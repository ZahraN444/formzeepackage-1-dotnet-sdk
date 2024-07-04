
# Account Event Attributes

## Structure

`AccountEventAttributes`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountId` | `Guid` | Required | ID of the account this event relates to |
| `DateTime` | `DateTime` | Required | - |
| `Description` | [`DescriptionEnum?`](../../doc/models/description-enum.md) | Optional | Contains the event description |
| `Reason` | `string` | Optional | Failure reason. Should only be present when description is failed |
| `RoutingStatus` | [`RoutingStatusEnum`](../../doc/models/routing-status-enum.md) | Required | Contains the routing status |
| `Status` | [`Status2Enum`](../../doc/models/status-2-enum.md) | Required | Contains the event status |

## Example (as JSON)

```json
{
  "account_id": "cfc09fb8-bbca-40bd-a518-6e58d8a9c7f4",
  "date_time": "2016-03-13T12:52:32.123Z",
  "description": "confirmed",
  "reason": "Invalid BIC",
  "routing_status": "routable",
  "status": "confirmed"
}
```

