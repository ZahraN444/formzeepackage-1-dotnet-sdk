
# Recall Decision Details Response

## Structure

`RecallDecisionDetailsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`RecallDecision`](../../doc/models/recall-decision.md) | Optional | - |
| `Links` | [`Links`](../../doc/models/links.md) | Optional | - |

## Example (as JSON)

```json
{
  "data": {
    "attributes": {
      "agents": [
        {
          "account_number": "account_number0",
          "account_number_code": "IBAN",
          "address": [
            "address4",
            "address5"
          ],
          "identification": {
            "bank_id": "bank_id4",
            "bank_id_code": "bank_id_code2",
            "bank_ids": [
              {
                "bank_id": "bank_id4",
                "bank_id_code": "bank_id_code8"
              },
              {
                "bank_id": "bank_id4",
                "bank_id_code": "bank_id_code8"
              },
              {
                "bank_id": "bank_id4",
                "bank_id_code": "bank_id_code8"
              }
            ]
          },
          "name": "name0"
        },
        {
          "account_number": "account_number0",
          "account_number_code": "IBAN",
          "address": [
            "address4",
            "address5"
          ],
          "identification": {
            "bank_id": "bank_id4",
            "bank_id_code": "bank_id_code2",
            "bank_ids": [
              {
                "bank_id": "bank_id4",
                "bank_id_code": "bank_id_code8"
              },
              {
                "bank_id": "bank_id4",
                "bank_id_code": "bank_id_code8"
              },
              {
                "bank_id": "bank_id4",
                "bank_id_code": "bank_id_code8"
              }
            ]
          },
          "name": "name0"
        },
        {
          "account_number": "account_number0",
          "account_number_code": "IBAN",
          "address": [
            "address4",
            "address5"
          ],
          "identification": {
            "bank_id": "bank_id4",
            "bank_id_code": "bank_id_code2",
            "bank_ids": [
              {
                "bank_id": "bank_id4",
                "bank_id_code": "bank_id_code8"
              },
              {
                "bank_id": "bank_id4",
                "bank_id_code": "bank_id_code8"
              },
              {
                "bank_id": "bank_id4",
                "bank_id_code": "bank_id_code8"
              }
            ]
          },
          "name": "name0"
        }
      ],
      "answer": "pending",
      "charges_amount": {
        "amount": "amount4",
        "currency": "currency2"
      },
      "reason": "reason0",
      "reason_code": "reason_code8"
    },
    "created_on": "2016-03-13T12:52:32.123Z",
    "id": "00001c2a-0000-0000-0000-000000000000",
    "modified_on": "2016-03-13T12:52:32.123Z",
    "organisation_id": "00000b24-0000-0000-0000-000000000000",
    "relationships": {
      "decision_admission": {
        "data": [
          {
            "id": "00001c2a-0000-0000-0000-000000000000",
            "type": "type0"
          }
        ]
      },
      "decision_submission": {
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
    },
    "type": "type0"
  },
  "links": {
    "first": "first0",
    "last": "last4",
    "next": "next2",
    "prev": "prev8",
    "self": "self2"
  }
}
```

