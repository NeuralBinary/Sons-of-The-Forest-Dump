using System;
using Il2CppDummyDll;

namespace CommandLine
{
	// Token: 0x0200005C RID: 92
	[Token(Token = "0x200005C")]
	public sealed class SetValueExceptionError : NamedError
	{
		// Token: 0x060001D7 RID: 471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x990590", Offset = "0x98EB90", VA = "0x180990590")]
		internal SetValueExceptionError(NameInfo nameInfo, Exception exception, object value)
		{
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005D")]
		public Exception Exception
		{
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005E")]
		public object Value
		{
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x040000D7 RID: 215
		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0x20")]
		private readonly Exception exception;

		// Token: 0x040000D8 RID: 216
		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x28")]
		private readonly object value;
	}
}
