using Lms.CourseService.Domain.Interfaces;
using Lms.CourseService.Domain.Entities;
using Lms.CourseService.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Lms.CourseService.Infrastructure.Repositories;

public class ReviewRepository : IReviewRepository
{
    private readonly CourseDbContext _context;

    public ReviewRepository(CourseDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Review>> GetByCourseIdAsync(int courseId)
    {
        return await _context.Reviews
            .Where(r => r.CourseId == courseId)
            .ToListAsync();
    }

    public async Task<Review?> GetByIdAsync(int id)
    {
        return await _context.Reviews.FindAsync(id);
    }

    public async Task AddAsync(Review review)
    {
        await _context.Reviews.AddAsync(review);
    }

    public async Task UpdateAsync(Review review)
    {
        _context.Reviews.Update(review);
        await Task.CompletedTask;
    }

    public async Task DeleteAsync(Review review)
    {
        _context.Reviews.Remove(review);
        await Task.CompletedTask;
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
}