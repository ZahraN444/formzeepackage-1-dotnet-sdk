
# Request for Information Agent

## Structure

`RequestForInformationAgent`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Identification` | [`Identification1`](../../doc/models/identification-1.md) | Optional | - |
| `Role` | `string` | Optional | - |

## Example (as JSON)

```json
{
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
  "role": "role0"
}
```

