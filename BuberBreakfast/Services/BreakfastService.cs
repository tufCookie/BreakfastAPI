using BuberBreakfast.Models;

namespace BuberBreakfast.Service;

public class BreakfastService : IBreakfastService{

    private readonly Dictionary<Guid, Breakfast> _breakfasts = new();
    public void CreateBreafast(Models.Breakfast breakfast){
        _breakfasts.Add(breakfast.Id, breakfast);
    }

    public Breakfast GetBreakfast(Guid id)
    {
        return _breakfasts[id];
    }
}