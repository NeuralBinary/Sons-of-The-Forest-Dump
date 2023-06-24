using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000138 RID: 312
	[Token(Token = "0x2000138")]
	[Nullable(0)]
	[NullableContext(1)]
	public class ReflectionValueProvider : IValueProvider
	{
		// Token: 0x06000991 RID: 2449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000991")]
		[Address(RVA = "0x25A3580", Offset = "0x25A1B80", VA = "0x1825A3580")]
		public ReflectionValueProvider(MemberInfo memberInfo)
		{
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000992")]
		[Address(RVA = "0x25A3650", Offset = "0x25A1C50", VA = "0x1825A3650", Slot = "4")]
		public void SetValue(object target, [Nullable(2)] object value)
		{
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000993")]
		[Address(RVA = "0x25A37A0", Offset = "0x25A1DA0", VA = "0x1825A37A0", Slot = "5")]
		public object GetValue(object target)
		{
			return null;
		}

		// Token: 0x040005BD RID: 1469
		[Token(Token = "0x40005BD")]
		[FieldOffset(Offset = "0x10")]
		private readonly MemberInfo _memberInfo;
	}
}
