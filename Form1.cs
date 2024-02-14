using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_ejercicio3_sueldo_empleado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Procesar_Click(object sender, EventArgs e)
        {

            int Pago_Hora = Convert.ToInt32(txt_pago_hora.Text);

            int Horas_Trabajadas = Convert.ToInt32(txt_Horas_Trabajadas.Text);   

            double Sueldo_Bruto = Horas_Trabajadas * Pago_Hora;

            double SFS = Sueldo_Bruto * 3.04 /100;
            double AFP = Sueldo_Bruto * 2.87 / 100;

            double descuento = SFS + AFP;
            txt_Total_descuento.Text = descuento.ToString();

            double Sueldo_Neto = Sueldo_Bruto - descuento;

            txt_AFP.Text = Convert.ToString(AFP);
            txt_SFS.Text = Convert.ToString(SFS);

            txt_sueldo_neto.Text = Convert.ToString(Sueldo_Neto);



        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
            txt_AFP.Enabled = false;
            txt_sueldo_neto.Enabled = false;
            txt_SFS.Enabled =false;

        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_sueldo_neto.Clear();
            txt_AFP.Clear();
            txt_SFS.Clear();
            txt_pago_hora.Clear();
            txt_Horas_Trabajadas.Clear();
        }
    }
}
