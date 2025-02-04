# EF-Core.Multi-tenancy

驗證 Entity Framework Core & Asp.net Core 框架下，是否能藉由Request的參數，切換資料庫連線字串，共用相同DbContext的邏輯跟資料庫溝通

## 初始資源

* [PostgresSQL 的 sql file](/提供測試連結的公司SQL.sql)
  * 資料表結構
    * hr010
  * Seed Data
    * `hr010`的資料，分散在各自資料庫中(3份)
      * 震旦雲端事業部
      * 震旦雲│雲端人資系統展示平台
      * 汎美

## 環境設定

* {Web Client}
  * 公司識別碼(`3`)
* Web API(`1`)
  * DBContext(`1`)
* 資料庫(`3`)

## POC情境的操作步驟

* [透過Aspire編排環境](Aspire/透過Aspire編排環境.md)
