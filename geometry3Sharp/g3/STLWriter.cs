using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020001B6 RID: 438
	[Token(Token = "0x20001B6")]
	public class STLWriter : IMeshWriter
	{
		// Token: 0x06000BB1 RID: 2993 RVA: 0x00008804 File Offset: 0x00006A04
		[Token(Token = "0x6000BB1")]
		[Address(RVA = "0x201E8B0", Offset = "0x201CEB0", VA = "0x18201E8B0", Slot = "5")]
		public IOWriteResult Write(BinaryWriter writer, List<WriteMesh> vMeshes, WriteOptions options)
		{
			return default(IOWriteResult);
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x0000881C File Offset: 0x00006A1C
		[Token(Token = "0x6000BB2")]
		[Address(RVA = "0x201EF50", Offset = "0x201D550", VA = "0x18201EF50", Slot = "4")]
		public IOWriteResult Write(TextWriter writer, List<WriteMesh> vMeshes, WriteOptions options)
		{
			return default(IOWriteResult);
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BB3")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public STLWriter()
		{
		}

		// Token: 0x020001B7 RID: 439
		[Token(Token = "0x20001B7")]
		private struct stl_triangle
		{
			// Token: 0x040006D1 RID: 1745
			[Token(Token = "0x40006D1")]
			[FieldOffset(Offset = "0x0")]
			public float nx;

			// Token: 0x040006D2 RID: 1746
			[Token(Token = "0x40006D2")]
			[FieldOffset(Offset = "0x4")]
			public float ny;

			// Token: 0x040006D3 RID: 1747
			[Token(Token = "0x40006D3")]
			[FieldOffset(Offset = "0x8")]
			public float nz;

			// Token: 0x040006D4 RID: 1748
			[Token(Token = "0x40006D4")]
			[FieldOffset(Offset = "0xC")]
			public float ax;

			// Token: 0x040006D5 RID: 1749
			[Token(Token = "0x40006D5")]
			[FieldOffset(Offset = "0x10")]
			public float ay;

			// Token: 0x040006D6 RID: 1750
			[Token(Token = "0x40006D6")]
			[FieldOffset(Offset = "0x14")]
			public float az;

			// Token: 0x040006D7 RID: 1751
			[Token(Token = "0x40006D7")]
			[FieldOffset(Offset = "0x18")]
			public float bx;

			// Token: 0x040006D8 RID: 1752
			[Token(Token = "0x40006D8")]
			[FieldOffset(Offset = "0x1C")]
			public float by;

			// Token: 0x040006D9 RID: 1753
			[Token(Token = "0x40006D9")]
			[FieldOffset(Offset = "0x20")]
			public float bz;

			// Token: 0x040006DA RID: 1754
			[Token(Token = "0x40006DA")]
			[FieldOffset(Offset = "0x24")]
			public float cx;

			// Token: 0x040006DB RID: 1755
			[Token(Token = "0x40006DB")]
			[FieldOffset(Offset = "0x28")]
			public float cy;

			// Token: 0x040006DC RID: 1756
			[Token(Token = "0x40006DC")]
			[FieldOffset(Offset = "0x2C")]
			public float cz;

			// Token: 0x040006DD RID: 1757
			[Token(Token = "0x40006DD")]
			[FieldOffset(Offset = "0x30")]
			public short attrib;
		}
	}
}
