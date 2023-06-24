using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200009C RID: 156
	[Token(Token = "0x200009C")]
	internal interface IWrappedCollection : IList, ICollection, IEnumerable
	{
		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000518 RID: 1304
		[Token(Token = "0x170000AC")]
		[Nullable(1)]
		object UnderlyingCollection { [Token(Token = "0x6000518")] [NullableContext(1)] get; }
	}
}
