using System;
using System.Dynamic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000BF RID: 191
	[Token(Token = "0x20000BF")]
	[NullableContext(1)]
	[Nullable(0)]
	internal class NoThrowSetBinderMember : SetMemberBinder
	{
		// Token: 0x060005F5 RID: 1525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x255DCA0", Offset = "0x255C2A0", VA = "0x18255DCA0")]
		public NoThrowSetBinderMember(SetMemberBinder innerBinder)
		{
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x255DE40", Offset = "0x255C440", VA = "0x18255DE40", Slot = "9")]
		public override DynamicMetaObject FallbackSetMember(DynamicMetaObject target, DynamicMetaObject value, [Nullable(2)] DynamicMetaObject errorSuggestion)
		{
			return null;
		}

		// Token: 0x0400043B RID: 1083
		[Token(Token = "0x400043B")]
		[FieldOffset(Offset = "0x28")]
		private readonly SetMemberBinder _innerBinder;
	}
}
