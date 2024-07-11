using CQRSAndMediatR_Implementation.Models;
using MediatR;

namespace CQRSAndMediatR_Implementation.Queries
{
    public class GetStudentByIdQuery : IRequest<StudentDetails>
    {
        public int Id { get; set; }
    }
}
