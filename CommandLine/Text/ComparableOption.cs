using System;
using Il2CppDummyDll;

namespace CommandLine.Text
{
	// Token: 0x0200008A RID: 138
	[Token(Token = "0x200008A")]
	public struct ComparableOption
	{
		// Token: 0x04000160 RID: 352
		[Token(Token = "0x4000160")]
		[FieldOffset(Offset = "0x0")]
		public bool Required;

		// Token: 0x04000161 RID: 353
		[Token(Token = "0x4000161")]
		[FieldOffset(Offset = "0x1")]
		public bool IsOption;

		// Token: 0x04000162 RID: 354
		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0x2")]
		public bool IsValue;

		// Token: 0x04000163 RID: 355
		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x8")]
		public string LongName;

		// Token: 0x04000164 RID: 356
		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0x10")]
		public string ShortName;

		// Token: 0x04000165 RID: 357
		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x18")]
		public int Index;
	}
}
