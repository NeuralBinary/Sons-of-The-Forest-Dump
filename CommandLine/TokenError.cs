using System;
using Il2CppDummyDll;

namespace CommandLine
{
	// Token: 0x0200004D RID: 77
	[Token(Token = "0x200004D")]
	public abstract class TokenError : Error, IEquatable<TokenError>
	{
		// Token: 0x060001BC RID: 444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x98F8C0", Offset = "0x98DEC0", VA = "0x18098F8C0")]
		protected internal TokenError(ErrorType tag, string token)
		{
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060001BD RID: 445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000057")]
		public string Token
		{
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00002898 File Offset: 0x00000A98
		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x98F980", Offset = "0x98DF80", VA = "0x18098F980", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x000028B0 File Offset: 0x00000AB0
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x98FAD0", Offset = "0x98E0D0", VA = "0x18098FAD0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x000028C8 File Offset: 0x00000AC8
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x98FBA0", Offset = "0x98E1A0", VA = "0x18098FBA0", Slot = "5")]
		public bool Equals(TokenError other)
		{
			return default(bool);
		}

		// Token: 0x040000D1 RID: 209
		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x18")]
		private readonly string token;
	}
}
