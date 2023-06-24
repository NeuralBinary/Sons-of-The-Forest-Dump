using System;
using Il2CppDummyDll;

namespace CommandLine
{
	// Token: 0x02000059 RID: 89
	[Token(Token = "0x2000059")]
	public sealed class HelpVerbRequestedError : Error
	{
		// Token: 0x060001D1 RID: 465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x990490", Offset = "0x98EA90", VA = "0x180990490")]
		internal HelpVerbRequestedError(string verb, Type type, bool matched)
		{
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005A")]
		public string Verb
		{
			[Token(Token = "0x60001D2")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005B")]
		public Type Type
		{
			[Token(Token = "0x60001D3")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x00002928 File Offset: 0x00000B28
		[Token(Token = "0x1700005C")]
		public bool Matched
		{
			[Token(Token = "0x60001D4")]
			[Address(RVA = "0x6599C0", Offset = "0x657FC0", VA = "0x1806599C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x040000D4 RID: 212
		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x18")]
		private readonly string verb;

		// Token: 0x040000D5 RID: 213
		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x20")]
		private readonly Type type;

		// Token: 0x040000D6 RID: 214
		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x28")]
		private readonly bool matched;
	}
}
