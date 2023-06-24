using System;
using Il2CppDummyDll;

namespace Sons.Save
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	public interface ITimeOfDay
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600003C RID: 60
		[Token(Token = "0x17000006")]
		int Days { [Token(Token = "0x600003C")] get; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600003D RID: 61
		[Token(Token = "0x17000007")]
		int Hours { [Token(Token = "0x600003D")] get; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600003E RID: 62
		[Token(Token = "0x17000008")]
		int Minutes { [Token(Token = "0x600003E")] get; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600003F RID: 63
		[Token(Token = "0x17000009")]
		int Seconds { [Token(Token = "0x600003F")] get; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000040 RID: 64
		[Token(Token = "0x1700000A")]
		int Milliseconds { [Token(Token = "0x6000040")] get; }
	}
}
