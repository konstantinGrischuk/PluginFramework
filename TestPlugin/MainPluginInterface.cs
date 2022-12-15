using System;
using System.Windows.Forms;

namespace Plugin
{
    public partial class TestPlug2 : UserControl
    {
        private static TestPlug2 _instance;
        public TestPlug2 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TestPlug2();
                    return _instance;
                }
                else  
                 return _instance;
              
            }
        }
        public TestPlug2()
        {
            InitializeComponent();
        }



        private void MainPluginInterface_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("wwwwwwww");
        }
    }
}
