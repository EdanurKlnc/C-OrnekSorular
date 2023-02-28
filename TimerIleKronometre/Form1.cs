namespace TimerIleKronometre
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

        //////////  KRONOMETRE ////////////777
        int salise = 0, dakika = 0, saniye = 0;

        private void button1_Click(object sender, EventArgs e)
        {

            timer.Enabled = true;
            // btnBasla.Text = "Durdur";

        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            dakika = 0;
            saniye = 0;
            salise = 0;
            timer.Enabled = false;
            txt.Text = dakika.ToString().PadLeft(2, '0') + ":" + saniye.ToString().PadLeft(2, '0') + ":" + salise.ToString().PadLeft(3, '0');
            btnBasla.Text = "Baþla";
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            btnBasla.Text = "Devam et";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {


            //PadLeft --> Sayýnýn kaç basamaklý yazýlacaðýna karar veririz
            txt.Text = dakika.ToString().PadLeft(2, '0') + ":" + saniye.ToString().PadLeft(2, '0') + ":" + salise.ToString().PadLeft(3, '0');
            if (salise == 60)
            {
                saniye++;
                salise = 0;
                if (saniye == 60)
                {
                    dakika++;
                    saniye = 0;
                    if (dakika == 60)
                    {
                        dakika = 0;
                    }
                }

            }
            salise++;
            /*
            //5 er artýrarak progressbarý ilerletiyoruz
            progressBar.Value = progressBar.Value + 5;
            label1.Text = progressBar.Value.ToString();
            if(progressBar.Value == 100)
            {
                Application.Exit();
            }*/
        }

        /////////////// GERÝ SAYIM //////////////////
        int geriSayimDakika = 0, geriSayimSaniye = 60;

        private void btnGeriSayimBaþla_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            dakika = Convert.ToInt32(txtGeriSayim.Text);

        }


        private void tmrGeriSayim_Tick(object sender, EventArgs e)
        {

            txtGeriSayimGösterge.Text = geriSayimDakika.ToString().PadLeft(2, '0') + ":" + geriSayimSaniye.ToString().PadLeft(2, '0') ;
            if (geriSayimSaniye == 0)
            {
                geriSayimDakika--;
                geriSayimSaniye= 60;
                if (geriSayimDakika == 0)
                {
                    geriSayimDakika--;
                    saniye = 0;
                    
                }

            }
            geriSayimDakika--;
            /*
            //5 er artýrarak progressbarý ilerletiyoruz
            progressBar.Value = progressBar.Value + 5;
            label1.Text = progressBar.Value.ToString();
            if(progressBar.Value == 100)
            {
                Application.Exit();
            }*/
        }
        /*
                int geriSayimDakika = 0, geriSayimSaniye = 60;

                private void btnGeriSayimBaþla_Click(object sender, EventArgs e)
                {
                    tmrGeriSayim.Start();
                    dakika = Convert.ToInt32(txtGeriSayim.Text);

                }


                private void tmrGeriSayim_Tick(object sender, EventArgs e)
                {
                    tmrGeriSayim.Interval = 1000;
                    saniye = saniye - 1;
                    lblSaniye.Text = geriSayimSaniye.ToString();
                    lblDakika.Text = (geriSayimDakika - 1).ToString();

                        if(geriSayimSaniye == 0)
                        {
                            geriSayimDakika = geriSayimDakika - 1;
                            lblDakika.Text = geriSayimDakika.ToString();
                        saniye = 60;

                        }

                }
        */
        private void progressBar_Click(object sender, EventArgs e)
        {

        }
    }
}