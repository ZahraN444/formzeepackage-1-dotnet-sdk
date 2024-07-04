
# Attributes 54

## Structure

`Attributes54`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Output` | `object` | Optional | Key Value map that contains the Task result. |
| `Status` | [`PaymentSubmissionTaskStatusEnum?`](../../doc/models/payment-submission-task-status-enum.md) | Optional | status of the submission task |

## Example (as JSON)

```json
{
  "output": {
    "outcome": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "status": "completed"
}
```

