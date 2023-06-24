using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000111 RID: 273
	[Token(Token = "0x2000111")]
	[NullableContext(1)]
	public interface IValueProvider
	{
		// Token: 0x060007CA RID: 1994
		[Token(Token = "0x60007CA")]
		void SetValue(object target, [Nullable(2)] object value);

		// Token: 0x060007CB RID: 1995
		[Token(Token = "0x60007CB")]
		object GetValue(object target);
	}
}
