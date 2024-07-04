
# Payment Submission Task Amendment

## Structure

`PaymentSubmissionTaskAmendment`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`PaymentSubmissionTaskUpdate`](../../doc/models/payment-submission-task-update.md) | Optional | - |

## Example (as JSON)

```json
{
  "data": {
    "attributes": {
      "output": {
        "key0": {
          "key1": "val1",
          "key2": "val2"
        },
        "key1": {
          "key1": "val1",
          "key2": "val2"
        },
        "key2": {
          "key1": "val1",
          "key2": "val2"
        }
      },
      "status": "pending"
    },
    "id": "00001c2a-0000-0000-0000-000000000000",
    "organisation_id": "00000b24-0000-0000-0000-000000000000",
    "type": "payment_submission_tasks",
    "version": 110
  }
}
```

