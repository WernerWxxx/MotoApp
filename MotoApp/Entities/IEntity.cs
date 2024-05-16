using MotoApp.Repositories;

namespace MotoApp.Entities
{
    public interface IEntity
    {
        int Id { get; set; }
        double num { get; set; }
        //T Add(double num);
        //double num2 { get; set; }
    }
}