using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000081 RID: 129
[Token(Token = "0x2000081")]
public interface ITimeOfDayState : IState, IDisposable
{
	// Token: 0x1700022F RID: 559
	// (get) Token: 0x06000454 RID: 1108
	[Token(Token = "0x1700022F")]
	NetworkArray_Integer TimeOfDay { [Token(Token = "0x6000454")] get; }
}
