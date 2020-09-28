using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject.FormData
{
    interface IData
    {
        Dictionary<string, string> GetTestData(string key);
    }
}