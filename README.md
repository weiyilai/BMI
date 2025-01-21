# BMI

[單元測試](https://docs.google.com/presentation/d/1y1_quIzecA8wZUWjYMzOCxm9gFsSIK-8vYgKR5Goe3s/edit?usp=sharing)

[與 .NET 測試整合](https://learn.microsoft.com/zh-tw/dotnet/core/testing/unit-testing-code-coverage?tabs=linux#integrate-with-net-test)

```shell
dotnet test --collect:"XPlat Code Coverage"
```

```shell
還原完成 (0.7 秒)
  App 成功 (2.3 秒) → App\bin\Debug\net8.0\App.dll
  App.Tests 成功 (0.7 秒) → App.Tests\bin\Debug\net8.0\App.Tests.dll
NUnit Adapter 4.6.0.0: Test execution started
Running all tests in D:\source\repos\BMI\App.Tests\bin\Debug\net8.0\App.Tests.dll
   NUnit3TestExecutor discovered 3 of 3 NUnit test cases using Current Discovery mode, Non-Explicit run
NUnit Adapter 4.6.0.0: Test execution complete
  App.Tests 測試 成功 (4.6 秒)

測試摘要: 總計: 3, 失敗: 0, 成功: 3, 已跳過: 0, 持續時間: 4.6 秒
在 8.7 秒內建置 成功

附件:
  D:\source\repos\BMI\App.Tests\TestResults\85cf1bd3-91dd-4a10-92fb-d7ae2af6a7e0\coverage.cobertura.xml
```

[產生報表](https://learn.microsoft.com/zh-tw/dotnet/core/testing/unit-testing-code-coverage?tabs=linux#generate-reports)

"Path\To\TestProject\TestResults\{guid}\coverage.cobertura.xml"
換成附件的路徑
D:\source\repos\BMI\App.Tests\TestResults\85cf1bd3-91dd-4a10-92fb-d7ae2af6a7e0\coverage.cobertura.xml

```shell
reportgenerator -reports:"Path\To\TestProject\TestResults\{guid}\coverage.cobertura.xml" -targetdir:"coveragereport" -reporttypes:Html
```
