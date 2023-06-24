using System;
using Il2CppDummyDll;

namespace Sons.TerrainDetail
{
	// Token: 0x02000521 RID: 1313
	[Token(Token = "0x2000521")]
	[Serializable]
	public enum WorldObjectState
	{
		// Token: 0x04001FCE RID: 8142
		[Token(Token = "0x4001FCE")]
		None = -1,
		// Token: 0x04001FCF RID: 8143
		[Token(Token = "0x4001FCF")]
		Default,
		// Token: 0x04001FD0 RID: 8144
		[Token(Token = "0x4001FD0")]
		Cleared,
		// Token: 0x04001FD1 RID: 8145
		[Token(Token = "0x4001FD1")]
		Damaged,
		// Token: 0x04001FD2 RID: 8146
		[Token(Token = "0x4001FD2")]
		Destroyed,
		// Token: 0x04001FD3 RID: 8147
		[Token(Token = "0x4001FD3")]
		Burning
	}
}
