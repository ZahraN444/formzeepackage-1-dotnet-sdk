
# Mandate Return

## Structure

`MandateReturn`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Attributes` | [`Attributes46`](../../doc/models/attributes-46.md) | Optional | - |
| `CreatedOn` | `DateTime?` | Optional | - |
| `Id` | `Guid?` | Optional | - |
| `ModifiedOn` | `DateTime?` | Optional | - |
| `OrganisationId` | `Guid?` | Optional | - |
| `Relationships` | [`Relationships17`](../../doc/models/relationships-17.md) | Optional | - |
| `Type` | `string` | Optional | **Constraints**: *Pattern*: `^[A-Za-z_]*$` |
| `Version` | `int?` | Optional | **Constraints**: `>= 0` |

## Example (as JSON)

```json
{
  "attributes": {
    "debtor_party": {
      "new_bank_details": {
        "account_number": "account_number4",
        "account_number_code": "IBAN",
        "account_with": {
          "bank_address": [
            "bank_address4",
            "bank_address3",
            "bank_address2"
          ],
          "bank_id": "bank_id2",
          "bank_id_code": "PLKNR",
          "bank_ids": [
            {
              "bank_id": "bank_id4",
              "bank_id_code": "bank_id_code8"
            },
            {
              "bank_id": "bank_id4",
              "bank_id_code": "bank_id_code8"
            }
          ],
          "bank_name": "bank_name4",
          "bank_party_id": "bank_party_id6"
        }
      }
    },
    "return_code": "return_code4"
  },
  "created_on": "2016-03-13T12:52:32.123Z",
  "id": "000007c4-0000-0000-0000-000000000000",
  "modified_on": "2016-03-13T12:52:32.123Z",
  "organisation_id": "00001dce-0000-0000-0000-000000000000"
}
```

