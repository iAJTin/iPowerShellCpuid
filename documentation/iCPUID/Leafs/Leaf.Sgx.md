# Sgx Leaf

Contains the available properties for a leaf 00000012 - Sgx

## Available Properties

| Name | Description | Returns | Units |
| --- | --- | --- | --- |
| **EpcSectionEncoding** | Defines EPC section encoding. | String | None |
| **EpcSectionSize** | Size of the corresponding EPC section within the Processor Reserved Memory. | UInt64 | None |
| **MaxEnclaveSize64** | The maximum supported enclave size in 64-bit mode. | UInt32 | None |
| **MaxEnclaveSizeNot64** | The maximum supported enclave size in non-64-bit mode. | UInt32 | None |
| **MISCSELECT** | Bit vector of supported extended SGX features. | Boolean | None |
| **PhysicalAddressEpcSection** | Physical address of the base of the EPC section. | String | None |
| **SecsAttributesAddress** | Reports the valid bits of SECS.ATTRIBUTES address (128 bits). | String | None |
| **SGX1** | If true, Indicates Intel SGX supports the collection of SGX1 leaf functions (Subleaf 1). | Boolean | None |
| **SGX2** | If true, Indicates Intel SGX supports the collection of SGX2 leaf functions (Subleaf 2 or higher). | Boolean | None |
