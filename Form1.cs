//Условие: разработать алгоритм и программу обработки одномерных массивов, используя единственный цикл
/* Условие: Задача 1.4.1 При заданных элементах массива X найти по формуле Yk = Sqr(1.5 - cosXk) значения элементов массива Y*/

//Condition: develop an algorithm and a program for processing one-dimensional arrays using a single loop
/* Condition: Task 1.4.1 Given the elements of the array X, find the values of the elements of the array Y using the formula Yk = Sqr(1.5 - cosXk) */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23_variant_CSharp_1_4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double ArrayCalc(int x)
        {
            double Y = 0;                                            //результат функциии
            Y = Math.Sqrt(1 - Math.Cos(x * Math.PI / 180));                          //переводим с градусов в радианы и вычисляем функцию
            return Y;
        }
        private void labelInputEl_Click(object sender, EventArgs e)
        {

        }
        private void buttonInputEl_Click(object sender, EventArgs e)
        {
            string[] param = textBoxInputEl.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int n = param.Length;
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(param[i]);
            }
            double[,] tableXY = new double[2, n];
            dataGridView1.RowCount = 2;                             //кол-во строк
            dataGridView1.ColumnCount = n;                          //столбцов
            dataGridView1.Rows[0].HeaderCell.Value = "Массив X: ";
            dataGridView1.Rows[1].HeaderCell.Value = "Массив Y: ";

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 2; j++)                                         //заполняем значения X
                {
                    if (j == 0)                                                     //для X
                    {
                        tableXY[j, i] = arr[i];
                        dataGridView1.Rows[j].Cells[i].Value = tableXY[j, i];
                    }                                                                //для Y
                    if (j == 1)
                    {
                        tableXY[j, i] = ArrayCalc(arr[i]);                            //передаем методу ArrCalc эл. Х;
                        dataGridView1.Rows[j].Cells[i].Value = tableXY[j, i].ToString("0.####");
                    }

                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}