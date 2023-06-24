using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000AC RID: 172
	[Token(Token = "0x20000AC")]
	[NullableContext(1)]
	[Nullable(0)]
	internal sealed class DynamicProxyMetaObject<T> : DynamicMetaObject
	{
		// Token: 0x060005B2 RID: 1458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B2")]
		internal DynamicProxyMetaObject(Expression expression, T value, DynamicProxy<T> proxy)
		{
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00003BB8 File Offset: 0x00001DB8
		[Token(Token = "0x60005B3")]
		private bool IsOverridden(string method)
		{
			return default(bool);
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005B4")]
		public override DynamicMetaObject BindGetMember(GetMemberBinder binder)
		{
			return null;
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005B5")]
		public override DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value)
		{
			return null;
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005B6")]
		public override DynamicMetaObject BindDeleteMember(DeleteMemberBinder binder)
		{
			return null;
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005B7")]
		public override DynamicMetaObject BindConvert(ConvertBinder binder)
		{
			return null;
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005B8")]
		public override DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, DynamicMetaObject[] args)
		{
			return null;
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005B9")]
		public override DynamicMetaObject BindCreateInstance(CreateInstanceBinder binder, DynamicMetaObject[] args)
		{
			return null;
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005BA")]
		public override DynamicMetaObject BindInvoke(InvokeBinder binder, DynamicMetaObject[] args)
		{
			return null;
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005BB")]
		public override DynamicMetaObject BindBinaryOperation(BinaryOperationBinder binder, DynamicMetaObject arg)
		{
			return null;
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005BC")]
		public override DynamicMetaObject BindUnaryOperation(UnaryOperationBinder binder)
		{
			return null;
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005BD")]
		public override DynamicMetaObject BindGetIndex(GetIndexBinder binder, DynamicMetaObject[] indexes)
		{
			return null;
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005BE")]
		public override DynamicMetaObject BindSetIndex(SetIndexBinder binder, DynamicMetaObject[] indexes, DynamicMetaObject value)
		{
			return null;
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005BF")]
		public override DynamicMetaObject BindDeleteIndex(DeleteIndexBinder binder, DynamicMetaObject[] indexes)
		{
			return null;
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060005C0 RID: 1472 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000C8")]
		private static Expression[] NoArgs
		{
			[Token(Token = "0x60005C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005C1")]
		private static IEnumerable<Expression> GetArgs(params DynamicMetaObject[] args)
		{
			return null;
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005C2")]
		private static Expression[] GetArgArray(DynamicMetaObject[] args)
		{
			return null;
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005C3")]
		private static Expression[] GetArgArray(DynamicMetaObject[] args, DynamicMetaObject value)
		{
			return null;
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005C4")]
		private static ConstantExpression Constant(DynamicMetaObjectBinder binder)
		{
			return null;
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005C5")]
		private DynamicMetaObject CallMethodWithResult(string methodName, DynamicMetaObjectBinder binder, IEnumerable<Expression> args, [Nullable(new byte[]
		{
			1,
			0
		})] DynamicProxyMetaObject<T>.Fallback fallback, [Nullable(new byte[]
		{
			2,
			0
		})] [Optional] DynamicProxyMetaObject<T>.Fallback fallbackInvoke)
		{
			return null;
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005C6")]
		private DynamicMetaObject BuildCallMethodWithResult(string methodName, DynamicMetaObjectBinder binder, IEnumerable<Expression> args, DynamicMetaObject fallbackResult, [Nullable(new byte[]
		{
			2,
			0
		})] DynamicProxyMetaObject<T>.Fallback fallbackInvoke)
		{
			return null;
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005C7")]
		private DynamicMetaObject CallMethodReturnLast(string methodName, DynamicMetaObjectBinder binder, IEnumerable<Expression> args, [Nullable(new byte[]
		{
			1,
			0
		})] DynamicProxyMetaObject<T>.Fallback fallback)
		{
			return null;
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005C8")]
		private DynamicMetaObject CallMethodNoResult(string methodName, DynamicMetaObjectBinder binder, Expression[] args, [Nullable(new byte[]
		{
			1,
			0
		})] DynamicProxyMetaObject<T>.Fallback fallback)
		{
			return null;
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005C9")]
		private BindingRestrictions GetRestrictions()
		{
			return null;
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005CA")]
		public override IEnumerable<string> GetDynamicMemberNames()
		{
			return null;
		}

		// Token: 0x0400040C RID: 1036
		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly DynamicProxy<T> _proxy;

		// Token: 0x020000AD RID: 173
		// (Invoke) Token: 0x060005CC RID: 1484
		[Token(Token = "0x20000AD")]
		[NullableContext(0)]
		private delegate DynamicMetaObject Fallback([Nullable(2)] DynamicMetaObject errorSuggestion);

		// Token: 0x020000AE RID: 174
		[Token(Token = "0x20000AE")]
		[Nullable(0)]
		private sealed class GetBinderAdapter : GetMemberBinder
		{
			// Token: 0x060005CF RID: 1487 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60005CF")]
			internal GetBinderAdapter(InvokeMemberBinder binder)
			{
			}

			// Token: 0x060005D0 RID: 1488 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x60005D0")]
			public override DynamicMetaObject FallbackGetMember(DynamicMetaObject target, [Nullable(2)] DynamicMetaObject errorSuggestion)
			{
				return null;
			}
		}
	}
}
