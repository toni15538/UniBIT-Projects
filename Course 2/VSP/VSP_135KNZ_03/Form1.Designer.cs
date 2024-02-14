namespace VSP_135KNZ_03
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label labelName;
            buttonOK = new Button();
            buttonHelp = new Button();
            textBoxName = new TextBox();
            labelAddress = new Label();
            textBoxOccupation = new TextBox();
            labelOccupation = new Label();
            textBoxAge = new TextBox();
            labelAge = new Label();
            labelOutput = new Label();
            textBoxAddress = new TextBox();
            textBoxOutput = new TextBox();
            labelName = new Label();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(13, 19);
            labelName.Name = "labelName";
            labelName.Size = new Size(31, 15);
            labelName.TabIndex = 2;
            labelName.Text = "Име";
            // 
            // buttonOK
            // 
            buttonOK.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonOK.Location = new Point(407, 16);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(75, 23);
            buttonOK.TabIndex = 0;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp.CausesValidation = false;
            buttonHelp.Location = new Point(407, 45);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(75, 23);
            buttonHelp.TabIndex = 1;
            buttonHelp.Text = "Help";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxName.Location = new Point(95, 16);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(287, 23);
            textBoxName.TabIndex = 4;
            textBoxName.TextChanged += textBox_TextChanged;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(13, 44);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(40, 15);
            labelAddress.TabIndex = 5;
            labelAddress.Text = "Адрес";
            // 
            // textBoxOccupation
            // 
            textBoxOccupation.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxOccupation.Location = new Point(95, 166);
            textBoxOccupation.Name = "textBoxOccupation";
            textBoxOccupation.Size = new Size(287, 23);
            textBoxOccupation.TabIndex = 8;
            textBoxOccupation.TextChanged += textBox_TextChanged;
            // 
            // labelOccupation
            // 
            labelOccupation.AutoSize = true;
            labelOccupation.Location = new Point(13, 169);
            labelOccupation.Name = "labelOccupation";
            labelOccupation.Size = new Size(64, 15);
            labelOccupation.TabIndex = 7;
            labelOccupation.Text = "Професия";
            // 
            // textBoxAge
            // 
            textBoxAge.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxAge.Location = new Point(95, 195);
            textBoxAge.MaxLength = 3;
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(287, 23);
            textBoxAge.TabIndex = 10;
            textBoxAge.TextChanged += textBox_TextChanged;
            textBoxAge.KeyPress += textBoxAge_KeyPress;
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Location = new Point(13, 198);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(50, 15);
            labelAge.TabIndex = 9;
            labelAge.Text = "Възраст";
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.Location = new Point(13, 241);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(61, 15);
            labelOutput.TabIndex = 11;
            labelOutput.Text = "Резултати";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxAddress.Location = new Point(95, 41);
            textBoxAddress.Multiline = true;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.ScrollBars = ScrollBars.Vertical;
            textBoxAddress.Size = new Size(287, 119);
            textBoxAddress.TabIndex = 12;
            textBoxAddress.TextChanged += textBox_TextChanged;
            // 
            // textBoxOutput
            // 
            textBoxOutput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxOutput.Location = new Point(13, 259);
            textBoxOutput.Multiline = true;
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.ReadOnly = true;
            textBoxOutput.ScrollBars = ScrollBars.Vertical;
            textBoxOutput.Size = new Size(369, 221);
            textBoxOutput.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 492);
            Controls.Add(textBoxOutput);
            Controls.Add(textBoxAddress);
            Controls.Add(labelOutput);
            Controls.Add(textBoxAge);
            Controls.Add(labelAge);
            Controls.Add(textBoxOccupation);
            Controls.Add(labelOccupation);
            Controls.Add(labelAddress);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            Controls.Add(buttonHelp);
            Controls.Add(buttonOK);
            MinimumSize = new Size(513, 531);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOK;
        private Button buttonHelp;
        private Label labelName;
        private TextBox textBoxName;
        private Label labelAddress;
        private TextBox textBoxOccupation;
        private Label labelOccupation;
        private TextBox textBoxAge;
        private Label labelAge;
        private Label labelOutput;
        private TextBox textBoxAddress;
        private TextBox textBoxOutput;
    }
}