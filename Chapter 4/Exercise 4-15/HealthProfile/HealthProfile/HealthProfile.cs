using System;

class HealthProfile
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    private string gender;
    private int birthMonth;
    private int birthDay;
    private int birthYear;
    private int height;
    private int weight;
    private int currentYear;

    public HealthProfile(string firstName, string lastName, string gender,
        int birthMonth, int birthDay, int birthYear, int height, int weight)
    {
        currentYear = DateTime.Now.Year;
        FirstName = firstName;
        LastName = lastName;
        Gender = gender;
        BirthMonth = birthMonth;
        BirthDay = birthDay;
        BirthYear = birthYear;
        Height = height;
        Weight = weight;

    }

    public string Gender
    {
        get
        {
            return gender;
        }

        set
        {
            if (value == "M" || value == "m")
            {
                gender = value;
            }

            else if (value == "F" || value == "f")
            {
                gender = value;
            }
        }
    }

    public int BirthMonth
    {
        get
        {
            return birthMonth;
        }

        set
        {
            if (value > 0 && value <= 12)
            {
                birthMonth = value;
            }
        }

    }

    public int BirthDay
    {
        get
        {
            return birthDay;
        }

        set
        {
            if (value > 0 && value <= 31)
            {
                birthDay = value;
            }
        }

    }

    public int BirthYear
    {
        get
        {
            return birthYear;
        }

        set
        {
            if (value > 1900 && value < currentYear)
            {
                birthYear = value;
            }
            
        }
    }

    public int Height
    {
        get
        {
            return height;
        }

        set
        {
            if(value > 36 && value < 96)
            {
                height = value;
            }
        }
    }

    public int Weight
    {
        get
        {
            return weight;
        }

        set
        {
            if (value > 0 && value < 900)
            {
                weight = value;
            }
        }
    }

    public int getAge()
    {
        int age = currentYear - this.BirthYear;
        return age;
    }

    public int getMaxHeartRate()
    {
        return 220 - this.getAge();
    }

    public double getMinTargetRate()
    {
        return .5 * this.getMaxHeartRate();
    }

    public double getMaxTargetRate()
    {
        return .85 * this.getMaxHeartRate();
    }

    public double getBMI()
    {
        double BMI = (double)(Weight * 703) / (Math.Pow(height, 2));
        return BMI;
    }
        
}

