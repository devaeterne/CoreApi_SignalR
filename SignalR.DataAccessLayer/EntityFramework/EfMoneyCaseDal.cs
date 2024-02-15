using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfMoneyCaseDal
    {
        public interface IMoneyCaseDal : IGenericDal<MoneyCase>
        {
            decimal TotalMoneyCaseAmount();
        }
    }
}