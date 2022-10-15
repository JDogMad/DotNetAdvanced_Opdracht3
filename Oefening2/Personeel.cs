using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening2 {
    public class Personeel<T> {
        private List<T> personeel;

        public Personeel() {
            this.personeel = new List<T>();
        }

        public void Toevoegen(T item) {
            personeel.Add(item);
        }

        public void Verwijderen(T item) {
            personeel.Remove(item);
        }

        public void Leegmaken() {
            personeel.Clear();
        }

        public bool IsAanwezig(T item) {
            if (personeel.Contains(item)) {
                return true;
            } else
                return false;
        }

        public override string ToString() {
            var res = string.Join(", ", personeel);
            return res;
        }
    }
}
