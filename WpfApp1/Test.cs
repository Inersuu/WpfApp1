using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Test
    {
        public int a { get; set; }
        public List<Tuple<string, string>> b = new List<Tuple<string, string>>();
        public List<string> c = new List<string>();
        public Test()
        {
            a = 0;
        }
    }
}
