# Users

```csharp
UsersController usersController = client.UsersController;
```

## Class Name

`UsersController`

## Methods

* [List All Users](../../doc/controllers/users.md#list-all-users)
* [Create User](../../doc/controllers/users.md#create-user)
* [Delete User](../../doc/controllers/users.md#delete-user)
* [Fetch User](../../doc/controllers/users.md#fetch-user)
* [Update User Details](../../doc/controllers/users.md#update-user-details)
* [Fetch Access Control List for User](../../doc/controllers/users.md#fetch-access-control-list-for-user)
* [Fetch Credentials for User](../../doc/controllers/users.md#fetch-credentials-for-user)
* [Create New Credentials for User](../../doc/controllers/users.md#create-new-credentials-for-user)
* [Delete Credentials for User](../../doc/controllers/users.md#delete-credentials-for-user)
* [Fetch All Roles for User](../../doc/controllers/users.md#fetch-all-roles-for-user)
* [Remove Role From User](../../doc/controllers/users.md#remove-role-from-user)
* [Add Role to User](../../doc/controllers/users.md#add-role-to-user)


# List All Users

List all users

```csharp
ListAllUsersAsync(
    int? pageNumber = null,
    int? pageSize = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `pageNumber` | `int?` | Query, Optional | Which page to select |
| `pageSize` | `int?` | Query, Optional | Number of items to select |

## Response Type

[`Task<Models.UserDetailsListResponse>`](../../doc/models/user-details-list-response.md)

## Example Usage

```csharp
Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')try
{
    UserDetailsListResponse result = await usersController.ListAllUsersAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Create User

Create user

```csharp
CreateUserAsync(
    Models.UserCreation userCreationRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userCreationRequest` | [`UserCreation`](../../doc/models/user-creation.md) | Body, Optional | - |

## Response Type

[`Task<Models.UserCreationResponse>`](../../doc/models/user-creation-response.md)

## Example Usage

```csharp
UserCreation userCreationRequest = new UserCreation
{
    Data = new User
    {
        Id = new Guid("7826c3cb-d6fd-41d0-b187-dc23ba928772"),
        OrganisationId = new Guid("ee2fb143-6dfe-4787-b183-ca8ddd4164d2"),
        Type = "User",
        Version = 0,
    },
};

try
{
    UserCreationResponse result = await usersController.CreateUserAsync(userCreationRequest);
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
| 400 | Bad request | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 409 | Conflict | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Delete User

Delete user

```csharp
DeleteUserAsync(
    Guid userId,
    int version)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userId` | `Guid` | Template, Required | User Id |
| `version` | `int` | Query, Required | Version |

## Response Type

`Task`

## Example Usage

```csharp
Guid userId = new Guid("00001e80-0000-0000-0000-000000000000");
int version = 172;
try
{
    await usersController.DeleteUserAsync(
        userId,
        version
    );
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
| 404 | Not Found | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 409 | Conflict | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Fetch User

Fetch user

```csharp
FetchUserAsync(
    Guid userId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userId` | `Guid` | Template, Required | User Id |

## Response Type

[`Task<Models.UserDetailsResponse>`](../../doc/models/user-details-response.md)

## Example Usage

```csharp
Guid userId = new Guid("00001e80-0000-0000-0000-000000000000");
try
{
    UserDetailsResponse result = await usersController.FetchUserAsync(userId);
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
| 404 | Not Found | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Update User Details

Update user details

```csharp
UpdateUserDetailsAsync(
    Guid userId,
    Models.UserCreation userUpdateRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userId` | `Guid` | Template, Required | User Id |
| `userUpdateRequest` | [`UserCreation`](../../doc/models/user-creation.md) | Body, Optional | - |

## Response Type

[`Task<Models.UserDetailsResponse>`](../../doc/models/user-details-response.md)

## Example Usage

```csharp
Guid userId = new Guid("00001e80-0000-0000-0000-000000000000");
UserCreation userUpdateRequest = new UserCreation
{
    Data = new User
    {
        Id = new Guid("7826c3cb-d6fd-41d0-b187-dc23ba928772"),
        OrganisationId = new Guid("ee2fb143-6dfe-4787-b183-ca8ddd4164d2"),
        Type = "User",
        Version = 0,
    },
};

try
{
    UserDetailsResponse result = await usersController.UpdateUserDetailsAsync(
        userId,
        userUpdateRequest
    );
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
| 400 | Bad request | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 404 | Not Found | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Fetch Access Control List for User

Fetch access control list for user

```csharp
FetchAccessControlListForUserAsync(
    Guid userId,
    string filterRecordType = null,
    string filterAction = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userId` | `Guid` | Template, Required | User Id |
| `filterRecordType` | `string` | Query, Optional | Record type |
| `filterAction` | `string` | Query, Optional | Access action |

## Response Type

[`Task<Models.AceDetailsListResponse>`](../../doc/models/ace-details-list-response.md)

## Example Usage

```csharp
Guid userId = new Guid("00001e80-0000-0000-0000-000000000000");
Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')try
{
    AceDetailsListResponse result = await usersController.FetchAccessControlListForUserAsync(userId);
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
| 404 | Not Found | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Fetch Credentials for User

Fetch credentials for user

```csharp
FetchCredentialsForUserAsync(
    Guid userId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userId` | `Guid` | Template, Required | User Id |

## Response Type

[`Task<Models.UserCredentialListResponse>`](../../doc/models/user-credential-list-response.md)

## Example Usage

```csharp
Guid userId = new Guid("00001e80-0000-0000-0000-000000000000");
try
{
    UserCredentialListResponse result = await usersController.FetchCredentialsForUserAsync(userId);
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
| 404 | Not Found | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Create New Credentials for User

Create new credentials for user

```csharp
CreateNewCredentialsForUserAsync(
    Guid userId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userId` | `Guid` | Template, Required | User Id |

## Response Type

[`Task<Models.CredentialCreationResponse>`](../../doc/models/credential-creation-response.md)

## Example Usage

```csharp
Guid userId = new Guid("00001e80-0000-0000-0000-000000000000");
try
{
    CredentialCreationResponse result = await usersController.CreateNewCredentialsForUserAsync(userId);
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
| 404 | Not Found | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Delete Credentials for User

Delete credentials for user

```csharp
DeleteCredentialsForUserAsync(
    Guid userId,
    string clientId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userId` | `Guid` | Template, Required | User Id |
| `clientId` | `string` | Template, Required | client id |

## Response Type

`Task`

## Example Usage

```csharp
Guid userId = new Guid("00001e80-0000-0000-0000-000000000000");
string clientId = "client_id8";
try
{
    await usersController.DeleteCredentialsForUserAsync(
        userId,
        clientId
    );
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
| 404 | Not Found | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Fetch All Roles for User

Fetch all roles for user

```csharp
FetchAllRolesForUserAsync(
    Guid userId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userId` | `Guid` | Template, Required | User Id |

## Response Type

[`Task<Models.UserRoleListResponse>`](../../doc/models/user-role-list-response.md)

## Example Usage

```csharp
Guid userId = new Guid("00001e80-0000-0000-0000-000000000000");
try
{
    UserRoleListResponse result = await usersController.FetchAllRolesForUserAsync(userId);
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
| 404 | Not Found | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Remove Role From User

Remove role from user

```csharp
RemoveRoleFromUserAsync(
    Guid userId,
    Guid roleId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userId` | `Guid` | Template, Required | User Id |
| `roleId` | `Guid` | Template, Required | Role Id |

## Response Type

`Task`

## Example Usage

```csharp
Guid userId = new Guid("00001e80-0000-0000-0000-000000000000");
Guid roleId = new Guid("000010c8-0000-0000-0000-000000000000");
try
{
    await usersController.RemoveRoleFromUserAsync(
        userId,
        roleId
    );
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
| 404 | Not Found | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Add Role to User

Add role to user

```csharp
AddRoleToUserAsync(
    Guid userId,
    Guid roleId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userId` | `Guid` | Template, Required | User Id |
| `roleId` | `Guid` | Template, Required | Role Id |

## Response Type

`Task`

## Example Usage

```csharp
Guid userId = new Guid("00001e80-0000-0000-0000-000000000000");
Guid roleId = new Guid("000010c8-0000-0000-0000-000000000000");
try
{
    await usersController.AddRoleToUserAsync(
        userId,
        roleId
    );
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
| 404 | Not Found | [`ApiErrorException`](../../doc/models/api-error-exception.md) |

