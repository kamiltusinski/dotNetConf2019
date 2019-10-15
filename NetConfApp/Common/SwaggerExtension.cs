using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;

namespace NetConfApp.Common
{
    public static class SwaggerExtension
    {
        public static void AddSwagger(this IServiceCollection services)
        {
            //services.AddSwaggerGen(c =>
            //{
            //    c.SwaggerDoc("v1", new OpenApiInfo
            //    {
            //        Version = "v1",
            //        Title = "My API",
            //    });

            //    c.SwaggerDoc("v2", new OpenApiInfo
            //    {
            //        Version = "v2",
            //        Title = "New API V2",
            //    });

            //    c.DescribeAllEnumsAsStrings();
            //    c.DescribeStringEnumsInCamelCase();
            //});
        }
        public static void UseCustomSwagger(this IApplicationBuilder app)
        {
            //app.UseSwagger();
            //app.UseSwaggerUI(c =>
            //{
            //    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            //    c.SwaggerEndpoint("/swagger/v2/swagger.json", "My API V2");
            //});
        }
    }
}
