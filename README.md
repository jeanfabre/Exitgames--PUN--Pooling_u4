# Exitgames--PUN--Pooling_u4
Unity Exitgames PUN pooling demo using SmartPool


This repository is a simple demo for integrating Pooling Systems and PUN. 

Unity 4.7.2: http://unity3d.com/
PUN 1.74: https://www.assetstore.unity3d.com/en/#!/content/1786
SmartPool 1.02: https://www.assetstore.unity3d.com/en/#!/content/5911

Basically, you create a Component Script that implements IPunPrefabPool and feed instances using your preffered Pooling system.

## Notes

-- You need to keep your prefab inside a Resources folder anyway, It's important for PUN to load that prefab and analyze photonViews to assign viewIds. Note that there are no instantiation, it's only loaded
-- On the Prefab instance, use OnPhotonInstantiate() to catch initialization, Start() and OnEnabled() are not suitable for reliable data across the various cases of instantiation and pool usage accross the network.

 Knowing this, that's about it really...



