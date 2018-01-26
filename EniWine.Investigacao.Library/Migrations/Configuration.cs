namespace EniWine.Investigacao.Library.Migrations
{
    using EniWine.Investigacao.Library.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EniWine.Investigacao.Library.Repository.EnieWineContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(EniWine.Investigacao.Library.Repository.EnieWineContext context)
        {
            List<Arma> armas = new List<Arma>();
            armas.Add(new Arma { Id = 1, Nome = "Cajado Devastador" });
            armas.Add(new Arma { Id = 2, Nome = "Phaser" });
            armas.Add(new Arma { Id = 3, Nome = "Peixeira" });
            armas.Add(new Arma { Id = 4, Nome = "Trezoitão" });
            armas.Add(new Arma { Id = 5, Nome = "Sabre de Luz" });
            armas.Add(new Arma { Id = 6, Nome = "Bomba" });
            armas.ForEach(r => context.Arma.AddOrUpdate(r));
            context.SaveChanges();

            List<Local> locais = new List<Local>();
            locais.Add(new Local { Id = 1, Nome = "Etérnia" });
            locais.Add(new Local { Id = 2, Nome = "Vulcano" });
            locais.Add(new Local { Id = 3, Nome = "Tatooine" });
            locais.Add(new Local { Id = 4, Nome = "Springfield" });
            locais.Add(new Local { Id = 5, Nome = "Gotham" });
            locais.Add(new Local { Id = 6, Nome = "Nova York" });
            locais.Add(new Local { Id = 7, Nome = "Sibéria" });
            locais.Add(new Local { Id = 8, Nome = "Machu Picchu" });
            locais.Add(new Local { Id = 9, Nome = "Show do Katinguele" });
            locais.Add(new Local { Id = 10, Nome = "São Paulo" });
            locais.ForEach(r => context.Local.AddOrUpdate(r));
            context.SaveChanges();

            List<Suspeito> suspeitos = new List<Suspeito>();
            suspeitos.Add(new Suspeito { Id = 1, Nome = "Esqueleto" });
            suspeitos.Add(new Suspeito { Id = 2, Nome = "Khan" });
            suspeitos.Add(new Suspeito { Id = 3, Nome = "Darth vader" });
            suspeitos.Add(new Suspeito { Id = 4, Nome = "Sideshow Bob" });
            suspeitos.Add(new Suspeito { Id = 5, Nome = "Coringa" });
            suspeitos.Add(new Suspeito { Id = 6, Nome = "Duende Verde" });
            suspeitos.ForEach(r => context.Suspeito.AddOrUpdate(r));
            context.SaveChanges();

        }
    }
}
