using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{

    internal class Animals
    {
        public int legs;
        public int eyes;
        public int  age;
        public string name;
    }
    internal class Birds : Animals
    {
        public bool canFly;
        public bool eatsMeat;
        public string favFood;
        public bool canSwim;
    }
    internal class Reptiles : Animals
    {
        public string scalesOrScutes;
        public bool layEggs;
        public int lungsNum;
        public string typeOfReptile;
    }

}
