namespace VSP_135KNZ_05
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.labelSize = new System.Windows.Forms.Label();
            this.buttonCenter = new System.Windows.Forms.Button();
            this.buttonItalic = new System.Windows.Forms.Button();
            this.buttonUnderline = new System.Windows.Forms.Button();
            this.buttonBold = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBoxText = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.buttonLoad);
            this.panel1.Controls.Add(this.textBoxSize);
            this.panel1.Controls.Add(this.labelSize);
            this.panel1.Controls.Add(this.buttonCenter);
            this.panel1.Controls.Add(this.buttonItalic);
            this.panel1.Controls.Add(this.buttonUnderline);
            this.panel1.Controls.Add(this.buttonBold);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 40);
            this.panel1.TabIndex = 9;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(582, 8);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 23;
            this.buttonSave.Text = "Запиши";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(490, 8);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 22;
            this.buttonLoad.Text = "Отвори...";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // textBoxSize
            // 
            this.textBoxSize.Location = new System.Drawing.Point(402, 10);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(75, 20);
            this.textBoxSize.TabIndex = 21;
            this.textBoxSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSize_KeyPress);
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(356, 14);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(49, 13);
            this.labelSize.TabIndex = 20;
            this.labelSize.Text = "Размер:";
            // 
            // buttonCenter
            // 
            this.buttonCenter.Location = new System.Drawing.Point(263, 8);
            this.buttonCenter.Name = "buttonCenter";
            this.buttonCenter.Size = new System.Drawing.Size(75, 23);
            this.buttonCenter.TabIndex = 19;
            this.buttonCenter.Text = "Center";
            this.buttonCenter.UseVisualStyleBackColor = true;
            this.buttonCenter.Click += new System.EventHandler(this.buttonCenter_Click);
            // 
            // buttonItalic
            // 
            this.buttonItalic.Location = new System.Drawing.Point(178, 8);
            this.buttonItalic.Name = "buttonItalic";
            this.buttonItalic.Size = new System.Drawing.Size(75, 23);
            this.buttonItalic.TabIndex = 18;
            this.buttonItalic.Text = "Italic";
            this.buttonItalic.UseVisualStyleBackColor = true;
            this.buttonItalic.Click += new System.EventHandler(this.buttonItalic_Click);
            // 
            // buttonUnderline
            // 
            this.buttonUnderline.Location = new System.Drawing.Point(93, 8);
            this.buttonUnderline.Name = "buttonUnderline";
            this.buttonUnderline.Size = new System.Drawing.Size(75, 23);
            this.buttonUnderline.TabIndex = 17;
            this.buttonUnderline.Text = "Underline";
            this.buttonUnderline.UseVisualStyleBackColor = true;
            this.buttonUnderline.Click += new System.EventHandler(this.buttonUnderline_Click);
            // 
            // buttonBold
            // 
            this.buttonBold.Location = new System.Drawing.Point(8, 8);
            this.buttonBold.Name = "buttonBold";
            this.buttonBold.Size = new System.Drawing.Size(75, 23);
            this.buttonBold.TabIndex = 16;
            this.buttonBold.Text = "Bold";
            this.buttonBold.UseVisualStyleBackColor = true;
            this.buttonBold.Click += new System.EventHandler(this.buttonBold_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.richTextBoxText);
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(716, 410);
            this.panel2.TabIndex = 10;
            // 
            // richTextBoxText
            // 
            this.richTextBoxText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxText.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxText.Name = "richTextBoxText";
            this.richTextBoxText.Size = new System.Drawing.Size(716, 410);
            this.richTextBoxText.TabIndex = 0;
            this.richTextBoxText.Text = "";
            this.richTextBoxText.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBoxText_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(734, 489);
            this.Name = "Form1";
            this.Text = "Елементарен текстови редактор";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.TextBox textBoxSize;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Button buttonCenter;
        private System.Windows.Forms.Button buttonItalic;
        private System.Windows.Forms.Button buttonUnderline;
        private System.Windows.Forms.Button buttonBold;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBoxText;
        const string MyFile = "Test.rtf";
    }
}

