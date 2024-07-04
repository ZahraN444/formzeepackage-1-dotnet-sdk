
# Mandate Submission

## Structure

`MandateSubmission`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Attributes` | [`Attributes48`](../../doc/models/attributes-48.md) | Optional | - |
| `CreatedOn` | `DateTime?` | Optional | - |
| `Id` | `Guid?` | Optional | - |
| `ModifiedOn` | `DateTime?` | Optional | - |
| `OrganisationId` | `Guid?` | Optional | - |
| `Relationships` | [`MandateSubmissionRelationships`](../../doc/models/mandate-submission-relationships.md) | Optional | - |
| `Type` | `string` | Optional | **Constraints**: *Pattern*: `^[A-Za-z_]*$` |
| `Version` | `int?` | Optional | **Constraints**: `>= 0` |

## Example (as JSON)

```json
{
  "attributes": {
    "file_identifier": "file_identifier6",
    "file_number": "file_number4",
    "last_payment_date": "2016-03-13",
    "original_mandate": {
      "amount": "amount4",
      "beneficiary_party": {
        "account_name": "account_name0",
        "account_number": "account_number8",
        "account_number_code": "IBAN",
        "account_type": 6,
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
      },
      "clearing_id": "clearing_id6",
      "currency": "currency8",
      "debtor_party": {
        "account_name": "account_name2",
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
        },
        "address": [
          "address8"
        ]
      }
    },
    "status": "validation_passed"
  },
  "created_on": "2016-03-13T12:52:32.123Z",
  "id": "000000ba-0000-0000-0000-000000000000",
  "modified_on": "2016-03-13T12:52:32.123Z",
  "organisation_id": "000016c4-0000-0000-0000-000000000000"
}
```

