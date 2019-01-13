using System;

namespace ProductsApp471.Interfaces
{
    public interface IAlertDAO
    {
        Guid AddAlert(DateTime time);
        DateTime GetAlert(Guid id);
    }
}
