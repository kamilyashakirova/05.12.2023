using System;
using System.Reflection;
class Program
{
    static void Main(string[] args)
    {
        //упр 14.1. использование предопределенного условного атрибута для условного выполнения кода
        account a1 = new account(12233,"35567", "tecuschiy");
        account a2 = new account(132345,"3545346", "sberegatelnyi");
        a1.DumpToScreen();
        a2.DumpToScreen();
        //упр 14.2 Создать пользовательский атрибут DeveloperInfoAttribute.
        MemberInfo b = typeof(building);
        object[] ats = b.GetCustomAttributes(false);
        foreach (Attribute at in ats)
        {
            if (at is DeveloperInfoAttribute)
            {
                DeveloperInfoAttribute info = (DeveloperInfoAttribute)at;
                Console.WriteLine("{0}, {1}", info.name, info.date);
            }
        }
        MemberInfo a = typeof(building);
        object[] atts = a.GetCustomAttributes(false);
        foreach (Attribute att in atts)
        {
            if (att is BuildingInfo)
            {
                BuildingInfo info = (BuildingInfo)att;
                Console.WriteLine("{0}, {1}", info.name, info.orgname);
            }
        }
    }
}

