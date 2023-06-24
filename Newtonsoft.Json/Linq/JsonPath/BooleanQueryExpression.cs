using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020001A1 RID: 417
	[Token(Token = "0x20001A1")]
	[NullableContext(1)]
	[Nullable(0)]
	internal class BooleanQueryExpression : QueryExpression
	{
		// Token: 0x06000E5A RID: 3674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E5A")]
		[Address(RVA = "0x1B0CF20", Offset = "0x1B0B520", VA = "0x181B0CF20")]
		public BooleanQueryExpression(QueryOperator @operator, object left, [Nullable(2)] object right)
		{
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000E5B")]
		[Address(RVA = "0x25EAD60", Offset = "0x25E9360", VA = "0x1825EAD60")]
		private IEnumerable<JToken> GetResult(JToken root, JToken t, [Nullable(2)] object o)
		{
			return null;
		}

		// Token: 0x06000E5C RID: 3676 RVA: 0x00006BB8 File Offset: 0x00004DB8
		[Token(Token = "0x6000E5C")]
		[Address(RVA = "0x25EAF50", Offset = "0x25E9550", VA = "0x1825EAF50", Slot = "4")]
		public override bool IsMatch(JToken root, JToken t, [Nullable(2)] JsonSelectSettings settings)
		{
			return default(bool);
		}

		// Token: 0x06000E5D RID: 3677 RVA: 0x00006BD0 File Offset: 0x00004DD0
		[Token(Token = "0x6000E5D")]
		[Address(RVA = "0x25EB460", Offset = "0x25E9A60", VA = "0x1825EB460")]
		private bool MatchTokens(JToken leftResult, JToken rightResult, [Nullable(2)] JsonSelectSettings settings)
		{
			return default(bool);
		}

		// Token: 0x06000E5E RID: 3678 RVA: 0x00006BE8 File Offset: 0x00004DE8
		[Token(Token = "0x6000E5E")]
		[Address(RVA = "0x25EB990", Offset = "0x25E9F90", VA = "0x1825EB990")]
		private static bool RegexEquals(JValue input, JValue pattern, [Nullable(2)] JsonSelectSettings settings)
		{
			return default(bool);
		}

		// Token: 0x06000E5F RID: 3679 RVA: 0x00006C00 File Offset: 0x00004E00
		[Token(Token = "0x6000E5F")]
		[Address(RVA = "0x25EBB20", Offset = "0x25EA120", VA = "0x1825EBB20")]
		internal static bool EqualsWithStringCoercion(JValue value, JValue queryValue)
		{
			return default(bool);
		}

		// Token: 0x06000E60 RID: 3680 RVA: 0x00006C18 File Offset: 0x00004E18
		[Token(Token = "0x6000E60")]
		[Address(RVA = "0x25EC0A0", Offset = "0x25EA6A0", VA = "0x1825EC0A0")]
		internal static bool EqualsWithStrictMatch(JValue value, JValue queryValue)
		{
			return default(bool);
		}

		// Token: 0x040007BB RID: 1979
		[Token(Token = "0x40007BB")]
		[FieldOffset(Offset = "0x18")]
		public readonly object Left;

		// Token: 0x040007BC RID: 1980
		[Token(Token = "0x40007BC")]
		[FieldOffset(Offset = "0x20")]
		[Nullable(2)]
		public readonly object Right;
	}
}
