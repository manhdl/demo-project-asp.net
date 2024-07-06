using Domain.Entity;

namespace Application.Persistence
{
    public interface ILeaveTypeRepository : IGenericRepository<LeaveType>
    {
        Task<bool> IsLeaveTypeUniqueAsync(string name);
    }
}
