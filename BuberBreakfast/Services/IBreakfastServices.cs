using BuberBreakfast.Models;

namespace BuberBreakfast.Service;

public interface IBreakfastService{
    void CreateBreafast(Breakfast request);

    Breakfast GetBreakfast(Guid id);
}