using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x02000165 RID: 357
	[Token(Token = "0x2000165")]
	public struct HeightFieldHeader
	{
		// Token: 0x06000706 RID: 1798 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000706")]
		[Address(RVA = "0x60DE80", Offset = "0x60C480", VA = "0x18060DE80")]
		public HeightFieldHeader(int firstSample, int sampleCount)
		{
		}

		// Token: 0x040005F1 RID: 1521
		[Token(Token = "0x40005F1")]
		[FieldOffset(Offset = "0x0")]
		public int firstSample;

		// Token: 0x040005F2 RID: 1522
		[Token(Token = "0x40005F2")]
		[FieldOffset(Offset = "0x4")]
		public int sampleCount;
	}
}
