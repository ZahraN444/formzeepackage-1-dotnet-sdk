
# Branch Creation

## Structure

`BranchCreation`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`Branch`](../../doc/models/branch.md) | Required | - |

## Example (as JSON)

```json
{
  "data": {
    "attributes": {
      "bank_id": "400300",
      "bank_id_code": "GBDSC",
      "reference_mask": "4929############",
      "acceptance_qualifier": "some_other_time",
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
    "id": "7826c3cb-d6fd-41d0-b187-dc23ba928772",
    "organisation_id": "ee2fb143-6dfe-4787-b183-ca8ddd4164d2",
    "type": "branches",
    "version": 0,
    "created_on": "2016-03-13T12:52:32.123Z",
    "modified_on": "2016-03-13T12:52:32.123Z"
  }
}
```

