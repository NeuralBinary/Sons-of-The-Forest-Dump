using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CommandLine
{
	// Token: 0x0200005E RID: 94
	[Token(Token = "0x200005E")]
	public sealed class MissingGroupOptionError : Error, IEquatable<Error>, IEquatable<MissingGroupOptionError>
	{
		// Token: 0x060001DB RID: 475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x9906D0", Offset = "0x98ECD0", VA = "0x1809906D0")]
		internal MissingGroupOptionError(string group, IEnumerable<NameInfo> names)
		{
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060001DC RID: 476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005F")]
		public string Group
		{
			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060001DD RID: 477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000060")]
		public IEnumerable<NameInfo> Names
		{
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00002940 File Offset: 0x00000B40
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x990790", Offset = "0x98ED90", VA = "0x180990790", Slot = "4")]
		public new bool Equals(Error obj)
		{
			return default(bool);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00002958 File Offset: 0x00000B58
		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x990920", Offset = "0x98EF20", VA = "0x180990920", Slot = "5")]
		public bool Equals(MissingGroupOptionError other)
		{
			return default(bool);
		}

		// Token: 0x040000DA RID: 218
		[Token(Token = "0x40000DA")]
		public const string ErrorMessage = "At least one option in a group must have value.";

		// Token: 0x040000DB RID: 219
		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x18")]
		private readonly string group;

		// Token: 0x040000DC RID: 220
		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x20")]
		private readonly IEnumerable<NameInfo> names;
	}
}
