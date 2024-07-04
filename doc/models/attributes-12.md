
# Attributes 12

## Structure

`Attributes12`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Assignee` | [`ReturnSubmissionTaskAssigneeEnum?`](../../doc/models/return-submission-task-assignee-enum.md) | Optional | Helps to identify the owner of the task |
| `Input` | `object` | Optional | Key Value map that contains additional data for executing the task. |
| `Name` | `string` | Optional | Identifies the return submission task to be executed |
| `Output` | `object` | Optional | Key Value map that contains the Task result. |
| `Status` | [`ReturnSubmissionTaskStatusEnum?`](../../doc/models/return-submission-task-status-enum.md) | Optional | status of the return submission task |

## Example (as JSON)

```json
{
  "assignee": "form3",
  "input": {
    "status_reason": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "name": "return_validation",
  "output": {
    "outcome": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "status": "completed"
}
```

