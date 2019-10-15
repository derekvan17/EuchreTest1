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
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deal();
            GetImages();
            Console.WriteLine("Player's Pts: " + Convert.ToString(Bidding.Bid(PlayersCards(),playerDeal)));
            Console.WriteLine("Opp 1's Pts: " + Convert.ToString(Bidding.Bid(Opp1Cards(),opp1Deal)));
            Console.WriteLine("Partner's Pts: " + Convert.ToString(Bidding.Bid(PartnersCards(),partnerDeal)));
            Console.WriteLine("Opp 2's Pts: " + Convert.ToString(Bidding.Bid(Opp2Cards(),opp2Deal)));
            Console.WriteLine();
            
            if(playerDeal)
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = true;
            }

            if (opp1Deal)
            {
                label1.Visible = true;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
            }

            if (partnerDeal)
            {
                label1.Visible = false;
                label2.Visible = true;
                label3.Visible = false;
                label4.Visible = false;
            }

            if (opp2Deal)
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = true;
                label4.Visible = false;
            }
        }

        public void GetImages()
        {
            pictureBox1.Image = images[PlayersCards()[0]];
            pictureBox2.Image = images[PlayersCards()[1]];
            pictureBox3.Image = images[PlayersCards()[2]];
            pictureBox4.Image = images[PlayersCards()[3]];
            pictureBox5.Image = images[PlayersCards()[4]];
            //correct UI commented out for troubleshooting
            /*pictureBox6.Image = images[32];
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
            pictureBox20.Image = images[32];*/
            pictureBox6.Image = images[Opp1Cards()[0]];
            pictureBox7.Image = images[Opp1Cards()[1]];
            pictureBox8.Image = images[Opp1Cards()[2]];
            pictureBox9.Image = images[Opp1Cards()[3]];
            pictureBox10.Image = images[Opp1Cards()[4]];
            pictureBox11.Image = images[Opp2Cards()[0]];
            pictureBox12.Image = images[Opp2Cards()[1]];
            pictureBox13.Image = images[Opp2Cards()[2]];
            pictureBox14.Image = images[Opp2Cards()[3]];
            pictureBox15.Image = images[Opp2Cards()[4]];
            pictureBox16.Image = images[PartnersCards()[0]];
            pictureBox17.Image = images[PartnersCards()[1]];
            pictureBox18.Image = images[PartnersCards()[2]];
            pictureBox19.Image = images[PartnersCards()[3]];
            pictureBox20.Image = images[PartnersCards()[4]];
            //the following two lines are always correct
            pictureBox21.Image = images[FaceCard()];
            pictureBox22.Image = images[32];

        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            Console.Write(Ranks.cards.value[PlayersCards()[0]]);

            if (Ranks.cards.isTrump[PlayersCards()[0]] == true)
            {
                Console.Write("-" + Ranks.cards.suit[PlayersCards()[0]]);
                Console.WriteLine(" This is a trump card!");
            }

            else
            {
                Console.WriteLine("-" + Ranks.cards.suit[PlayersCards()[0]]);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Console.Write(Ranks.cards.value[PlayersCards()[1]]);

            if (Ranks.cards.isTrump[PlayersCards()[1]] == true)
            {
                Console.Write("-" + Ranks.cards.suit[PlayersCards()[1]]);
                Console.WriteLine(" This is a trump card!");
            }

            else
            {
                Console.WriteLine("-" + Ranks.cards.suit[PlayersCards()[1]]);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Console.Write(Ranks.cards.value[PlayersCards()[2]]);

            if (Ranks.cards.isTrump[PlayersCards()[2]] == true)
            {
                Console.Write("-" + Ranks.cards.suit[PlayersCards()[2]]);
                Console.WriteLine(" This is a trump card!");
            }

            else
            {
                Console.WriteLine("-" + Ranks.cards.suit[PlayersCards()[2]]);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Console.Write(Ranks.cards.value[PlayersCards()[3]]);

            if (Ranks.cards.isTrump[PlayersCards()[3]] == true)
            {
                Console.Write("-" + Ranks.cards.suit[PlayersCards()[3]]);
                Console.WriteLine(" This is a trump card!");
            }

            else
            {
                Console.WriteLine("-" + Ranks.cards.suit[PlayersCards()[3]]);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Console.Write(Ranks.cards.value[PlayersCards()[4]]);

            if (Ranks.cards.isTrump[PlayersCards()[4]] == true)
            {
                Console.Write("-" + Ranks.cards.suit[PlayersCards()[4]]);
                Console.WriteLine("  This is a trump card!");
            }

            else
            {
                Console.WriteLine("-" + Ranks.cards.suit[PlayersCards()[4]]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
