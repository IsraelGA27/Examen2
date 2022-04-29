using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2
{
    public partial class Form2 : Form
    {
        public CheckBox? chbxMX;
        public CheckBox? chbxUSD;

        private Button btnCancel;
        public float Monto2, Conversion, Conversion2, Conversion3, Conversion4, Conversion5;
        public double resultado;
        public TextBox txtMoneda;


        public CheckBox? chbxCAD;
        public CheckBox? chbxEUR;
        public CheckBox? chbxJPY;

        public Label lblMensaje;
        private Button btnAceptar;
        

        public Form2()
        {
            //mensaje = "";
            btnCancel = new Button();
            btnAceptar = new Button();
            lblMensaje = new Label();
            InitializeComponent();
            InicializarComponentes();
        }

        private void InicializarComponentes()
        {
            this.Size = new Size(400, 450);
            this.Text = "Nueva Ventana";


            // MX
            chbxMX = new CheckBox();
            chbxMX.AutoSize = true;
            chbxMX.Location = new Point(15, 15);
            chbxMX.Text = "MXN - Pesos Mexicanos";
            this.Controls.Add(chbxMX);
            chbxMX.Visible = true;

            // USD
            chbxUSD = new CheckBox();
            chbxUSD.AutoSize = true;
            chbxUSD.Location = new Point(15, 40);
            chbxUSD.Text = "USD - Dólar Estadounidense";
            this.Controls.Add(chbxUSD);
            chbxUSD.Visible = true;

            // CAD
            chbxCAD = new CheckBox();
            chbxCAD.AutoSize = true;
            chbxCAD.Location = new Point(15, 65);
            chbxCAD.Text = "CAD - Dólar Canadiense";
            this.Controls.Add(chbxCAD);
            chbxCAD.Visible = true;

            // EUR
            chbxEUR = new CheckBox();
            chbxEUR.AutoSize = true;
            chbxEUR.Location = new Point(15, 90);
            chbxEUR.Text = "EUR - Euro";
            this.Controls.Add(chbxEUR);
            chbxEUR.Visible = true;

            // JPY
            chbxJPY = new CheckBox();
            chbxJPY.AutoSize = true;
            chbxJPY.Location = new Point(15, 115);
            chbxJPY.Text = "JPY - Yen Japonés";
            this.Controls.Add(chbxJPY);
            chbxJPY.Visible = true;

            btnAceptar.Text = "Aceptar";
            btnAceptar.AutoSize = true;
            btnAceptar.Location = new Point(290, 350);

            // Anidar Evento -- Cerrar 
            btnAceptar.Click += new EventHandler(btnAceptar_Click);
            this.Controls.Add(btnAceptar);

            btnCancel.Text = "Cancelar";
            btnCancel.AutoSize = true;
            btnCancel.Location = new Point(20, 350);

            // Anidar Evento -- Cerrar 
            btnCancel.Click += new EventHandler(btnCancelar_Click);
            this.Controls.Add(btnCancel);


            //Moneda
            txtMoneda = new TextBox();
            txtMoneda.Location = new Point(15, 135);
            this.Controls.Add(txtMoneda);


            

        }

        private void btnAceptar_Click(Object? sender, EventArgs e)
        {
            if (txtMoneda.Text != "Selecciona Moneda" && Monto2 > 0)
            {
                Form1 f1 = new Form1();

                if (txtMoneda.Text == "MXN (Peso Mexicano)")
                {
                    if (chbxMX.Checked)
                    {
                        resultado = Monto2 * 1;
                        f1.txtMonto1.Text = Convert.ToString(resultado);
                        f1.lblMX.Visible = true;
                        f1.txtMonto1.Visible = true;
                    }
                    if (chbxUSD.Checked)
                    {
                        resultado = Monto2 * 0.05;
                        f1.txtMonto4.Text = Convert.ToString(resultado);
                        f1.lblUSD.Visible = true;
                        f1.txtMonto4.Visible = true;
                    }
                    if (chbxCAD.Checked)
                    {
                        resultado = Monto2 * 0.06;
                        f1.txtMonto2.Text = Convert.ToString(resultado);
                        f1.lblCAD.Visible = true;
                        f1.txtMonto2.Visible = true;
                    }
                    if (chbxEUR.Checked)
                    {
                        resultado = Monto2 * 0.04;
                        f1.txtMonto3.Text = Convert.ToString(resultado);
                        f1.lblEUR.Visible = true;
                        f1.txtMonto3.Visible = true;
                    }
                    if (chbxJPY.Checked)
                    {
                        resultado = Monto2 * 5.32;
                        f1.txtMonto5.Text = Convert.ToString(resultado);
                        f1.lblJPY.Visible = true;
                        f1.txtMonto5.Visible = true;
                    }
                    f1.Show();
                }
                if (txtMoneda.Text == "USD (Dolar Estadounidense)")
                {
                    if (chbxMX.Checked)
                    {
                        resultado = Monto2 * 21.23;
                    }
                    if (chbxUSD.Checked)
                    {
                        resultado = Monto2 * 1;
                    }
                    if (chbxCAD.Checked)
                    {
                        resultado = Monto2 * 1.28;
                    }
                    if (chbxEUR.Checked)
                    {
                        resultado = Monto2 * 0.89;
                    }
                    if (chbxJPY.Checked)
                    {
                        resultado = Monto2 * 113.05;
                    }
                }
                if (txtMoneda.Text == "CAD (Dolar Canadiense)")
                {
                    if (chbxMX.Checked)
                    {
                        resultado = Monto2 * 16.55;
                    }
                    if (chbxUSD.Checked)
                    {
                        resultado = Monto2 * 0.78;
                    }
                    if (chbxCAD.Checked)
                    {
                        resultado = Monto2 * 1;
                    }
                    if (chbxEUR.Checked)
                    {
                        resultado = Monto2 * 0.69;
                    }
                    if (chbxJPY.Checked)
                    {
                        resultado = Monto2 * 88.12;
                    }
                }
                if (txtMoneda.Text == "EUR (Euro)")
                {
                    if (chbxMX.Checked)
                    {
                        resultado = Monto2 * 23.96;
                    }
                    if (chbxUSD.Checked)
                    {
                        resultado = Monto2 * 0.78;
                    }
                    if (chbxCAD.Checked)
                    {
                        resultado = Monto2 * 1.45;
                    }
                    if (chbxEUR.Checked)
                    {
                        resultado = Monto2 * 1;
                    }
                    if (chbxJPY.Checked)
                    {
                        resultado = Monto2 * 127.56;
                    }
                }
                if (txtMoneda.Text == "JPY (Yen Japones)")
                {
                    if (chbxMX.Checked)
                    {
                        resultado = Monto2 * 0.1878;
                    }
                    if (chbxUSD.Checked)
                    {
                        resultado = Monto2 * 0.0088;
                    }
                    if (chbxCAD.Checked)
                    {
                        resultado = Monto2 * 0.0113;
                    }
                    if (chbxEUR.Checked)
                    {
                        resultado = Monto2 * 0.0078;
                    }
                    if (chbxJPY.Checked)
                    {
                        resultado = Monto2 * 1;
                    }
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(Object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            //this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

    }
}