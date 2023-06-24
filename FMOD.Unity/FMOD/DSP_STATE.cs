using System;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x02000095 RID: 149
	[Token(Token = "0x2000095")]
	public struct DSP_STATE
	{
		// Token: 0x040002CE RID: 718
		[Token(Token = "0x40002CE")]
		[FieldOffset(Offset = "0x0")]
		public IntPtr instance;

		// Token: 0x040002CF RID: 719
		[Token(Token = "0x40002CF")]
		[FieldOffset(Offset = "0x8")]
		public IntPtr plugindata;

		// Token: 0x040002D0 RID: 720
		[Token(Token = "0x40002D0")]
		[FieldOffset(Offset = "0x10")]
		public uint channelmask;

		// Token: 0x040002D1 RID: 721
		[Token(Token = "0x40002D1")]
		[FieldOffset(Offset = "0x14")]
		public int source_speakermode;

		// Token: 0x040002D2 RID: 722
		[Token(Token = "0x40002D2")]
		[FieldOffset(Offset = "0x18")]
		public IntPtr sidechaindata;

		// Token: 0x040002D3 RID: 723
		[Token(Token = "0x40002D3")]
		[FieldOffset(Offset = "0x20")]
		public int sidechainchannels;

		// Token: 0x040002D4 RID: 724
		[Token(Token = "0x40002D4")]
		[FieldOffset(Offset = "0x28")]
		public IntPtr functions;

		// Token: 0x040002D5 RID: 725
		[Token(Token = "0x40002D5")]
		[FieldOffset(Offset = "0x30")]
		public int systemobject;
	}
}
