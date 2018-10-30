using System;
using AutoMapper;
using CustomerManager.Core.Infrastructure;
using CustomerManager.Core.ViewModels;
using MvvmCross;
using MvvmCross.IoC;
using MvvmCross.ViewModels;

namespace CustomerManager.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            Mvx.IoCProvider.RegisterSingleton<IMapper>(MapperConfigurator.InitializeProfiles().CreateMapper());
            
            RegisterAppStart<CustomersListViewModel>();
        }
    }
}