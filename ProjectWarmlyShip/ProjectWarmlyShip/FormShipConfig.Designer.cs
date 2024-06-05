namespace ProjectWarmlyShip
{
    partial class FormShipConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxConfig = new GroupBox();
            groupBoxColors = new GroupBox();
            panelPurple = new Panel();
            panelBlack = new Panel();
            panelGrey = new Panel();
            panelWhite = new Panel();
            panelYellow = new Panel();
            panelBlue = new Panel();
            panelGreen = new Panel();
            panelRed = new Panel();
            checkBoxFuelTank = new CheckBox();
            checkBoxPipes = new CheckBox();
            numericUpDownWeight = new NumericUpDown();
            labelWeight = new Label();
            numericUpDownSpeed = new NumericUpDown();
            labelSpeed = new Label();
            labelModifiedObject = new Label();
            labelSimpleObject = new Label();
            pictureBoxObject = new PictureBox();
            buttonAdd = new Button();
            buttonCancel = new Button();
            panelObject = new Panel();
            labelAdditionalColor = new Label();
            labelBodyColor = new Label();
            groupBoxConfig.SuspendLayout();
            groupBoxColors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxObject).BeginInit();
            panelObject.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxConfig
            // 
            groupBoxConfig.Controls.Add(groupBoxColors);
            groupBoxConfig.Controls.Add(checkBoxFuelTank);
            groupBoxConfig.Controls.Add(checkBoxPipes);
            groupBoxConfig.Controls.Add(numericUpDownWeight);
            groupBoxConfig.Controls.Add(labelWeight);
            groupBoxConfig.Controls.Add(numericUpDownSpeed);
            groupBoxConfig.Controls.Add(labelSpeed);
            groupBoxConfig.Controls.Add(labelModifiedObject);
            groupBoxConfig.Controls.Add(labelSimpleObject);
            groupBoxConfig.Dock = DockStyle.Left;
            groupBoxConfig.Location = new Point(0, 0);
            groupBoxConfig.Name = "groupBoxConfig";
            groupBoxConfig.Size = new Size(478, 239);
            groupBoxConfig.TabIndex = 0;
            groupBoxConfig.TabStop = false;
            groupBoxConfig.Text = "Параметры";
            // 
            // groupBoxColors
            // 
            groupBoxColors.Controls.Add(panelPurple);
            groupBoxColors.Controls.Add(panelBlack);
            groupBoxColors.Controls.Add(panelGrey);
            groupBoxColors.Controls.Add(panelWhite);
            groupBoxColors.Controls.Add(panelYellow);
            groupBoxColors.Controls.Add(panelBlue);
            groupBoxColors.Controls.Add(panelGreen);
            groupBoxColors.Controls.Add(panelRed);
            groupBoxColors.Location = new Point(211, 22);
            groupBoxColors.Name = "groupBoxColors";
            groupBoxColors.Size = new Size(231, 122);
            groupBoxColors.TabIndex = 8;
            groupBoxColors.TabStop = false;
            groupBoxColors.Text = "Цвета";
            // 
            // panelPurple
            // 
            panelPurple.BackColor = Color.Purple;
            panelPurple.Location = new Point(176, 73);
            panelPurple.Name = "panelPurple";
            panelPurple.Size = new Size(35, 32);
            panelPurple.TabIndex = 1;
            // 
            // panelBlack
            // 
            panelBlack.BackColor = Color.Black;
            panelBlack.Location = new Point(118, 73);
            panelBlack.Name = "panelBlack";
            panelBlack.Size = new Size(35, 32);
            panelBlack.TabIndex = 1;
            // 
            // panelGrey
            // 
            panelGrey.BackColor = Color.Gray;
            panelGrey.Location = new Point(65, 73);
            panelGrey.Name = "panelGrey";
            panelGrey.Size = new Size(35, 32);
            panelGrey.TabIndex = 4;
            // 
            // panelWhite
            // 
            panelWhite.BackColor = Color.White;
            panelWhite.Location = new Point(15, 73);
            panelWhite.Name = "panelWhite";
            panelWhite.Size = new Size(35, 32);
            panelWhite.TabIndex = 3;
            // 
            // panelYellow
            // 
            panelYellow.BackColor = Color.Yellow;
            panelYellow.Location = new Point(176, 22);
            panelYellow.Name = "panelYellow";
            panelYellow.Size = new Size(35, 32);
            panelYellow.TabIndex = 1;
            // 
            // panelBlue
            // 
            panelBlue.BackColor = Color.Blue;
            panelBlue.Location = new Point(118, 22);
            panelBlue.Name = "panelBlue";
            panelBlue.Size = new Size(35, 32);
            panelBlue.TabIndex = 2;
            // 
            // panelGreen
            // 
            panelGreen.BackColor = Color.Green;
            panelGreen.Location = new Point(65, 22);
            panelGreen.Name = "panelGreen";
            panelGreen.Size = new Size(35, 32);
            panelGreen.TabIndex = 1;
            // 
            // panelRed
            // 
            panelRed.BackColor = Color.Red;
            panelRed.Location = new Point(15, 22);
            panelRed.Name = "panelRed";
            panelRed.Size = new Size(35, 32);
            panelRed.TabIndex = 0;
            // 
            // checkBoxFuelTank
            // 
            checkBoxFuelTank.AutoSize = true;
            checkBoxFuelTank.Location = new Point(6, 202);
            checkBoxFuelTank.Name = "checkBoxFuelTank";
            checkBoxFuelTank.Size = new Size(219, 19);
            checkBoxFuelTank.TabIndex = 7;
            checkBoxFuelTank.Text = "Признак наличия топливного бака";
            checkBoxFuelTank.UseVisualStyleBackColor = true;
            // 
            // checkBoxPipes
            // 
            checkBoxPipes.AutoSize = true;
            checkBoxPipes.Location = new Point(6, 160);
            checkBoxPipes.Name = "checkBoxPipes";
            checkBoxPipes.Size = new Size(151, 19);
            checkBoxPipes.TabIndex = 6;
            checkBoxPipes.Text = "Признак наличия труб";
            checkBoxPipes.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            numericUpDownWeight.Location = new Point(80, 68);
            numericUpDownWeight.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownWeight.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDownWeight.Name = "numericUpDownWeight";
            numericUpDownWeight.Size = new Size(62, 23);
            numericUpDownWeight.TabIndex = 5;
            numericUpDownWeight.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // labelWeight
            // 
            labelWeight.AutoSize = true;
            labelWeight.Location = new Point(12, 70);
            labelWeight.Name = "labelWeight";
            labelWeight.Size = new Size(29, 15);
            labelWeight.TabIndex = 4;
            labelWeight.Text = "Вес:";
            // 
            // numericUpDownSpeed
            // 
            numericUpDownSpeed.Location = new Point(80, 32);
            numericUpDownSpeed.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownSpeed.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDownSpeed.Name = "numericUpDownSpeed";
            numericUpDownSpeed.Size = new Size(62, 23);
            numericUpDownSpeed.TabIndex = 3;
            numericUpDownSpeed.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // labelSpeed
            // 
            labelSpeed.AutoSize = true;
            labelSpeed.Location = new Point(12, 34);
            labelSpeed.Name = "labelSpeed";
            labelSpeed.Size = new Size(62, 15);
            labelSpeed.TabIndex = 2;
            labelSpeed.Text = "Скорость:";
            // 
            // labelModifiedObject
            // 
            labelModifiedObject.BorderStyle = BorderStyle.FixedSingle;
            labelModifiedObject.Location = new Point(354, 194);
            labelModifiedObject.Name = "labelModifiedObject";
            labelModifiedObject.Size = new Size(88, 33);
            labelModifiedObject.TabIndex = 1;
            labelModifiedObject.Text = "Продвинутый";
            labelModifiedObject.TextAlign = ContentAlignment.MiddleCenter;
            labelModifiedObject.MouseDown += labelObject_MouseDown;
            // 
            // labelSimpleObject
            // 
            labelSimpleObject.BorderStyle = BorderStyle.FixedSingle;
            labelSimpleObject.Location = new Point(248, 194);
            labelSimpleObject.Name = "labelSimpleObject";
            labelSimpleObject.Size = new Size(88, 33);
            labelSimpleObject.TabIndex = 0;
            labelSimpleObject.Text = "Простой";
            labelSimpleObject.TextAlign = ContentAlignment.MiddleCenter;
            labelSimpleObject.MouseDown += labelObject_MouseDown;
            // 
            // pictureBoxObject
            // 
            pictureBoxObject.Location = new Point(23, 26);
            pictureBoxObject.Name = "pictureBoxObject";
            pictureBoxObject.Size = new Size(158, 152);
            pictureBoxObject.TabIndex = 1;
            pictureBoxObject.TabStop = false;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(498, 204);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(579, 204);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // panelObject
            // 
            panelObject.AllowDrop = true;
            panelObject.Controls.Add(labelAdditionalColor);
            panelObject.Controls.Add(labelBodyColor);
            panelObject.Controls.Add(pictureBoxObject);
            panelObject.Location = new Point(484, 12);
            panelObject.Name = "panelObject";
            panelObject.Size = new Size(194, 186);
            panelObject.TabIndex = 4;
            panelObject.DragDrop += panelObject_DragDrop;
            panelObject.DragEnter += panelObject_DragEnter;
            // 
            // labelAdditionalColor
            // 
            labelAdditionalColor.AllowDrop = true;
            labelAdditionalColor.BorderStyle = BorderStyle.FixedSingle;
            labelAdditionalColor.Location = new Point(93, 0);
            labelAdditionalColor.Name = "labelAdditionalColor";
            labelAdditionalColor.Size = new Size(88, 21);
            labelAdditionalColor.TabIndex = 3;
            labelAdditionalColor.Text = "Доп цвет";
            labelAdditionalColor.TextAlign = ContentAlignment.MiddleCenter;
            labelAdditionalColor.DragDrop += labelAdditionalColor_DragDrop;
            labelAdditionalColor.DragEnter += labelAdditionalColor_DragEnter;
            // 
            // labelBodyColor
            // 
            labelBodyColor.AllowDrop = true;
            labelBodyColor.BorderStyle = BorderStyle.FixedSingle;
            labelBodyColor.Location = new Point(14, 0);
            labelBodyColor.Name = "labelBodyColor";
            labelBodyColor.Size = new Size(75, 21);
            labelBodyColor.TabIndex = 2;
            labelBodyColor.Text = "Цвет";
            labelBodyColor.TextAlign = ContentAlignment.MiddleCenter;
            labelBodyColor.DragDrop += labelBodyColor_DragDrop;
            labelBodyColor.DragEnter += labelBodyColor_DragEnter;
            // 
            // FormShipConfig
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 239);
            Controls.Add(panelObject);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAdd);
            Controls.Add(groupBoxConfig);
            Name = "FormShipConfig";
            Text = "Создание объетка";
            groupBoxConfig.ResumeLayout(false);
            groupBoxConfig.PerformLayout();
            groupBoxColors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxObject).EndInit();
            panelObject.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxConfig;
        private Label labelSimpleObject;
        private Label labelModifiedObject;
        private NumericUpDown numericUpDownWeight;
        private Label labelWeight;
        private NumericUpDown numericUpDownSpeed;
        private Label labelSpeed;
        private CheckBox checkBoxPipes;
        private CheckBox checkBoxFuelTank;
        private GroupBox groupBoxColors;
        private Panel panelRed;
        private Panel panelPurple;
        private Panel panelBlack;
        private Panel panelGrey;
        private Panel panelWhite;
        private Panel panelYellow;
        private Panel panelBlue;
        private Panel panelGreen;
        private PictureBox pictureBoxObject;
        private Button buttonAdd;
        private Button buttonCancel;
        private Panel panelObject;
        private Label labelAdditionalColor;
        private Label labelBodyColor;
    }
}