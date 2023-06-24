using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace MTAssets.UltimateLODSystem.MeshSimplifier.Internal
{
	// Token: 0x02000076 RID: 118
	[Token(Token = "0x2000076")]
	internal struct Vertex : IEquatable<Vertex>
	{
		// Token: 0x06000251 RID: 593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x60E100", Offset = "0x60C700", VA = "0x18060E100")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Vertex(int index, Vector3d p)
		{
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00002B68 File Offset: 0x00000D68
		[Token(Token = "0x6000252")]
		[Address(RVA = "0x60E050", Offset = "0x60C650", VA = "0x18060E050", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00002B80 File Offset: 0x00000D80
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x60E140", Offset = "0x60C740", VA = "0x18060E140", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00002B98 File Offset: 0x00000D98
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x60E0F0", Offset = "0x60C6F0", VA = "0x18060E0F0", Slot = "4")]
		public bool Equals(Vertex other)
		{
			return default(bool);
		}

		// Token: 0x04000328 RID: 808
		[Token(Token = "0x4000328")]
		[FieldOffset(Offset = "0x0")]
		public int index;

		// Token: 0x04000329 RID: 809
		[Token(Token = "0x4000329")]
		[FieldOffset(Offset = "0x8")]
		public Vector3d p;

		// Token: 0x0400032A RID: 810
		[Token(Token = "0x400032A")]
		[FieldOffset(Offset = "0x20")]
		public int tstart;

		// Token: 0x0400032B RID: 811
		[Token(Token = "0x400032B")]
		[FieldOffset(Offset = "0x24")]
		public int tcount;

		// Token: 0x0400032C RID: 812
		[Token(Token = "0x400032C")]
		[FieldOffset(Offset = "0x28")]
		public SymmetricMatrix q;

		// Token: 0x0400032D RID: 813
		[Token(Token = "0x400032D")]
		[FieldOffset(Offset = "0x78")]
		public bool borderEdge;

		// Token: 0x0400032E RID: 814
		[Token(Token = "0x400032E")]
		[FieldOffset(Offset = "0x79")]
		public bool uvSeamEdge;

		// Token: 0x0400032F RID: 815
		[Token(Token = "0x400032F")]
		[FieldOffset(Offset = "0x7A")]
		public bool uvFoldoverEdge;
	}
}
