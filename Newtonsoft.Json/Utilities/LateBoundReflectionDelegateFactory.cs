using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000D5 RID: 213
	[Token(Token = "0x20000D5")]
	[NullableContext(1)]
	[Nullable(0)]
	internal class LateBoundReflectionDelegateFactory : ReflectionDelegateFactory
	{
		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600065E RID: 1630 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000D7")]
		internal static ReflectionDelegateFactory Instance
		{
			[Token(Token = "0x600065E")]
			[Address(RVA = "0x2567B20", Offset = "0x2566120", VA = "0x182567B20")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600065F")]
		[Address(RVA = "0x2567B70", Offset = "0x2566170", VA = "0x182567B70", Slot = "5")]
		public override ObjectConstructor<object> CreateParameterizedConstructor(MethodBase method)
		{
			return null;
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000660")]
		public override MethodCall<T, object> CreateMethodCall<T>(MethodBase method)
		{
			return null;
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000661")]
		public override Func<T> CreateDefaultConstructor<T>(Type type)
		{
			return null;
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000662")]
		public override Func<T, object> CreateGet<T>(PropertyInfo propertyInfo)
		{
			return null;
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000663")]
		public override Func<T, object> CreateGet<T>(FieldInfo fieldInfo)
		{
			return null;
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000664")]
		public override Action<T, object> CreateSet<T>(FieldInfo fieldInfo)
		{
			return null;
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000665")]
		public override Action<T, object> CreateSet<T>(PropertyInfo propertyInfo)
		{
			return null;
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000666")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public LateBoundReflectionDelegateFactory()
		{
		}

		// Token: 0x040004A6 RID: 1190
		[Token(Token = "0x40004A6")]
		[FieldOffset(Offset = "0x0")]
		private static readonly LateBoundReflectionDelegateFactory _instance;
	}
}
