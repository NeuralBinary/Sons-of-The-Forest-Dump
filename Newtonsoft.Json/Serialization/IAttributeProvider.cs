using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200010C RID: 268
	[Token(Token = "0x200010C")]
	[NullableContext(1)]
	public interface IAttributeProvider
	{
		// Token: 0x060007BF RID: 1983
		[Token(Token = "0x60007BF")]
		IList<Attribute> GetAttributes(bool inherit);

		// Token: 0x060007C0 RID: 1984
		[Token(Token = "0x60007C0")]
		IList<Attribute> GetAttributes(Type attributeType, bool inherit);
	}
}
