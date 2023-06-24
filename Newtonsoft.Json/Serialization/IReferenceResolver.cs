using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200010E RID: 270
	[Token(Token = "0x200010E")]
	[NullableContext(1)]
	public interface IReferenceResolver
	{
		// Token: 0x060007C2 RID: 1986
		[Token(Token = "0x60007C2")]
		object ResolveReference(object context, string reference);

		// Token: 0x060007C3 RID: 1987
		[Token(Token = "0x60007C3")]
		string GetReference(object context, object value);

		// Token: 0x060007C4 RID: 1988
		[Token(Token = "0x60007C4")]
		bool IsReferenced(object context, object value);

		// Token: 0x060007C5 RID: 1989
		[Token(Token = "0x60007C5")]
		void AddReference(object context, string reference, object value);
	}
}
