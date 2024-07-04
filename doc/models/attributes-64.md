
# Attributes 64

## Structure

`Attributes64`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Output` | `object` | Optional | Key Value map that contains the Task result. |
| `Status` | [`ReturnSubmissionTaskStatusEnum?`](../../doc/models/return-submission-task-status-enum.md) | Optional | status of the return submission task |

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

