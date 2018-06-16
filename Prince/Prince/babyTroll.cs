using System;
using System.Collections.Generic;
using System.Text;

namespace Prince
{
    class babyTroll : Troll
    {
        public double _weight { get; set; }

        public babyTroll(string name, int strength, string color, double weight) : base(name, strength, color)
        {
            _tName = name;
            _strength = _strength;
            _color = color;
            _weight = weight;
        }

    }
}
