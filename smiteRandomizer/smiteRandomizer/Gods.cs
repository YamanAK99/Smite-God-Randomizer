using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smiteRandomizer
{
    class Gods
    {
        public string Name { get; }
        public string ImageSource { get; }
        public string Role { get; }
        public string Description { get; }
        public Gods(string name, string imageSource, string role, string description)
        {
            Name = name;
            ImageSource = imageSource;
            Role = role;
            Description = description;
        }
    }
}
