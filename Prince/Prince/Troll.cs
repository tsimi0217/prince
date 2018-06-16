using System;
using System.Collections.Generic;
using System.Text;

namespace Prince
{
    class Troll
    {
        public string _tName { get; set; }
        public int _strength { get; set; }
        public string _color { get; set; }

        public Troll(string name, int strength, string color)
        {
            _tName = name;
            _strength = strength;
            _color = color;
        }
    }
}
