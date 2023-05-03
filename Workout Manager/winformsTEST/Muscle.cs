using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUSCLE
{
    [Serializable]
    public class Muscle
    {
        string _name;

        public Muscle()
        {
            this._name = "NO_NAME";
        }
        public Muscle(string name)
        {
            this._name = name;
        }

        public string getName()
        {
            return this._name;
        }
        ~Muscle() { }
    }
}
