using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public T Verwijderen() {
            if (bezoekers.Count <= 0) {

                MessageBox.Show("Dit is een reeds lege stapel.");
                throw new Exception();

            } else {

                T teller = bezoekers[bezoekers.Count - 1];
                bezoekers.RemoveAt(bezoekers.Count - 1);

                MessageBox.Show("Item is verwijderd.");

                return teller;
            }

            // bezoekers.Remove(item);
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
