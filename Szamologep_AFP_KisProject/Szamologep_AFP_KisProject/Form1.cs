using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szamologep_AFP_KisProject
{
    public partial class Form1 : Form
    {
        //public double  HozzaAd(double elsoSzam, double masodikSzam)
        //{
        //    double seged = elsoSzam * 10;
        //    elsoSzam = seged + masodikSzam;
        //    Global.osszeg = elsoSzam;
        //    return Global.osszeg;
        //}
        public Form1()
        {
            InitializeComponent();  
        }

        double calculation;
        string option;
        double num1;
        double num2;
        

        private void btn1_Click(object sender, EventArgs e)
        {
            if (Global.TizedesVesszo == true)
            {
                Global.szamlalo++;
                double sSzam = 1;
                double seged = Global.tortresz * 10;
                Global.tortresz = sSzam + seged;
                //HozzaAd(Global.osszeg, sSzam);
            }
            else
            {
                double sSzam = 1;
                double seged = Global.osszeg * 10;
                Global.osszeg = sSzam + seged;
                //HozzaAd(Global.osszeg, sSzam);
            }
            Global.kiirt += "1";
            label_result.Text = Global.kiirt;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //2
            if (Global.TizedesVesszo == true)
            {
                Global.szamlalo++;
                double sSzam = 2;
                double seged = Global.tortresz * 10;
                Global.tortresz = sSzam + seged;
                //HozzaAd(Global.osszeg, sSzam);
            }
            else
            {
                double sSzam = 2;
                double seged = Global.osszeg * 10;
                Global.osszeg = sSzam + seged;
                //HozzaAd(Global.osszeg, sSzam);
            }
            Global.kiirt += "2";
            label_result.Text = Global.kiirt;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            //3
            if (Global.TizedesVesszo == true)
            {
                Global.szamlalo++;
                double sSzam = 3;
                double seged = Global.tortresz * 10;
                Global.tortresz = sSzam + seged;
                //HozzaAd(Global.osszeg, sSzam);
            }
            else
            {
                double sSzam = 3;
                double seged = Global.osszeg * 10;
                Global.osszeg = sSzam + seged;
                //HozzaAd(Global.osszeg, sSzam);
            }
            Global.kiirt += "3";
            label_result.Text = Global.kiirt;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            //4
            if (Global.TizedesVesszo == true)
            {
                Global.szamlalo++;
                double sSzam = 4;
                double seged = Global.tortresz * 10;
                Global.tortresz = sSzam + seged;
                //HozzaAd(Global.osszeg, sSzam);
            }
            else
            {
                double sSzam = 4;
                double seged = Global.osszeg * 10;
                Global.osszeg = sSzam + seged;
                //HozzaAd(Global.osszeg, sSzam);
            }
            Global.kiirt += "4";
            label_result.Text = Global.kiirt;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            //5
            
            if (Global.TizedesVesszo == true)
            {
                Global.szamlalo++;
                double sSzam = 5;
                double seged = Global.tortresz * 10;
                Global.tortresz = sSzam + seged;
                //HozzaAd(Global.osszeg, sSzam);
            }
            else
            {
                double sSzam = 5;
                double seged = Global.osszeg * 10;
                Global.osszeg = sSzam + seged;
                //HozzaAd(Global.osszeg, sSzam);
            }
            Global.kiirt += "5";
            label_result.Text = Global.kiirt;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            //6
            if (Global.TizedesVesszo == true)
            {
                Global.szamlalo++;
                double sSzam = 6;
                double seged = Global.tortresz * 10;
                Global.tortresz = sSzam + seged;
                //HozzaAd(Global.osszeg, sSzam);
            }
            else
            {
                double sSzam = 6;
                double seged = Global.osszeg * 10;
                Global.osszeg = sSzam + seged;
                //HozzaAd(Global.osszeg, sSzam);
            }
            Global.kiirt += "6";
            label_result.Text = Global.kiirt;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            //7
            if (Global.TizedesVesszo == true)
            {
                Global.szamlalo++;
                double sSzam = 7;
                double seged = Global.tortresz * 10;
                Global.tortresz = sSzam + seged;
                //HozzaAd(Global.osszeg, sSzam);
            }
            else
            {
                double sSzam = 7;
                double seged = Global.osszeg * 10;
                Global.osszeg = sSzam + seged;
                //HozzaAd(Global.osszeg, sSzam);
            }
            Global.kiirt += "7";
            label_result.Text = Global.kiirt;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            //8
            if (Global.TizedesVesszo == true)
            {
                Global.szamlalo++;
                double sSzam = 8;
                double seged = Global.tortresz * 10;
                Global.tortresz = sSzam + seged;
                //HozzaAd(Global.osszeg, sSzam);
            }
            else
            {
                double sSzam = 8;
                double seged = Global.osszeg * 10;
                Global.osszeg = sSzam + seged;
                //HozzaAd(Global.osszeg, sSzam);
            }
            Global.kiirt += "8";
            label_result.Text = Global.kiirt;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            //9
            if (Global.TizedesVesszo == true)
            {
                Global.szamlalo++;
                double sSzam = 9;
                double seged = Global.tortresz * 10;
                Global.tortresz = sSzam + seged;
                //HozzaAd(Global.osszeg, sSzam);
            }
            else
            {
                double sSzam = 9;
                double seged = Global.osszeg * 10;
                Global.osszeg = sSzam + seged;
                //HozzaAd(Global.osszeg, sSzam);
            }
            Global.kiirt += "9";
            label_result.Text = Global.kiirt;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            //0
            if (Global.TizedesVesszo == true)
            {
                Global.szamlalo++;
                double sSzam = 0;
                double seged = Global.tortresz * 10;
                Global.tortresz = sSzam + seged;
                //HozzaAd(Global.osszeg, sSzam);
            }
            else
            {
                double sSzam = 0;
                double seged = Global.osszeg * 10;
                Global.osszeg = sSzam + seged;
                //HozzaAd(Global.osszeg, sSzam);
            }
            Global.kiirt += "0";
            label_result.Text = Global.kiirt;
        }

        private void btn_dec_Click(object sender, EventArgs e)
        {
            Global.TizedesVesszo = true;
            Global.kiirt += ",";
            label_result.Text = Global.kiirt;
            //tizedesvessző    
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = Global.osszeg + (Global.tortresz * 10 / Math.Pow(10, 2));
            Global.osszeg = 0;
            Global.tortresz = 0;
            Global.TizedesVesszo = false;
            Global.kiirt += "/";
            label_result.Text = Global.kiirt;
            //osztás
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = Global.osszeg + (Global.tortresz * 10 / Math.Pow(10, 2));
            Global.osszeg = 0;
            Global.tortresz = 0;
            Global.TizedesVesszo = false;
            Global.kiirt += "*";
            label_result.Text = Global.kiirt;
            //szorzás
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = Global.osszeg + (Global.tortresz * 10 / Math.Pow(10, 2));
            Global.osszeg = 0;
            Global.tortresz = 0;
            Global.TizedesVesszo = false;
            Global.kiirt += "-";
            label_result.Text = Global.kiirt;
            //kivonás
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = Global.osszeg + (Global.tortresz * 10 / Math.Pow(10, 2));
            Global.osszeg = 0;
            Global.tortresz = 0;
            Global.TizedesVesszo = false;
            Global.kiirt += "+";
            label_result.Text = Global.kiirt;
            //összeadás
        }

        private void btn_res_Click(object sender, EventArgs e)
        {
            num2 = Global.osszeg + (Global.tortresz * 10 / Math.Pow(10, 2));

            if (option.Equals("+"))
                calculation = num1 + num2;
            else if (option.Equals("-"))
                calculation = num1 - num2;
            else if (option.Equals("/"))
                calculation = num1 / num2;
            else if (option.Equals("*"))
                calculation = num1 * num2;


            Global.tortresz = 0;
            Global.TizedesVesszo = false;
            Global.kiirt = Convert.ToString(calculation);
            label_result.Text = Global.kiirt;
            //num2 = calculation;

            //egyenlő
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Global.tortresz = 0;
            Global.osszeg = 0;
            Global.szamlalo = 0;
            Global.szamolasSegito = 0;
            Global.TizedesVesszo = false;
            Global.kiirt = "";
            label_result.Text = Global.kiirt;
            //grid ürítése
        }


        private void result_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label_result.Text = Global.kiirt;
        }
    }
}
