using System;
using System.Windows.Forms;

namespace Plugin
{
    public partial class MainPluginInterface : UserControl
    {
        private static MainPluginInterface _instance;
        public MainPluginInterface Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MainPluginInterface();
                }

                return _instance;
            }
        }
        public MainPluginInterface()
        {
            InitializeComponent();
        }



        private void MainPluginInterface_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
