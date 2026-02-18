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
        TimeOnly[][] Start =
        {

          new[] {new TimeOnly(9,0,0), new TimeOnly(12, 0, 0), new TimeOnly(16, 0, 0)},  //Monday
          new[] {new TimeOnly(9,0,0), new TimeOnly(10, 30, 0), new TimeOnly(16, 0, 0)}, //Tuesday
          new[] {new TimeOnly(9,0,0) }, //Wednesday
          new[] {new TimeOnly(10,30,0), new TimeOnly(12, 30, 0), new TimeOnly(14, 0, 0)}, //Thursday
          new[] {new TimeOnly(9,0,0), new TimeOnly(16, 0, 0), new TimeOnly(17, 30, 0), new TimeOnly(19, 30, 0)}, //Friday
        };

        TimeOnly[][] End =
        {
          new[] {new TimeOnly(10,30,0), new TimeOnly(14, 0, 0), new TimeOnly(17, 30, 0)  }, //Monday
          new[] {new TimeOnly(10,30,0), new TimeOnly(12, 0, 0), new TimeOnly(17, 30, 0), }, //Tuesday
          new[] {new TimeOnly(10,30,0) }, //Wednesday
          new[] {new TimeOnly(12,0,0), new TimeOnly(14, 0, 0), new TimeOnly(15, 30, 0), }, //Thursday
          new[] {new TimeOnly(10,30,0), new TimeOnly(17, 30, 0), new TimeOnly(19, 0, 0), new TimeOnly(21, 0, 0) }, //Thursday
        };

        /*if (Date == DayOfWeek.Monday)
      {

          if (Time >= MathsStart && Time <= MathsEnd)
          {
              return "Maths";
          }

          else return "Yuna";

      }
      else
          return "smth msth";*/

        int WhatDay = (int)Date == 0 ? 7 : (int)Date;

        switch (WhatDay)
        {
            case 1:
                return "Monday";
            case 2:

                for (int Period = 0; Period < Start.GetLength(1); Period++)
                {
                    if (Time >= Start[1][Period] && Time <= End[1][Period])
                    {
                        if (Period == 0)
                        {
                            return "ji";
                        }

                        else if (Period == 1)
                        {
                            return "Maths-B";
                        }
                    }
                }
            default:
                return "ERROR";

        }
    }
}
