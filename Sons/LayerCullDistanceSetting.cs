using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x020001E2 RID: 482
[Token(Token = "0x20001E2")]
[Serializable]
public class LayerCullDistanceSetting
{
	// Token: 0x06000DCB RID: 3531 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DCB")]
	[Address(RVA = "0x370AD10", Offset = "0x3709310", VA = "0x18370AD10")]
	public string GetLabel()
	{
		return null;
	}

	// Token: 0x06000DCC RID: 3532 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DCC")]
	[Address(RVA = "0x370AEE0", Offset = "0x37094E0", VA = "0x18370AEE0")]
	private string GetLongestLayerName()
	{
		return null;
	}

	// Token: 0x06000DCD RID: 3533 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DCD")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	public LayerCullDistanceSetting()
	{
	}

	// Token: 0x04000CBD RID: 3261
	[Token(Token = "0x4000CBD")]
	[FieldOffset(Offset = "0x10")]
	[HideInInspector]
	public int LayerIndex;

	// Token: 0x04000CBE RID: 3262
	[Token(Token = "0x4000CBE")]
	[FieldOffset(Offset = "0x14")]
	[Min(0f)]
	[FormerlySerializedAs("CullDistance")]
	public float Renderer;

	// Token: 0x04000CBF RID: 3263
	[Token(Token = "0x4000CBF")]
	[FieldOffset(Offset = "0x18")]
	[Min(0f)]
	[FormerlySerializedAs("LightCullDistance")]
	public float Shadows;
}
