using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VIZCore3D.NET.BayBlock
{
    public partial class OutlinePathDrawingControl : UserControl
    {
        public VIZCore3D.NET.VIZCore3DControl VIZCore { get; set; }

        /// <summary>
        /// 아이템 드래그앤 드롭 상태
        /// </summary>
        public bool ItemDragState { get; set; }

        /// <summary>
        /// 아이템 드래그앤 드롭 View 외부시작 여부
        /// </summary>
        public bool ItemDragViewDrawingEnter { get; set; }

        /// <summary>
        /// 아이템 외곽 정보
        /// </summary>
        public List<BlockOutlinePath> ITEM_OUTLINE_DATA { get; set; }

        #region Width, Height, Block Offset
        internal int blockWidthOffset = 10;
        internal int blockHeightOffset = 5;
        public int ContentWidth
        {
            get
            {
                return this.Size.Width - scrollBar.Width;
            }
        }
        public int ContentHeight
        {
            get
            {
                return this.Size.Height;
            }
        }
        #endregion

        internal Size _ItemSize = Size.Empty;
        /// <summary>
        /// 아이템 크기
        /// </summary>
        public Size ItemSize
        {
            get
            {
                if(_ItemSize == Size.Empty)
                {
                    if (ITEM_OUTLINE_DATA.Count == 0)
                        return ItemBaseSize;

                    // GetDrawPoint 올바른 계산 위해선 Zoom, ScreenSize 가 업데이트되여야 함.
                    ITEM_OUTLINE_DATA.ForEach(item =>
                    {
                        item.Zoom = CameraZoom;
                        item.ScreenSize = ModelViewScreenSize;
                    });

                    // 모든블럭의 최대 크기 계산.
                    var allPoints = ITEM_OUTLINE_DATA.SelectMany(t => t.GetDrawPoint()).ToArray();
                    float pointOffset = 5.0f; // Point 길이 Offset
                    var xLength = allPoints.Max(t => t.X) - allPoints.Min(t => t.X) + pointOffset;
                    var yLength = allPoints.Max(t => t.Y) - allPoints.Min(t => t.Y) + pointOffset;

                    float scaleMinValue = 0.5f;
                    //float scaleMaxValue = 5.0f;

                    //Control 크기 비례
                    int controlSizeMinValue = Math.Min(ContentWidth, ContentHeight) - (blockWidthOffset * 2);
                    if (controlSizeMinValue < 0)
                        controlSizeMinValue = 1;

                    // BlockBaseSize 의 사이즈 0.5배보다는 커야 하고 최대 한칸 너비보단 작게 설정한다.
                    var x = Math.Max(xLength, ItemBaseSize.Width * scaleMinValue); //Scale 최소값
                    x = Math.Min(x, controlSizeMinValue); //Scale 최대값
                    var y = Math.Max(yLength, ItemBaseSize.Height * scaleMinValue); //Scale 최소값
                    y = Math.Min(y, controlSizeMinValue); //Scale 최대값

                    float currentScale = Math.Max(x, y);

                    _ItemSize = new Size((int)(currentScale), (int)((float)currentScale));

                    // 해당 블럭 사이즈 업데이트
                    ITEM_OUTLINE_DATA.ForEach(item =>
                    {
                        item.BlockItemSize = ItemSize;
                    });
                }

                return _ItemSize;
            }
            set
            {
                _ItemSize = value;
            }
        }

        /// <summary>
        /// 아이템 기준 크기
        /// </summary>
        public Size ItemBaseSize { get; set; }

        /// <summary>
        /// 아이템 배율
        /// </summary>
        public float ItemScale { get; set; }

        /// <summary>
        /// 가로 기준 아이템 표시 개수
        /// </summary>
        public int CountPerHorizontal { get; set; }

        /// <summary>
        /// 가로 여백
        /// </summary>
        public int HorizontalMargine { get; set; }

        /// <summary>
        /// 세로 기준 위치
        /// </summary>
        public int VerticalReferencePosition { get; set; }

        internal float _CameraZoom = 1.0f;
        /// <summary>
        /// Camera Zoom Ration
        /// </summary>
        public float CameraZoom
        {
            get
            {
                return _CameraZoom;
            }
            set
            {
                if (_CameraZoom == value) return;

                _CameraZoom = value;
                ItemSize = Size.Empty;
            }
        }

        public BlockOutlinePath SelectedItem { get; set; }
        internal Point _MouseDownPoint { get; set; }

        /// <summary>
        /// ModelView ScreenSize Item Drawing 
        /// </summary>
        public SizeF ModelViewScreenSize { get; set; }

        // 텍스트 글꼴 크기
        public int ItemFontSize { get; set; } = 10;

        /// <summary>
        /// 블록 글꼴 색상
        /// </summary>
        public System.Drawing.Color ItemFontColor { get; set; } = System.Drawing.Color.Black;

        /// <summary>
        /// 선택 항목 배경 색상
        /// </summary>
        public System.Drawing.Color FocusedBackColor { get; set; } = System.Drawing.Color.Yellow;

        /// <summary>
        /// 블록 외곽라인 그리기 여부
        /// </summary>
        public bool ShowItemRectangle { get; set; } = true;

        public OutlinePathDrawingControl()
        {
            InitializeComponent();

            this.Dock = DockStyle.Fill;
            this.BackColor = Color.White;
            this.AllowDrop = true;
            this.DoubleBuffered = true;

            ItemBaseSize = new Size(150, 150);
            ItemSize = new Size(150, 150);

            this.scrollBar.SmallChange = ItemSize.Height;

            //==============================================================
            // 테스트 데이터 생성
            //string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            //string file = System.IO.Path.Combine(path, "PATHDATA.xml");
            //DataSet ds = new DataSet();
            //ds.ReadXml(file);

            //foreach (DataRow item in ds.Tables[0].Rows)
            //{
            //    BlockOutlinePath data = new BlockOutlinePath(item, new Size(150, 150));
            //    ITEM_OUTLINE_DATA.Add(data);
            //}
            //==============================================================


            ITEM_OUTLINE_DATA = new List<BlockOutlinePath>();


            // 이벤트 정의
            this.Paint += OutlinePathDrawingControl_Paint;
            this.Resize += OutlinePathDrawingControl_Resize;
            this.scrollBar.Scroll += ScrollBar_Scroll;
            this.MouseEnter += OutlinePathDrawingControl_MouseEnter;
            this.MouseWheel += OutlinePathDrawingControl_MouseWheel;
            this.MouseClick += OutlinePathDrawingControl_MouseClick;
            this.MouseDoubleClick += OutlinePathDrawingControl_MouseDoubleClick;
            this.MouseDown += OutlinePathDrawingControl_MouseDown;
            this.MouseMove += OutlinePathDrawingControl_MouseMove;
            this.MouseUp += OutlinePathDrawingControl_MouseUp;
            this.GiveFeedback += OutlinePathDrawingControl_GiveFeedback;
            this.DragEnter += OutlinePathDrawingControl_DragEnter;
            this.DragDrop += OutlinePathDrawingControl_DragDrop;
        }

        public void AddItem(string name, string pathData, float length, float width, float height)
        {
            ITEM_OUTLINE_DATA.Add(new BlockOutlinePath(name, pathData, length, width, height, new Size(150, 150)));

            Invalidate();
        }

        public void SetOutlineData(List<BlockOutlinePath> items)
        {
            ITEM_OUTLINE_DATA = items;
            Invalidate();
        }

        private void OutlinePathDrawingControl_Paint(object sender, PaintEventArgs e)
        {
            if (ITEM_OUTLINE_DATA == null || ITEM_OUTLINE_DATA.Count == 0) return;

            int blockWidthInterval = ItemSize.Width + blockWidthOffset;
            int blockHeightInterval = ItemSize.Height + blockHeightOffset;

            CountPerHorizontal = ContentWidth / blockWidthInterval;
            HorizontalMargine = ContentWidth % blockWidthInterval;
            int countPerVertical = ContentHeight / blockHeightInterval; //현재 화면에 그려지는 세로 개수

            foreach (BlockOutlinePath item in ITEM_OUTLINE_DATA)
            {
                item.Visible = false;
                item.Position = Point.Empty;
                item.ItemRectangle = Rectangle.Empty;
            }

            if (CountPerHorizontal > 0 && countPerVertical > 0)
            {
                int ScrollbarValue = scrollBar.Value;

                //이전 스크롤 위치 비율
                float oldScrollbar = 0.0f;
                if (scrollBar.Maximum > 0)
                    oldScrollbar = (float)scrollBar.Value / (float)scrollBar.Maximum;

                //Scrol Max 구하기
                int scrollbar_maximum = Math.Max((((ITEM_OUTLINE_DATA.Count() / CountPerHorizontal) - (countPerVertical - 1)) * blockHeightInterval), 0);

                if (scrollbar_maximum > 0)
                    scrollbar_maximum += 5; //Bottom 여유 공간

                scrollBar.Maximum = scrollbar_maximum;

                //현재 위치로 변경
                if (scrollbar_maximum > 0)
                    ScrollbarValue = (int)(oldScrollbar * (float)scrollbar_maximum);

                if (ScrollbarValue > scrollbar_maximum)
                    ScrollbarValue = Math.Max(scrollbar_maximum, 0);

                scrollBar.Value = ScrollbarValue;

                int heightNum = Math.Max((ScrollbarValue / blockHeightInterval), 0);
                int i = heightNum * CountPerHorizontal; //Block Item 시작
                int drawPos = heightNum * blockHeightInterval; //Scrollbar 그리기 시작위치

                // Mode : Anti Alias
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                //가운데 정렬
                var woffset = (ContentWidth - (CountPerHorizontal * ItemSize.Width)) * 1.0f / (CountPerHorizontal + 1);
                woffset = Math.Max(woffset, blockWidthOffset);

                int VerticalPosition = 0;
                //item[i]의 현재 화면재 걸치는 item 추가로 2개 더 그리기
                for (int draw = 0; draw < countPerVertical + 2; draw++) //세로
                {
                    for (int j = 0; j < CountPerHorizontal; j++, i++) //가로
                    {
                        if (i >= ITEM_OUTLINE_DATA.Count()) break;

                        BlockOutlinePath item = ITEM_OUTLINE_DATA.ElementAt(i);

                        int xPt = j * ItemSize.Width + (j + 1) * (int)woffset; //좌측 offset
                        int yPt = blockHeightOffset * 2 + drawPos + VerticalPosition - scrollBar.Value;

                        // 그릴위치 업데이트
                        item.Position = new Point(xPt, yPt);
                        item.ItemRectangle = new System.Drawing.Rectangle(
                                xPt, yPt
                                , item.BlockItemSize.Width
                                , item.BlockItemSize.Height
                                );

                        DrawItem(e.Graphics, item);
                    }

                    VerticalPosition += blockHeightInterval;
                }
            }
        }

        internal void DrawItem(System.Drawing.Graphics g, BlockOutlinePath block)
        {
            // 상태 변경
            Visible = true;

            if (block.Focused == true)
            {
                using (var brush = new SolidBrush(FocusedBackColor))
                {
                    g.FillRectangle(brush, block.ItemRectangle);
                }
            }

            if (ShowItemRectangle == true)
            {
                if (block.Focused != true)
                {
                    using (var brush = BackgroundBrush(block.ItemRectangle))
                    {
                        g.FillRectangle(brush, block.ItemRectangle);
                    }
                }

                g.DrawRectangle(
                    System.Drawing.Pens.LightGray
                    , block.ItemRectangle
                    );
            }

            System.Drawing.PointF[] drawPoint = block.GetDrawPoint()
                .Select(t => {
                    //위치보정
                    t.X += block.Position.X;
                    t.Y += block.Position.Y;

                    //외곽 테두리 넘는 것을 방지.
                    t.X = Math.Max(t.X, block.ItemRectangle.Left);
                    t.X = Math.Min(t.X, block.ItemRectangle.Right);

                    t.Y = Math.Max(t.Y, block.ItemRectangle.Top);
                    t.Y = Math.Min(t.Y, block.ItemRectangle.Bottom);
                    return t;

                }).ToArray();

            if (drawPoint.Length > 0)
            {
                g.FillPolygon(Brushes.Lime, drawPoint);
                g.DrawPolygon(Pens.Black, drawPoint);
            }

            // 텍스트 그리기
            // Create font and brush.
            System.Drawing.Font drawFont = new System.Drawing.Font("Arial", ItemFontSize);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(ItemFontColor);

            // Set format of string.
            System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();
            drawFormat.FormatFlags = System.Drawing.StringFormatFlags.DisplayFormatControl;
            drawFormat.LineAlignment = System.Drawing.StringAlignment.Center;
            drawFormat.Alignment = System.Drawing.StringAlignment.Center;



            // 텍스트 그림자
            //g.SmoothingMode = SmoothingMode.AntiAlias;
            //using (GraphicsPath path = GetStringPath(block.NOTE_TEXT_NONASSIGN, g.DpiY, block.ItemRectangle, drawFont, drawFormat))
            //{
            //    Pen p = new Pen(Color.FromArgb(180,255,255,255));
            //    p.Width = 2;
            //    g.DrawPath(p, path);
            //    p.Dispose();
            //}
            //g.SmoothingMode = SmoothingMode.Default;

            // 텍스트
            g.DrawString(block.GetLabel(), drawFont, drawBrush, block.ItemRectangle, drawFormat);

            drawFont.Dispose();
            drawBrush.Dispose();
            drawFormat.Dispose();
        }

        private System.Drawing.Drawing2D.GraphicsPath GetStringPath(string s, float dpi, RectangleF rect, Font font, StringFormat format)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            float emSize = dpi * font.SizeInPoints / 72;
            path.AddString(s, font.FontFamily, (int)font.Style, emSize, rect, format);
            return path;
        }

        System.Drawing.Drawing2D.ColorBlend _colorBlend = null;
        public Brush BackgroundBrush(RectangleF rect)
        {
            if (_colorBlend == null)
            {
                _colorBlend = new System.Drawing.Drawing2D.ColorBlend();
                _colorBlend.Positions = new[] { 0, 0.1f, 1 };
                _colorBlend.Colors = new[] { Color.FromArgb(255, 255, 255, 255), Color.FromArgb(255, 248, 248, 248), Color.FromArgb(255, 240, 240, 240) };
            }
            return new System.Drawing.Drawing2D.LinearGradientBrush(rect, _colorBlend.Colors[0], _colorBlend.Colors[2], 90, true);
        }

        private void OutlinePathDrawingControl_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void ScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.OldValue == e.NewValue)
                return;

            Invalidate();
        }

        private void OutlinePathDrawingControl_MouseEnter(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void OutlinePathDrawingControl_MouseWheel(object sender, MouseEventArgs e)
        {
            int max = scrollBar.Maximum;
            int min = scrollBar.Minimum;
            int offset = scrollBar.SmallChange;
            int oldValue = scrollBar.Value;
            int newValue = 0;

            if (e.Delta > 0)
            {
                newValue = oldValue - offset;
            }
            else
            {
                newValue = oldValue + offset;
            }

            if (newValue <= max && newValue >= min)
            {
                scrollBar.Value = newValue;
                Invalidate();
            }
            else if (newValue > max)
            {
                scrollBar.Value = max;
                Invalidate();
            }
            else if (newValue < min)
            {
                scrollBar.Value = min;
                Invalidate();
            }
        }

        private void OutlinePathDrawingControl_MouseClick(object sender, MouseEventArgs e)
        {
            if (SelectedItem == null) return;
        }

        private void OutlinePathDrawingControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (SelectedItem == null) return;

            MessageBox.Show(SelectedItem.GetLabel());
        }

        private void OutlinePathDrawingControl_MouseDown(object sender, MouseEventArgs e)
        {
            SelectedItem = null;
            _MouseDownPoint = new Point(e.X, e.Y);

            foreach (BlockOutlinePath item in ITEM_OUTLINE_DATA)
            {
                item.Visible = false;
                if (item.ItemRectangle.Contains(e.X, e.Y) == true)
                {
                    item.Focused = true;
                    SelectedItem = item;

                    System.Diagnostics.Debug.WriteLine(string.Format("Mouse Down : {0}-{1}", item.SHIP_NO, item.BLOCK));
                }
                else
                {
                    item.Focused = false;
                }
            }

            Invalidate();
        }

        private void OutlinePathDrawingControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            if (SelectedItem == null) return;

            ItemDragState = true;
            ItemDragViewDrawingEnter = false;

            this.DoDragDrop(SelectedItem, DragDropEffects.Copy);
        }

        private void OutlinePathDrawingControl_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void OutlinePathDrawingControl_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {
        }

        private void OutlinePathDrawingControl_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void OutlinePathDrawingControl_DragDrop(object sender, DragEventArgs e)
        {
            object dragItem = null;

            string[] dragItemFormat = e.Data.GetFormats(true);
            if (dragItemFormat != null && dragItemFormat.Length == 1)
            {
                dragItem = e.Data.GetData(dragItemFormat[0]);
            }

            if (dragItem == null) return;

            if (dragItem is BlockOutlinePath) return;

            List<int> Node = (List<int>)dragItem;
            if (Node.Count == 0) return;

            RefreshData();
        }


        public void RefreshData()
        {
            ITEM_OUTLINE_DATA = null;
            Invalidate();
        }

        public void SetItemDrawingRatio(float fScale, SizeF worldSize, Size screenSize)
        {
            // Block Base 기준으로 크기 변경
            //float currentScale = 1.0f / fScale;
            //currentScale = Math.Max(currentScale, 0.5f); //Scale 최소값
            //currentScale = Math.Min(currentScale, 5.0f); //Scale 최대값

            CameraZoom = Math.Max(worldSize.Width, worldSize.Height);
            ModelViewScreenSize = screenSize;

            Invalidate();
        }
    }
}
