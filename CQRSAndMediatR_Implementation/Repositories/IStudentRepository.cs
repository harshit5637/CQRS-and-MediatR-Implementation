using CQRSAndMediatR_Implementation.Models;

namespace CQRSAndMediatR_Implementation.Repositories
{
    
     

        public interface IStudentRepository
        {
            public Task<List<StudentDetails>> GetStudentListAsync();
            Task<StudentDetails> GetStudentByIdAsync(int id);
            public Task<StudentDetails> AddStudentAsync(StudentDetails studentDetails);
            public Task<int> UpdateStudentAsync(StudentDetails studentDetails);
            public Task<int> DeleteStudentAsync(int Id);
        }
    
}
