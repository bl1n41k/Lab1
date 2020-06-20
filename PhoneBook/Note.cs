using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class Note
    {
        public string LastName;
        public string Name;
        public string Patronymic;
        public string Street;
        public ushort House;
        public ushort Flat;
        public string Phone;
        public override bool Equals(object obj)
        {
            Note note = (Note)obj;
            return (LastName == note.LastName && Name == note.Name && Patronymic == note.Patronymic && Street == note.Street && House == note.House && Flat == note.Flat && Phone == note.Phone);
        }
        public override int GetHashCode() => LastName.Length ^ Name.Length ^ Patronymic.Length ^ Street.Length ^ House ^ Flat ^ Phone.Length;
    }
    class CompareByLastName : IComparer<Note>
    {
        public int Compare(Note x, Note y) =>
        string.Compare(x.LastName, y.LastName);
    }

    class CompareByName : IComparer<Note>
    {
        public int Compare(Note x, Note y) =>
            string.Compare(x.Name, y.Name);
    }

    class CompareByPatronymic : IComparer<Note>
    {
        public int Compare(Note x, Note y) =>
            string.Compare(x.Patronymic, y.Patronymic);
    }

    class CompareByStreet : IComparer<Note>
    {
        public int Compare(Note x, Note y) =>
            string.Compare(x.Street, y.Street);
    }
    class CompareByHouse : IComparer<Note>
    {
        public int Compare(Note x, Note y) =>
            x.House.CompareTo(y.House);
    }
    class CompareByFlat : IComparer<Note>
    {
        public int Compare(Note x, Note y) =>
            x.Flat.CompareTo(y.Flat);
    }
    
    class CompareByPhone : IComparer<Note>
    {
        public int Compare(Note x, Note y) => 
            string.Compare(x.Phone, y.Phone);
    }
    public enum AddOrEdit
    {
        Add,
        Edit
    }
}

