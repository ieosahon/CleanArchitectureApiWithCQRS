using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace CleanArchitecture.Social.Api.Options
{
    public class SwaggerOption : IConfigureOptions<SwaggerGenOptions>
    {
        private readonly IApiVersionDescriptionProvider _provider;

        public SwaggerOption(IApiVersionDescriptionProvider provider)
        {
            _provider = provider;
        }

        public void Configure(SwaggerGenOptions options)
        {
            foreach (var description in _provider.ApiVersionDescriptions)
            {
                options.SwaggerDoc(description.GroupName, CreateVersion(description));
            }

        }

        private OpenApiInfo CreateVersion(ApiVersionDescription apiVersion)
        {
            var info = new OpenApiInfo
            {
                Title = "Social Applicatiom",
                Description = apiVersion.ApiVersion.ToString()
            };
            if (apiVersion.IsDeprecated)
            {
                info.Description = "this api version is depricated";
            }
            return info;
        }
    }
}
