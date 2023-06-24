using System;
using Il2CppDummyDll;

namespace Sons.SimpleStateMachine
{
	// Token: 0x02000525 RID: 1317
	[Token(Token = "0x2000525")]
	public enum StateMode
	{
		// Token: 0x04001FE0 RID: 8160
		[Token(Token = "0x4001FE0")]
		None,
		// Token: 0x04001FE1 RID: 8161
		[Token(Token = "0x4001FE1")]
		Entering,
		// Token: 0x04001FE2 RID: 8162
		[Token(Token = "0x4001FE2")]
		Active,
		// Token: 0x04001FE3 RID: 8163
		[Token(Token = "0x4001FE3")]
		Exiting,
		// Token: 0x04001FE4 RID: 8164
		[Token(Token = "0x4001FE4")]
		Ended
	}
}
