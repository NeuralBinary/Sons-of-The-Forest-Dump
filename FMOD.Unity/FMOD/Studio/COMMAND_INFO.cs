using System;
using Il2CppDummyDll;

namespace FMOD.Studio
{
	// Token: 0x020000E6 RID: 230
	[Token(Token = "0x20000E6")]
	public struct COMMAND_INFO
	{
		// Token: 0x040004B9 RID: 1209
		[Token(Token = "0x40004B9")]
		[FieldOffset(Offset = "0x0")]
		public StringWrapper commandname;

		// Token: 0x040004BA RID: 1210
		[Token(Token = "0x40004BA")]
		[FieldOffset(Offset = "0x8")]
		public int parentcommandindex;

		// Token: 0x040004BB RID: 1211
		[Token(Token = "0x40004BB")]
		[FieldOffset(Offset = "0xC")]
		public int framenumber;

		// Token: 0x040004BC RID: 1212
		[Token(Token = "0x40004BC")]
		[FieldOffset(Offset = "0x10")]
		public float frametime;

		// Token: 0x040004BD RID: 1213
		[Token(Token = "0x40004BD")]
		[FieldOffset(Offset = "0x14")]
		public INSTANCETYPE instancetype;

		// Token: 0x040004BE RID: 1214
		[Token(Token = "0x40004BE")]
		[FieldOffset(Offset = "0x18")]
		public INSTANCETYPE outputtype;

		// Token: 0x040004BF RID: 1215
		[Token(Token = "0x40004BF")]
		[FieldOffset(Offset = "0x1C")]
		public uint instancehandle;

		// Token: 0x040004C0 RID: 1216
		[Token(Token = "0x40004C0")]
		[FieldOffset(Offset = "0x20")]
		public uint outputhandle;
	}
}
