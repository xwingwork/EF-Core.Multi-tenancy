var builder = DistributedApplication.CreateBuilder(args);

var postgres = builder
    .AddPostgres("postgres") // 執行個體，包含預設資料庫
    .WithPgAdmin() // 執行個體網頁客戶端-管理工具
    .WithPgWeb(); // 資料庫網頁客戶端-資料表查詢工具

builder.AddProject<Projects.WebAPI>("webapi");

builder.Build().Run();
