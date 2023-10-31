using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_6_version_2._0_
{
    interface IHuman
    {
        string FirstName { get; }
        string SecondName { get; }
        int Age { get; }
        string Gender { get; }
        string Group { get; }
    }

    interface IMark
    {
        string GetInfo();
    }
}
