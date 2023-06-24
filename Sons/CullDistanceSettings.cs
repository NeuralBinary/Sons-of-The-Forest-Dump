using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001E3 RID: 483
[Token(Token = "0x20001E3")]
[CreateAssetMenu(menuName = "Sons/Cull Distance Settings", fileName = "CullDistanceSettings", order = 0)]
public class CullDistanceSettings : ScriptableObject
{
	// Token: 0x06000DCE RID: 3534 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DCE")]
	[Address(RVA = "0x370AFA0", Offset = "0x37095A0", VA = "0x18370AFA0")]
	public CullDistanceSettings()
	{
	}

	// Token: 0x04000CC0 RID: 3264
	[Token(Token = "0x4000CC0")]
	[FieldOffset(Offset = "0x18")]
	public List<LayerCullDistanceSetting> _settings;
}
