
# Attributes 2

## Structure

`Attributes2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Action` | `string` | Optional | Action that this ACE controls |
| `Filter` | `string` | Optional | - |
| `RecordType` | `string` | Optional | Type of record that this ACE gives access to |
| `RoleId` | `Guid?` | Optional | Role ID of the role that this ACE belongs to |

## Example (as JSON)

```json
{
  "action": "CREATE",
  "record_type": "User",
  "role_id": "813e371b-c16c-4b86-adbf-82bcda159b27",
  "filter": "filter6"
}
```

