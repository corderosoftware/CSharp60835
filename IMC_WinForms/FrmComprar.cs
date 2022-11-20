using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC_WinForms
{
    public partial class FrmComprar : Form
    {
        FrmMain main;
        List<Compra> listCompras = new List<Compra>();
        public FrmComprar(FrmMain frmMain)
        {
            InitializeComponent();
            main = frmMain; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            main.Show();
            this.Close();
        }

        private void FillCompras()
        {
            DgvCompras.DataSource = listCompras;
            DgvCompras.AutoGenerateColumns = false;
        }

        private Producto ObtenerProducto(string Codigo)
        {
            Producto productoFound= new Producto();
            List<Producto> listProductos = new List<Producto>();
            listProductos.Add(new Producto() { CodProducto = "12345", NombreProducto= "Ibuprofeno", Precio= 1200});
            listProductos.Add(new Producto() { CodProducto = "784512", NombreProducto = "Aspirina", Precio = 2000 });
            listProductos.Add(new Producto() { CodProducto = "998866", NombreProducto = "Alical", Precio = 800 });
            listProductos.Add(new Producto() { CodProducto = "774512", NombreProducto = "Tafirol", Precio = 2500 });

            foreach (Producto producto in listProductos)
            {
                if (producto.CodProducto == Codigo)
                {
                    Compra newCompra = new Compra();
                    newCompra.Producto = producto;
                    newCompra.Cantidad = 1;
                    newCompra.Subtotal = 1 * producto.Precio;

                    listCompras.Add(newCompra);

                    FillCompras(); //Invoca para llenar la Grilla

                    productoFound = producto;


                    break;
                }
            }

            return productoFound;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto producto = ObtenerProducto(TxtCodigo.Text);

            if (producto.CodProducto != null)
            {
                LblProducto.Text = producto.NombreProducto;
                LblPrecio.Text = producto.Precio.ToString();
            }
            else
            {
                LblProducto.Text = "PRODUCTO NO ENCONTRADO";
                LblPrecio.Text = "0,00";
            }

        }
    }

    struct Compra
    {
        public Producto Producto { private get;  set; }
        public string CodProducto { get { return Producto.CodProducto; } }
        public string NombreProducto { get { return Producto.NombreProducto; } }
        public double Precio { get { return Producto.Precio; } }
        public int Cantidad { get; set; }
        public double Subtotal { get; set; }
    }

    struct Producto
    {
        public string CodProducto { get; set; }
        public string NombreProducto { get; set; }
        public double Precio { get; set; }
    }




}
