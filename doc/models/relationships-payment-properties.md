
# Relationships Payment Properties

## Structure

`RelationshipsPaymentProperties`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid` | Required | The payment associated with this query |
| `Type` | `string` | Required, Constant | **Default**: `"payments"` |

## Example (as JSON)

```json
{
  "id": "00001186-0000-0000-0000-000000000000",
  "type": "payments"
}
```

