using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PARTE1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string caracter = textBox1.Text.ToString();
            string valor = "";
            ChangeString change = new ChangeString();
            valor = change.build(caracter);

            MessageBox.Show(valor);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // int[] myValues = {58,60,55};
            int[] myValues = textBox2.Text.Split(',').Select(s => Int32.Parse(s)).ToArray();
            CompleteRange change = new CompleteRange();
            int[] resultado = change.build(myValues);

            string valor = "";
            for (int i = 1; i < resultado.Length; i ++)
                valor += resultado[i].ToString() + ",";

            MessageBox.Show(valor);
        }
    }
}
