
# Subscription Update

## Structure

`SubscriptionUpdate`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Attributes` | [`SubscriptionUpdateAttributes`](../../doc/models/subscription-update-attributes.md) | Required | - |
| `Id` | `Guid` | Required | Unique resource ID |
| `OrganisationId` | `Guid` | Required | Unique ID of the organisation this resource is created by |
| `Type` | `string` | Optional | Name of the resource type<br>**Constraints**: *Pattern*: `^[A-Za-z]*$` |
| `Version` | `int?` | Optional | Version number<br>**Constraints**: `>= 0` |

## Example (as JSON)

```json
{
  "attributes": {
    "callback_transport": "http_aws_private",
    "callback_uri": "callback_uri8",
    "callback_uris": [
      {
        "callback_transport": "queue",
        "callback_uri": "callback_uri4"
      }
    ],
    "deactivated": false,
    "event_type": "event_type4"
  },
  "id": "7826c3cb-d6fd-41d0-b187-dc23ba928772",
  "organisation_id": "ee2fb143-6dfe-4787-b183-ca8ddd4164d2",
  "type": "subscriptions",
  "version": 0
}
```

