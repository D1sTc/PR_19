using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void вычислитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newF = new Form2();
            newF.Show(); // открытие формы newF
        }

        private void Mach1(object sender, EventArgs e) // вычисление
        {
            try
            {
                double z; // z- итоговый ответ.
                double v1, v2, v3, v4, v5, v6, v7, v8, v9, v10; // ввод пошаговых действий

                double x = double.Parse(textBox_x.Text);
                double y = double.Parse(textBox_y.Text);

                v1 = Math.Pow(x, 2); // высчет степени 2 x-а
                v2 = Math.Log10(v1); // высчет десятичного логарифма со значением v1
                v3 = 2 * y;
                v4 = Math.Sin(v3); // высчет десятичного логарифма со значением v3
                v5 = Math.Exp(v4); // ввод константы + возводит эту константу в v4 степень
                v6 = v2 * v5;
                v7 = 3 * x;
                v8 = Math.Log10(v7);
                v9 = Math.Sqrt(y); // высчет корня y
                v10 = v8 + v9;

                z = v6 / v10; // главная дробь- после ответ
                z = Math.Round(z, 3, MidpointRounding.AwayFromZero); // округление

                textBox_3.Text = z.ToString();
            }

            catch (FormatException ex)
            {
                ex.ToString();
                MessageBox.Show("Проверьте правильность введения данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_x.Clear(); // очистка полей ввода значений
                textBox_y.Clear();
                textBox_3.Clear();
            }
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // очистка текстовых полей
            textBox_x.Clear();
            textBox_y.Clear();
            textBox_3.Clear();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox_x_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_y_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            Mach1(sender, e); // стр. 86
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void программаРасчётыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mach1(sender, e); // стр. 86
        }

        private void picture_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}