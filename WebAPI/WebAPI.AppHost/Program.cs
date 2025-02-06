var builder = DistributedApplication.CreateBuilder(args);

var postgres = builder
    .AddPostgres("postgres") // �������A�]�t�w�]��Ʈw�Chttps://learn.microsoft.com/zh-tw/dotnet/aspire/database/postgresql-entity-framework-integration?tabs=dotnet-cli
    .WithBindMount("Development/Postgres", "/docker-entrypoint-initdb.d") // Seed data https://learn.microsoft.com/en-us/dotnet/aspire/database/seed-database-data?tabs=sql-server#database-seeding-examples
    .WithPgAdmin() // �����������Ȥ��-�޲z�u��
    .WithPgWeb(); // ��Ʈw�����Ȥ��-��ƪ�d�ߤu��

// �s�ơG�K�[��Ʈw���ʱ��B�s�u�r��ǻ�(��PgWeb)
var �_�����ݨƷ~�� = postgres.AddDatabase("a0ac");
var ���ݤH��t�ήi�ܥ��x = postgres.AddDatabase("oacloud");
var �Ƭ� = postgres.AddDatabase("gm9415");

builder.AddProject<Projects.WebAPI>("webapi")
                            // �A�ȶ������p��
                            .WithReference(�_�����ݨƷ~��) // �A�Ȫ��̩ۨʡB���ҰѼƶǻ�
                                .WaitFor(�_�����ݨƷ~��) // �Ұʪ��̩ۨ�
                            .WithReference(���ݤH��t�ήi�ܥ��x)
                                .WaitFor(���ݤH��t�ήi�ܥ��x)
                            .WithReference(�Ƭ�)
                                .WaitFor(�Ƭ�);

builder.Build().Run();
