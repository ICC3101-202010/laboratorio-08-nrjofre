using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class Form2 : Form
    {
        List<Tienda> tiendas;
        List<Recreacional> recreacionales;
        List<Cine> cines;
        List<Restaurante> restaurantes;
        
        public Form2(List<Cine> ciness, List<Restaurante> restaurantess, List<Recreacional> recreacionaless, List<Tienda> tiendass)
        {
            InitializeComponent();
            cines = ciness;
            tiendas = tiendass;
            recreacionales = recreacionaless;
            restaurantes = restaurantess;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            string newLine = Environment.NewLine;
            textBox1.Text = 
                "Cines:" + newLine + "\t" +  String.Join(newLine + "\t", cines.Select(x => x.nombre)) + newLine + 
                "Recreacionales:" + newLine + "\t" + String.Join(newLine + "\t", recreacionales.Select(x => x.nombre)) + newLine +
                "Restaurantes:" + newLine + "\t" + String.Join(newLine + "\t", restaurantes.Select(x => x.nombre)) + newLine +
                "Tiendas:" + newLine + "\t" + String.Join(newLine + "\t", tiendas.Select(x => x.nombre));
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
