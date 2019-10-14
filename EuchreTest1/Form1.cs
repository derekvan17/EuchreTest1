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
            pictureBox1.Image = images[Dealer.PlayersCards()[0]];
            pictureBox2.Image = images[Dealer.PlayersCards()[1]];
            pictureBox3.Image = images[Dealer.PlayersCards()[2]];
            pictureBox4.Image = images[Dealer.PlayersCards()[3]];
            pictureBox5.Image = images[Dealer.PlayersCards()[4]];
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
            pictureBox21.Image = images[Dealer.FaceCard()];
            pictureBox22.Image = images[32];

        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Ranks.cards.value[Dealer.PlayersCards()[0]]);
            //Console.WriteLine()
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Ranks.cards.value[Dealer.PlayersCards()[1]]);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Ranks.cards.value[Dealer.PlayersCards()[2]]);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Ranks.cards.value[Dealer.PlayersCards()[3]]);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Ranks.cards.value[Dealer.PlayersCards()[4]]);
        }
    }
}
