using Oefening;

namespace Oefening1 {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Nieuwe objecten aanmaken en eentje verwijderen 
            Stapel<string> s1 = new Stapel<string>();
            s1.Toevoegen("Liefde");
            s1.Toevoegen("Deur");
            s1.Toevoegen("Chokomelk");
            s1.Toevoegen("muis");
            s1.Toevoegen("item 5");

            s1.Verwijderen("Deur");
            // s1.Leegmaken();

            s1.ToString();
           
            // Alles verwijderen 
            Stapel<string> s2 = new Stapel<string>();
            s2.Toevoegen("paard");
            s2.Toevoegen("computer");
            s2.Toevoegen("mensheid");
            s2.Toevoegen("dood");
            s2.Toevoegen("leven");

            s2.Leegmaken();
            s2.ToString();

            // IsAanwezig proberen
            Stapel<string> s3 = new Stapel<string>();
            s3.Toevoegen("boom");
            s3.Toevoegen("aardappel");
            s3.Toevoegen("opa");

            s3.IsAanwezig("boom");

            // Copy proberen
            Stapel<string> s4 = (Stapel<string>) s3.Shallowcopy();

            System.Diagnostics.Debug.WriteLine(s1);
            System.Diagnostics.Debug.WriteLine(s2);
            System.Diagnostics.Debug.WriteLine(s3.IsAanwezig("boom"));
            System.Diagnostics.Debug.WriteLine(s4);

            // Application.Run(new Form1());
        }
    }
}