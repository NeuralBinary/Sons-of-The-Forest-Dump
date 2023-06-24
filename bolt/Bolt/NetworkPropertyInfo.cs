using System;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x020000B0 RID: 176
	[Token(Token = "0x20000B0")]
	internal struct NetworkPropertyInfo
	{
		// Token: 0x040002A1 RID: 673
		[Token(Token = "0x40002A1")]
		[FieldOffset(Offset = "0x0")]
		public int[] Indices;

		// Token: 0x040002A2 RID: 674
		[Token(Token = "0x40002A2")]
		[FieldOffset(Offset = "0x8")]
		public string[] Paths;

		// Token: 0x040002A3 RID: 675
		[Token(Token = "0x40002A3")]
		[FieldOffset(Offset = "0x10")]
		public int OffsetObjects;

		// Token: 0x040002A4 RID: 676
		[Token(Token = "0x40002A4")]
		[FieldOffset(Offset = "0x18")]
		public NetworkProperty Property;
	}
}
