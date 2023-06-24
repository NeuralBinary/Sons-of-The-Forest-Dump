using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000E1 RID: 225
	[Token(Token = "0x20000E1")]
	[NullableContext(1)]
	[Nullable(0)]
	internal abstract class ReflectionDelegateFactory
	{
		// Token: 0x06000690 RID: 1680 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000690")]
		public Func<T, object> CreateGet<T>(MemberInfo memberInfo)
		{
			return null;
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000691")]
		public Action<T, object> CreateSet<T>(MemberInfo memberInfo)
		{
			return null;
		}

		// Token: 0x06000692 RID: 1682
		[Token(Token = "0x6000692")]
		public abstract MethodCall<T, object> CreateMethodCall<T>(MethodBase method);

		// Token: 0x06000693 RID: 1683
		[Token(Token = "0x6000693")]
		public abstract ObjectConstructor<object> CreateParameterizedConstructor(MethodBase method);

		// Token: 0x06000694 RID: 1684
		[Token(Token = "0x6000694")]
		public abstract Func<T> CreateDefaultConstructor<T>(Type type);

		// Token: 0x06000695 RID: 1685
		[Token(Token = "0x6000695")]
		public abstract Func<T, object> CreateGet<T>(PropertyInfo propertyInfo);

		// Token: 0x06000696 RID: 1686
		[Token(Token = "0x6000696")]
		public abstract Func<T, object> CreateGet<T>(FieldInfo fieldInfo);

		// Token: 0x06000697 RID: 1687
		[Token(Token = "0x6000697")]
		public abstract Action<T, object> CreateSet<T>(FieldInfo fieldInfo);

		// Token: 0x06000698 RID: 1688
		[Token(Token = "0x6000698")]
		public abstract Action<T, object> CreateSet<T>(PropertyInfo propertyInfo);

		// Token: 0x06000699 RID: 1689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000699")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		protected ReflectionDelegateFactory()
		{
		}
	}
}
