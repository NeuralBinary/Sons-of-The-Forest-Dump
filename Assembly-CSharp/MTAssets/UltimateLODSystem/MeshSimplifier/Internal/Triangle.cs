using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace MTAssets.UltimateLODSystem.MeshSimplifier.Internal
{
	// Token: 0x02000074 RID: 116
	[Token(Token = "0x2000074")]
	internal struct Triangle : IEquatable<Triangle>
	{
		// Token: 0x17000030 RID: 48
		[Token(Token = "0x17000030")]
		public int this[int index]
		{
			[Token(Token = "0x6000242")]
			[Address(RVA = "0x60DF50", Offset = "0x60C550", VA = "0x18060DF50")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000243")]
			[Address(RVA = "0x60A180", Offset = "0x608780", VA = "0x18060A180")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x60DF70", Offset = "0x60C570", VA = "0x18060DF70")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Triangle(int index, int v0, int v1, int v2, int subMeshIndex)
		{
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x60DFC0", Offset = "0x60C5C0", VA = "0x18060DFC0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void GetAttributeIndices(int[] attributeIndices)
		{
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x60A200", Offset = "0x608800", VA = "0x18060A200")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void SetAttributeIndex(int index, int value)
		{
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000247")]
		[Address(RVA = "0x60E000", Offset = "0x60C600", VA = "0x18060E000")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void GetErrors(double[] err)
		{
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00002B20 File Offset: 0x00000D20
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x60E050", Offset = "0x60C650", VA = "0x18060E050", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00002B38 File Offset: 0x00000D38
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x60E060", Offset = "0x60C660", VA = "0x18060E060", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00002B50 File Offset: 0x00000D50
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x60E0F0", Offset = "0x60C6F0", VA = "0x18060E0F0", Slot = "4")]
		public bool Equals(Triangle other)
		{
			return default(bool);
		}

		// Token: 0x04000316 RID: 790
		[Token(Token = "0x4000316")]
		[FieldOffset(Offset = "0x0")]
		public int index;

		// Token: 0x04000317 RID: 791
		[Token(Token = "0x4000317")]
		[FieldOffset(Offset = "0x4")]
		public int v0;

		// Token: 0x04000318 RID: 792
		[Token(Token = "0x4000318")]
		[FieldOffset(Offset = "0x8")]
		public int v1;

		// Token: 0x04000319 RID: 793
		[Token(Token = "0x4000319")]
		[FieldOffset(Offset = "0xC")]
		public int v2;

		// Token: 0x0400031A RID: 794
		[Token(Token = "0x400031A")]
		[FieldOffset(Offset = "0x10")]
		public int subMeshIndex;

		// Token: 0x0400031B RID: 795
		[Token(Token = "0x400031B")]
		[FieldOffset(Offset = "0x14")]
		public int va0;

		// Token: 0x0400031C RID: 796
		[Token(Token = "0x400031C")]
		[FieldOffset(Offset = "0x18")]
		public int va1;

		// Token: 0x0400031D RID: 797
		[Token(Token = "0x400031D")]
		[FieldOffset(Offset = "0x1C")]
		public int va2;

		// Token: 0x0400031E RID: 798
		[Token(Token = "0x400031E")]
		[FieldOffset(Offset = "0x20")]
		public double err0;

		// Token: 0x0400031F RID: 799
		[Token(Token = "0x400031F")]
		[FieldOffset(Offset = "0x28")]
		public double err1;

		// Token: 0x04000320 RID: 800
		[Token(Token = "0x4000320")]
		[FieldOffset(Offset = "0x30")]
		public double err2;

		// Token: 0x04000321 RID: 801
		[Token(Token = "0x4000321")]
		[FieldOffset(Offset = "0x38")]
		public double err3;

		// Token: 0x04000322 RID: 802
		[Token(Token = "0x4000322")]
		[FieldOffset(Offset = "0x40")]
		public bool deleted;

		// Token: 0x04000323 RID: 803
		[Token(Token = "0x4000323")]
		[FieldOffset(Offset = "0x41")]
		public bool dirty;

		// Token: 0x04000324 RID: 804
		[Token(Token = "0x4000324")]
		[FieldOffset(Offset = "0x48")]
		public Vector3d n;
	}
}
