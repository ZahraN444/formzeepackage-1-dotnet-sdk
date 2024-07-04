
# Ace Details List Response

## Structure

`AceDetailsListResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<Ace>`](../../doc/models/ace.md) | Required | - |
| `Links` | [`Links`](../../doc/models/links.md) | Optional | - |

## Example (as JSON)

```json
{
  "data": [
    {
      "attributes": {
        "action": "CREATE",
        "record_type": "User",
        "role_id": "813e371b-c16c-4b86-adbf-82bcda159b27",
        "filter": "filter0"
      },
      "id": "7826c3cb-d6fd-41d0-b187-dc23ba928772",
      "organisation_id": "ee2fb143-6dfe-4787-b183-ca8ddd4164d2",
      "type": "ace",
      "version": 0
    }
  ],
  "links": {
    "first": "first0",
    "last": "last4",
    "next": "next2",
    "prev": "prev8",
    "self": "self2"
  }
}
```

