using System;
using Il2CppDummyDll;

namespace Sons.Multiplayer
{
	// Token: 0x02000548 RID: 1352
	[Token(Token = "0x2000548")]
	[Serializable]
	public enum ClientState
	{
		// Token: 0x04001FB5 RID: 8117
		[Token(Token = "0x4001FB5")]
		Unknown,
		// Token: 0x04001FB6 RID: 8118
		[Token(Token = "0x4001FB6")]
		Blocked,
		// Token: 0x04001FB7 RID: 8119
		[Token(Token = "0x4001FB7")]
		Lobby,
		// Token: 0x04001FB8 RID: 8120
		[Token(Token = "0x4001FB8")]
		Preloading,
		// Token: 0x04001FB9 RID: 8121
		[Token(Token = "0x4001FB9")]
		Loading,
		// Token: 0x04001FBA RID: 8122
		[Token(Token = "0x4001FBA")]
		Loaded,
		// Token: 0x04001FBB RID: 8123
		[Token(Token = "0x4001FBB")]
		Paused,
		// Token: 0x04001FBC RID: 8124
		[Token(Token = "0x4001FBC")]
		ShuttingDown
	}
}
