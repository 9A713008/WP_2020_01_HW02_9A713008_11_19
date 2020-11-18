using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WP_2020_01_HW02_9A713008_11_19.Properties;


namespace WP_2020_01_HW02_9A713008_11_19
{
    public partial class Form1 : Form
    { 
        List<Image> list = new List<Image>();
        int times = 0;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btn1_Click(object sender, EventArgs e)
        {
            
            times++;
            rTB1.Text = " " + times + "次";
            if (times>52)
            {
                MessageBox.Show("MD還按");   
            }
            //GetPoker p = new GetPoker();
            //List<int> getpoker = p.Poker(52);

            //string msg = "";
            //for (int p = 0; p < getpoker.Count; p++)
            //{
            //    msg += $"{getpoker[i]} ,";
            //}
            //rTB1.Text = msg + "\n";
            Random a = new Random();//亂數種子
            int i = a.Next(0, 52);
            pB1.Image = list[i];
        }
        #region 生命週期
        
        private void Form1_Load(object sender, EventArgs e)
        {
            #region 撲克牌
            
            list.Add(Resources.P1);
            list.Add(Resources.P2);
            list.Add(Resources.P3);
            list.Add(Resources.P4);
            list.Add(Resources.P5);
            list.Add(Resources.P6);
            list.Add(Resources.P7);
            list.Add(Resources.P8);
            list.Add(Resources.P9);
            list.Add(Resources.P10);
            list.Add(Resources.P11);
            list.Add(Resources.P12);
            list.Add(Resources.P13);
            list.Add(Resources.P14);
            list.Add(Resources.P15);
            list.Add(Resources.P16);
            list.Add(Resources.P17);
            list.Add(Resources.P18);
            list.Add(Resources.P19);
            list.Add(Resources.P20);
            list.Add(Resources.P21);
            list.Add(Resources.P22);
            list.Add(Resources.P23);
            list.Add(Resources.P24);
            list.Add(Resources.P25);
            list.Add(Resources.P26);
            list.Add(Resources.P27);
            list.Add(Resources.P28);
            list.Add(Resources.P29);
            list.Add(Resources.P30);
            list.Add(Resources.P31);
            list.Add(Resources.P32);
            list.Add(Resources.P33);
            list.Add(Resources.P34);
            list.Add(Resources.P35);
            list.Add(Resources.P36);
            list.Add(Resources.P37);
            list.Add(Resources.P38);
            list.Add(Resources.P39);
            list.Add(Resources.P40);
            list.Add(Resources.P41);
            list.Add(Resources.P42);
            list.Add(Resources.P43);
            list.Add(Resources.P44);
            list.Add(Resources.P45);
            list.Add(Resources.P46);
            list.Add(Resources.P47);
            list.Add(Resources.P48);
            list.Add(Resources.P49);
            list.Add(Resources.P50);
            list.Add(Resources.P51);
            list.Add(Resources.P52);
            #endregion
           
        }
        private void Form1_Shown(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }


        #endregion

        private void btn2_Click(object sender, EventArgs e)
        {
            times = 0;
            rTB1.Text = " " + times + "次";
        }
    }
}
