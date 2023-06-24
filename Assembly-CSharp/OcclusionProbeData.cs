using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000017 RID: 23
[Token(Token = "0x2000017")]
public class OcclusionProbeData : ScriptableObject
{
	// Token: 0x06000057 RID: 87 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000057")]
	[Address(RVA = "0x5D2C40", Offset = "0x5D1240", VA = "0x1805D2C40")]
	public OcclusionProbeData()
	{
	}

	// Token: 0x040000C4 RID: 196
	[Token(Token = "0x40000C4")]
	[FieldOffset(Offset = "0x18")]
	[Header("Baked Results")]
	[Tooltip("Affects grass occlusion as well.")]
	[Range(0f, 1f)]
	public float reflectionOcclusionAmount;

	// Token: 0x040000C5 RID: 197
	[Token(Token = "0x40000C5")]
	[FieldOffset(Offset = "0x1C")]
	[Header("Internal Data")]
	public Matrix4x4 worldToLocal;

	// Token: 0x040000C6 RID: 198
	[Token(Token = "0x40000C6")]
	[FieldOffset(Offset = "0x60")]
	public Texture3D occlusion;

	// Token: 0x040000C7 RID: 199
	[Token(Token = "0x40000C7")]
	[FieldOffset(Offset = "0x68")]
	public Matrix4x4[] worldToLocalDetail;

	// Token: 0x040000C8 RID: 200
	[Token(Token = "0x40000C8")]
	[FieldOffset(Offset = "0x70")]
	public Texture3D[] occlusionDetail;
}
