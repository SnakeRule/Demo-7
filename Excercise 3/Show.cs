using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_3
{
    [Serializable] // The class can be serialized for writing to a file
    class Show
    {
        public string Name { get; set; }
        public string Channel { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string info { get; set; }
    }
}
