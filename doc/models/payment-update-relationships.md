
# Payment Update Relationships

## Structure

`PaymentUpdateRelationships`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Beneficiary` | [`Beneficiary`](../../doc/models/beneficiary.md) | Optional | - |
| `BeneficiaryAccount` | [`BeneficiaryAccount`](../../doc/models/beneficiary-account.md) | Optional | - |
| `Debtor` | [`Debtor`](../../doc/models/debtor.md) | Optional | - |
| `DebtorAccount` | [`DebtorAccount`](../../doc/models/debtor-account.md) | Optional | - |
| `ForwardingPayment` | [`ForwardingPayment1`](../../doc/models/forwarding-payment-1.md) | Optional | - |
| `FxDeal` | [`FxDeal`](../../doc/models/fx-deal.md) | Optional | - |
| `PaymentAdmission` | [`PaymentAdmission2`](../../doc/models/payment-admission-2.md) | Optional | - |
| `PaymentAdvice` | [`PaymentAdvice1`](../../doc/models/payment-advice-1.md) | Optional | - |
| `PaymentRecall` | [`PaymentRecall`](../../doc/models/payment-recall.md) | Optional | - |
| `PaymentReturn` | [`PaymentReturn`](../../doc/models/payment-return.md) | Optional | - |
| `PaymentReversal` | [`PaymentReversal`](../../doc/models/payment-reversal.md) | Optional | - |
| `PaymentSubmission` | [`PaymentSubmission2`](../../doc/models/payment-submission-2.md) | Optional | - |

## Example (as JSON)

```json
{
  "beneficiary": {
    "data": [
      {
        "id": "00001c2a-0000-0000-0000-000000000000",
        "type": "type0"
      },
      {
        "id": "00001c2a-0000-0000-0000-000000000000",
        "type": "type0"
      },
      {
        "id": "00001c2a-0000-0000-0000-000000000000",
        "type": "type0"
      }
    ]
  },
  "beneficiary_account": {
    "data": [
      {
        "id": "00001c2a-0000-0000-0000-000000000000",
        "type": "type0"
      },
      {
        "id": "00001c2a-0000-0000-0000-000000000000",
        "type": "type0"
      },
      {
        "id": "00001c2a-0000-0000-0000-000000000000",
        "type": "type0"
      }
    ]
  },
  "debtor": {
    "data": [
      {
        "id": "00001c2a-0000-0000-0000-000000000000",
        "type": "type0"
      },
      {
        "id": "00001c2a-0000-0000-0000-000000000000",
        "type": "type0"
      }
    ]
  },
  "debtor_account": {
    "data": [
      {
        "id": "00001c2a-0000-0000-0000-000000000000",
        "type": "type0"
      },
      {
        "id": "00001c2a-0000-0000-0000-000000000000",
        "type": "type0"
      },
      {
        "id": "00001c2a-0000-0000-0000-000000000000",
        "type": "type0"
      }
    ]
  },
  "forwarding_payment": {
    "data": [
      {
        "id": "00001c2a-0000-0000-0000-000000000000",
        "type": "type0"
      },
      {
        "id": "00001c2a-0000-0000-0000-000000000000",
        "type": "type0"
      }
    ]
  }
}
```

