-- 創建資料庫
SELECT 'CREATE DATABASE a0ac'
WHERE NOT EXISTS (SELECT FROM pg_database WHERE datname = 'a0ac')\gexec

SELECT 'CREATE DATABASE oacloud'
WHERE NOT EXISTS (SELECT FROM pg_database WHERE datname = 'oacloud')\gexec

SELECT 'CREATE DATABASE gm9415'
WHERE NOT EXISTS (SELECT FROM pg_database WHERE datname = 'gm9415')\gexec