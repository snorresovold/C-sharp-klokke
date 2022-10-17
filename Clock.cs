class Clock
{
    public int second;
    public int minute;
    public int hour;

    public Clock()
    {
        second = 0;
        minute = 0;
        hour = 0;
    }

    public Clock(int clSecond, int clMinute, int clHour)
    {
        second = clSecond;
        minute = clMinute;
        hour = clHour;
    }

    public void setSecond(int newSecond)
    {
        if (newSecond > 60 || newSecond < 0)
        {
            throw new Exception("Dette er ikke en gyldig verdi for second.");
        }
        second = newSecond;
    }

    public int getSecond() => second;

    public void addSeconds(int amountSeconds)
    {
        second += 1;
        while (second > 59)
        {
            addMinutes(minute);
            second = 1;
        }
    }

    public void setMinute(int newMinute)
    {
        if (newMinute > 60 || newMinute < 0)
        {
            throw new Exception("Dette er ikke en gyldig verdi for minutt.");
        }
        minute = newMinute;
    }

    public int getMinute() => minute;
    
    public void addMinutes(int amountminutes)
    {
        minute += 1;
        while (minute > 59)
        {
            addHour(hour);
            minute = 0;
        }
    }

    public void setHour(int newHour)
    {
        if (newHour > 24 || newHour < 0)
        {
            throw new Exception("Dette er ikke en gyldig verdi for time.");
        }
        hour = newHour;
    }

    public int getHour() => hour;

    public void addHour(int amounthours)
    {
        hour += 1;
        while (hour > 23)
        {
            hour = 0;
        }
    }

    public void tick()
    {
        addSeconds(second);
    }

    private string numToString(int tall)
    {
        if (tall < 60)
        {
            return "" + tall;
        }
        return tall.ToString();
    }

    public string numToString()
    {
        return numToString(hour) + ":" + (minute) + ":" + (second);
    }
}