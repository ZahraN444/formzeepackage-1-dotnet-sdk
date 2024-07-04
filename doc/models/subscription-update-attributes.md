
# Subscription Update Attributes

## Structure

`SubscriptionUpdateAttributes`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CallbackTransport` | [`CallbackTransportEnum?`](../../doc/models/callback-transport-enum.md) | Optional | - |
| `CallbackUri` | `string` | Optional | Deprecated. Please use callback_uris instead<br>**Constraints**: *Pattern*: `^[A-Za-z0-9 .,@:\&\?=\/\-_]*$` |
| `CallbackUris` | [`List<CallbackURI>`](../../doc/models/callback-uri.md) | Optional | - |
| `Deactivated` | `bool?` | Optional | - |
| `EventType` | `string` | Optional | **Constraints**: *Pattern*: `^[A-Za-z_-]*$` |
| `Filter` | `string` | Optional | - |
| `RecordType` | `string` | Optional | **Constraints**: *Pattern*: `^[A-Za-z_-]*$` |
| `UserDefinedData` | [`List<SubscriptionUserDefinedData>`](../../doc/models/subscription-user-defined-data.md) | Optional | All purpose list of key-value pairs to store specific data for the associated subscription.<br>**Constraints**: *Maximum Items*: `5` |
| `UserId` | `Guid?` | Optional | - |

## Example (as JSON)

```json
{
  "callback_transport": "http_aws_private",
  "callback_uri": "callback_uri6",
  "callback_uris": [
    {
      "callback_transport": "queue",
      "callback_uri": "callback_uri4"
    },
    {
      "callback_transport": "queue",
      "callback_uri": "callback_uri4"
    },
    {
      "callback_transport": "queue",
      "callback_uri": "callback_uri4"
    }
  ],
  "deactivated": false,
  "event_type": "event_type2"
}
```

