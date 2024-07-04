
# Swift

## Structure

`Swift`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BankOperationCode` | `string` | Optional | SWIFT service level |
| `Header` | [`Header`](../../doc/models/header.md) | Optional | - |
| `InstructionCode` | `string` | Optional | A SWIFT instruction code |
| `SenderReceiverInformation` | `string` | Optional | This field specifies additional information for the Receiver or other party specified. |
| `TimeIndication` | `string` | Optional | This repetitive field specifies one or several time indication(s) related to the processing of the payment instruction. |

## Example (as JSON)

```json
{
  "bank_operation_code": "CRED",
  "instruction_code": "INTC",
  "sender_receiver_information": "/INS/ABNANL2A",
  "time_indication": "/CLSTIME/0915+0200",
  "header": {
    "destination": "destination8",
    "message_type": "message_type2",
    "priority": "priority4",
    "recipient": "recipient8",
    "source": "source2"
  }
}
```

