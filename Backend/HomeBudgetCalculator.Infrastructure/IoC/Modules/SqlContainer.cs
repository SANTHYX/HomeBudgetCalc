﻿using Autofac;
using HomeBudgetCalculator.Infrastructure.EntityFramework.Interfaces;
using System.Reflection;

namespace HomeBudgetCalculator.Infrastructure.IoC.Modules
{
    public class SqlContainer : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var assembly = typeof(SqlContainer).GetTypeInfo().Assembly;

            builder.RegisterAssemblyTypes(assembly).Where(x => x.IsAssignableTo<ISqlRepository>())
                .AsImplementedInterfaces().InstancePerLifetimeScope();
        }
    }
}
