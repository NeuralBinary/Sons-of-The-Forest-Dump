using System;
using Il2CppDummyDll;

namespace Sons.TerrainDetail
{
	// Token: 0x02000519 RID: 1305
	[Token(Token = "0x2000519")]
	[Serializable]
	public enum WorldObjectState
	{
		// Token: 0x04001F1A RID: 7962
		[Token(Token = "0x4001F1A")]
		None = -1,
		// Token: 0x04001F1B RID: 7963
		[Token(Token = "0x4001F1B")]
		Default,
		// Token: 0x04001F1C RID: 7964
		[Token(Token = "0x4001F1C")]
		Cleared,
		// Token: 0x04001F1D RID: 7965
		[Token(Token = "0x4001F1D")]
		Damaged,
		// Token: 0x04001F1E RID: 7966
		[Token(Token = "0x4001F1E")]
		Destroyed,
		// Token: 0x04001F1F RID: 7967
		[Token(Token = "0x4001F1F")]
		Burning
	}
}
