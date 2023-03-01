using System;
using Il2CppDummyDll;

namespace Sons.Multiplayer
{
	// Token: 0x0200054C RID: 1356
	[Token(Token = "0x200054C")]
	[Serializable]
	public enum ServerState
	{
		// Token: 0x04001FC9 RID: 8137
		[Token(Token = "0x4001FC9")]
		Unknown,
		// Token: 0x04001FCA RID: 8138
		[Token(Token = "0x4001FCA")]
		Lobby,
		// Token: 0x04001FCB RID: 8139
		[Token(Token = "0x4001FCB")]
		Preloading,
		// Token: 0x04001FCC RID: 8140
		[Token(Token = "0x4001FCC")]
		Loading,
		// Token: 0x04001FCD RID: 8141
		[Token(Token = "0x4001FCD")]
		Loaded,
		// Token: 0x04001FCE RID: 8142
		[Token(Token = "0x4001FCE")]
		Paused,
		// Token: 0x04001FCF RID: 8143
		[Token(Token = "0x4001FCF")]
		ShuttingDown
	}
}
