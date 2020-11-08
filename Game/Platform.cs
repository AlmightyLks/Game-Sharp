using Game.Models;
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
    public partial class Platform : Form
    {
        /// <summary>
        /// The thread listening to the player's movement input
        /// </summary>
        private Thread movementThread;

        #region Drag From https://stackoverflow.com/a/1592899
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void GameArea_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void AddDrag(Control c)
        {
            c.MouseDown += GameArea_MouseDown;
        }
        #endregion

        /// <summary>
        /// Standard constructor
        /// </summary>
        public Platform()
        {
            InitializeComponent();
            AddDrag(DragPanel);
            CheckForIllegalCrossThreadCalls = false;
        }

        /// <summary>
        /// This event-method is fired when the user presses the ExitButton in the upper-right corner of the window
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">EventArgs</param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            movementThread.Interrupt();
            Environment.Exit(0);
        }
        /// <summary>
        /// This event-method is fired when the Platform is loaded
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">EventArgs</param>
        private void Platform_Load(object sender, EventArgs e)
        {
            movementThread = new Thread(() =>
            {
                bool valid = true;
                do
                {
                    if (Keyboard.IsKeyDown(Key.W))
                        PlayerObj.ChangePosition(Directions.Up, 4);
                    if (Keyboard.IsKeyDown(Key.A))
                        PlayerObj.ChangePosition(Directions.Left, 4);
                    if (Keyboard.IsKeyDown(Key.S))
                        PlayerObj.ChangePosition(Directions.Down, 4);
                    if (Keyboard.IsKeyDown(Key.D))
                        PlayerObj.ChangePosition(Directions.Right, 4);

                    try
                    {
                        Thread.Sleep(PlayerObj.MovementSpeed);
                    }
                    catch
                    {
                        valid = false;
                    }
                } while (valid);
            });
            movementThread.SetApartmentState(ApartmentState.STA);
            movementThread.Start();
        }
    }
}
