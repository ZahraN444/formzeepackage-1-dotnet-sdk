
# Query Response Attributes

## Structure

`QueryResponseAttributes`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Answer` | [`QueryResponseAnswerEnum`](../../doc/models/query-response-answer-enum.md) | Required | - |
| `Charges` | [`QueryResponseCharges`](../../doc/models/query-response-charges.md) | Optional | - |
| `Compensation` | [`QueryResponseCompensation`](../../doc/models/query-response-compensation.md) | Optional | - |
| `CompensationAmount` | `string` | Optional | - |
| `Currency` | `string` | Optional | - |
| `Information` | [`QueryResponseInformation`](../../doc/models/query-response-information.md) | Optional | - |
| `StatusCode` | [`QueryResponseStatusCodeEnum?`](../../doc/models/query-response-status-code-enum.md) | Optional | - |

## Example (as JSON)

```json
{
  "answer": "modified_as_requested",
  "charges": {
    "account_number": "account_number4",
    "account_number_code": "account_number_code6",
    "amount": "amount8",
    "currency": "currency6"
  },
  "compensation": {
    "account_number": "account_number2",
    "account_number_code": "account_number_code4",
    "amount": "amount0",
    "currency": "currency2"
  },
  "compensation_amount": "compensation_amount2",
  "currency": "currency0",
  "information": {
    "beneficiary_party": {
      "account_number": "account_number8",
      "account_number_code": "IBAN",
      "account_proxy": {
        "proxy": "proxy4",
        "proxy_id": "proxy_id4",
        "proxy_id_code": "proxy_id_code4"
      },
      "account_with": {
        "bank_id": "bank_id2",
        "bank_id_code": "bank_id_code0",
        "bank_name": "bank_name4"
      },
      "additional_address_line": "additional_address_line4"
    },
    "correction_transaction_information": {
      "amount": "amount4",
      "currency": "currency2",
      "end_to_end_reference": "end_to_end_reference2",
      "instruction_id": "instruction_id6",
      "processing_date": "2016-03-13"
    },
    "debtor_party": {
      "account_number": "account_number4",
      "account_number_code": "IBAN",
      "account_proxy": {
        "proxy": "proxy4",
        "proxy_id": "proxy_id4",
        "proxy_id_code": "proxy_id_code4"
      },
      "account_with": {
        "bank_id": "bank_id2",
        "bank_id_code": "bank_id_code0",
        "bank_name": "bank_name4"
      },
      "additional_address_line": "additional_address_line6"
    },
    "duplicate_transaction_information": {
      "end_to_end_reference": "end_to_end_reference0",
      "references": [
        {
          "type": "type8",
          "value": "value4"
        }
      ],
      "scheme_transaction_id": "scheme_transaction_id6"
    },
    "payment_type_information": {
      "amount": "amount0",
      "category_purpose": "category_purpose2",
      "currency": "currency8",
      "payment_purpose": "payment_purpose4",
      "processing_date": "2016-03-13"
    }
  }
}
```

