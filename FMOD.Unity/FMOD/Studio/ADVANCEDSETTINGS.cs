using System;
using Il2CppDummyDll;

namespace FMOD.Studio
{
	// Token: 0x020000C8 RID: 200
	[Token(Token = "0x20000C8")]
	public struct ADVANCEDSETTINGS
	{
		// Token: 0x0400042D RID: 1069
		[Token(Token = "0x400042D")]
		[FieldOffset(Offset = "0x0")]
		public int cbsize;

		// Token: 0x0400042E RID: 1070
		[Token(Token = "0x400042E")]
		[FieldOffset(Offset = "0x4")]
		public int commandqueuesize;

		// Token: 0x0400042F RID: 1071
		[Token(Token = "0x400042F")]
		[FieldOffset(Offset = "0x8")]
		public int handleinitialsize;

		// Token: 0x04000430 RID: 1072
		[Token(Token = "0x4000430")]
		[FieldOffset(Offset = "0xC")]
		public int studioupdateperiod;

		// Token: 0x04000431 RID: 1073
		[Token(Token = "0x4000431")]
		[FieldOffset(Offset = "0x10")]
		public int idlesampledatapoolsize;

		// Token: 0x04000432 RID: 1074
		[Token(Token = "0x4000432")]
		[FieldOffset(Offset = "0x14")]
		public int streamingscheduledelay;

		// Token: 0x04000433 RID: 1075
		[Token(Token = "0x4000433")]
		[FieldOffset(Offset = "0x18")]
		public IntPtr encryptionkey;
	}
}
