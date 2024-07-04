
# Relationship Query Response Admission

## Structure

`RelationshipQueryResponseAdmission`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<QueryResponseAdmission>`](../../doc/models/query-response-admission.md) | Optional | - |

## Example (as JSON)

```json
{
  "data": [
    {
      "attributes": {
        "status": "failed",
        "status_reason": "status_reason6"
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
        "query": {
          "data": [
            {
              "id": "00001c2a-0000-0000-0000-000000000000",
              "type": "type0"
            }
          ]
        },
        "query_response": {
          "data": [
            {
              "id": "00001c2a-0000-0000-0000-000000000000",
              "type": "type0"
            }
          ]
        },
        "recall": {
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
      "type": "type0",
      "version": 110
    },
    {
      "attributes": {
        "status": "failed",
        "status_reason": "status_reason6"
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
        "query": {
          "data": [
            {
              "id": "00001c2a-0000-0000-0000-000000000000",
              "type": "type0"
            }
          ]
        },
        "query_response": {
          "data": [
            {
              "id": "00001c2a-0000-0000-0000-000000000000",
              "type": "type0"
            }
          ]
        },
        "recall": {
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
      "type": "type0",
      "version": 110
    }
  ]
}
```

