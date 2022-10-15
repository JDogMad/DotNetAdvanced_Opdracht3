using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening {
    //De generische klasse Stapel met volgende eigenschappen:
    public class Stapel<T> {
        //De interne(private) container is gebaseerd op een List
        private List<T> items;

        public Stapel() {
            this.items = new List<T>();
        }

        //De publieke methoden 
        //Toevoegen (iets) : zet een generisch object op de stapel
        public void Toevoegen(T item) {
            items.Add(item);
        }

        //iets Verwijderen() : haal een generisch object van de stapel en return dit aan de oproeper
        public void Verwijderen(T item) {
            items.Remove(item);
        }

        //void Leegmaken() : haal alles van de stack
        public void Leegmaken() {
            items.Clear();
        }

        //string ToString () : als override van de bestaande ToString die de hele inhoud van de stack weergeeft in een string
        public override string ToString() {
            var res = string.Join(" - ", items);
            return res;
        }

        //bool IsAanwezig (iets) : een booleaanse methode die true is als een gegeven generisch object ergens in de stack voorkomt
        public bool IsAanwezig(T item) {
            if (items.Contains(item)) {
                return true;
            }
            else 
                return false;
        }

        //Stapel Copy () : maak een "shallow" kopij van een stapel naar een nieuwe stapel
        public object Shallowcopy() {
            return this.MemberwiseClone();
        }

        //Gebruik de methode MemberwiseClone()
    }
}
