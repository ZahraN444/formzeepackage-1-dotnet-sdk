
# Account Creation

## Structure

`AccountCreation`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`Account`](../../doc/models/account.md) | Required | - |

## Example (as JSON)

```json
{
  "data": {
    "attributes": {
      "account_classification": "Personal",
      "account_matching_opt_out": false,
      "account_number": "41426819",
      "bank_id": "400300",
      "bank_id_code": "GBDSC",
      "base_currency": "GBP",
      "bic": "NWBKGB22",
      "country": "GB",
      "customer_id": "12345",
      "iban": "GB11NWBK40030041426819",
      "joint_account": false,
      "name_matching_status": "supported",
      "reference_mask": "4929############",
      "status_reason": "transferred",
      "switched": false,
      "title": "Ms",
      "acceptance_qualifier": "some_other_time",
      "alternative_bank_account_names": [
        "alternative_bank_account_names9"
      ]
    },
    "id": "7826c3cb-d6fd-41d0-b187-dc23ba928772",
    "organisation_id": "ee2fb143-6dfe-4787-b183-ca8ddd4164d2",
    "type": "accounts",
    "version": 0,
    "relationships": {
      "account_events": {
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
      "master_account": {
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
}
```

