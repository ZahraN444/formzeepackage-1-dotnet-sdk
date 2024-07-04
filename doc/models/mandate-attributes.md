
# Mandate Attributes

## Structure

`MandateAttributes`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | `string` | Optional | **Constraints**: *Pattern*: `^[0-9.]{0,20}$` |
| `BeneficiaryParty` | [`MandateAttributesBeneficiaryParty`](../../doc/models/mandate-attributes-beneficiary-party.md) | Optional | - |
| `ClearingId` | `string` | Optional | - |
| `Currency` | `string` | Optional | - |
| `DebtorParty` | [`MandateAttributesDebtorParty`](../../doc/models/mandate-attributes-debtor-party.md) | Optional | - |
| `Frequency` | [`MandateFrequencyEnum?`](../../doc/models/mandate-frequency-enum.md) | Optional | - |
| `NumericReference` | `string` | Optional | - |
| `PaymentScheme` | `string` | Optional | - |
| `ProcessingDate` | `DateTime?` | Optional | - |
| `Reference` | `string` | Optional | - |
| `SchemePaymentType` | `string` | Optional | - |
| `SchemeProcessingDate` | `DateTime?` | Optional | - |
| `Source` | `string` | Optional | - |
| `Status` | [`MandateStatusEnum?`](../../doc/models/mandate-status-enum.md) | Optional | - |
| `StatusReason` | `string` | Optional | - |
| `UniqueSchemeId` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "amount": "amount2",
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
  "clearing_id": "clearing_id2",
  "currency": "currency0",
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
}
```

