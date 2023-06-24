using System;
using Il2CppDummyDll;
using UnityEngine.Rendering;

namespace SonsLOD
{
	// Token: 0x02000044 RID: 68
	[Token(Token = "0x2000044")]
	public struct SonsDrawKey
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x000022C8 File Offset: 0x000004C8
		[Token(Token = "0x17000003")]
		public SonsRangeKey rangeKey
		{
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
			get
			{
				return default(SonsRangeKey);
			}
		}

		// Token: 0x040001DE RID: 478
		[Token(Token = "0x40001DE")]
		[FieldOffset(Offset = "0x0")]
		public BatchID batchID;

		// Token: 0x040001DF RID: 479
		[Token(Token = "0x40001DF")]
		[FieldOffset(Offset = "0x4")]
		public BatchMeshID meshID;

		// Token: 0x040001E0 RID: 480
		[Token(Token = "0x40001E0")]
		[FieldOffset(Offset = "0x8")]
		public uint submeshIndex;

		// Token: 0x040001E1 RID: 481
		[Token(Token = "0x40001E1")]
		[FieldOffset(Offset = "0xC")]
		public BatchMaterialID material;

		// Token: 0x040001E2 RID: 482
		[Token(Token = "0x40001E2")]
		[FieldOffset(Offset = "0x10")]
		public ShadowCastingMode shadows;
	}
}
