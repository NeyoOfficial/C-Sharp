using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Klienci_i_Kontrahenci_Wersja_Rozszerzona
{
    public partial class Form1 : Form
    {
        private List<Zadanie> zadania = new List<Zadanie>();

        public Form1()
        {
            InitializeComponent();
        }

        private void DodajZadanie(object sender, EventArgs e)
        {
            var nazwa = textBox1.Text;
            var opis = textBox2.Text;

            if (!string.IsNullOrEmpty(nazwa))
            {
                zadania.Add(new Zadanie { Nazwa = nazwa, Opis = opis }); 
                MessageBox.Show("Zadanie dodane pomyœlnie.");
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Nazwa zadania nie mo¿e byæ pusta.");
            }
        }

        private void UsunZad(object sender, EventArgs e)
        {
            if (listBoxZadania.SelectedItem is Zadanie wybraneZadanie)
            {
                zadania.Remove(wybraneZadanie);
                MessageBox.Show("Zadanie usuniête.");
                UpdateTaskList();
            }
            else
            {
                MessageBox.Show("Wybierz zadanie do usuniêcia.");
            }
        }

        private void UpdateTaskList()
        {
            listBoxZadania.Items.Clear();
            foreach (var zadanie in zadania)
            {
                listBoxZadania.Items.Add(zadanie); // Dodawanie zadania do listy
            }
        }

        private void ClearInputFields()
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }

    public class Zadanie
    {
        public string Nazwa { get; set; }
        public string Opis { get; set; }

        public override string ToString() // Aby w ListBox wyœwietliæ tylko nazwê zadania.
        {
            return Nazwa;
        }
    }
}