namespace ProductManagement.Application.Abstractions.DataAbstractions;

public interface IUnitOfWork
{
     ICategoryRepository Category { get; }
   

    Task StartTransactionAsync(CancellationToken cancellationToken);
    Task SubmitTransactionAsync(CancellationToken cancellationToken);
    Task RevertTransactionAsync(CancellationToken cancellationToken);
    Task SaveChangesAsync(CancellationToken cancellationToken);
}