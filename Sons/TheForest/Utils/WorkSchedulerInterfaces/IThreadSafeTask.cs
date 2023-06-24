using System;
using Il2CppDummyDll;

namespace TheForest.Utils.WorkSchedulerInterfaces
{
	// Token: 0x020003CF RID: 975
	[Token(Token = "0x20003CF")]
	public interface IThreadSafeTask
	{
		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06001AC2 RID: 6850
		// (set) Token: 0x06001AC3 RID: 6851
		[Token(Token = "0x170003BC")]
		bool ShouldDoMainThreadRefresh { [Token(Token = "0x6001AC2")] get; [Token(Token = "0x6001AC3")] set; }

		// Token: 0x06001AC4 RID: 6852
		[Token(Token = "0x6001AC4")]
		void ThreadedRefresh();

		// Token: 0x06001AC5 RID: 6853
		[Token(Token = "0x6001AC5")]
		void MainThreadRefresh();

		// Token: 0x06001AC6 RID: 6854
		[Token(Token = "0x6001AC6")]
		string GetTaskName();
	}
}
