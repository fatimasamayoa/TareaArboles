using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaArboles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Declaración de variables a utilizar
        int Dato = 0;
        int cont = 0;
        ArbolBinario miArbol = new ArbolBinario(null);   
        
        //Creación del objeto Árbol      
        Graphics g;         
            
        //Definición del objeto gráfico
        //Evento del formulario que permitirá dibujar el Árbol Binario
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g = e.Graphics;
            miArbol.DibujarArbol(g, this.Font, Brushes.Blue, Brushes.White, Pens.Black, Brushes.White); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            { 
                MessageBox.Show("Debe ingresar el valor a buscar"); 
            }else 
            { 
                Dato = Convert.ToInt32(txtBuscar.Text); 
                if (Dato <= 0 || Dato >= 100) 
                { 
                    MessageBox.Show("Error de Ingreso"); 
                } else 
                {   
                    miArbol.Buscar(Dato); 
                    txtBuscar.Clear(); 
                    txtBuscar.Focus(); 
                    Refresh(); 
                    Refresh(); 
                } 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario ElUsuario;
            ElUsuario = new Usuario(textBox1.Text, int.Parse(textBox2.Text), double.Parse(textBox3.Text), textBox4.Text);
            
            MessageBox.Show("Datos ingresados");

            if (textBox1.Text == "")
            {
                MessageBox.Show("Debe Ingresar un Valor");
            }
            else
            {
                textBox1.Clear(); textBox1.Focus(); cont++; Refresh(); Refresh();
            }

            if (textBox2.Text == "")
            {
                MessageBox.Show("Debe Ingresar un Valor");
            }
            else
            {
                textBox2.Clear(); textBox1.Focus(); cont++; Refresh(); Refresh();
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("Debe Ingresar un Valor");
            }
            else
            {
                textBox3.Clear(); textBox1.Focus(); cont++; Refresh(); Refresh();
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("Debe Ingresar un Valor");
            }
            else
            {
                textBox4.Clear(); textBox1.Focus(); cont++; Refresh(); Refresh();
            }

            if (txtBuscar.Text == "")

                if (txtDato.Text == "") 
            { 
                MessageBox.Show("Debe Ingresar un Valor"); 
            } else 
            {
                              
                Dato = int.Parse(txtDato.Text); 
                if (Dato <= 0 || Dato >= 100) 
                    MessageBox.Show("Solo Recibe Valores desde 1 hasta 99", "Error de Ingreso"); 
                else { 
                    miArbol.Insertar(Dato); txtDato.Clear(); txtDato.Focus(); cont++; Refresh(); Refresh(); 
                } 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtEliminar.Text == "") 
            { 
                MessageBox.Show("Debe ingresar el valor a eliminar"); 
            } else 
            { Dato = Convert.ToInt32(txtEliminar.Text); 
                if (Dato <= 0 || Dato >= 100) 
                { 
                    MessageBox.Show("Error de Ingreso"); 
                } else 
                { miArbol.Eliminar(Dato);
                    MessageBox.Show("Elemento eliminado");
                    txtEliminar.Clear(); 
                    txtEliminar.Focus(); 
                    cont--; 
                    Refresh(); 
                    Refresh(); 
                } 
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
