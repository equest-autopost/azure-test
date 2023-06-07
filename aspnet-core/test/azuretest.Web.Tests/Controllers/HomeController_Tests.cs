using System.Threading.Tasks;
using azuretest.Models.TokenAuth;
using azuretest.Web.Controllers;
using Shouldly;
using Xunit;

namespace azuretest.Web.Tests.Controllers
{
    public class HomeController_Tests: azuretestWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}