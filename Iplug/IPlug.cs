using System.Drawing;
using System.Windows.Forms;

namespace PluginFramework
{
    public enum PlugType
    {
        Window,                          //Плагин имеет окно
        Filter,							 //Плагин - фильтр 
    }


    public interface IPlugin
    {
        string Name { get; }             //Имя
        string Description { get; }      //Описание плагина
        string Author { get; }           //Автор
        string Version { get; }          //Версия
        PlugType PlugType { get; }       //Тип плагина
        ToolStripMenuItem GetMenuItem(); //Кнопка меню вызывающая плагин
        UserControl MainInterface { get; }//Окно плагина 

        Image GetIcon();
    }
}