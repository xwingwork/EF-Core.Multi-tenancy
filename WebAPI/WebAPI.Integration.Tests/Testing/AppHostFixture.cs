using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using Aspire.Hosting.Testing;
using Microsoft.Extensions.DependencyInjection;

namespace WebAPI.Tests.Testing;

// // https://learn.microsoft.com/en-us/dotnet/aspire/testing/manage-app-host?pivots=xunit#use-the-distributedapplicationtestingbuilder-class
public sealed class AppHostFixture : IAsyncLifetime
{
    private DistributedApplication? app;
    public required HttpClient httpClient;

    public async Task InitializeAsync()
    {
        var appHost = await DistributedApplicationTestingBuilder
   .CreateAsync<Projects.WebAPI_AppHost>();

        app = await appHost.BuildAsync();
        var resourceNotificationService = app.Services.GetRequiredService<ResourceNotificationService>();
        await app.StartAsync();

        await resourceNotificationService.WaitForResourceAsync("webapi", KnownResourceStates.Running).WaitAsync(TimeSpan.FromSeconds(30));
        httpClient = app.CreateHttpClient("webapi");
    }

    public async Task DisposeAsync() => await app.DisposeAsync();
}

// 採集固定 https://xunit.net/docs/shared-context#collection-fixture
[CollectionDefinition(Name)]
public sealed class AppHostCollection : ICollectionFixture<AppHostFixture>
{
    public const string Name = "webapi.AppHost";
}