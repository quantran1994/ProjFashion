using ProjFashion.WebApi.Services;

namespace ProjFashion.WebApi.GroupEndPoints
{
    public static class CategoryRoutes
    {
        public static void MapGroupCategoryRoutes(this IEndpointRouteBuilder appBuilder)
        {
            var categoryRoutes = appBuilder.MapGroup("/api/Categories");
            categoryRoutes.MapGet("/", (CategoryService service) =>
            {
                return Results.Ok(service.GetData);
            })
            .WithName("");

        }
    }
}
