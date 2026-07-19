using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Bingo
{
    public partial class Main : Form
    {
        private Image currentBackground;
        private Image nextBackground;
        private float fade = 0;
        private Timer fadeTimer;

        public Main()
        {
            InitializeComponent();
            WindowState = FormWindowState.Normal;
            FormBorderStyle = FormBorderStyle.None;
            Bounds = Screen.PrimaryScreen.Bounds;
        }

        private async void Main_Load(object sender, EventArgs e)
        {
            UIAnimator.IsAnimating = true;
            currentBackground = Properties.Resources.menu;
            BingoLabel.Visible = false;
            FootballEditionLabel.Visible = false;
            PlayLabel.Visible = false;
            QuitLabel.Visible = false;
            await UIAnimator.FadeInForm(this);
            await UIAnimator.FadeInControl(FootballEditionLabel, 200);
            await UIAnimator.FadeInControl(BingoLabel, 200);
            await Task.Delay(200);
            await UIAnimator.SlideFadeIn(PlayLabel, 50, 50);
            await UIAnimator.SlideFadeIn(QuitLabel, 50, 50);
            UIAnimator.IsAnimating = false;
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

        public void ChangeBackground(Image newBackground)
        {
            nextBackground = newBackground;
            fade = 0;
            fadeTimer = new Timer();
            fadeTimer.Interval = 15;
            fadeTimer.Tick += (s, e) =>
            {
                fade += 0.02f;

                if (fade >= 1)
                {
                    fade = 1;
                    currentBackground = nextBackground;
                    nextBackground = null;
                    fadeTimer.Stop();
                }

                Invalidate();
            };

            fadeTimer.Start();
        }

        private void DrawImageAlpha(Graphics g, Image img, float alpha)
        {
            if (img == null) return;

            using (var attributes = new System.Drawing.Imaging.ImageAttributes())
            {
                var matrix = new System.Drawing.Imaging.ColorMatrix();

                matrix.Matrix33 = alpha;

                attributes.SetColorMatrix(matrix);

                g.DrawImage(
                    img,
                    new Rectangle(0, 0, Width, Height),
                    0,
                    0,
                    img.Width,
                    img.Height,
                    GraphicsUnit.Pixel,
                    attributes
                );
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            DrawImageAlpha(e.Graphics, currentBackground, 1);

            if (nextBackground != null)
            {
                DrawImageAlpha(e.Graphics, nextBackground, fade);
            }
        }

        private void QuitLabel_Click(object sender, EventArgs e)
        {
            if (UIAnimator.IsAnimating)
                return;

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

        private async void PlayLabel_Click(object sender, EventArgs e)
        {
            if (UIAnimator.IsAnimating)
                return;

            UIAnimator.IsAnimating = true;
            BingoLabel.Visible = false;
            FootballEditionLabel.Visible = false;
            PlayLabel.Visible = false;
            QuitLabel.Visible = false;
            await UIAnimator.FadeInControl(FootballEditionSmallLabel, 200);
            await UIAnimator.FadeInControl(BingoSmallLabel, 200);
            await UIAnimator.SlideFadeIn(CountPlayers, 50, 50);
            await UIAnimator.SlideFadeIn(CountPlayersNumericUpDown, 50, 50);
            await UIAnimator.SlideFadeIn(DifficultLabel, 50, 50);
            await UIAnimator.SlideFadeIn(EasyRadioButton, 50, 50);
            await UIAnimator.SlideFadeIn(EasyLabel, 50, 50);
            await UIAnimator.SlideFadeIn(AverageRadioButton, 50, 50);
            await UIAnimator.SlideFadeIn(AverageLabel, 50, 50);
            await UIAnimator.SlideFadeIn(FullHouseRadioButton, 50, 50);
            await UIAnimator.SlideFadeIn(FullHouseLabel, 50, 50);
            await UIAnimator.SlideFadeIn(BackLabel, 50, 50);
            UIAnimator.IsAnimating = false;
        }

        private async void BackLabel_Click(object sender, EventArgs e)
        {
            if (UIAnimator.IsAnimating)
                return;

            UIAnimator.IsAnimating = true;
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
            await UIAnimator.FadeInControl(FootballEditionLabel, 200);
            await UIAnimator.FadeInControl(BingoLabel, 200);
            await Task.Delay(200);
            await UIAnimator.SlideFadeIn(PlayLabel, 50, 50);
            await UIAnimator.SlideFadeIn(QuitLabel, 50, 50);
            UIAnimator.IsAnimating = false;
        }

        private void BackLabel_MouseEnter(object sender, EventArgs e)
        {
            BackLabel.ForeColor = Color.LightGray;
        }

        private void BackLabel_MouseLeave(object sender, EventArgs e)
        {
            BackLabel.ForeColor = Color.White;
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

        private async void StartGame_CheckedChanged(object sender, EventArgs e)
        {
            if (UIAnimator.IsAnimating)
                return;

            if (EasyRadioButton.Checked || FullHouseRadioButton.Checked)
            {
                ModificatorLabel.Visible = false;
                ModificatorsComboBox.Visible = false;
                UIAnimator.IsAnimating = true;
                await UIAnimator.SlideFadeIn(StartGameLabel, 50, 50);
                UIAnimator.IsAnimating = false;
            }
        }

        private async void AverageRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (UIAnimator.IsAnimating)
                return;

            if (AverageRadioButton.Checked)
            {
                UIAnimator.IsAnimating = true;
                StartGameLabel.Visible = false;
                await UIAnimator.SlideFadeIn(ModificatorLabel, 50, 50);
                await UIAnimator.SlideFadeIn(ModificatorsComboBox, 50, 50);
                ModificatorsComboBox.SelectedIndex = -1;
                UIAnimator.IsAnimating = false;
            }
            else
            {
                StartGameLabel.Visible = false;
                ModificatorLabel.Visible = false;
                ModificatorsComboBox.Visible = false;
            }
        }

        private async void ModificatorsComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            await UIAnimator.SlideFadeIn(StartGameLabel, 50, 50);
        }

        private void AverageRadioButton_Click(object sender, EventArgs e)
        {
            if (UIAnimator.IsAnimating)
                return;

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

        private async void StartGameLabel_Click(object sender, EventArgs e)
        {
            if (UIAnimator.IsAnimating)
                return;

            UIAnimator.IsAnimating = true;
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
            ChangeBackground(Properties.Resources.game);
            BackgroundImageLayout = ImageLayout.Stretch;
            await Task.Delay(1500);
            await UIAnimator.FadeInControl(FootballEditionInGameLabel, 200);
            await UIAnimator.FadeInControl(BingoInGameLabel, 200);
            await UIAnimator.FadeInControl(ExitPictureBox, 200);
            await UIAnimator.FadeInControl(HomePictureBox, 200);
            if (EasyRadioButton.Checked)
            {
                Bingo.StartGame("Лёгкая", Convert.ToInt32(CountPlayersNumericUpDown.Value), this, 50, 120, 900, 40);
            }
            if (AverageRadioButton.Checked)
            {
                MessageBox.Show($"average - {ModificatorsComboBox.SelectedItem} - {CountPlayersNumericUpDown.Value}");
            }
            if (FullHouseRadioButton.Checked)
            {
                MessageBox.Show($"fullhouse - {CountPlayersNumericUpDown.Value}");
            }
            UIAnimator.IsAnimating = false;
            EasyRadioButton.Checked = AverageRadioButton.Checked = FullHouseRadioButton.Checked = false;
            CountPlayersNumericUpDown.Value = CountPlayersNumericUpDown.Minimum;
        }

        private void ExitPictureBox_Click(object sender, EventArgs e)
        {
            if (UIAnimator.IsAnimating)
                return;

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

        private async void HomePictureBox_Click(object sender, EventArgs e)
        {
            if (UIAnimator.IsAnimating)
                return;

            DialogResult result = MessageBox.Show("Весь прогресс будет утерян, вы уверены?", "Уведомление", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                UIAnimator.IsAnimating = true;
                ExitPictureBox.Visible = false;
                HomePictureBox.Visible = false;
                BingoInGameLabel.Visible = false;
                FootballEditionInGameLabel.Visible = false;
                ChangeBackground(Properties.Resources.menu);
                BackgroundImageLayout = ImageLayout.Stretch;
                await Task.Delay(1500);
                await UIAnimator.FadeInControl(FootballEditionLabel, 200);
                await UIAnimator.FadeInControl(BingoLabel, 200);
                await Task.Delay(200);
                await UIAnimator.SlideFadeIn(PlayLabel, 50, 50);
                await UIAnimator.SlideFadeIn(QuitLabel, 50, 50);
                EasyRadioButton.Checked = AverageRadioButton.Checked = FullHouseRadioButton.Checked = false;
                CountPlayersNumericUpDown.Value = CountPlayersNumericUpDown.Minimum;
                UIAnimator.IsAnimating = false;
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

        private void EasyRadioButton_MouseEnter(object sender, EventArgs e)
        {
            EasyRadioButton.ForeColor = Color.LightGray;
        }

        private void EasyRadioButton_MouseLeave(object sender, EventArgs e)
        {
            EasyRadioButton.ForeColor = Color.White;
        }
    }
}
