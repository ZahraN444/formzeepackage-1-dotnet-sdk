
# Getting Started with Form3 Public API

## Install the Package

If you are building with .NET CLI tools then you can also use the following command:

```bash
dotnet add package zahra.testpackage --version 1.1.1
```

You can also view the package at:
https://www.nuget.org/packages/zahra.testpackage/1.1.1

## Initialize the API Client

**_Note:_** Documentation for the client can be found [here.](https://www.github.com/ZahraN444/formzeepackage-1-dotnet-sdk/tree/1.1.1/doc/client.md)

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| `BasicCredentials` | [`BasicCredentials`](https://www.github.com/ZahraN444/formzeepackage-1-dotnet-sdk/tree/1.1.1/doc/$a/https://www.github.com/ZahraN444/formzeepackage-1-dotnet-sdk/tree/1.1.1/basic-authentication.md) | The Credentials Setter for Basic Authentication |
| `OAuth2Credentials` | [`OAuth2Credentials`](https://www.github.com/ZahraN444/formzeepackage-1-dotnet-sdk/tree/1.1.1/doc/$a/https://www.github.com/ZahraN444/formzeepackage-1-dotnet-sdk/tree/1.1.1/oauth-2-client-credentials-grant.md) | The Credentials Setter for OAuth 2 Client Credentials Grant |

The API client can be initialized as follows:

```csharp
Form3PublicAPI.Standard.Form3PublicAPIClient client = new Form3PublicAPI.Standard.Form3PublicAPIClient.Builder()
    .BasicCredentials(
        new BasicModel.Builder(
            "Username",
            "Password"
        )
        .Build())
    .OAuth2Credentials(
        new OAuth2Model.Builder(
            "OAuthClientId",
            "OAuthClientSecret"
        )
        .Build())
    .Build();
```

## Authorization

This API uses the following authentication schemes.

* [`Basic (Basic Authentication)`](https://www.github.com/ZahraN444/formzeepackage-1-dotnet-sdk/tree/1.1.1/doc/$a/https://www.github.com/ZahraN444/formzeepackage-1-dotnet-sdk/tree/1.1.1/basic-authentication.md)
* [`OAuth2 (OAuth 2 Client Credentials Grant)`](https://www.github.com/ZahraN444/formzeepackage-1-dotnet-sdk/tree/1.1.1/doc/$a/https://www.github.com/ZahraN444/formzeepackage-1-dotnet-sdk/tree/1.1.1/oauth-2-client-credentials-grant.md)

## List of APIs

* [Scheme File API](https://www.github.com/ZahraN444/formzeepackage-1-dotnet-sdk/tree/1.1.1/doc/controllers/scheme-file-api.md)
* [Transaction File API](https://www.github.com/ZahraN444/formzeepackage-1-dotnet-sdk/tree/1.1.1/doc/controllers/transaction-file-api.md)
* [Metrics API](https://www.github.com/ZahraN444/formzeepackage-1-dotnet-sdk/tree/1.1.1/doc/controllers/metrics-api.md)
* [Name Verification API](https://www.github.com/ZahraN444/formzeepackage-1-dotnet-sdk/tree/1.1.1/doc/controllers/name-verification-api.md)
* [O Auth Authorization](https://www.github.com/ZahraN444/formzeepackage-1-dotnet-sdk/tree/1.1.1/doc/controllers/o-auth-authorization.md)
* [Audit](https://www.github.com/ZahraN444/formzeepackage-1-dotnet-sdk/tree/1.1.1/doc/controllers/audit.md)
* [Reports](https://www.github.com/ZahraN444/formzeepackage-1-dotnet-sdk/tree/1.1.1/doc/controllers/reports.md)
* [Scheme Messages](https://www.github.com/ZahraN444/formzeepackage-1-dotnet-sdk/tree/1.1.1/doc/controllers/scheme-messages.md)
* [Subscriptions](https://www.github.com/ZahraN444/formzeepackage-1-dotnet-sdk/tree/1.1.1/doc/controllers/subscriptions.md)
* [Oauth 2](https://www.github.com/ZahraN444/formzeepackage-1-dotnet-sdk/tree/1.1.1/doc/controllers/oauth-2.md)
* [Accounts](https://www.github.com/ZahraN444/formzeepackage-1-dotnet-sdk/tree/1.1.1/doc/controllers/accounts.md)
* [Account Identification](https://www.github.com/ZahraN444/formzeepackage-1-dotnet-sdk/tree/1.1.1/doc/controllers/account-identification.md)
* [Branches](https://www.github.com/ZahraN444/formzeepackage-1-dotnet-sdk/tree/1.1.1/doc/controllers/branches.md)
* [Branch Identification](https://www.github.com/ZahraN444/formzeepackage-1-dotnet-sdk/tree/1.1.1/doc/controllers/branch-identification.md)
* [Payments](https://www.github.com/ZahraN444/formzeepackage-1-dotnet-sdk/tree/1.1.1/doc/controllers/payments.md)
* [Organisations](https://www.github.com/ZahraN444/formzeepackage-1-dotnet-sdk/tree/1.1.1/doc/controllers/organisations.md)
* [Platformsecurityapi](https://www.github.com/ZahraN444/formzeepackage-1-dotnet-sdk/tree/1.1.1/doc/controllers/platformsecurityapi.md)
* [Roles](https://www.github.com/ZahraN444/formzeepackage-1-dotnet-sdk/tree/1.1.1/doc/controllers/roles.md)
* [ACE](https://www.github.com/ZahraN444/formzeepackage-1-dotnet-sdk/tree/1.1.1/doc/controllers/ace.md)
* [Users](https://www.github.com/ZahraN444/formzeepackage-1-dotnet-sdk/tree/1.1.1/doc/controllers/users.md)
* [Claims](https://www.github.com/ZahraN444/formzeepackage-1-dotnet-sdk/tree/1.1.1/doc/controllers/claims.md)
* [Direct Debits](https://www.github.com/ZahraN444/formzeepackage-1-dotnet-sdk/tree/1.1.1/doc/controllers/direct-debits.md)
* [Mandates](https://www.github.com/ZahraN444/formzeepackage-1-dotnet-sdk/tree/1.1.1/doc/controllers/mandates.md)
* [Query Api](https://www.github.com/ZahraN444/formzeepackage-1-dotnet-sdk/tree/1.1.1/doc/controllers/query-api.md)
* [Account Validation](https://www.github.com/ZahraN444/formzeepackage-1-dotnet-sdk/tree/1.1.1/doc/controllers/account-validation.md)

## Classes Documentation

* [Utility Classes](https://www.github.com/ZahraN444/formzeepackage-1-dotnet-sdk/tree/1.1.1/doc/utility-classes.md)
* [HttpRequest](https://www.github.com/ZahraN444/formzeepackage-1-dotnet-sdk/tree/1.1.1/doc/http-request.md)
* [HttpResponse](https://www.github.com/ZahraN444/formzeepackage-1-dotnet-sdk/tree/1.1.1/doc/http-response.md)
* [HttpStringResponse](https://www.github.com/ZahraN444/formzeepackage-1-dotnet-sdk/tree/1.1.1/doc/http-string-response.md)
* [HttpContext](https://www.github.com/ZahraN444/formzeepackage-1-dotnet-sdk/tree/1.1.1/doc/http-context.md)
* [HttpClientConfiguration](https://www.github.com/ZahraN444/formzeepackage-1-dotnet-sdk/tree/1.1.1/doc/http-client-configuration.md)
* [HttpClientConfiguration Builder](https://www.github.com/ZahraN444/formzeepackage-1-dotnet-sdk/tree/1.1.1/doc/http-client-configuration-builder.md)
* [IAuthManager](https://www.github.com/ZahraN444/formzeepackage-1-dotnet-sdk/tree/1.1.1/doc/i-auth-manager.md)
* [ApiException](https://www.github.com/ZahraN444/formzeepackage-1-dotnet-sdk/tree/1.1.1/doc/api-exception.md)

