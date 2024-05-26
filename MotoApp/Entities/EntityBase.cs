using MotoApp.Repositories;

namespace MotoApp.Entities
{
    public abstract class EntityBase : IEntity
    {
        public int Id { get; set; }
    }
}