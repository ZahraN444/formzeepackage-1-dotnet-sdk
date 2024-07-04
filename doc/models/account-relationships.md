
# Account Relationships

## Structure

`AccountRelationships`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountEvents` | [`RelationshipLinks`](../../doc/models/relationship-links.md) | Optional | - |
| `MasterAccount` | [`RelationshipLinks`](../../doc/models/relationship-links.md) | Optional | - |

## Example (as JSON)

```json
{
  "account_events": {
    "data": [
      {
        "id": "00001c2a-0000-0000-0000-000000000000",
        "type": "type0"
      },
      {
        "id": "00001c2a-0000-0000-0000-000000000000",
        "type": "type0"
      }
    ]
  },
  "master_account": {
    "data": [
      {
        "id": "00001c2a-0000-0000-0000-000000000000",
        "type": "type0"
      },
      {
        "id": "00001c2a-0000-0000-0000-000000000000",
        "type": "type0"
      }
    ]
  }
}
```

