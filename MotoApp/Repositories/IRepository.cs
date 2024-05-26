namespace MotoApp.Repositories   // - Poprawki Wpisy Nawiasu Klamrowego i usunięcie średnika
{  // - Poprawki Wpisy Nawiasu Klamrowego
    using MotoApp.Entities;

   public interface IRepository<T> : IReadRepository<T>, IWriteRepository<T>
   where T : class, IEntity, new()
   {
   }
}  // - Poprawki Wpisy Nawiasu Klamrowego