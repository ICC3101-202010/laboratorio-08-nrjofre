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
    public partial class Form1 : Form
    {
        List<Tienda> tiendas = new List<Tienda>();
        List<Recreacional> recreacionales = new List<Recreacional>();
        List<Cine> cines = new List<Cine>();
        List<Restaurante> restaurantes = new List<Restaurante>();

        public Form1()
        {
            InitializeComponent();
            cines.Add(new Cine("CineHoyts", "0001", "Roberto", "9am - 1am", "10"));
            cines.Add(new Cine("CineMark", "0002", "Rodrigo", "9am - 1am", "12"));
            cines.Add(new Cine("CineMundo", "0003", "Ramon", "9am - 1am", "15"));

            recreacionales.Add(new Recreacional("Recreacional1", "0001", "Roberto", "1pm - 1am"));
            recreacionales.Add(new Recreacional("Recreacional2", "0002", "Rodrigo", "9am - 1am"));
            recreacionales.Add(new Recreacional("Recreacional3", "0003", "Ramon", "9am - 1am"));

            restaurantes.Add(new Restaurante("Nueva China", "0001", "Roberto", "11am - 11pm", "Si"));
            restaurantes.Add(new Restaurante("Burger King", "0002", "Rodrigo", "11am - 11pm", "No"));
            restaurantes.Add(new Restaurante("El Italiano", "0003", "Ramon", "11am - 11pm", "No"));

            tiendas.Add(new Tienda("Ripley", "0001", "Roberto", "9am - 11am", "10"));
            tiendas.Add(new Tienda("Paris", "0002", "Rodrigo", "9am - 11am", "12"));
            tiendas.Add(new Tienda("Falabella", "0003", "Ramon", "9am - 11am", "15"));

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TipoLocalBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TipoLocalBox.Text == "Cine")
            {
                RestauranteComboBox.Visible = false;
                labelRestaurantes.Visible = false;
                labelTiendas.Visible = false;
                labelCines.Visible = true;
                textBox4.Visible = true;
            }
            else if (TipoLocalBox.Text == "Recreacional")
            {
                RestauranteComboBox.Visible = false;
                textBox4.Visible = false;
                labelRestaurantes.Visible = false;
                labelCines.Visible = false;
                labelTiendas.Visible = false;
            }
            else if (TipoLocalBox.Text == "Restaurante")
            {
                RestauranteComboBox.Visible = true;
                labelTiendas.Visible = false;
                labelCines.Visible = false;
                labelRestaurantes.Visible = true;
                textBox4.Visible = true;
            }
            else if (TipoLocalBox.Text == "Tienda")
            {
                RestauranteComboBox.Visible = false;
                labelRestaurantes.Visible = false;
                labelCines.Visible = false;
                labelTiendas.Visible = true;
                textBox4.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PanelAgregar.Visible = true;
            panel2.Visible = false;
        }

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            if (TipoLocalBox.Text == "Cine")
            {
                Cine cine = new Cine(textBox5.Text, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                cines.Add(cine);
            }
            else if (TipoLocalBox.Text == "Recreacional")
            {
                Recreacional recreacional = new Recreacional(textBox5.Text, textBox1.Text, textBox2.Text, textBox3.Text);
                recreacionales.Add(recreacional);
            }
            else if (TipoLocalBox.Text == "Restaurante")
            {
                Restaurante restaurante = new Restaurante(textBox5.Text, textBox1.Text, textBox2.Text, textBox3.Text, RestauranteComboBox.Text);
                restaurantes.Add(restaurante);
            }
            else if (TipoLocalBox.Text == "Tienda")
            {
                Tienda tienda = new Tienda(textBox5.Text, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                tiendas.Add(tienda);
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            RestauranteComboBox.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            PanelAgregar.Visible = false;
            Form2 form2 = new Form2(cines, restaurantes, recreacionales, tiendas);
            form2.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PanelAgregar.Visible = false;
            panel2.Visible = true;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Cine")
            {
                NomTextBox2.Clear();
                IDTextBox2.Clear();
                DueñoTextbox2.Clear();
                HorarioTextbox2.Clear();
                textboxcineytiendayrestaurante2.Clear();
                
                cinelabel2.Visible = true;
                tiendalabel2.Visible = false;
                restaurantelabel2.Visible = false;
                textboxcineytiendayrestaurante2.Visible = true;
            }
            else if (comboBox2.Text == "Recreacional")
            {
                NomTextBox2.Clear();
                IDTextBox2.Clear();
                DueñoTextbox2.Clear();
                HorarioTextbox2.Clear();
                textboxcineytiendayrestaurante2.Clear();
                
                cinelabel2.Visible = false;
                tiendalabel2.Visible = false;
                restaurantelabel2.Visible = false;
                textboxcineytiendayrestaurante2.Visible = false;
            }
            else if (comboBox2.Text == "Restaurante")
            {
                NomTextBox2.Clear();
                IDTextBox2.Clear();
                DueñoTextbox2.Clear();
                HorarioTextbox2.Clear();
                textboxcineytiendayrestaurante2.Clear();
                
                cinelabel2.Visible = false;
                tiendalabel2.Visible = false;
                restaurantelabel2.Visible = true;
                textboxcineytiendayrestaurante2.Visible = true;
            }
            else if (comboBox2.Text == "Tienda")
            {
                NomTextBox2.Clear();
                IDTextBox2.Clear();
                DueñoTextbox2.Clear();
                HorarioTextbox2.Clear();
                textboxcineytiendayrestaurante2.Clear();
                
                cinelabel2.Visible = false;
                restaurantelabel2.Visible = false;
                textboxcineytiendayrestaurante2.Visible = true;
                tiendalabel2.Visible = true;
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void NomTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string nombreloc = NomTextBox2.Text;
            NomTextBox2.Clear();
            IDTextBox2.Clear();
            DueñoTextbox2.Clear();
            HorarioTextbox2.Clear();
            textboxcineytiendayrestaurante2.Clear();

            if (comboBox2.Text == "Cine")
            {
                try
                {
                    Cine asd = cines.Where(cine => cine.nombre == nombreloc).FirstOrDefault();
                    if (asd == null)
                    {
                        NomTextBox2.Text = "No Existe";
                    }
                    else
                    {
                        NomTextBox2.Text = asd.nombre;
                        DueñoTextbox2.Text = asd.dueño;
                        IDTextBox2.Text = asd.id;
                        HorarioTextbox2.Text = asd.horario;
                        textboxcineytiendayrestaurante2.Text = asd.nSalas;
                    }
                }
                catch
                {
                    NomTextBox2.Text = "No Existe";
                }
                

            }
            else if (comboBox2.Text == "Recreacional")
            {
                try
                {
                    Recreacional asd = recreacionales.Where(recreacional => recreacional.nombre == nombreloc).FirstOrDefault();
                    if (asd == null)
                    {
                        NomTextBox2.Text = "No Existe";
                    }
                    else
                    {
                        DueñoTextbox2.Text = asd.dueño;
                        IDTextBox2.Text = asd.id;
                        HorarioTextbox2.Text = asd.horario;
                    }
                    
                }
                catch
                {
                    NomTextBox2.Text = "No Existe";
                }
                
            }
            else if (comboBox2.Text == "Restaurante")
            {
                try
                {
                    Restaurante asd = restaurantes.Where(restaurante => restaurante.nombre == nombreloc).FirstOrDefault();
                    if (asd == null)
                    {
                        NomTextBox2.Text = "No Existe";
                    }
                    else
                    {
                        DueñoTextbox2.Text = asd.dueño;
                        IDTextBox2.Text = asd.id;
                        HorarioTextbox2.Text = asd.horario;
                        textboxcineytiendayrestaurante2.Text = asd.mesasExclusivas;
                    }
                    
                }
                catch
                {
                    NomTextBox2.Text = "No Existe";
                }
                
            }
            else if (comboBox2.Text == "Tienda")
            {
                try
                {
                    Tienda asd = tiendas.Where(tienda => tienda.nombre == nombreloc).FirstOrDefault();
                    if (asd == null)
                    {
                        NomTextBox2.Text = "No Existe";
                    }
                    else
                    {
                        DueñoTextbox2.Text = asd.dueño;
                        IDTextBox2.Text = asd.id;
                        HorarioTextbox2.Text = asd.horario;
                        textboxcineytiendayrestaurante2.Text = asd.categorias;
                    }
                    
                }
                catch
                {
                    NomTextBox2.Text = "No Existe";
                }
                
            }
            

        }
    }
}
