# Subscriptions

```csharp
SubscriptionsController subscriptionsController = client.SubscriptionsController;
```

## Class Name

`SubscriptionsController`

## Methods

* [List Subscriptions](../../doc/controllers/subscriptions.md#list-subscriptions)
* [Create Subscription](../../doc/controllers/subscriptions.md#create-subscription)
* [Delete Subscription](../../doc/controllers/subscriptions.md#delete-subscription)
* [Fetch Subscription](../../doc/controllers/subscriptions.md#fetch-subscription)
* [Patch Subscription](../../doc/controllers/subscriptions.md#patch-subscription)


# List Subscriptions

List all subscriptions

```csharp
ListSubscriptionsAsync(
    string pageNumber = null,
    int? pageSize = null,
    List<string> filterEventType = null,
    List<string> filterRecordType = null,
    List<Guid> filterOrganisationId = null,
    bool? filterDeactivated = null,
    string filterCallbackTransport = null,
    string filterCallbackUriSearchTerm = null,
    bool? filterNotificationFilter = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `pageNumber` | `string` | Query, Optional | Which page to select |
| `pageSize` | `int?` | Query, Optional | Number of items to select |
| `filterEventType` | `List<string>` | Query, Optional | Filter by event type |
| `filterRecordType` | `List<string>` | Query, Optional | Filter by record type |
| `filterOrganisationId` | `List<Guid>` | Query, Optional | Filter by organisation id |
| `filterDeactivated` | `bool?` | Query, Optional | Filter by deactivated |
| `filterCallbackTransport` | `string` | Query, Optional | Filter by callback_transport |
| `filterCallbackUriSearchTerm` | `string` | Query, Optional | Filter on callback_uri containing a search term |
| `filterNotificationFilter` | `bool?` | Query, Optional | Filter by existence of notification filters |

## Response Type

[`Task<Models.SubscriptionDetailsListResponse>`](../../doc/models/subscription-details-list-response.md)

## Example Usage

```csharp
Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')try
{
    SubscriptionDetailsListResponse result = await subscriptionsController.ListSubscriptionsAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Create Subscription

Create subscription

```csharp
CreateSubscriptionAsync(
    Models.SubscriptionCreation subscriptionCreationRequest)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionCreationRequest` | [`SubscriptionCreation`](../../doc/models/subscription-creation.md) | Body, Required | - |

## Response Type

[`Task<Models.SubscriptionCreationResponse>`](../../doc/models/subscription-creation-response.md)

## Example Usage

```csharp
SubscriptionCreation subscriptionCreationRequest = new SubscriptionCreation
{
    Data = new Subscription
    {
        Attributes = new SubscriptionAttributes
        {
            EventType = "event_type4",
            RecordType = "record_type8",
        },
        Id = new Guid("7826c3cb-d6fd-41d0-b187-dc23ba928772"),
        OrganisationId = new Guid("ee2fb143-6dfe-4787-b183-ca8ddd4164d2"),
        Type = "subscriptions",
        Version = 0,
    },
};

try
{
    SubscriptionCreationResponse result = await subscriptionsController.CreateSubscriptionAsync(subscriptionCreationRequest);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Delete Subscription

Deletes a subscription

```csharp
DeleteSubscriptionAsync(
    Guid id,
    int version)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Subscription Id |
| `version` | `int` | Query, Required | Version |

## Response Type

`Task`

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
int version = 172;
try
{
    await subscriptionsController.DeleteSubscriptionAsync(
        id,
        version
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Fetch Subscription

Fetch subscription

```csharp
FetchSubscriptionAsync(
    Guid id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Subscription Id |

## Response Type

[`Task<Models.SubscriptionDetailsResponse>`](../../doc/models/subscription-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
try
{
    SubscriptionDetailsResponse result = await subscriptionsController.FetchSubscriptionAsync(id);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Patch Subscription

Update subscription details

```csharp
PatchSubscriptionAsync(
    Guid id,
    Models.SubscriptionAmendment subscriptionUpdateRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Subscription Id |
| `subscriptionUpdateRequest` | [`SubscriptionAmendment`](../../doc/models/subscription-amendment.md) | Body, Optional | - |

## Response Type

[`Task<Models.SubscriptionDetailsResponse>`](../../doc/models/subscription-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
SubscriptionAmendment subscriptionUpdateRequest = new SubscriptionAmendment
{
    Data = new SubscriptionUpdate
    {
        Attributes = new SubscriptionUpdateAttributes
        {
        },
        Id = new Guid("7826c3cb-d6fd-41d0-b187-dc23ba928772"),
        OrganisationId = new Guid("ee2fb143-6dfe-4787-b183-ca8ddd4164d2"),
        Type = "subscriptions",
        Version = 0,
    },
};

try
{
    SubscriptionDetailsResponse result = await subscriptionsController.PatchSubscriptionAsync(
        id,
        subscriptionUpdateRequest
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
| 400 | Bad Request | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 404 | Not Found | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 409 | Conflict | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 500 | Internal Error | [`ApiErrorException`](../../doc/models/api-error-exception.md) |

