
# Attributes 31

## Structure

`Attributes31`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ChargesAmount` | [`CurrencyAndAmount`](../../doc/models/currency-and-amount.md) | Optional | - |
| `ClearingId` | `string` | Optional | Unique identifier for organisations collecting payments |
| `CompensationAmount` | [`CurrencyAndAmount`](../../doc/models/currency-and-amount.md) | Optional | - |
| `ProcessingDate` | `DateTime?` | Optional | Date on which the operation is to be debited from the debtor account. Formatted according to ISO 8601 format: YYYY-MM-DD. |
| `ReturnAmount` | [`CurrencyAndAmount`](../../doc/models/currency-and-amount.md) | Optional | - |
| `ReturnCode` | `string` | Optional | - |
| `ReturnInitiator` | [`ReturnInitiatorEnum?`](../../doc/models/return-initiator-enum.md) | Optional | - |
| `SchemeProcessingDate` | `DateTime?` | Optional | Date on which the operation is processed by the scheme. Formatted according to ISO 8601 format: YYYY-MM-DD. Only used if different from `processing_date`. |
| `SchemeTransactionId` | `string` | Optional | - |
| `Settlement` | [`Settlement`](../../doc/models/settlement.md) | Optional | Specifies the details on how the settlement of the transaction between the instructing agent and the instructed agent is completed |

## Example (as JSON)

```json
{
  "clearing_id": "123456",
  "processing_date": "2015-02-12",
  "scheme_processing_date": "2015-02-12",
  "charges_amount": {
    "amount": "amount4",
    "currency": "currency2"
  },
  "compensation_amount": {
    "amount": "amount4",
    "currency": "currency2"
  },
  "return_amount": {
    "amount": "amount6",
    "currency": "currency4"
  }
}
```

