using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace kz_2_1
{
    public partial class Form1 : Form
    {
        public static class SuccesfulWork
        {
            public static ArrayList Resort_information;
            public static ArrayList Track_information;

            static SuccesfulWork()
            {
                Resort_information = SkiResort.GetselfArrayList();
                Track_information = Track_1.GetTrackInfo();
            }
        }

        public static class SucWor
        {
            public static ArrayList Array;
            public static ArrayList List;
            
            static SucWor()
            {
                Array = SkiResort.GetselfArrayList();
                List = Track_1.GetTrackInfo();

            }
        }
           

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            var ad = SuccesfulWork.Track_information

            .OfType<Track_1>()
            .Where(n => n.Track_id == "1" | n.Track_id.First() == n.Track_id.Last())
            .Select(n => n.AD.Average());

            foreach (var s in ad)
            {
                label1.Text += " " + s;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            var c = SuccesfulWork.Track_information
                .OfType<Track_1>()
                .Where(x => x.Track_id == textBox1.Text)
                .Select(x => x.HasSnowMachine);
            foreach (var f in c)
            {
                label2.Text += " " + Convert.ToString(f);
            }
                
        }

        private void label3_Click(object sender, EventArgs e)
        {
            var f = SuccesfulWork.Track_information
                .OfType<Track_1>()
                .Where(x => x.Track_id == "1")
                .Select(x => x.HasSnowMachine);

            bool[] bol = { };
            int sum = 0;

            foreach (bool g in  f)
            {
                sum += g ? 1 : 0;
                
            }
            if (sum == 0)
            {
                label3.Text += " " + "False";
            }
            else
            {
                label3.Text += " " + "True";
            }

        }
    }
}
