namespace Capstone
{
    public partial class Form1 : Form
    {
       
        Boolean isCollapsed1, isCollapsed3 = true;
        Boolean isCollapsed2 = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dropBtnProducts_Click(object sender, EventArgs e)
        {
            isCollapsed1 = true;
            isCollapsed3 = false;
            isCollapsed2 = false;
            timerDrpBtnSales.Start();
            timerDrpBtnPayment.Start();
            timerDrpBtnProducts.Start();
        }

        private void timerDrpBtnPayment_Tick(object sender, EventArgs e)
        {
            if (isCollapsed2)
            {
                dropBtnPayment.Image = Properties.Resources.Down_Arrow;
                dropPanelPayment.Height += 10;
                if (dropPanelPayment.Size == dropPanelPayment.MaximumSize)
                {
                    timerDrpBtnPayment.Stop();
                    isCollapsed2 = false;
                }
            }
            else
            {
                dropBtnPayment.Image = Properties.Resources.payment;
                dropPanelPayment.Height -= 10;
                if (dropPanelPayment.Size == dropPanelPayment.MinimumSize)
                {
                    timerDrpBtnPayment.Stop();
                    isCollapsed2 = true;
                }
            }
        }

        private void dropBtnPayment_Click(object sender, EventArgs e)
        {
            isCollapsed2 = true;
            isCollapsed3 = false;
            isCollapsed1 = false;
            timerDrpBtnPayment.Start();
            timerDrpBtnSales.Start();
            timerDrpBtnProducts.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dropPanelPayment.Size = dropPanelPayment.MinimumSize;
            dropPanelProducts.Size = dropPanelProducts.MinimumSize;
            dropPanelSales.Size = dropPanelSales.MinimumSize;
        }

        private void timerDrpBtnSales_Tick(object sender, EventArgs e)
        {
            if (isCollapsed3)
            {
                dropBtnSales.Image = Properties.Resources.Down_Arrow;
                dropPanelSales.Height += 10;
                if (dropPanelSales.Size == dropPanelSales.MaximumSize)
                {
                    timerDrpBtnSales.Stop();
                    isCollapsed3 = false;
                }
            }
            else
            {
                dropBtnSales.Image = Properties.Resources.Sales_Report;
                dropPanelSales.Height -= 10;
                if (dropPanelSales.Size == dropPanelSales.MinimumSize)
                {
                    timerDrpBtnSales.Stop();
                    isCollapsed3 = true;
                }
            }
        }

        private void dropBtnSales_Click(object sender, EventArgs e)
        {
            isCollapsed3 = true;
            isCollapsed1 = false;
            isCollapsed2 = false;
            timerDrpBtnSales.Start();
            timerDrpBtnPayment.Start();
            timerDrpBtnProducts.Start();

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void timerDrpBtnProducts_Tick(object sender, EventArgs e)
        {
            if (isCollapsed1)
            {
                dropBtnProducts.Image = Properties.Resources.Down_Arrow;
                dropPanelProducts.Height += 10;
                if (dropPanelProducts.Size == dropPanelProducts.MaximumSize)
                {
                    timerDrpBtnProducts.Stop();
                    isCollapsed1 = false;
                }
            }
            else
            {
                dropBtnProducts.Image = Properties.Resources.ProdItemServ;
                dropPanelProducts.Height -= 10;
                if (dropPanelProducts.Size == dropPanelProducts.MinimumSize)
                {
                    timerDrpBtnProducts.Stop();
                    isCollapsed1 = true;
                }
            }

        }


    }
}