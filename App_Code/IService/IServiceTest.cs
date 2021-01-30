using System.ServiceModel;

public partial interface IService
{
    [OperationContract]
    string TestConnection(bool _dummy);
} 