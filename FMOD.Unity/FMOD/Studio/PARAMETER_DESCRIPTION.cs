using System;
using Il2CppDummyDll;

namespace FMOD.Studio
{
	// Token: 0x020000D2 RID: 210
	[Token(Token = "0x20000D2")]
	public struct PARAMETER_DESCRIPTION
	{
		// Token: 0x0400045C RID: 1116
		[Token(Token = "0x400045C")]
		[FieldOffset(Offset = "0x0")]
		public StringWrapper name;

		// Token: 0x0400045D RID: 1117
		[Token(Token = "0x400045D")]
		[FieldOffset(Offset = "0x8")]
		public PARAMETER_ID id;

		// Token: 0x0400045E RID: 1118
		[Token(Token = "0x400045E")]
		[FieldOffset(Offset = "0x10")]
		public float minimum;

		// Token: 0x0400045F RID: 1119
		[Token(Token = "0x400045F")]
		[FieldOffset(Offset = "0x14")]
		public float maximum;

		// Token: 0x04000460 RID: 1120
		[Token(Token = "0x4000460")]
		[FieldOffset(Offset = "0x18")]
		public float defaultvalue;

		// Token: 0x04000461 RID: 1121
		[Token(Token = "0x4000461")]
		[FieldOffset(Offset = "0x1C")]
		public PARAMETER_TYPE type;

		// Token: 0x04000462 RID: 1122
		[Token(Token = "0x4000462")]
		[FieldOffset(Offset = "0x20")]
		public PARAMETER_FLAGS flags;
	}
}
