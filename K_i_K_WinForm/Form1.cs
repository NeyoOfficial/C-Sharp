namespace K_i_K_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            listView1.Columns.Add("ID", 80);
            listView1.Columns.Add("Imiê", 120);
            listView1.Columns.Add("Nazwisko", 120);

            listView2.Columns.Add("Nr.Zad", 120);
            listView2.Columns.Add("Nazwa", 120);
            listView2.Columns.Add("Opis", 120);
            listView2.Columns.Add("Status", 120);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ListViewItem newItem = new(textBox1.Text);
            newItem.SubItems.Add(textBox2.Text);
            newItem.SubItems.Add(textBox3.Text);

            listView1.Items.Add(newItem);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void ListView1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
                textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
                textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].SubItems[0].Text = textBox1.Text;
                listView1.SelectedItems[0].SubItems[1].Text = textBox2.Text;
                listView1.SelectedItems[0].SubItems[2].Text = textBox3.Text;
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            checkBox1.Checked = false;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ListViewItem newItem = new(textBox4.Text);
            newItem.SubItems.Add(textBox5.Text);
            newItem.SubItems.Add(textBox6.Text);
            newItem.SubItems.Add(checkBox1.Checked ? "Ukoñczone" : "Nieukoñczone");
            listView2.Items.Add(newItem);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                listView2.Items.Remove(listView2.SelectedItems[0]);
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                listView2.SelectedItems[0].SubItems[0].Text = textBox4.Text;
                listView2.SelectedItems[0].SubItems[1].Text = textBox5.Text;
                listView2.SelectedItems[0].SubItems[2].Text = textBox6.Text;
                listView2.SelectedItems[0].SubItems[3].Text = checkBox1.Checked ? "Ukoñczone" : "Nieukoñczone";
            }
        }
    }
}
