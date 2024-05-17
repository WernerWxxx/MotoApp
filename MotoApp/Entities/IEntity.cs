using MotoApp.Repositories;

namespace MotoApp.Entities
{
    public interface IEntity
    {
        int Id { get; set; }
        double zmiennaWalutiMetali { get; set; }

    }
}