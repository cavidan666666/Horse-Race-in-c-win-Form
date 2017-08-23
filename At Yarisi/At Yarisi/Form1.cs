using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace At_Yarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //ilk olaraq soldan uzaqliqi tapmaq ucun deyisenleri teyin edirik
        int birinciSol, ikinciSol, ucuncuSol;
        //ikinci olaraq randomu teyin edirik
        Random random = new Random();

       

        private void Form1_Load(object sender, EventArgs e)
        {
            //Dorduncu Isimiz

            //birinci atin sol uzaqligini birnci picture box un sol uzaqliqina teyin edirik
            birinciSol = pictureBox1.Left;
            //ikinci atin sol uzaqligini ikinci picture box un sol uzaqliqina teyin edirik
            ikinciSol = pictureBox2.Left;
            //u acuncutin sol uzaqligini ucuncu picture box un sol uzaqliqina teyin edirik
            ucuncuSol = pictureBox3.Left;
                
        }

       

        private void BASLA_Click(object sender, EventArgs e)
        {
            //Ucuncu timer ise salmaq ucun true yaziriq
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //10 - cu isimiz vaxti ekrana gostermekdir

            int derece = Convert.ToInt32(label9.Text);
            derece++;
            label9.Text = derece.ToString();

            // 5 ci isimiz hansi atin qabagda oldugunu bilmek ucun onun genisligini tapiriq;
            int birinciatingenisligi = pictureBox1.Width;
            int ikinciatingenisligi = pictureBox2.Width;
            int ucuncuatingenisligi = pictureBox3.Width;

            //6-ci isimizde ati hereket etdirmek ucun (Random-dan Istifade Edirik)

            //7 - ci isimiz hansi at finise geldise o qazandi problemini hell etmek: bunun ucun bir deyisen teyin edib label 5 in leftine assign edirik

            int bitisuzaqligi = label5.Left;

            //birinciuzaqliqimizin sol terefine birinciuzaqliqimizin sol terefi + randomumuz.next(5,16 ne istiyirsn daxil ele)
             pictureBox1.Left = pictureBox1.Left + random.Next(5, 15);
            //ikinciuzaqliqimizin sol terefine ikinicuzaqliqimizin sol terefi + randomumuz.next(5,16 ne isdrsen daxil ele)
             pictureBox2.Left = pictureBox2.Left + random.Next(5, 15);
            //ucuncuuzaqliqimizin sol terefine ucuncuuzaqliqimizin sol terefi + randomumuz.next(5,16 ne isdrsen daxil ele)
             pictureBox3.Left = pictureBox3.Left + random.Next(5, 15);

            //9 - cu isimiz bize hal hazirdaki neticeni xeber vermek

            if(pictureBox1.Left>pictureBox2.Left + 5 && pictureBox1.Left > pictureBox3.Left + 5)
            {
                label8.Text = "Birinci At Ondedir";
            }

            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label8.Text = "Ikinci At Yaxi Kecid Eledi";
            }

            if (pictureBox3.Left > pictureBox2.Left + 5 && pictureBox3.Left > pictureBox2.Left + 5)
            {
                label8.Text = "Ucuncu At Hamsini Kecerek Lider Oldu";
            }

            // 8 - ci isimiz hansi atin qelebe qazandiqini gormek

            if (birinciatingenisligi + pictureBox1.Left >= bitisuzaqligi)
            {
                label7.Text = "Birinci At Yarisi Qazandi";
                timer1.Enabled = false;
            }
            if (ikinciatingenisligi + pictureBox2.Left >= bitisuzaqligi)
            {
                label7.Text = "Ikinci At Yarisi Qazandi";
                timer1.Enabled = false;
            }
            if(ucuncuatingenisligi + pictureBox3.Left  >= bitisuzaqligi)
            {
                label7.Text = "Ucuncu At Yarisi Kazandi";
                timer1.Enabled = false;
                MessageBox.Show("Oyun Bitdi");
            }

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

    }
}
