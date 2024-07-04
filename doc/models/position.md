
# Position

## Structure

`Position`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Attributes` | [`Attributes55`](../../doc/models/attributes-55.md) | Required | - |
| `Id` | `Guid` | Required | Unique resource ID |
| `Links` | [`Self`](../../doc/models/self.md) | Optional | - |
| `OrganisationId` | `Guid` | Required | Unique ID of the organisation this resource is created by |
| `Type` | `string` | Optional | Name of the resource type<br>**Constraints**: *Pattern*: `^[A-Za-z_]*$` |
| `Version` | `int?` | Optional | Version number<br>**Constraints**: `>= 0` |

## Example (as JSON)

```json
{
  "attributes": {
    "limit": "1000",
    "position": "10",
    "scheme": "FPS"
  },
  "id": "7826c3cb-d6fd-41d0-b187-dc23ba928772",
  "organisation_id": "ee2fb143-6dfe-4787-b183-ca8ddd4164d2",
  "type": "positions",
  "version": 0,
  "links": {
    "self": "self2"
  }
}
```
