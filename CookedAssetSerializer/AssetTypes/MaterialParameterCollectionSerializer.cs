﻿namespace CookedAssetSerializer.AssetTypes;

public class MaterialParameterCollectionSerializer : SimpleAssetSerializer<NormalExport>
{
    public MaterialParameterCollectionSerializer(Settings settings, UAsset asset) : base(settings, asset)
    {
        if (!Setup()) return;
        SerializeAsset();
    }
}