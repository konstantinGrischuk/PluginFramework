using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace PluginFramework
{
    public class PluginManager
    {
        static public List<IPlugin> Plugins = new List<IPlugin>();
        public static void Init(string startupPath)
        {
            string[] dir = Directory.GetFiles(startupPath);
            foreach (var path in dir)
            {
                if (Path.GetExtension(path) == ".dll")
                {

                    IPlugin plug = LoadPlugin(path);
                    if (plug != null)
                    {
                        Plugins.Add(plug);
                    }
                  
                }

            }
        }

        public static IPlugin LoadPlugin(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    var fl = File.ReadAllBytes(path);
                    Assembly Assembly = Assembly.Load(fl);
                    foreach (Type t in Assembly.GetTypes())
                    {
                        if ((t.IsClass) & (typeof(IPlugin).IsAssignableFrom(t)))
                        {

                            IPlugin pl = Activator.CreateInstance(t) as IPlugin;
                            if (pl != null)
                            {
                                return pl;
                            }
                            
                        }
                       
                    }
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }


    }
}