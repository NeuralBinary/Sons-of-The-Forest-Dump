using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x02000178 RID: 376
	[Token(Token = "0x2000178")]
	public struct CellSpan
	{
		// Token: 0x06000748 RID: 1864 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000748")]
		[Address(RVA = "0x15C8940", Offset = "0x15C6F40", VA = "0x1815C8940")]
		public CellSpan(VInt4 min, VInt4 max)
		{
		}

		// Token: 0x04000635 RID: 1589
		[Token(Token = "0x4000635")]
		[FieldOffset(Offset = "0x0")]
		public VInt4 min;

		// Token: 0x04000636 RID: 1590
		[Token(Token = "0x4000636")]
		[FieldOffset(Offset = "0x10")]
		public VInt4 max;
	}
}
