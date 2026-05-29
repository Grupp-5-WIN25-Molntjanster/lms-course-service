using Lms.CourseService.Domain.Entities;

namespace Lms.CourseService.Domain.Interfaces;

public interface IReviewRepository
{
    Task<IEnumerable<Review>> GetByCourseIdAsync(int courseId);

    Task<Review?> GetByIdAsync(int id);

    Task AddAsync(Review review);

    Task UpdateAsync(Review review);

    Task DeleteAsync(Review review);

    Task SaveChangesAsync();
}