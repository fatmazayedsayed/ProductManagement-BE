using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProductManagement.Application.Abstractions.DataAbstractions;
using ProductManagement.Domain.Models;

namespace ProductManagement.Infrastructure;

public class ProductManagementUoW : IUnitOfWork
{
    private readonly ProductManagementDbContext _context;
    private readonly IConfiguration _Configuration; 
    public ICategoryRepository Category { get; }  

    public ProductManagementUoW(ProductManagementDbContext context,
          ICategoryRepository Category,
        
       IConfiguration _configuration )

    {
        _context = context;
         _Configuration = _configuration;
         
        Category = Category; 

         
    }



    public async Task StartTransactionAsync(CancellationToken cancellationToken)
    {
        await _context.Database.BeginTransactionAsync(cancellationToken);
    }

    public async Task SubmitTransactionAsync(CancellationToken cancellationToken)
    {
        await _context.Database.CommitTransactionAsync(cancellationToken);
    }
    public async Task SaveChangesAsync(CancellationToken cancellationToken)
    {
        //var userId = CurrentSessionProvider.GetUserId();
        //SetAuditableProperties(userId);

        //var auditEntries = HandleAuditingBeforeSaveChanges(userId).ToList();
        //if (auditEntries.Any())
        //{
        //    await _context.AuditTrails.AddRangeAsync(auditEntries, cancellationToken);
        //}

        //try
        //{
        //    await _context.SaveChangesAsync(cancellationToken);
        //}
        //catch (DbUpdateException ex)
        //{
        //    // Log the exception and inner exception details
        //    var innerException = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
        //    throw new Exception($"An error occurred while saving changes: {innerException}", ex);
        //}
    }
    public async Task RevertTransactionAsync(CancellationToken cancellationToken)
    {
        await _context.Database.RollbackTransactionAsync(cancellationToken);
    }
    private void SetAuditableProperties(Guid? userId)
    {
        foreach (var entry in _context.ChangeTracker.Entries<BaseModel>())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.InsertedDate = DateTime.UtcNow;
                    entry.Entity.InsertedBy = userId;
                    break;

                case EntityState.Modified:
                    entry.Entity.UpdatedDate = DateTime.UtcNow;
                    entry.Entity.UpdatedBy = userId;
                    break;
            }
        }
    }


}