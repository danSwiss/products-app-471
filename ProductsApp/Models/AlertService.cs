using ProductsApp471.Interfaces;
using System;

namespace ProductsApp471.Models
{
    public class AlertService
    {
        private IAlertDAO _alertDAO;
        public AlertService(IAlertDAO _alertDAO)
        {
            this._alertDAO = _alertDAO;
        }

        private readonly AlertDAO storage = new AlertDAO();

        public Guid RaiseAlert()
        {
            return _alertDAO.AddAlert(DateTime.Now);
        }

        public DateTime GetAlertTime(Guid id)
        {
            return _alertDAO.GetAlert(id);
        }
    }
}