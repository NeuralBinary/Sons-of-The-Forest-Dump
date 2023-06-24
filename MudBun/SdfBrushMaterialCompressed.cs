using System;
using Il2CppDummyDll;

namespace MudBun
{
	// Token: 0x020000AD RID: 173
	[Token(Token = "0x20000AD")]
	[Serializable]
	public struct SdfBrushMaterialCompressed
	{
		// Token: 0x0400035D RID: 861
		[Token(Token = "0x400035D")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int Stride;

		// Token: 0x0400035E RID: 862
		[Token(Token = "0x400035E")]
		[FieldOffset(Offset = "0x0")]
		public uint Color;

		// Token: 0x0400035F RID: 863
		[Token(Token = "0x400035F")]
		[FieldOffset(Offset = "0x4")]
		public uint EmissionTightness;

		// Token: 0x04000360 RID: 864
		[Token(Token = "0x4000360")]
		[FieldOffset(Offset = "0x8")]
		public uint TextureWeight;

		// Token: 0x04000361 RID: 865
		[Token(Token = "0x4000361")]
		[FieldOffset(Offset = "0xC")]
		public int BrushIndex;

		// Token: 0x04000362 RID: 866
		[Token(Token = "0x4000362")]
		[FieldOffset(Offset = "0x10")]
		public float MetallicSmoothness;

		// Token: 0x04000363 RID: 867
		[Token(Token = "0x4000363")]
		[FieldOffset(Offset = "0x14")]
		public float Size;

		// Token: 0x04000364 RID: 868
		[Token(Token = "0x4000364")]
		[FieldOffset(Offset = "0x18")]
		public float Hash;

		// Token: 0x04000365 RID: 869
		[Token(Token = "0x4000365")]
		[FieldOffset(Offset = "0x1C")]
		public float Padding0;
	}
}
