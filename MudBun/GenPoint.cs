using System;
using Il2CppDummyDll;
using UnityEngine;

namespace MudBun
{
	// Token: 0x02000149 RID: 329
	[Token(Token = "0x2000149")]
	[Serializable]
	public struct GenPoint
	{
		// Token: 0x040004D2 RID: 1234
		[Token(Token = "0x40004D2")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int Stride;

		// Token: 0x040004D3 RID: 1235
		[Token(Token = "0x40004D3")]
		[FieldOffset(Offset = "0x0")]
		public Vector4 PosNorm;

		// Token: 0x040004D4 RID: 1236
		[Token(Token = "0x40004D4")]
		[FieldOffset(Offset = "0x10")]
		public int BoneIndex0;

		// Token: 0x040004D5 RID: 1237
		[Token(Token = "0x40004D5")]
		[FieldOffset(Offset = "0x14")]
		public int BoneIndex1;

		// Token: 0x040004D6 RID: 1238
		[Token(Token = "0x40004D6")]
		[FieldOffset(Offset = "0x18")]
		public int BoneIndex2;

		// Token: 0x040004D7 RID: 1239
		[Token(Token = "0x40004D7")]
		[FieldOffset(Offset = "0x1C")]
		public int BoneIndex3;

		// Token: 0x040004D8 RID: 1240
		[Token(Token = "0x40004D8")]
		[FieldOffset(Offset = "0x20")]
		public uint BoneWeight;

		// Token: 0x040004D9 RID: 1241
		[Token(Token = "0x40004D9")]
		[FieldOffset(Offset = "0x24")]
		public int iBrushMask;

		// Token: 0x040004DA RID: 1242
		[Token(Token = "0x40004DA")]
		[FieldOffset(Offset = "0x28")]
		public uint VertId;

		// Token: 0x040004DB RID: 1243
		[Token(Token = "0x40004DB")]
		[FieldOffset(Offset = "0x2C")]
		public uint AtSmoothEdge;

		// Token: 0x040004DC RID: 1244
		[Token(Token = "0x40004DC")]
		[FieldOffset(Offset = "0x30")]
		public float SdfValue;

		// Token: 0x040004DD RID: 1245
		[Token(Token = "0x40004DD")]
		[FieldOffset(Offset = "0x34")]
		public float Norm2d;

		// Token: 0x040004DE RID: 1246
		[Token(Token = "0x40004DE")]
		[FieldOffset(Offset = "0x38")]
		public Vector2 UV;

		// Token: 0x040004DF RID: 1247
		[Token(Token = "0x40004DF")]
		[FieldOffset(Offset = "0x40")]
		public SdfBrushMaterialCompressed Material;
	}
}
