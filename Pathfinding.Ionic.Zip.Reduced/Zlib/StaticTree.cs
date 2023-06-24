using System;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zlib
{
	// Token: 0x02000063 RID: 99
	[Token(Token = "0x2000063")]
	internal sealed class StaticTree
	{
		// Token: 0x06000439 RID: 1081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000439")]
		[Address(RVA = "0x289D4F0", Offset = "0x289BAF0", VA = "0x18289D4F0")]
		private StaticTree(short[] treeCodes, int[] extraBits, int extraBase, int elems, int maxLength)
		{
		}

		// Token: 0x0400035C RID: 860
		[Token(Token = "0x400035C")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly short[] lengthAndLiteralsTreeCodes;

		// Token: 0x0400035D RID: 861
		[Token(Token = "0x400035D")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly short[] distTreeCodes;

		// Token: 0x0400035E RID: 862
		[Token(Token = "0x400035E")]
		[FieldOffset(Offset = "0x10")]
		internal static readonly StaticTree Literals;

		// Token: 0x0400035F RID: 863
		[Token(Token = "0x400035F")]
		[FieldOffset(Offset = "0x18")]
		internal static readonly StaticTree Distances;

		// Token: 0x04000360 RID: 864
		[Token(Token = "0x4000360")]
		[FieldOffset(Offset = "0x20")]
		internal static readonly StaticTree BitLengths;

		// Token: 0x04000361 RID: 865
		[Token(Token = "0x4000361")]
		[FieldOffset(Offset = "0x10")]
		internal short[] treeCodes;

		// Token: 0x04000362 RID: 866
		[Token(Token = "0x4000362")]
		[FieldOffset(Offset = "0x18")]
		internal int[] extraBits;

		// Token: 0x04000363 RID: 867
		[Token(Token = "0x4000363")]
		[FieldOffset(Offset = "0x20")]
		internal int extraBase;

		// Token: 0x04000364 RID: 868
		[Token(Token = "0x4000364")]
		[FieldOffset(Offset = "0x24")]
		internal int elems;

		// Token: 0x04000365 RID: 869
		[Token(Token = "0x4000365")]
		[FieldOffset(Offset = "0x28")]
		internal int maxLength;
	}
}
