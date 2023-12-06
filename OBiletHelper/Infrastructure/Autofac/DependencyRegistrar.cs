using Autofac;
using OBiletHelper.Interface;
using OBiletHelper.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBiletHelper.Infrastructure.Autofac
{
    public class DependencyRegistrar : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<BusJourneyService>().As<IBusJourneyService>();
            builder.RegisterType<BusLocationService>().As<IBusLocationService>();
            base.Load(builder);

        }
    }
}
