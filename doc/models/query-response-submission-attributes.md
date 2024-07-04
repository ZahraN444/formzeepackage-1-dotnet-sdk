
# Query Response Submission Attributes

## Structure

`QueryResponseSubmissionAttributes`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Auto` | `bool?` | Optional | - |
| `Status` | [`QueryResponseSubmissionStatusEnum?`](../../doc/models/query-response-submission-status-enum.md) | Optional | - |
| `StatusReason` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "auto": false,
  "status": "queued_for_delivery",
  "status_reason": "status_reason0"
}
```

