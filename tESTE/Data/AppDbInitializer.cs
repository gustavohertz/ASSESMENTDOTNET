using tESTE.Models;

namespace tESTE.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviseScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                    var context = serviseScope.ServiceProvider.GetService<tESTEContext>();

                context.Database.EnsureCreated();
                if (!context.Cliente.Any())
                {
                    context.Cliente.AddRange(new List<Cliente>(){
                        new Cliente()
                        {
                            Id = "dbvsjdg",
                            Nome = "Rafael",
                            Numero = 1,
                            Idade = 18,

                        }
                    });
                    }
                    context.SaveChanges();
                }

            }
        }
    }

