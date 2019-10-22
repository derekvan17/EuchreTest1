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
        public int PassCount { get; private set; }
        public Form1()
        {
            InitializeComponent();
            NewDeal();
        }
        private void NewDeal()
        {
            Deal();
            ClearBoard();
            GetImages();            
            DisplayDealer();
            DecisionLabels();
        }
        private void ClearBoard()
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            playerPlayCard.Visible = false;
            opp1PlayCard.Visible = false;
            partnersPlayCard.Visible = false;
            opp2PlayCard.Visible = false;
            playerDecisionLbl.Visible = false;
            opp1DecisionLbl.Visible = false;
            partnerDecisionLbl.Visible = false;
            opp2DecisionLbl.Visible = false;
            clubsButton.Visible = false;
            diamondsButton.Visible = false;
            spadesButton.Visible = false;
            heartsButton.Visible = false;
            orderUpButton.Visible = true;
            faceCard.Visible = true;
            kittyCards.Visible = true;
            PassCount = 0;
        }
        private void GetImages()
        {
            playerCard0.Image = images[PlayersCards()[0]];
            playerCard1.Image = images[PlayersCards()[1]];
            playerCard2.Image = images[PlayersCards()[2]];
            playerCard3.Image = images[PlayersCards()[3]];
            playerCard4.Image = images[PlayersCards()[4]];
            //correct UI commented out for troubleshooting
            /*opp1Card0.Image.Image = images[32];
            opp1Card1.Image.Image = images[32];
            opp1Card2.Image.Image = images[32];
            opp1Card3.Image.Image = images[32];
            opp1Card4.Image.Image = images[32];
            opp2Card0.Image.Image = images[32];
            opp2Card1.Image = images[32];
            opp2Card2.Image = images[32];
            opp2Card3.Image = images[32];
            opp2Card4.Image = images[32];
            partnerCard0.Image = images[32];
            partnerCard1.Image = images[32];
            partnerCard2.Image = images[32];
            partnerCard3.Image = images[32];
            partnerCard4.Image = images[32];*/
            opp1Card0.Image = images[Opp1Cards()[0]];
            opp1Card1.Image = images[Opp1Cards()[1]];
            opp1Card2.Image = images[Opp1Cards()[2]];
            opp1Card3.Image = images[Opp1Cards()[3]];
            opp1Card4.Image = images[Opp1Cards()[4]];
            opp2Card0.Image = images[Opp2Cards()[0]];
            opp2Card1.Image = images[Opp2Cards()[1]];
            opp2Card2.Image = images[Opp2Cards()[2]];
            opp2Card3.Image = images[Opp2Cards()[3]];
            opp2Card4.Image = images[Opp2Cards()[4]];
            partnerCard0.Image = images[PartnersCards()[0]];
            partnerCard1.Image = images[PartnersCards()[1]];
            partnerCard2.Image = images[PartnersCards()[2]];
            partnerCard3.Image = images[PartnersCards()[3]];
            partnerCard4.Image = images[PartnersCards()[4]];
            //the following two lines are always correct
            faceCard.Image = images[FaceCard()];
            kittyCards.Image = images[32];
            clubsButton.Image = images[49];
            diamondsButton.Image = images[50];
            spadesButton.Image = images[51];
            heartsButton.Image = images[52];

        }
        private void DisplayDealer()
        {
            if (playerDeal)
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
        private void DecisionLabels()
        {
            Console.WriteLine("Player's Pts: " + Convert.ToString(Bidding.BidPoints(PlayersCards(), playerDeal)));
            if (Bidding.Bid(Bidding.BidPoints(PlayersCards(), playerDeal)) == 1)
            {
                playerDecisionLbl.Text = "Pick it up!";
            }

            else if (Bidding.Bid(Bidding.BidPoints(PlayersCards(), playerDeal)) == 2)
            {
                playerDecisionLbl.Text = "Alone!";
            }

            else
            {
                playerDecisionLbl.Text = "Pass";
            }

            Console.WriteLine("Opp 1's Pts: " + Convert.ToString(Bidding.BidPoints(Opp1Cards(), opp1Deal)));
            if (Bidding.Bid(Bidding.BidPoints(Opp1Cards(), opp1Deal)) == 1)
            {
                opp1DecisionLbl.Text = "Pick it up!";
            }

            else if (Bidding.Bid(Bidding.BidPoints(Opp1Cards(), playerDeal)) == 2)
            {
                opp1DecisionLbl.Text = "Alone!";
            }

            else
            {
                opp1DecisionLbl.Text = "Pass";
            }


            Console.WriteLine("Partner's Pts: " + Convert.ToString(Bidding.BidPoints(PartnersCards(), partnerDeal)));
            if (Bidding.Bid(Bidding.BidPoints(PartnersCards(), partnerDeal)) == 1)
            {
                partnerDecisionLbl.Text = "Pick it up!";
            }

            else if (Bidding.Bid(Bidding.BidPoints(PartnersCards(), playerDeal)) == 2)
            {
                partnerDecisionLbl.Text = "Alone!";
            }

            else
            {
                partnerDecisionLbl.Text = "Pass";
            }


            Console.WriteLine("Opp 2's Pts: " + Convert.ToString(Bidding.BidPoints(Opp2Cards(), opp2Deal)));
            if (Bidding.Bid(Bidding.BidPoints(Opp2Cards(), opp2Deal)) == 1)
            {
                opp2DecisionLbl.Text = "Pick it up!";
            }

            else if (Bidding.Bid(Bidding.BidPoints(Opp2Cards(), playerDeal)) == 2)
            {
                opp2DecisionLbl.Text = "Alone!";
            }

            else
            {
                opp2DecisionLbl.Text = "Pass";
            }

            Console.WriteLine();
        }
        private void playerCard0_Click(object sender, EventArgs e)
        {
            //playerPlayCard.Visible = true;
            //playerPlayCard.Image = playerCard0.Image;
        }
        private void playerCard1_Click(object sender, EventArgs e)
        {
            //playerPlayCard.Visible = true;
            //playerPlayCard.Image = playerCard1.Image;
        }
        private void playerCard2_Click(object sender, EventArgs e)
        {
            //playerPlayCard.Visible = true;
            //playerPlayCard.Image = playerCard2.Image;
        }
        private void playerCard3_Click(object sender, EventArgs e)
        {
            //playerPlayCard.Visible = true;
            //playerPlayCard.Image = playerCard3.Image;
        }
        private void playerCard4_Click(object sender, EventArgs e)
        {
            //playerPlayCard.Visible = true;
            //playerPlayCard.Image = playerCard4.Image;
        }
        private void passButton_Click(object sender, EventArgs e)
        {
            PassCount++;
            if(Game.turn < 3)
            {
                Game.turn++;
            }

            else
            {
                Game.turn = 0;
            }

            if (Game.turn == 0)
            {
                playerDecisionLbl.Visible = false;
                opp1DecisionLbl.Visible = true;
                partnerDecisionLbl.Visible = false;
                opp2DecisionLbl.Visible = false;
            }

            if (Game.turn == 1)
            {
                playerDecisionLbl.Visible = false;
                opp1DecisionLbl.Visible = false;
                partnerDecisionLbl.Visible = true;
                opp2DecisionLbl.Visible = false;
            }

            if (Game.turn == 2)
            {
                playerDecisionLbl.Visible = false;
                opp1DecisionLbl.Visible = false;
                partnerDecisionLbl.Visible = false;
                opp2DecisionLbl.Visible = true;
            }

            if (Game.turn == 3)
            {
                playerDecisionLbl.Visible = true;
                opp1DecisionLbl.Visible = false;
                partnerDecisionLbl.Visible = false;
                opp2DecisionLbl.Visible = false;
            }

            if (PassCount > 4)
            {
                faceCard.Visible = false;
                kittyCards.Visible = false;
                orderUpButton.Visible = false;
                clubsButton.Visible = true;
                diamondsButton.Visible = true;
                spadesButton.Visible = true;
                heartsButton.Visible = true;

                if(Bidding.DetermineSuit() == Suit.Clubs)
                {
                    clubsButton.Image = images[53];
                }

                else if (Bidding.DetermineSuit() == Suit.Diamonds)
                {
                    diamondsButton.Image = images[54];
                }

                else if (Bidding.DetermineSuit() == Suit.Spades)
                {
                    spadesButton.Image = images[55];
                }

                else if (Bidding.DetermineSuit() == Suit.Hearts)
                {
                    heartsButton.Image = images[56];
                }
            }

            if (PassCount > 8)
            {
                NewDeal();
            }
        }
        private void orderUpButton_Click(object sender, EventArgs e)
        {

        }
        private void clubsButton_Click(object sender, EventArgs e)
        {

        }
        private void diamondsButton_Click(object sender, EventArgs e)
        {

        }
        private void spadesButton_Click(object sender, EventArgs e)
        {

        }
        private void heartsButton_Click(object sender, EventArgs e)
        {

        }
    }
}
