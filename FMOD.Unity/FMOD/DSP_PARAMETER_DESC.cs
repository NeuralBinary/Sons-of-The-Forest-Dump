using System;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x0200008A RID: 138
	[Token(Token = "0x200008A")]
	public struct DSP_PARAMETER_DESC
	{
		// Token: 0x04000288 RID: 648
		[Token(Token = "0x4000288")]
		[FieldOffset(Offset = "0x0")]
		public DSP_PARAMETER_TYPE type;

		// Token: 0x04000289 RID: 649
		[Token(Token = "0x4000289")]
		[FieldOffset(Offset = "0x8")]
		public byte[] name;

		// Token: 0x0400028A RID: 650
		[Token(Token = "0x400028A")]
		[FieldOffset(Offset = "0x10")]
		public byte[] label;

		// Token: 0x0400028B RID: 651
		[Token(Token = "0x400028B")]
		[FieldOffset(Offset = "0x18")]
		public string description;

		// Token: 0x0400028C RID: 652
		[Token(Token = "0x400028C")]
		[FieldOffset(Offset = "0x20")]
		public DSP_PARAMETER_DESC_UNION desc;
	}
}
