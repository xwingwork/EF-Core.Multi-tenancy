using Aspire.Hosting.ApplicationModel;
using Aspire.Hosting.Testing;
using Microsoft.Extensions.DependencyInjection;
using System.Net;

namespace WebAPI.Integration.Tests
{
    public class SingletonTests
    {
        // 參考微軟範例 https://learn.microsoft.com/en-us/dotnet/aspire/testing/write-your-first-test?pivots=xunit#explore-the-test-project
        [Fact]
        public async Task GetWebResourceRootReturnsOkStatusCodeAsync()
        {
            // Arrange
            var appHost = await DistributedApplicationTestingBuilder
                .CreateAsync<Projects.WebAPI_AppHost>();
            appHost.Services.ConfigureHttpClientDefaults(clientBuilder =>
            {
                clientBuilder.AddStandardResilienceHandler();
            });
            // To output logs to the xUnit.net ITestOutputHelper, consider adding a package from https://www.nuget.org/packages?q=xunit+logging

            await using var app = await appHost.BuildAsync();
            var resourceNotificationService = app.Services
                .GetRequiredService<ResourceNotificationService>();
            await app.StartAsync();

            // Act
            var httpClient = app.CreateHttpClient("webapi");
            httpClient.DefaultRequestHeaders.Add("TenantId", "a0ac");
            await resourceNotificationService
                .WaitForResourceAsync("webapi", KnownResourceStates.Running) // 等待依賴項目運行
                .WaitAsync(TimeSpan.FromSeconds(30));
            var response = await httpClient.GetAsync("/todos");

            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
