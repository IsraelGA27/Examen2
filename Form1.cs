namespace Examen2
{
    public partial class Form1 : Form
    {
        private Button btnCalcular; // Va a ser el "Calcular"
        private int num; // Para recorrer lo que obtengamos del Form2

        private Label? lblFigura;
        private ComboBox? cmbDivisas;
        private Label? lblMonto;
        private Label? lblConversiones;
        private TextBox? txtMonto;
        public Form1()
        {
            num = 1;
            btnCalcular = new Button();
            InitializeComponent();
            InicializarComponenetes();
        }

        private void InicializarComponenetes()
        {
            // Tamaño de la ventana
            this.Size = new Size(380, 550);
            // Nombre ventana
            this.Text = "Inicio";

            // Etiqueta Conversiones
            lblConversiones = new Label();
            lblConversiones.Text = "Conversiones";
            lblConversiones.AutoSize = true;
            lblConversiones.Location = new Point(10, 110);
            this.Controls.Add(lblConversiones);


            //Etiqueta Moneda
            lblFigura = new Label();
            lblFigura.Text = "Moneda";
            lblFigura.AutoSize = true;
            lblFigura.Location = new Point(10, 10);

            //ComboBox Monedas
            cmbDivisas = new ComboBox();
            cmbDivisas.Items.Add("Selecciona Moneda");
            cmbDivisas.Items.Add("MXN - Peso Mexicano");
            cmbDivisas.Items.Add("USD - Dólar Estadounidense");
            cmbDivisas.Items.Add("CAD - Dólar Canadiense");
            cmbDivisas.Items.Add("EUR - Euro");
            cmbDivisas.Items.Add("JPY - Yen Japonés");

            cmbDivisas.SelectedIndex = 0;
            cmbDivisas.Size = new Size(235, 235);
            cmbDivisas.Location = new Point(10, 40);
            cmbDivisas.SelectedValueChanged += new EventHandler(cmb_ValueChanged);

            //Etiqueta Monto
            lblMonto = new Label();
            lblMonto.Text = "Monto";
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(250, 10);

            //Cuadro de texto para el Monto
            txtMonto = new TextBox();
            txtMonto.Size = new Size(100, 20);
            txtMonto.Location = new Point(250, 40);


            btnCalcular.Text = "Calcular";
            btnCalcular.AutoSize = true;

            btnCalcular.Location = new Point(250, 70);
            btnCalcular.Click += new EventHandler(btnCalcular_Click);
            this.Controls.Add(btnCalcular);

            //Agregar controles a la ventana
            this.Controls.Add(lblFigura);
            this.Controls.Add(cmbDivisas);
            this.Controls.Add(lblMonto);
            this.Controls.Add(btnCalcular);
            this.Controls.Add(txtMonto);

        }

        private void cmb_ValueChanged(object sender, EventArgs e)
        {
            if (cmbDivisas.SelectedIndex != 0)
            {
                if (cmbDivisas.SelectedItem.ToString() == "MXN - Peso Mexicano")
                {
                    
                }
                if (cmbDivisas.SelectedItem.ToString() == "USD - Dólar Estadounidense")
                {

                }
                if (cmbDivisas.SelectedItem.ToString() == "CAD - Dólar Canadiense")
                {

                }
                if (cmbDivisas.SelectedItem.ToString() == "EUR - Euro")
                {

                }
                if (cmbDivisas.SelectedItem.ToString() == "JPY - Yen Japonés")
                {

                }
            }
            else
            {
                //txtAltura.Visible = false;
                //lblAltura.Visible = false;
            }
        }

        private void btnCalcular_Click(Object? sender, EventArgs e) //
        {
            Form2 frmVentana = new Form2();
            if (frmVentana.ShowDialog() == DialogResult.OK)
            {
                Label lblAgregado = new Label();
                lblAgregado.Text = frmVentana.mensaje; // Obtener un valor de el otro formulario?
                lblAgregado.AutoSize = true;
                lblAgregado.Location = new Point(10, 60 * num);
                num++; // Recorrer
                this.Controls.Add(lblAgregado);
            }
        }





        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}