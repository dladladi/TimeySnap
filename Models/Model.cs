using System;

namespace TimeySnap.Models;

public class Model
{
    public string Validation(TimeOnly Time, DayOfWeek Date)
    {

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
          new[] {new TimeOnly(10,30,0), new TimeOnly(17, 30, 0), new TimeOnly(19, 0, 0), new TimeOnly(21, 0, 0) }, //Friday
        };


        int WhatDay = (int)Date == 0 ? 7 : (int)Date;

        switch (WhatDay)
        {
            case 1:

                for (int Period = 0; Period < Start[0].Length; Period++)
                {
                    if (Time >= Start[0][Period] && Time <= End[0][Period])
                    {
                        switch (Period)
                        {
                            case 0:
                                return "FPM";
                            case 1:
                                return "Physics";
                            case 2:
                                return "Chemistry";
                        }
                    }
                }
                break;
            case 2:

                for (int Period = 0; Period < Start[1].Length; Period++)
                {
                    if (Time >= Start[1][Period] && Time <= End[1][Period])
                    {
                        switch (Period)
                        {
                            case 0:
                                return "Maths-B";
                            case 1:
                                return "FPM";
                            case 2:
                                return "Chemistry";
                        }
                    }
                }
                break;
            case 3:

                for (int Period = 0; Period < Start[2].Length; Period++)
                {
                    if (Time >= Start[2][Period] && Time <= End[2][Period])
                    {
                        switch (Period)
                        {
                            case 0:
                                return "ICT";
                        }
                    }
                }
                break;

            case 4:

                for (int Period = 0; Period < Start[3].Length; Period++)
                {
                    if (Time >= Start[3][Period] && Time <= End[3][Period])
                    {
                        switch (Period)
                        {
                            case 0:
                                return "ICT";
                            case 1:
                                return "FPM";
                            case 2:
                                return "Language-B";
                        }
                    }
                }
                break;

            case 5:

                for (int Period = 0; Period < Start[4].Length; Period++)
                {
                    if (Time >= Start[4][Period] && Time <= End[4][Period])
                    {
                        switch (Period)
                        {
                            case 0:
                                return "Maths-B";
                            case 1:
                                return "Physics";
                            case 2:
                                return "FPMPastPaper";
                            case 3:
                                return "Language-B";
                        }
                    }
                }
                break;

            default:
                return "ERROR";

        }
        return "FreeTIME";
    }
}
