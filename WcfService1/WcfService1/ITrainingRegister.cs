using System.ServiceModel;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITrainingRegister" in both code and config file together.
    [ServiceContract]
    public interface ITrainingRegister : CoursesSvc.ITrainingsSchedule
    {
        [OperationContract]
        void DoWork();
    }
}
