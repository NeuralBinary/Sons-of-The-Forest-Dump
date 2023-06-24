using System;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zlib
{
	// Token: 0x0200005B RID: 91
	[Token(Token = "0x200005B")]
	internal sealed class Tree
	{
		// Token: 0x0600042A RID: 1066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600042A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public Tree()
		{
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00003F00 File Offset: 0x00002100
		[Token(Token = "0x600042C")]
		[Address(RVA = "0x289C5C0", Offset = "0x289ABC0", VA = "0x18289C5C0")]
		internal static int DistanceCode(int dist)
		{
			return 0;
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600042D")]
		[Address(RVA = "0x289C690", Offset = "0x289AC90", VA = "0x18289C690")]
		internal void gen_bitlen(DeflateManager s)
		{
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600042E")]
		[Address(RVA = "0x289CA70", Offset = "0x289B070", VA = "0x18289CA70")]
		internal void build_tree(DeflateManager s)
		{
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600042F")]
		[Address(RVA = "0x289CFA0", Offset = "0x289B5A0", VA = "0x18289CFA0")]
		internal static void gen_codes(short[] tree, int max_code, short[] bl_count)
		{
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00003F18 File Offset: 0x00002118
		[Token(Token = "0x6000430")]
		[Address(RVA = "0x289D180", Offset = "0x289B780", VA = "0x18289D180")]
		internal static int bi_reverse(int code, int len)
		{
			return 0;
		}

		// Token: 0x04000329 RID: 809
		[Token(Token = "0x4000329")]
		internal const int Buf_size = 16;

		// Token: 0x0400032A RID: 810
		[Token(Token = "0x400032A")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int HEAP_SIZE;

		// Token: 0x0400032B RID: 811
		[Token(Token = "0x400032B")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly int[] ExtraLengthBits;

		// Token: 0x0400032C RID: 812
		[Token(Token = "0x400032C")]
		[FieldOffset(Offset = "0x10")]
		internal static readonly int[] ExtraDistanceBits;

		// Token: 0x0400032D RID: 813
		[Token(Token = "0x400032D")]
		[FieldOffset(Offset = "0x18")]
		internal static readonly int[] extra_blbits;

		// Token: 0x0400032E RID: 814
		[Token(Token = "0x400032E")]
		[FieldOffset(Offset = "0x20")]
		internal static readonly sbyte[] bl_order;

		// Token: 0x0400032F RID: 815
		[Token(Token = "0x400032F")]
		[FieldOffset(Offset = "0x28")]
		private static readonly sbyte[] _dist_code;

		// Token: 0x04000330 RID: 816
		[Token(Token = "0x4000330")]
		[FieldOffset(Offset = "0x30")]
		internal static readonly sbyte[] LengthCode;

		// Token: 0x04000331 RID: 817
		[Token(Token = "0x4000331")]
		[FieldOffset(Offset = "0x38")]
		internal static readonly int[] LengthBase;

		// Token: 0x04000332 RID: 818
		[Token(Token = "0x4000332")]
		[FieldOffset(Offset = "0x40")]
		internal static readonly int[] DistanceBase;

		// Token: 0x04000333 RID: 819
		[Token(Token = "0x4000333")]
		[FieldOffset(Offset = "0x10")]
		internal short[] dyn_tree;

		// Token: 0x04000334 RID: 820
		[Token(Token = "0x4000334")]
		[FieldOffset(Offset = "0x18")]
		internal int max_code;

		// Token: 0x04000335 RID: 821
		[Token(Token = "0x4000335")]
		[FieldOffset(Offset = "0x20")]
		internal StaticTree staticTree;
	}
}
