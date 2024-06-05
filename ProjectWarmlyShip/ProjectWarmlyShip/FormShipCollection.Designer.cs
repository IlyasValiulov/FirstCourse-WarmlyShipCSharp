namespace ProjectWarmlyShip
{
    partial class FormShipCollection
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
            groupBoxTools = new GroupBox();
            panelCompanyTools = new Panel();
            buttonByColor = new Button();
            buttonSortByType = new Button();
            buttonAddShip = new Button();
            buttonRefresh = new Button();
            maskedTextBox = new MaskedTextBox();
            buttonGoToCheck = new Button();
            buttonRemoveShip = new Button();
            buttonCreateCompany = new Button();
            panelStorage = new Panel();
            buttonCollectionDel = new Button();
            listBoxCollection = new ListBox();
            buttonCollectionAdd = new Button();
            radioButtonList = new RadioButton();
            radioButtonMassive = new RadioButton();
            textBoxCollectionName = new TextBox();
            labelCollectionName = new Label();
            comboBoxSelectorCompany = new ComboBox();
            pictureBox = new PictureBox();
            menuStrip = new MenuStrip();
            FileToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            saveFileDialog = new SaveFileDialog();
            openFileDialog = new OpenFileDialog();
            groupBoxTools.SuspendLayout();
            panelCompanyTools.SuspendLayout();
            panelStorage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTools
            // 
            groupBoxTools.Controls.Add(panelCompanyTools);
            groupBoxTools.Controls.Add(buttonCreateCompany);
            groupBoxTools.Controls.Add(panelStorage);
            groupBoxTools.Dock = DockStyle.Right;
            groupBoxTools.Location = new Point(887, 24);
            groupBoxTools.Name = "groupBoxTools";
            groupBoxTools.Size = new Size(146, 600);
            groupBoxTools.TabIndex = 0;
            groupBoxTools.TabStop = false;
            groupBoxTools.Text = "Инструменты";
            // 
            // panelCompanyTools
            // 
            panelCompanyTools.Controls.Add(buttonByColor);
            panelCompanyTools.Controls.Add(buttonSortByType);
            panelCompanyTools.Controls.Add(buttonAddShip);
            panelCompanyTools.Controls.Add(buttonRefresh);
            panelCompanyTools.Controls.Add(maskedTextBox);
            panelCompanyTools.Controls.Add(buttonGoToCheck);
            panelCompanyTools.Controls.Add(buttonRemoveShip);
            panelCompanyTools.Enabled = false;
            panelCompanyTools.Location = new Point(6, 333);
            panelCompanyTools.Name = "panelCompanyTools";
            panelCompanyTools.Size = new Size(200, 249);
            panelCompanyTools.TabIndex = 2;
            // 
            // buttonByColor
            // 
            buttonByColor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonByColor.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonByColor.Location = new Point(4, 211);
            buttonByColor.Name = "buttonByColor";
            buttonByColor.Size = new Size(133, 29);
            buttonByColor.TabIndex = 8;
            buttonByColor.Text = "Сортировка по цвету";
            buttonByColor.TextAlign = ContentAlignment.MiddleLeft;
            buttonByColor.UseVisualStyleBackColor = true;
            buttonByColor.Click += buttonByColor_Click;
            // 
            // buttonSortByType
            // 
            buttonSortByType.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonSortByType.Location = new Point(4, 176);
            buttonSortByType.Name = "buttonSortByType";
            buttonSortByType.Size = new Size(133, 29);
            buttonSortByType.TabIndex = 7;
            buttonSortByType.Text = "Сортировка по типу";
            buttonSortByType.UseVisualStyleBackColor = true;
            buttonSortByType.Click += buttonSortByType_Click;
            // 
            // buttonAddShip
            // 
            buttonAddShip.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonAddShip.Location = new Point(3, 3);
            buttonAddShip.Name = "buttonAddShip";
            buttonAddShip.Size = new Size(128, 38);
            buttonAddShip.TabIndex = 1;
            buttonAddShip.Text = "Добавление судна";
            buttonAddShip.UseVisualStyleBackColor = true;
            buttonAddShip.Click += buttonAddShip_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(4, 144);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(130, 26);
            buttonRefresh.TabIndex = 6;
            buttonRefresh.Text = "Обновить";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // maskedTextBox
            // 
            maskedTextBox.Location = new Point(3, 47);
            maskedTextBox.Mask = "00";
            maskedTextBox.Name = "maskedTextBox";
            maskedTextBox.Size = new Size(128, 23);
            maskedTextBox.TabIndex = 3;
            maskedTextBox.ValidatingType = typeof(int);
            // 
            // buttonGoToCheck
            // 
            buttonGoToCheck.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonGoToCheck.Location = new Point(4, 109);
            buttonGoToCheck.Name = "buttonGoToCheck";
            buttonGoToCheck.Size = new Size(128, 29);
            buttonGoToCheck.TabIndex = 5;
            buttonGoToCheck.Text = "Передать на тесты";
            buttonGoToCheck.UseVisualStyleBackColor = true;
            buttonGoToCheck.Click += buttonGoToCheck_Click;
            // 
            // buttonRemoveShip
            // 
            buttonRemoveShip.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonRemoveShip.Location = new Point(3, 76);
            buttonRemoveShip.Name = "buttonRemoveShip";
            buttonRemoveShip.Size = new Size(128, 27);
            buttonRemoveShip.TabIndex = 4;
            buttonRemoveShip.Text = "Удаление";
            buttonRemoveShip.UseVisualStyleBackColor = true;
            buttonRemoveShip.Click += buttonRemoveShip_Click;
            // 
            // buttonCreateCompany
            // 
            buttonCreateCompany.Location = new Point(6, 304);
            buttonCreateCompany.Name = "buttonCreateCompany";
            buttonCreateCompany.Size = new Size(128, 23);
            buttonCreateCompany.TabIndex = 8;
            buttonCreateCompany.Text = "Создать компанию";
            buttonCreateCompany.UseVisualStyleBackColor = true;
            buttonCreateCompany.Click += buttonCreateCompany_Click;
            // 
            // panelStorage
            // 
            panelStorage.Controls.Add(buttonCollectionDel);
            panelStorage.Controls.Add(listBoxCollection);
            panelStorage.Controls.Add(buttonCollectionAdd);
            panelStorage.Controls.Add(radioButtonList);
            panelStorage.Controls.Add(radioButtonMassive);
            panelStorage.Controls.Add(textBoxCollectionName);
            panelStorage.Controls.Add(labelCollectionName);
            panelStorage.Controls.Add(comboBoxSelectorCompany);
            panelStorage.Dock = DockStyle.Top;
            panelStorage.Location = new Point(3, 19);
            panelStorage.Name = "panelStorage";
            panelStorage.Size = new Size(140, 279);
            panelStorage.TabIndex = 7;
            // 
            // buttonCollectionDel
            // 
            buttonCollectionDel.Location = new Point(3, 216);
            buttonCollectionDel.Name = "buttonCollectionDel";
            buttonCollectionDel.Size = new Size(132, 23);
            buttonCollectionDel.TabIndex = 6;
            buttonCollectionDel.Text = "Удалить коллецию";
            buttonCollectionDel.UseVisualStyleBackColor = true;
            buttonCollectionDel.Click += buttonCollectionDel_Click;
            // 
            // listBoxCollection
            // 
            listBoxCollection.FormattingEnabled = true;
            listBoxCollection.ItemHeight = 15;
            listBoxCollection.Location = new Point(3, 101);
            listBoxCollection.Name = "listBoxCollection";
            listBoxCollection.Size = new Size(134, 109);
            listBoxCollection.TabIndex = 5;
            // 
            // buttonCollectionAdd
            // 
            buttonCollectionAdd.Location = new Point(3, 72);
            buttonCollectionAdd.Name = "buttonCollectionAdd";
            buttonCollectionAdd.Size = new Size(128, 23);
            buttonCollectionAdd.TabIndex = 4;
            buttonCollectionAdd.Text = "Добавить коллекцию";
            buttonCollectionAdd.UseVisualStyleBackColor = true;
            buttonCollectionAdd.Click += buttonCollectionAdd_Click;
            // 
            // radioButtonList
            // 
            radioButtonList.AutoSize = true;
            radioButtonList.Location = new Point(71, 47);
            radioButtonList.Name = "radioButtonList";
            radioButtonList.Size = new Size(66, 19);
            radioButtonList.TabIndex = 3;
            radioButtonList.TabStop = true;
            radioButtonList.Text = "Список";
            radioButtonList.UseVisualStyleBackColor = true;
            // 
            // radioButtonMassive
            // 
            radioButtonMassive.AutoSize = true;
            radioButtonMassive.Location = new Point(3, 47);
            radioButtonMassive.Name = "radioButtonMassive";
            radioButtonMassive.Size = new Size(67, 19);
            radioButtonMassive.TabIndex = 2;
            radioButtonMassive.TabStop = true;
            radioButtonMassive.Text = "Массив";
            radioButtonMassive.UseVisualStyleBackColor = true;
            // 
            // textBoxCollectionName
            // 
            textBoxCollectionName.Location = new Point(3, 18);
            textBoxCollectionName.Name = "textBoxCollectionName";
            textBoxCollectionName.Size = new Size(128, 23);
            textBoxCollectionName.TabIndex = 1;
            // 
            // labelCollectionName
            // 
            labelCollectionName.AutoSize = true;
            labelCollectionName.Location = new Point(3, 0);
            labelCollectionName.Name = "labelCollectionName";
            labelCollectionName.Size = new Size(125, 15);
            labelCollectionName.TabIndex = 0;
            labelCollectionName.Text = "Название коллекции:";
            // 
            // comboBoxSelectorCompany
            // 
            comboBoxSelectorCompany.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxSelectorCompany.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSelectorCompany.FormattingEnabled = true;
            comboBoxSelectorCompany.Items.AddRange(new object[] { "Хранилище" });
            comboBoxSelectorCompany.Location = new Point(3, 256);
            comboBoxSelectorCompany.Name = "comboBoxSelectorCompany";
            comboBoxSelectorCompany.Size = new Size(128, 23);
            comboBoxSelectorCompany.TabIndex = 0;
            comboBoxSelectorCompany.SelectedIndexChanged += ComboBoxSelectorCompany_SelectedIndexChanged;
            // 
            // pictureBox
            // 
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Location = new Point(0, 24);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(887, 600);
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { FileToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1033, 24);
            menuStrip.TabIndex = 2;
            menuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            FileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, loadToolStripMenuItem });
            FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            FileToolStripMenuItem.Size = new Size(48, 20);
            FileToolStripMenuItem.Text = "Файл";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(181, 22);
            saveToolStripMenuItem.Text = "Сохранение";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.L;
            loadToolStripMenuItem.Size = new Size(181, 22);
            loadToolStripMenuItem.Text = "Загрузка";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // saveFileDialog
            // 
            saveFileDialog.Filter = "txt file | *.txt";
            // 
            // openFileDialog
            // 
            openFileDialog.Filter = "txt file | *.txt";
            // 
            // FormShipCollection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 624);
            Controls.Add(pictureBox);
            Controls.Add(groupBoxTools);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "FormShipCollection";
            Text = "Коллекция судов";
            groupBoxTools.ResumeLayout(false);
            panelCompanyTools.ResumeLayout(false);
            panelCompanyTools.PerformLayout();
            panelStorage.ResumeLayout(false);
            panelStorage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxTools;
        private ComboBox comboBoxSelectorCompany;
        private Button buttonAddShip;
        private Button buttonGoToCheck;
        private Button buttonRemoveShip;
        private MaskedTextBox maskedTextBox;
        private PictureBox pictureBox;
        private Button buttonRefresh;
        private Panel panelStorage;
        private RadioButton radioButtonList;
        private RadioButton radioButtonMassive;
        private TextBox textBoxCollectionName;
        private Label labelCollectionName;
        private Button buttonCreateCompany;
        private Button buttonCollectionDel;
        private ListBox listBoxCollection;
        private Button buttonCollectionAdd;
        private Panel panelCompanyTools;
        private MenuStrip menuStrip;
        private ToolStripMenuItem FileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private SaveFileDialog saveFileDialog;
        private OpenFileDialog openFileDialog;
        private Button buttonByColor;
        private Button buttonSortByType;
    }
}