using System;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x02000018 RID: 24
	[Token(Token = "0x2000018")]
	[Flags]
	public enum DEBUG_FLAGS : uint
	{
		// Token: 0x040000C8 RID: 200
		[Token(Token = "0x40000C8")]
		NONE = 0U,
		// Token: 0x040000C9 RID: 201
		[Token(Token = "0x40000C9")]
		ERROR = 1U,
		// Token: 0x040000CA RID: 202
		[Token(Token = "0x40000CA")]
		WARNING = 2U,
		// Token: 0x040000CB RID: 203
		[Token(Token = "0x40000CB")]
		LOG = 4U,
		// Token: 0x040000CC RID: 204
		[Token(Token = "0x40000CC")]
		TYPE_MEMORY = 256U,
		// Token: 0x040000CD RID: 205
		[Token(Token = "0x40000CD")]
		TYPE_FILE = 512U,
		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000CE")]
		TYPE_CODEC = 1024U,
		// Token: 0x040000CF RID: 207
		[Token(Token = "0x40000CF")]
		TYPE_TRACE = 2048U,
		// Token: 0x040000D0 RID: 208
		[Token(Token = "0x40000D0")]
		DISPLAY_TIMESTAMPS = 65536U,
		// Token: 0x040000D1 RID: 209
		[Token(Token = "0x40000D1")]
		DISPLAY_LINENUMBERS = 131072U,
		// Token: 0x040000D2 RID: 210
		[Token(Token = "0x40000D2")]
		DISPLAY_THREAD = 262144U
	}
}
