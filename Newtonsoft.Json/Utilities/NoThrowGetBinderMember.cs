using System;
using System.Dynamic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000BE RID: 190
	[Token(Token = "0x20000BE")]
	[NullableContext(1)]
	[Nullable(0)]
	internal class NoThrowGetBinderMember : GetMemberBinder
	{
		// Token: 0x060005F3 RID: 1523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x255DB10", Offset = "0x255C110", VA = "0x18255DB10")]
		public NoThrowGetBinderMember(GetMemberBinder innerBinder)
		{
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x255DBA0", Offset = "0x255C1A0", VA = "0x18255DBA0", Slot = "9")]
		public override DynamicMetaObject FallbackGetMember(DynamicMetaObject target, [Nullable(2)] DynamicMetaObject errorSuggestion)
		{
			return null;
		}

		// Token: 0x0400043A RID: 1082
		[Token(Token = "0x400043A")]
		[FieldOffset(Offset = "0x28")]
		private readonly GetMemberBinder _innerBinder;
	}
}
