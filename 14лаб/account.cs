using System;
using System.Collections.Generic;
using System.Diagnostics;

public class account
{
    private decimal balance;
    private string number;
    private string type;
    public decimal Balance => balance;
    public string Number => number;
    public string Type => type;

    public account(decimal balance, string number, string type)
    {
        this.balance = balance;
        this.number = number;
        this.type = type;

    }
    public bool takemymoney(decimal a)
    {
        if (balance >= a && a >= 0)
        {
            balance -= a;
            return true;
        }
        return false;
    }
    public void givememoney(decimal a)
    {
        if (a >= 0)
        {
            balance += a;
        }
    }
    public void transfer(account acc, decimal a)
    {
        if (takemymoney(a))
        {
            acc.givememoney(a);
        }
    }
    public override int GetHashCode()
    {
        return number.GetHashCode();
    }
    public static bool operator ==(account a1, account a2)
    {
        if (ReferenceEquals(a1, null) && ReferenceEquals(a2, null))
        {
            return true;
        }

        if (ReferenceEquals(a1, null) || ReferenceEquals(a2, null))
        {
            return false;
        }

        return a1.Equals(a2);
    }
    public static bool operator !=(account a1, account a2)
    {
        return !(a1 == a2);
    }

    public override string ToString()
    {
        return $"номер счёта: {number}, тип счёта: {type}, баланс: {balance}";
    }
    [Conditional("DEBUG_ACCOUNT")]
    public void DumpToScreen()
    {
        Console.WriteLine("о банковском счёте: {0}", ToString());
    }
}
