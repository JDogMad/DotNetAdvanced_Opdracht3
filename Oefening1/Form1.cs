using Oefening;

namespace Oefening1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            var s1 = new Stapel<string>();
            s1.Toevoegen("item 1");
            s1.Toevoegen("item 2");
            s1.Toevoegen("item 3");
            s1.Toevoegen("item 4");
            s1.Toevoegen("item 5");

            s1.Verwijderen("item 3");
            // s1.Leegmaken();
            // s1.ToString();
            s1.IsAanwezig("item 2");
            s1.Shallowcopy();
        }
    }
}