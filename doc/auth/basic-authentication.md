
# Basic Authentication



Documentation for accessing and setting credentials for Basic.

## Auth Credentials

| Name | Type | Description | Setter | Getter |
|  --- | --- | --- | --- | --- |
| Username | `string` | The username to use with basic authentication | `Username` | `Username` |
| Password | `string` | The password to use with basic authentication | `Password` | `Password` |



**Note:** Auth credentials can be set using `BasicCredentials` in the client builder and accessed through `BasicCredentials` method in the client instance.

## Usage Example

### Client Initialization

You must provide credentials in the client as shown in the following code snippet.

```csharp
Form3PublicAPI.Standard.Form3PublicAPIClient client = new Form3PublicAPI.Standard.Form3PublicAPIClient.Builder()
    .BasicCredentials(
        new BasicModel.Builder(
            "Username",
            "Password"
        )
        .Build())
    .Build();
```


