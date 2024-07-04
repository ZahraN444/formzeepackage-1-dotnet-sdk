
# Query Response Admission Relationships

## Structure

`QueryResponseAdmissionRelationships`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Payment` | [`RelationshipsPayment`](../../doc/models/relationships-payment.md) | Optional | - |
| `Query` | [`RelationshipsQuery`](../../doc/models/relationships-query.md) | Optional | - |
| `QueryResponse` | [`RelationshipsQueryResponse`](../../doc/models/relationships-query-response.md) | Optional | - |
| `Recall` | [`RelationshipsPaymentRecall`](../../doc/models/relationships-payment-recall.md) | Optional | - |

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
  "query": {
    "data": [
      {
        "id": "00001c2a-0000-0000-0000-000000000000",
        "type": "type0"
      }
    ]
  },
  "query_response": {
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

