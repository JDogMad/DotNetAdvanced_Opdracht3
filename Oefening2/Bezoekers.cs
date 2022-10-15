using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening2 {
    public class Bezoekers<T> {
        private List<T> bezoekers;

        public Bezoekers() {
            this.bezoekers = new List<T>();
        }

        public void Toevoegen(T item) {
            bezoekers.Add(item);
        }

        public void Verwijderen(T item) {
            bezoekers.Remove(item);
        }

        public void Leegmaken() {
            bezoekers.Clear();
        }

        public override string ToString() {
            var res = string.Join(" , ", bezoekers);
            return res;
        }
    }
}
