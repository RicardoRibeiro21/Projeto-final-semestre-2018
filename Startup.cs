using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Senai.OO.ProjetoFinal {
    public class Startup {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices (IServiceCollection services) {
            //adicionando memória rápida
            services.AddDistributedMemoryCache ();
            //Autenticação momentânea
            services.AddSession (
                //definindo tempo para a sessão/memória rápida
                options => options.IdleTimeout = TimeSpan.FromMinutes (20)
            );
            //Modelo View Controller
            services.AddMvc ();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure (IApplicationBuilder app, IHostingEnvironment env) {
            if (env.IsDevelopment ()) {
                app.UseDeveloperExceptionPage ();

                app.UseSession ();
                //para utilizar arquivos css 
                app.UseStaticFiles ();
                //Utilizando o Mvc (TRABALHAMOS COM ROTAS == URL1)
                app.UseMvc (
                    rota => rota.MapRoute (
                        name: "default",
                        template: "{controller=Usuario}/{action=Cadastrar}"
                    ));
            }
        }
    }
}