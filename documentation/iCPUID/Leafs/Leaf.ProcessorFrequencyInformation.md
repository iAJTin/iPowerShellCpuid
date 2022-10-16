# ProcessorFrequencyInformation Leaf

Contains the available properties for a leaf 00000016 - Processor Frequency Information

## Available Properties

| Name | Description | Returns | Units |
| --- | --- | --- | --- |
| **BusReferenceFrequency** | Bus (Reference) Frequency (in MHz). Data is returned from this interface in accordance with the processor's specification and does not reflect actual values. While a processor may support the Processor Frequency Information leaf, fields that return a value of zero are not supported. | UInt32 | MHz |
| **MaximumFrequency** | Maximum Frequency (in MHz). Data is returned from this interface in accordance with the processor's specification and does not reflect actual values. While a processor may support the Processor Frequency Information leaf, fields that return a value of zero are not supported. | UInt32| MHz |
| **ProcessorBaseFrequency** | Processor Base Frequency (in MHz). Data is returned from this interface in accordance with the processor's specification and does not reflect actual values. While a processor may support the Processor Frequency Information leaf, fields that return a value of zero are not supported. | UInt32 | MHz |
