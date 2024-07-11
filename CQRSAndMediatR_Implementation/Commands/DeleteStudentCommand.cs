using MediatR;

namespace CQRSAndMediatR_Implementation.Commands
{
    public class DeleteStudentCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
