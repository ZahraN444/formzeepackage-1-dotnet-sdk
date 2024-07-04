
# Attributes 35

## Structure

`Attributes35`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ChargesAmount` | [`ChargesAmount`](../../doc/models/charges-amount.md) | Optional | Only present when a DirectDebitReversal contains charges. SEPA only |
| `ProcessingDate` | `DateTime?` | Optional | Date on which the operation is to be debited from the debtor account. Formatted according to ISO 8601 format: YYYY-MM-DD. |
| `Reason` | `string` | Optional | Further explanation of the reason given in reason_code. Only evaluated for certain reason codes. |
| `ReasonCode` | `string` | Optional | The reason for the direct debit reversal. Has to be a valid [reversal reason code](http://api-docs.form3.tech/api.html#enumerations-reversal-reason-codes). |
| `ReversalAmount` | [`ReversalAmount`](../../doc/models/reversal-amount.md) | Optional | SEPA only |
| `SchemeProcessingDate` | `DateTime?` | Optional | Date on which the operation is processed by the scheme. Formatted according to ISO 8601 format: YYYY-MM-DD. Only used if different from `processing_date`. |

## Example (as JSON)

```json
{
  "processing_date": "2015-02-12",
  "reason": "Direct debit was a duplicate",
  "reason_code": "AM05",
  "scheme_processing_date": "2015-02-12",
  "charges_amount": {
    "amount": "amount4",
    "currency": "currency2"
  },
  "reversal_amount": {
    "amount": "amount0",
    "currency": "currency8"
  }
}
```

