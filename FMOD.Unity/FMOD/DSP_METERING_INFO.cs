using System;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x02000096 RID: 150
	[Token(Token = "0x2000096")]
	public struct DSP_METERING_INFO
	{
		// Token: 0x040002D6 RID: 726
		[Token(Token = "0x40002D6")]
		[FieldOffset(Offset = "0x0")]
		public int numsamples;

		// Token: 0x040002D7 RID: 727
		[Token(Token = "0x40002D7")]
		[FieldOffset(Offset = "0x8")]
		public float[] peaklevel;

		// Token: 0x040002D8 RID: 728
		[Token(Token = "0x40002D8")]
		[FieldOffset(Offset = "0x10")]
		public float[] rmslevel;

		// Token: 0x040002D9 RID: 729
		[Token(Token = "0x40002D9")]
		[FieldOffset(Offset = "0x18")]
		public short numchannels;
	}
}
