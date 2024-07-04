
# Query Submission Response

## Structure

`QuerySubmissionResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`QuerySubmission`](../../doc/models/query-submission.md) | Required | - |
| `Links` | [`Links`](../../doc/models/links.md) | Optional | - |

## Example (as JSON)

```json
{
  "data": {
    "attributes": {
      "status": "submitted",
      "status_reason": "status_reason6"
    },
    "id": "00001c2a-0000-0000-0000-000000000000",
    "organisation_id": "00000b24-0000-0000-0000-000000000000",
    "type": "query_submissions",
    "version": 110,
    "created_on": "2016-03-13T12:52:32.123Z",
    "modified_on": "2016-03-13T12:52:32.123Z",
    "relationships": {
      "query": {
        "data": [
          {
            "id": "00001c2a-0000-0000-0000-000000000000",
            "type": "type0"
          }
        ]
      }
    }
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

