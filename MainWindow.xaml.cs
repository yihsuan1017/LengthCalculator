﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LengthCalculator
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

        }
        // 全域變數
        string strInput; // 字串型態的strInput變數
        double douOutput; // double浮點數型態的douOutput變數

        // 設計一個單位轉換計算的函式，沒有回傳值，設計兩個參數，1.類別參數、2.數值參數
        private void caculateAnswer(int _kind, double _value)
        {
            if (_kind != 0)
                txtCM.Text = string.Format("{0:0.##########}", _value);
            if (_kind != 1)
                txtM.Text = string.Format("{0:0.##########}", _value / 100);
            if (_kind != 2)
                txtKM.Text = string.Format("{0:0.##########}", _value / 100000);
            if (_kind != 3)
                txtIn.Text = string.Format("{0:0.##########}", _value / 2.54);
            if (_kind != 4)
                txtFt.Text = string.Format("{0:0.##########}", _value / 30.48);
            if (_kind != 5)
                txtYard.Text = string.Format("{0:0.##########}", _value / 91.44);
        }

        private void txtCM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtCM.Text; // 將txtCM文字框的值放入strInput變數

            // 判斷式，如果能夠以double.TryParse成功轉型，那才做數值的計算
            if (double.TryParse(strInput, out douOutput) == true)
            {
                //txtM.Text = string.Format("{0:0.##########}", douOutput / 100);
                //txtKM.Text = string.Format("{0:0.##########}", douOutput / 100000);
                //txtIn.Text = string.Format("{0:0.##########}", douOutput / 2.54);
                //txtFt.Text = string.Format("{0:0.##########}", douOutput / 30.48);
                //txtYard.Text = string.Format("{0:0.##########}", douOutput / 91.44);
                caculateAnswer(0, douOutput);
            }
            else
            {
                // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtCM文字框清除
                txtInfo.Text = "請輸入數字";
                txtCM.Text = "";
            }
        }

        private void txtM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtM.Text; 

            if (double.TryParse(strInput, out douOutput) == true)
            {
                //txtCM.Text = string.Format("{0:0.##########}", douOutput * 100);
               //txtKM.Text = string.Format("{0:0.##########}", douOutput * 0.001);
                //txtIn.Text = string.Format("{0:0.##########}", douOutput * 39.37);
                //txtFt.Text = string.Format("{0:0.##########}", douOutput * 3.28);
                //txtYard.Text = string.Format("{0:0.##########}", douOutput * 1.09);
                caculateAnswer(1, douOutput);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtM.Text = "";
            }
        }

        private void txtKM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtKM.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
               // txtCM.Text = string.Format("{0:0.##########}", douOutput * 100);
               // txtM.Text = string.Format("{0:0.##########}", douOutput * 1000);
                //txtIn.Text = string.Format("{0:0.##########}", douOutput * 39370.1);
                //txtFt.Text = string.Format("{0:0.##########}", douOutput * 3280.84);
                //txtYard.Text = string.Format("{0:0.##########}", douOutput * 1093.61);
                caculateAnswer(2, douOutput);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtKM.Text = "";
            }
        }

        private void txtIn_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtIn.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
               // txtCM.Text = string.Format("{0:0.##########}", douOutput * 2.54);
                //txtM.Text = string.Format("{0:0.##########}", douOutput * 0.0254);
                //txtKM.Text = string.Format("{0:0.##########}", douOutput * 0.0000254);
                //txtFt.Text = string.Format("{0:0.##########}", douOutput * 0.0833);
               // txtYard.Text = string.Format("{0:0.##########}", douOutput * 0.0278);
                caculateAnswer(3, douOutput);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtIn.Text = "";
            }
        }

        private void txtFt_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtFt.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                //txtCM.Text = string.Format("{0:0.##########}", douOutput * 30.48);
               // txtM.Text = string.Format("{0:0.##########}", douOutput * 0.3048);
                //txtKM.Text = string.Format("{0:0.##########}", douOutput * 0.0003048);
               // txtIn.Text = string.Format("{0:0.##########}", douOutput * 12);
               // txtYard.Text = string.Format("{0:0.##########}", douOutput * 0.3333);
                caculateAnswer(4, douOutput);



            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtFt.Text = "";
            }
        }

        private void txtYard_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtYard.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                //txtCM.Text = string.Format("{0:0.##########}", douOutput * 91.44);
                //txtM.Text = string.Format("{0:0.##########}", douOutput * 0.9144);
               // txtKM.Text = string.Format("{0:0.##########}", douOutput * 0.0009144);
               // txtIn.Text = string.Format("{0:0.##########}", douOutput * 36);
               // txtFt.Text = string.Format("{0:0.##########}", douOutput * 3);
                caculateAnswer(5, douOutput);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtYard.Text = "";
            }
        }

        private void btnAllClea_Click(object sender, RoutedEventArgs e)
        {
            txtCM.Text = "";
            txtM.Text = "";
            txtKM.Text = "";
            txtIn.Text = "";
            txtFt.Text = "";
            txtYard.Text = "";
        }
    }
    
}
