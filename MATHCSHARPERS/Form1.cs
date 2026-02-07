using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MATHCSHARPERS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Num_4_Click(object sender, EventArgs e)
        {

        }

        private void Num_3_Click(object sender, EventArgs e)
        {

        }

        private void Num_2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Num_1_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            //def variable for later use
            double Num_1, Num_2, Num_3, Num_4, Num_5;

            double.TryParse(textBox1.Text, out Num_1);
            double.TryParse(textBox2.Text, out Num_2);  
            double.TryParse(textBox3.Text, out Num_3);
            double.TryParse(textBox4.Text, out Num_4);  
            double.TryParse(textBox5.Text, out Num_5);

            //spam math sheet
            double Absolute , Absolute2 , Absolute3 , Absolute4 , Absolute5 ;

            Absolute = Math.Abs(Num_1); 
            Absolute2 = Math.Abs(Num_2);
            Absolute3 = Math.Abs(Num_3);
            Absolute4 = Math.Abs(Num_4);
            Absolute5 = Math.Abs(Num_5);

            double Sqrt, Sqrt2, Sqrt3, Sqrt4, Sqrt5;

            Sqrt = Math.Sqrt(Num_1);
            Sqrt2 = Math.Sqrt(Num_2);
            Sqrt3 = Math.Sqrt(Num_3);
            Sqrt4 = Math.Sqrt(Num_4);   
            Sqrt5 = Math.Sqrt(Num_5);

            double floor, floor2, floor3, floor4, floor5;

            floor = Math.Floor(Num_1);
            floor2 = Math.Floor(Num_2);
            floor3 = Math.Floor(Num_3);
            floor4 = Math.Floor(Num_4);
            floor5 = Math.Floor(Num_5);

            double Max ,  Max2 , Max3 , RealMax;

            double Min , Min2 , Min3 , RealMin;

            Max = Math.Max(Num_1, Num_2);
            Max2 = Math.Max(Max, Num_3);
            Max3 = Math.Max(Max2, Num_4);
            RealMax = Math.Max(Max3, Num_5);

            Min = Math.Min(Num_1 , Num_2);
            Min2 = Math.Min(Min, Num_3);
            Min3 = Math.Min(Min2 , Num_4);
            RealMin = Math.Min(Min3 , Num_5);


            label1.Text = ($"Absolute Value: {Absolute} , {Absolute2} , {Absolute3} , {Absolute4} , {Absolute5} \nSquare Roots: {Sqrt} , {Sqrt2} , {Sqrt3} , {Sqrt4} , {Sqrt5}\n" +
                $"Floor Values: {floor} , {floor2} , {floor3} , {floor4} , {floor5}\nMaximum Value:{RealMax}\nMinimum Value:{RealMin}").ToString();

        }

        private void Clear_Click(object sender, EventArgs e)
        {

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            label1.Text = ("");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
