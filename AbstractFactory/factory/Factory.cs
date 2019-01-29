using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.ListFactory;

namespace AbstractFactory.factory
{
    public abstract class Factory
    {
        public static Factory GetFactory(string className)
        {
            Factory factory = null;
            try
            {
                var type = Type.GetType($"AbstractFactory.{className}.{className}");
                factory = (Factory)Activator.CreateInstance(type);
            }
            catch (Exception)
            {

                throw;
            }
            return factory;
        }

        public abstract Link CreateLink(string caption, string url);
        public abstract Tray CreateTray(string caption);
        public abstract Page CreatePage(string title, string author);
    }
}