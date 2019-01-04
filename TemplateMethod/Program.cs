using System;
using Framework;
using IDCard;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new IDCardFactory();
            Product card1 = factory.Create(1, "結城浩");
            Product card2 = factory.Create(2, "とむら");
            Product card3 = factory.Create(3, "佐藤花子");
            card1.Use();
            card2.Use();
            card3.Use();
        }
    }
}
