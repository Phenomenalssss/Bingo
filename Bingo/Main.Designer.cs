namespace Bingo
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.QuitLabel = new System.Windows.Forms.Label();
            this.PlayLabel = new System.Windows.Forms.Label();
            this.BingoLabel = new System.Windows.Forms.Label();
            this.FootballEditionLabel = new System.Windows.Forms.Label();
            this.BackLabel = new System.Windows.Forms.Label();
            this.FootballEditionSmallLabel = new System.Windows.Forms.Label();
            this.BingoSmallLabel = new System.Windows.Forms.Label();
            this.DifficultLabel = new System.Windows.Forms.Label();
            this.EasyRadioButton = new System.Windows.Forms.RadioButton();
            this.EasyLabel = new System.Windows.Forms.Label();
            this.AverageLabel = new System.Windows.Forms.Label();
            this.AverageRadioButton = new System.Windows.Forms.RadioButton();
            this.FullHouseLabel = new System.Windows.Forms.Label();
            this.FullHouseRadioButton = new System.Windows.Forms.RadioButton();
            this.ModificatorLabel = new System.Windows.Forms.Label();
            this.ModificatorsComboBox = new System.Windows.Forms.ComboBox();
            this.CountPlayers = new System.Windows.Forms.Label();
            this.CountPlayersNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.StartGameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CountPlayersNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // QuitLabel
            // 
            this.QuitLabel.AutoSize = true;
            this.QuitLabel.BackColor = System.Drawing.Color.Transparent;
            this.QuitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QuitLabel.Font = new System.Drawing.Font("Montserrat Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuitLabel.ForeColor = System.Drawing.Color.White;
            this.QuitLabel.Location = new System.Drawing.Point(219, 734);
            this.QuitLabel.Name = "QuitLabel";
            this.QuitLabel.Size = new System.Drawing.Size(367, 62);
            this.QuitLabel.TabIndex = 0;
            this.QuitLabel.Text = "Выйти из игры";
            this.QuitLabel.Click += new System.EventHandler(this.QuitLabel_Click);
            this.QuitLabel.MouseEnter += new System.EventHandler(this.QuitLabel_MouseEnter);
            this.QuitLabel.MouseLeave += new System.EventHandler(this.QuitLabel_MouseLeave);
            // 
            // PlayLabel
            // 
            this.PlayLabel.AutoSize = true;
            this.PlayLabel.BackColor = System.Drawing.Color.Transparent;
            this.PlayLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayLabel.Font = new System.Drawing.Font("Montserrat Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayLabel.ForeColor = System.Drawing.Color.White;
            this.PlayLabel.Location = new System.Drawing.Point(219, 655);
            this.PlayLabel.Name = "PlayLabel";
            this.PlayLabel.Size = new System.Drawing.Size(183, 62);
            this.PlayLabel.TabIndex = 1;
            this.PlayLabel.Text = "Играть";
            this.PlayLabel.Click += new System.EventHandler(this.PlayLabel_Click);
            this.PlayLabel.MouseEnter += new System.EventHandler(this.PlayLabel_MouseEnter);
            this.PlayLabel.MouseLeave += new System.EventHandler(this.PlayLabel_MouseLeave);
            // 
            // BingoLabel
            // 
            this.BingoLabel.AutoSize = true;
            this.BingoLabel.BackColor = System.Drawing.Color.Transparent;
            this.BingoLabel.Font = new System.Drawing.Font("Good Vibes Pro", 150F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BingoLabel.ForeColor = System.Drawing.Color.White;
            this.BingoLabel.Location = new System.Drawing.Point(115, 226);
            this.BingoLabel.Name = "BingoLabel";
            this.BingoLabel.Size = new System.Drawing.Size(858, 416);
            this.BingoLabel.TabIndex = 2;
            this.BingoLabel.Text = "Bingo";
            // 
            // FootballEditionLabel
            // 
            this.FootballEditionLabel.AutoSize = true;
            this.FootballEditionLabel.BackColor = System.Drawing.Color.Transparent;
            this.FootballEditionLabel.Font = new System.Drawing.Font("Inter", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FootballEditionLabel.ForeColor = System.Drawing.Color.White;
            this.FootballEditionLabel.Location = new System.Drawing.Point(267, 547);
            this.FootballEditionLabel.Name = "FootballEditionLabel";
            this.FootballEditionLabel.Size = new System.Drawing.Size(319, 57);
            this.FootballEditionLabel.TabIndex = 3;
            this.FootballEditionLabel.Text = "Football Edition";
            // 
            // BackLabel
            // 
            this.BackLabel.AutoSize = true;
            this.BackLabel.BackColor = System.Drawing.Color.Transparent;
            this.BackLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackLabel.Font = new System.Drawing.Font("Montserrat Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackLabel.ForeColor = System.Drawing.Color.White;
            this.BackLabel.Location = new System.Drawing.Point(12, 1023);
            this.BackLabel.Name = "BackLabel";
            this.BackLabel.Size = new System.Drawing.Size(163, 62);
            this.BackLabel.TabIndex = 4;
            this.BackLabel.Text = "Назад";
            this.BackLabel.Visible = false;
            this.BackLabel.Click += new System.EventHandler(this.BackLabel_Click);
            this.BackLabel.MouseEnter += new System.EventHandler(this.BackLabel_MouseEnter);
            this.BackLabel.MouseLeave += new System.EventHandler(this.BackLabel_MouseLeave);
            // 
            // FootballEditionSmallLabel
            // 
            this.FootballEditionSmallLabel.AutoSize = true;
            this.FootballEditionSmallLabel.BackColor = System.Drawing.Color.Transparent;
            this.FootballEditionSmallLabel.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FootballEditionSmallLabel.ForeColor = System.Drawing.Color.White;
            this.FootballEditionSmallLabel.Location = new System.Drawing.Point(80, 178);
            this.FootballEditionSmallLabel.Name = "FootballEditionSmallLabel";
            this.FootballEditionSmallLabel.Size = new System.Drawing.Size(159, 28);
            this.FootballEditionSmallLabel.TabIndex = 6;
            this.FootballEditionSmallLabel.Text = "Football Edition";
            this.FootballEditionSmallLabel.Visible = false;
            // 
            // BingoSmallLabel
            // 
            this.BingoSmallLabel.AutoSize = true;
            this.BingoSmallLabel.BackColor = System.Drawing.Color.Transparent;
            this.BingoSmallLabel.Font = new System.Drawing.Font("Good Vibes Pro", 75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BingoSmallLabel.ForeColor = System.Drawing.Color.White;
            this.BingoSmallLabel.Location = new System.Drawing.Point(12, 9);
            this.BingoSmallLabel.Name = "BingoSmallLabel";
            this.BingoSmallLabel.Size = new System.Drawing.Size(428, 208);
            this.BingoSmallLabel.TabIndex = 5;
            this.BingoSmallLabel.Text = "Bingo";
            this.BingoSmallLabel.Visible = false;
            // 
            // DifficultLabel
            // 
            this.DifficultLabel.AutoSize = true;
            this.DifficultLabel.BackColor = System.Drawing.Color.Transparent;
            this.DifficultLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.DifficultLabel.Font = new System.Drawing.Font("Montserrat Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DifficultLabel.ForeColor = System.Drawing.Color.White;
            this.DifficultLabel.Location = new System.Drawing.Point(36, 342);
            this.DifficultLabel.Name = "DifficultLabel";
            this.DifficultLabel.Size = new System.Drawing.Size(648, 62);
            this.DifficultLabel.TabIndex = 7;
            this.DifficultLabel.Text = "Выберете сложность игры:";
            this.DifficultLabel.Visible = false;
            // 
            // EasyRadioButton
            // 
            this.EasyRadioButton.AutoSize = true;
            this.EasyRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.EasyRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EasyRadioButton.Font = new System.Drawing.Font("Inter", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EasyRadioButton.ForeColor = System.Drawing.Color.Transparent;
            this.EasyRadioButton.Location = new System.Drawing.Point(47, 407);
            this.EasyRadioButton.Name = "EasyRadioButton";
            this.EasyRadioButton.Size = new System.Drawing.Size(407, 61);
            this.EasyRadioButton.TabIndex = 8;
            this.EasyRadioButton.Text = "лёгкая сложность";
            this.EasyRadioButton.UseVisualStyleBackColor = false;
            this.EasyRadioButton.Visible = false;
            this.EasyRadioButton.CheckedChanged += new System.EventHandler(this.StartGame_CheckedChanged);
            this.EasyRadioButton.MouseEnter += new System.EventHandler(this.EasyRadioButton_MouseEnter);
            this.EasyRadioButton.MouseLeave += new System.EventHandler(this.EasyRadioButton_MouseEnter);
            // 
            // EasyLabel
            // 
            this.EasyLabel.AutoSize = true;
            this.EasyLabel.BackColor = System.Drawing.Color.Transparent;
            this.EasyLabel.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EasyLabel.ForeColor = System.Drawing.Color.White;
            this.EasyLabel.Location = new System.Drawing.Point(80, 471);
            this.EasyLabel.Name = "EasyLabel";
            this.EasyLabel.Size = new System.Drawing.Size(573, 28);
            this.EasyLabel.TabIndex = 9;
            this.EasyLabel.Text = "(одна любая линия - вертикальная или горизонтальная)";
            this.EasyLabel.Visible = false;
            // 
            // AverageLabel
            // 
            this.AverageLabel.AutoSize = true;
            this.AverageLabel.BackColor = System.Drawing.Color.Transparent;
            this.AverageLabel.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AverageLabel.ForeColor = System.Drawing.Color.White;
            this.AverageLabel.Location = new System.Drawing.Point(80, 581);
            this.AverageLabel.Name = "AverageLabel";
            this.AverageLabel.Size = new System.Drawing.Size(543, 28);
            this.AverageLabel.TabIndex = 11;
            this.AverageLabel.Text = "(большой квадрат, малый квадрат, две линии, буква)";
            this.AverageLabel.Visible = false;
            // 
            // AverageRadioButton
            // 
            this.AverageRadioButton.AutoSize = true;
            this.AverageRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.AverageRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AverageRadioButton.Font = new System.Drawing.Font("Inter", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AverageRadioButton.ForeColor = System.Drawing.Color.Transparent;
            this.AverageRadioButton.Location = new System.Drawing.Point(47, 517);
            this.AverageRadioButton.Name = "AverageRadioButton";
            this.AverageRadioButton.Size = new System.Drawing.Size(439, 61);
            this.AverageRadioButton.TabIndex = 10;
            this.AverageRadioButton.Text = "средняя сложность";
            this.AverageRadioButton.UseVisualStyleBackColor = false;
            this.AverageRadioButton.Visible = false;
            this.AverageRadioButton.CheckedChanged += new System.EventHandler(this.AverageRadioButton_CheckedChanged);
            this.AverageRadioButton.Click += new System.EventHandler(this.AverageRadioButton_Click);
            this.AverageRadioButton.MouseEnter += new System.EventHandler(this.AverageRadioButton_MouseEnter);
            this.AverageRadioButton.MouseLeave += new System.EventHandler(this.AverageRadioButton_MouseLeave);
            // 
            // FullHouseLabel
            // 
            this.FullHouseLabel.AutoSize = true;
            this.FullHouseLabel.BackColor = System.Drawing.Color.Transparent;
            this.FullHouseLabel.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullHouseLabel.ForeColor = System.Drawing.Color.White;
            this.FullHouseLabel.Location = new System.Drawing.Point(80, 693);
            this.FullHouseLabel.Name = "FullHouseLabel";
            this.FullHouseLabel.Size = new System.Drawing.Size(161, 28);
            this.FullHouseLabel.TabIndex = 13;
            this.FullHouseLabel.Text = "(полное бинго)";
            this.FullHouseLabel.Visible = false;
            // 
            // FullHouseRadioButton
            // 
            this.FullHouseRadioButton.AutoSize = true;
            this.FullHouseRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.FullHouseRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FullHouseRadioButton.Font = new System.Drawing.Font("Inter", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullHouseRadioButton.ForeColor = System.Drawing.Color.Transparent;
            this.FullHouseRadioButton.Location = new System.Drawing.Point(47, 629);
            this.FullHouseRadioButton.Name = "FullHouseRadioButton";
            this.FullHouseRadioButton.Size = new System.Drawing.Size(475, 61);
            this.FullHouseRadioButton.TabIndex = 12;
            this.FullHouseRadioButton.Text = "Full House сложность";
            this.FullHouseRadioButton.UseVisualStyleBackColor = false;
            this.FullHouseRadioButton.Visible = false;
            this.FullHouseRadioButton.CheckedChanged += new System.EventHandler(this.StartGame_CheckedChanged);
            this.FullHouseRadioButton.MouseEnter += new System.EventHandler(this.FullHouseRadioButton_MouseEnter);
            this.FullHouseRadioButton.MouseLeave += new System.EventHandler(this.FullHouseRadioButton_MouseLeave);
            // 
            // ModificatorLabel
            // 
            this.ModificatorLabel.AutoSize = true;
            this.ModificatorLabel.BackColor = System.Drawing.Color.Transparent;
            this.ModificatorLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.ModificatorLabel.Font = new System.Drawing.Font("Montserrat Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModificatorLabel.ForeColor = System.Drawing.Color.White;
            this.ModificatorLabel.Location = new System.Drawing.Point(36, 767);
            this.ModificatorLabel.Name = "ModificatorLabel";
            this.ModificatorLabel.Size = new System.Drawing.Size(586, 62);
            this.ModificatorLabel.TabIndex = 14;
            this.ModificatorLabel.Text = "Выберете модификатор:";
            this.ModificatorLabel.Visible = false;
            // 
            // ModificatorsComboBox
            // 
            this.ModificatorsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModificatorsComboBox.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModificatorsComboBox.Items.AddRange(new object[] {
            "большой квадрат",
            "малый квадрат",
            "две линии",
            "буква П",
            "буква X",
            "буква Н",
            "буква Е",
            "буква Т"});
            this.ModificatorsComboBox.Location = new System.Drawing.Point(47, 832);
            this.ModificatorsComboBox.Name = "ModificatorsComboBox";
            this.ModificatorsComboBox.Size = new System.Drawing.Size(557, 36);
            this.ModificatorsComboBox.TabIndex = 16;
            this.ModificatorsComboBox.Visible = false;
            this.ModificatorsComboBox.SelectedValueChanged += new System.EventHandler(this.ModificatorsComboBox_SelectedValueChanged);
            // 
            // CountPlayers
            // 
            this.CountPlayers.AutoSize = true;
            this.CountPlayers.BackColor = System.Drawing.Color.Transparent;
            this.CountPlayers.Cursor = System.Windows.Forms.Cursors.Default;
            this.CountPlayers.Font = new System.Drawing.Font("Montserrat Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountPlayers.ForeColor = System.Drawing.Color.White;
            this.CountPlayers.Location = new System.Drawing.Point(36, 262);
            this.CountPlayers.Name = "CountPlayers";
            this.CountPlayers.Size = new System.Drawing.Size(502, 62);
            this.CountPlayers.TabIndex = 17;
            this.CountPlayers.Text = "Количество игроков:";
            this.CountPlayers.Visible = false;
            // 
            // CountPlayersNumericUpDown
            // 
            this.CountPlayersNumericUpDown.AutoSize = true;
            this.CountPlayersNumericUpDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CountPlayersNumericUpDown.Font = new System.Drawing.Font("Inter", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountPlayersNumericUpDown.Location = new System.Drawing.Point(544, 268);
            this.CountPlayersNumericUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.CountPlayersNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CountPlayersNumericUpDown.Name = "CountPlayersNumericUpDown";
            this.CountPlayersNumericUpDown.ReadOnly = true;
            this.CountPlayersNumericUpDown.Size = new System.Drawing.Size(75, 56);
            this.CountPlayersNumericUpDown.TabIndex = 18;
            this.CountPlayersNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CountPlayersNumericUpDown.Visible = false;
            // 
            // StartGameLabel
            // 
            this.StartGameLabel.AutoSize = true;
            this.StartGameLabel.BackColor = System.Drawing.Color.Transparent;
            this.StartGameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartGameLabel.Font = new System.Drawing.Font("Montserrat Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartGameLabel.ForeColor = System.Drawing.Color.White;
            this.StartGameLabel.Location = new System.Drawing.Point(36, 920);
            this.StartGameLabel.Name = "StartGameLabel";
            this.StartGameLabel.Size = new System.Drawing.Size(302, 62);
            this.StartGameLabel.TabIndex = 19;
            this.StartGameLabel.Text = "Начать игру";
            this.StartGameLabel.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1318, 1050);
            this.Controls.Add(this.StartGameLabel);
            this.Controls.Add(this.CountPlayersNumericUpDown);
            this.Controls.Add(this.CountPlayers);
            this.Controls.Add(this.ModificatorsComboBox);
            this.Controls.Add(this.ModificatorLabel);
            this.Controls.Add(this.FullHouseLabel);
            this.Controls.Add(this.FullHouseRadioButton);
            this.Controls.Add(this.AverageLabel);
            this.Controls.Add(this.AverageRadioButton);
            this.Controls.Add(this.EasyLabel);
            this.Controls.Add(this.EasyRadioButton);
            this.Controls.Add(this.DifficultLabel);
            this.Controls.Add(this.FootballEditionSmallLabel);
            this.Controls.Add(this.BingoSmallLabel);
            this.Controls.Add(this.BackLabel);
            this.Controls.Add(this.FootballEditionLabel);
            this.Controls.Add(this.BingoLabel);
            this.Controls.Add(this.PlayLabel);
            this.Controls.Add(this.QuitLabel);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CountPlayersNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QuitLabel;
        private System.Windows.Forms.Label PlayLabel;
        private System.Windows.Forms.Label BingoLabel;
        private System.Windows.Forms.Label FootballEditionLabel;
        private System.Windows.Forms.Label BackLabel;
        private System.Windows.Forms.Label FootballEditionSmallLabel;
        private System.Windows.Forms.Label BingoSmallLabel;
        private System.Windows.Forms.Label DifficultLabel;
        private System.Windows.Forms.RadioButton EasyRadioButton;
        private System.Windows.Forms.Label EasyLabel;
        private System.Windows.Forms.Label AverageLabel;
        private System.Windows.Forms.RadioButton AverageRadioButton;
        private System.Windows.Forms.Label FullHouseLabel;
        private System.Windows.Forms.RadioButton FullHouseRadioButton;
        private System.Windows.Forms.Label ModificatorLabel;
        private System.Windows.Forms.ComboBox ModificatorsComboBox;
        private System.Windows.Forms.Label CountPlayers;
        private System.Windows.Forms.NumericUpDown CountPlayersNumericUpDown;
        private System.Windows.Forms.Label StartGameLabel;
    }
}

