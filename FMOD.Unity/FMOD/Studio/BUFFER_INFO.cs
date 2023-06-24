using System;
using Il2CppDummyDll;

namespace FMOD.Studio
{
	// Token: 0x020000CA RID: 202
	[Token(Token = "0x20000CA")]
	public struct BUFFER_INFO
	{
		// Token: 0x04000439 RID: 1081
		[Token(Token = "0x4000439")]
		[FieldOffset(Offset = "0x0")]
		public int currentusage;

		// Token: 0x0400043A RID: 1082
		[Token(Token = "0x400043A")]
		[FieldOffset(Offset = "0x4")]
		public int peakusage;

		// Token: 0x0400043B RID: 1083
		[Token(Token = "0x400043B")]
		[FieldOffset(Offset = "0x8")]
		public int capacity;

		// Token: 0x0400043C RID: 1084
		[Token(Token = "0x400043C")]
		[FieldOffset(Offset = "0xC")]
		public int stallcount;

		// Token: 0x0400043D RID: 1085
		[Token(Token = "0x400043D")]
		[FieldOffset(Offset = "0x10")]
		public float stalltime;
	}
}
