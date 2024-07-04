
# Subscription Creation

## Structure

`SubscriptionCreation`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`Subscription`](../../doc/models/subscription.md) | Required | - |

## Example (as JSON)

```json
{
  "data": {
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
      "event_type": "event_type4",
      "filter": "filter0",
      "record_type": "record_type8"
    },
    "id": "7826c3cb-d6fd-41d0-b187-dc23ba928772",
    "organisation_id": "ee2fb143-6dfe-4787-b183-ca8ddd4164d2",
    "type": "subscriptions",
    "version": 0,
    "created_on": "2016-03-13T12:52:32.123Z",
    "modified_on": "2016-03-13T12:52:32.123Z"
  }
}
```

