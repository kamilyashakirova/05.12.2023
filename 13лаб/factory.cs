using System;
using System.Collections.Generic;
public class factory
{
    private Dictionary<string, account> accs;

    public factory()
    {
        accs = new Dictionary<string, account>();
    }

    public string createAcc(decimal balance, string type)
    {
        string number = generate();
        account acc = new account(balance, number, type);
        accs.Add(number, acc);
        return number;
    }

    public void closeAcc(string number)
    {
        accs.Remove(number);
    }

    public account get(string number)
    {
        account ac;
        accs.TryGetValue(number, out ac);
        return ac;
    }

    private string generate()
    {
        Random random = new Random();
        return random.Next(1123434, 34332434).ToString();
    }
}