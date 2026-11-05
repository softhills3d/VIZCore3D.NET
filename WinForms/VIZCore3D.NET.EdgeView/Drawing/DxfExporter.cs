using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using VIZCore3D.NET.Data;

namespace VIZCore3D.NET.EdgeView.Drawing
{
    /// <summary>DXF R12 (AC1009) ASCII 내보내기 - 레이어 / 선종류 포함</summary>
    public static class DxfExporter
    {
        static readonly CultureInfo Inv = CultureInfo.InvariantCulture;

        static string Layer(ProjectionLineKind k)
        {
            switch (k)
            {
                case ProjectionLineKind.OUTER: return "OUTER";
                case ProjectionLineKind.INNER: return "INNER";
                case ProjectionLineKind.FEATURE: return "EDGE";
                case ProjectionLineKind.SILHOUETTE: return "SILHOUETTE";
                case ProjectionLineKind.HIDDEN: return "HIDDEN";
                case ProjectionLineKind.CENTER: return "CENTER";
                default: return "DIMENSION";
            }
        }

        public static void Export(List<EdgeProjectionResult> views, string path)
        {
            var sb = new StringBuilder();
            System.Action<int, string> w = (code, val) => { sb.Append(code).Append("\r\n").Append(val).Append("\r\n"); };
            System.Action<int, double> wd = (code, val) => w(code, val.ToString("0.######", Inv));

            // HEADER
            w(0, "SECTION"); w(2, "HEADER");
            w(9, "$ACADVER"); w(1, "AC1009");
            w(9, "$INSUNITS"); w(70, "4");
            w(0, "ENDSEC");

            // TABLES
            w(0, "SECTION"); w(2, "TABLES");
            w(0, "TABLE"); w(2, "LTYPE"); w(70, "3");
            LType(w, wd, "CONTINUOUS", "Solid line", new double[0]);
            LType(w, wd, "DASHED", "__ __ __", new double[] { 6, -3 });
            LType(w, wd, "CENTER", "____ _ ____", new double[] { 12, -3, 2, -3 });
            w(0, "ENDTAB");

            w(0, "TABLE"); w(2, "LAYER"); w(70, "7");
            LayerDef(w, "OUTER", 7, "CONTINUOUS");
            LayerDef(w, "INNER", 5, "CONTINUOUS");
            LayerDef(w, "EDGE", 8, "CONTINUOUS");
            LayerDef(w, "SILHOUETTE", 3, "CONTINUOUS");
            LayerDef(w, "HIDDEN", 9, "DASHED");
            LayerDef(w, "CENTER", 1, "CENTER");
            LayerDef(w, "DIMENSION", 4, "CONTINUOUS");
            w(0, "ENDTAB");
            w(0, "ENDSEC");

            // ENTITIES
            w(0, "SECTION"); w(2, "ENTITIES");
            foreach (var v in views)
            {
                foreach (var l in v.Lines)
                {
                    w(0, "LINE"); w(8, Layer(l.Kind));
                    wd(10, l.Start.X); wd(20, l.Start.Y); wd(30, 0);
                    wd(11, l.End.X); wd(21, l.End.Y); wd(31, 0);
                }
                foreach (var t in v.Texts)
                {
                    w(0, "TEXT"); w(8, Layer(t.Kind));
                    wd(10, t.Position.X); wd(20, t.Position.Y); wd(30, 0);
                    wd(40, t.Height);
                    w(1, t.Text.Replace("Ø", "%%c"));
                    if (t.Angle != 0) wd(50, t.Angle);
                    int h = t.Align == ProjectionTextAlign.LEFT ? 0 : t.Align == ProjectionTextAlign.RIGHT ? 2 : 1;
                    w(72, h.ToString()); w(73, "2");
                    wd(11, t.Position.X); wd(21, t.Position.Y); wd(31, 0);
                }
            }
            w(0, "ENDSEC");
            w(0, "EOF");

            File.WriteAllText(path, sb.ToString(), Encoding.Default);
        }

        static void LType(System.Action<int, string> w, System.Action<int, double> wd, string name, string desc, double[] pat)
        {
            double total = 0;
            foreach (var p in pat) total += System.Math.Abs(p);
            w(0, "LTYPE"); w(2, name); w(70, "0"); w(3, desc); w(72, "65");
            w(73, pat.Length.ToString()); wd(40, total);
            foreach (var p in pat) wd(49, p);
        }

        static void LayerDef(System.Action<int, string> w, string name, int color, string ltype)
        {
            w(0, "LAYER"); w(2, name); w(70, "0"); w(62, color.ToString()); w(6, ltype);
        }
    }
}
