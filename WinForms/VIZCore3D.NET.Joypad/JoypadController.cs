using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SharpDX.XInput;

namespace VIZCore3D.NET.Joypad
{
    public class JoypadController
    {
        public bool IsConnected { get; set; }

        public bool EnableOption { get; set; }

        public event KeyDownEvent OnKeyDownEvent;
        public event ObjectSelectEvent OnObjectSelectEvent;

        public delegate void KeyDownEvent(object sender, EventArgs e);
        public delegate void ObjectSelectEvent(object sender, EventArgs e);

        public JoypadController()
        {
            IsConnected = false;
            EnableOption = false;
        }

        /// <summary>
        /// 패드 연결
        /// </summary>
        /// <returns></returns>
        public bool Connect(VIZCore3D.NET.VIZCore3DControl vizcore)
        {
            if (IsConnected)
                return true;

            var controllers = new[] { new Controller(UserIndex.One), new Controller(UserIndex.Two), new Controller(UserIndex.Three), new Controller(UserIndex.Four) };
            
            // Get 1st controller available
            Controller controller = null;
            foreach (var selectControler in controllers)
            {
                if (selectControler.IsConnected)
                {
                    controller = selectControler;
                    break;
                }
            }

            if (controller == null)
                return false;

            IsConnected = true;
            System.Threading.Tasks.Task task = new System.Threading.Tasks.Task(() =>
            {
                //이전 상태
                if (!IsConnected) return;

                bool bButtonADown = false;
                bool bButtonBDown = false;
                bool bButtonXDown = false;
                bool bButtonYDown = false;

                var previousState = controller.GetState();
                while (IsConnected && controller.IsConnected)
                {
                    var state = controller.GetState();
                    while (previousState.PacketNumber != state.PacketNumber)
                    {
                        if (!vizcore.Walkthrough.Avatar)
                        {
                            if (state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.Start))
                            {
                                //동기화 함수로 호출 필요
                                //vizcore.Walkthrough.Avatar = !vizcore.Walkthrough.Avatar;
                            }
                            break;
                        }
                        else
                        {
                            if (state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.Start))
                            {
                                if (OnObjectSelectEvent != null)
                                    OnObjectSelectEvent(this, new EventArgs());
                            }
                        }

                        float moveX = 0, moveY = 0, avatarRot = 0;
                        float rotateX = 0, rotateY = 0;

                        //이동
                        {
                            if (state.Gamepad.LeftThumbX > 0)
                            {
                                avatarRot = ((float)state.Gamepad.LeftThumbX / 32767.0f);
                            }
                            else if (state.Gamepad.LeftThumbX < 0)
                            {
                                avatarRot = ((float)state.Gamepad.LeftThumbX / 32768.0f);
                            }


                            if (state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadLeft))
                            {
                                moveX = 1.0f;
                            }

                            if (state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadRight))
                            {
                                moveX = -1.0f;
                            }

                            if (state.Gamepad.LeftThumbY > 0)
                            {
                                moveY = ((float)state.Gamepad.LeftThumbY / 32767.0f);
                            }
                            else if (state.Gamepad.LeftThumbY < 0)
                            {
                                moveY = ((float)state.Gamepad.LeftThumbY / 32768.0f);
                            }

                            vizcore.Walkthrough.Move(moveY, moveX);
                            vizcore.Walkthrough.Rotate(avatarRot * -1.0f);
                        }



                        // 회전
                        {
                            if (state.Gamepad.RightThumbX > 0)
                            {
                                rotateX = ((float)state.Gamepad.RightThumbX / 32767.0f);
                            }
                            else if (state.Gamepad.RightThumbX < 0)
                            {
                                rotateX = ((float)state.Gamepad.RightThumbX / 32768.0f);
                            }

                            if (state.Gamepad.RightThumbY > 0)
                            {
                                rotateY = ((float)state.Gamepad.RightThumbY / 32767.0f);
                            }
                            else if (state.Gamepad.RightThumbY < 0)
                            {
                                rotateY = ((float)state.Gamepad.RightThumbY / 32768.0f);
                            }

                            vizcore.Walkthrough.ViewRotate(rotateY * -1.0f, rotateX * -1.0f);
                        }

                        //Up
                        {
                            if (state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadUp))
                            {
                                vizcore.Walkthrough.Up(1.0f);
                            }

                            if (state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadDown))
                            {
                                vizcore.Walkthrough.Up(-1.0f);
                            }
                        }

                        // 숙임
                        if (state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.A))
                        {
                            if (!bButtonADown)
                            {
                                bButtonADown = true;
                                vizcore.Walkthrough.UseAvatarBowWalk = !vizcore.Walkthrough.UseAvatarBowWalk;

                                if (OnKeyDownEvent != null)
                                    OnKeyDownEvent(this, new EventArgs());
                            }
                        }
                        else
                        {
                            bButtonADown = false;
                        }

                        // 충돌
                        if (state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.B))
                        {
                            if (!bButtonBDown)
                            {
                                bButtonBDown = true;
                                vizcore.Walkthrough.UseAvatarCollision = !vizcore.Walkthrough.UseAvatarCollision;

                                if (OnKeyDownEvent != null)
                                    OnKeyDownEvent(this, new EventArgs());
                            }
                        }
                        else
                        {
                            bButtonBDown = false;
                        }

                        // 전체 활성화 / 비활성화
                        if (state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.X))
                        {
                            if (!bButtonXDown)
                            {
                                bButtonXDown = true;

                                EnableOption = !EnableOption;
                                vizcore.Walkthrough.UseAvatarGravity = EnableOption;
                                vizcore.Walkthrough.UseAvatarCollision = EnableOption;
                                vizcore.Walkthrough.UseAvatarBowWalk = EnableOption;

                                if (OnKeyDownEvent != null)
                                    OnKeyDownEvent(this, new EventArgs());
                            }
                        }
                        else
                        {
                            bButtonXDown = false;
                        }

                        // 중력
                        if (state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.Y))
                        {
                            if (!bButtonYDown)
                            {
                                bButtonYDown = true;
                                vizcore.Walkthrough.UseAvatarGravity = !vizcore.Walkthrough.UseAvatarGravity;

                                if (OnKeyDownEvent != null)
                                    OnKeyDownEvent(this, new EventArgs());
                            }
                        }
                        else
                        {
                            bButtonYDown = false;
                        }

                        break;
                    }
                    previousState = state;
                }
            });
            task.Start();

            return true;
        }

        /// <summary>
        /// 연결해제
        /// </summary>
        public void Disconnected()
        {
            IsConnected = false;
        }
    }
}
