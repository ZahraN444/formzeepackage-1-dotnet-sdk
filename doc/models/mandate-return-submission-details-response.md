
# Mandate Return Submission Details Response

## Structure

`MandateReturnSubmissionDetailsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`MandateReturnSubmission`](../../doc/models/mandate-return-submission.md) | Optional | - |
| `Links` | [`Links`](../../doc/models/links.md) | Optional | - |

## Example (as JSON)

```json
{
  "data": {
    "attributes": {
      "status": "delivery_confirmed",
      "status_reason": "status_reason6",
      "submission_datetime": "2016-03-13T12:52:32.123Z",
      "transaction_start_datetime": "2016-03-13T12:52:32.123Z"
    },
    "created_on": "2016-03-13T12:52:32.123Z",
    "id": "00001c2a-0000-0000-0000-000000000000",
    "modified_on": "2016-03-13T12:52:32.123Z",
    "organisation_id": "00000b24-0000-0000-0000-000000000000"
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

