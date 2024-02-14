namespace VSP_135KNZ_04
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
            textBoxAge = new TextBox();
            labelAge = new Label();
            labelOutput = new Label();
            textBoxAddress = new TextBox();
            textBoxOutput = new TextBox();
            groupBoxGender = new GroupBox();
            radioButtonFemale = new RadioButton();
            radioButtonMale = new RadioButton();
            checkBoxProgrammer = new CheckBox();
            labelName = new Label();
            groupBoxGender.SuspendLayout();
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
            // textBoxAge
            // 
            textBoxAge.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxAge.Location = new Point(95, 250);
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
            labelAge.Location = new Point(13, 253);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(50, 15);
            labelAge.TabIndex = 9;
            labelAge.Text = "Възраст";
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.Location = new Point(16, 300);
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
            textBoxOutput.Location = new Point(13, 318);
            textBoxOutput.Multiline = true;
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.ReadOnly = true;
            textBoxOutput.ScrollBars = ScrollBars.Vertical;
            textBoxOutput.Size = new Size(369, 192);
            textBoxOutput.TabIndex = 13;
            // 
            // groupBoxGender
            // 
            groupBoxGender.Controls.Add(radioButtonFemale);
            groupBoxGender.Controls.Add(radioButtonMale);
            groupBoxGender.Location = new Point(16, 197);
            groupBoxGender.Name = "groupBoxGender";
            groupBoxGender.Size = new Size(366, 47);
            groupBoxGender.TabIndex = 14;
            groupBoxGender.TabStop = false;
            groupBoxGender.Text = "Пол";
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Location = new Point(197, 18);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(55, 19);
            radioButtonFemale.TabIndex = 1;
            radioButtonFemale.TabStop = true;
            radioButtonFemale.Text = "Жена";
            radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Location = new Point(46, 18);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(52, 19);
            radioButtonMale.TabIndex = 0;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Мъж";
            radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // checkBoxProgrammer
            // 
            checkBoxProgrammer.AutoSize = true;
            checkBoxProgrammer.CheckAlign = ContentAlignment.MiddleRight;
            checkBoxProgrammer.Location = new Point(16, 166);
            checkBoxProgrammer.Name = "checkBoxProgrammer";
            checkBoxProgrammer.Size = new Size(99, 19);
            checkBoxProgrammer.TabIndex = 15;
            checkBoxProgrammer.Text = "Програмист?";
            checkBoxProgrammer.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 522);
            Controls.Add(checkBoxProgrammer);
            Controls.Add(groupBoxGender);
            Controls.Add(textBoxOutput);
            Controls.Add(textBoxAddress);
            Controls.Add(labelOutput);
            Controls.Add(textBoxAge);
            Controls.Add(labelAge);
            Controls.Add(labelAddress);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            Controls.Add(buttonHelp);
            Controls.Add(buttonOK);
            MinimumSize = new Size(513, 531);
            Name = "Form1";
            Text = "Form1";
            groupBoxGender.ResumeLayout(false);
            groupBoxGender.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOK;
        private Button buttonHelp;
        private Label labelName;
        private TextBox textBoxName;
        private Label labelAddress;
        private TextBox textBoxAge;
        private Label labelAge;
        private Label labelOutput;
        private TextBox textBoxAddress;
        private TextBox textBoxOutput;
        private GroupBox groupBoxGender;
        private RadioButton radioButtonFemale;
        private RadioButton radioButtonMale;
        private CheckBox checkBoxProgrammer;
    }
}