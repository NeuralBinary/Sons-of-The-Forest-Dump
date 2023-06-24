using System;
using Il2CppDummyDll;

namespace Sons.Interfaces
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	public interface IBurnable
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6
		[Token(Token = "0x17000003")]
		bool IsBurning { [Token(Token = "0x6000006")] get; }

		// Token: 0x06000007 RID: 7
		[Token(Token = "0x6000007")]
		void Burn();
	}
}
