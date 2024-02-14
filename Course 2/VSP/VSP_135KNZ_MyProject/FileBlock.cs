using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSP_135KNZ_MyProject
{   //клас FileBlock за програмата AP BITRENAMER
    //От Антонио Петков, 2. курс, специалност КН, Фак. Ном. 135КНЗ
    //Служи за по-лесно съхранение на данните, нужни при преименуване на файловете
    //Повече информация вижте в документа към програмата
    internal class FileBlock
    {
        // Полета
        private string filelocation;//Локация на файла
        private string filename;//Оригинално име на файла
        private string newfilename;//Ново преименувано име на файла
        private DateTime datecreated;//Дата на модифициране на файла(използва се при добавяне на дата/час към името)

        // Свойства

        public string Location//Локация на файла
        {
            get { return filelocation; }
            set { filelocation = value; }
        }
        public string FileName
        {
            get { return filename; }//Оригинално име на файла
            set { filename = value; }
        }
        public string NewFileName//Ново преименувано име на файла
        {
            get { return newfilename; }
            set { newfilename = value; }
        }
        public DateTime DateCreated//Дата на модифициране на файла(използва се при добавяне на дата/час към името)
        {
            get { return datecreated; }
                set { datecreated = value; }
        }
        // конструктор
        public FileBlock (string name, string location, DateTime date)
        {
            this.FileName = name;//Оригинално име на файла
            this.NewFileName = name;//Ново преименувано име на файла
            this.Location = location;//Локация на файла
            this.DateCreated = date;//Дата на модифициране на файла(използва се при добавяне на дата/час към името)
        }
    }
}
