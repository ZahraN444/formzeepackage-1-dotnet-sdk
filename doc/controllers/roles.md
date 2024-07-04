# Roles

```csharp
RolesController rolesController = client.RolesController;
```

## Class Name

`RolesController`

## Methods

* [List All Roles](../../doc/controllers/roles.md#list-all-roles)
* [Create Role](../../doc/controllers/roles.md#create-role)
* [Delete Role](../../doc/controllers/roles.md#delete-role)
* [Fetch Role](../../doc/controllers/roles.md#fetch-role)


# List All Roles

List all roles

```csharp
ListAllRolesAsync(
    int? pageNumber = null,
    int? pageSize = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `pageNumber` | `int?` | Query, Optional | Which page to select |
| `pageSize` | `int?` | Query, Optional | Number of items to select |

## Response Type

[`Task<Models.RoleDetailsListResponse>`](../../doc/models/role-details-list-response.md)

## Example Usage

```csharp
Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')try
{
    RoleDetailsListResponse result = await rolesController.ListAllRolesAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Create Role

Create role

```csharp
CreateRoleAsync(
    Models.RoleCreation roleCreationRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `roleCreationRequest` | [`RoleCreation`](../../doc/models/role-creation.md) | Body, Optional | - |

## Response Type

[`Task<Models.RoleCreationResponse>`](../../doc/models/role-creation-response.md)

## Example Usage

```csharp
RoleCreation roleCreationRequest = new RoleCreation
{
    Data = new Role
    {
        Id = new Guid("7826c3cb-d6fd-41d0-b187-dc23ba928772"),
        OrganisationId = new Guid("ee2fb143-6dfe-4787-b183-ca8ddd4164d2"),
        Type = "role",
        Version = 0,
    },
};

try
{
    RoleCreationResponse result = await rolesController.CreateRoleAsync(roleCreationRequest);
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


# Delete Role

Delete role

```csharp
DeleteRoleAsync(
    Guid roleId,
    int version)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `roleId` | `Guid` | Template, Required | Role Id |
| `version` | `int` | Query, Required | Version |

## Response Type

`Task`

## Example Usage

```csharp
Guid roleId = new Guid("000010c8-0000-0000-0000-000000000000");
int version = 172;
try
{
    await rolesController.DeleteRoleAsync(
        roleId,
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


# Fetch Role

Fetch role

```csharp
FetchRoleAsync(
    Guid roleId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `roleId` | `Guid` | Template, Required | Role Id |

## Response Type

[`Task<Models.RoleDetailsResponse>`](../../doc/models/role-details-response.md)

## Example Usage

```csharp
Guid roleId = new Guid("000010c8-0000-0000-0000-000000000000");
try
{
    RoleDetailsResponse result = await rolesController.FetchRoleAsync(roleId);
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

