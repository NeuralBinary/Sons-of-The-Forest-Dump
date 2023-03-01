using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001E4 RID: 484
[Token(Token = "0x20001E4")]
[CreateAssetMenu(menuName = "Sons/Cull Distance Settings", fileName = "CullDistanceSettings", order = 0)]
public class CullDistanceSettings : ScriptableObject
{
	// Token: 0x06000D73 RID: 3443 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D73")]
	[Address(RVA = "0x2F84040", Offset = "0x2F83040", VA = "0x182F84040")]
	public CullDistanceSettings()
	{
	}

	// Token: 0x04000C91 RID: 3217
	[Token(Token = "0x4000C91")]
	[FieldOffset(Offset = "0x18")]
	public List<LayerCullDistanceSetting> _settings;
}
