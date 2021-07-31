using PluginFramework;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Plugin
{
    public class MyTestPlugin : IPlugin
    {
        public Image GetIcon()
        {
            return Res.menu_icon;
        }
        public ToolStripMenuItem GetMenuItem()
        {
            ToolStripMenuItem plug = new ToolStripMenuItem("PluginButton");
            plug.Tag = "Файл";
            plug.Name = "PluginButton";
            plug.Image = Res.menu_icon;
            plug.Click += new System.EventHandler(this.click);
            return plug;
        }

        private void click(object sender, EventArgs e)
        {
            //   MessageBox.Show("Click");

        }

        public string Name => "Тестовый плагин";

        public string Description => "Первый плагин созданый для теста фрэймворка";

        public string Author => "Грищук Констанитн Борисович";

        public string Version => "1.0.0.0";

        public UserControl MainInterface => new MainPluginInterface();

        public PlugType PlugType => PlugType.Window;

    }
}

