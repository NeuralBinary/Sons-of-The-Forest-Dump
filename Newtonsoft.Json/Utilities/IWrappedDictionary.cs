using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000A7 RID: 167
	[Token(Token = "0x20000A7")]
	internal interface IWrappedDictionary : IDictionary, ICollection, IEnumerable
	{
		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000577 RID: 1399
		[Token(Token = "0x170000B6")]
		[Nullable(1)]
		object UnderlyingDictionary { [Token(Token = "0x6000577")] [NullableContext(1)] get; }
	}
}
