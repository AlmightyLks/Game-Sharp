using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Game
{
    public partial class Form1 : Form
    {
        #region Drag From https://stackoverflow.com/a/1592899
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void AddDrag(Control c)
        {
            c.MouseDown += Form1_MouseDown;
        }

        #endregion

        Thread d { get; set; }

        public Form1()
        {
            InitializeComponent();
            AddDrag(button2);
            CheckForIllegalCrossThreadCalls = false;
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            d.Interrupt();
            Application.Exit();
        }

        private void GameArea_Paint(object sender, PaintEventArgs e)
        {
            d = new Thread(() =>
            {
                bool yee = true;
                while (yee)
                {
                        if (Keyboard.IsKeyDown(Key.W))
                            player1.MoveUp(4);
                        if (Keyboard.IsKeyDown(Key.A))
                            player1.MoveLeft(4);
                        if (Keyboard.IsKeyDown(Key.S))
                            player1.MoveDown(4);
                        if (Keyboard.IsKeyDown(Key.D))
                            player1.MoveRight(4);
                    try
                    {
                        Thread.Sleep(250);
                    }
                    catch
                    {
                        yee = false;
                    }
                }
            });
            d.SetApartmentState(ApartmentState.STA);
            d.Start();
        }
    }
}
