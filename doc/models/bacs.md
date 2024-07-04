
# BACS

## Structure

`BACS`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AcceptsPayments` | `bool?` | Optional | **Default**: `false` |
| `AccountSwitching` | [`AccountSwitchingEnum?`](../../doc/models/account-switching-enum.md) | Optional | - |
| `AllowedTransactions` | [`List<TransactionGroupCodeEnum>`](../../doc/models/transaction-group-code-enum.md) | Optional | - |
| `ServiceStatus` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "accepts_payments": false,
  "account_switching": "ineligible",
  "allowed_transactions": [
    "CU",
    "BS",
    "DV"
  ],
  "service_status": "service_status6"
}
```

