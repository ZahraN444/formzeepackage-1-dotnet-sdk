
# Header

## Structure

`Header`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Destination` | `string` | Optional | Destination SWIFT logical terminal address. Complete 12-character SWIFT destination, including BIC (x8), logical terminal code (x1) and branch code (x). |
| `MessageType` | `string` | Optional | The message type of the SWIFT payment, has to match `[A-Z]{2}[0-9]{3}`. Currently `MT103` is the only supported value |
| `Priority` | `string` | Optional | SWIFT priority. Either `Normal` or `Priority`. |
| `Recipient` | `string` | Optional | The destination SWIFT BIC for SWIFT MT messages being sent by Form3 client to SWIFT. Formatted as BIC8 or BIC11. |
| `Source` | `string` | Optional | The source SWIFT BIC for SWIFT MT messages being received by Form3 client from SWIFT. Formatted as BIC8 or BIC11. |
| `UserReference` | `string` | Optional | Message User Reference (MUR) value, which can be up to 16 characters, and will be returned in the ACK |

## Example (as JSON)

```json
{
  "destination": "MIDLGB22XABC",
  "message_type": "MT103",
  "priority": "Priority",
  "recipient": "recipient4",
  "source": "source8"
}
```

