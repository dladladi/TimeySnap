using System;

namespace TimeySnap.Models;

public class Model
{


    public string Validation(TimeOnly Time, DateOnly Date)
    {
        //List Periods
        TimeOnly MathsStart = new TimeOnly(10, 0, 0);
        TimeOnly MathsEnd = new TimeOnly(15, 0, 0);



        if (Time >= MathsStart && Time <= MathsEnd)
        {
            return "Mable_is_Cringe";
        }

        else return "Yuna";
    }

}
