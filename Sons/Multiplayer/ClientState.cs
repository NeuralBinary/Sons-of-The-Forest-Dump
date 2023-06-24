using System;
using Il2CppDummyDll;

namespace Sons.Multiplayer
{
	// Token: 0x02000552 RID: 1362
	[Token(Token = "0x2000552")]
	[Serializable]
	public enum ClientState
	{
		// Token: 0x0400206F RID: 8303
		[Token(Token = "0x400206F")]
		Unknown,
		// Token: 0x04002070 RID: 8304
		[Token(Token = "0x4002070")]
		Blocked,
		// Token: 0x04002071 RID: 8305
		[Token(Token = "0x4002071")]
		Lobby,
		// Token: 0x04002072 RID: 8306
		[Token(Token = "0x4002072")]
		Preloading,
		// Token: 0x04002073 RID: 8307
		[Token(Token = "0x4002073")]
		Loading,
		// Token: 0x04002074 RID: 8308
		[Token(Token = "0x4002074")]
		Loaded,
		// Token: 0x04002075 RID: 8309
		[Token(Token = "0x4002075")]
		Paused,
		// Token: 0x04002076 RID: 8310
		[Token(Token = "0x4002076")]
		ShuttingDown
	}
}
