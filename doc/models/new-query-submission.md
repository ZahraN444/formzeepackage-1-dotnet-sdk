
# New Query Submission

## Structure

`NewQuerySubmission`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid` | Required | - |
| `OrganisationId` | `Guid` | Required | - |
| `Type` | `string` | Required, Constant | **Default**: `"query_submissions"` |

## Example (as JSON)

```json
{
  "id": "00001ea8-0000-0000-0000-000000000000",
  "organisation_id": "00000da2-0000-0000-0000-000000000000",
  "type": "query_submissions"
}
```

