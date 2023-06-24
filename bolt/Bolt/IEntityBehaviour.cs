using System;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x0200006F RID: 111
	[Token(Token = "0x200006F")]
	public interface IEntityBehaviour
	{
		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600045D RID: 1117
		// (set) Token: 0x0600045E RID: 1118
		[Token(Token = "0x170000DE")]
		BoltEntity entity { [Token(Token = "0x600045D")] get; [Token(Token = "0x600045E")] set; }

		// Token: 0x0600045F RID: 1119
		[Token(Token = "0x600045F")]
		void Initialized();

		// Token: 0x06000460 RID: 1120
		[Token(Token = "0x6000460")]
		void Attached();

		// Token: 0x06000461 RID: 1121
		[Token(Token = "0x6000461")]
		void Detached();

		// Token: 0x06000462 RID: 1122
		[Token(Token = "0x6000462")]
		void SimulateOwner();

		// Token: 0x06000463 RID: 1123
		[Token(Token = "0x6000463")]
		void SimulateController();

		// Token: 0x06000464 RID: 1124
		[Token(Token = "0x6000464")]
		void ControlLost();

		// Token: 0x06000465 RID: 1125
		[Token(Token = "0x6000465")]
		void ControlGained();

		// Token: 0x06000466 RID: 1126
		[Token(Token = "0x6000466")]
		void MissingCommand(Command previous);

		// Token: 0x06000467 RID: 1127
		[Token(Token = "0x6000467")]
		void ExecuteCommand(Command command, bool resetState);
	}
}
