using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PhoneBook.Save
{
	interface ISave
	{
		void Save(List<Note> notes, String fileName);
	}
}
