using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioBook.DB;

namespace AudioBook.ClassHelp
{
    internal class EFClass
    {
        public static Entities Context { get; } = new Entities();
    }
}
