using System;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x02000071 RID: 113
	[Token(Token = "0x2000071")]
	public interface IPriorityCalculator
	{
		// Token: 0x06000469 RID: 1129
		[Token(Token = "0x6000469")]
		float CalculateStatePriority(BoltConnection connection, int skipped);

		// Token: 0x0600046A RID: 1130
		[Token(Token = "0x600046A")]
		float CalculateEventPriority(BoltConnection connection, Event evnt);

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x0600046B RID: 1131
		[Token(Token = "0x170000DF")]
		bool Always { [Token(Token = "0x600046B")] get; }
	}
}
