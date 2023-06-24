using System;
using Il2CppDummyDll;

namespace Sons.Multiplayer
{
	// Token: 0x02000556 RID: 1366
	[Token(Token = "0x2000556")]
	[Serializable]
	public enum ServerState
	{
		// Token: 0x04002083 RID: 8323
		[Token(Token = "0x4002083")]
		Unknown,
		// Token: 0x04002084 RID: 8324
		[Token(Token = "0x4002084")]
		Lobby,
		// Token: 0x04002085 RID: 8325
		[Token(Token = "0x4002085")]
		Preloading,
		// Token: 0x04002086 RID: 8326
		[Token(Token = "0x4002086")]
		Loading,
		// Token: 0x04002087 RID: 8327
		[Token(Token = "0x4002087")]
		Loaded,
		// Token: 0x04002088 RID: 8328
		[Token(Token = "0x4002088")]
		Paused,
		// Token: 0x04002089 RID: 8329
		[Token(Token = "0x4002089")]
		ShuttingDown
	}
}
