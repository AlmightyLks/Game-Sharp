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
        private int movementSpeed;

        /// <summary>
        /// The player's movement speed in milliseconds
        /// </summary>
        public int MovementSpeed { get => movementSpeed; set => movementSpeed = value; }

        /// <summary>
        /// Standard constructor
        /// </summary>
        public Player()
        {
            InitializeComponent();
            // Make this false to allow threads to get it.
            CheckForIllegalCrossThreadCalls = false;
            MovementSpeed = 250;
        }   

        /// <summary>
        /// Move the Player Object to the right
        /// </summary>
        /// <param name="amount">Amount of units to move</param>
        public void MoveRight(int amount)
        {
            Location = new Point(Location.X + amount, Location.Y);
        }

        /// <summary>
        /// Move the Player Object to the left
        /// </summary>
        /// <param name="amount">Amount of units to move</param>
        public void MoveLeft(int amount)
        {
            Location = new Point(Location.X - amount, Location.Y);
        }

        /// <summary>
        /// Move the Player Object up
        /// </summary>
        /// <param name="amount">Amount of units to move</param>
        public void MoveUp(int amount)
        {
            Location = new Point(Location.X, Location.Y - amount);
        }

        /// <summary>
        /// Move the Player Object down
        /// </summary>
        /// <param name="amount">Amount of units to move</param>
        public void MoveDown(int amount)
        {
            Location = new Point(Location.X, Location.Y + amount);
        }
    }
}
