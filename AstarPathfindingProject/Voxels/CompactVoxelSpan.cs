using System;
using Il2CppDummyDll;

namespace Pathfinding.Voxels
{
	// Token: 0x02000115 RID: 277
	[Token(Token = "0x2000115")]
	public struct CompactVoxelSpan
	{
		// Token: 0x060008E0 RID: 2272 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008E0")]
		[Address(RVA = "0x6ED310", Offset = "0x6EB910", VA = "0x1806ED310")]
		public CompactVoxelSpan(ushort bottom, uint height)
		{
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x6ED330", Offset = "0x6EB930", VA = "0x1806ED330")]
		public void SetConnection(int dir, uint value)
		{
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x00005F24 File Offset: 0x00004124
		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x6ED360", Offset = "0x6EB960", VA = "0x1806ED360")]
		public int GetConnection(int dir)
		{
			return 0;
		}

		// Token: 0x0400062B RID: 1579
		[Token(Token = "0x400062B")]
		[FieldOffset(Offset = "0x0")]
		public ushort y;

		// Token: 0x0400062C RID: 1580
		[Token(Token = "0x400062C")]
		[FieldOffset(Offset = "0x4")]
		public uint con;

		// Token: 0x0400062D RID: 1581
		[Token(Token = "0x400062D")]
		[FieldOffset(Offset = "0x8")]
		public uint h;

		// Token: 0x0400062E RID: 1582
		[Token(Token = "0x400062E")]
		[FieldOffset(Offset = "0xC")]
		public int reg;
	}
}
