using System;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x02000094 RID: 148
	[Token(Token = "0x2000094")]
	public struct DSP_STATE_FUNCTIONS
	{
		// Token: 0x040002C2 RID: 706
		[Token(Token = "0x40002C2")]
		[FieldOffset(Offset = "0x0")]
		public DSP_ALLOC_FUNC alloc;

		// Token: 0x040002C3 RID: 707
		[Token(Token = "0x40002C3")]
		[FieldOffset(Offset = "0x8")]
		public DSP_REALLOC_FUNC realloc;

		// Token: 0x040002C4 RID: 708
		[Token(Token = "0x40002C4")]
		[FieldOffset(Offset = "0x10")]
		public DSP_FREE_FUNC free;

		// Token: 0x040002C5 RID: 709
		[Token(Token = "0x40002C5")]
		[FieldOffset(Offset = "0x18")]
		public DSP_GETSAMPLERATE_FUNC getsamplerate;

		// Token: 0x040002C6 RID: 710
		[Token(Token = "0x40002C6")]
		[FieldOffset(Offset = "0x20")]
		public DSP_GETBLOCKSIZE_FUNC getblocksize;

		// Token: 0x040002C7 RID: 711
		[Token(Token = "0x40002C7")]
		[FieldOffset(Offset = "0x28")]
		public IntPtr dft;

		// Token: 0x040002C8 RID: 712
		[Token(Token = "0x40002C8")]
		[FieldOffset(Offset = "0x30")]
		public IntPtr pan;

		// Token: 0x040002C9 RID: 713
		[Token(Token = "0x40002C9")]
		[FieldOffset(Offset = "0x38")]
		public DSP_GETSPEAKERMODE_FUNC getspeakermode;

		// Token: 0x040002CA RID: 714
		[Token(Token = "0x40002CA")]
		[FieldOffset(Offset = "0x40")]
		public DSP_GETCLOCK_FUNC getclock;

		// Token: 0x040002CB RID: 715
		[Token(Token = "0x40002CB")]
		[FieldOffset(Offset = "0x48")]
		public DSP_GETLISTENERATTRIBUTES_FUNC getlistenerattributes;

		// Token: 0x040002CC RID: 716
		[Token(Token = "0x40002CC")]
		[FieldOffset(Offset = "0x50")]
		public DSP_LOG_FUNC log;

		// Token: 0x040002CD RID: 717
		[Token(Token = "0x40002CD")]
		[FieldOffset(Offset = "0x58")]
		public DSP_GETUSERDATA_FUNC getuserdata;
	}
}
