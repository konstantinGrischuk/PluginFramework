using System;
using System.Drawing;
using System.Windows.Forms;
using testexListBox;

namespace PluginTest
{
    public partial class About : UserControl
    {
        private static About _instance;

        public static About Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new About();
                }

                return _instance;
            }
        }
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            foreach (var plugin in PluginFramework.PluginManager.Plugins)
            {
                var img = ResizeImage(plugin.GetIcon(), new Size(30, 30));
                exListBox1.Items.Add(new ExListBoxItem(0, plugin.Name, plugin.Version + " " + plugin.Description, img));
            }
        }
        public static Image ResizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

      
    }
}
