using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smiteRandomizer
{
    class Items
    {
        public string Name { get; }
        public string ImageSource { get; }
        public string Type { get; }

        public Items(string name, string imageSource, string type)
        {
            Name = name;
            ImageSource = imageSource;
            Type = type;
        }
    }
}
