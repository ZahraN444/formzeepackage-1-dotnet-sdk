
# Branch Amendment

## Structure

`BranchAmendment`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`BranchUpdate`](../../doc/models/branch-update.md) | Optional | - |

## Example (as JSON)

```json
{
  "data": {
    "attributes": {
      "acceptance_qualifier": "some_other_time",
      "reference_mask": "reference_mask4",
      "user_defined_data": [
        {
          "key": "key6",
          "value": "value8"
        },
        {
          "key": "key6",
          "value": "value8"
        }
      ],
      "validation_type": "account_mod_check"
    },
    "id": "00001c2a-0000-0000-0000-000000000000",
    "organisation_id": "00000b24-0000-0000-0000-000000000000",
    "type": "type0",
    "version": 110
  }
}
```

