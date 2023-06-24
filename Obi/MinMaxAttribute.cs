using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x020001B4 RID: 436
	[Token(Token = "0x20001B4")]
	[AttributeUsage(AttributeTargets.Field)]
	public class MinMaxAttribute : MultiPropertyAttribute
	{
		// Token: 0x06000883 RID: 2179 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000883")]
		[Address(RVA = "0xAB20C0", Offset = "0xAB06C0", VA = "0x180AB20C0")]
		public MinMaxAttribute(float min, float max)
		{
		}

		// Token: 0x0400072D RID: 1837
		[Token(Token = "0x400072D")]
		[FieldOffset(Offset = "0x18")]
		private float min;

		// Token: 0x0400072E RID: 1838
		[Token(Token = "0x400072E")]
		[FieldOffset(Offset = "0x1C")]
		private float max;
	}
}
