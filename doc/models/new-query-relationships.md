
# New Query Relationships

## Structure

`NewQueryRelationships`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Payment` | [`RelationshipsPayment`](../../doc/models/relationships-payment.md) | Optional | - |
| `PaymentAdmission` | [`RelationshipsPaymentAdmission`](../../doc/models/relationships-payment-admission.md) | Optional | - |
| `PaymentSubmission` | [`RelationshipsPaymentSubmission`](../../doc/models/relationships-payment-submission.md) | Optional | - |
| `Query` | [`RelationshipsQuery`](../../doc/models/relationships-query.md) | Optional | - |
| `Recall` | [`RelationshipsPaymentRecall`](../../doc/models/relationships-payment-recall.md) | Optional | - |
| `RecallSubmission` | [`RelationshipsPaymentRecallSubmission`](../../doc/models/relationships-payment-recall-submission.md) | Optional | - |

## Example (as JSON)

```json
{
  "payment": {
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
  "payment_admission": {
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
  "payment_submission": {
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
  "query": {
    "data": [
      {
        "id": "00001c2a-0000-0000-0000-000000000000",
        "type": "type0"
      }
    ]
  },
  "recall": {
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
  }
}
```

