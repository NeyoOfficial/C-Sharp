using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinForm1
{
    public partial class SzczegolyForm : Form
    {
        private string id;
        private string imie;
        private string nazwisko;
        private string typuzytkownika;

        private List<string> zadania = new List<string>();

        public SzczegolyForm(string id, string imie, string nazwisko, string typuzytkownika)
        {
            InitializeComponent();

            this.id = id;
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.typuzytkownika = typuzytkownika;

            labelID.Text = id;
            labelImie.Text = imie;
            labelNazwisko.Text = nazwisko;
            labelTypUzytkownika.Text = typuzytkownika;
        }

        private void buttonDodajZadanie_Click(object sender, EventArgs e)
        {
            string noweZadanie = textBoxNoweZadanie.Text.Trim();
            if (!string.IsNullOrEmpty(noweZadanie))
            {
                zadania.Add(noweZadanie);

                labelPrzypisaneZadanie.Text = $"Przypisane zadanie: {noweZadanie}";
                textBoxNoweZadanie.Clear();
                MessageBox.Show("Zadanie dodane i przypisane: " + noweZadanie);
            }
            else
            {
                MessageBox.Show("Proszę wpisać zadanie.");
            }
        }
    }
}
