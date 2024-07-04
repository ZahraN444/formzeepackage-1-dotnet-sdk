
# Subscription Details Response

## Structure

`SubscriptionDetailsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`Subscription`](../../doc/models/subscription.md) | Optional | - |
| `Links` | [`Links`](../../doc/models/links.md) | Optional | - |

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
    "created_on": "2016-03-13T12:52:32.123Z",
    "id": "00001c2a-0000-0000-0000-000000000000",
    "modified_on": "2016-03-13T12:52:32.123Z",
    "organisation_id": "00000b24-0000-0000-0000-000000000000",
    "type": "type0",
    "version": 110
  },
  "links": {
    "first": "first0",
    "last": "last4",
    "next": "next2",
    "prev": "prev8",
    "self": "self2"
  }
}
```

