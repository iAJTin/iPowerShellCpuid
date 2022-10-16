# DeterministicCacheParameters Leaf

Contains the available properties for a leaf 00000004 - Deterministic Cache Parameters

## Available Properties

| Name | Description | Returns | Units |
| --- | --- | --- | --- |
| **CacheLevel** | Cache Level. | Byte | None |
| **CacheSize** | Cache Size in Bytes. | String | Bytes |
| **CacheType** | Cache Type. | String | None |
| **IsCacheInclusiveOfLowerLevels** | Determines if the cache is inclusive of lower cache levels. | Boolean | None |
| **IsFullyAssociativeCache** | Fully Associative cache. | Boolean | None |
| **IsSelfInitializingCacheLevel** | Self Initializing cache level. Self Initializing cache level (does not need SW initialization). | Boolean | None |
| **MaximumLogicalProcessorCores** | Maximum number of addressable IDs for logical processors sharing this cache. | UInt32 | None |
| **MaximumPhysicalProcessorCores** | Maximum number of addressable IDs for processor cores in the physical package. | UInt32 | None |
| **UseDirectMappedCache** | Determines if use direct mapped cache or not (A complex function is used to index the cache, potentially using all address bits). | Boolean | None |
| **WriteBack** | *true* indicates WBINVD/INVD from threads sharing this cache acts upon lower level caches for threads sharing this cache. *false* indicates WBINVD/INVD is not guaranteed to act upon lower level caches of non-originating threads sharing this cache. | Boolean | None |
