# Oauth 2

```csharp
Oauth2Controller oauth2Controller = client.Oauth2Controller;
```

## Class Name

`Oauth2Controller`


# Request Access Token

Request Access Token

```csharp
RequestAccessTokenAsync()
```

## Response Type

[`Task<Models.Token>`](../../doc/models/token.md)

## Example Usage

```csharp
try
{
    Token result = await oauth2Controller.RequestAccessTokenAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 403 | Authentication failed | `ApiException` |

