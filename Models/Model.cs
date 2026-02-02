using System;

namespace TimeySnap.Models;

public class Model
{


    public string Validation(TimeOnly Time, DayOfWeek Date)
    {
        //List Periods
        TimeOnly MathsStart = new TimeOnly(10, 0, 0);
        TimeOnly MathsEnd = new TimeOnly(15, 0, 0);

        //List





        if (Date == DayOfWeek.Monday)
        {

            if (Time >= MathsStart && Time <= MathsEnd)
            {
                return "Maths";
            }

            else return "Yuna";

        }
        else
            return "smth msth";
    }

}
