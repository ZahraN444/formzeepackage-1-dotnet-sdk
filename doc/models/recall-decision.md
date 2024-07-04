
# Recall Decision

## Structure

`RecallDecision`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Attributes` | [`Attributes57`](../../doc/models/attributes-57.md) | Optional | - |
| `CreatedOn` | `DateTime?` | Optional | - |
| `Id` | `Guid` | Required | Unique resource ID |
| `ModifiedOn` | `DateTime?` | Optional | - |
| `OrganisationId` | `Guid` | Required | Unique ID of the organisation this resource is created by |
| `Relationships` | [`Relationships20`](../../doc/models/relationships-20.md) | Optional | - |
| `Type` | `string` | Optional | Name of the resource type<br>**Constraints**: *Pattern*: `^[A-Za-z_]*$` |
| `Version` | `int?` | Optional | Version number<br>**Constraints**: `>= 0` |

## Example (as JSON)

```json
{
  "id": "7826c3cb-d6fd-41d0-b187-dc23ba928772",
  "organisation_id": "ee2fb143-6dfe-4787-b183-ca8ddd4164d2",
  "type": "recall_decisions",
  "version": 0,
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
  "modified_on": "2016-03-13T12:52:32.123Z",
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
  }
}
```

