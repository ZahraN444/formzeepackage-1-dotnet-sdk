
# User Creation Response

## Structure

`UserCreationResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`User`](../../doc/models/user.md) | Required | - |
| `Links` | [`Links`](../../doc/models/links.md) | Optional | - |

## Example (as JSON)

```json
{
  "data": {
    "id": "7826c3cb-d6fd-41d0-b187-dc23ba928772",
    "organisation_id": "ee2fb143-6dfe-4787-b183-ca8ddd4164d2",
    "type": "User",
    "version": 0,
    "attributes": {
      "client_credential_ids": [
        "client_credential_ids4",
        "client_credential_ids5",
        "client_credential_ids6"
      ],
      "email": "email2",
      "public_key_ids": [
        "00000304-0000-0000-0000-000000000000",
        "00000305-0000-0000-0000-000000000000"
      ],
      "role_ids": [
        "000007a4-0000-0000-0000-000000000000",
        "000007a5-0000-0000-0000-000000000000"
      ],
      "username": "username4"
    }
  },
  "links": {
    "first": "first0",
    "last": "last4",
    "next": "next2",
    "prev": "prev8",
    "self": "self2"
  }
}
```

