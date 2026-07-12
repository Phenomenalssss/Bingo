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
        }

        private void Main_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            FormBorderStyle = FormBorderStyle.None;
            Bounds = Screen.PrimaryScreen.Bounds;
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
    }
}
