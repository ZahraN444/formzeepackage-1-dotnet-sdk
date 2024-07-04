
# Links

## Structure

`Links`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `First` | `string` | Optional | Link to the first resource in the list |
| `Last` | `string` | Optional | Link to the last resource in the list |
| `Next` | `string` | Optional | Link to the next resource in the list |
| `Prev` | `string` | Optional | Link to the previous resource in the list |
| `Self` | `string` | Required | Link to this resource type |

## Example (as JSON)

```json
{
  "first": "https://api.test.form3.tech/v1/api_name/resource_type",
  "last": "https://api.test.form3.tech/v1/api_name/resource_type",
  "next": "https://api.test.form3.tech/v1/api_name/resource_type",
  "prev": "https://api.test.form3.tech/v1/api_name/resource_type",
  "self": "https://api.test.form3.tech/v1/api_name/resource_type"
}
```

