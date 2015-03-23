using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public sealed class ServiceFactory
    {
        public static void Configure()
        {
            Mapper.DynamicMap<Service.ISrvAgenda>(new Service.SrvAgenda());
        }
    }
}