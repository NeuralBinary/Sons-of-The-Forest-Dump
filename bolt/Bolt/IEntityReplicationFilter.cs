using System;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x02000070 RID: 112
	[Token(Token = "0x2000070")]
	public interface IEntityReplicationFilter
	{
		// Token: 0x06000468 RID: 1128
		[Token(Token = "0x6000468")]
		bool AllowReplicationTo(BoltConnection connection);
	}
}
