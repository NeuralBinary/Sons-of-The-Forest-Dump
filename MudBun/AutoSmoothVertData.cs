using System;
using Il2CppDummyDll;
using UnityEngine;

namespace MudBun
{
	// Token: 0x0200014A RID: 330
	[Token(Token = "0x200014A")]
	[Serializable]
	public struct AutoSmoothVertData
	{
		// Token: 0x040004E0 RID: 1248
		[Token(Token = "0x40004E0")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int Stride;

		// Token: 0x040004E1 RID: 1249
		[Token(Token = "0x40004E1")]
		[FieldOffset(Offset = "0x0")]
		public uint Id;

		// Token: 0x040004E2 RID: 1250
		[Token(Token = "0x40004E2")]
		[FieldOffset(Offset = "0x4")]
		public uint NumNormals;

		// Token: 0x040004E3 RID: 1251
		[Token(Token = "0x40004E3")]
		[FieldOffset(Offset = "0x8")]
		public Vector4 VertNormalPacked0123;

		// Token: 0x040004E4 RID: 1252
		[Token(Token = "0x40004E4")]
		[FieldOffset(Offset = "0x18")]
		public Vector4 VertNormalPacked4567;

		// Token: 0x040004E5 RID: 1253
		[Token(Token = "0x40004E5")]
		[FieldOffset(Offset = "0x28")]
		public Vector4 VertNormalPacked89AB;

		// Token: 0x040004E6 RID: 1254
		[Token(Token = "0x40004E6")]
		[FieldOffset(Offset = "0x38")]
		public Vector4 Area0123;

		// Token: 0x040004E7 RID: 1255
		[Token(Token = "0x40004E7")]
		[FieldOffset(Offset = "0x48")]
		public Vector4 Area4567;

		// Token: 0x040004E8 RID: 1256
		[Token(Token = "0x40004E8")]
		[FieldOffset(Offset = "0x58")]
		public Vector4 Area89AB;
	}
}
