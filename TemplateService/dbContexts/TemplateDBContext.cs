
using TemplateService.DataContracts;
using TemplateService.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Collections.Generic;
using static Mono.Security.X509.X520;
using System.Runtime.Remoting.Contexts;

namespace TemplateService.dbContexts
{
    public class TemplateDBContext : DbContext
    {
        public TemplateDBContext() : base(nameOrConnectionString: "PostgresqlDBContext") {
            this.Database.CreateIfNotExists();
            //Database.SetInitializer(new TemplateDBInitializer());
        }
        public DbSet<Template> Templates { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Template>().HasKey(u => new
            {
                u.Name,
                u.Id
            });
        }

        public Boolean removeTemplate(string Name)
        {
            using (var context = new TemplateDBContext())
            {
                Template template = context.Templates.ToList<Template>().Where(x => x.Name == Name).FirstOrDefault();
                context.Templates.Remove(template);
                context.SaveChanges();
                return true;
            }
        }

        public TemplateDC addTemplate(string name, string TextSample)
        {
            Template template = new Template(name, TextSample);
            using (var context = new TemplateDBContext())
            {
                context.Templates.Add(template);
                context.SaveChanges();
            }
            TemplateDC templateDC = new TemplateDC();
            templateDC.Name = template.Name;
            templateDC.TextSample = template.TextSample;
            return templateDC;
        }

        public TemplateDC getTemplate(string Name)
        {
            using (var context = new TemplateDBContext())
            {
                Template template = context.Templates.ToList<Template>().Where(x => x.Name == Name).FirstOrDefault();
                TemplateDC templateDC = new TemplateDC();
                templateDC.Name = template.Name;
                templateDC.TextSample = template.TextSample;
                return templateDC;
            }
        }

        public void init()
        {
            //Database.SetInitializer(new TemplateDBInitializer());
            List<Template> defaultTemplates = new List<Template>();
            // name - creditnumber - summe - date => the order to generate the template
            string text = "Sehr geehrte Frau {0}, bis zum heutigen Datum konnten wir noch keinen Zahlungseingang der Rechnung Nr. {1}" +
                "über den fälligen Betrag von {2} feststellen. Bitte begleichen Sie die Rechnung bis zum {3} und überweisen den Rechnungsbetrag " +
                "auf das angegebene Geschäftskonto.";
            defaultTemplates.Add(new Template("Example 1", text));

            text = "sehr geehrte/r {0} - {1} Bitte zahlen sie bis zum {3} Die Summe {2} zurück";
            defaultTemplates.Add(new Template("Mahnung 1", text));
            TemplateDBContext cntxt = new TemplateDBContext();
            cntxt.Templates.AddRange(defaultTemplates);
            cntxt.SaveChanges();
        }
    }

    public class TemplateDBInitializer : DropCreateDatabaseAlways<TemplateDBContext>
    {
        protected override void Seed(TemplateDBContext context)
        {
            List<Template> defaultTemplates = new List<Template>();
            // name - creditnumber - summe - date => the order to generate the template
            string text = "Sehr geehrte Frau {0}, bis zum heutigen Datum konnten wir noch keinen Zahlungseingang der Rechnung Nr. {1}" +
                "über den fälligen Betrag von {2} feststellen. Bitte begleichen Sie die Rechnung bis zum {3} und überweisen den Rechnungsbetrag " +
                "auf das angegebene Geschäftskonto.";
            defaultTemplates.Add(new Template("Example 1", text));

            text = "sehr geehrte/r {0} - {1} Bitte zahlen sie bis zum {3} Die Summe {2} zurück";
            defaultTemplates.Add(new Template("Mahnung 1", text));
            context.Templates.AddRange(defaultTemplates);
            context.SaveChanges();
            base.Seed(context);
        }
    }
}