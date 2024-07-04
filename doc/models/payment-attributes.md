
# Payment Attributes

## Structure

`PaymentAttributes`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Agents` | [`List<Agent>`](../../doc/models/agent.md) | Optional | Block to represent a Financial Institution/agent in the payment chain |
| `Amount` | `string` | Optional | Amount of money moved between the instructing agent and instructed agent<br>**Constraints**: *Pattern*: `^[0-9.]{0,20}$` |
| `BatchBookingIndicator` | `string` | Optional | - |
| `BatchId` | `string` | Optional | - |
| `BatchType` | `string` | Optional | - |
| `BeneficiaryParty` | [`BeneficiaryParty1`](../../doc/models/beneficiary-party-1.md) | Optional | - |
| `CategoryPurpose` | `string` | Optional | Category purpose in proprietary form. Specifies the high level purpose of the instruction. Cannot be used at the same time as `category_purpose_coded`. |
| `CategoryPurposeCoded` | `string` | Optional | Category purpose in a coded form. Specifies the high level purpose of the instruction. Cannot be used at the same time as `category_purpose`. |
| `ChargesInformation` | [`ChargesInformation`](../../doc/models/charges-information.md) | Optional | - |
| `ClearingId` | `string` | Optional | Unique identifier for organisations collecting payments |
| `Currency` | `string` | Optional | Currency of the transaction amount. Currency code as defined in [ISO 4217](http://www.iso.org/iso/home/standards/currency_codes.htm) |
| `DebtorParty` | [`DebtorParty`](../../doc/models/debtor-party.md) | Optional | - |
| `EndToEndReference` | `string` | Optional | Unique identification, as assigned by the initiating party, to unambiguously identify the transaction. This identification is passed on, unchanged, throughout the entire end-to-end chain. |
| `FileNumber` | `string` | Optional | - |
| `Fx` | [`Fx`](../../doc/models/fx.md) | Optional | - |
| `InstructionId` | `string` | Optional | Unique identification, as assigned by the initiating party to unambiguously identify the transaction. This identification is an point-to-point reference and is passed on, unchanged, throughout the entire chain. Cannot include leading, trailing or internal spaces. |
| `IntermediaryBank` | [`IntermediaryBankAccountHoldingEntity`](../../doc/models/intermediary-bank-account-holding-entity.md) | Optional | - |
| `NumericReference` | `string` | Optional | Numeric reference field, see scheme specific descriptions for usage |
| `PaymentAcceptanceDatetime` | `DateTime?` | Optional | Timestamp of when the payment instruction meets the set processing conditions. Format: YYYY-MM-DDThh:mm:ss:mmm+hh:mm |
| `PaymentPurpose` | `string` | Optional | Purpose of the payment in a proprietary form |
| `PaymentPurposeCoded` | `string` | Optional | Purpose of the payment in a coded form |
| `PaymentScheme` | `string` | Optional | Clearing infrastructure through which the payment instruction is to be processed. Default for given organisation ID is used if left empty. Has to be a valid [scheme identifier](http://draft-api-docs.form3.tech/api.html#enumerations-schemes).<br>**Constraints**: *Pattern*: `^[A-Za-z_]*$` |
| `PaymentType` | `string` | Optional | - |
| `ProcessingDate` | `DateTime?` | Optional | Date on which the payment is to be debited from the debtor account. Formatted according to ISO 8601 format: YYYY-MM-DD. |
| `ReceiversCorrespondent` | [`ReceiversCorrespondentAccountHoldingEntity`](../../doc/models/receivers-correspondent-account-holding-entity.md) | Optional | - |
| `Reference` | `string` | Optional | Payment reference for beneficiary use |
| `References` | [`List<Reference>`](../../doc/models/reference.md) | Optional | Block to represent a list of references |
| `RegulatoryReporting` | `string` | Optional | Regulatory reporting information |
| `Reimbursement` | [`ReimbursementAccountHoldingEntity`](../../doc/models/reimbursement-account-holding-entity.md) | Optional | - |
| `RemittanceInformation` | `string` | Optional | Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, such as commercial invoices in an accounts receivable system provided by the debtor for the beneficiary. |
| `SchemePaymentSubType` | `string` | Optional | The scheme specific payment [sub type](http://api-docs.form3.tech/api.html#enumerations-scheme-specific-payment-sub-types) |
| `SchemePaymentType` | `string` | Optional | The [scheme-specific payment type](#enumerations-scheme-payment-types) |
| `SchemeProcessingDate` | `DateTime?` | Optional | Date on which the payment is processed by the scheme. Only used if different from `processing_date`. |
| `SchemeTransactionId` | `string` | Optional | Unique identification, as assigned by the first instructing agent, to unambiguously identify the transaction that is passed on, unchanged, throughout the entire interbank chain. |
| `SendersCorrespondent` | [`SendersCorrespondentAccountHoldingEntity`](../../doc/models/senders-correspondent-account-holding-entity.md) | Optional | - |
| `Settlement` | [`Settlement`](../../doc/models/settlement.md) | Optional | Specifies the details on how the settlement of the transaction between the instructing agent and the instructed agent is completed |
| `StructuredReference` | [`StructuredReference`](../../doc/models/structured-reference.md) | Optional | - |
| `Swift` | [`Swift`](../../doc/models/swift.md) | Optional | - |
| `UltimateBeneficiary` | [`UltimateEntity`](../../doc/models/ultimate-entity.md) | Optional | - |
| `UltimateDebtor` | [`UltimateEntity`](../../doc/models/ultimate-entity.md) | Optional | - |
| `UniqueSchemeId` | `string` | Optional | The scheme-specific unique transaction ID. Populated by the scheme. |
| `UserDefinedData` | [`List<UserDefinedData>`](../../doc/models/user-defined-data.md) | Optional | All purpose list of key-value pairs specific data stored on the payment.<br>**Constraints**: *Maximum Items*: `5` |

## Example (as JSON)

```json
{
  "amount": "10.00",
  "currency": "EUR",
  "end_to_end_reference": "PAYMENT REF: 20094",
  "instruction_id": "ID1245799",
  "payment_acceptance_datetime": "09/30/2017 12:36:02",
  "payment_purpose": "X",
  "payment_scheme": "FPS",
  "processing_date": "2015-02-12",
  "reference": "rent for oct",
  "regulatory_reporting": "May be required for some foreign originated payments",
  "remittance_information": "Additional remittance information over and above reference information",
  "scheme_payment_sub_type": "TelephoneBanking",
  "scheme_payment_type": "ImmediatePayment",
  "scheme_processing_date": "2015-02-12",
  "scheme_transaction_id": "123456789012345678",
  "unique_scheme_id": "L5W48NDWYW7JV9MRO71020180301826040011",
  "agents": [
    {
      "account_number": "account_number0",
      "account_number_code": "IBAN",
      "address": [
        "address4",
        "address5"
      ],
      "identification": {
        "bank_id": "bank_id4",
        "bank_id_code": "bank_id_code2",
        "bank_ids": [
          {
            "bank_id": "bank_id4",
            "bank_id_code": "bank_id_code8"
          },
          {
            "bank_id": "bank_id4",
            "bank_id_code": "bank_id_code8"
          },
          {
            "bank_id": "bank_id4",
            "bank_id_code": "bank_id_code8"
          }
        ]
      },
      "name": "name0"
    },
    {
      "account_number": "account_number0",
      "account_number_code": "IBAN",
      "address": [
        "address4",
        "address5"
      ],
      "identification": {
        "bank_id": "bank_id4",
        "bank_id_code": "bank_id_code2",
        "bank_ids": [
          {
            "bank_id": "bank_id4",
            "bank_id_code": "bank_id_code8"
          },
          {
            "bank_id": "bank_id4",
            "bank_id_code": "bank_id_code8"
          },
          {
            "bank_id": "bank_id4",
            "bank_id_code": "bank_id_code8"
          }
        ]
      },
      "name": "name0"
    }
  ],
  "batch_booking_indicator": "batch_booking_indicator8",
  "batch_id": "batch_id2",
  "batch_type": "batch_type4"
}
```

