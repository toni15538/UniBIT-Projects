namespace VSP_135KNZ_MyProject
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.splitContainerFilesAndTasks = new System.Windows.Forms.SplitContainer();
            this.labelErrorReport = new System.Windows.Forms.Label();
            this.buttonRemoveFile = new System.Windows.Forms.Button();
            this.buttonAddFile = new System.Windows.Forms.Button();
            this.buttonGoToDir = new System.Windows.Forms.Button();
            this.labelLocText = new System.Windows.Forms.Label();
            this.textBoxCurDir = new System.Windows.Forms.TextBox();
            this.listViewFilesAndFolders = new System.Windows.Forms.ListView();
            this.buttonBack = new System.Windows.Forms.Button();
            this.listViewSelectedFiles = new System.Windows.Forms.ListView();
            this.groupBoxRenameOptions = new System.Windows.Forms.GroupBox();
            this.checkBoxAddTime = new System.Windows.Forms.CheckBox();
            this.checkBoxBackupFiles = new System.Windows.Forms.CheckBox();
            this.checkBoxDividerAdd = new System.Windows.Forms.CheckBox();
            this.numericUpDownSymDelNum = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownNumStart = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownNumZeroes = new System.Windows.Forms.NumericUpDown();
            this.labelNumStart = new System.Windows.Forms.Label();
            this.buttonPriorityDown = new System.Windows.Forms.Button();
            this.buttonPriorityUp = new System.Windows.Forms.Button();
            this.labelNamePriorities = new System.Windows.Forms.Label();
            this.buttonStartRename = new System.Windows.Forms.Button();
            this.listBoxNamePriorities = new System.Windows.Forms.ListBox();
            this.textBoxAddName = new System.Windows.Forms.TextBox();
            this.textBoxExtChange = new System.Windows.Forms.TextBox();
            this.labelExtChange = new System.Windows.Forms.Label();
            this.labelNumZeroes = new System.Windows.Forms.Label();
            this.checkBoxExtChange = new System.Windows.Forms.CheckBox();
            this.checkBoxAddNum = new System.Windows.Forms.CheckBox();
            this.checkBoxAddDate = new System.Windows.Forms.CheckBox();
            this.checkBoxAddName = new System.Windows.Forms.CheckBox();
            this.checkBoxDeleteAllSymbols = new System.Windows.Forms.CheckBox();
            this.checkBoxDeleteLastSymbols = new System.Windows.Forms.CheckBox();
            this.labelSymDelNum = new System.Windows.Forms.Label();
            this.labelProgName = new System.Windows.Forms.Label();
            this.buttonOpenLogs = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxDivider = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFilesAndTasks)).BeginInit();
            this.splitContainerFilesAndTasks.Panel1.SuspendLayout();
            this.splitContainerFilesAndTasks.Panel2.SuspendLayout();
            this.splitContainerFilesAndTasks.SuspendLayout();
            this.groupBoxRenameOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSymDelNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumZeroes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "icons8-opened-folder-16.png");
            this.imageListSmall.Images.SetKeyName(1, "icons8-document-16.png");
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerMain.IsSplitterFixed = true;
            this.splitContainerMain.Location = new System.Drawing.Point(3, 69);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.splitContainerFilesAndTasks);
            this.splitContainerMain.Panel1MinSize = 450;
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.groupBoxRenameOptions);
            this.splitContainerMain.Panel2MinSize = 204;
            this.splitContainerMain.Size = new System.Drawing.Size(806, 528);
            this.splitContainerMain.SplitterDistance = 597;
            this.splitContainerMain.TabIndex = 12;
            // 
            // splitContainerFilesAndTasks
            // 
            this.splitContainerFilesAndTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerFilesAndTasks.Location = new System.Drawing.Point(0, 0);
            this.splitContainerFilesAndTasks.Name = "splitContainerFilesAndTasks";
            this.splitContainerFilesAndTasks.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerFilesAndTasks.Panel1
            // 
            this.splitContainerFilesAndTasks.Panel1.Controls.Add(this.labelErrorReport);
            this.splitContainerFilesAndTasks.Panel1.Controls.Add(this.buttonRemoveFile);
            this.splitContainerFilesAndTasks.Panel1.Controls.Add(this.buttonAddFile);
            this.splitContainerFilesAndTasks.Panel1.Controls.Add(this.buttonGoToDir);
            this.splitContainerFilesAndTasks.Panel1.Controls.Add(this.labelLocText);
            this.splitContainerFilesAndTasks.Panel1.Controls.Add(this.textBoxCurDir);
            this.splitContainerFilesAndTasks.Panel1.Controls.Add(this.listViewFilesAndFolders);
            this.splitContainerFilesAndTasks.Panel1.Controls.Add(this.buttonBack);
            this.splitContainerFilesAndTasks.Panel1MinSize = 175;
            // 
            // splitContainerFilesAndTasks.Panel2
            // 
            this.splitContainerFilesAndTasks.Panel2.Controls.Add(this.listViewSelectedFiles);
            this.splitContainerFilesAndTasks.Panel2MinSize = 150;
            this.splitContainerFilesAndTasks.Size = new System.Drawing.Size(597, 528);
            this.splitContainerFilesAndTasks.SplitterDistance = 303;
            this.splitContainerFilesAndTasks.TabIndex = 17;
            // 
            // labelErrorReport
            // 
            this.labelErrorReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelErrorReport.AutoSize = true;
            this.labelErrorReport.ForeColor = System.Drawing.Color.Red;
            this.labelErrorReport.Location = new System.Drawing.Point(177, 280);
            this.labelErrorReport.Name = "labelErrorReport";
            this.labelErrorReport.Size = new System.Drawing.Size(0, 13);
            this.labelErrorReport.TabIndex = 7;
            // 
            // buttonRemoveFile
            // 
            this.buttonRemoveFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRemoveFile.CausesValidation = false;
            this.buttonRemoveFile.Image = global:: VSP_135KNZ_MyProject.Properties.Resources.icons8_cancel_16;
            this.buttonRemoveFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRemoveFile.Location = new System.Drawing.Point(89, 273);
            this.buttonRemoveFile.Name = "buttonRemoveFile";
            this.buttonRemoveFile.Size = new System.Drawing.Size(84, 27);
            this.buttonRemoveFile.TabIndex = 18;
            this.buttonRemoveFile.Text = "Премахни";
            this.buttonRemoveFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRemoveFile.UseVisualStyleBackColor = true;
            this.buttonRemoveFile.Click += new System.EventHandler(this.buttonRemoveFile_Click);
            // 
            // buttonAddFile
            // 
            this.buttonAddFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddFile.CausesValidation = false;
            this.buttonAddFile.Image = global:: VSP_135KNZ_MyProject.Properties.Resources.icons8_plus_16;
            this.buttonAddFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddFile.Location = new System.Drawing.Point(4, 273);
            this.buttonAddFile.Name = "buttonAddFile";
            this.buttonAddFile.Size = new System.Drawing.Size(84, 27);
            this.buttonAddFile.TabIndex = 17;
            this.buttonAddFile.Text = "Добави";
            this.buttonAddFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAddFile.UseVisualStyleBackColor = true;
            this.buttonAddFile.Click += new System.EventHandler(this.buttonAddFile_Click);
            // 
            // buttonGoToDir
            // 
            this.buttonGoToDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGoToDir.Image = global:: VSP_135KNZ_MyProject.Properties.Resources.icons8_circled_right_16;
            this.buttonGoToDir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGoToDir.Location = new System.Drawing.Point(526, 1);
            this.buttonGoToDir.Name = "buttonGoToDir";
            this.buttonGoToDir.Size = new System.Drawing.Size(68, 27);
            this.buttonGoToDir.TabIndex = 16;
            this.buttonGoToDir.Text = "Отиди";
            this.buttonGoToDir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGoToDir.UseVisualStyleBackColor = true;
            this.buttonGoToDir.Click += new System.EventHandler(this.buttonGoToDir_Click);
            // 
            // labelLocText
            // 
            this.labelLocText.AutoSize = true;
            this.labelLocText.Location = new System.Drawing.Point(74, 8);
            this.labelLocText.Name = "labelLocText";
            this.labelLocText.Size = new System.Drawing.Size(72, 13);
            this.labelLocText.TabIndex = 12;
            this.labelLocText.Text = "Директория:";
            // 
            // textBoxCurDir
            // 
            this.textBoxCurDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCurDir.Location = new System.Drawing.Point(146, 5);
            this.textBoxCurDir.Name = "textBoxCurDir";
            this.textBoxCurDir.Size = new System.Drawing.Size(376, 20);
            this.textBoxCurDir.TabIndex = 15;
            // 
            // listViewFilesAndFolders
            // 
            this.listViewFilesAndFolders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewFilesAndFolders.HideSelection = false;
            this.listViewFilesAndFolders.Location = new System.Drawing.Point(4, 31);
            this.listViewFilesAndFolders.MinimumSize = new System.Drawing.Size(448, 100);
            this.listViewFilesAndFolders.Name = "listViewFilesAndFolders";
            this.listViewFilesAndFolders.Size = new System.Drawing.Size(590, 240);
            this.listViewFilesAndFolders.TabIndex = 13;
            this.listViewFilesAndFolders.UseCompatibleStateImageBehavior = false;
            this.listViewFilesAndFolders.View = System.Windows.Forms.View.Details;
            this.listViewFilesAndFolders.ItemActivate += new System.EventHandler(this.listViewFilesAndFolders_ItemActivate);
            // 
            // buttonBack
            // 
            this.buttonBack.CausesValidation = false;
            this.buttonBack.Image = global:: VSP_135KNZ_MyProject.Properties.Resources.icons8_go_back_16;
            this.buttonBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBack.Location = new System.Drawing.Point(4, 1);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(70, 27);
            this.buttonBack.TabIndex = 14;
            this.buttonBack.Text = "Назад";
            this.buttonBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // listViewSelectedFiles
            // 
            this.listViewSelectedFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewSelectedFiles.HideSelection = false;
            this.listViewSelectedFiles.Location = new System.Drawing.Point(4, 3);
            this.listViewSelectedFiles.Name = "listViewSelectedFiles";
            this.listViewSelectedFiles.Size = new System.Drawing.Size(590, 213);
            this.listViewSelectedFiles.TabIndex = 17;
            this.listViewSelectedFiles.UseCompatibleStateImageBehavior = false;
            this.listViewSelectedFiles.View = System.Windows.Forms.View.Details;
            // 
            // groupBoxRenameOptions
            // 
            this.groupBoxRenameOptions.Controls.Add(this.comboBoxDivider);
            this.groupBoxRenameOptions.Controls.Add(this.checkBoxAddTime);
            this.groupBoxRenameOptions.Controls.Add(this.checkBoxBackupFiles);
            this.groupBoxRenameOptions.Controls.Add(this.checkBoxDividerAdd);
            this.groupBoxRenameOptions.Controls.Add(this.numericUpDownSymDelNum);
            this.groupBoxRenameOptions.Controls.Add(this.numericUpDownNumStart);
            this.groupBoxRenameOptions.Controls.Add(this.numericUpDownNumZeroes);
            this.groupBoxRenameOptions.Controls.Add(this.labelNumStart);
            this.groupBoxRenameOptions.Controls.Add(this.buttonPriorityDown);
            this.groupBoxRenameOptions.Controls.Add(this.buttonPriorityUp);
            this.groupBoxRenameOptions.Controls.Add(this.labelNamePriorities);
            this.groupBoxRenameOptions.Controls.Add(this.buttonStartRename);
            this.groupBoxRenameOptions.Controls.Add(this.listBoxNamePriorities);
            this.groupBoxRenameOptions.Controls.Add(this.textBoxAddName);
            this.groupBoxRenameOptions.Controls.Add(this.textBoxExtChange);
            this.groupBoxRenameOptions.Controls.Add(this.labelExtChange);
            this.groupBoxRenameOptions.Controls.Add(this.labelNumZeroes);
            this.groupBoxRenameOptions.Controls.Add(this.checkBoxExtChange);
            this.groupBoxRenameOptions.Controls.Add(this.checkBoxAddNum);
            this.groupBoxRenameOptions.Controls.Add(this.checkBoxAddDate);
            this.groupBoxRenameOptions.Controls.Add(this.checkBoxAddName);
            this.groupBoxRenameOptions.Controls.Add(this.checkBoxDeleteAllSymbols);
            this.groupBoxRenameOptions.Controls.Add(this.checkBoxDeleteLastSymbols);
            this.groupBoxRenameOptions.Controls.Add(this.labelSymDelNum);
            this.groupBoxRenameOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxRenameOptions.Location = new System.Drawing.Point(0, 0);
            this.groupBoxRenameOptions.Name = "groupBoxRenameOptions";
            this.groupBoxRenameOptions.Size = new System.Drawing.Size(205, 528);
            this.groupBoxRenameOptions.TabIndex = 19;
            this.groupBoxRenameOptions.TabStop = false;
            this.groupBoxRenameOptions.Text = "Опции за редактиране";
            // 
            // checkBoxAddTime
            // 
            this.checkBoxAddTime.AutoSize = true;
            this.checkBoxAddTime.Location = new System.Drawing.Point(6, 226);
            this.checkBoxAddTime.Name = "checkBoxAddTime";
            this.checkBoxAddTime.Size = new System.Drawing.Size(112, 17);
            this.checkBoxAddTime.TabIndex = 30;
            this.checkBoxAddTime.Text = "Добавяне на час";
            this.checkBoxAddTime.UseVisualStyleBackColor = true;
            this.checkBoxAddTime.CheckedChanged += new System.EventHandler(this.checkBoxAddTime_CheckedChanged);
            // 
            // checkBoxBackupFiles
            // 
            this.checkBoxBackupFiles.AutoSize = true;
            this.checkBoxBackupFiles.Location = new System.Drawing.Point(6, 462);
            this.checkBoxBackupFiles.Name = "checkBoxBackupFiles";
            this.checkBoxBackupFiles.Size = new System.Drawing.Size(180, 30);
            this.checkBoxBackupFiles.TabIndex = 29;
            this.checkBoxBackupFiles.Text = "Архивирай файловете в папка\r\nпреди редакция";
            this.checkBoxBackupFiles.UseVisualStyleBackColor = true;
            // 
            // checkBoxDividerAdd
            // 
            this.checkBoxDividerAdd.AutoSize = true;
            this.checkBoxDividerAdd.Location = new System.Drawing.Point(6, 248);
            this.checkBoxDividerAdd.Name = "checkBoxDividerAdd";
            this.checkBoxDividerAdd.Size = new System.Drawing.Size(129, 30);
            this.checkBoxDividerAdd.TabIndex = 28;
            this.checkBoxDividerAdd.Text = "Добави разделител\r\nслед всеки елемент\r\n";
            this.checkBoxDividerAdd.UseVisualStyleBackColor = true;
            this.checkBoxDividerAdd.CheckedChanged += new System.EventHandler(this.checkBoxDividerAdd_CheckedChanged);
            // 
            // numericUpDownSymDelNum
            // 
            this.numericUpDownSymDelNum.Enabled = false;
            this.numericUpDownSymDelNum.Location = new System.Drawing.Point(108, 35);
            this.numericUpDownSymDelNum.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numericUpDownSymDelNum.Name = "numericUpDownSymDelNum";
            this.numericUpDownSymDelNum.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownSymDelNum.TabIndex = 27;
            this.numericUpDownSymDelNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownSymDelNum.ValueChanged += new System.EventHandler(this.numericUpDownSymDelNum_ValueChanged);
            // 
            // numericUpDownNumStart
            // 
            this.numericUpDownNumStart.Enabled = false;
            this.numericUpDownNumStart.Location = new System.Drawing.Point(108, 173);
            this.numericUpDownNumStart.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDownNumStart.Name = "numericUpDownNumStart";
            this.numericUpDownNumStart.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownNumStart.TabIndex = 26;
            this.numericUpDownNumStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownNumStart.ValueChanged += new System.EventHandler(this.numericUpDownNumStart_ValueChanged);
            // 
            // numericUpDownNumZeroes
            // 
            this.numericUpDownNumZeroes.Enabled = false;
            this.numericUpDownNumZeroes.Location = new System.Drawing.Point(108, 147);
            this.numericUpDownNumZeroes.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDownNumZeroes.Name = "numericUpDownNumZeroes";
            this.numericUpDownNumZeroes.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownNumZeroes.TabIndex = 25;
            this.numericUpDownNumZeroes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownNumZeroes.ValueChanged += new System.EventHandler(this.numericUpDownNumZeroes_ValueChanged);
            // 
            // labelNumStart
            // 
            this.labelNumStart.AutoSize = true;
            this.labelNumStart.Enabled = false;
            this.labelNumStart.Location = new System.Drawing.Point(23, 175);
            this.labelNumStart.Name = "labelNumStart";
            this.labelNumStart.Size = new System.Drawing.Size(66, 13);
            this.labelNumStart.TabIndex = 23;
            this.labelNumStart.Text = "Започни от:";
            // 
            // buttonPriorityDown
            // 
            this.buttonPriorityDown.Image = global:: VSP_135KNZ_MyProject.Properties.Resources.icons8_below_16;
            this.buttonPriorityDown.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPriorityDown.Location = new System.Drawing.Point(113, 372);
            this.buttonPriorityDown.Name = "buttonPriorityDown";
            this.buttonPriorityDown.Size = new System.Drawing.Size(85, 28);
            this.buttonPriorityDown.TabIndex = 22;
            this.buttonPriorityDown.Text = "Надолу";
            this.buttonPriorityDown.UseVisualStyleBackColor = true;
            this.buttonPriorityDown.Click += new System.EventHandler(this.buttonPriorityDown_Click);
            // 
            // buttonPriorityUp
            // 
            this.buttonPriorityUp.Image = global:: VSP_135KNZ_MyProject.Properties.Resources.icons8_upward_arrow_16;
            this.buttonPriorityUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPriorityUp.Location = new System.Drawing.Point(6, 372);
            this.buttonPriorityUp.Name = "buttonPriorityUp";
            this.buttonPriorityUp.Size = new System.Drawing.Size(85, 28);
            this.buttonPriorityUp.TabIndex = 21;
            this.buttonPriorityUp.Text = "Нагоре";
            this.buttonPriorityUp.UseVisualStyleBackColor = true;
            this.buttonPriorityUp.Click += new System.EventHandler(this.buttonPriorityUp_Click);
            // 
            // labelNamePriorities
            // 
            this.labelNamePriorities.AutoSize = true;
            this.labelNamePriorities.Location = new System.Drawing.Point(6, 286);
            this.labelNamePriorities.Name = "labelNamePriorities";
            this.labelNamePriorities.Size = new System.Drawing.Size(137, 13);
            this.labelNamePriorities.TabIndex = 20;
            this.labelNamePriorities.Text = "Приоритет на действията";
            // 
            // buttonStartRename
            // 
            this.buttonStartRename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonStartRename.Image = global:: VSP_135KNZ_MyProject.Properties.Resources.icons8_edit_16;
            this.buttonStartRename.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStartRename.Location = new System.Drawing.Point(6, 496);
            this.buttonStartRename.Name = "buttonStartRename";
            this.buttonStartRename.Size = new System.Drawing.Size(192, 29);
            this.buttonStartRename.TabIndex = 19;
            this.buttonStartRename.Text = "Започни преименуването";
            this.buttonStartRename.UseVisualStyleBackColor = true;
            this.buttonStartRename.Click += new System.EventHandler(this.buttonStartRename_Click);
            // 
            // listBoxNamePriorities
            // 
            this.listBoxNamePriorities.FormattingEnabled = true;
            this.listBoxNamePriorities.Location = new System.Drawing.Point(6, 303);
            this.listBoxNamePriorities.Name = "listBoxNamePriorities";
            this.listBoxNamePriorities.Size = new System.Drawing.Size(192, 69);
            this.listBoxNamePriorities.TabIndex = 13;
            // 
            // textBoxAddName
            // 
            this.textBoxAddName.Enabled = false;
            this.textBoxAddName.Location = new System.Drawing.Point(26, 97);
            this.textBoxAddName.Name = "textBoxAddName";
            this.textBoxAddName.Size = new System.Drawing.Size(172, 20);
            this.textBoxAddName.TabIndex = 12;
            this.textBoxAddName.TextChanged += new System.EventHandler(this.textBoxAddName_TextChanged);
            this.textBoxAddName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAddName_KeyPress);
            // 
            // textBoxExtChange
            // 
            this.textBoxExtChange.Enabled = false;
            this.textBoxExtChange.Location = new System.Drawing.Point(93, 438);
            this.textBoxExtChange.Name = "textBoxExtChange";
            this.textBoxExtChange.Size = new System.Drawing.Size(107, 20);
            this.textBoxExtChange.TabIndex = 11;
            this.textBoxExtChange.TextChanged += new System.EventHandler(this.textBoxExtChange_TextChanged);
            this.textBoxExtChange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxExtChange_KeyPress);
            // 
            // labelExtChange
            // 
            this.labelExtChange.AutoSize = true;
            this.labelExtChange.Enabled = false;
            this.labelExtChange.Location = new System.Drawing.Point(23, 441);
            this.labelExtChange.Name = "labelExtChange";
            this.labelExtChange.Size = new System.Drawing.Size(72, 13);
            this.labelExtChange.TabIndex = 10;
            this.labelExtChange.Text = "Нов формат:";
            // 
            // labelNumZeroes
            // 
            this.labelNumZeroes.AutoSize = true;
            this.labelNumZeroes.Enabled = false;
            this.labelNumZeroes.Location = new System.Drawing.Point(23, 149);
            this.labelNumZeroes.Name = "labelNumZeroes";
            this.labelNumZeroes.Size = new System.Drawing.Size(61, 13);
            this.labelNumZeroes.TabIndex = 8;
            this.labelNumZeroes.Text = "Брой нули:";
            // 
            // checkBoxExtChange
            // 
            this.checkBoxExtChange.AutoSize = true;
            this.checkBoxExtChange.Location = new System.Drawing.Point(6, 408);
            this.checkBoxExtChange.Name = "checkBoxExtChange";
            this.checkBoxExtChange.Size = new System.Drawing.Size(172, 30);
            this.checkBoxExtChange.TabIndex = 6;
            this.checkBoxExtChange.Text = "Смяна на формата\r\n(Това не конвертира файла!)\r\n";
            this.checkBoxExtChange.UseVisualStyleBackColor = true;
            this.checkBoxExtChange.CheckedChanged += new System.EventHandler(this.checkBoxExtChange_CheckedChanged);
            // 
            // checkBoxAddNum
            // 
            this.checkBoxAddNum.AutoSize = true;
            this.checkBoxAddNum.Location = new System.Drawing.Point(6, 129);
            this.checkBoxAddNum.Name = "checkBoxAddNum";
            this.checkBoxAddNum.Size = new System.Drawing.Size(151, 17);
            this.checkBoxAddNum.TabIndex = 5;
            this.checkBoxAddNum.Text = "Добавяне на номерация";
            this.checkBoxAddNum.UseVisualStyleBackColor = true;
            this.checkBoxAddNum.CheckedChanged += new System.EventHandler(this.checkBoxAddNum_CheckedChanged);
            // 
            // checkBoxAddDate
            // 
            this.checkBoxAddDate.AutoSize = true;
            this.checkBoxAddDate.Location = new System.Drawing.Point(6, 203);
            this.checkBoxAddDate.Name = "checkBoxAddDate";
            this.checkBoxAddDate.Size = new System.Drawing.Size(118, 17);
            this.checkBoxAddDate.TabIndex = 4;
            this.checkBoxAddDate.Text = "Добавяне на дата";
            this.checkBoxAddDate.UseVisualStyleBackColor = true;
            this.checkBoxAddDate.CheckedChanged += new System.EventHandler(this.checkBoxAddDate_CheckedChanged);
            // 
            // checkBoxAddName
            // 
            this.checkBoxAddName.AutoSize = true;
            this.checkBoxAddName.Location = new System.Drawing.Point(6, 80);
            this.checkBoxAddName.Name = "checkBoxAddName";
            this.checkBoxAddName.Size = new System.Drawing.Size(115, 17);
            this.checkBoxAddName.TabIndex = 3;
            this.checkBoxAddName.Text = "Добавяне на име";
            this.checkBoxAddName.UseVisualStyleBackColor = true;
            this.checkBoxAddName.CheckedChanged += new System.EventHandler(this.checkBoxAddName_CheckedChanged);
            // 
            // checkBoxDeleteAllSymbols
            // 
            this.checkBoxDeleteAllSymbols.AutoSize = true;
            this.checkBoxDeleteAllSymbols.Enabled = false;
            this.checkBoxDeleteAllSymbols.Location = new System.Drawing.Point(26, 57);
            this.checkBoxDeleteAllSymbols.Name = "checkBoxDeleteAllSymbols";
            this.checkBoxDeleteAllSymbols.Size = new System.Drawing.Size(101, 17);
            this.checkBoxDeleteAllSymbols.TabIndex = 2;
            this.checkBoxDeleteAllSymbols.Text = "Изтрии всичко";
            this.checkBoxDeleteAllSymbols.UseVisualStyleBackColor = true;
            this.checkBoxDeleteAllSymbols.CheckedChanged += new System.EventHandler(this.checkBoxDeleteAllSymbols_CheckedChanged);
            // 
            // checkBoxDeleteLastSymbols
            // 
            this.checkBoxDeleteLastSymbols.AutoSize = true;
            this.checkBoxDeleteLastSymbols.Location = new System.Drawing.Point(6, 18);
            this.checkBoxDeleteLastSymbols.Name = "checkBoxDeleteLastSymbols";
            this.checkBoxDeleteLastSymbols.Size = new System.Drawing.Size(146, 17);
            this.checkBoxDeleteLastSymbols.TabIndex = 1;
            this.checkBoxDeleteLastSymbols.Text = "Съкращаване на името";
            this.checkBoxDeleteLastSymbols.UseVisualStyleBackColor = true;
            this.checkBoxDeleteLastSymbols.CheckedChanged += new System.EventHandler(this.checkBoxDeleteLastSymbols_CheckedChanged);
            // 
            // labelSymDelNum
            // 
            this.labelSymDelNum.AutoSize = true;
            this.labelSymDelNum.Enabled = false;
            this.labelSymDelNum.Location = new System.Drawing.Point(23, 37);
            this.labelSymDelNum.Name = "labelSymDelNum";
            this.labelSymDelNum.Size = new System.Drawing.Size(86, 13);
            this.labelSymDelNum.TabIndex = 0;
            this.labelSymDelNum.Text = "Начални знаци:";
            // 
            // labelProgName
            // 
            this.labelProgName.AutoSize = true;
            this.labelProgName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgName.Location = new System.Drawing.Point(79, 19);
            this.labelProgName.Name = "labelProgName";
            this.labelProgName.Size = new System.Drawing.Size(213, 31);
            this.labelProgName.TabIndex = 13;
            this.labelProgName.Text = "AP BitRenamer";
            // 
            // buttonOpenLogs
            // 
            this.buttonOpenLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenLogs.CausesValidation = false;
            this.buttonOpenLogs.Image = global:: VSP_135KNZ_MyProject.Properties.Resources.icons8_document_16;
            this.buttonOpenLogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOpenLogs.Location = new System.Drawing.Point(730, 35);
            this.buttonOpenLogs.Name = "buttonOpenLogs";
            this.buttonOpenLogs.Size = new System.Drawing.Size(75, 28);
            this.buttonOpenLogs.TabIndex = 24;
            this.buttonOpenLogs.Text = "Логове";
            this.buttonOpenLogs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonOpenLogs.UseVisualStyleBackColor = true;
            this.buttonOpenLogs.Click += new System.EventHandler(this.buttonOpenLogs_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAbout.CausesValidation = false;
            this.buttonAbout.Image = global:: VSP_135KNZ_MyProject.Properties.Resources.icons8_info_16;
            this.buttonAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAbout.Location = new System.Drawing.Point(730, 5);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(75, 28);
            this.buttonAbout.TabIndex = 23;
            this.buttonAbout.Text = "Относно";
            this.buttonAbout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global:: VSP_135KNZ_MyProject.Properties.Resources.bitrenamerlogo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(8, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 64);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxDivider
            // 
            this.comboBoxDivider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDivider.Enabled = false;
            this.comboBoxDivider.FormattingEnabled = true;
            this.comboBoxDivider.Items.AddRange(new object[] {
            "-",
            "space",
            "_"});
            this.comboBoxDivider.Location = new System.Drawing.Point(141, 253);
            this.comboBoxDivider.Name = "comboBoxDivider";
            this.comboBoxDivider.Size = new System.Drawing.Size(57, 21);
            this.comboBoxDivider.TabIndex = 31;
            this.comboBoxDivider.SelectedIndexChanged += new System.EventHandler(this.comboBoxDivider_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 601);
            this.Controls.Add(this.buttonOpenLogs);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelProgName);
            this.Controls.Add(this.splitContainerMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(684, 580);
            this.Name = "Form1";
            this.Text = "AP BitRenamer";
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.splitContainerFilesAndTasks.Panel1.ResumeLayout(false);
            this.splitContainerFilesAndTasks.Panel1.PerformLayout();
            this.splitContainerFilesAndTasks.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFilesAndTasks)).EndInit();
            this.splitContainerFilesAndTasks.ResumeLayout(false);
            this.groupBoxRenameOptions.ResumeLayout(false);
            this.groupBoxRenameOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSymDelNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumZeroes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageListSmall;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Button buttonGoToDir;
        private System.Windows.Forms.TextBox textBoxCurDir;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ListView listViewFilesAndFolders;
        private System.Windows.Forms.Label labelLocText;
        private System.Windows.Forms.Label labelProgName;
        private System.Windows.Forms.SplitContainer splitContainerFilesAndTasks;
        private System.Windows.Forms.ListView listViewSelectedFiles;
        private System.Windows.Forms.Button buttonRemoveFile;
        private System.Windows.Forms.GroupBox groupBoxRenameOptions;
        private System.Windows.Forms.CheckBox checkBoxDeleteAllSymbols;
        private System.Windows.Forms.CheckBox checkBoxDeleteLastSymbols;
        private System.Windows.Forms.Label labelSymDelNum;
        private System.Windows.Forms.CheckBox checkBoxExtChange;
        private System.Windows.Forms.CheckBox checkBoxAddNum;
        private System.Windows.Forms.CheckBox checkBoxAddDate;
        private System.Windows.Forms.CheckBox checkBoxAddName;
        private System.Windows.Forms.Label labelErrorReport;
        private System.Windows.Forms.Label labelNumZeroes;
        private System.Windows.Forms.TextBox textBoxExtChange;
        private System.Windows.Forms.Label labelExtChange;
        private System.Windows.Forms.TextBox textBoxAddName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonAddFile;
        private System.Windows.Forms.Button buttonStartRename;
        private System.Windows.Forms.ListBox listBoxNamePriorities;
        private System.Windows.Forms.Label labelNamePriorities;
        private System.Windows.Forms.Button buttonPriorityDown;
        private System.Windows.Forms.Button buttonPriorityUp;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.NumericUpDown numericUpDownSymDelNum;
        private System.Windows.Forms.NumericUpDown numericUpDownNumStart;
        private System.Windows.Forms.NumericUpDown numericUpDownNumZeroes;
        private System.Windows.Forms.Label labelNumStart;
        private System.Windows.Forms.CheckBox checkBoxDividerAdd;
        private System.Windows.Forms.CheckBox checkBoxBackupFiles;
        private System.Windows.Forms.Button buttonOpenLogs;
        private System.Windows.Forms.CheckBox checkBoxAddTime;
        private System.Windows.Forms.ComboBox comboBoxDivider;
    }
}

