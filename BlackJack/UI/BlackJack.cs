using BlackJack.Class;
using BlackJack.Enumeration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class BlackJackForm : Form
    {
        private List<Card> deckList = new List<Card>();
        private Player player = new Player("PLAYER", true);
        private Player dealer = new Player("DEALER", false);
        private int hitButtonClickCount = 0;
        private int timerTickCount = 0;
        private Random random = new Random();

        public BlackJackForm()
        {
            InitializeComponent();
            CreateDeck();
            PrepareGame();
        }

        private void PrepareGame()
        {
            pc3.Visible = false;
            pc4.Visible = false;
            pc5.Visible = false;
            dc3.Visible = false;
            dc4.Visible = false;
            dc5.Visible = false;
        }

        private void CreateDeck()
        {
            deckList.Clear();
            foreach (FaceColor faceColor in Enum.GetValues(typeof(FaceColor)))
            {
                foreach (FaceValue faceValue in Enum.GetValues(typeof(FaceValue)))
                {
                    deckList.Add(new Card(faceColor, faceValue));
                }
            }
        }

        private void newGameToolStripButton_Click(object sender, EventArgs e)
        {
            CreateDeck();
        }

        private void dealButton_Click(object sender, EventArgs e)
        {
            DealOneCard(player, pc1, playerTotalLabel);
            DealOneCard(dealer, dc1, dealerTotalLabel);
            DealOneCard(player, pc2, playerTotalLabel); 
            DealOneCard(dealer, dc2, dealerTotalLabel);
            CheckAceToAce(player, true);
            CheckBlackJack(player);
        }

        private void CheckAceToAce(Player p, bool isPlayer)
        {
            if(p.HandTotal == 22)
            {
                p.HandTotal -= 10;
                if (isPlayer)
                {
                    playerTotalLabel.Text = p.HandTotal.ToString();
                }
                else
                {
                    dealerTotalLabel.Text = p.HandTotal.ToString();
                }              
            }
        }

        private void CheckBlackJack(Player p)
        {
            if(p.HandTotal == 21)
            {
                p.IsBlackJack = true;
                FinishGame(p);
            }
        }

        private void hitButton_Click(object sender, EventArgs e)
        {
            hitButtonClickCount++;
            if (hitButtonClickCount == 1)
            {
                DealOneCard(player, pc3, playerTotalLabel);
                CheckPlayerHandTotal();
            }
            else if (hitButtonClickCount == 2)
            {
                DealOneCard(player, pc4, playerTotalLabel);
                CheckPlayerHandTotal();
            }
            else if (hitButtonClickCount == 3)
            {
                DealOneCard(player, pc5, playerTotalLabel);
                CheckPlayerHandTotal();
            }
        }   
        

        private void CheckPlayerHandTotal()
        {
            if(player.HandTotal > 21)
            {
                Card ace = player.CardList.Find(card => card.FaceValue == FaceValue.Ace);
                if(ace == null)
                {
                    FinishGame(dealer);
                }
                else
                {
                    player.HandTotal -= 10;
                    playerTotalLabel.Text = player.HandTotal.ToString();
                }
            }
        }

        private void FinishGame(Player winnerPlayer)
        {
            StringBuilder builder = new StringBuilder();
            if (winnerPlayer == null)
            {
                builder.Append("BERABERE!");
            }
            else
            {
                if (winnerPlayer.IsBlackJack)
                {
                    builder.Append("BLACKJACK!");
                    builder.Append(Environment.NewLine);
                }
                builder.Append(winnerPlayer.Name);
                builder.Append(" ");
                builder.Append("KAZANDI");                
            }
     
            MessageBox.Show(builder.ToString(), "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if(MessageBox.Show("Yeni el dağıtılsın mı?", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                player.CardList.Clear();
                player.HandTotal = 0;
                player.ShowTotal = true;
                player.IsBlackJack = false;

                dealer.CardList.Clear();
                dealer.HandTotal = 0;
                dealer.ShowTotal = false;
                dealer.IsBlackJack = false;

                hitButtonClickCount = 0;
                timerTickCount = 0;
                ClearControls();
                CreateDeck();
                PrepareGame();
            }
        }

        private void standButton_Click(object sender, EventArgs e)
        {
            dc1.Image = dealer.CardList.First().Image;
            dealerTotalLabel.Text = dealer.HandTotal.ToString();
            dealer.ShowTotal = true;
            CheckAceToAce(dealer, false);
            CheckBlackJack(dealer);
            CheckDealerHandTotal();

        }

        private void CheckDealerHandTotal()
        {
            if (dealer.HandTotal > 21)
            {
                Card ace = dealer.CardList.Find(card => card.FaceValue == FaceValue.Ace);
                if(ace == null)
                {
                    FinishGame(player);
                }
                else
                {
                    dealer.HandTotal -= 10;
                    dealerTotalLabel.Text = dealer.HandTotal.ToString();
                    timer.Start();
                }             
            }
            else if (dealer.HandTotal >= 17 && dealer.HandTotal <= 21)
            {
                if (dealer.HandTotal > player.HandTotal)
                {
                    FinishGame(dealer);
                }
                else if (dealer.HandTotal < player.HandTotal)
                {
                    FinishGame(player);
                }
                else
                {
                    FinishGame(null);
                }
            }
            else
            {           
                timer.Start();                          
            }
        }

        private void DealOneCard(Player player, PictureBox pictureBox, Label label)
        {
            int randomNumber = random.Next(deckList.Count);
            Card randomCard = deckList.ElementAt(randomNumber);
            player.CardList.Add(randomCard);
            deckList.Remove(randomCard);
            player.HandTotal += randomCard.Value;
            if(pictureBox == dc1)
            {
                pictureBox.Image = Resources.blackcard;
            }
            else
            {
                pictureBox.Visible = true;
                pictureBox.Image = randomCard.Image;
            }
            if (player.ShowTotal)
            {
                label.Text = player.HandTotal.ToString();
            }           
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if(timerTickCount == 0)
            {
                DealOneCard(dealer, dc3, dealerTotalLabel);
                timerTickCount++;
            }
            else if(timerTickCount == 1)
            {
                DealOneCard(dealer, dc4, dealerTotalLabel);
                timerTickCount++;
            }
            else if(timerTickCount == 2)
            {
                DealOneCard(dealer, dc5, dealerTotalLabel);
                timerTickCount++;
            }
            timer.Stop();
            CheckDealerHandTotal();
        }

        private void ClearControls()
        {
            var enumerator = Controls.GetEnumerator();
            while (enumerator.MoveNext())
            {
                if (enumerator.Current.GetType().Equals(typeof(PictureBox)))
                {
                    (enumerator.Current as PictureBox).Image = null;
                }
            }
            playerTotalLabel.Text = string.Empty;
            dealerTotalLabel.Text = string.Empty;
        }
    }
}
