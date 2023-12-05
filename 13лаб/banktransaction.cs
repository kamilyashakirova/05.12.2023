using System.Collections.Generic;
public class BankTransaction
{
    private List<decimal> transactions;

    public BankTransaction()
    {
        transactions = new List<decimal>();
    }
    public decimal this[int index]
    {
        get { return transactions[index]; }
    }
    public int cnt
    {
        get { return transactions.Count;}
    }
    public void add(decimal a)
    {
        transactions.Add(a);
    }
    public void remove(decimal a)
    {
        transactions.Remove(a);
    }
}
