using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace sistema_toma_turnos.Views
{
    public class bloc_notasModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}


//--------------BLOC DE NOTAS--------
//// Add services to the container.
//builder.Services.AddRazorPages();



//var cadenaConexion = builder.Configuration.GetConnectionString("connCOAPRE");
//builder.Services.AddDbContext<ModelContext>(x => x.UseOracle(cadenaConexion, options =>
//                                                             options.UseOracleSQLCompatibility("11"))
//                                           );


//builder.Services.AddScoped<ICategoriaRepository, CategoriaRepository>();
//builder.Services.AddScoped<ITipoAuditoriaRepository, TipoAuditoriaRepository>();
//builder.Services.AddScoped<IEntidadAudRepository, EntidadAudRepository>();

//var app = builder.Build();


//*------------------Conexion en sql startUp----------------------------------------------------------------------------------------------


//        public void ConfigureServices(IServiceCollection services)
//{
//    services.AddDbContext<ApplicationDbContext>(options =>
//        options.UseSqlServer(Configuration.GetConnectionString("ConnectionSql")));

//    services.AddControllersWithViews();
//}

//*------------------------------------JSON cadena de Conexion----------------------------------------------------------------------------

//{
//  "ConnectionStrings": {
//    "connCOAPRE" : "User Id=coacehl;Password=123456;Data Source=192.168.103.97:1521/COAPRE;"
//  }