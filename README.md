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

### 隱含設定

未直接定義，在接案交談歷程中提部分

#### 資料庫服務

繼承現有資料庫服務`PostgresSQL`

##### 資料庫存取

* 連線至單一資料庫服務
* 切換連線字串方式，更換資料庫存取
* 共用一份資料庫的存取邏輯

> 微軟提供 Entity Framework Core (EF Core) 作為與資料庫互動的工具，提供 Object Relational Mapping(ORM、O/RM、O/R mapping、物件關聯式的對應程式) 方式存取、可重複利用的上下文(DbContext)
> <https://learn.microsoft.com/zh-tw/ef/core/>

#### RunTime

使用Linux環境

#### 效能

依照重要性排序

1. 提高 Run Time
2. 資源釋放
3. 啟動階段

> 微軟提供 Native ahead-of-time (Native AOT、原生AOT) 的發布模式，未來預計取代預設 Just-In-Time (JIT、即時) 編譯器，是容器化跟SRE概念下，效能改進的方案
>
> * 於開發期啟用
> * 可讓建構物產出最小化
> * 使用原生環境機制提升效能(更少的記憶體消耗)
>
> <https://learn.microsoft.com/en-us/dotnet/core/deploying/native-aot/?tabs=windows%2Cnet8>

##### 原生AOT與EFCore不兼容

概念牴觸，現階段(EF Core 9)處於 Experimental (實驗性)，Production (生產) 不適合使用

> NativeAOT 支援和先行編譯查詢 Experimental (實驗性)，<https://learn.microsoft.com/zh-tw/ef/core/performance/nativeaot-and-precompiled-queries>

* Native ahead-of-time (Native AOT、原生AOT) - 動態轉靜態
* Entity Framework Core (EF Core) - 動態生成對應配置的語法

> `**價值牴觸**`本案定義 Multi-tenancy (多租戶) 模式，該模式使用 Native AOT時，會在`dbContext.Database.SetConnectionString`產生錯誤，且開發與編譯階段時，未有告警訊息。錯誤訊息`System.InvalidOperationException: 'Model building is not supported when publishing with NativeAOT. Use a compiled model.'`
> [停用NativeAOT編譯](停用NativeAOT編譯.md)

## POC情境的操作步驟

* [透過Aspire編排環境](Aspire/README.md)
