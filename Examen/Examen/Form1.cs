using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Examen.Clases;
using Examen.Clases.Gestion;
using Examen.Clases.POCO;


namespace Examen
{
    public partial class Form1 : Form
    {
        ValidacionTexto validador;
        CalculoCirculo circulo;
        CalculoRectangulo rectangulo;
        CalculoCuadrado cuadrado;
        Archivo archivo;
        GestorFiguras gestorCuadrado;
        GestorFiguras gestorRectangulo;
        GestorFiguras gestorCirculo;
        Figura figCuadrado;
        Figura figRectangulo;
        Figura figCirculo;

        public Form1()
        {
            InitializeComponent();
            validador = new ValidacionTexto();
            circulo = new CalculoCirculo();
            rectangulo = new CalculoRectangulo();
            cuadrado = new CalculoCuadrado();
            archivo = new Archivo();
            figCuadrado = new Figura();
            figRectangulo = new Figura();
            figCirculo = new Figura();
            cmbTipo.SelectedItem = "Area";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ValidacionTexto validador = new ValidacionTexto();
            CalculoCirculo circulo = new CalculoCirculo();
            CalculoRectangulo rectangulo = new CalculoRectangulo();
            CalculoCuadrado cuadrado = new CalculoCuadrado();

           //Validacion para que solo contenga caracteres alfanumericos en los tres textbox
           if (validador.contieneCarEspeciales(txtLado.Text) && validador.contieneCarAlfabeticos(txtLado.Text) ||
                   validador.contieneCarEspeciales(txtBase.Text) && validador.contieneCarAlfabeticos(txtBase.Text) ||
                   validador.contieneCarEspeciales(txtAltura.Text) && validador.contieneCarAlfabeticos(txtAltura.Text) ||
                   validador.contieneCarEspeciales(txtRadio.Text) && validador.contieneCarAlfabeticos(txtRadio.Text))
            {
                MessageBox.Show("Entrada con caracteres alfabeticos y especiales");
            }
            else if (validador.contieneCarEspeciales(txtLado.Text) || validador.contieneCarEspeciales(txtBase.Text) ||
                    validador.contieneCarEspeciales(txtAltura.Text) || validador.contieneCarEspeciales(txtRadio.Text))
            {
                MessageBox.Show("Entrada con caracteres especiales");
            }
            else if (validador.contieneCarAlfabeticos(txtLado.Text) || validador.contieneCarAlfabeticos(txtBase.Text) ||
                    validador.contieneCarAlfabeticos(txtAltura.Text) || validador.contieneCarAlfabeticos(txtRadio.Text))
            {
                MessageBox.Show("Entrada con caracteres alfabeticos");
            }
            else
            {
                //Calculo del area de cada figura
                if (cmbTipo.SelectedItem.ToString() == "Area")
                {
                    string textoCuadrado = Convert.ToString(cuadrado.area(Convert.ToDouble(txtLado.Text)));
                    string textRectangulo = Convert.ToString(rectangulo.area(Convert.ToDouble(txtBase.Text), Convert.ToDouble(txtAltura.Text)));
                    string textoCirculo = Convert.ToString(circulo.area(Convert.ToDouble(txtRadio.Text)));

                    txtCuadrado.Text = textoCuadrado;
                    txtRectangulo.Text = textRectangulo;
                    txtCirculo.Text = textoCirculo;

                    lstBoxCalculos.Items.Add("El area del cuadrado con lado de " + txtLado.Text + " es " + textoCuadrado);
                    lstBoxCalculos.Items.Add("El area del rectangulo con base de " + txtBase.Text + " y con altura de " + txtAltura.Text + " es " + textRectangulo);
                    lstBoxCalculos.Items.Add("El area del circulo con radio de " + txtRadio.Text + " es " + textoCirculo);

                    //Insercion en la base datos
                    figCuadrado.figura = "cuadrado";
                    figCuadrado.formula = "L*L";
                    figCuadrado.calculo = "Area";
                    figCuadrado.datos = "Lado=" + txtLado.Text;
                    figCuadrado.resultado = textoCuadrado;
                    gestorCuadrado = new GestorFiguras(figCuadrado);

                    figRectangulo.figura = "rectangulo";
                    figRectangulo.formula = "B*H";
                    figRectangulo.calculo = "Area";
                    figRectangulo.datos = "Base=" + txtBase.Text + "  Altura=" + txtAltura.Text;
                    figRectangulo.resultado = textRectangulo;
                    gestorRectangulo = new GestorFiguras(figRectangulo);

                    figCirculo.figura = "circulo";
                    figCirculo.formula = "PI*(R*R)";
                    figCirculo.calculo = "Area";
                    figCirculo.datos = "Radio=" + txtRadio.Text ;
                    figCirculo.resultado = textoCirculo;
                    gestorCirculo = new GestorFiguras(figCirculo);
                    
                    if(gestorRectangulo.insertarFigura()&&gestorCirculo.insertarFigura()&&gestorCuadrado.insertarFigura())
                        MessageBox.Show("Figuras insertadas correctamente a la base datos", "Mensaje");
                    else
                        MessageBox.Show("Error no se pudieron insertar las figuras a la base de datos", "Error");
                }
                //Calculo del perimetro de cada figura
                else if (cmbTipo.SelectedItem.ToString() == "Perimetro")
                {
                    string textoCuadrado = Convert.ToString(cuadrado.perimetro(Convert.ToDouble(txtLado.Text)));
                    string textRectangulo = Convert.ToString(rectangulo.perimetro(Convert.ToDouble(txtBase.Text), Convert.ToDouble(txtAltura.Text)));
                    string textoCirculo = Convert.ToString(circulo.perimetro(Convert.ToDouble(txtRadio.Text)));

                    txtCuadrado.Text = textoCuadrado;
                    txtRectangulo.Text = textRectangulo;
                    txtCirculo.Text = textoCirculo;

                    lstBoxCalculos.Items.Add("El perimetro del cuadrado con lado de " + txtLado.Text + " es " + textoCuadrado);
                    lstBoxCalculos.Items.Add("El perimetro del rectangulo con base de " + txtBase.Text + " y con altura de " + txtAltura.Text + " es " + textRectangulo);
                    lstBoxCalculos.Items.Add("El perimetro del circulo con radio de " + txtRadio.Text + " es " + textoCirculo);


                    //Insercion en la base datos
                    figCuadrado.figura = "cuadrado";
                    figCuadrado.formula = "L*L";
                    figCuadrado.calculo = "Perminetro";
                    figCuadrado.datos = "Lado=" + txtLado.Text;
                    figCuadrado.resultado = textoCuadrado;
                    gestorCuadrado = new GestorFiguras(figCuadrado);

                    figRectangulo.figura = "rectangulo";
                    figRectangulo.formula = "B*H";
                    figRectangulo.calculo = "Perminetro";
                    figRectangulo.datos = "Base=" + txtBase.Text + "  Altura=" + txtAltura.Text;
                    figRectangulo.resultado = textRectangulo;
                    gestorRectangulo = new GestorFiguras(figRectangulo);

                    figCirculo.figura = "circulo";
                    figCirculo.formula = "PI*(R*R)";
                    figCirculo.calculo = "Perminetro";
                    figCirculo.datos = "Radio=" + txtRadio.Text;
                    figCirculo.resultado = textoCirculo;
                    gestorCirculo = new GestorFiguras(figCirculo);

                    if (gestorCuadrado.insertarFigura() && gestorCirculo.insertarFigura() && gestorRectangulo.insertarFigura())
                        MessageBox.Show("Figuras insertadas correctamente a la base datos", "Mensaje");
                    else
                        MessageBox.Show("Error no se pudieron insertar las figuras a la base de datos", "Error");
                }
            }
            
        }



        private void button2_Click(object sender, EventArgs e)
        {
            string texto = "";
            //Leer todo el contenido de los listbox
            foreach (Object o in lstBoxCalculos.Items)
            {
                texto += o.ToString()+"    ";
            }
            
           //Guardar el contenido en un archivo
            if (archivo.escribir(txtArchivo.Text, texto))
            {
                MessageBox.Show("Archivo creado correctamente", "Notificaion");
            }
            else
            {
                MessageBox.Show("El archivo no pudo escribirse", "Error");
            }
            
        }
    }
}
