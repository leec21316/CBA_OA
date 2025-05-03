# 🐶 Swagger Petstore API Regression Suite

This project is an API regression test suite built using **C#**, **NUnit**, and **RestSharp**, based on the [Swagger Petstore](https://petstore.swagger.io/) API documentation.

## ✅ Technologies Used

- C# (.NET Framework 4.8)
- NUnit for test framework
- RestSharp for HTTP client
- Swagger Codegen (generated client)
- Docker (for local API server)
- GitHub Actions (CI)

---

## 🚀 Setup Instructions

### Option 1: Run Swagger Petstore API Locally (Recommended)

Run the Petstore API in Docker:

```bash
docker run -d -p 8080:8080 swaggerapi/petstore3
```

After it's running, the API will be available at 
http://localhost:8080/api/v3

In these Api test files, the baseUrl is configured for local testing:
private readonly string baseUrl = "http://localhost:8080/api/v3";


## 🧪 How to Run Tests Locally

 - Open the solution in Visual Studio 2019 or later

 - Restore NuGet packages (packages.config)

 - Build the solution

 - Open Test Explorer and click Run All Tests


## 🤖 Running Tests in CI (GitHub Actions)

 - This project includes a GitHub Actions workflow that:

	 - Builds the solution using MSBuild

	 - Runs tests via vstest.console.exe on Windows

 - See .github/workflows/test.yml for details.
