using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200010D RID: 269
	[Token(Token = "0x200010D")]
	[NullableContext(1)]
	public interface IContractResolver
	{
		// Token: 0x060007C1 RID: 1985
		[Token(Token = "0x60007C1")]
		JsonContract ResolveContract(Type type);
	}
}
