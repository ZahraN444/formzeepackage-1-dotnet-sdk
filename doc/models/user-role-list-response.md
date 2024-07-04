
# User Role List Response

## Structure

`UserRoleListResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<Role>`](../../doc/models/role.md) | Required | - |
| `Links` | [`Links`](../../doc/models/links.md) | Optional | - |

## Example (as JSON)

```json
{
  "data": [
    {
      "id": "7826c3cb-d6fd-41d0-b187-dc23ba928772",
      "organisation_id": "ee2fb143-6dfe-4787-b183-ca8ddd4164d2",
      "type": "role",
      "version": 0,
      "attributes": {
        "name": "name4",
        "parent_role_id": "00000bf4-0000-0000-0000-000000000000"
      }
    }
  ],
  "links": {
    "first": "first0",
    "last": "last4",
    "next": "next2",
    "prev": "prev8",
    "self": "self2"
  }
}
```

