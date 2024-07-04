
# Forwarded Payment

## Structure

`ForwardedPayment`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<RelationshipData>`](../../doc/models/relationship-data.md) | Optional | Array of Inbound Payments that triggered the creation of this Forwarding Payment. |

## Example (as JSON)

```json
{
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
```

