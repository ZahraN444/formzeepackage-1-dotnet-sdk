
# Attributes 17

## Structure

`Attributes17`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Assignee` | [`PaymentSubmissionTaskAssigneeEnum?`](../../doc/models/payment-submission-task-assignee-enum.md) | Optional | Helps to identify the owner of the task |
| `Name` | `string` | Optional | Identifies the payment submission task to be executed |
| `Output` | `object` | Optional | Key Value map that contains the Task result. |
| `Status` | [`PaymentSubmissionTaskStatusEnum?`](../../doc/models/payment-submission-task-status-enum.md) | Optional | status of the submission task |

## Example (as JSON)

```json
{
  "assignee": "form3",
  "name": "fraud_check",
  "output": {
    "outcome": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "status": "completed"
}
```

