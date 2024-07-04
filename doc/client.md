
# Client Class Documentation

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| `BasicCredentials` | [`BasicCredentials`]($a/basic-authentication.md) | The Credentials Setter for Basic Authentication |
| `OAuth2Credentials` | [`OAuth2Credentials`]($a/oauth-2-client-credentials-grant.md) | The Credentials Setter for OAuth 2 Client Credentials Grant |

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

## Form3 Public APIClient Class

The gateway for the SDK. This class acts as a factory for the Controllers and also holds the configuration of the SDK.

### Controllers

| Name | Description |
|  --- | --- |
| AuditController | Gets AuditController controller. |
| SchemeFileAPIController | Gets SchemeFileAPIController controller. |
| TransactionFileAPIController | Gets TransactionFileAPIController controller. |
| MetricsAPIController | Gets MetricsAPIController controller. |
| ReportsController | Gets ReportsController controller. |
| SchemeMessagesController | Gets SchemeMessagesController controller. |
| SubscriptionsController | Gets SubscriptionsController controller. |
| Oauth2Controller | Gets Oauth2Controller controller. |
| AccountsController | Gets AccountsController controller. |
| AccountIdentificationController | Gets AccountIdentificationController controller. |
| BranchesController | Gets BranchesController controller. |
| BranchIdentificationController | Gets BranchIdentificationController controller. |
| NameVerificationAPIController | Gets NameVerificationAPIController controller. |
| PaymentsController | Gets PaymentsController controller. |
| OrganisationsController | Gets OrganisationsController controller. |
| PlatformsecurityapiController | Gets PlatformsecurityapiController controller. |
| RolesController | Gets RolesController controller. |
| ACEController | Gets ACEController controller. |
| UsersController | Gets UsersController controller. |
| ClaimsController | Gets ClaimsController controller. |
| DirectDebitsController | Gets DirectDebitsController controller. |
| MandatesController | Gets MandatesController controller. |
| QueryApiController | Gets QueryApiController controller. |
| AccountValidationController | Gets AccountValidationController controller. |
| OAuthAuthorizationController | Gets OAuthAuthorizationController controller. |

### Properties

| Name | Description | Type |
|  --- | --- | --- |
| HttpClientConfiguration | Gets the configuration of the Http Client associated with this client. | [`IHttpClientConfiguration`](http-client-configuration.md) |
| Timeout | Http client timeout. | `TimeSpan` |
| Environment | Current API environment. | `Environment` |
| BasicCredentials | Gets the credentials to use with Basic. | [`IBasicCredentials`]($a/basic-authentication.md) |
| OAuth2Credentials | Gets the credentials to use with OAuth2. | [`IOAuth2Credentials`]($a/oauth-2-client-credentials-grant.md) |

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `GetBaseUri(Server alias = Server.Default)` | Gets the URL for a particular alias in the current environment and appends it with template parameters. | `string` |
| `ToBuilder()` | Creates an object of the Form3 Public APIClient using the values provided for the builder. | `Builder` |

## Form3 Public APIClient Builder Class

Class to build instances of Form3 Public APIClient.

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `HttpClientConfiguration(Action<`[`HttpClientConfiguration.Builder`](http-client-configuration-builder.md)`> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `BasicCredentials(Action<BasicModel.Builder> action)` | Sets credentials for Basic. | `Builder` |
| `OAuth2Credentials(Action<OAuth2Model.Builder> action)` | Sets credentials for OAuth2. | `Builder` |

