class building
{
    private static int lastnumber;
    private int n;
    private int h;
    private int f;
    private int aps;
    private int entrs;

    public building(int height, int floors, int apartments, int entrances)
    {
            n = generate();
            h = height;
            f = floors;
            aps = apartments;
            entrs = entrances;
    }

    public int number
    {
        get { return n; }
    }

    public int height
    {
        get { return h; }
        set { h = value; }
    }

    public int floors
    {
        get { return f; }
        set { floors = value; }
    }

    public int apartments
    {
        get { return aps; }
        set { aps = value; }
    }

    public int entrances
    {
        get { return entrs; }
        set { entrs = value; }
    }

    private static int generate()
    {
            lastnumber++;
            return lastnumber;
    }

}

