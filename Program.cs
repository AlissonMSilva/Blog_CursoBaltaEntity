using Blog.Data;
using Blog.Models;

namespace Blog
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var context = new DataContext())
            {
                // var tag = new Tag { Name = "ASP.NET", Slug = "aspnet" };
                // // Inserir novas informacoes no banco ->>
                // context.Tags.Add(tag);
                // context.SaveChanges();

                //Se for uma lista
                var tag=context.Tags.FirstOrDefault(x=>x.Id==2);//objeto vindo diretamente do banco
                tag.Name=".NET";
                tag.Slug="dotnet";
                context.Update(tag);
                context.SaveChanges();

                //ToList
                var tags=context
                    .Tags
                    .ToList();

                foreach(var item in tags)
                {
                    Console.WriteLine(item.Name);
                }

                //Atualizar uma info no banco ->>context.Update(tag);
                //Deletar uma info no banco
                // context.Remove(tag);

                // var tag=context.Tags.Where(x=> x.Name.Contains(".NET")).ToList();

                // foreach(var item in tag)
                // {
                //     Console.WriteLine(item.Name);
                // }
            }
        }
    }
}

