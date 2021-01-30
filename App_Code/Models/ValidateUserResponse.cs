using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Obiekt zwracany dla metody ValidateUser
/// </summary>
[DataContract]
public class ValidateUserResponse
{ 
    [DataMember]
    public bool IsValid { get; set; }

    [DataMember]
    public string DeviceId { get; set; }

    [DataMember]
    public string DeviceName { get; set; }

    [DataMember]
    public string UserId { get; set; }

    [DataMember]
    public string UserName { get; set; }

    [DataMember]
    public DateTime OperationTime { get; set; }

    public ValidateUserResponse()
    {
        this.OperationTime = DateTime.Now;
        this.CheckNulls();
    }

    /// <summary>
    /// zamienia nulle na pusty ciag znaków
    /// </summary>
    private void CheckNulls()
    {
        this.DeviceId   = String.IsNullOrWhiteSpace(this.DeviceId)      ? "" : this.DeviceId;
        this.DeviceName = String.IsNullOrWhiteSpace(this.DeviceName)    ? "" : this.DeviceName;
        this.UserId     = String.IsNullOrWhiteSpace(this.UserId)        ? "" : this.UserId;
        this.UserName   = String.IsNullOrWhiteSpace(this.UserName)      ? "" : this.UserName;
    }
}