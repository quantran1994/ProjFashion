using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace ProjFashion.WebApi.Authorizes
{
    public class MinimumAgeRequirement : IAuthorizationRequirement
    {
        public MinimumAgeRequirement(int age)
        {
            MinimumAge = age;
        }

        public int MinimumAge { get; private set; }
    }

    public class MinimumAgeHandler : AuthorizationHandler<MinimumAgeRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, MinimumAgeRequirement requirement)
        {
         
            //var dateOfBirthClaim = context.User.FindFirst(
            //c => c.Type == ClaimTypes.DateOfBirth && c.Issuer == "http://contoso.com");

            //if (dateOfBirthClaim is null)
            //{
            //    return Task.CompletedTask;
            //}

            var dateOfBirth =new DateTime(2020,1,1);
            int calculatedAge = DateTime.Today.Year - dateOfBirth.Year;
            if (dateOfBirth > DateTime.Today.AddYears(-calculatedAge))
            {
                calculatedAge--;
            }

            if (calculatedAge >= requirement.MinimumAge)
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}
