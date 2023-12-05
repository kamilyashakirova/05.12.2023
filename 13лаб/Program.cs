using System;
using System.Reflection;

public class Program
{
    public static void Main(string[] args)
    {   //упр 13.1. банковский счёт
        factory factory = new factory();
        string n1 = factory.createAcc(35567, "tecuschiy");
        string n2 = factory.createAcc(3545346, "sberegatelnyi");
        account a1 = factory.get(n1);
        account a2 = factory.get(n2);
        a1.givememoney(123242);
        a2.takemymoney(2433543);
        a1.transfer(a2, 32455);
        //упр 13.2. добавить индексатор в класс банковский счет для получения доступа к любому объекту BankTransaction.
        BankTransaction newtransaction = new BankTransaction();
        a2.transactions[0] = newtransaction;
        newtransaction.add(32455);
        Console.WriteLine(a1);
        Console.WriteLine(a2);
        if (a1 == a2)
        {
            Console.WriteLine("счета совпадают");
        }
        else
        {
            Console.WriteLine("счета не совпадают");
        }
        factory.closeAcc(n1);
        factory.closeAcc(n2);
        //дз 13.1. в классе здания все методы для заполнения и получения значений полей заменить на свойства.
        buildings collection = new buildings();
        building b1 = new building(123, 13, 34, 7);
        building b2 = new building(615, 24, 98, 6);
        Console.WriteLine("здание 1: номер - {0}, высота - {1}, этажи - {2}, квартиры - {3}, подъезды - {4}", b1.number, b1.height, b1.floors, b1.apartments, b1.entrances);
        Console.WriteLine("Building 2: номер - {0}, высота - {1}, этажи - {2}, квартиры - {3}, подъезды - {4}", b2.number, b2.height, b2.floors, b2.apartments, b2.entrances);
        //дз 13.2. создать класс для нескольких зданий.
        collection[0] = b1;
        collection[1] = b2;
    }
}