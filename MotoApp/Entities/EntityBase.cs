using MotoApp.Repositories;

namespace MotoApp.Entities
{
    public abstract class EntityBase : IEntity
    {
        public int Id { get; set; }
        public double num { get; set; }
        //T GetById(int id);
        //T Add(double num);
        public double num2 { get; set; }
    }
}