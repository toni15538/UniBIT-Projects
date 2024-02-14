namespace VSP_135KNZ_07
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
            this.labelLocText = new System.Windows.Forms.Label();
            this.listViewFilesAndFolders = new System.Windows.Forms.ListView();
            this.buttonBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonTile = new System.Windows.Forms.RadioButton();
            this.radioButtonDetails = new System.Windows.Forms.RadioButton();
            this.radioButtonList = new System.Windows.Forms.RadioButton();
            this.radioButtonSmallIcon = new System.Windows.Forms.RadioButton();
            this.radioButtonLargeIcon = new System.Windows.Forms.RadioButton();
            this.labelCurrentPath = new System.Windows.Forms.Label();
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelLocText
            // 
            this.labelLocText.AutoSize = true;
            this.labelLocText.Location = new System.Drawing.Point(12, 9);
            this.labelLocText.Name = "labelLocText";
            this.labelLocText.Size = new System.Drawing.Size(111, 13);
            this.labelLocText.TabIndex = 0;
            this.labelLocText.Text = "Текуща директория:";
            // 
            // listViewFilesAndFolders
            // 
            this.listViewFilesAndFolders.HideSelection = false;
            this.listViewFilesAndFolders.Location = new System.Drawing.Point(15, 31);
            this.listViewFilesAndFolders.Name = "listViewFilesAndFolders";
            this.listViewFilesAndFolders.Size = new System.Drawing.Size(563, 392);
            this.listViewFilesAndFolders.TabIndex = 1;
            this.listViewFilesAndFolders.UseCompatibleStateImageBehavior = false;
            this.listViewFilesAndFolders.View = System.Windows.Forms.View.Details;
            this.listViewFilesAndFolders.ItemActivate += new System.EventHandler(this.listViewFilesAndFolders_ItemActivate);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(360, 429);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonTile);
            this.groupBox1.Controls.Add(this.radioButtonDetails);
            this.groupBox1.Controls.Add(this.radioButtonList);
            this.groupBox1.Controls.Add(this.radioButtonSmallIcon);
            this.groupBox1.Controls.Add(this.radioButtonLargeIcon);
            this.groupBox1.Location = new System.Drawing.Point(592, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 229);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Опции";
            // 
            // radioButtonTile
            // 
            this.radioButtonTile.AutoSize = true;
            this.radioButtonTile.Location = new System.Drawing.Point(11, 112);
            this.radioButtonTile.Name = "radioButtonTile";
            this.radioButtonTile.Size = new System.Drawing.Size(115, 17);
            this.radioButtonTile.TabIndex = 4;
            this.radioButtonTile.Text = "Детайлен списък";
            this.radioButtonTile.UseVisualStyleBackColor = true;
            this.radioButtonTile.CheckedChanged += new System.EventHandler(this.radioButtonTile_CheckedChanged);
            // 
            // radioButtonDetails
            // 
            this.radioButtonDetails.AutoSize = true;
            this.radioButtonDetails.Checked = true;
            this.radioButtonDetails.Location = new System.Drawing.Point(11, 89);
            this.radioButtonDetails.Name = "radioButtonDetails";
            this.radioButtonDetails.Size = new System.Drawing.Size(75, 17);
            this.radioButtonDetails.TabIndex = 3;
            this.radioButtonDetails.TabStop = true;
            this.radioButtonDetails.Text = "Детайлно";
            this.radioButtonDetails.UseVisualStyleBackColor = true;
            this.radioButtonDetails.CheckedChanged += new System.EventHandler(this.radioButtonDetails_CheckedChanged);
            // 
            // radioButtonList
            // 
            this.radioButtonList.AutoSize = true;
            this.radioButtonList.Location = new System.Drawing.Point(11, 66);
            this.radioButtonList.Name = "radioButtonList";
            this.radioButtonList.Size = new System.Drawing.Size(63, 17);
            this.radioButtonList.TabIndex = 2;
            this.radioButtonList.Text = "Списък";
            this.radioButtonList.UseVisualStyleBackColor = true;
            this.radioButtonList.CheckedChanged += new System.EventHandler(this.radioButtonList_CheckedChanged);
            // 
            // radioButtonSmallIcon
            // 
            this.radioButtonSmallIcon.AutoSize = true;
            this.radioButtonSmallIcon.Location = new System.Drawing.Point(11, 43);
            this.radioButtonSmallIcon.Name = "radioButtonSmallIcon";
            this.radioButtonSmallIcon.Size = new System.Drawing.Size(91, 17);
            this.radioButtonSmallIcon.TabIndex = 1;
            this.radioButtonSmallIcon.Text = "Малки икони";
            this.radioButtonSmallIcon.UseVisualStyleBackColor = true;
            this.radioButtonSmallIcon.CheckedChanged += new System.EventHandler(this.radioButtonSmallIcon_CheckedChanged);
            // 
            // radioButtonLargeIcon
            // 
            this.radioButtonLargeIcon.AutoSize = true;
            this.radioButtonLargeIcon.Location = new System.Drawing.Point(11, 20);
            this.radioButtonLargeIcon.Name = "radioButtonLargeIcon";
            this.radioButtonLargeIcon.Size = new System.Drawing.Size(96, 17);
            this.radioButtonLargeIcon.TabIndex = 0;
            this.radioButtonLargeIcon.Text = "Големи икони";
            this.radioButtonLargeIcon.UseVisualStyleBackColor = true;
            this.radioButtonLargeIcon.CheckedChanged += new System.EventHandler(this.radioButtonLargeIcon_CheckedChanged);
            // 
            // labelCurrentPath
            // 
            this.labelCurrentPath.AutoSize = true;
            this.labelCurrentPath.Location = new System.Drawing.Point(124, 9);
            this.labelCurrentPath.Name = "labelCurrentPath";
            this.labelCurrentPath.Size = new System.Drawing.Size(27, 13);
            this.labelCurrentPath.TabIndex = 4;
            this.labelCurrentPath.Text = "N/A";
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "redfoldersmall.ico");
            this.imageListSmall.Images.SetKeyName(1, "bluedocusmall.ico");
            // 
            // imageListLarge
            // 
            this.imageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLarge.ImageStream")));
            this.imageListLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListLarge.Images.SetKeyName(0, "redfolder.ico");
            this.imageListLarge.Images.SetKeyName(1, "bluedocu.ico");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.labelCurrentPath);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.listViewFilesAndFolders);
            this.Controls.Add(this.labelLocText);
            this.MaximumSize = new System.Drawing.Size(816, 504);
            this.MinimumSize = new System.Drawing.Size(816, 504);
            this.Name = "Form1";
            this.Text = "Изобразяване на файлове и папки";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLocText;
        private System.Windows.Forms.ListView listViewFilesAndFolders;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonTile;
        private System.Windows.Forms.RadioButton radioButtonDetails;
        private System.Windows.Forms.RadioButton radioButtonList;
        private System.Windows.Forms.RadioButton radioButtonSmallIcon;
        private System.Windows.Forms.RadioButton radioButtonLargeIcon;
        private System.Windows.Forms.Label labelCurrentPath;
        private System.Windows.Forms.ImageList imageListSmall;
        private System.Windows.Forms.ImageList imageListLarge;
    }
}

