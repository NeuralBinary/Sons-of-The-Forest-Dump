using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000AB RID: 171
	[Token(Token = "0x20000AB")]
	[NullableContext(1)]
	[Nullable(0)]
	internal class DynamicProxy<T>
	{
		// Token: 0x060005A4 RID: 1444 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005A4")]
		public virtual IEnumerable<string> GetDynamicMemberNames(T instance)
		{
			return null;
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00003A98 File Offset: 0x00001C98
		[Token(Token = "0x60005A5")]
		public virtual bool TryBinaryOperation(T instance, BinaryOperationBinder binder, object arg, [Nullable(2)] out object result)
		{
			return default(bool);
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00003AB0 File Offset: 0x00001CB0
		[Token(Token = "0x60005A6")]
		public virtual bool TryConvert(T instance, ConvertBinder binder, [Nullable(2)] out object result)
		{
			return default(bool);
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x00003AC8 File Offset: 0x00001CC8
		[Token(Token = "0x60005A7")]
		public virtual bool TryCreateInstance(T instance, CreateInstanceBinder binder, object[] args, [Nullable(2)] out object result)
		{
			return default(bool);
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00003AE0 File Offset: 0x00001CE0
		[Token(Token = "0x60005A8")]
		public virtual bool TryDeleteIndex(T instance, DeleteIndexBinder binder, object[] indexes)
		{
			return default(bool);
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00003AF8 File Offset: 0x00001CF8
		[Token(Token = "0x60005A9")]
		public virtual bool TryDeleteMember(T instance, DeleteMemberBinder binder)
		{
			return default(bool);
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00003B10 File Offset: 0x00001D10
		[Token(Token = "0x60005AA")]
		public virtual bool TryGetIndex(T instance, GetIndexBinder binder, object[] indexes, [Nullable(2)] out object result)
		{
			return default(bool);
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00003B28 File Offset: 0x00001D28
		[Token(Token = "0x60005AB")]
		public virtual bool TryGetMember(T instance, GetMemberBinder binder, [Nullable(2)] out object result)
		{
			return default(bool);
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x00003B40 File Offset: 0x00001D40
		[Token(Token = "0x60005AC")]
		public virtual bool TryInvoke(T instance, InvokeBinder binder, object[] args, [Nullable(2)] out object result)
		{
			return default(bool);
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00003B58 File Offset: 0x00001D58
		[Token(Token = "0x60005AD")]
		public virtual bool TryInvokeMember(T instance, InvokeMemberBinder binder, object[] args, [Nullable(2)] out object result)
		{
			return default(bool);
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00003B70 File Offset: 0x00001D70
		[Token(Token = "0x60005AE")]
		public virtual bool TrySetIndex(T instance, SetIndexBinder binder, object[] indexes, object value)
		{
			return default(bool);
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00003B88 File Offset: 0x00001D88
		[Token(Token = "0x60005AF")]
		public virtual bool TrySetMember(T instance, SetMemberBinder binder, object value)
		{
			return default(bool);
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x00003BA0 File Offset: 0x00001DA0
		[Token(Token = "0x60005B0")]
		public virtual bool TryUnaryOperation(T instance, UnaryOperationBinder binder, [Nullable(2)] out object result)
		{
			return default(bool);
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B1")]
		public DynamicProxy()
		{
		}
	}
}
