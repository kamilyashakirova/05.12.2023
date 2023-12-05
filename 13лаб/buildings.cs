using System;
class buildings
{
    private building[] bs;

    public buildings()
    {
        bs = new building[10];
    }

    public building this[int number]
    {
        get
        {
            if (number < 0 || number >= bs.Length)
            {
                throw new IndexOutOfRangeException("ошибка");
            }
            return bs[number];
        }
        set
        {
            if (number < 0 || number >= bs.Length)
            {
                throw new IndexOutOfRangeException("ошибка");
            }
            bs[number] = value;
        }
    }
}

