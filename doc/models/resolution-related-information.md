
# Resolution Related Information

## Structure

`ResolutionRelatedInformation`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ClearingChannel` | [`ClearingChannelEnum?`](../../doc/models/clearing-channel-enum.md) | Optional | Answer to the recall request. Can either be `MPNS`, `RTGS` or `RTNS`. |
| `References` | [`List<Reference>`](../../doc/models/reference.md) | Optional | Block to represent a list of references<br>**Constraints**: *Maximum Items*: `5` |
| `SettlementDate` | `DateTime?` | Optional | Date that the payment will be settled |

## Example (as JSON)

```json
{
  "clearing_channel": "MPNS",
  "settlement_date": "2017-07-23",
  "references": [
    {
      "type": "type8",
      "value": "value4"
    }
  ]
}
```

