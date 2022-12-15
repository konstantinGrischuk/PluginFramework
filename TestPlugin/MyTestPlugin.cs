using PluginFramework;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Plugin
{
    [Serializable]
    public class MyTestPlugin : IPlugin
    {
        public Image GetIcon()
        {
            return Res.menu_icon;
        }
        public ToolStripMenuItem GetMenuItem()
        {
            ToolStripMenuItem plug = new ToolStripMenuItem("PluginButton2")
            {
                Tag = "Файл",
                Name = "PluginButton2",
                Image = Res.menu_icon
            };
            plug.Click += new EventHandler(this.Click);
            return plug;
        }

        private void Click(object sender, EventArgs e)
        {
         

        }

        public string Name => "Тестовый плагин2";

        public string Description => "Первый плагин созданый для теста фрэймворка";

        public string Author => "Грищук Констанитн Борисович";

        public string Version => "1.0.0.0";

        public UserControl MainInterface => new TestPlug2();

        public PlugType PlugType => PlugType.Window;

    }
}

