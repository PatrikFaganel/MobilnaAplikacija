using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilnaAplikacija.Model
{

    public class Rootobject
    {
        public string title { get; set; }
        public List<Variable> variables { get; set; }
    }

    public class Variable
    {
        public string code { get; set; }
        public string text { get; set; }
        public string[] values { get; set; }
        public string[] valueTexts { get; set; }
        public bool elimination { get; set; }
    }

}
