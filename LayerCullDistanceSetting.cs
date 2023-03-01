using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x020001E3 RID: 483
[Token(Token = "0x20001E3")]
[Serializable]
public class LayerCullDistanceSetting
{
	// Token: 0x06000D70 RID: 3440 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D70")]
	[Address(RVA = "0x2F8FB60", Offset = "0x2F8EB60", VA = "0x182F8FB60")]
	public string GetLabel()
	{
		return null;
	}

	// Token: 0x06000D71 RID: 3441 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D71")]
	[Address(RVA = "0x2F8FC80", Offset = "0x2F8EC80", VA = "0x182F8FC80")]
	private string GetLongestLayerName()
	{
		return null;
	}

	// Token: 0x06000D72 RID: 3442 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D72")]
	[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
	public LayerCullDistanceSetting()
	{
	}

	// Token: 0x04000C8E RID: 3214
	[Token(Token = "0x4000C8E")]
	[FieldOffset(Offset = "0x10")]
	[HideInInspector]
	public int LayerIndex;

	// Token: 0x04000C8F RID: 3215
	[Token(Token = "0x4000C8F")]
	[FieldOffset(Offset = "0x14")]
	[Min(0f)]
	[FormerlySerializedAs("CullDistance")]
	public float Renderer;

	// Token: 0x04000C90 RID: 3216
	[Token(Token = "0x4000C90")]
	[FieldOffset(Offset = "0x18")]
	[FormerlySerializedAs("LightCullDistance")]
	[Min(0f)]
	public float Shadows;
}
