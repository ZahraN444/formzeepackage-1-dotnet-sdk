
# Query Beneficiary Debtor Account Proxy

## Structure

`QueryBeneficiaryDebtorAccountProxy`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Proxy` | `string` | Optional | Name of the identification scheme, in a free text form. When used proxy_id_code must not be present.<br>**Constraints**: *Maximum Length*: `35` |
| `ProxyId` | `string` | Optional | Identification used to indicate the account identification under another specified name<br>**Constraints**: *Maximum Length*: `2048` |
| `ProxyIdCode` | `string` | Optional | Name of the identification scheme, in a coded form as published in an external list. When used proxy field must not be present<br>**Constraints**: *Maximum Length*: `4` |

## Example (as JSON)

```json
{
  "proxy": "ID123456",
  "proxy_id": "07495845323",
  "proxy_id_code": "MBNO"
}
```

