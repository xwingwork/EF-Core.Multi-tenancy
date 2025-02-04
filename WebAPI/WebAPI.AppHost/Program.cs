var builder = DistributedApplication.CreateBuilder(args);

var postgres = builder
    .AddPostgres("postgres") // �������A�]�t�w�]��Ʈw
    .WithPgAdmin() // �����������Ȥ��-�޲z�u��
    .WithPgWeb(); // ��Ʈw�����Ȥ��-��ƪ�d�ߤu��

builder.AddProject<Projects.WebAPI>("webapi");

builder.Build().Run();
