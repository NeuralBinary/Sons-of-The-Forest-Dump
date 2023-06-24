using System;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x02000015 RID: 21
	[Token(Token = "0x2000015")]
	public struct ASYNCREADINFO
	{
		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x8")]
		public uint offset;

		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0xC")]
		public uint sizebytes;

		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x10")]
		public int priority;

		// Token: 0x040000AA RID: 170
		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x18")]
		public IntPtr userdata;

		// Token: 0x040000AB RID: 171
		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x20")]
		public IntPtr buffer;

		// Token: 0x040000AC RID: 172
		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x28")]
		public uint bytesread;

		// Token: 0x040000AD RID: 173
		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x30")]
		public FILE_ASYNCDONE_FUNC done;
	}
}
