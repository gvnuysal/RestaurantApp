using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Restaurant.Business.Abstract;
using Restaurant.Business.Abstract.Orders;
using Restaurant.Business.Concrete.Customers;
using Restaurant.Business.Concrete.Orders;
using Restaurant.DataAcess.Abstract.Customers;
using Restaurant.DataAcess.Abstract.Orders;
using Restaurant.DataAcess.Concrete.EntityFrameworkCore.Customers;
using Restaurant.DataAcess.Concrete.EntityFrameworkCore.Orders;
using Swashbuckle.Swagger;

namespace Restaurant.WEBAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<ICustomerService, CustomerManager>();
            services.AddTransient<ICustomerDal, EfCustomerDal>();
            services.AddTransient<IOrderService, OrderManager>();
            services.AddTransient<IOrdersDal, EfOrderDal>();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Contact=new Microsoft.OpenApi.Models.OpenApiContact() { Email="gvnuysal@gmail.com"},
                    Description="Restaurant SWAGGER API DOC",
                    Version="V1"
                });
            });
            services.AddMvc();
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "V1");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
