using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Net;
using System.Windows.Forms;
using System.Management;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types;
using ForFileSystemTestingWinFormsApp.Forms;

namespace ForFileSystemTestingWinFormsApp
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void ReadyButton_Click(object sender, EventArgs e)
        {
            
            if (daysTextBox.Text != string.Empty && monthesComboBox.Text != string.Empty)
            {
                KatalogInfo katalogInfo = new KatalogInfo();
                //DefiningKatalogForm definingKatalogForm = new DefiningKatalogForm();

                Card card = new(Convert.ToInt32(daysTextBox.Text), monthesComboBox.Text);
                CardInfoForm cardInfoForm = new CardInfoForm();

                cardInfoForm.cardNameLabel.Text = $"Your card {card.CardNameToDisplay}";
                cardInfoForm.descriptionLabel.Text = $"{card.Description}";
                //D:\\Projects\\ForFileSystemTestingWinFormsApp\\карты судьбы\\{card.CardName}.jpg
                cardInfoForm.cardPictureBox.ImageLocation = $"{KatalogInfo.GetPath(StartForm.folderBrowserDialog1)}\\карты судьбы\\{card.CardName}.jpg";

                cardInfoForm.Show();
                daysTextBox.Text = string.Empty;
                monthesComboBox.Text = string.Empty;
            }
            
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            daysTextBox.KeyDown += (sender, args) => {
                if (args.KeyCode == Keys.Return)
                {
                    ReadyButton.PerformClick();
                }
            };
            
        }

        private void monthesComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ReadyButton.PerformClick();
            }
        }
    }
}