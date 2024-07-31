namespace WinForm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem newItem = new ListViewItem(textBox1.Text);
            newItem.SubItems.Add(textBox2.Text);
            newItem.SubItems.Add(textBox3.Text);
            newItem.SubItems.Add(checkBox2.Checked ? "Klient" : "Kontrahent");
            listView1.Items.Add(newItem);

            clearUserFields();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var wynik = MessageBox.Show("Czy na pewno chcesz usun¹æ wybrany element?",
                                               "Potwierdzenie usuniêcia",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Warning);

                if (wynik == DialogResult.Yes)
                {
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].SubItems[0].Text = textBox1.Text;
                listView1.SelectedItems[0].SubItems[1].Text = textBox2.Text;
                listView1.SelectedItems[0].SubItems[2].Text = textBox3.Text;
                listView1.SelectedItems[0].SubItems[3].Text = checkBox2.Checked ? "Klient" : "Kontrahent";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("ID", 80);
            listView1.Columns.Add("Imiê", 120);
            listView1.Columns.Add("Nazwisko", 120);
            listView1.Columns.Add("Typ u¿ytkownika", 120);

            listView2.Columns.Add("Nr.Zad", 120);
            listView2.Columns.Add("Nazwa", 120);
            listView2.Columns.Add("Opis", 120);
            listView2.Columns.Add("Status", 120);
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
                textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
                textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListViewItem newItem = new ListViewItem(textBox4.Text);
            newItem.SubItems.Add(textBox5.Text);
            newItem.SubItems.Add(textBox6.Text);
            newItem.SubItems.Add(checkBox1.Checked ? "Ukoñczone" : "Nieukoñczone");
            listView2.Items.Add(newItem);

            clearTaskFields();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                var result = MessageBox.Show("Czy na pewno chcesz usun¹æ wybrany element?",
                                               "Potwierdzenie usuniêcia",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    listView2.Items.Remove(listView2.SelectedItems[0]);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                listView2.SelectedItems[0].SubItems[0].Text = textBox4.Text;
                listView2.SelectedItems[0].SubItems[1].Text = textBox5.Text;
                listView2.SelectedItems[0].SubItems[2].Text = textBox6.Text;
                listView2.SelectedItems[0].SubItems[3].Text = checkBox1.Checked ? "Ukoñczone" : "Nieukoñczone";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            clearUserFields();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            clearTaskFields();
        }
        private void clearUserFields()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        private void clearTaskFields()
        {
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void listView2_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                textBox4.Text = listView2.SelectedItems[0].SubItems[0].Text;
                textBox5.Text = listView2.SelectedItems[0].SubItems[1].Text;
                textBox6.Text = listView2.SelectedItems[0].SubItems[2].Text;
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var selectedItem = listView1.SelectedItems[0];
                string id = selectedItem.SubItems[0].Text;
                string imie = selectedItem.SubItems[1].Text;
                string nazwisko = selectedItem.SubItems[2].Text;
                string typuzytkownika = selectedItem.SubItems[3].Text;

                SzczegolyForm szczegolyForm = new SzczegolyForm(id, imie, nazwisko, typuzytkownika);
                szczegolyForm.ShowDialog();
            }
        }
    }
}

