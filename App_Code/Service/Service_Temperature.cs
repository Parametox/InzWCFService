using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Service_Temperature
/// </summary>
public partial class Service
{
    private TemperatureCollection GetMinutesTemperatureCollection(int minutes)
    {
        TemperatureCollection retCollection = new TemperatureCollection();
        TemperatureTable[] tt;

        using (InzDatabase db = new InzDatabase())
        {
            var date = DateTime.Now.AddMinutes(minutes);


            tt = db.TemperatureTables.Where(d => d.Date >= date).ToArray(); // LINQ

        }










        retCollection.TemperatureTables = tt;
        return retCollection;
    }

    private TemperatureCollection GetHourTemperatureCollection(int hours)
    {
        TemperatureCollection retCollection = new TemperatureCollection();
        TemperatureTable[] tt;

        using (InzDatabase db = new InzDatabase())
        {
            var date = DateTime.Now.AddHours(hours);
            tt = db.TemperatureTables.Where(d => d.Date >= date).ToArray();
        }

        retCollection.TemperatureTables = tt;
        return retCollection;
    }


    private TemperatureCollection GetDayTemperatureCollection(int days)
    {
        TemperatureCollection retCollection = new TemperatureCollection();
        TemperatureTable[] tt;

        using (InzDatabase db = new InzDatabase())
        {
            var date = DateTime.Now.AddDays(days);
            tt = db.TemperatureTables.Where(d => d.Date >= date).ToArray();
        }

        retCollection.TemperatureTables = tt;
        return retCollection;
    }

    public TemperatureCollection GetSpecyficTimeTemperature(DateTime _from, DateTime _to)
    {
        TemperatureCollection retCollection = new TemperatureCollection();
        TemperatureTable[] tt;

        using (InzDatabase db = new InzDatabase())
        {
            var from = _from;
            var to = _to;
            tt = db.TemperatureTables.Where(d => d.Date >= from
                                            && d.Date <= to).ToArray();
        }

        retCollection.TemperatureTables = tt;
        return retCollection;
    }

    public TemperatureTable GetLastTemperatureRecord()
    {
        TemperatureTable retTable = new TemperatureTable();

        using (InzDatabase db = new InzDatabase())
        {
            retTable = db.TemperatureTables.OrderByDescending(r => r.Id).FirstOrDefault();
        }

        return retTable;
    }

    public TemperatureCollection GetMunuteTemperature()
    {
        return GetMinutesTemperatureCollection(-1);
    }

    public TemperatureCollection GetTwoMunutesTemperature()
    {
        return GetMinutesTemperatureCollection(-2);

    }

    public TemperatureCollection GetThreeMunutesTemperature()
    {
        return GetMinutesTemperatureCollection(-3);

    }


    public TemperatureCollection GetFourMunutesTemperature()
    {
        return GetMinutesTemperatureCollection(-4);

    }

    public TemperatureCollection GetFiveMunutesTemperature()
    {
        return GetMinutesTemperatureCollection(-5);

    }

    public TemperatureCollection GetHourTemperatures()
    {
        return GetHourTemperatureCollection(-1);
    }

    public TemperatureCollection GetThreeDaysTemperature()
    {
        return GetDayTemperatureCollection(-3);

    }
    public TemperatureCollection GetWeeklyTemperature()
    {
        return GetDayTemperatureCollection(-7);

    }
    public TemperatureCollection GetDailyTemperature()
    {
        return GetDayTemperatureCollection(-1);
    }
}