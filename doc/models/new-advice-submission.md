
# New Advice Submission

## Structure

`NewAdviceSubmission`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid` | Required | - |
| `OrganisationId` | `Guid` | Required | - |
| `Type` | `string` | Optional | **Constraints**: *Pattern*: `^[A-Za-z_]*$` |
| `Version` | `int?` | Optional | **Constraints**: `>= 0` |

## Example (as JSON)

```json
{
  "id": "0000234e-0000-0000-0000-000000000000",
  "organisation_id": "00001248-0000-0000-0000-000000000000",
  "type": "type2",
  "version": 82
}
```

