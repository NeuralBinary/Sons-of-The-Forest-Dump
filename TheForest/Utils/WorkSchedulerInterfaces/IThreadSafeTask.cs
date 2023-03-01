using System;
using Il2CppDummyDll;

namespace TheForest.Utils.WorkSchedulerInterfaces
{
	// Token: 0x020003DD RID: 989
	[Token(Token = "0x20003DD")]
	public interface IThreadSafeTask
	{
		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06001A84 RID: 6788
		// (set) Token: 0x06001A85 RID: 6789
		[Token(Token = "0x170003B2")]
		bool ShouldDoMainThreadRefresh
		{
			[Token(Token = "0x6001A84")]
			get;
			[Token(Token = "0x6001A85")]
			set;
		}

		// Token: 0x06001A86 RID: 6790
		[Token(Token = "0x6001A86")]
		void ThreadedRefresh();

		// Token: 0x06001A87 RID: 6791
		[Token(Token = "0x6001A87")]
		void MainThreadRefresh();

		// Token: 0x06001A88 RID: 6792
		[Token(Token = "0x6001A88")]
		string GetTaskName();
	}
}
