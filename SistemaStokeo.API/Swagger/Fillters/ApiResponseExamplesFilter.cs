using Azure;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using SistemaStokeo.API.Swagger.Attribute;
using SistemaStokeo.API.Swagger.Examples;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Reflection;

namespace SistemaStokeo.API.Swagger.Fillters
{
    public class ApiResponseExamplesFilter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            var attributes = context.MethodInfo.GetCustomAttributes<StandarResponsesAttribute>().FirstOrDefault();
            if (attributes == null) return;

            // Ejemplo para 200 OK
            var successExample = new SuccessExample().GetExamples();
            var forbiddenExample = new ForbiddenExample().GetExamples();
            var notFoundExample = new NotFoundExample().GetExamples();
            var errorExample = new InternalErrorExample().GetExamples();

            operation.Responses["200"] = CreateExample("200", context, successExample, "Ok");
            operation.Responses["403"] = CreateExample("403", context, forbiddenExample, "Forbidden");
            operation.Responses["404"] = CreateExample("404", context, notFoundExample, "Not Found");
            operation.Responses["500"] = CreateExample("500", context, errorExample, "Internal Server Error");

        }

        private OpenApiResponse CreateExample(string statusCode, OperationFilterContext context, object exampleObject, string description)
        {
            return new OpenApiResponse
            {
                Description = description,
                Content = new Dictionary<string, OpenApiMediaType>
                {
                    ["application/json"] = new OpenApiMediaType
                    {
                        Schema = context.SchemaGenerator.GenerateSchema(typeof(Response<object>), context.SchemaRepository),
                        Example = ConvertToOpenApiAny(exampleObject)
                    }
                }
            };
        }

        private IOpenApiAny ConvertToOpenApiAny(object obj)
        {
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(obj);
            return OpenApiAnyFactory.CreateFromJson(json);
        }
    }
}

