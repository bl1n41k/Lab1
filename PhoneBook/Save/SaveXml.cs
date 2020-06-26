using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PhoneBook.Save
{
    class SaveXml : ISave
    {
        public void Save(List<Note> phoneNote, string fileName)
        {
            //Создаём xml документ
            XmlTextWriter textWritter = new XmlTextWriter(fileName, Encoding.UTF8);
            textWritter.WriteStartDocument();
            textWritter.WriteStartElement("Notes");
            textWritter.WriteEndElement();
            textWritter.Close();

            XmlDocument document = new XmlDocument();
            document.Load(fileName);//загружаем из xml файла
            int i = 0;
            foreach (Note x in phoneNote)
            {
                //Создаём XML запись
                XmlElement element = document.CreateElement("Note");
                document.DocumentElement.AppendChild(element); 
                XmlAttribute attribute = document.CreateAttribute("id"); 
                attribute.Value = i.ToString(); 
                element.Attributes.Append(attribute); 

                //Добавляем в запись данные
                XmlNode lastnameElem = document.CreateElement("Lastname"); 
                lastnameElem.InnerText = x.LastName;
                element.AppendChild(lastnameElem); 
                XmlNode nameElem = document.CreateElement("Name"); 
                nameElem.InnerText = x.Name;
                element.AppendChild(nameElem); 
                XmlNode PatronymicElem = document.CreateElement("Patronymic"); 
                PatronymicElem.InnerText = x.Patronymic; 
                element.AppendChild(PatronymicElem); 
                XmlNode streetElem = document.CreateElement("Street"); 
                streetElem.InnerText = x.Street; 
                element.AppendChild(streetElem);
                XmlNode houseElem = document.CreateElement("House"); 
                houseElem.InnerText = x.House.ToString(); 
                element.AppendChild(houseElem); 
                XmlNode flatElem = document.CreateElement("Flat"); 
                flatElem.InnerText = x.Flat.ToString(); 
                element.AppendChild(flatElem); 
                XmlNode phoneElem = document.CreateElement("Phone"); 
                phoneElem.InnerText = x.Phone; 
                element.AppendChild(phoneElem); 
                i++;
            }
            document.Save(fileName);
        }
    }
}
