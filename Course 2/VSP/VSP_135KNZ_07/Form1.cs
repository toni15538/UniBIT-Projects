using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VSP_135KNZ_07
{
    public partial class Form1 : Form
    {
        private System.Collections.Specialized.StringCollection folderCol;
        public Form1()
        {
            InitializeComponent();
            folderCol = new System.Collections.Specialized.StringCollection();
            CreateHeadersAndFillListView();
            PaintListView(@"C:\");
            folderCol.Add(@"C:\");
        }

        private void PaintListView(string root)
        {
            listViewFilesAndFolders.SmallImageList = imageListSmall;
            listViewFilesAndFolders.LargeImageList = imageListLarge;
            try
            {
                ListViewItem lvi;
                ListViewItem.ListViewSubItem lvsi;

                if (root.CompareTo("") == 0) return;

                DirectoryInfo dir = new DirectoryInfo(root);

                DirectoryInfo[] dirs = dir.GetDirectories();
                FileInfo[] files = dir.GetFiles();

                this.listViewFilesAndFolders.Items.Clear();
                this.labelCurrentPath.Text = root;
                this.listViewFilesAndFolders.BeginUpdate();

                foreach (DirectoryInfo direc in dirs)
                {
                    lvi = new ListViewItem();
                    lvi.Text = direc.Name;
                    lvi.ImageIndex = 0;
                    lvi.Tag = direc.FullName;
                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = "";
                    lvi.SubItems.Add(lvsi);
                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = direc.LastAccessTime.ToString();
                    lvi.SubItems.Add(lvsi);
                    this.listViewFilesAndFolders.Items.Add(lvi);
                }
                foreach (FileInfo file in files)
                {
                    lvi = new ListViewItem();
                    lvi.Text = file.Name;
                    lvi.ImageIndex = 1;
                    lvi.Tag = file.FullName;
                    lvsi = new ListViewItem.ListViewSubItem();
                    string size = file.Length.ToString();
                    lvsi.Text = ConvertToReadableBytes(size); ;
                    lvi.SubItems.Add(lvsi);
                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = file.LastAccessTime.ToString();
                    lvi.SubItems.Add(lvsi);
                    this.listViewFilesAndFolders.Items.Add(lvi);
                }
                this.listViewFilesAndFolders.EndUpdate();
            }
            catch (System.Exception err)
            {
                MessageBox.Show("Грешка: "+err.Message);
            }
        }

        private void CreateHeadersAndFillListView()
        {
            ColumnHeader colHead;
            colHead = new ColumnHeader();
            colHead.Text = "Файл/Папка";
            colHead.Width = 200;
            this.listViewFilesAndFolders.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "Размер";
            colHead.Width = 100;
            this.listViewFilesAndFolders.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "Модифициран";
            colHead.Width = 200;
            this.listViewFilesAndFolders.Columns.Add(colHead);
        }

        private void listViewFilesAndFolders_ItemActivate(object sender, EventArgs e)
        {
            System.Windows.Forms.ListView lw = (System.Windows.Forms.ListView)sender;
            string filename = lw.SelectedItems[0].Tag.ToString(); 
            if (lw.SelectedItems[0].ImageIndex != 0 )
            {
                try{
                    System.Diagnostics.Process.Start(filename);
                }
                catch
                {
                    return;
                }
            }
            else 
            {
                PaintListView(filename);
                folderCol.Add(filename);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (folderCol.Count > 1)
            {
                PaintListView(folderCol[folderCol.Count - 2].ToString());
                folderCol.RemoveAt(folderCol.Count - 1);
            }
            else
            {
                PaintListView(folderCol[0].ToString());
            }
        }


        private string ConvertToReadableBytes(string size)
        {
            try
            {

            
               double sizenum = double.Parse(size);


                if (sizenum > 1073741824)
                {
                    sizenum /= 1073741824;
                    sizenum = Math.Round(sizenum, 2);
                    string result = sizenum.ToString() + "G";
                    return result;
                }
                else if (sizenum > 1048576)
                {
                    sizenum /= 1048576;
                    sizenum = Math.Round(sizenum,2);
                    string result = sizenum.ToString() + "M";
                    return result;
                }
                else if (sizenum > 1024)
                {
                    sizenum /= 1024;
                    sizenum = Math.Round(sizenum, 2);
                    string result = sizenum.ToString() + "K";
                    return result;
                }
                else
                {
                    string result = sizenum.ToString() + "B";
                    return result;
                }
                
            }
            catch
            {
                return "NaN";
            }
           
        }

        private void radioButtonDetails_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
            {
                this.listViewFilesAndFolders.View = View.Details;
            }
        }

        private void radioButtonTile_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
            {
                this.listViewFilesAndFolders.View = View.Tile;
            }
        }

        private void radioButtonList_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
            {
                this.listViewFilesAndFolders.View = View.List;
            }
        }

        private void radioButtonSmallIcon_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
            {
                this.listViewFilesAndFolders.View = View.SmallIcon;
            }
        }

        private void radioButtonLargeIcon_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
            {
                this.listViewFilesAndFolders.View = View.LargeIcon;
            }
        }
    }
}
