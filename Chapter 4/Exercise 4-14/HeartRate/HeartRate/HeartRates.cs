using System;

class HeartRates
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    private int birthYear;
    private int currentYear;
    private int maxHeartRate;
    private decimal minTargetRate;
    private decimal maxTargetRate;

    public HeartRates(string firstName, string lastName, int initialBirthYear, int initialCurrentYear)
    {
        FirstName = firstName;
        LastName = lastName;
        BirthYear = initialBirthYear;
        CurrentYear = initialCurrentYear;
        Age = initialCurrentYear - initialBirthYear;
        MaxHeartRate = Age;
        MinTargetRate = MaxHeartRate;
        MaxTargetRate = MaxHeartRate;

    }

    public int BirthYear
    {
        get
        {
            return birthYear;
        }

        set
        {
            if(value >= 1900)
            {
                birthYear = value;
            }
        }
    }

    public int CurrentYear
    {
        get
        {
            return currentYear;
        }

        set
        {
            if(value > 2000)
            {
                currentYear = value;
            }
        }
    }

    public int Age { get; set; }

    public int MaxHeartRate
    {
        get
        {
            return maxHeartRate;
        }

        set
        {
            maxHeartRate = 220 - value;
        }
    }

    public decimal MinTargetRate
    {
        get
        {
            return minTargetRate;
        }

        set
        {
            minTargetRate = value * .5m;
        }

    }

    public decimal MaxTargetRate
    {
        get
        {
            return maxTargetRate;
        }

        set
        {
            maxTargetRate = value * .85m;
        }
    }

}
