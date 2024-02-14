using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        //Создание изентификатор
        BankCount A = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Данны метод будет вызиван когда по
            //Алгоритм собираем данный из формы
            //создаем объект класса
            //Вызивай метод и резулат записываем в RichTextBox(tinfo)

            //1
            string name = tname.Text;
            double sum = Convert.ToDouble(tsum.Text);
            double prosent = Convert.ToDouble(tprosent.Value);
            int period = Convert.ToInt32(tperiod.Value);

            //2
            BankCount A = new BankCount(name, sum, prosent, period);
            //3
            tinfo.AppendText(A.getinfo());
        }

        private void tsum_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tinfo.Text = "";
        }
    }
}
