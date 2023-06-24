using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000E3 RID: 227
	[Token(Token = "0x20000E3")]
	[NullableContext(1)]
	[Nullable(0)]
	internal class ReflectionObject
	{
		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060006A1 RID: 1697 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000DB")]
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public ObjectConstructor<object> Creator
		{
			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060006A2 RID: 1698 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000DC")]
		public IDictionary<string, ReflectionMember> Members
		{
			[Token(Token = "0x60006A2")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x2568F60", Offset = "0x2567560", VA = "0x182568F60")]
		private ReflectionObject([Nullable(new byte[]
		{
			2,
			1
		})] ObjectConstructor<object> creator)
		{
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x2569080", Offset = "0x2567680", VA = "0x182569080")]
		public object GetValue(object target, string member)
		{
			return null;
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x2569100", Offset = "0x2567700", VA = "0x182569100")]
		public void SetValue(object target, string member, [Nullable(2)] object value)
		{
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x2569190", Offset = "0x2567790", VA = "0x182569190")]
		public Type GetType(string member)
		{
			return null;
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x25691F0", Offset = "0x25677F0", VA = "0x1825691F0")]
		public static ReflectionObject Create(Type t, params string[] memberNames)
		{
			return null;
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x2569200", Offset = "0x2567800", VA = "0x182569200")]
		public static ReflectionObject Create(Type t, [Nullable(2)] MethodBase creator, params string[] memberNames)
		{
			return null;
		}
	}
}
