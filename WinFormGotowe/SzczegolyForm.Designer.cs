namespace WinForm1
{
    partial class SzczegolyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelID = new Label();
            labelImie = new Label();
            labelNazwisko = new Label();
            labelTypUzytkownika = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            labelPrzypisaneZadanie = new Label();
            label1 = new Label();
            buttonDodajZadanie = new Button();
            textBoxNoweZadanie = new TextBox();
            labelPrzypiszZadanie = new Label();
            SuspendLayout();
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(69, 9);
            labelID.Name = "labelID";
            labelID.Size = new Size(0, 15);
            labelID.TabIndex = 0;
            // 
            // labelImie
            // 
            labelImie.AutoSize = true;
            labelImie.Location = new Point(69, 34);
            labelImie.Name = "labelImie";
            labelImie.Size = new Size(0, 15);
            labelImie.TabIndex = 1;
            // 
            // labelNazwisko
            // 
            labelNazwisko.AutoSize = true;
            labelNazwisko.Location = new Point(69, 58);
            labelNazwisko.Name = "labelNazwisko";
            labelNazwisko.Size = new Size(0, 15);
            labelNazwisko.TabIndex = 2;
            // 
            // labelTypUzytkownika
            // 
            labelTypUzytkownika.AutoSize = true;
            labelTypUzytkownika.Location = new Point(113, 83);
            labelTypUzytkownika.Name = "labelTypUzytkownika";
            labelTypUzytkownika.Size = new Size(0, 15);
            labelTypUzytkownika.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 7;
            label2.Text = "ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 34);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 8;
            label3.Text = "Imię:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 58);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 9;
            label4.Text = "Nazwisko:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 83);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 10;
            label5.Text = "Typ Użytkownika:";
            // 
            // labelPrzypisaneZadanie
            // 
            labelPrzypisaneZadanie.AutoSize = true;
            labelPrzypisaneZadanie.Location = new Point(12, 109);
            labelPrzypisaneZadanie.Name = "labelPrzypisaneZadanie";
            labelPrzypisaneZadanie.Size = new Size(90, 15);
            labelPrzypisaneZadanie.TabIndex = 12;
            labelPrzypisaneZadanie.Text = "Numer zadania:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 141);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 4;
            label1.Text = "Podaj numer zadania";
            // 
            // buttonDodajZadanie
            // 
            buttonDodajZadanie.Location = new Point(116, 159);
            buttonDodajZadanie.Name = "buttonDodajZadanie";
            buttonDodajZadanie.Size = new Size(75, 23);
            buttonDodajZadanie.TabIndex = 13;
            buttonDodajZadanie.Text = "Dodaj Zadanie";
            buttonDodajZadanie.UseVisualStyleBackColor = true;
            buttonDodajZadanie.Click += buttonDodajZadanie_Click;
            // 
            // textBoxNoweZadanie
            // 
            textBoxNoweZadanie.Location = new Point(10, 159);
            textBoxNoweZadanie.Name = "textBoxNoweZadanie";
            textBoxNoweZadanie.Size = new Size(100, 23);
            textBoxNoweZadanie.TabIndex = 14;
            // 
            // labelPrzypiszZadanie
            // 
            labelPrzypiszZadanie.AutoSize = true;
            labelPrzypiszZadanie.Location = new Point(113, 109);
            labelPrzypiszZadanie.Name = "labelPrzypiszZadanie";
            labelPrzypiszZadanie.Size = new Size(0, 15);
            labelPrzypiszZadanie.TabIndex = 15;
            // 
            // SzczegolyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelPrzypiszZadanie);
            Controls.Add(textBoxNoweZadanie);
            Controls.Add(buttonDodajZadanie);
            Controls.Add(labelPrzypisaneZadanie);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelTypUzytkownika);
            Controls.Add(labelNazwisko);
            Controls.Add(labelImie);
            Controls.Add(labelID);
            Name = "SzczegolyForm";
            Text = "SzczegolyForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelID;
        private Label labelImie;
        private Label labelNazwisko;
        private Label labelTypUzytkownika;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label labelPrzypisaneZadanie;
        private Label label1;
        private Button buttonDodajZadanie;
        private TextBox textBoxNoweZadanie;
        private Label labelPrzypiszZadanie;
    }
}