using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x02000160 RID: 352
	[Token(Token = "0x2000160")]
	[NullableContext(1)]
	public interface IJEnumerable<out T> : IEnumerable<T>, IEnumerable where T : JToken
	{
		// Token: 0x170001CF RID: 463
		[Token(Token = "0x170001CF")]
		IJEnumerable<JToken> this[object key]
		{
			[Token(Token = "0x6000B19")]
			get;
		}
	}
}
