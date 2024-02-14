namespace VSP_135KNZ_02
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
            buttonEnglish = new Button();
            buttonBulgarian = new Button();
            buttonOK = new Button();
            SuspendLayout();
            // 
            // buttonEnglish
            // 
            buttonEnglish.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEnglish.Image = Properties.Resources.miniukflag;
            buttonEnglish.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEnglish.Location = new Point(15, 12);
            buttonEnglish.Name = "buttonEnglish";
            buttonEnglish.Size = new Size(130, 46);
            buttonEnglish.TabIndex = 0;
            buttonEnglish.Text = "English";
            buttonEnglish.TextAlign = ContentAlignment.MiddleRight;
            buttonEnglish.UseVisualStyleBackColor = true;
            buttonEnglish.Click += buttonEnglish_Click;
            // 
            // buttonBulgarian
            // 
            buttonBulgarian.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBulgarian.Image = Properties.Resources.minibgflag;
            buttonBulgarian.ImageAlign = ContentAlignment.MiddleLeft;
            buttonBulgarian.Location = new Point(179, 12);
            buttonBulgarian.Name = "buttonBulgarian";
            buttonBulgarian.Size = new Size(130, 46);
            buttonBulgarian.TabIndex = 1;
            buttonBulgarian.Text = "Bulgarian";
            buttonBulgarian.TextAlign = ContentAlignment.MiddleRight;
            buttonBulgarian.UseVisualStyleBackColor = true;
            buttonBulgarian.Click += buttonBulgarian_Click;
            // 
            // buttonOK
            // 
            buttonOK.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOK.Location = new Point(125, 67);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(86, 28);
            buttonOK.TabIndex = 2;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 107);
            Controls.Add(buttonOK);
            Controls.Add(buttonBulgarian);
            Controls.Add(buttonEnglish);
            Name = "Form1";
            Text = "English";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonEnglish;
        private Button buttonBulgarian;
        private Button buttonOK;
    }
}