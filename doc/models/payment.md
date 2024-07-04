
# Payment

## Structure

`Payment`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Attributes` | [`PaymentAttributes`](../../doc/models/payment-attributes.md) | Required | - |
| `CreatedOn` | `DateTime?` | Optional | - |
| `Id` | `Guid` | Required | Unique resource ID |
| `ModifiedOn` | `DateTime?` | Optional | - |
| `OrganisationId` | `Guid` | Required | Unique ID of the organisation this resource is created by |
| `Relationships` | [`PaymentRelationships`](../../doc/models/payment-relationships.md) | Optional | - |
| `Type` | `string` | Optional | Name of the resource type<br>**Constraints**: *Pattern*: `^[A-Za-z_]*$` |
| `Version` | `int?` | Optional | Version number<br>**Constraints**: `>= 0` |

## Example (as JSON)

```json
{
  "attributes": {
    "amount": "10.00",
    "currency": "EUR",
    "end_to_end_reference": "PAYMENT REF: 20094",
    "instruction_id": "ID1245799",
    "payment_acceptance_datetime": "09/30/2017 12:36:02",
    "payment_purpose": "X",
    "payment_scheme": "FPS",
    "processing_date": "2015-02-12",
    "reference": "rent for oct",
    "regulatory_reporting": "May be required for some foreign originated payments",
    "remittance_information": "Additional remittance information over and above reference information",
    "scheme_payment_sub_type": "TelephoneBanking",
    "scheme_payment_type": "ImmediatePayment",
    "scheme_processing_date": "2015-02-12",
    "scheme_transaction_id": "123456789012345678",
    "unique_scheme_id": "L5W48NDWYW7JV9MRO71020180301826040011",
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
    "batch_booking_indicator": "batch_booking_indicator2",
    "batch_id": "batch_id6",
    "batch_type": "batch_type0"
  },
  "id": "7826c3cb-d6fd-41d0-b187-dc23ba928772",
  "organisation_id": "ee2fb143-6dfe-4787-b183-ca8ddd4164d2",
  "type": "payments",
  "version": 0,
  "created_on": "2016-03-13T12:52:32.123Z",
  "modified_on": "2016-03-13T12:52:32.123Z",
  "relationships": {
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
    "forwarded_payment": {
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
}
```

