using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace PhoneBook
{
    public partial class MainForm : Form
    {
        private List<Note> PhoneNote;
        private int current;
        private bool SaveNote;

        public MainForm()
        {
            InitializeComponent();
            PhoneNote = new List<Note>();
            current = -1;
            SaveNote = false;
        }
       
        private void PrintElement()
        {
            if ((current >= 0) && (current < PhoneNote.Count))
            {   // если есть что выводить
                // MyRecord - запись списка PhoneNote номер current
                Note MyRecord = PhoneNote[current];
                // записываем в соответствующие элементы на форме 
                // поля из записи MyRecord 
                LastNameTextBox.Text = MyRecord.LastName;
                NameTextBox.Text = MyRecord.Name;
                PatronymicTextBox.Text = MyRecord.Patronymic;
                PhoneMaskedTextBox.Text = MyRecord.Phone;
                StreetTextBox.Text = MyRecord.Street;
                HouseNumericUpDown.Value = MyRecord.House;
                FlatNumericUpDown.Value = MyRecord.Flat;
            }
            else // если current равно -1, т. е. список пуст
            {   // очистить поля формы 
                LastNameTextBox.Text = "";
                NameTextBox.Text = "";
                PatronymicTextBox.Text = "";
                PhoneMaskedTextBox.Text = "";
                StreetTextBox.Text = "";
                HouseNumericUpDown.Value = 1;
                FlatNumericUpDown.Value = 1;
            }
            // обновление строки состояния
            NumberToolStripStatusLabel.Text = (current + 1).ToString();
            QuantityToolStripStatusLabel.Text = PhoneNote.Count.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public bool CheckAdd(Note MyRecord) => PhoneNote.Contains(MyRecord) ? true : false;
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // создаем запись - экземпляр класса Note
            Note MyRecord = new Note();
            // создаем экземпляр формы AddForm
            AddForm _AddForm = new AddForm(MyRecord, PhoneNote, AddOrEdit.Add);
            // открываем форму для добавления записи
            _AddForm.ShowDialog();
            // текущей записью становится последняя
            // добавляем к списку PhoneNote новый элемент - запись MyRecord,
            // взятую из формы AddForm
            if (_AddForm.Add)
            {
                current = PhoneNote.Count;
                PhoneNote.Add(_AddForm.MyRecord);
                SaveNote = true;
            }
            // если current--;
            // выводим текущий элемент
            PrintElement();
        }
        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (current != 0 && PhoneNote.Count > 0) current--; // уменьшаем номер текущей записи на 1
            else MessageBox.Show("Предыдущей записи не существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            PrintElement(); 	// выводим элемент с номером current
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (current < PhoneNote.Count - 1) current++; //увеличиваем номер текущей записи на 1
            else MessageBox.Show("Следующей записи не существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            PrintElement(); 	// выводим элемент с номером current
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) // Если в диалоговом окне нажали ОК
            {
                try // обработчик исключительных ситуаций
                {
                    if (saveFileDialog1.FilterIndex == 1)
                    {
                        // используя sw (экземпляр класса StreamWriter),
                        // создаем файл с заданным в диалоговом окне именем
                        using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                        {
                            // проходим по всем элементам списка
                            foreach (Note MyRecord in PhoneNote)
                            {
                                // записываем каждое поле в отдельной строке
                                sw.WriteLine(MyRecord.LastName);
                                sw.WriteLine(MyRecord.Name);
                                sw.WriteLine(MyRecord.Patronymic);
                                sw.WriteLine(MyRecord.Street);
                                sw.WriteLine(MyRecord.House);
                                sw.WriteLine(MyRecord.Flat);
                                sw.WriteLine(MyRecord.Phone);
                            }
                        }
                    }
                    else
                    {
                        XmlTextWriter textWriter = new XmlTextWriter(saveFileDialog1.FileName, Encoding.UTF8);
                        textWriter.WriteStartDocument();
                        textWriter.WriteStartElement("Notes");
                        textWriter.WriteEndDocument();
                        textWriter.Close();
                        XmlDocument document = new XmlDocument();
                        document.Load(saveFileDialog1.FileName);
                        int i = 0;
                        foreach (Note MyRecord in PhoneNote)
                        {
                            //Создаём XML-запись
                            XmlElement element = document.CreateElement("Note");
                            document.DocumentElement.AppendChild(element);// указываем родителя

                            XmlAttribute attribute = document.CreateAttribute("id");// создаём атрибут
                            attribute.Value = i.ToString();// устанавливаем значение атрибута
                            element.Attributes.Append(attribute);// добавляем атрибут
                            //Добавляем в запись данные
                            XmlNode lastNameElem = document.CreateElement("Lastname");
                            lastNameElem.InnerText = MyRecord.LastName;
                            element.AppendChild(lastNameElem);

                            XmlNode nameElem = document.CreateElement("Name");
                            nameElem.InnerText = MyRecord.Name;
                            element.AppendChild(nameElem);

                            XmlNode patronymicElem = document.CreateElement("Patronymic");
                            patronymicElem.InnerText = MyRecord.Patronymic;
                            element.AppendChild(patronymicElem);

                            XmlNode streetElem = document.CreateElement("Street");
                            streetElem.InnerText = MyRecord.Street;
                            element.AppendChild(streetElem);

                            XmlNode houseElem = document.CreateElement("House");
                            houseElem.InnerText = MyRecord.House.ToString();
                            element.AppendChild(houseElem);

                            XmlNode flatElem = document.CreateElement("Flat");
                            flatElem.InnerText = MyRecord.Flat.ToString();
                            element.AppendChild(flatElem);

                            XmlNode phoneElem = document.CreateElement("Phone");
                            phoneElem.InnerText = MyRecord.Phone;
                            element.AppendChild(phoneElem);
                            i++;
                        }
                        document.Save(saveFileDialog1.FileName);
                    }
                    SaveNote = false;
                }
                catch (Exception ex)    // перехватываем ошибку
                {
                    // выводим информацию об ошибке
                    MessageBox.Show("Не удалось сохранить данные! Ошибка: " +
                    ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            // если в диалоговом окне нажали ОК
            {
                try // обработчик исключительных ситуаций
                {
                    PhoneNote.Clear();
                    //openFileDialog1.RestoreDirectory = true;
                    if (Path.GetExtension(openFileDialog1.FileName) == ".txt")
                    {
                        // считываем из указанного в диалоговом окне файла
                        using (StreamReader sr =
                        new StreamReader(openFileDialog1.FileName))
                        {
                            // пока не дошли до конца файла
                            while (!sr.EndOfStream)
                            {
                                //выделяем место под запись
                                Note MyRecord = new Note();
                                // считываем значения полей записи из файла
                                MyRecord.LastName = sr.ReadLine();
                                MyRecord.Name = sr.ReadLine();
                                MyRecord.Patronymic = sr.ReadLine();
                                MyRecord.Street = sr.ReadLine();
                                MyRecord.House = ushort.Parse(sr.ReadLine());
                                MyRecord.Flat = ushort.Parse(sr.ReadLine());
                                MyRecord.Phone = sr.ReadLine();
                                //добавляем запись в список
                                PhoneNote.Add(MyRecord);
                            }
                        }
                        // если список пуст, то current устанавливаем в -1,
                        // иначе текущей является первая с начала запись (номер 0)
                        if (PhoneNote.Count == 0) current = -1;
                        else current = 0;
                        // выводим текущий элемент
                        PrintElement();
                    }
                    else
                    {
                        XmlDocument xDoc = new XmlDocument();
                        xDoc.Load(openFileDialog1.FileName);
                        XmlElement xRoot = xDoc.DocumentElement;
                        foreach (XmlElement xnode in xRoot)
                        {
                            Note node = new Note();
                            foreach (XmlNode cnode in xnode.ChildNodes)
                            {
                                if (cnode.Name == "Lastname") node.LastName = cnode.InnerText;
                                else if (cnode.Name == "Name") node.Name = cnode.InnerText;
                                else if (cnode.Name == "Patronymic") node.Patronymic = cnode.InnerText;
                                else if (cnode.Name == "Street") node.Street = cnode.InnerText;
                                else if (cnode.Name == "House") node.House = ushort.Parse(cnode.InnerText);
                                else if (cnode.Name == "Flat") node.Flat = ushort.Parse(cnode.InnerText);
                                else if (cnode.Name == "Phone") node.Phone = cnode.InnerText;
                            }
                            PhoneNote.Add(node);
                        }
                        if (PhoneNote.Count == 0) current = -1;
                        else current = 0;
                        // выводим текущий элемент
                        PrintElement();
                    }
                    SaveNote = false;
                }
                catch (Exception ex)    // если произошла ошибка
                {
                    // выводим сообщение об ошибке
                    MessageBox.Show("При открытии файла произошла ошибка: " +
                    ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SaveNote)
            {
                DialogResult res = MessageBox.Show("Сохранить изменения?", "Уведомление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                    сохранитьToolStripMenuItem_Click(sender, e);
            }
        }
        private void поискПоФИОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Поиск_абонента _Search = new Поиск_абонента(PhoneNote);
            _Search.ShowDialog();
        }
        private void поискПоАдресуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchAddressForm _Search = new SearchAddressForm(PhoneNote);
            _Search.ShowDialog();
        }
        private void поискПоТелефонуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchPhoneForm _Search = new SearchPhoneForm(PhoneNote);
            _Search.ShowDialog();
        }
        private void поФамилииToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        private void поВозрастаниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PhoneNote.Count > 0)
            {
                PhoneNote.Sort(new CompareByLastName());
                current = 0;
                PrintElement();
            }
        }
        private void поУбываниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PhoneNote.Count > 0)
            {
                PhoneNote.Sort(new CompareByLastName());
                PhoneNote.Reverse();
                current = 0;
                PrintElement();
            }
        }
        private void поВозрастаниюToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (PhoneNote.Count > 0)
            {
                PhoneNote.Sort(new CompareByFlat());
                current = 0;
                PrintElement();
            }
        }
        private void поУбываниюToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (PhoneNote.Count > 0)
            {
                PhoneNote.Sort(new CompareByFlat());
                PhoneNote.Reverse();
                current = 0;
                PrintElement();
            }
        }
        private void поВозрастаниюToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (PhoneNote.Count > 0)
            {
                PhoneNote.Sort(new CompareByName());
                current = 0;
                PrintElement();
            }
        }
        private void поУбываниюToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (PhoneNote.Count > 0)
            {
                PhoneNote.Sort(new CompareByName());
                PhoneNote.Reverse();
                current = 0;
                PrintElement();
            }
        }
        private void поВозрастаниюToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (PhoneNote.Count > 0)
            {
                PhoneNote.Sort(new CompareByPatronymic());
                current = 0;
                PrintElement();
            }
        }
        private void поУбываниюToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (PhoneNote.Count > 0)
            {
                PhoneNote.Sort(new CompareByPatronymic());
                PhoneNote.Reverse();
                current = 0;
                PrintElement();
            }
        }
        private void поВозрастаниюToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (PhoneNote.Count > 0)
            {
                PhoneNote.Sort(new CompareByStreet());
                current = 0;
                PrintElement();
            }
        }
        private void поУбываниюToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (PhoneNote.Count > 0)
            {
                PhoneNote.Sort(new CompareByStreet());
                PhoneNote.Reverse();
                current = 0;
                PrintElement();
            }
        }
        private void поВозрастаниюToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (PhoneNote.Count > 0)
            {
                PhoneNote.Sort(new CompareByHouse());
                current = 0;
                PrintElement();
            }
        }
        private void поУбываниюToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (PhoneNote.Count > 0)
            {
                PhoneNote.Sort(new CompareByHouse());
                PhoneNote.Reverse();
                current = 0;
                PrintElement();
            }
        }
        private void поВозрастаниюToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            if (PhoneNote.Count > 0)
            {
                PhoneNote.Sort(new CompareByPhone());
                current = 0;
                PrintElement();
            }
        }
        private void поУбываниюToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            if (PhoneNote.Count > 0)
            {
                PhoneNote.Sort(new CompareByPhone());
                PhoneNote.Reverse();
                current = 0;
                PrintElement();
            }
        }       
        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PhoneNote.Count > 0)
            {
                // создаем запись - экземпляр класса Note
                Note MyRecord = new Note();
                // определяем поля записи
                // (берем значения из соответствующих компонентов на форме)
                MyRecord.LastName = LastNameTextBox.Text;
                MyRecord.Name = NameTextBox.Text;
                MyRecord.Patronymic = PatronymicTextBox.Text;
                MyRecord.Phone = PhoneMaskedTextBox.Text;
                MyRecord.Street = StreetTextBox.Text;
                MyRecord.House = (ushort)HouseNumericUpDown.Value;
                MyRecord.Flat = (ushort)FlatNumericUpDown.Value;
                // создаем экземпляр формы и открываем эту форму
                AddForm _AddForm = new AddForm(MyRecord, PhoneNote, AddOrEdit.Edit);
                _AddForm.ShowDialog();
                // изменяем текущую запись
                if (_AddForm.Add)
                {
                    PhoneNote[current] = _AddForm.MyRecord;
                    SaveNote = true;
                }
            }
            PrintElement();
        }
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PhoneNote.Count > 0)
            {
                PhoneNote.RemoveAt(current);
                if (current > 0 || PhoneNote.Count == 0)
                    current--;
                SaveNote = true;  //сохранение
                PrintElement();
            }
        }
    }
}
