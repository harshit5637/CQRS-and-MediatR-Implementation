using CQRSAndMediatR_Implementation.Models;
using MediatR;

namespace CQRSAndMediatR_Implementation.Queries
{
    
        public class GetStudentListQuery : IRequest<List<StudentDetails>>
        {
        }
    
}
