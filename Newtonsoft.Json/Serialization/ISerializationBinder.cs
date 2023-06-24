using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200010F RID: 271
	[Token(Token = "0x200010F")]
	[NullableContext(1)]
	public interface ISerializationBinder
	{
		// Token: 0x060007C6 RID: 1990
		[Token(Token = "0x60007C6")]
		Type BindToType([Nullable(2)] string assemblyName, string typeName);

		// Token: 0x060007C7 RID: 1991
		[Token(Token = "0x60007C7")]
		[NullableContext(2)]
		void BindToName([Nullable(1)] Type serializedType, out string assemblyName, out string typeName);
	}
}
