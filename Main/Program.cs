using Data;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductDbContext db = new ProductDbContext();

            Loja loja = new Loja
            {
                Nome = "Extra",
                Descricao = "Supermercado",
            };
            try
            {
                db.Lojas.Add(loja);
                db.SaveChanges();
                Console.WriteLine("Cliente salvo com sucesso.");
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
