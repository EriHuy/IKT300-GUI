using PS2000GUI;

namespace GUI
{


    public partial class Form1 : Form
    {
        /*
        private Class1 class1 = new Class1();
           
        public string voltage { get; set; }
        public string remoteControl { get; set; }
        public string serialNumberString { get; set; }
        public string articleNumber { get; set; }

        private string comport = "";
        */

        private IPSU psuInstance;
        public Form1()
        {
            InitializeComponent();
            psuInstance = PSUFactory.CreatePSU();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //display();
            psuInstance.comport = txtBoxComport.Text;
            txtBox_Volt.Text = psuInstance.GetVoltage().ToString();

        }

    }
}