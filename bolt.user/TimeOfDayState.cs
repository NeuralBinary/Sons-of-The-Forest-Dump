using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000082 RID: 130
[Token(Token = "0x2000082")]
internal class TimeOfDayState : NetworkState, ITimeOfDayState, IState, IDisposable
{
	// Token: 0x06000455 RID: 1109 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000455")]
	[Address(RVA = "0x80E590", Offset = "0x80CB90", VA = "0x18080E590")]
	public TimeOfDayState()
	{
	}

	// Token: 0x17000230 RID: 560
	// (get) Token: 0x06000456 RID: 1110 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000230")]
	public NetworkArray_Integer TimeOfDay
	{
		[Token(Token = "0x6000456")]
		[Address(RVA = "0x80E5F0", Offset = "0x80CBF0", VA = "0x18080E5F0", Slot = "31")]
		get
		{
			return null;
		}
	}
}
