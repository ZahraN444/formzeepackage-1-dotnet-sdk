
# Relationships Query Submission Properties

## Structure

`RelationshipsQuerySubmissionProperties`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid` | Required | The query submission associated with this query |
| `Type` | `string` | Required, Constant | **Default**: `"query_submissions"` |

## Example (as JSON)

```json
{
  "id": "000021d6-0000-0000-0000-000000000000",
  "type": "query_submissions"
}
```

