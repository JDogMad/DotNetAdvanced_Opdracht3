using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening2 {
    public class School {
        public int id { get; set; }
        public string naam { get; set; }

        public School() {
            this.naam = naam;
        }

        public School(string naam) {
            this.naam = naam;
        }

        public override string ToString() {
            return naam;
        }
    }
}
