using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using static EuchreTest1.ImportDLL;
using static EuchreTest1.Dealer;
namespace EuchreTest1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NewDeal();
            FormClosing += Form1_Closing;
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
            faceCard.Visible = true;
            kittyCards.Visible = true;
            Bidding.PassCount = 0;
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
            Console.WriteLine("Player: " + Convert.ToString(Bidding.BidPoints(PlayersCards(), playerDeal)));
            if (Bidding.BidDecision(Bidding.BidPoints(PlayersCards(), playerDeal)) == 1)
            {
                playerDecisionLbl.Text = "Pick it up!";
            }

            else if (Bidding.BidDecision(Bidding.BidPoints(PlayersCards(), playerDeal)) == 2)
            {
                playerDecisionLbl.Text = "Alone!";
            }

            else
            {
                playerDecisionLbl.Text = "Pass";
            }

            Console.WriteLine("Opp 1: " + Convert.ToString((Bidding.BidPoints(Opp1Cards(), opp1Deal))));
            if (Bidding.BidDecision(Bidding.BidPoints(Opp1Cards(), opp1Deal)) == 1)
            {
                opp1DecisionLbl.Text = "Pick it up!";
            }

            else if (Bidding.BidDecision(Bidding.BidPoints(Opp1Cards(), opp1Deal)) == 2)
            {
                opp1DecisionLbl.Text = "Alone!";
            }

            else
            {
                opp1DecisionLbl.Text = "Pass";

            }


            Console.WriteLine("Partner: " + Convert.ToString(Bidding.BidPoints(PartnersCards(), partnerDeal)));
            if (Bidding.BidDecision(Bidding.BidPoints(PartnersCards(), partnerDeal)) == 1)
            {
                partnerDecisionLbl.Text = "Pick it up!";
            }

            else if (Bidding.BidDecision(Bidding.BidPoints(PartnersCards(), partnerDeal)) == 2)
            {
                partnerDecisionLbl.Text = "Alone!";

            }

            else
            {
                partnerDecisionLbl.Text = "Pass";
            }


            Console.WriteLine("Opp 2: " + Convert.ToString((Bidding.BidPoints(Opp2Cards(), opp2Deal))));
            if (Bidding.BidDecision(Bidding.BidPoints(Opp2Cards(), opp2Deal)) == 1)
            {
                opp2DecisionLbl.Text = "Pick it up!";
            }

            else if (Bidding.BidDecision(Bidding.BidPoints(Opp2Cards(), opp2Deal)) == 2)
            {
                opp2DecisionLbl.Text = "Alone!";
            }

            else
            {
                opp2DecisionLbl.Text = "Pass";
            }

            Console.WriteLine();
        }
        private void Passing()
        {
            if (Bidding.PassCount > 7)
            {
                NewDeal();
            }

            UpdateUserInterface();

            if (Game.Turn < 3)
            {
                Game.Turn++;
            }

            else
            {
                Game.Turn = 0;
            }

            if (Game.Turn == 3)
            {
                opp2DecisionLbl.Visible = false;
                var form = new Form2();
                form.ShowDialog();                
            }

            UpdateUserInterface();
            Bidding.PassCount++;
        }
        private void UpdateUserInterface()
        {
            UserInterface ui = new UserInterface();
            faceCard.Visible = ui.ShouldKittyBeVisible(Bidding.PassCount);
            kittyCards.Visible = ui.ShouldKittyBeVisible(Bidding.PassCount);
            orderUpButton.Visible = ui.ShouldKittyBeVisible(Bidding.PassCount);
            opp1DecisionLbl.Visible = ui.DecisionLabelVisible(0);
            partnerDecisionLbl.Visible = ui.DecisionLabelVisible(1);
            opp2DecisionLbl.Visible = ui.DecisionLabelVisible(2);
            //playerDecisionLbl.Visible = ui.DecisionLabelVisible(3);

            Refresh();
        }
        private void passButton_Click(object sender, EventArgs e)
        {
            Bidding.BidActive = true;
            while(Bidding.BidActive)
            {
                Passing();
                Console.WriteLine(Convert.ToString(Game.Turn));

                if (//Bidding.BidDecision(Bidding.BidPoints(PlayersCards(), playerDeal)) > 0 && Game.Turn == 3 ||
                    Bidding.BidDecision(Bidding.BidPoints(Opp1Cards(), opp1Deal)) > 0 && Game.Turn == 0 ||
                    Bidding.BidDecision(Bidding.BidPoints(PartnersCards(), partnerDeal)) > 0 && Game.Turn == 1 ||
                    Bidding.BidDecision(Bidding.BidPoints(Opp2Cards(), opp2Deal)) > 0 && Game.Turn == 2)
                {
                    Bidding.BidActive = false;
                }

                if (Bidding.PassCount > 3)
                {
                    Console.WriteLine(Convert.ToString(Bidding.BidPoints2(Opp1Cards())));
                    Console.WriteLine(Convert.ToString(Bidding.BidPoints2(PartnersCards())));
                    Console.WriteLine(Convert.ToString(Bidding.BidPoints2(Opp2Cards())));
                    Console.WriteLine(Convert.ToString(Bidding.BidPoints2(PlayersCards())));
                }
                
                Thread.Sleep(1500);
            }                 
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
        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
