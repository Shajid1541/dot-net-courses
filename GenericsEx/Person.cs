using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsEx
{
    internal class Person : IComparable<Person>
    {
        public int id {  get; set; }
        public string name { get; set; }



        public int CompareTo(Person? other)
        {
            if (this.id.CompareTo(other.id) == 0)
            {
                return this.name.CompareTo(other.name);
            }
            return this.id.CompareTo(other.id);
        }


        public override string ToString()
        {
            return $"{id} {name}";
        }
    }
}
