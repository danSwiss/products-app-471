using ProductsApp471.Interfaces;
using System;
using System.Collections.Generic;

namespace ProductsApp471.Models
{
    public class AlertDAO : IAlertDAO
    {
        private readonly Dictionary<Guid, DateTime> alerts = new Dictionary<Guid, DateTime>();

        public Guid AddAlert(DateTime time)
        {
            Guid id = Guid.NewGuid();
            alerts.Add(id, time);
            return id;
        }

        public DateTime GetAlert(Guid id)
        {
            return alerts[id];
        }
    }

}