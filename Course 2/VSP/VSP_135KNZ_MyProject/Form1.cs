using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace VSP_135KNZ_MyProject
{
    //AP BITRENAMER
    //От Антонио Петков, 2. курс, специалност КН, Фак. Ном. 135КНЗ
    //Тази програма използва класа FileBlock.cs
    //Повече информация вижте в документа към програмата

    public partial class Form1 : Form
    {
        private List<FileBlock> selectedFiles = new List<FileBlock>(); // Лист с избраните файлове
        private System.Collections.Specialized.StringCollection folderCol;
        private string userroot = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile); //Директорията на потребителя
        string currentdir; //Променлива за сегашната директория
        bool direrror = false; //Променлива при грешка с директорията
        public Form1()
        {
            InitializeComponent();
            listBoxNamePriorities.Items.Add("Старо име");
            comboBoxDivider.SelectedIndex = 0;
            folderCol = new System.Collections.Specialized.StringCollection();
            CreateHeadersAndFillListView();
            MakeHeadersSelectedFilesList();
            folderCol.Add(@"C:\");
            folderCol.Add(@"C:\Users");
            currentdir = userroot;
            PaintListView(userroot);
            folderCol.Add(userroot);
            PaintSelectedFilesView();
        }

        //действия по обновяването на интерфейса и валидация
        //Съкращаване на името
        private void checkBoxDeleteLastSymbols_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDeleteLastSymbols.Checked && checkBoxDeleteAllSymbols.Checked)
            {
                numericUpDownSymDelNum.Enabled = false;
                labelSymDelNum.Enabled = false;
                checkBoxDeleteAllSymbols.Enabled = true;
                listBoxNamePriorities.Items.Remove("Старо име");
            }
            else if (checkBoxDeleteLastSymbols.Checked && !checkBoxDeleteAllSymbols.Checked)
            {
                numericUpDownSymDelNum.Enabled = true;
                labelSymDelNum.Enabled = true;
                checkBoxDeleteAllSymbols.Enabled = true;
            }
            else
            {
                numericUpDownSymDelNum.Enabled = false;
                labelSymDelNum.Enabled = false;
                checkBoxDeleteAllSymbols.Enabled = false;
                if (checkBoxDeleteAllSymbols.Checked) listBoxNamePriorities.Items.Add("Старо име");
            }
            UpdateNewNames();
        }

        //Изтриване на цялото име(без формата)
        private void checkBoxDeleteAllSymbols_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDeleteAllSymbols.Checked)
            {
                numericUpDownSymDelNum.Enabled = false;
                labelSymDelNum.Enabled = false;
                listBoxNamePriorities.Items.Remove("Старо име");
            }
            else
            {
                numericUpDownSymDelNum.Enabled = true;
                labelSymDelNum.Enabled = true;
                listBoxNamePriorities.Items.Add("Старо име");
            }
            UpdateNewNames();
        }

        //Добавяне на ново име
        private void checkBoxAddName_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAddName.Checked)
            {
                textBoxAddName.Enabled = true;
                listBoxNamePriorities.Items.Add("Ново име");
            }
            else
            {
                textBoxAddName.Enabled = false;
                listBoxNamePriorities.Items.Remove("Ново име");
            }
            UpdateNewNames();
        }

        //Добавяне на номерация в името
        private void checkBoxAddNum_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAddNum.Checked)
            {
                numericUpDownNumZeroes.Enabled = true;
                labelNumZeroes.Enabled = true;
                numericUpDownNumStart.Enabled = true;
                labelNumStart.Enabled = true;
                listBoxNamePriorities.Items.Add("Номер");
            }
            else
            {
                numericUpDownNumZeroes.Enabled = false;
                labelNumZeroes.Enabled = false;
                numericUpDownNumStart.Enabled = false;
                labelNumStart.Enabled = false;
                listBoxNamePriorities.Items.Remove("Номер");
            }
            UpdateNewNames();
        }

        //Добавяне на дата към името
        private void checkBoxAddDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAddDate.Checked)
            {
                listBoxNamePriorities.Items.Add("Дата");
            }
            else
            {
                listBoxNamePriorities.Items.Remove("Дата");
            }
            UpdateNewNames();
        }

        //Добавяне на час към името
        private void checkBoxAddTime_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxAddTime.Checked)
            {
                listBoxNamePriorities.Items.Add("Час");
            }
            else
            {
                listBoxNamePriorities.Items.Remove("Час");
            }
            UpdateNewNames();
        }

        //Смяна на формата(без конвертиране)
        private void checkBoxExtChange_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxExtChange.Checked)
            {
                textBoxExtChange.Enabled = true;
                labelExtChange.Enabled = true;
            }
            else
            {
                textBoxExtChange.Enabled = false;
                labelExtChange.Enabled = false;
            }
            UpdateNewNames();
        }

        //Добавяне на разделител между елементите
        private void checkBoxDividerAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDividerAdd.Checked) comboBoxDivider.Enabled = true;
            else comboBoxDivider.Enabled = false;
            UpdateNewNames();
        }


        //Отваря формата 'Относно'
        private void buttonAbout_Click(object sender, EventArgs e)
        {
            FormAbout form = new FormAbout();
            form.ShowDialog();

        }




        //Действия на програмата


        //Отваря избрания файл или папка, ако е папка, тя се отваря в програмата 
        private void listViewFilesAndFolders_ItemActivate(object sender, EventArgs e)
        {
            System.Windows.Forms.ListView lw = (System.Windows.Forms.ListView)sender;
            string filename = lw.SelectedItems[0].Tag.ToString();
            if (lw.SelectedItems[0].ImageIndex != 0)
            {
                try
                {
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
                if (!direrror)
                {
                    folderCol.Add(filename);
                    currentdir = filename;
                }
            }
        }

        // Променя имената на избраните файлове и ги записва в техните елементи от типа FileBlock
        private void UpdateNewNames()
        {
            try
            {
                decimal counter = numericUpDownNumStart.Value;
                //Файл от списъка с избрани файлове
                foreach (FileBlock item in selectedFiles)
                {

                    //опит за запазване на формата 
                    string[] oldfullname = item.FileName.ToString().Split('.');
                    int nameparts = oldfullname.Length;

                    //конструиране на старото име
                    string oldname = "";
                    for (int i = 0; i < nameparts - 1; i++)
                    {
                        if (i != 0) oldname += ".";
                        oldname += oldfullname[i];
                    }

                    //стария формат
                    string oldextention = "." + oldfullname[nameparts - 1];

                    string newname = "";
                    //начало на действие по приоритет
                    foreach (string action in this.listBoxNamePriorities.Items)
                    {
                        //Добавяне на разделител
                        if (newname != "" && this.checkBoxDividerAdd.Checked)
                        {
                            if (comboBoxDivider.SelectedIndex == 0) newname += "-";
                            if (comboBoxDivider.SelectedIndex == 1) newname += " ";
                            if (comboBoxDivider.SelectedIndex == 2) newname += "_";
                        }

                        //Съкращаване или оставяне на старото име
                        if (action == "Старо име")
                        {
                            if (checkBoxDeleteLastSymbols.Checked)
                            {
                                for (int i = 0; i < numericUpDownSymDelNum.Value; i++)
                                {
                                    if (i <= oldname.Length - 1) newname += oldname[i];
                                }
                            }
                            else newname = oldname;
                        }

                        //Добавяне на номерация
                        else if (action == "Номер")
                        {

                            for (int i = counter.ToString().Length; i < numericUpDownNumZeroes.Value; i++)
                            {
                                newname += "0";
                            }
                            newname += counter;
                        }

                        //Добавяне на дата
                        else if (action == "Дата")
                        {
                            newname += item.DateCreated.Day.ToString() + "-" + item.DateCreated.Month.ToString() + "-" + item.DateCreated.Year.ToString();
                        }

                        //Добавяне на час
                        else if (action == "Час")
                        {
                            string hour;
                            string minute;
                            string second;
                            if (item.DateCreated.Hour < 10) hour = "0" + item.DateCreated.Hour.ToString();
                            else hour = item.DateCreated.Hour.ToString();
                            if (item.DateCreated.Minute < 10) minute = "0" + item.DateCreated.Minute.ToString();
                            else minute = item.DateCreated.Minute.ToString();
                            if (item.DateCreated.Second < 10) second = "0" + item.DateCreated.Second.ToString();
                            else second = item.DateCreated.Second.ToString();
                            newname += hour + "-" + minute + "-" + second;
                        }

                        //Добавяне на дата
                        else if (action == "Ново име") newname += textBoxAddName.Text;

                    }
                    //смяна на формата (без конвертиране)
                    if (checkBoxExtChange.Checked)
                    {
                        string newextention = textBoxExtChange.Text;
                        if (newextention != "") newextention = "." + newextention;
                        item.NewFileName = newname + newextention;
                    }
                    else
                    {
                        item.NewFileName = newname + oldextention;
                    }

                    counter++;


                }
                //Проверка за дублирани файлове и валидиране
                var keyscheck = new HashSet<string>();
                foreach (FileBlock file in selectedFiles)
                {
                    if (!keyscheck.Add(file.NewFileName + "," + file.Location))
                    {
                        buttonStartRename.Enabled = false;
                        labelErrorReport.Text = "Намерени потенциални дубликати! Моля, сменете метода на преименуване!";
                        break;
                    }
                    labelErrorReport.Text = "";
                    buttonStartRename.Enabled = true;
                }

                PaintSelectedFilesView();


            }

            catch (Exception err)
            {
                WriteToLog("Грешка в програмата! " + err.Message);
                MessageBox.Show("Грешка в програмата! " + err.Message, "Грешка в програмата!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelErrorReport.Text = "Грешка :" + err.Message;
            }
        }

        //Връщане назад с една директория
        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (folderCol.Count > 1)
            {
                PaintListView(folderCol[folderCol.Count - 2].ToString());
                currentdir = folderCol[folderCol.Count - 2].ToString();
                folderCol.RemoveAt(folderCol.Count - 1);

            }
            else
            {
                PaintListView(folderCol[0].ToString());
            }
        }

        //Отиване на посочената директория, при грешка изписва грешката и не прави нищо
        private void buttonGoToDir_Click(object sender, EventArgs e)
        {
            labelErrorReport.Text = "";
            PaintListView(textBoxCurDir.Text);
            currentdir = textBoxCurDir.Text;
            folderCol.Add(textBoxCurDir.Text);

        }

        //Конвентира дадения файлов размер в четлив формат за потребителя, например 1048576 ще изведе 1M - 1 мегабайт
        private string ConvertToReadableBytes(string size)
        {
            try
            {

                //взима размера на файла
                double sizenum = double.Parse(size);

                //гигабайт
                if (sizenum > 1073741824)
                {
                    sizenum /= 1073741824;
                    sizenum = Math.Round(sizenum, 2);
                    string result = sizenum.ToString() + "G";
                    return result;
                }
                //мегабайт
                else if (sizenum > 1048576)
                {
                    sizenum /= 1048576;
                    sizenum = Math.Round(sizenum, 2);
                    string result = sizenum.ToString() + "M";
                    return result;
                }
                //килобайт
                else if (sizenum > 1024)
                {
                    sizenum /= 1024;
                    sizenum = Math.Round(sizenum, 2);
                    string result = sizenum.ToString() + "K";
                    return result;
                }
                //байт
                else
                {
                    string result = sizenum.ToString() + "B";
                    return result;
                }

            }
            //ако стане грешка, било то твърде голямо число или грешка в изчислението, то връща за размер N/A
            catch
            {
                WriteToLog("Грешка в изчисляването на размера!");
                return "N/A";
            }

        }

        //Добавя се файла към списъка за преименуване, ако е папка или вече добавен, не се добавя и се изписва грешка до бутона 
        private void buttonAddFile_Click(object sender, EventArgs e)
        {

            labelErrorReport.Text = "";
            try
            {
                foreach (System.Windows.Forms.ListViewItem file in listViewFilesAndFolders.SelectedItems)
                {
                    FileInfo fileInfoBuffer = new FileInfo(file.Tag.ToString());
                    if (file.ImageIndex != 0)
                    {

                        FileBlock filebuffer = new FileBlock(fileInfoBuffer.Name, fileInfoBuffer.Directory.ToString(), fileInfoBuffer.LastWriteTime);
                        //при празен списък
                        if (selectedFiles.Count == 0)
                        {
                            selectedFiles.Add(filebuffer);
                        }
                        else
                        {

                            int duplicate = 0;
                            foreach (FileBlock filechecked in selectedFiles.ToList())
                            {
                                //файлът вече е в списъка
                                if (filebuffer.FileName == filechecked.FileName && filebuffer.Location == filechecked.Location)
                                {
                                    WriteToLog($"Грешка в добавянето на файл {filebuffer.FileName}, вече съществува в списъка");
                                    labelErrorReport.Text = "ГРЕШКА: Един или повече елемента не бяха добавени! Вече съществуват в списъка";
                                    duplicate++;
                                }


                            }
                            //ако не е намерен дубликат, файла се добавя
                            if (duplicate == 0) selectedFiles.Add(filebuffer);
                        }

                    }
                    //избрана е папка и се принтира грешка до бутоните
                    else
                    {
                        WriteToLog($"Грешка в добавянето на файл {file.Text}, избрания елемент е папка!");
                        labelErrorReport.Text = "ГРЕШКА: Един или повече елемента не бяха добавени! Избрани са папки";
                    }

                }
                UpdateNewNames();
                PaintSelectedFilesView();
            }
            catch (System.Exception err)
            {
                WriteToLog("Грешка при добавянето на файлове! " + err.Message);
                MessageBox.Show("Грешка при добавянето на файлове! " + err.Message, "Грешка при добавянето на файлове!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelErrorReport.Text = "Грешка при добавянето на файлове! " + err.Message;
            }

        }


        //Създава изгледа на формата за файловия мениджър
        private void CreateHeadersAndFillListView()
        {
            ColumnHeader colHead;
            colHead = new ColumnHeader();
            colHead.Text = "Име";
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

        //Създава изгледа за избраните файлове за преименуване
        private void MakeHeadersSelectedFilesList()
        {
            ColumnHeader colHead;
            colHead = new ColumnHeader();
            colHead.Text = "Старо име";
            colHead.Width = 150;
            this.listViewSelectedFiles.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "Ново име";
            colHead.Width = 150;
            this.listViewSelectedFiles.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "Директория";
            colHead.Width = 200;
            this.listViewSelectedFiles.Columns.Add(colHead);
        }

        //Обновява ListView за файловия мениджър 
        private void PaintListView(string root)
        {
            listViewFilesAndFolders.SmallImageList = imageListSmall;
            direrror = false;
            try
            {
                ListViewItem lvi;
                ListViewItem.ListViewSubItem lvsi;

                if (root.CompareTo("") == 0) return;

                DirectoryInfo dir = new DirectoryInfo(root);

                DirectoryInfo[] dirs = dir.GetDirectories();
                FileInfo[] files = dir.GetFiles();

                this.listViewFilesAndFolders.Items.Clear();
                this.textBoxCurDir.Text = root;
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
                    lvsi.Text = file.LastWriteTime.ToString();
                    lvi.SubItems.Add(lvsi);
                    this.listViewFilesAndFolders.Items.Add(lvi);
                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = file.DirectoryName;
                    lvi.SubItems.Add(lvsi);
                }
                this.listViewFilesAndFolders.EndUpdate();
            }
            catch (System.Exception err)
            {
                WriteToLog("Грешка в програмата! " + err.Message);
                MessageBox.Show("Грешка в програмата! " + err.Message, "Грешка в програмата!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelErrorReport.Text = "Грешка в програмата! " + err.Message;
                direrror = true;
                ;
            }
        }

        //Обновява ListView за избраните файлове за преименуване
        private void PaintSelectedFilesView()
        {

            try
            {
                ListViewItem lvi;
                ListViewItem.ListViewSubItem lvsi;

                this.listViewSelectedFiles.Items.Clear();
                this.listViewSelectedFiles.BeginUpdate();

                foreach (FileBlock file in selectedFiles)
                {
                    lvi = new ListViewItem();
                    lvi.Text = file.FileName;
                    lvi.ImageIndex = 1;
                    lvi.Tag = file.Location + file.FileName;

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = file.NewFileName;
                    lvi.SubItems.Add(lvsi);

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = file.Location;
                    lvi.SubItems.Add(lvsi);

                    this.listViewSelectedFiles.Items.Add(lvi);

                }
                this.listViewSelectedFiles.EndUpdate();
            }
            catch (System.Exception err)
            {
                WriteToLog("Грешка в програмата! " + err.Message);
                MessageBox.Show("Грешка в програмата! " + err.Message, "Грешка в програмата!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelErrorReport.Text = "Грешка в програмата! " + err.Message;
            }
        }

        //Премахва файловете от списъка за преименуване
        private void buttonRemoveFile_Click(object sender, EventArgs e)
        {
            try
            {
                labelErrorReport.Text = "";
                //ако са избрани повече от един файл, се добавя променливата adjustment, тъй като може да се объркат индексите
                int adjustment = 0;
                foreach (System.Windows.Forms.ListViewItem file in listViewSelectedFiles.SelectedItems)
                {
                    selectedFiles.RemoveAt(file.Index - adjustment);
                    adjustment++;
                }
                PaintSelectedFilesView();
                UpdateNewNames();
            }
            catch (Exception err)
            {
                WriteToLog("Грешка в програмата! " + err.Message);
                labelErrorReport.Text = "Грешка: " + err.Message;
            }
        }

        //Промяна на приоритета за метода към по-висок
        private void buttonPriorityUp_Click(object sender, EventArgs e)
        {
            try
            {
                //ако не е избрано нищо, не изпълнява кода, предотвратява грешки
                if (listBoxNamePriorities.SelectedItem != null)
                {
                    int oldindex = listBoxNamePriorities.SelectedIndex;
                    string item = listBoxNamePriorities.SelectedItem.ToString();
                    if (oldindex - 1 >= 0)
                    {
                        listBoxNamePriorities.Items.RemoveAt(oldindex);
                        listBoxNamePriorities.Items.Insert(oldindex - 1, item);
                        listBoxNamePriorities.SelectedIndex = oldindex - 1;
                    }
                }
                UpdateNewNames();
            }
            catch (Exception err)
            {
                WriteToLog("Грешка в програмата! " + err.Message);
                labelErrorReport.Text = "Грешка: " + err.Message;
            }

        }

        //Промяна на приоритета за метода към по-нисък
        private void buttonPriorityDown_Click(object sender, EventArgs e)
        {
            try
            {
                //ако не е избрано нищо, не изпълнява кода, предотвратява грешки
                if (listBoxNamePriorities.SelectedItem != null)
                {
                    int oldindex = listBoxNamePriorities.SelectedIndex;
                    string item = listBoxNamePriorities.SelectedItem.ToString();
                    if (oldindex+1 < listBoxNamePriorities.Items.Count)
                    {
                        listBoxNamePriorities.Items.RemoveAt(oldindex);
                        listBoxNamePriorities.Items.Insert(oldindex + 1, item);
                        listBoxNamePriorities.SelectedIndex = oldindex + 1;
                    }
                }
                UpdateNewNames();
            }
            catch (Exception err)
            {
                WriteToLog("Грешка в програмата! " + err.Message);
                labelErrorReport.Text = "Грешка: " + err.Message;
            }
        }



        private void buttonStartRename_Click(object sender, EventArgs e)
        {
            BeginRenaming();
        }
        //Метод за преименуване и архивиране
        private void BeginRenaming()
        {
            //Потвърждение от потребителя 
            DialogResult result = MessageBox.Show("ВНИМАНИЕ?\r\n\nАко сте включили архивирането преди преименуване, съществуващите файлове може да бъдат презаписани.\r\n\nСигурни ли сте?", "ВНИМАНИЕ!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            //Ако потвърди
            if (result == DialogResult.Yes)
            {
                try
                {
                    int errcount = 0; // брояч на грешки

                    //Архивиране на файловете
                    if (checkBoxBackupFiles.Checked)
                    {
                        //безкраен цикъл за нов опит
                        while (true)
                        {
                            WriteToLog("----Започване на бекъп преди преименуване...---- ");
                            foreach (FileBlock file in selectedFiles)
                            {
                                try
                                {
                                    string fullfilename = file.Location + @"\" + file.FileName; //Взима се пълната локация
                                    System.IO.FileInfo filebuffer = new FileInfo(fullfilename); //Взима се информация за файла
                                    string backupdir = filebuffer.DirectoryName + "\\BitRenamer-Backup\\" + filebuffer.Name; //Създава се дестинация
                                    Directory.CreateDirectory($@"{filebuffer.Directory}\BitRenamer-backup"); // Създава папка, ако такава липсва
                                    filebuffer.CopyTo(backupdir, true); //Копиране
                                }
                                catch (Exception err)
                                {
                                    WriteToLog($"Файлът {file.FileName} не бе архивиран! {err.Message}");
                                    errcount++;
                                }

                            }
                            //Избор за следващ опит, позволява на потребителя да затвори някой файл, ако го е забравил отворен в програма
                            if (errcount != 0)
                            {
                                string dialogtextRetry = "Някои файлове не бяха успешно архивирани.\r\nТова е възможно, ако някои от избраните файлове се използват в момента или са недостъпни.\r\nБихте ли опитали отново? Можете да продължите с преименуването, като натиенете Игнорирай.";
                                string dialogtitleRetry = "ВНИМАНИЕ!";
                                DialogResult resultretry = MessageBox.Show(dialogtextRetry, dialogtitleRetry, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Question);
                                if (resultretry == DialogResult.Abort) throw new Exception("Отказ от потребителя след неуспешно архивиране.");//отказ
                                if (resultretry == DialogResult.Ignore) break;//игнориране на предупреждението
                                // Опитва отново, ако се натисне retry
                            }
                            else break; //успешен бекъп

                        }


                    }
                    //започване на преименуването
                    errcount = 0; //ресетва се брояча
                    WriteToLog("----Започване на преименуването...---- ");
                    foreach (FileBlock file in selectedFiles)
                    {

                        try
                        {
                            string fullfilename = file.Location + @"\" + file.FileName; //Взима се пълната локация
                            System.IO.FileInfo filebuffer = new FileInfo(fullfilename); //Взима се инфомация за файла
                            string newfullfilename = filebuffer.Directory + "\\" + file.NewFileName; //Прави се дестинация
                            filebuffer.MoveTo(newfullfilename);//Преименуваме файла
                        }
                        //запис в лога при неуспех
                        catch (Exception err)
                        {
                            WriteToLog($"Файлът {file.FileName} не бе преименуван! {err.Message}");
                            errcount++;
                        }

                    }

                    //Частичен успех
                    if (errcount != 0)
                    {
                        string dialogtextReady = "Някои файлове не бяха успешно преименувани.\r\n" +
                            "Това е възможно, ако някои от избраните файлове се използват в момента, или са недостъпни.\r\n" +
                            "Проверете лога за повече подробности\r\n\n\n" +
                            $"    Неуспешно преименувани файлове: {errcount}\r\n" +
                            $"    Успешно преименувани файлове: {selectedFiles.Count - errcount}";
                        string dialogtitleReady = "Преименуването е частично успешно.";
                        MessageBox.Show(dialogtextReady, dialogtitleReady, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    //Успешно преименуване
                    else
                    {
                        string dialogtextReady =
                             "Всички файлове са преименувани успешно\r\n\n\n" +
                             $"    Неуспешно преименувани файлове: {errcount}\r\n" +
                             $"    Успешно преименувани файлове: {selectedFiles.Count - errcount}";
                        string dialogtitleReady = "Преименуването е успешно.";
                        MessageBox.Show(dialogtextReady, dialogtitleReady, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    //При частичен успех или пълен успех, списъка се изчиства и се обновява изгледа с папките
                    listViewSelectedFiles.Items.Clear();
                    selectedFiles.Clear();
                    PaintListView(currentdir);
                }
                //Запис в лога при критична грешка, било то отказ от потребителя или грешка от програмата
                catch (Exception err)
                {
                    WriteToLog($"Преименуването е неуспешно! {err.Message}");
                    MessageBox.Show("Преименуването е неуспешно! Проверете лога за повече подробности. \r\nГрешка: " + err.Message, "Преименуването e неуспешно!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    labelErrorReport.Text = "Преименуването е неуспешно! Проверете лога за подробности!";
                }


            }


        }


        //Логване на всички грешки
        private void WriteToLog(string message)
        {
            try
            {
                string logline = DateTime.Now.ToString() + " " + message + "\r\n";
                string programpath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

                File.AppendAllText(programpath + "\\BitRenamerlog.txt", logline);
            }
            catch (Exception err)
            {
                MessageBox.Show("Неуспешен запис в лога! \r\nГрешка:" + err.Message, "Неуспешен запис в лога!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //отваряне на логовете
        private void buttonOpenLogs_Click(object sender, EventArgs e)
        {
            try
            {
                string programpath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                System.Diagnostics.Process.Start(programpath + "\\BitRenamerlog.txt");
            }
            catch (Exception err)
            {
                MessageBox.Show("Лог файлът не може да се отвори! \r\nГрешка:" + err.Message, "Лог файлът не може да се отвори!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Позволява въвеждане само на букви, цифри, долна черта, тире и позволява изтриване
        private void textBoxExtChange_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || (e.KeyChar > 57 && e.KeyChar < 65) || (e.KeyChar > 90 & e.KeyChar < 97) || e.KeyChar > 122)) && e.KeyChar != 8 && e.KeyChar != 45 && e.KeyChar != 95) e.Handled = true;
        }

        //Позволява въвеждане само на букви, цифри, долна черта, тире, точка, спейс и позволява изтриване
        private void textBoxAddName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || (e.KeyChar > 57 && e.KeyChar < 65) || (e.KeyChar > 90 & e.KeyChar < 97) || e.KeyChar > 122)) && e.KeyChar != 8 && e.KeyChar != 32 && e.KeyChar != 45 && e.KeyChar != 46 && e.KeyChar != 95) e.Handled = true;
        }


        //Всички методи, които само извикват функцията UpdateNewNames()
        private void comboBoxDivider_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateNewNames();
        }

        private void textBoxAddName_TextChanged(object sender, EventArgs e)
        {
            UpdateNewNames();
        }

        private void numericUpDownSymDelNum_ValueChanged(object sender, EventArgs e)
        {
            UpdateNewNames();
        }

        private void numericUpDownNumZeroes_ValueChanged(object sender, EventArgs e)
        {
            UpdateNewNames();
        }

        private void numericUpDownNumStart_ValueChanged(object sender, EventArgs e)
        {
            UpdateNewNames();
        }

        private void textBoxExtChange_TextChanged(object sender, EventArgs e)
        {
            UpdateNewNames();
        }


    }


}
