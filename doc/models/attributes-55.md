
# Attributes 55

## Structure

`Attributes55`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Limit` | `string` | Optional | Current limit<br>**Constraints**: *Pattern*: `^[0-9.]{0,20}$` |
| `Position` | `string` | Optional | Current position<br>**Constraints**: *Pattern*: `^[0-9.]{0,20}$` |
| `Scheme` | `string` | Optional | Scheme associated with the limit<br>**Constraints**: *Pattern*: `^[A-Za-z_\-]*$` |

## Example (as JSON)

```json
{
  "limit": "1000",
  "position": "10",
  "scheme": "FPS"
}
```

