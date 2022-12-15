using Plugin;
using PluginFramework;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace PluginTest
{
    public partial class MainWindow : Form
    {
    
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PluginManager.Init(Application.StartupPath);

            foreach (var p in PluginManager.Plugins)
            {
                if (p.PlugType == PlugType.Window)
                {
                    var plug = p.GetMenuItem();

                    foreach (ToolStripMenuItem i in menuStrip1.Items)
                    {
                      
                        if (plug.Tag == null)
                        {
                            menuStrip1.Items.Add(plug);
                            break;
                        }
                        if (i.Text == plug.Tag.ToString())
                        {
                          
                            i.DropDownItems.Add(plug);
                            break;
                        }

                    }
                }
            }
        }

        private void ФайлToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            foreach(Control c in DisplayPanel.Controls)
            {
                c.Visible = false;
            }
            IPlugin v = PluginManager.Plugins.Find(x => x.GetMenuItem().Name == e.ClickedItem.Name);        
            var i = DisplayPanel.Controls.Find(v.MainInterface.Name, true);
            { 
                if (i.Length == 0)
                {               
                    DisplayPanel.Controls.Add(v.MainInterface);
                    v.MainInterface.Dock = DockStyle.Fill;
             
                    v.MainInterface.Visible = true;
                   
                }
                else
                { 
                    i[0].Dock = DockStyle.Fill;
                    i[0].Visible = true; 
                }
            }


        }

        private void ОПриложенииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayPanel.Controls.Clear();
            About a = new About();
            DisplayPanel.Controls.Add(a);
            a.Dock = DockStyle.Fill;
        }
    }
}
