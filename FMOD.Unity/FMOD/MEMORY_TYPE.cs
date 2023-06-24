using System;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000019")]
	[Flags]
	public enum MEMORY_TYPE : uint
	{
		// Token: 0x040000D4 RID: 212
		[Token(Token = "0x40000D4")]
		NORMAL = 0U,
		// Token: 0x040000D5 RID: 213
		[Token(Token = "0x40000D5")]
		STREAM_FILE = 1U,
		// Token: 0x040000D6 RID: 214
		[Token(Token = "0x40000D6")]
		STREAM_DECODE = 2U,
		// Token: 0x040000D7 RID: 215
		[Token(Token = "0x40000D7")]
		SAMPLEDATA = 4U,
		// Token: 0x040000D8 RID: 216
		[Token(Token = "0x40000D8")]
		DSP_BUFFER = 8U,
		// Token: 0x040000D9 RID: 217
		[Token(Token = "0x40000D9")]
		PLUGIN = 16U,
		// Token: 0x040000DA RID: 218
		[Token(Token = "0x40000DA")]
		PERSISTENT = 2097152U,
		// Token: 0x040000DB RID: 219
		[Token(Token = "0x40000DB")]
		ALL = 4294967295U
	}
}
