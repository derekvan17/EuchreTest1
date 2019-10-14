using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EuchreTest1.ImportDLL;
using static EuchreTest1.Dealer;

namespace EuchreTest1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dealer.Deal();
            GetImages();
        }

        public void GetImages()
        {
            pictureBox1.Image = images[PlayersCards()[0]];
            pictureBox2.Image = images[PlayersCards()[1]];
            pictureBox3.Image = images[PlayersCards()[2]];
            pictureBox4.Image = images[PlayersCards()[3]];
            pictureBox5.Image = images[PlayersCards()[4]];
            pictureBox6.Image = images[32];
            pictureBox7.Image = images[32];
            pictureBox8.Image = images[32];
            pictureBox9.Image = images[32];
            pictureBox10.Image = images[32];
            pictureBox11.Image = images[32];
            pictureBox12.Image = images[32];
            pictureBox13.Image = images[32];
            pictureBox14.Image = images[32];
            pictureBox15.Image = images[32];
            pictureBox16.Image = images[32];
            pictureBox17.Image = images[32];
            pictureBox18.Image = images[32];
            pictureBox19.Image = images[32];
            pictureBox20.Image = images[32];
            pictureBox21.Image = images[FaceCard()];
            pictureBox22.Image = images[32];

        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            Console.Write(Ranks.cards.value[PlayersCards()[0]]);
            //Console.WriteLine("-" + Suits.WhichSuit(PlayersCards()[0]));
            Console.WriteLine("-" + Ranks.cards.suit[PlayersCards()[0]]);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Console.Write(Ranks.cards.value[PlayersCards()[1]]);
            //Console.WriteLine("-" + Suits.WhichSuit(PlayersCards()[0]));
            Console.WriteLine("-" + Ranks.cards.suit[PlayersCards()[1]]);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Console.Write(Ranks.cards.value[PlayersCards()[2]]);
            //Console.WriteLine("-" + Suits.WhichSuit(PlayersCards()[0]));
            Console.WriteLine("-" + Ranks.cards.suit[PlayersCards()[2]]);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Console.Write(Ranks.cards.value[PlayersCards()[3]]);
            //Console.WriteLine("-" + Suits.WhichSuit(PlayersCards()[0]));
            Console.WriteLine("-" + Ranks.cards.suit[PlayersCards()[3]]);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Console.Write(Ranks.cards.value[PlayersCards()[4]]);
            //Console.WriteLine("-" + Suits.WhichSuit(PlayersCards()[0]));
            Console.WriteLine("-" + Ranks.cards.suit[PlayersCards()[4]]);
        }
    }
}
