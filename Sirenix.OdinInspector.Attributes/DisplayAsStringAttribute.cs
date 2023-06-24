using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200001C RID: 28
	[Token(Token = "0x200001C")]
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	public sealed class DisplayAsStringAttribute : Attribute
	{
		// Token: 0x06000036 RID: 54 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x704F00", Offset = "0x703500", VA = "0x180704F00")]
		public DisplayAsStringAttribute()
		{
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x5FD4F0", Offset = "0x5FBAF0", VA = "0x1805FD4F0")]
		public DisplayAsStringAttribute(bool overflow)
		{
		}

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x10")]
		public bool Overflow;
	}
}
