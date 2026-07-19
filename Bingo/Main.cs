using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Bingo
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            WindowState = FormWindowState.Normal;
            FormBorderStyle = FormBorderStyle.None;
            Bounds = Screen.PrimaryScreen.Bounds;
        }

        private async void Main_Load(object sender, EventArgs e)
        {
            BingoLabel.Visible = false;
            FootballEditionLabel.Visible = false;
            PlayLabel.Visible = false;
            QuitLabel.Visible = false;
            await UIAnimator.FadeInForm(this);
            await UIAnimator.FadeInControl(FootballEditionLabel, 50);
            await UIAnimator.FadeInControl(BingoLabel, 50);
            await Task.Delay(200);
            await UIAnimator.SlideFadeIn(PlayLabel, 80);
            await Task.Delay(150);
            await UIAnimator.SlideFadeIn(QuitLabel, 80);
        }

        private bool isClosing = false;

        private async void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isClosing)
            {
                e.Cancel = true;
                isClosing = true;
                await UIAnimator.FadeOutForm(this);
                Close();
            }
        }

        private void QuitLabel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void QuitLabel_MouseEnter(object sender, EventArgs e)
        {
            QuitLabel.ForeColor = Color.LightGray;
        }

        private void QuitLabel_MouseLeave(object sender, EventArgs e)
        {
            QuitLabel.ForeColor = Color.White;
        }

        private void PlayLabel_MouseEnter(object sender, EventArgs e)
        {
            PlayLabel.ForeColor = Color.LightGray;
        }

        private void PlayLabel_MouseLeave(object sender, EventArgs e)
        {
            PlayLabel.ForeColor = Color.White;
        }

        private void PlayLabel_Click(object sender, EventArgs e)
        {
            BingoLabel.Visible = false;
            FootballEditionLabel.Visible = false;
            PlayLabel.Visible = false;
            QuitLabel.Visible = false;
            BackLabel.Visible = true;
            FootballEditionSmallLabel.Visible = true;
            BingoSmallLabel.Visible = true;
            CountPlayers.Visible = true;
            CountPlayersNumericUpDown.Visible = true;
            DifficultLabel.Visible = true;
            EasyRadioButton.Visible = true;
            EasyLabel.Visible = true;
            AverageRadioButton.Visible = true;
            AverageLabel.Visible = true;
            FullHouseRadioButton.Visible = true;
            FullHouseLabel.Visible = true;
        }

        private void BackLabel_Click(object sender, EventArgs e)
        {
            BingoLabel.Visible = true;
            FootballEditionLabel.Visible = true;
            PlayLabel.Visible = true;
            QuitLabel.Visible = true;
            BackLabel.Visible = false;
            FootballEditionSmallLabel.Visible = false;
            BingoSmallLabel.Visible = false;
            CountPlayers.Visible = false;
            CountPlayersNumericUpDown.Visible = false;
            DifficultLabel.Visible = false;
            EasyRadioButton.Visible = false;
            EasyLabel.Visible = false;
            AverageRadioButton.Visible = false;
            AverageLabel.Visible = false;
            FullHouseRadioButton.Visible = false;
            FullHouseLabel.Visible = false;
            ModificatorLabel.Visible = false;
            ModificatorsComboBox.Visible = false;
            StartGameLabel.Visible = false;
            EasyRadioButton.Checked = AverageRadioButton.Checked = FullHouseRadioButton.Checked = false;
            CountPlayersNumericUpDown.Value = CountPlayersNumericUpDown.Minimum;
        }

        private void BackLabel_MouseEnter(object sender, EventArgs e)
        {
            BackLabel.ForeColor = Color.LightGray;
        }

        private void BackLabel_MouseLeave(object sender, EventArgs e)
        {
            BackLabel.ForeColor = Color.White;
        }

        private void EasyRadioButton_MouseEnter(object sender, EventArgs e)
        {
            EasyRadioButton.ForeColor = Color.LightGray;
        }

        private void EasyRadioButton_MouseLeave(object sender, EventArgs e)
        {
            EasyRadioButton.ForeColor = Color.White;
        }

        private void AverageRadioButton_MouseEnter(object sender, EventArgs e)
        {
            AverageRadioButton.ForeColor = Color.LightGray;
        }

        private void AverageRadioButton_MouseLeave(object sender, EventArgs e)
        {
            AverageRadioButton.ForeColor = Color.White;
        }

        private void FullHouseRadioButton_MouseEnter(object sender, EventArgs e)
        {
            FullHouseRadioButton.ForeColor = Color.LightGray;
        }

        private void FullHouseRadioButton_MouseLeave(object sender, EventArgs e)
        {
            FullHouseRadioButton.ForeColor = Color.White;
        }

        private void StartGame_CheckedChanged(object sender, EventArgs e)
        {
            if (EasyRadioButton.Checked || FullHouseRadioButton.Checked)
            {
                StartGameLabel.Visible = true;
            }
        }

        private void AverageRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (AverageRadioButton.Checked)
            {
                StartGameLabel.Visible = false;
                ModificatorLabel.Visible = true;
                ModificatorsComboBox.Visible = true;
                ModificatorsComboBox.SelectedIndex = -1;
            }
            else
            {
                StartGameLabel.Visible = false;
                ModificatorLabel.Visible = false;
                ModificatorsComboBox.Visible = false;
            }
        }

        private void ModificatorsComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            StartGameLabel.Visible = true;
        }

        private void AverageRadioButton_Click(object sender, EventArgs e)
        {
            StartGameLabel.Visible = false;
        
        }

        private void StartGameLabel_MouseEnter(object sender, EventArgs e)
        {
            StartGameLabel.ForeColor = Color.LightGray;
        }

        private void StartGameLabel_MouseLeave(object sender, EventArgs e)
        {
            StartGameLabel.ForeColor = Color.White;
        }

        private void StartGameLabel_Click(object sender, EventArgs e)
        {
            ExitPictureBox.Visible = true;
            HomePictureBox.Visible = true;
            BackLabel.Visible = false;
            FootballEditionSmallLabel.Visible = false;
            BingoSmallLabel.Visible = false;
            CountPlayers.Visible = false;
            CountPlayersNumericUpDown.Visible = false;
            DifficultLabel.Visible = false;
            EasyRadioButton.Visible = false;
            EasyLabel.Visible = false;
            AverageRadioButton.Visible = false;
            AverageLabel.Visible = false;
            FullHouseRadioButton.Visible = false;
            FullHouseLabel.Visible = false;
            ModificatorLabel.Visible = false;
            ModificatorsComboBox.Visible = false;
            StartGameLabel.Visible = false;
            BackgroundImage = Properties.Resources.game;
            BackgroundImageLayout = ImageLayout.Stretch;
            FootballEditionInGameLabel.Visible = true;
            BingoInGameLabel.Visible = true;
            if (EasyRadioButton.Checked)
            {
                MessageBox.Show($"easy - {CountPlayersNumericUpDown.Value}");
            }
            if (AverageRadioButton.Checked)
            {
                MessageBox.Show($"average - {ModificatorsComboBox.SelectedItem} - {CountPlayersNumericUpDown.Value}");
            }
            if (FullHouseRadioButton.Checked)
            {
                MessageBox.Show($"fullhouse - {CountPlayersNumericUpDown.Value}");
            }
            EasyRadioButton.Checked = AverageRadioButton.Checked = FullHouseRadioButton.Checked = false;
            CountPlayersNumericUpDown.Value = CountPlayersNumericUpDown.Minimum;
        }

        private void ExitPictureBox_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Весь прогресс будет утерян, вы уверены?", "Уведомление", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                Close();
            }
        }

        private void ExitPictureBox_MouseEnter(object sender, EventArgs e)
        {
            ExitPictureBox.Image = Properties.Resources.exit2;
        }

        private void ExitPictureBox_MouseLeave(object sender, EventArgs e)
        {
            ExitPictureBox.Image = Properties.Resources.exit;
        }

        private void HomePictureBox_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Весь прогресс будет утерян, вы уверены?", "Уведомление", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                BackgroundImage = Properties.Resources.menu;
                BackgroundImageLayout = ImageLayout.Stretch;
                ExitPictureBox.Visible = false;
                HomePictureBox.Visible = false;
                BingoInGameLabel.Visible = false;
                FootballEditionInGameLabel.Visible = false;
                BingoLabel.Visible = true;
                FootballEditionLabel.Visible = true;
                PlayLabel.Visible = true;
                QuitLabel.Visible = true;
                EasyRadioButton.Checked = AverageRadioButton.Checked = FullHouseRadioButton.Checked = false;
                CountPlayersNumericUpDown.Value = CountPlayersNumericUpDown.Minimum;
            }
        }

        private void HomePictureBox_MouseEnter(object sender, EventArgs e)
        {
            HomePictureBox.Image = Properties.Resources.home2;
        }

        private void HomePictureBox_MouseLeave(object sender, EventArgs e)
        {
            HomePictureBox.Image = Properties.Resources.home;
        }
    }
}
