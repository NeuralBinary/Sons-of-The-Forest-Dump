using System;
using System.Collections;
using Il2CppDummyDll;

namespace NWH.DWP2.MeshDecimation
{
	// Token: 0x02000050 RID: 80
	[Token(Token = "0x2000050")]
	public class Comparer : IComparer
	{
		// Token: 0x06000238 RID: 568 RVA: 0x000030A4 File Offset: 0x000012A4
		[Token(Token = "0x6000238")]
		[Address(RVA = "0x2722470", Offset = "0x2720A70", VA = "0x182722470", Slot = "4")]
		public int Compare(object x, object y)
		{
			return 0;
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000239")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public Comparer()
		{
		}

		// Token: 0x040001F3 RID: 499
		[Token(Token = "0x40001F3")]
		[FieldOffset(Offset = "0x10")]
		private Vert vx;

		// Token: 0x040001F4 RID: 500
		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0x18")]
		private Vert vy;
	}
}
