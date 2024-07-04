
# Relationships Query Submission

## Structure

`RelationshipsQuerySubmission`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<QuerySubmission>`](../../doc/models/query-submission.md) | Optional | - |

## Example (as JSON)

```json
{
  "data": [
    {
      "attributes": {
        "status": "submitted",
        "status_reason": "status_reason6"
      },
      "created_on": "2016-03-13T12:52:32.123Z",
      "id": "00001c2a-0000-0000-0000-000000000000",
      "modified_on": "2016-03-13T12:52:32.123Z",
      "organisation_id": "00000b24-0000-0000-0000-000000000000",
      "relationships": {
        "query": {
          "data": [
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
        "status": "submitted",
        "status_reason": "status_reason6"
      },
      "created_on": "2016-03-13T12:52:32.123Z",
      "id": "00001c2a-0000-0000-0000-000000000000",
      "modified_on": "2016-03-13T12:52:32.123Z",
      "organisation_id": "00000b24-0000-0000-0000-000000000000",
      "relationships": {
        "query": {
          "data": [
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
        "status": "submitted",
        "status_reason": "status_reason6"
      },
      "created_on": "2016-03-13T12:52:32.123Z",
      "id": "00001c2a-0000-0000-0000-000000000000",
      "modified_on": "2016-03-13T12:52:32.123Z",
      "organisation_id": "00000b24-0000-0000-0000-000000000000",
      "relationships": {
        "query": {
          "data": [
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

