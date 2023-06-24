using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x020001B7 RID: 439
	[Token(Token = "0x20001B7")]
	[AttributeUsage(AttributeTargets.Field)]
	public class MultiRange : MultiPropertyAttribute
	{
		// Token: 0x06000886 RID: 2182 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000886")]
		[Address(RVA = "0xAB20C0", Offset = "0xAB06C0", VA = "0x180AB20C0")]
		public MultiRange(float min, float max)
		{
		}

		// Token: 0x0400072F RID: 1839
		[Token(Token = "0x400072F")]
		[FieldOffset(Offset = "0x18")]
		private float min;

		// Token: 0x04000730 RID: 1840
		[Token(Token = "0x4000730")]
		[FieldOffset(Offset = "0x1C")]
		private float max;
	}
}
