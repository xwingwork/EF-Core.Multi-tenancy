var builder = DistributedApplication.CreateBuilder(args);

var postgres = builder
    .AddPostgres("postgres") // 執行個體，包含預設資料庫。https://learn.microsoft.com/zh-tw/dotnet/aspire/database/postgresql-entity-framework-integration?tabs=dotnet-cli
    .WithBindMount("Development/Postgres", "/docker-entrypoint-initdb.d") // Seed data https://learn.microsoft.com/en-us/dotnet/aspire/database/seed-database-data?tabs=sql-server#database-seeding-examples
    .WithPgAdmin() // 執行個體網頁客戶端-管理工具
    .WithPgWeb(); // 資料庫網頁客戶端-資料表查詢工具

// 編排：添加資料庫的監控、連線字串傳遞(給PgWeb)
var 震旦雲端事業部 = postgres.AddDatabase("a0ac");
var 雲端人資系統展示平台 = postgres.AddDatabase("oacloud");
var 汎美 = postgres.AddDatabase("gm9415");

builder.AddProject<Projects.WebAPI>("webapi")
                            // 服務間的關聯性
                            .WithReference(震旦雲端事業部) // 服務的相依性、環境參數傳遞
                                .WaitFor(震旦雲端事業部) // 啟動的相依性
                            .WithReference(雲端人資系統展示平台)
                                .WaitFor(雲端人資系統展示平台)
                            .WithReference(汎美)
                                .WaitFor(汎美);

builder.Build().Run();
