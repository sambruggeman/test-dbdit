using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc3;
using Microsoft.Practices.Unity.Configuration;
using System.Configuration;

namespace dbdit
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            //registered via Web.Config

            //container.RegisterType<IRepository<Institution>, RepositoryBase<Institution>>();
            //container.RegisterType<IRepository<Person>, RepositoryBase<Person>>();
            //container.RegisterType<IRepository<Employee>, RepositoryBase<Employee>>();

            //container.RegisterType<IPersonService, PersonService>();
            //container.RegisterType<IEmployeeService, EmployeeService>();
            //container.RegisterType<IInstitutionService, InstitutionService>();

            UnityConfigurationSection section = ConfigurationManager.GetSection("unity") as UnityConfigurationSection;
            section.Configure(container, "default");           

            return container;
        }
    }
}