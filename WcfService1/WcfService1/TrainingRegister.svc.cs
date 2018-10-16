using System;
using WcfService1.CoursesSvc;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TrainingRegister" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TrainingRegister.svc or TrainingRegister.svc.cs at the Solution Explorer and start debugging.
    public class TrainingRegister : ITrainingsSchedule
    {
        public CourseDetailsResponse CourseDetails(CourseDetailsRequest request)
        {
            return new CourseDetailsResponse {
                id = request.id,
                userId = request.userId,
                client = request.client,
                service = request.service,
                protocolVersion = request.protocolVersion,
                Course = new Course
                {
                    date = DateTime.Now,
                    location = "Avatud Kool",
                    Id = "2",
                    Name = "Koolitus2"
                }
            };
        }

        public CoursesListResponse CoursesList(CoursesListRequest request)
        {
            return new CoursesListResponse
            {
                id = request.id,
                userId = request.userId,
                client = request.client,
                service = request.service,
                protocolVersion = request.protocolVersion,
                Courses = new[] {
                    new CourseShort{ Id = "1", Name = "Koolitus1" },
                    new CourseShort{ Id = "2", Name = "Koolitus2" },
                    new CourseShort{ Id = "3", Name = "Koolitus3" },
                    new CourseShort{ Id = "4", Name = "Koolitus4" }
                }
            };
        }

    }
}
