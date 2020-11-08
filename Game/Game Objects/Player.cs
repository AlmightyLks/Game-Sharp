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
using Game.Models;
using Game.Helper;

namespace Game.Game_Objects
{
    public partial class Player : UserControl
    {
        /// <summary>
        /// The player's movement speed - delay in milliseconds, the lower, the faster
        /// </summary>
        public int MovementSpeed { get; set; }

        /// <summary>
        /// Standard constructor
        /// </summary>
        public Player()
        {
            InitializeComponent();
            // Make this false to allow threads to get it.
            CheckForIllegalCrossThreadCalls = false;
            MovementSpeed = 10;
        }
        
        /// <summary>
        /// Move the player in the desired direction by the specified amount of units
        /// </summary>
        /// <param name="directions">Direction</param>
        /// <param name="amount">Amoung</param>
        public void ChangePosition(Directions directions, int amount = 4)
        {
            Point newLocation = Location;
            int i = default;

            switch (directions)
            {
                case Directions.Up:
                    for (i = 0; i < amount; i++)
                    {
                        Location = new Point(Location.X, Location.Y - i);
                    }
                    break;
                case Directions.Down:
                    for (i = 0; i < amount; i++)
                    {
                        Location = new Point(Location.X, Location.Y + i);
                    }
                    break;
                case Directions.Left:
                    for (i = 0; i < amount; i++)
                    {
                        Location = new Point(Location.X - i, Location.Y);
                    }
                    break;
                case Directions.Right:
                    for (i = 0; i < amount; i++)
                    {
                        Location = new Point(Location.X + i, Location.Y);
                    }
                    break;
            }
        }
    }
}
