using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Summary description for TemperatureCollection
/// </summary> 

[DataContract]
public class TemperatureCollection
{
    [DataMember]
    public TemperatureTable[]  TemperatureTables{ get; set; }

}