using System;
using Il2CppDummyDll;
using UnityEngine;

namespace MudBun
{
	// Token: 0x02000145 RID: 325
	[Token(Token = "0x2000145")]
	[Serializable]
	public struct VoxelNode
	{
		// Token: 0x06000853 RID: 2131 RVA: 0x000061E0 File Offset: 0x000043E0
		[Token(Token = "0x6000853")]
		[Address(RVA = "0x2454350", Offset = "0x2452950", VA = "0x182454350")]
		public static VoxelNode New(Vector3 center)
		{
			return default(VoxelNode);
		}

		// Token: 0x040004C3 RID: 1219
		[Token(Token = "0x40004C3")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int Stride;

		// Token: 0x040004C4 RID: 1220
		[Token(Token = "0x40004C4")]
		[FieldOffset(Offset = "0x0")]
		public Vector3 Center;

		// Token: 0x040004C5 RID: 1221
		[Token(Token = "0x40004C5")]
		[FieldOffset(Offset = "0xC")]
		public float SdfValue;

		// Token: 0x040004C6 RID: 1222
		[Token(Token = "0x40004C6")]
		[FieldOffset(Offset = "0x10")]
		public int ParentId;

		// Token: 0x040004C7 RID: 1223
		[Token(Token = "0x40004C7")]
		[FieldOffset(Offset = "0x14")]
		public int BrushMaskId;

		// Token: 0x040004C8 RID: 1224
		[Token(Token = "0x40004C8")]
		[FieldOffset(Offset = "0x18")]
		public uint Key;

		// Token: 0x040004C9 RID: 1225
		[Token(Token = "0x40004C9")]
		[FieldOffset(Offset = "0x1C")]
		public int Padding;
	}
}
