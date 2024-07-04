
# Audit Entry List Response

## Structure

`AuditEntryListResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<AuditEntry>`](../../doc/models/audit-entry.md) | Optional | - |
| `Links` | [`Links`](../../doc/models/links.md) | Optional | - |

## Example (as JSON)

```json
{
  "data": [
    {
      "attributes": {
        "action_time": "2016-03-13T12:52:32.123Z",
        "actioned_by": "00002648-0000-0000-0000-000000000000",
        "after_data": {
          "key1": "val1",
          "key2": "val2"
        },
        "before_data": {
          "key1": "val1",
          "key2": "val2"
        },
        "description": "description4"
      },
      "id": "00001c2a-0000-0000-0000-000000000000",
      "organisation_id": "00000b24-0000-0000-0000-000000000000",
      "type": "type0",
      "version": 110
    },
    {
      "attributes": {
        "action_time": "2016-03-13T12:52:32.123Z",
        "actioned_by": "00002648-0000-0000-0000-000000000000",
        "after_data": {
          "key1": "val1",
          "key2": "val2"
        },
        "before_data": {
          "key1": "val1",
          "key2": "val2"
        },
        "description": "description4"
      },
      "id": "00001c2a-0000-0000-0000-000000000000",
      "organisation_id": "00000b24-0000-0000-0000-000000000000",
      "type": "type0",
      "version": 110
    },
    {
      "attributes": {
        "action_time": "2016-03-13T12:52:32.123Z",
        "actioned_by": "00002648-0000-0000-0000-000000000000",
        "after_data": {
          "key1": "val1",
          "key2": "val2"
        },
        "before_data": {
          "key1": "val1",
          "key2": "val2"
        },
        "description": "description4"
      },
      "id": "00001c2a-0000-0000-0000-000000000000",
      "organisation_id": "00000b24-0000-0000-0000-000000000000",
      "type": "type0",
      "version": 110
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

