using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonCount_Click(object sender, EventArgs e)
        {
            string imie = textBoxName.Text; // wyciągamy z pola tekst, który wpisał użytkownik.'
            string nazwisko = textBoxSurname.Text; 
            // odwołujemy sie do właściwości obiektu czyli tego co zostało wpisane poprzez TEXT
            // Text jest właściwością obiektu.
            int wiek = int.Parse(textBoxAge.Text);

            if (wiek >= 67)
                labelWynik.Text = "jesteś emerytem";
            else
                labelWynik.Text = $"Do emerytury zostało ci {67 - wiek} lat ";
         } 
    }
}
