using System;
using Il2CppDummyDll;

namespace CommandLine.Core
{
	// Token: 0x020000F5 RID: 245
	[Token(Token = "0x20000F5")]
	internal abstract class Token
	{
		// Token: 0x06000596 RID: 1430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000596")]
		[Address(RVA = "0x77B7F0", Offset = "0x779DF0", VA = "0x18077B7F0")]
		protected Token(TokenType tag, string text)
		{
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000597")]
		[Address(RVA = "0x9BABF0", Offset = "0x9B91F0", VA = "0x1809BABF0")]
		public static Token Name(string text)
		{
			return null;
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000598")]
		[Address(RVA = "0x9BAC80", Offset = "0x9B9280", VA = "0x1809BAC80")]
		public static Token Value(string text)
		{
			return null;
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000599")]
		[Address(RVA = "0x9BAD20", Offset = "0x9B9320", VA = "0x1809BAD20")]
		public static Token Value(string text, bool explicitlyAssigned)
		{
			return null;
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600059A")]
		[Address(RVA = "0x9BADD0", Offset = "0x9B93D0", VA = "0x1809BADD0")]
		public static Token ValueForced(string text)
		{
			return null;
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600059B")]
		[Address(RVA = "0x9BAE70", Offset = "0x9B9470", VA = "0x1809BAE70")]
		public static Token ValueFromSeparator(string text)
		{
			return null;
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600059C RID: 1436 RVA: 0x00003BE8 File Offset: 0x00001DE8
		[Token(Token = "0x170000DB")]
		public TokenType Tag
		{
			[Token(Token = "0x600059C")]
			[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
			get
			{
				return TokenType.Name;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600059D RID: 1437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000DC")]
		public string Text
		{
			[Token(Token = "0x600059D")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000319 RID: 793
		[Token(Token = "0x4000319")]
		[FieldOffset(Offset = "0x10")]
		private readonly TokenType tag;

		// Token: 0x0400031A RID: 794
		[Token(Token = "0x400031A")]
		[FieldOffset(Offset = "0x18")]
		private readonly string text;
	}
}
