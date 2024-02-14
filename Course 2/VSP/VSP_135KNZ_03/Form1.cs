using System.ComponentModel;

namespace VSP_135KNZ_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.buttonOK.Enabled = false;

            this.textBoxAddress.Tag = false;
            this.textBoxAge.Tag = false;
            this.textBoxName.Tag = false;
            this.textBoxOccupation.Tag = false;

            this.textBoxName.Validating += new CancelEventHandler(textBoxEmpty_Validating);
            this.textBoxAddress.Validating += new CancelEventHandler(textBoxEmpty_Validating);
            this.textBoxOccupation.Validating += new CancelEventHandler(textBoxOccupation_Validating);
            this.textBoxAge.Validating += new CancelEventHandler(textBoxAge_Validating);
        }
        private void ValidateOK()
        {
            this.buttonOK.Enabled =
                ((bool)(this.textBoxAddress.Tag)
                && (bool)(this.textBoxName.Tag)
                && (bool)(this.textBoxOccupation.Tag)
                && (bool)(this.textBoxAge.Tag)
                );
        }

        private void textBoxEmpty_Validating(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length == 0)
            {
                tb.BackColor = Color.LightCoral;
                tb.Tag = false;
            }
            else
            {
                tb.BackColor = System.Drawing.SystemColors.Window;
                tb.Tag = true;
            }
            ValidateOK();
        }

        private void textBoxOccupation_Validating(Object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.CompareTo("Програмист") != 0 || tb.Text.Length == 0)
            {
                tb.BackColor = Color.LightCoral;
                tb.Tag = false;
            }
            else
            {
                tb.BackColor = System.Drawing.SystemColors.Window;
                tb.Tag = true;
            }
            ValidateOK();
        }

        private void textBoxAge_Validating(Object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            int Age = int.Parse(tb.Text);
            if (Age < 18 || tb.Text.Length == 0)
            {
                tb.BackColor = Color.LightCoral;
                tb.Tag = false;
            }
            else
            {
                tb.BackColor = System.Drawing.SystemColors.Window;
                tb.Tag = true;
            }
            ValidateOK();
        }


        private void buttonOK_Click(object sender, EventArgs e)
        {
            string output;

            output = "Име: " + this.textBoxName.Text + "\r\n";
            output += "Адрес: " + this.textBoxAddress.Text + "\r\n";
            output += "Професия: " + this.textBoxOccupation.Text + "\r\n";
            output += "Възраст: " + this.textBoxAge.Text + "\r\n";

            this.textBoxOutput.Text = output;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            string output;

            output = "Помощна информация: \r\n\r\n";
            output += "Име = Вашето име\r\n";
            output += "Адрес = Вашият адрес\r\n";
            output += "Професия = Единствена допустима стойност е 'Програмист'\r\n";
            output += "Възраст = Вашата вързраст";


            this.textBoxOutput.Text = output;

        }

        private void textBoxAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8) e.Handled = true;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

            TextBox tb = (TextBox)sender;
            
            if (tb.Text.Length == 0 && tb != textBoxOccupation)
            {
                tb.BackColor = Color.LightCoral;
                tb.Tag = false;
            }
            else if (tb.Text.CompareTo("Програмист") != 0 && tb.Text.Length != 0)
            {
                tb.Tag = false;
            }
            else
            {
                tb.BackColor = System.Drawing.SystemColors.Window;
                tb.Tag = true;
            }
            ValidateOK();
        }
    }
}