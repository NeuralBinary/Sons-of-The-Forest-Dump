using System;
using Il2CppDummyDll;
using UnityEngine.Rendering;

// Token: 0x0200002B RID: 43
[Token(Token = "0x200002B")]
public struct SonsDrawKey
{
	// Token: 0x17000002 RID: 2
	// (get) Token: 0x060000A1 RID: 161 RVA: 0x000021C0 File Offset: 0x000003C0
	[Token(Token = "0x17000002")]
	public SonsRangeKey rangeKey
	{
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
		get
		{
			return default(SonsRangeKey);
		}
	}

	// Token: 0x04000154 RID: 340
	[Token(Token = "0x4000154")]
	[FieldOffset(Offset = "0x0")]
	public BatchID batchID;

	// Token: 0x04000155 RID: 341
	[Token(Token = "0x4000155")]
	[FieldOffset(Offset = "0x4")]
	public BatchMeshID meshID;

	// Token: 0x04000156 RID: 342
	[Token(Token = "0x4000156")]
	[FieldOffset(Offset = "0x8")]
	public uint submeshIndex;

	// Token: 0x04000157 RID: 343
	[Token(Token = "0x4000157")]
	[FieldOffset(Offset = "0xC")]
	public BatchMaterialID material;

	// Token: 0x04000158 RID: 344
	[Token(Token = "0x4000158")]
	[FieldOffset(Offset = "0x10")]
	public ShadowCastingMode shadows;
}
