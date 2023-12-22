var date = new Date();
date.day=Convert.ToInt32(Console.ReadLine());
date.month=Convert.ToInt32(Console.ReadLine());
date.year=Convert.ToInt32(Console.ReadLine());

class Date
{
    private int day;
    private int month;
    private int year;

    public int Day { get{return day;} set{day=value;} }

    public int Month { get{return month;} set{day=value;} }

    public int Year { get{return year;} set{day=value;} }

    public Date()
    {
        
    }
    public Date(int a,int b)
    {
        Day=a;
        Month=b;
    }
    public Date(int a,int b,int c)
    {
        Day=a;
        Month=b;
        Year=c;
    }
    public string SetDate()
    {
        return $"{Day} {Month} {Year}";
    }
    public string GetDay()
    {
        return $"{Day}";
    }
    public string GetMonth()
    {
        return $"{Month}";
    }
    public string GetYear()
    {
        return $"{Year}";
    }
    public string ToString()
    {
        return $"{Day/10}{Day%10}/{Month/10}{Month%10}/{Year}";
    }
}