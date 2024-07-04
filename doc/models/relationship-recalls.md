
# Relationship Recalls

## Structure

`RelationshipRecalls`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<Recall>`](../../doc/models/recall.md) | Optional | - |

## Example (as JSON)

```json
{
  "data": [
    {
      "attributes": {
        "reason": "reason0",
        "reason_code": "reason_code8",
        "status": "confirmed"
      },
      "created_on": "2016-03-13T12:52:32.123Z",
      "id": "00001c2a-0000-0000-0000-000000000000",
      "modified_on": "2016-03-13T12:52:32.123Z",
      "organisation_id": "00000b24-0000-0000-0000-000000000000",
      "relationships": {
        "payment": {
          "data": [
            {
              "id": "00001c2a-0000-0000-0000-000000000000",
              "type": "type0"
            },
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
        "recall_admission": {
          "data": [
            {
              "id": "00001c2a-0000-0000-0000-000000000000",
              "type": "type0"
            }
          ]
        },
        "recall_decisions": {
          "data": [
            {
              "id": "00001c2a-0000-0000-0000-000000000000",
              "type": "type0"
            },
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
        "recall_reversal": {
          "data": [
            {
              "id": "00001c2a-0000-0000-0000-000000000000",
              "type": "type0"
            }
          ]
        },
        "recall_submission": {
          "data": [
            {
              "id": "00001c2a-0000-0000-0000-000000000000",
              "type": "type0"
            },
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
      },
      "type": "type0"
    }
  ]
}
```

