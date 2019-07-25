using AWSChunky.Data.Models;
using AWSChunky.Data.Queries;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace AWSChunky
{
    public class Startup
    {
        public const string AppS3BucketKey = "AppS3Bucket";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public static IConfiguration Configuration { get; private set; }

        // This method gets called by the runtime. Use this method to add services to the container
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<ChunkyDatabaseSettings>(Configuration.GetSection(nameof(ChunkyDatabaseSettings)));
            services.AddSingleton<IChunkyDatabaseSettings>(sp =>
                    sp.GetRequiredService<IOptions<ChunkyDatabaseSettings>>().Value);
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddAWSService<Amazon.S3.IAmazonS3>();
            services.AddSingleton<IDecksQueryProcessor, DecksQueryProcessor> ();
            services.AddSingleton<IWordsQueryProcessor, WordsQueryProcessor>();
            services.AddCors(x => {
                x.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin());
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseCors(options => options.AllowAnyOrigin());

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
