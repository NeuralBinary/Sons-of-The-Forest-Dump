using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000C5 RID: 197
	[Token(Token = "0x20000C5")]
	[NullableContext(2)]
	[Nullable(0)]
	internal class FSharpFunction
	{
		// Token: 0x0600060C RID: 1548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600060C")]
		[Address(RVA = "0x992FC0", Offset = "0x9915C0", VA = "0x180992FC0")]
		public FSharpFunction(object instance, [Nullable(new byte[]
		{
			1,
			2,
			1
		})] MethodCall<object, object> invoker)
		{
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600060D")]
		[Address(RVA = "0x25602E0", Offset = "0x255E8E0", VA = "0x1825602E0")]
		[NullableContext(1)]
		public object Invoke(params object[] args)
		{
			return null;
		}

		// Token: 0x04000449 RID: 1097
		[Token(Token = "0x4000449")]
		[FieldOffset(Offset = "0x10")]
		private readonly object _instance;

		// Token: 0x0400044A RID: 1098
		[Token(Token = "0x400044A")]
		[FieldOffset(Offset = "0x18")]
		[Nullable(new byte[]
		{
			1,
			2,
			1
		})]
		private readonly MethodCall<object, object> _invoker;
	}
}
