using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x0200019C RID: 412
	[Token(Token = "0x200019C")]
	[NullableContext(1)]
	[Nullable(0)]
	internal class JPath
	{
		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000E38 RID: 3640 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000241")]
		public List<PathFilter> Filters
		{
			[Token(Token = "0x6000E38")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E39")]
		[Address(RVA = "0x25E6DF0", Offset = "0x25E53F0", VA = "0x1825E6DF0")]
		public JPath(string expression)
		{
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E3A")]
		[Address(RVA = "0x25E6F60", Offset = "0x25E5560", VA = "0x1825E6F60")]
		private void ParseMain()
		{
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x00006B10 File Offset: 0x00004D10
		[Token(Token = "0x6000E3B")]
		[Address(RVA = "0x25E7110", Offset = "0x25E5710", VA = "0x1825E7110")]
		private bool ParsePath(List<PathFilter> filters, int currentPartStartIndex, bool query)
		{
			return default(bool);
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000E3C")]
		[Address(RVA = "0x25E7640", Offset = "0x25E5C40", VA = "0x1825E7640")]
		private static PathFilter CreatePathFilter([Nullable(2)] string member, bool scan)
		{
			return null;
		}

		// Token: 0x06000E3D RID: 3645 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000E3D")]
		[Address(RVA = "0x25E7770", Offset = "0x25E5D70", VA = "0x1825E7770")]
		private PathFilter ParseIndexer(char indexerOpenChar, bool scan)
		{
			return null;
		}

		// Token: 0x06000E3E RID: 3646 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000E3E")]
		[Address(RVA = "0x25E7880", Offset = "0x25E5E80", VA = "0x1825E7880")]
		private PathFilter ParseArrayIndexer(char indexerCloseChar)
		{
			return null;
		}

		// Token: 0x06000E3F RID: 3647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E3F")]
		[Address(RVA = "0x25E81E0", Offset = "0x25E67E0", VA = "0x1825E81E0")]
		private void EatWhitespace()
		{
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000E40")]
		[Address(RVA = "0x25E8230", Offset = "0x25E6830", VA = "0x1825E8230")]
		private PathFilter ParseQuery(char indexerCloseChar, bool scan)
		{
			return null;
		}

		// Token: 0x06000E41 RID: 3649 RVA: 0x00006B28 File Offset: 0x00004D28
		[Token(Token = "0x6000E41")]
		[Address(RVA = "0x25E8560", Offset = "0x25E6B60", VA = "0x1825E8560")]
		private bool TryParseExpression([Nullable(new byte[]
		{
			2,
			1
		})] out List<PathFilter> expressionPath)
		{
			return default(bool);
		}

		// Token: 0x06000E42 RID: 3650 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000E42")]
		[Address(RVA = "0x25E8810", Offset = "0x25E6E10", VA = "0x1825E8810")]
		private JsonException CreateUnexpectedCharacterException()
		{
			return null;
		}

		// Token: 0x06000E43 RID: 3651 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000E43")]
		[Address(RVA = "0x25E8930", Offset = "0x25E6F30", VA = "0x1825E8930")]
		private object ParseSide()
		{
			return null;
		}

		// Token: 0x06000E44 RID: 3652 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000E44")]
		[Address(RVA = "0x25E8B90", Offset = "0x25E7190", VA = "0x1825E8B90")]
		private QueryExpression ParseExpression()
		{
			return null;
		}

		// Token: 0x06000E45 RID: 3653 RVA: 0x00006B40 File Offset: 0x00004D40
		[Token(Token = "0x6000E45")]
		[Address(RVA = "0x25E8F20", Offset = "0x25E7520", VA = "0x1825E8F20")]
		[NullableContext(2)]
		private bool TryParseValue(out object value)
		{
			return default(bool);
		}

		// Token: 0x06000E46 RID: 3654 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000E46")]
		[Address(RVA = "0x25E9550", Offset = "0x25E7B50", VA = "0x1825E9550")]
		private string ReadQuotedString()
		{
			return null;
		}

		// Token: 0x06000E47 RID: 3655 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000E47")]
		[Address(RVA = "0x25E97F0", Offset = "0x25E7DF0", VA = "0x1825E97F0")]
		private string ReadRegexString()
		{
			return null;
		}

		// Token: 0x06000E48 RID: 3656 RVA: 0x00006B58 File Offset: 0x00004D58
		[Token(Token = "0x6000E48")]
		[Address(RVA = "0x25E9970", Offset = "0x25E7F70", VA = "0x1825E9970")]
		private bool Match(string s)
		{
			return default(bool);
		}

		// Token: 0x06000E49 RID: 3657 RVA: 0x00006B70 File Offset: 0x00004D70
		[Token(Token = "0x6000E49")]
		[Address(RVA = "0x25E9A20", Offset = "0x25E8020", VA = "0x1825E9A20")]
		private QueryOperator ParseOperator()
		{
			return QueryOperator.None;
		}

		// Token: 0x06000E4A RID: 3658 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000E4A")]
		[Address(RVA = "0x25E9D80", Offset = "0x25E8380", VA = "0x1825E9D80")]
		private PathFilter ParseQuotedField(char indexerCloseChar, bool scan)
		{
			return null;
		}

		// Token: 0x06000E4B RID: 3659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E4B")]
		[Address(RVA = "0x25EA0F0", Offset = "0x25E86F0", VA = "0x1825EA0F0")]
		private void EnsureLength(string message)
		{
		}

		// Token: 0x06000E4C RID: 3660 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000E4C")]
		[Address(RVA = "0x25EA160", Offset = "0x25E8760", VA = "0x1825EA160")]
		internal IEnumerable<JToken> Evaluate(JToken root, JToken t, [Nullable(2)] JsonSelectSettings settings)
		{
			return null;
		}

		// Token: 0x06000E4D RID: 3661 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000E4D")]
		[Address(RVA = "0x25EA1F0", Offset = "0x25E87F0", VA = "0x1825EA1F0")]
		internal static IEnumerable<JToken> Evaluate(List<PathFilter> filters, JToken root, JToken t, [Nullable(2)] JsonSelectSettings settings)
		{
			return null;
		}

		// Token: 0x040007A7 RID: 1959
		[Token(Token = "0x40007A7")]
		[FieldOffset(Offset = "0x0")]
		private static readonly char[] FloatCharacters;

		// Token: 0x040007A8 RID: 1960
		[Token(Token = "0x40007A8")]
		[FieldOffset(Offset = "0x10")]
		private readonly string _expression;

		// Token: 0x040007AA RID: 1962
		[Token(Token = "0x40007AA")]
		[FieldOffset(Offset = "0x20")]
		private int _currentIndex;
	}
}
