using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var channel = new CourseRegisterReference.TrainingsScheduleClient();

            var client = new CourseRegisterReference.XRoadClientIdentifierType {
                objectType = CourseRegisterReference.XRoadObjectType.SUBSYSTEM,
                xRoadInstance = "ee-dev",
                memberClass = "COM",
                memberCode = "11333578",
                subsystemCode = "DEVTRAINING_09_B"
            };

            var service = new CourseRegisterReference.XRoadServiceIdentifierType
            {
                objectType = CourseRegisterReference.XRoadObjectType.SERVICE,
                xRoadInstance = "ee-dev",
                memberClass = "COM",
                memberCode = "11333578",
                subsystemCode = "DEVTRAINING_09_A",
                serviceCode = "CoursesList",
                serviceVersion = "v1"
            };

            String id = new Guid().ToString();
            String protocolversion = "4.0";
            String userId = "EE37799899";
            var response = channel.CoursesList(
                ref client,
                ref service,
                ref userId,
                ref id,
                ref protocolversion,
                "Nimi parameeter",
                DateTime.Now
            );

            foreach (var item in response)
                Console.WriteLine(string.Format("Id: {0}\tName: {1}", item.Id, item.Name));

            Console.ReadKey();
        }
    }
}
