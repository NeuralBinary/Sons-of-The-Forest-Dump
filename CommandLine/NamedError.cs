using System;
using Il2CppDummyDll;

namespace CommandLine
{
	// Token: 0x0200004F RID: 79
	[Token(Token = "0x200004F")]
	public abstract class NamedError : Error, IEquatable<NamedError>
	{
		// Token: 0x060001C2 RID: 450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x98FD50", Offset = "0x98E350", VA = "0x18098FD50")]
		protected internal NamedError(ErrorType tag, NameInfo nameInfo)
		{
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000058")]
		public NameInfo NameInfo
		{
			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x000028E0 File Offset: 0x00000AE0
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x98FDB0", Offset = "0x98E3B0", VA = "0x18098FDB0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x000028F8 File Offset: 0x00000AF8
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x98FED0", Offset = "0x98E4D0", VA = "0x18098FED0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00002910 File Offset: 0x00000B10
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x98FFA0", Offset = "0x98E5A0", VA = "0x18098FFA0", Slot = "5")]
		public bool Equals(NamedError other)
		{
			return default(bool);
		}

		// Token: 0x040000D2 RID: 210
		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x18")]
		private readonly NameInfo nameInfo;
	}
}
