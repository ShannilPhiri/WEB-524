using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Assignment2.EntityModels;
using Assignment2.Models;

namespace Assignment2.Controllers
{
    public class Manager
    {
        // Reference to the data context
        private DataContext ds = new DataContext();

        // AutoMapper instance
        public IMapper mapper;

        public Manager()
        {
            // If necessary, add more constructor code here...

            // Configure the AutoMapper components
            var config = new MapperConfiguration(cfg =>
            {
                // Define the mappings below, for example...
                // cfg.CreateMap<SourceType, DestinationType>();
                // cfg.CreateMap<Employee, EmployeeBase>();
                //cfg.CreateMap<Employee, EmployeeAddViewModel>();
                cfg.CreateMap<Employee, EmployeeBaseViewModel>();
                cfg.CreateMap<EmployeeAddViewModel, Employee>();
                
               
            });

            
            
            mapper = config.CreateMapper();

            // Turn off the Entity Framework (EF) proxy creation features
            // We do NOT want the EF to track changes - we'll do that ourselves
            ds.Configuration.ProxyCreationEnabled = false;

            // Also, turn off lazy loading...
            // We want to retain control over fetching related objects
            ds.Configuration.LazyLoadingEnabled = false;
        }

        // Add methods below
        // Controllers will call these methods
        // Ensure that the methods accept and deliver ONLY view model objects and collections
        // The collection return type is almost always IEnumerable<T>

        // Suggested naming convention: Entity + task/action
        // For example:
        // ProductGetAll()
        public IEnumerable<EmployeeBaseViewModel> EmployeeGetAll()
        {
            //a list of new collections based on view model class
            var collection = new List< EmployeeBaseViewModel>();

            //fetchind the collection from the data store
            var allEmployees = ds.Employees;

            foreach (var employees in allEmployees)
            {

                //new collection based on view model class
                var e = new EmployeeBaseViewModel();


                //collection retrived from data store mapped into a
                //temp view model class
                e.Address = employees.Address;
                e.BirthDate = employees.BirthDate;
                e.City = employees.City;
                e.Country = employees.Country;
                e.Email = employees.Email;
                e.EmployeeId = employees.EmployeeId;
                e.Fax = employees.Fax;
                e.FirstName = employees.FirstName;
                e.HireDate = employees.HireDate;
                e.LastName = employees.LastName;
                e.Phone = employees.Phone;
                e.PostalCode = employees.PostalCode;
                e.State = employees.State;
                e.Title = employees.Title;

                //mapped data saved into list of collections
                collection.Add(e);

            }
           //returned new collection.
            return collection;

        }
        // ProductGetById()
        public EmployeeBaseViewModel EmployeeGetById(int id)
        {
            //fetch / find object in data store
            var obj = ds.Employees.Find(id);

            //if obj == null return null else return mapper of employee from
            //employeebaseviewmodel based on employee id
            return obj == null ? null : mapper.Map<Employee, EmployeeBaseViewModel>(obj);
        }
        // ProductAdd()

        public EmployeeBaseViewModel EmployeeAdd(EmployeeAddViewModel newEmployee)
        {

            //add new object                //map function , source        , destination, data
            var addnewItem = ds.Employees.Add(mapper.Map<EmployeeAddViewModel, Employee>(newEmployee));
            ds.SaveChanges();
            //returm mew object
            return addnewItem == null ? null : mapper.Map<Employee, EmployeeBaseViewModel>(addnewItem);
        }
        // ProductEdit()
        // ProductDelete()
    }
}