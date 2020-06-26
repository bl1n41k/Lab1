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
using System.Xml.Linq;
using System.Xml;
using PhoneBook.Save;
using PhoneBook.Open;

namespace PhoneBook
{
    public partial class MainForm : Form
    {
        private List<Note> PhoneNote;
        private List<Note> oldPhoneNote;
        private int current;
        private int count;
        private bool SaveNote;
        ISave saveBehavior;
        IOpen openBehavior;
        SaveFileDialog SaveDialog = new SaveFileDialog();
        OpenFileDialog OpenDialog = new OpenFileDialog();
        public MainForm()
        {
            InitializeComponent();
            PhoneNote = new List<Note>();
            oldPhoneNote = new List<Note>();
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

        
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SaveNote)
            {
                DialogResult res = MessageBox.Show("Сохранить изменения?", "Уведомление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                    вTxtФайлToolStripMenuItem_Click(sender, e);
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
            SearchPhoneForm _Search = new SearchPhoneForm(PhoneNote);
            _Search.ShowDialog();
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

        private void вTxtФайлToolStripMenuItem_Click(object sender, EventArgs e)// Сохранение в txt файл
        {
            
            if (PhoneNote.Count > 0)
            {
                SaveDialog.Filter = "Текст|*.txt";
                if (SaveDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        saveBehavior = new SaveTxt();
                        saveBehavior.Save(PhoneNote, SaveDialog.FileName);
                        MessageBox.Show("Запись успешно выполнена!");
                        SaveDialog.FileName = "";
                        oldPhoneNote = PhoneNote.ToList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Запись прервана! Не удалось сохранить данные! Ошибка: " + ex.Message);
                    }
                }
            }
            else MessageBox.Show("Телефонный справочник пуст!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void вXmlФайлToolStripMenuItem_Click(object sender, EventArgs e) // Сохранение в Xml файл
        {
            if (PhoneNote.Count > 0)
            {
                SaveDialog.Filter = "Текст|*.xml";
                if (SaveDialog.ShowDialog() == DialogResult.OK)
                {

                    saveBehavior = new SaveXml();
                    saveBehavior.Save(PhoneNote, SaveDialog.FileName);
                    oldPhoneNote = PhoneNote.ToList();
                    SaveDialog.FileName = "";
                }
            }
            else MessageBox.Show("Телефонный справочник пуст!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void изTxtToolStripMenuItem_Click(object sender, EventArgs e) // Открыть txt файл
        {
            if (PhoneNote.Count != 0)//если есть записи
            {
                DialogResult dialogResult = MessageBox.Show("Данные могут быть утеряны.\n  Хотите сохранить телефонный справочник в файл?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)//если захотели сохранить, то сохраняем в текстовый файл
                {
                    вTxtФайлToolStripMenuItem_Click(sender, e);
                }
                PhoneNote.Clear();

            }
            OpenDialog.Filter = "Текст|*.txt";
            if (OpenDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    openBehavior = new OpenTxt();
                    PhoneNote = openBehavior.CreateNewList(OpenDialog.FileName);
                    if (PhoneNote.Count == 0) current = -1;
                    else
                    {
                        current = 0;
                        if (count == 0)
                        {
                            oldPhoneNote = PhoneNote.ToList();
                            ++count;
                        }
                    }
                    PrintElement();// Выводим текущий элемент
                    OpenDialog.FileName = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("При открытии файла возникла ошибка! Ошибка: " + ex.Message);
                }
            }
        }
        private void изXmlФайлаToolStripMenuItem_Click(object sender, EventArgs e)// Открыть xml файл
        {
            if (PhoneNote.Count != 0)//если есть записи
            {
                DialogResult dialogResult = MessageBox.Show("Данные могут быть утеряны.\n Хотите сохранить телефонный справочник в файл?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)//если захотели сохранить, то сохраняем в текстовый файл
                {
                    вTxtФайлToolStripMenuItem_Click(sender, e);
                }
               PhoneNote.Clear();
            }
            
            OpenDialog.Filter = "Текст|*.xml";
            if (OpenDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    openBehavior = new OpenXml();
                    PhoneNote = openBehavior.CreateNewList(OpenDialog.FileName);
                    if (PhoneNote.Count == 0) current = -1;
                    else
                    {
                        current = 0;
                        if (count == 0)
                        {
                            oldPhoneNote = PhoneNote.ToList();
                            ++count;
                        }
                    }
                    PrintElement(); // выводим текущий элемент
                    OpenDialog.FileName = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("xml файл не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void изФайлаtxtToolStripMenuItem_Click(object sender, EventArgs e)//Добавляем данные из файла txt
        {
            OpenDialog.Filter = "Текст|*.txt";
            if (OpenDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    openBehavior = new OpenTxt();
                    PhoneNote = openBehavior.AddData(PhoneNote, OpenDialog.FileName);
                    if (PhoneNote.Count == 0) current = -1;
                    else
                    {
                        current = 0;
                        if (count == 0)
                        {
                            oldPhoneNote = PhoneNote.ToList();
                            ++count;
                        };
                    }
                    PrintElement();// выводим текущий элемент
                    OpenDialog.FileName = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("При открытии файла возникла ошибка! Ошибка: " + ex.Message);

                }
            }
        }
        private void изФайлаxmlToolStripMenuItem_Click(object sender, EventArgs e) //Добавляем данные из файла xml
        {
            OpenDialog.Filter = "Текст|*.xml";
            if (OpenDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    openBehavior = new OpenXml();
                    PhoneNote = openBehavior.AddData(PhoneNote, OpenDialog.FileName);
                    if (PhoneNote.Count == 0) current = -1;
                    else
                    {
                        current = 0;
                        if (count == 0)
                        {
                            oldPhoneNote = PhoneNote.ToList();
                            ++count;
                        }
                    }
                   
                    PrintElement(); // выводим текущий элемент
                    OpenDialog.FileName = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("xml файл не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
