
using ServiceCustomers.DataContracts;
using ServiceCustomers.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Contexts;
using static Mono.Security.X509.X520;

namespace ServiceCustomers.dbContexts
{
    public class CustomerDBContext : DbContext
    {
        public CustomerDBContext() : base(nameOrConnectionString: "PostgresqlDBContext") {
            this.Database.CreateIfNotExists();
            //Database.SetInitializer(new CustomerDBInitializer());
        }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Customer>().HasKey(u => new
            {
                u.Id,
                u.Creditnumber
            });
        }
        public Boolean removeCustomer(int creditnumber)
        {
            using (var context = new CustomerDBContext())
            {
                Customer customer = context.Customers.ToList<Customer>().Where(x => x.Creditnumber == creditnumber).FirstOrDefault();
                context.Customers.Remove(customer);
                context.SaveChanges();
                return true;
            }
        }

        public CustomerDC addCustomer(string name, DateTime dueDate, double amount, int creditnumber, long phonenbr, string template)
        {
            Customer customer = new Customer(name, dueDate, amount, creditnumber, phonenbr, template);
            using (var context = new CustomerDBContext())
            {
                context.Customers.Add(customer);
                context.SaveChanges();
            }
            CustomerDC customerDC = new CustomerDC();
            customerDC.amount = customer.amount;
            customerDC.dueDate = customer.dueDate;
            customerDC.Name = customer.Name;
            customerDC.Creditnumber = customer.Creditnumber;

            return customerDC;
        }

        public CustomerDC getCustomer(Int32? creditnumber)
        {
            using (var context = new CustomerDBContext())
            {
                Customer customer = context.Customers.ToList<Customer>().Where(x => x.Creditnumber == creditnumber).FirstOrDefault();
                CustomerDC customerDC = new CustomerDC();
                customerDC.amount = customer.amount;
                customerDC.dueDate = customer.dueDate;
                customerDC.Name = customer.Name;
                customerDC.Creditnumber = customer.Creditnumber;
                return customerDC;
            }
        }

        public CustomerDC editCustomer(int creditnumber, string template)
        {
            using (var context = new CustomerDBContext())
            {
                Customer customer = context.Customers.ToList<Customer>().Where(x => x.Creditnumber == creditnumber).FirstOrDefault();
                context.Customers.Remove(customer);
                context.SaveChanges();
                customer.template= template;
                context.Customers.Add(customer);
                context.SaveChanges();

                CustomerDC customerDC = new CustomerDC();
                customerDC.amount = customer.amount;
                customerDC.dueDate = customer.dueDate;
                customerDC.Name = customer.Name;
                customerDC.template = customer.template;
                customerDC.Creditnumber = customer.Creditnumber;
                return customerDC;
            }
        }

        public void init ()
        {
            //Database.SetInitializer(new CustomerDBInitializer());
            using (var cntxt = new CustomerDBContext())
            {
                cntxt.Customers.Add(new Customer("customer1", (DateTime.Now), 147.456, 142546, 004917654789654, ""));
                cntxt.SaveChanges();
                cntxt.Customers.Add(new Customer("customer2", (DateTime.Now), 4568.478, 123, 004917654789654, ""));
                cntxt.SaveChanges();
            }
        }
    }

    public class CustomerDBInitializer : DropCreateDatabaseAlways<CustomerDBContext>
    {
        protected override void Seed(CustomerDBContext context)
        {
            List<Customer> defaultCustomer = new List<Customer>();

            defaultCustomer.Add(new Customer("customer1", (DateTime.Now), 147.456, 142546, 004917654789654, ""));
            defaultCustomer.Add(new Customer("customer2", (DateTime.Now), 4568.478, 123, 004917654789654, ""));
            context.Customers.AddRange(defaultCustomer);
            context.SaveChanges();
            base.Seed(context);
        }
    }
}