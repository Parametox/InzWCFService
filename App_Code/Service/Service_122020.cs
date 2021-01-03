using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public partial class Service
{
    public ValidateUserResponse ValidateUser(string _userId,
                        string _password,
                        string _deviceId)
    {
        ValidateUserResponse retVal = new ValidateUserResponse();

        string userID = String.IsNullOrWhiteSpace(_userId) ? "" : _userId;
        string password = String.IsNullOrWhiteSpace(_password) ? "" : _password;
        string deviceID = String.IsNullOrWhiteSpace(_deviceId) ? "" : _deviceId;

        retVal.UserId = userID;
        retVal.DeviceId = deviceID;

        if (String.IsNullOrEmpty(deviceID))
        {
            retVal.IsValid = false;
            return retVal;
        }

        using (InzDatabase db = new InzDatabase())
        {
            if (db.DeviceTables.Any(d => d.DeviceId == deviceID))
            {
                retVal.DeviceName = db.DeviceTables.Where(id => id.DeviceId == deviceID).FirstOrDefault().Name;
            }
            if (db.UserTables.Any(id => id.UserId == _userId && id.Password == password))
            {
                var tmpUser = db.UserTables.Where(id => id.UserId == _userId && id.Password == password).FirstOrDefault();
                retVal.UserName = String.Format("{0} {1}", tmpUser.Name, tmpUser.FirstName);
            }
            if (db.DeviceTables.Any(d => d.DeviceId == deviceID)
                && db.UserTables.Any(id => id.UserId == _userId && id.Password == password))
            {
                retVal.IsValid = true;
            }
        }

        return retVal;
    }


    public bool RegisterDevice(string _deviceID)
    {
        string deviceId = _deviceID == null ? "" : _deviceID;
        try
        {
            using (InzDatabase db = new InzDatabase())
            {
                if (db.DeviceTables.Any(x => x.DeviceId == deviceId))
                {
                    throw new Exception(String.Format("Istnieje identyczny wpis dla DeviceID = {0}",deviceId));
                }

                DeviceTable dt = new DeviceTable();
                dt.DeviceId = deviceId;
                dt.Name = null;
                db.DeviceTables.Add(dt);
                db.SaveChanges();
            }
        }
        catch (Exception ex)
        {
            return false;
        }
        return true;
    }


}