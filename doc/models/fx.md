
# Fx

## Structure

`Fx`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ContractReference` | `string` | Optional | Reference to the foreign exchange contract associated with the transaction |
| `ExchangeRate` | `string` | Optional | Factor used to convert an amount from the instructed currency into the transaction currency: i.e. to convert the `fx.original_amount`, expressed in the `fx.original_currency`, to `amount` specified in `currency`. Decimal value, represented as a string, maximum length 12. Must be > 0. |
| `OriginalAmount` | `string` | Optional | Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as instructed by the initiating party. Decimal value. Must be > 0. |
| `OriginalCurrency` | `string` | Optional | Currency of `original_amount`. Currency code as defined in ISO 4217. |

## Example (as JSON)

```json
{
  "contract_reference": "FXCONTRACT/REF/123567",
  "exchange_rate": "0.13343",
  "original_amount": "100.00",
  "original_currency": "EUR"
}
```

