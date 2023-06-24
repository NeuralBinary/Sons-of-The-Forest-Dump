using System;
using Il2CppDummyDll;

namespace CommandLine
{
	// Token: 0x02000065 RID: 101
	[Token(Token = "0x2000065")]
	public sealed class NameInfo : IEquatable<NameInfo>
	{
		// Token: 0x060001F1 RID: 497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x991740", Offset = "0x98FD40", VA = "0x180991740")]
		internal NameInfo(string shortName, string longName)
		{
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000061")]
		public string ShortName
		{
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000062")]
		public string LongName
		{
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000063")]
		public string NameText
		{
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x9918B0", Offset = "0x98FEB0", VA = "0x1809918B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00002A30 File Offset: 0x00000C30
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x991930", Offset = "0x98FF30", VA = "0x180991930", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00002A48 File Offset: 0x00000C48
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x991A50", Offset = "0x990050", VA = "0x180991A50", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00002A60 File Offset: 0x00000C60
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x991AE0", Offset = "0x9900E0", VA = "0x180991AE0", Slot = "4")]
		public bool Equals(NameInfo other)
		{
			return default(bool);
		}

		// Token: 0x040000E7 RID: 231
		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x0")]
		public static readonly NameInfo EmptyName;

		// Token: 0x040000E8 RID: 232
		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x10")]
		private readonly string longName;

		// Token: 0x040000E9 RID: 233
		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x18")]
		private readonly string shortName;
	}
}
