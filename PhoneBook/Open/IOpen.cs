using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Open
{
	interface IOpen
	{
		List<Note> CreateNewList(string fileName);
		List<Note> AddData(List<Note> phoneNote, String fileName);
	}
}
