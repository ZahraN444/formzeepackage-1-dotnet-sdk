
# Relationships Payment Recall Submission Properties

## Structure

`RelationshipsPaymentRecallSubmissionProperties`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid` | Required | The payment recall submission associated with this query |
| `Type` | `string` | Required, Constant | **Default**: `"recall_submissions"` |

## Example (as JSON)

```json
{
  "id": "00001382-0000-0000-0000-000000000000",
  "type": "recall_submissions"
}
```

