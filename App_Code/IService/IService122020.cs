using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

public partial interface IService
{
    /// <summary>
    /// Sprawdza czy istnieje taki użykownik
    /// </summary>
    /// <param name="_userId">id użytkownika</param>
    /// <param name="_password">hasło uzytkownika</param>
    /// <param name="_deviceId">numer urządzenia</param>
    [OperationContract]
    ValidateUserResponse ValidateUser(string _userId,
                        string _password,
                        string _deviceId);

    /// <summary>
    /// Zwraca ostatnio dodany rekord 
    /// </summary>
    [OperationContract]
    TemperatureTable GetLastTemperatureRecord();

    //// <summary>
    ///// Zwraca rekordy z ostatniej godziny 
    ///// </summary>
    //[OperationContract]
    //TemperatureCollection GetHourTemperatures();

    //// <summary>
    ///// Zwraca rekordy z ostatniej doby 
    ///// </summary>
    //[OperationContract]
    //TemperatureCollection GetDailyTemperature();

    //// <summary>
    ///// Zwraca rekordy z ostatnich 3dni 
    ///// </summary>
    //[OperationContract]
    //TemperatureCollection GetThreeDaysTemperature();


    //// <summary>
    ///// Zwraca rekordy z ostatniego tygodnia 
    ///// </summary>
    //[OperationContract]
    //TemperatureCollection GetWeeklyTemperature();


    // <summary>
    /// Zwraca rekordy z ostatniego tygodnia 
    /// </summary>
    [OperationContract]
    TemperatureCollection GetMunuteTemperature();


    [OperationContract]
    TemperatureCollection GetTwoMunutesTemperature();

    [OperationContract]
    TemperatureCollection GetThreeMunutesTemperature();

    [OperationContract]
    TemperatureCollection GetFourMunutesTemperature();

    [OperationContract]
    TemperatureCollection GetFiveMunutesTemperature();


    [OperationContract]
    bool RegisterDevice(string _deviceID);
}

