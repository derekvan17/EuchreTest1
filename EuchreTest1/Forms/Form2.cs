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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            if(Bidding.PassCount > 3)
            {
                orderUpButton.Visible = false;
                clubsButton.Visible = true;
                diamondsButton.Visible = true;
                spadesButton.Visible = true;
                heartsButton.Visible = true;
                clubsButton.Image = images[49];
                diamondsButton.Image = images[50];
                spadesButton.Image = images[51];
                heartsButton.Image = images[52];


                if (Bidding.FaceCardSuit() == Suit.Clubs)
                {
                    clubsButton.Image = images[53];
                }

                else if (Bidding.FaceCardSuit() == Suit.Diamonds)
                {
                    diamondsButton.Image = images[54];
                }

                else if (Bidding.FaceCardSuit() == Suit.Spades)
                {
                    spadesButton.Image = images[55];
                }

                else if (Bidding.FaceCardSuit() == Suit.Hearts)
                {
                    heartsButton.Image = images[56];
                }
            }
        }


        private void passButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void orderUpButton_Click(object sender, EventArgs e)
        {
            Bidding.BidActive = false;
            this.Close();
        }

        private void clubsButton_Click(object sender, EventArgs e)
        {
            if (Bidding.FaceCardSuit() == Suit.Clubs)
            {
                MessageBox.Show("Clubs was turned down already! Pick another trump suit.");
            }

            else
            {
                Bidding.BidActive = false;
                this.Close();
            }
        }

        private void diamondsButton_Click(object sender, EventArgs e)
        {
            if (Bidding.FaceCardSuit() == Suit.Diamonds)
            {
                MessageBox.Show("Diamonds was turned down already! Pick another trump suit.");
            }

            else
            {
                Bidding.BidActive = false;
                this.Close();
            }

            
        }

        private void spadesButton_Click(object sender, EventArgs e)
        {
            if (Bidding.FaceCardSuit() == Suit.Spades)
            {
                MessageBox.Show("Spades was turned down already! Pick another trump suit.");
            }

            else
            {
                Bidding.BidActive = false;
                this.Close();
            }
        }

        private void heartsButton_Click(object sender, EventArgs e)
        {
            if (Bidding.FaceCardSuit() == Suit.Hearts)
            {
                MessageBox.Show("Hearts was turned down already! Pick another trump suit.");
            }

            else
            {
                Bidding.BidActive = false;
                this.Close();
            }
        }
    }
}
