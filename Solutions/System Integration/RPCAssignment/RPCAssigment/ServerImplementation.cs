using System.Threading.Tasks;
using Grpc.Core;

namespace RPCAssignment
{
    class ServerImplementation : StudentService.StudentServiceBase
    {
        // Instance of the datamanager class to get the students.
        DataManager dataManager = new DataManager();

        // Implementing the method from the StudentRPC object.

        public override Task<StudentReply> GetStudents(StudentRequest request, ServerCallContext context)
        {
            return Task.FromResult(new StudentReply { Info = dataManager.GetStudents() });
        }
    }
}
