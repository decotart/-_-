using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib6
{
    public class LectorsNotFoundException : Exception
    {
        public LectorsNotFoundException() : base("Преподаватели не найдены") { }
    }
}
