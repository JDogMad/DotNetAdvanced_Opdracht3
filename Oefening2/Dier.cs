using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening2 {
    public class Dier<T> {
        private List<T> dieren;

        public Dier() {
            this.dieren = new List<T>();
        }

        public void Toevoegen(T item) {
            dieren.Add(item);
        }

        public void Verwijderen(T item) {
            dieren.Remove(item);
        }

        public void Leegmaken() {
            dieren.Clear();
        }

        public bool IsAanwezig(T item) {
            if (dieren.Contains(item))
            {
                return true;
            }
            else
                return false;
        }

        public override string ToString() {
            var res = string.Join(" , ", dieren);
            return res;
        }
    }
}
