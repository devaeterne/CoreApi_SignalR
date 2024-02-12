using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfSocialMediaDal : GenericRepository<SocialMedia>, ISocialMedia
    {
        public EfSocialMediaDal(SignalRContext context) : base(context)
        {
        }
    }
}