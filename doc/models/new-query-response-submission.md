
# New Query Response Submission

## Structure

`NewQueryResponseSubmission`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Attributes` | [`Attributes50`](../../doc/models/attributes-50.md) | Optional | - |
| `Id` | `Guid` | Required | - |
| `OrganisationId` | `Guid` | Required | - |
| `Type` | `string` | Required, Constant | **Default**: `"query_response_submissions"` |

## Example (as JSON)

```json
{
  "id": "00001b3a-0000-0000-0000-000000000000",
  "organisation_id": "00000a34-0000-0000-0000-000000000000",
  "type": "query_response_submissions",
  "attributes": {
    "auto": false
  }
}
```

