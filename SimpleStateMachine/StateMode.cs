using System;
using Il2CppDummyDll;

namespace Sons.SimpleStateMachine
{
	// Token: 0x0200051D RID: 1309
	[Token(Token = "0x200051D")]
	public enum StateMode
	{
		// Token: 0x04001F2C RID: 7980
		[Token(Token = "0x4001F2C")]
		None,
		// Token: 0x04001F2D RID: 7981
		[Token(Token = "0x4001F2D")]
		Entering,
		// Token: 0x04001F2E RID: 7982
		[Token(Token = "0x4001F2E")]
		Active,
		// Token: 0x04001F2F RID: 7983
		[Token(Token = "0x4001F2F")]
		Exiting,
		// Token: 0x04001F30 RID: 7984
		[Token(Token = "0x4001F30")]
		Ended
	}
}
