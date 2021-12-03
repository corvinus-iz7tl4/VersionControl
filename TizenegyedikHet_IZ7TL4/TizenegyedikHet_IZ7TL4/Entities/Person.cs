using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TizenegyedikHet_IZ7TL4.Entities
{
    public class Person
    {
        public int BirthYear { get; set; }
        public Gender Gender { get; set; }
        public int NbrOfChildren { get; set; }
        public bool IsAlive { get; set; }

        public Person()
        {
            IsAlive = true;
        }
    }
}
