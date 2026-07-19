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
            this.components = new System.ComponentModel.Container();
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
            this.ExitPictureBox = new System.Windows.Forms.PictureBox();
            this.HomePictureBox = new System.Windows.Forms.PictureBox();
            this.FootballEditionInGameLabel = new System.Windows.Forms.Label();
            this.BingoInGameLabel = new System.Windows.Forms.Label();
            this.TimerMenu = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CountPlayersNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // QuitLabel
            // 
            this.QuitLabel.AutoSize = true;
            this.QuitLabel.BackColor = System.Drawing.Color.Transparent;
            this.QuitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QuitLabel.Font = new System.Drawing.Font("Montserrat Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuitLabel.ForeColor = System.Drawing.Color.White;
            this.QuitLabel.Location = new System.Drawing.Point(69, 635);
            this.QuitLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.QuitLabel.Name = "QuitLabel";
            this.QuitLabel.Size = new System.Drawing.Size(250, 42);
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
            this.PlayLabel.Location = new System.Drawing.Point(69, 584);
            this.PlayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PlayLabel.Name = "PlayLabel";
            this.PlayLabel.Size = new System.Drawing.Size(124, 42);
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
            this.BingoLabel.Location = new System.Drawing.Point(0, 305);
            this.BingoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BingoLabel.Name = "BingoLabel";
            this.BingoLabel.Size = new System.Drawing.Size(572, 277);
            this.BingoLabel.TabIndex = 2;
            this.BingoLabel.Text = "Bingo";
            // 
            // FootballEditionLabel
            // 
            this.FootballEditionLabel.AutoSize = true;
            this.FootballEditionLabel.BackColor = System.Drawing.Color.Transparent;
            this.FootballEditionLabel.Font = new System.Drawing.Font("Inter", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FootballEditionLabel.ForeColor = System.Drawing.Color.White;
            this.FootballEditionLabel.Location = new System.Drawing.Point(101, 514);
            this.FootballEditionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FootballEditionLabel.Name = "FootballEditionLabel";
            this.FootballEditionLabel.Size = new System.Drawing.Size(217, 39);
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
            this.BackLabel.Location = new System.Drawing.Point(25, 990);
            this.BackLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BackLabel.Name = "BackLabel";
            this.BackLabel.Size = new System.Drawing.Size(110, 42);
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
            this.FootballEditionSmallLabel.Location = new System.Drawing.Point(53, 333);
            this.FootballEditionSmallLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FootballEditionSmallLabel.Name = "FootballEditionSmallLabel";
            this.FootballEditionSmallLabel.Size = new System.Drawing.Size(110, 21);
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
            this.BingoSmallLabel.Location = new System.Drawing.Point(8, 223);
            this.BingoSmallLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BingoSmallLabel.Name = "BingoSmallLabel";
            this.BingoSmallLabel.Size = new System.Drawing.Size(287, 139);
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
            this.DifficultLabel.Location = new System.Drawing.Point(24, 428);
            this.DifficultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DifficultLabel.Name = "DifficultLabel";
            this.DifficultLabel.Size = new System.Drawing.Size(440, 42);
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
            this.EasyRadioButton.ForeColor = System.Drawing.Color.White;
            this.EasyRadioButton.Location = new System.Drawing.Point(31, 471);
            this.EasyRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.EasyRadioButton.Name = "EasyRadioButton";
            this.EasyRadioButton.Size = new System.Drawing.Size(278, 43);
            this.EasyRadioButton.TabIndex = 8;
            this.EasyRadioButton.Text = "лёгкая сложность";
            this.EasyRadioButton.UseVisualStyleBackColor = false;
            this.EasyRadioButton.Visible = false;
            this.EasyRadioButton.CheckedChanged += new System.EventHandler(this.StartGame_CheckedChanged);
            this.EasyRadioButton.MouseEnter += new System.EventHandler(this.EasyRadioButton_MouseEnter);
            this.EasyRadioButton.MouseLeave += new System.EventHandler(this.EasyRadioButton_MouseLeave);
            // 
            // EasyLabel
            // 
            this.EasyLabel.AutoSize = true;
            this.EasyLabel.BackColor = System.Drawing.Color.Transparent;
            this.EasyLabel.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EasyLabel.ForeColor = System.Drawing.Color.White;
            this.EasyLabel.Location = new System.Drawing.Point(53, 512);
            this.EasyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EasyLabel.Name = "EasyLabel";
            this.EasyLabel.Size = new System.Drawing.Size(402, 21);
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
            this.AverageLabel.Location = new System.Drawing.Point(53, 584);
            this.AverageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AverageLabel.Name = "AverageLabel";
            this.AverageLabel.Size = new System.Drawing.Size(386, 21);
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
            this.AverageRadioButton.Location = new System.Drawing.Point(31, 542);
            this.AverageRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.AverageRadioButton.Name = "AverageRadioButton";
            this.AverageRadioButton.Size = new System.Drawing.Size(298, 43);
            this.AverageRadioButton.TabIndex = 10;
            this.AverageRadioButton.Text = "средняя сложность";
            this.AverageRadioButton.UseVisualStyleBackColor = false;
            this.AverageRadioButton.Visible = false;
            this.AverageRadioButton.CheckedChanged += new System.EventHandler(this.AverageRadioButton_CheckedChanged);
            this.AverageRadioButton.MouseEnter += new System.EventHandler(this.AverageRadioButton_MouseEnter);
            this.AverageRadioButton.MouseLeave += new System.EventHandler(this.AverageRadioButton_MouseLeave);
            // 
            // FullHouseLabel
            // 
            this.FullHouseLabel.AutoSize = true;
            this.FullHouseLabel.BackColor = System.Drawing.Color.Transparent;
            this.FullHouseLabel.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullHouseLabel.ForeColor = System.Drawing.Color.White;
            this.FullHouseLabel.Location = new System.Drawing.Point(53, 656);
            this.FullHouseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FullHouseLabel.Name = "FullHouseLabel";
            this.FullHouseLabel.Size = new System.Drawing.Size(110, 21);
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
            this.FullHouseRadioButton.Location = new System.Drawing.Point(31, 615);
            this.FullHouseRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.FullHouseRadioButton.Name = "FullHouseRadioButton";
            this.FullHouseRadioButton.Size = new System.Drawing.Size(322, 43);
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
            this.ModificatorLabel.Location = new System.Drawing.Point(24, 694);
            this.ModificatorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ModificatorLabel.Name = "ModificatorLabel";
            this.ModificatorLabel.Size = new System.Drawing.Size(398, 42);
            this.ModificatorLabel.TabIndex = 14;
            this.ModificatorLabel.Text = "Выберете модификатор:";
            this.ModificatorLabel.Visible = false;
            // 
            // ModificatorsComboBox
            // 
            this.ModificatorsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModificatorsComboBox.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModificatorsComboBox.Items.AddRange(new object[] {
            "Большой квадрат",
            "Малый квадрат",
            "Две линии",
            "Буква П",
            "Буква X",
            "Буква Н",
            "Буква Е",
            "Буква Т"});
            this.ModificatorsComboBox.Location = new System.Drawing.Point(31, 736);
            this.ModificatorsComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.ModificatorsComboBox.Name = "ModificatorsComboBox";
            this.ModificatorsComboBox.Size = new System.Drawing.Size(373, 26);
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
            this.CountPlayers.Location = new System.Drawing.Point(24, 376);
            this.CountPlayers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CountPlayers.Name = "CountPlayers";
            this.CountPlayers.Size = new System.Drawing.Size(341, 42);
            this.CountPlayers.TabIndex = 17;
            this.CountPlayers.Text = "Количество игроков:";
            this.CountPlayers.Visible = false;
            // 
            // CountPlayersNumericUpDown
            // 
            this.CountPlayersNumericUpDown.AutoSize = true;
            this.CountPlayersNumericUpDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CountPlayersNumericUpDown.Font = new System.Drawing.Font("Inter", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountPlayersNumericUpDown.Location = new System.Drawing.Point(363, 380);
            this.CountPlayersNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
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
            this.CountPlayersNumericUpDown.Size = new System.Drawing.Size(50, 40);
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
            this.StartGameLabel.Location = new System.Drawing.Point(25, 940);
            this.StartGameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StartGameLabel.Name = "StartGameLabel";
            this.StartGameLabel.Size = new System.Drawing.Size(205, 42);
            this.StartGameLabel.TabIndex = 19;
            this.StartGameLabel.Text = "Начать игру";
            this.StartGameLabel.Visible = false;
            this.StartGameLabel.Click += new System.EventHandler(this.StartGameLabel_Click);
            this.StartGameLabel.MouseEnter += new System.EventHandler(this.StartGameLabel_MouseEnter);
            this.StartGameLabel.MouseLeave += new System.EventHandler(this.StartGameLabel_MouseLeave);
            // 
            // ExitPictureBox
            // 
            this.ExitPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.ExitPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitPictureBox.Image = global::Bingo.Properties.Resources.exit;
            this.ExitPictureBox.Location = new System.Drawing.Point(1862, 6);
            this.ExitPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.ExitPictureBox.Name = "ExitPictureBox";
            this.ExitPictureBox.Size = new System.Drawing.Size(31, 38);
            this.ExitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitPictureBox.TabIndex = 20;
            this.ExitPictureBox.TabStop = false;
            this.ExitPictureBox.Visible = false;
            this.ExitPictureBox.Click += new System.EventHandler(this.ExitPictureBox_Click);
            this.ExitPictureBox.MouseEnter += new System.EventHandler(this.ExitPictureBox_MouseEnter);
            this.ExitPictureBox.MouseLeave += new System.EventHandler(this.ExitPictureBox_MouseLeave);
            // 
            // HomePictureBox
            // 
            this.HomePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.HomePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomePictureBox.Image = global::Bingo.Properties.Resources.home;
            this.HomePictureBox.Location = new System.Drawing.Point(1827, 6);
            this.HomePictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.HomePictureBox.Name = "HomePictureBox";
            this.HomePictureBox.Size = new System.Drawing.Size(31, 38);
            this.HomePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HomePictureBox.TabIndex = 21;
            this.HomePictureBox.TabStop = false;
            this.HomePictureBox.Visible = false;
            this.HomePictureBox.Click += new System.EventHandler(this.HomePictureBox_Click);
            this.HomePictureBox.MouseEnter += new System.EventHandler(this.HomePictureBox_MouseEnter);
            this.HomePictureBox.MouseLeave += new System.EventHandler(this.HomePictureBox_MouseLeave);
            // 
            // FootballEditionInGameLabel
            // 
            this.FootballEditionInGameLabel.AutoSize = true;
            this.FootballEditionInGameLabel.BackColor = System.Drawing.Color.Transparent;
            this.FootballEditionInGameLabel.Font = new System.Drawing.Font("Inter", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FootballEditionInGameLabel.ForeColor = System.Drawing.Color.White;
            this.FootballEditionInGameLabel.Location = new System.Drawing.Point(918, 78);
            this.FootballEditionInGameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FootballEditionInGameLabel.Name = "FootballEditionInGameLabel";
            this.FootballEditionInGameLabel.Size = new System.Drawing.Size(78, 14);
            this.FootballEditionInGameLabel.TabIndex = 23;
            this.FootballEditionInGameLabel.Text = "Football Edition";
            this.FootballEditionInGameLabel.Visible = false;
            // 
            // BingoInGameLabel
            // 
            this.BingoInGameLabel.AutoSize = true;
            this.BingoInGameLabel.BackColor = System.Drawing.Color.Transparent;
            this.BingoInGameLabel.Font = new System.Drawing.Font("Good Vibes Pro", 50F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BingoInGameLabel.ForeColor = System.Drawing.Color.White;
            this.BingoInGameLabel.Location = new System.Drawing.Point(894, 6);
            this.BingoInGameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BingoInGameLabel.Name = "BingoInGameLabel";
            this.BingoInGameLabel.Size = new System.Drawing.Size(192, 93);
            this.BingoInGameLabel.TabIndex = 22;
            this.BingoInGameLabel.Text = "Bingo";
            this.BingoInGameLabel.Visible = false;
            // 
            // TimerMenu
            // 
            this.TimerMenu.Interval = 20;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.FootballEditionInGameLabel);
            this.Controls.Add(this.BingoInGameLabel);
            this.Controls.Add(this.HomePictureBox);
            this.Controls.Add(this.ExitPictureBox);
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
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CountPlayersNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePictureBox)).EndInit();
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
        private System.Windows.Forms.PictureBox ExitPictureBox;
        private System.Windows.Forms.PictureBox HomePictureBox;
        private System.Windows.Forms.Label FootballEditionInGameLabel;
        private System.Windows.Forms.Label BingoInGameLabel;
        private System.Windows.Forms.Timer TimerMenu;
    }
}

