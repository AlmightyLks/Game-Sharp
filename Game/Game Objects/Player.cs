using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Game.Game_Objects
{
    public partial class Player : UserControl
    {
        public Player()
        {
            InitializeComponent();
            // Make this false to allow threads to get it.
            CheckForIllegalCrossThreadCalls = false;
        }   

        public void MoveRight(int amount)
        {
            Location = new Point(Location.X + amount, Location.Y);
        }

        public void MoveLeft(int amount)
        {
            Location = new Point(Location.X - amount, Location.Y);
        }

        public void MoveUp(int amount)
        {
            Location = new Point(Location.X, Location.Y - amount);
        }

        public void MoveDown(int amount)
        {
            Location = new Point(Location.X, Location.Y + amount);
        }

    }
}
