using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class AddForm : Form
    {
        public Note MyRecord;
        public bool Add = false;
        private List<Note> PhoneNote;
        public AddForm(Note _MyRecord, List<Note> _PhoneNote, AddOrEdit MyType)
        {
            InitializeComponent();
            MyRecord = _MyRecord;
            PhoneNote = _PhoneNote;
            if (MyType == AddOrEdit.Add)
            {
                Text = "Добавление абонента";
                AddButton.Text = "Добавить";
            }
            else    // если форма открыта для изменения записи
            {
                Text = "Изменение абонента";
                AddButton.Text = "Изменить";
                // определяем значение компонентов на форме
                LastNameTextBox.Text = MyRecord.LastName;
                NameTextBox.Text = MyRecord.Name;
                PatronymicTextBox.Text = MyRecord.Patronymic;
                PhoneMaskedTextBox.Text = MyRecord.Phone;
                StreetTextBox.Text = MyRecord.Street;
                HouseNumericUpDown.Value = MyRecord.House;
                FlatNumericUpDown.Value = MyRecord.Flat;
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            // определяем поля записи -
            // берем значения из соответствующих компонентов на форме
            MyRecord.LastName = LastNameTextBox.Text;
            MyRecord.Name = NameTextBox.Text;
            MyRecord.Patronymic = PatronymicTextBox.Text;
            MyRecord.Phone = PhoneMaskedTextBox.Text;
            MyRecord.Street = StreetTextBox.Text;
            MyRecord.House = (ushort)HouseNumericUpDown.Value;
            MyRecord.Flat = (ushort)FlatNumericUpDown.Value; 
            if (PhoneNote.Contains(MyRecord)) 
                MessageBox.Show("Запись уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(!CheckForCorrect(MyRecord.LastName) || !CheckForCorrect(MyRecord.Name) || !CheckForCorrect(MyRecord.Patronymic) || !CheckForCorrect(MyRecord.Street) || !PhoneMaskedTextBox.MaskFull)
                MessageBox.Show("Поля заполнены неправильно! ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Add = true;
                Close();        // закрываем форму
            }
        }
        private bool CheckForCorrect(string line)
        {
            if (line == "") return false;
            foreach (char c in line)
            {
                if (!Char.IsLetter(c)) return false;
            }
            return true;
        }
    }
}
