using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000C0 RID: 192
	[Token(Token = "0x20000C0")]
	[Nullable(0)]
	[NullableContext(1)]
	internal class NoThrowExpressionVisitor : ExpressionVisitor
	{
		// Token: 0x060005F7 RID: 1527 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x255DF90", Offset = "0x255C590", VA = "0x18255DF90", Slot = "7")]
		protected override Expression VisitConditional(ConditionalExpression node)
		{
			return null;
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public NoThrowExpressionVisitor()
		{
		}

		// Token: 0x0400043C RID: 1084
		[Token(Token = "0x400043C")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly object ErrorResult;
	}
}
