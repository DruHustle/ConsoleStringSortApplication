using Autofac;
using ConsoleClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            
            builder.RegisterType<Execution>().As<IExecution>();
            builder.RegisterType<ReadInput>().As<IReadInput> ();
            builder.RegisterType<PrintOutput>().As<IPrintOutput>();
            builder.RegisterType<WorkSpace>().As<IWorkSpace>();
            builder.RegisterType<StringConstraint>().As<IStringConstraint>();
            builder.RegisterType<MapString>().As<IMapString>();
            builder.RegisterType<SortString>().As<ISortString>();
            builder.RegisterType<Validation>().As<IValidation>();
            builder.RegisterType<Application>().As<IApplication>();

            return builder.Build();
        }
    }
}
