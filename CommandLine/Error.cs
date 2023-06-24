using System;
using Il2CppDummyDll;

namespace CommandLine
{
	// Token: 0x0200004C RID: 76
	[Token(Token = "0x200004C")]
	public abstract class Error : IEquatable<Error>
	{
		// Token: 0x060001B5 RID: 437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x98F6C0", Offset = "0x98DCC0", VA = "0x18098F6C0")]
		protected internal Error(ErrorType tag, bool stopsProcessing)
		{
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x98F6D0", Offset = "0x98DCD0", VA = "0x18098F6D0")]
		protected internal Error(ErrorType tag)
		{
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x00002820 File Offset: 0x00000A20
		[Token(Token = "0x17000055")]
		public ErrorType Tag
		{
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
			get
			{
				return ErrorType.BadFormatTokenError;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x00002838 File Offset: 0x00000A38
		[Token(Token = "0x17000056")]
		public bool StopsProcessing
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x5FD560", Offset = "0x5FBB60", VA = "0x1805FD560")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00002850 File Offset: 0x00000A50
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x98F6E0", Offset = "0x98DCE0", VA = "0x18098F6E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00002868 File Offset: 0x00000A68
		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x98F7C0", Offset = "0x98DDC0", VA = "0x18098F7C0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00002880 File Offset: 0x00000A80
		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x98F830", Offset = "0x98DE30", VA = "0x18098F830", Slot = "4")]
		public bool Equals(Error other)
		{
			return default(bool);
		}

		// Token: 0x040000CF RID: 207
		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x10")]
		private readonly ErrorType tag;

		// Token: 0x040000D0 RID: 208
		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x14")]
		private readonly bool stopsProcessing;
	}
}
