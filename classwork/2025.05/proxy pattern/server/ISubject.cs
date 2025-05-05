using System.ServiceModel;

[ServiceContract]
interface ISubject {
    [OperationContract]
    void Say(string input);
}