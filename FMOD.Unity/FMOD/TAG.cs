using System;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x02000040 RID: 64
	[Token(Token = "0x2000040")]
	public struct TAG
	{
		// Token: 0x040001CA RID: 458
		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0x0")]
		public TAGTYPE type;

		// Token: 0x040001CB RID: 459
		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0x4")]
		public TAGDATATYPE datatype;

		// Token: 0x040001CC RID: 460
		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x8")]
		public StringWrapper name;

		// Token: 0x040001CD RID: 461
		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x10")]
		public IntPtr data;

		// Token: 0x040001CE RID: 462
		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0x18")]
		public uint datalen;

		// Token: 0x040001CF RID: 463
		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0x1C")]
		public bool updated;
	}
}
