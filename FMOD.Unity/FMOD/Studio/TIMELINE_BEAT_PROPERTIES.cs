using System;
using Il2CppDummyDll;

namespace FMOD.Studio
{
	// Token: 0x020000C7 RID: 199
	[Token(Token = "0x20000C7")]
	public struct TIMELINE_BEAT_PROPERTIES
	{
		// Token: 0x04000427 RID: 1063
		[Token(Token = "0x4000427")]
		[FieldOffset(Offset = "0x0")]
		public int bar;

		// Token: 0x04000428 RID: 1064
		[Token(Token = "0x4000428")]
		[FieldOffset(Offset = "0x4")]
		public int beat;

		// Token: 0x04000429 RID: 1065
		[Token(Token = "0x4000429")]
		[FieldOffset(Offset = "0x8")]
		public int position;

		// Token: 0x0400042A RID: 1066
		[Token(Token = "0x400042A")]
		[FieldOffset(Offset = "0xC")]
		public float tempo;

		// Token: 0x0400042B RID: 1067
		[Token(Token = "0x400042B")]
		[FieldOffset(Offset = "0x10")]
		public int timesignatureupper;

		// Token: 0x0400042C RID: 1068
		[Token(Token = "0x400042C")]
		[FieldOffset(Offset = "0x14")]
		public int timesignaturelower;
	}
}
