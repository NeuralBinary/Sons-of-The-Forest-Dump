using System;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x02000058 RID: 88
	[Token(Token = "0x2000058")]
	public struct DSP_BUFFER_ARRAY
	{
		// Token: 0x04000235 RID: 565
		[Token(Token = "0x4000235")]
		[FieldOffset(Offset = "0x0")]
		public int numbuffers;

		// Token: 0x04000236 RID: 566
		[Token(Token = "0x4000236")]
		[FieldOffset(Offset = "0x8")]
		public int[] buffernumchannels;

		// Token: 0x04000237 RID: 567
		[Token(Token = "0x4000237")]
		[FieldOffset(Offset = "0x10")]
		public CHANNELMASK[] bufferchannelmask;

		// Token: 0x04000238 RID: 568
		[Token(Token = "0x4000238")]
		[FieldOffset(Offset = "0x18")]
		public IntPtr[] buffers;

		// Token: 0x04000239 RID: 569
		[Token(Token = "0x4000239")]
		[FieldOffset(Offset = "0x20")]
		public SPEAKERMODE speakermode;
	}
}
