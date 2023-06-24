using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Environment
{
	// Token: 0x02000010 RID: 16
	[Token(Token = "0x2000010")]
	public static class NormalSolver
	{
		// Token: 0x06000044 RID: 68 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x2F93240", Offset = "0x2F91840", VA = "0x182F93240")]
		public static void RecalculateNormals(this Mesh mesh, float angle)
		{
		}

		// Token: 0x02000011 RID: 17
		[Token(Token = "0x2000011")]
		private struct VertexKey
		{
			// Token: 0x06000045 RID: 69 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x6000045")]
			[Address(RVA = "0x2F94180", Offset = "0x2F92780", VA = "0x182F94180")]
			public VertexKey(Vector3 position)
			{
			}

			// Token: 0x06000046 RID: 70 RVA: 0x000021D4 File Offset: 0x000003D4
			[Token(Token = "0x6000046")]
			[Address(RVA = "0x2F941F0", Offset = "0x2F927F0", VA = "0x182F941F0", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			// Token: 0x06000047 RID: 71 RVA: 0x000021EC File Offset: 0x000003EC
			[Token(Token = "0x6000047")]
			[Address(RVA = "0x2F942B0", Offset = "0x2F928B0", VA = "0x182F942B0", Slot = "2")]
			public override int GetHashCode()
			{
				return 0;
			}

			// Token: 0x04000094 RID: 148
			[Token(Token = "0x4000094")]
			[FieldOffset(Offset = "0x0")]
			private readonly long _x;

			// Token: 0x04000095 RID: 149
			[Token(Token = "0x4000095")]
			[FieldOffset(Offset = "0x8")]
			private readonly long _y;

			// Token: 0x04000096 RID: 150
			[Token(Token = "0x4000096")]
			[FieldOffset(Offset = "0x10")]
			private readonly long _z;

			// Token: 0x04000097 RID: 151
			[Token(Token = "0x4000097")]
			private const int Tolerance = 100000;

			// Token: 0x04000098 RID: 152
			[Token(Token = "0x4000098")]
			private const long FNV32Init = 2166136261L;

			// Token: 0x04000099 RID: 153
			[Token(Token = "0x4000099")]
			private const long FNV32Prime = 16777619L;
		}

		// Token: 0x02000012 RID: 18
		[Token(Token = "0x2000012")]
		private struct VertexEntry
		{
			// Token: 0x06000048 RID: 72 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x65F570", Offset = "0x65DB70", VA = "0x18065F570")]
			public VertexEntry(int meshIndex, int triIndex, int vertIndex)
			{
			}

			// Token: 0x0400009A RID: 154
			[Token(Token = "0x400009A")]
			[FieldOffset(Offset = "0x0")]
			public int MeshIndex;

			// Token: 0x0400009B RID: 155
			[Token(Token = "0x400009B")]
			[FieldOffset(Offset = "0x4")]
			public int TriangleIndex;

			// Token: 0x0400009C RID: 156
			[Token(Token = "0x400009C")]
			[FieldOffset(Offset = "0x8")]
			public int VertexIndex;
		}
	}
}
