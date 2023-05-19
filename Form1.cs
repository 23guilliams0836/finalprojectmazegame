using mazegamefinalproj.Properties;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing.Text;
using System.Timers;
using System.Xml.Linq;
using Timer = System.Timers.Timer;

namespace mazegamefinalproj
{
    public partial class Form1 : Form
    {
        public int totalSplunders = 0;
        public int roomSplunders = 0;
        bool lost = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            lblGame.Text = "";
            btnLeft.Visible = true;
            btnForward.Visible = true;
            btnRight.Visible = true;
            btnStart.Visible = false;
            Plunder();
        }
        private void btnForward_Click(object sender, EventArgs e)
        {
            Plunder();
        }
        private void btnLeft_Click(object sender, EventArgs e)
        {
            Plunder();
        }
        private void btnRight_Click(object sender, EventArgs e)
        {
            Plunder();
        }

        void Plunder()
        {
            Room nextRoom = GetNextRoom();
            pictureBox1.Image = nextRoom.img;
            btnLeft.Enabled = nextRoom.hasLeft;
            btnForward.Enabled = nextRoom.hasStraight;
            btnRight.Enabled = nextRoom.hasRight;
            nextRoom.FindTreasure();
            roomSplunders = nextRoom.FindTreasure();
            totalSplunders += roomSplunders;
            lblSplunders.Text = "Total Splunders: " + totalSplunders.ToString();
            SplunderFlare();
            if (lost == true)
            {
                Loser();
            }
        }
        public async void SplunderFlare()
        {
            Random r = new Random();
            lblSplunderFlare.Text = "+" + roomSplunders.ToString() + " SPLUNDERS";
            lblSplunderFlare.Location = new Point(r.Next(98, 469), r.Next(54, 435));
            lblSplunderFlare.Visible = true;
            var timer = new Timer(500);
            timer.Elapsed += async (sender, e) => await HandleTimer(lblSplunderFlare);
            timer.AutoReset = false;
            timer.Start();
        }
        private static Task HandleTimer(Label l)
        {
            l.Visible = false;
            return Task.CompletedTask;
        }
        public Room GetNextRoom()
        {
            Random r = new Random();
            int x = r.Next(0,9);
            switch(x)
            {
                case 0: return new RoomStraight();
                case 1: return new RoomLeft();
                case 2: return new RoomRight();
                case 3: return new RoomLeftStraight();
                case 4: return new RoomRightStraight();
                case 5: return new RoomLeftRight();
                case 6: return new RoomLeftRightStraight();
                case 7: return new RoomLootRoom();
                case 8: lost = true;
                    return new RoomDeadEnd();
                default: return new RoomStraight();
            }
        }
        public void Loser()
        {
            lblGame.Text = "As the walls close behind you, the realization sets in.\n You will forever be trapped in this maze";
            btnForward.Visible = false;
            btnLeft.Visible = false;
            btnRight.Visible = false;
            button1.Visible = true;
        }

        #region room definitions
        public abstract class Room
        {
            public Image img;
            public bool hasLeft;
            public bool hasStraight;
            public bool hasRight;
            public int minLoot = 0, maxLoot = 10;
            public Room(Image img, bool hasLeft, bool hasStraight, bool hasRight, int minLoot, int maxLoot)
            {
                this.img = img;
                this.hasLeft = hasLeft;
                this.hasStraight = hasStraight;
                this.hasRight = hasRight;
                this.minLoot = minLoot;
                this.maxLoot = maxLoot;
            }
            public virtual int FindTreasure()
            {
                Random r = new Random();
                int Splunders = r.Next(minLoot, maxLoot);
                return Splunders;
            }
        }
        public class RoomStraight : Room
        {
            public RoomStraight() : base(Resources.mazeI, false, true, false, 1, 10)
            {

            }
        }
        public class RoomLeft : Room
        {
            public RoomLeft() : base(Resources.mazeL, true, false, false, 1, 5)
            {

            }
        }
        public class RoomRight : Room
        {
            public RoomRight() : base(Resources.mazeR, false, false, true, 1, 5)
            {

            }
        }
        public class RoomLeftStraight : Room
        {
            public RoomLeftStraight() : base(Resources.maze_I, true, true, false, 5, 7)
            {

            }
        }
        public class RoomRightStraight : Room
        {
            public RoomRightStraight() : base(Resources.mazeI_, false, true, true, 5, 7)
            {

            }
        }
        public class RoomLeftRight : Room
        {
            public RoomLeftRight() : base(Resources.mazeT, true, false, true, 9, 15)
            {

            }
        }
        public class RoomLeftRightStraight : Room
        {
            public RoomLeftRightStraight() : base(Resources.maze_, true, true, true, 1, 17)
            {

            }
        }
        public class RoomLootRoom : Room
        {
            public RoomLootRoom() : base(Resources.lootroom, false, true, false, 30, 55)
            {

            }
        }
        public class RoomDeadEnd : Room 
        {
            public RoomDeadEnd() : base(Resources.mazedeadend, false, false, false, 0, 0)
            {

            }
            public override int FindTreasure()
            {
                return 0;
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            scores scoreWindow;
            scoreWindow = new scores(totalSplunders);
            scoreWindow.Show();
        }
    }
}