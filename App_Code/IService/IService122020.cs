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

    // <summary>
    /// Zwraca rekordy z ostatniej godziny 
    /// </summary>
    [OperationContract]
    TemperatureCollection GetHourTemperatures();

    // <summary>
    /// Zwraca rekordy z ostatniej doby 
    /// </summary> 
    [OperationContract]
    TemperatureCollection GetDailyTemperature();

    // <summary>
    /// Zwraca rekordy z ostatnich 3dni 
    /// </summary>
    [OperationContract]
    TemperatureCollection GetThreeDaysTemperature();


    // <summary>
    /// Zwraca rekordy z ostatniego tygodnia 
    /// </summary>
    [OperationContract]
    TemperatureCollection GetWeeklyTemperature();


    // <summary>
    /// Zwraca rekordy z ostatniej minuty
    /// </summary>
    [OperationContract]
    TemperatureCollection GetMunuteTemperature();


    // <summary>
    /// Zwraca rekordy z ostatnich 2 minut
    /// </summary>
    [OperationContract]
    TemperatureCollection GetTwoMunutesTemperature();


    // <summary>
    /// Zwraca rekordy z ostatnich 3 minut
    /// </summary>
    [OperationContract]
    TemperatureCollection GetThreeMunutesTemperature();

    // <summary>
    /// Zwraca rekordy z ostatnich 4 minut
    /// </summary>

    [OperationContract]
    TemperatureCollection GetFourMunutesTemperature();

    // <summary>
    /// Zwraca rekordy z ostatnich 5 minut
    /// </summary>

    [OperationContract]
    TemperatureCollection GetFiveMunutesTemperature();


    // <summary>
    /// Zwraca rekordy z wybranego przedziału czasowego
    /// </summary>
    [OperationContract]
    TemperatureCollection GetSpecyficTimeTemperature(DateTime _from , DateTime _to);
    
    /// <summary>
    /// Rejestruje urządzenie w bazie danych
    /// </summary>
    /// <param name="_deviceID"></param>
    /// <returns></returns>
    [OperationContract]
    bool RegisterDevice(string _deviceID);
}

