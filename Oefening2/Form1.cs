using System.Collections.Generic;
using System.Diagnostics;

namespace Oefening2 {
    public partial class Form1 : Form {
        Personeel<string> personeelslijst = new Personeel<string>();
        Dier<string> dierenlijst = new Dier<string>();
        Dier<int> dierenData = new Dier<int>();
        Bezoekers<int> bezoekersdata = new Bezoekers<int>();
        Bezoekers<School> scholen = new Bezoekers<School>();

        int totaal;
        int totaalDieren;

        public Form1() {
            InitializeComponent();
        }

        // Methoden uittesten voor klasse Personeel 
        private void button1_Click(object sender, EventArgs e) {
            personeel.Text = personeelslijst.ToString();
        }
        private void button3_Click(object sender, EventArgs e) {
            personeelslijst.Toevoegen(nieuwePersoon.Text);
        }
        private void button5_Click(object sender, EventArgs e) {
            personeelslijst.Verwijderen(nieuwePersoon.Text);
        }
        private void button12_Click(object sender, EventArgs e) {
            personeel.Text = personeelslijst.IsAanwezig(nieuwePersoon.Text).ToString();
        }

        // Methoden uittesten voor klasse Dier
        private void button2_Click(object sender, EventArgs e) {
            dieren.Text = dierenlijst.ToString();
        }
        private void button4_Click(object sender, EventArgs e) {
            dierenlijst.Toevoegen(nieuweDier.Text);
        }
        private void button6_Click(object sender, EventArgs e) {
            dierenlijst.Verwijderen(nieuweDier.Text);
        }
        private void button7_Click(object sender, EventArgs e) {
            dierenlijst.Leegmaken();
        }
        private void button11_Click(object sender, EventArgs e) {
            dieren.Text = dierenlijst.IsAanwezig(nieuweDier.Text).ToString();
        }

        // Methoden uittesten voor klasse Bezoekers 
        private void button8_Click(object sender, EventArgs e) {
            totaal += int.Parse(bzVandaag.Text);
            bezoekersdata.Toevoegen(totaal);

            bzTotaal.Text = totaal.ToString();
        }

        // Methoden uittesten voor School <- Bezoekers
        private void button10_Click(object sender, EventArgs e) {
            School school = new School(nieuweSchool.Text);

            scholen.Toevoegen(school);
            scholenLijst.Text = scholen.ToString();
        }

        private void button9_Click(object sender, EventArgs e) {
            scholen.Verwijderen();
            scholenLijst.Text = scholen.ToString();
        }

        // Methoden uittesten voor Dieren data
        private void button16_Click(object sender, EventArgs e)  {
            totaalDieren += int.Parse(dierenCijfers.Text);
            dierenData.Toevoegen(totaalDieren);
        }

        private void button15_Click(object sender, EventArgs e) {
            totaalDieren -= int.Parse(dierenCijfers.Text);
            dierenData.Toevoegen(totaalDieren);
        }

        private void button17_Click(object sender, EventArgs e) {
            dierenDataCijfers.Text = dierenData.ToString();
        }

        private void button14_Click(object sender, EventArgs e) {
            dierenData.Leegmaken();
        }
        
        // Alle Data resseten 
        private void button13_Click(object sender, EventArgs e) {
            personeelslijst.Leegmaken();
            dierenlijst.Leegmaken();
            dierenData.Leegmaken();
            bezoekersdata.Leegmaken();
            scholen.Leegmaken();

            totaal = 0;
            totaalDieren = 0;

            personeel.Text = personeelslijst.ToString();
            dieren.Text = dierenlijst.ToString();
            dierenDataCijfers.Text = dierenData.ToString();
            scholenLijst.Text = scholen.ToString();
        }

        // Alle lijsten tonen 
        private void button18_Click(object sender, EventArgs e){
            personeel.Text = personeelslijst.ToString();
            dieren.Text = dierenlijst.ToString();
            dierenDataCijfers.Text = dierenData.ToString();
            scholenLijst.Text = scholen.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}