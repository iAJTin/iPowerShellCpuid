# ThermalAndPowerManagementFeatures Leaf

Contains the available properties for a leaf 00000006 - Thermal And Power Management Features.

## Available Properties

| Name | Description | Returns | Units |
| --- | --- | --- | --- |
| **ARAT** | ARAT. APIC-Timer-always-running feature. | Boolean | None |
| **DigitalTemperatureSensor** | Digital Temperature Sensor. | Boolean | None |
| **ECMD** | Clock modulation duty cycle extension. | Boolean | None |
| **HardwareCoordinationCapability** | Hardware Coordination Feedback Capability (Presence of IA32_MPERF and IA32_APERF). The capability to provide a measure of delivered processor performance (since last reset of the counters) as a percentage of the expected processor performance when running at the TSC frequency. | Boolean | None |
| **HDC** | HDC base registers IA32_PKG_HDC_CTL, IA32_PM_CTL1, IA32_THREAD_STALL MSRs | Boolean | None |
| **HWP** | HWP base registers. | Boolean | None |
| **HWP_Activity_Window** | HWP Notification. IA32_HWP_REQUEST[bits 41:32]. | Boolean | None |
| **HWP_Energy_Performance_Preference** | HWP Energy Performance Preference. IA32_HWP_REQUEST[bits 31:24]. | Boolean | None |
| **HWP_Notification** | HWP Notification. IA32_HWP_INTERRUPT MSR. | Boolean | None |
| **HWP_Package_Level_Request** | HWP Package Level Request. IA32_HWP_REQUEST_PKG MSR. | Boolean | None |
| **IntelTurboBoost** | Intel Turbo Boost Technology. | Boolean | None |
| **InterruptNumber** | Number of Interrupt Thresholds in Digital Thermal Sensor. | UInt32 | None |
| **PerformanceEnergyPreference** | Performance Energy Preference. The processor supports performance-energy bias preference and also implies the presence of a new architectural MSR called IA32_ENERGY_PERF_BIAS. | Boolean | None |
| **PLN** | Power limit notification controls. | Boolean | None |
| **PTM** | Package thermal management. | Boolean | None |
