using System;
using Il2CppDummyDll;

namespace FMOD.Studio
{
	// Token: 0x020000CC RID: 204
	[Token(Token = "0x20000CC")]
	public struct BANK_INFO
	{
		// Token: 0x04000440 RID: 1088
		[Token(Token = "0x4000440")]
		[FieldOffset(Offset = "0x0")]
		public int size;

		// Token: 0x04000441 RID: 1089
		[Token(Token = "0x4000441")]
		[FieldOffset(Offset = "0x8")]
		public IntPtr userdata;

		// Token: 0x04000442 RID: 1090
		[Token(Token = "0x4000442")]
		[FieldOffset(Offset = "0x10")]
		public int userdatalength;

		// Token: 0x04000443 RID: 1091
		[Token(Token = "0x4000443")]
		[FieldOffset(Offset = "0x18")]
		public FILE_OPEN_CALLBACK opencallback;

		// Token: 0x04000444 RID: 1092
		[Token(Token = "0x4000444")]
		[FieldOffset(Offset = "0x20")]
		public FILE_CLOSE_CALLBACK closecallback;

		// Token: 0x04000445 RID: 1093
		[Token(Token = "0x4000445")]
		[FieldOffset(Offset = "0x28")]
		public FILE_READ_CALLBACK readcallback;

		// Token: 0x04000446 RID: 1094
		[Token(Token = "0x4000446")]
		[FieldOffset(Offset = "0x30")]
		public FILE_SEEK_CALLBACK seekcallback;
	}
}
