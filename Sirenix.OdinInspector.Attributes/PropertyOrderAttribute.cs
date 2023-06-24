using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000051 RID: 81
	[Token(Token = "0x2000051")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public class PropertyOrderAttribute : Attribute
	{
		// Token: 0x060000D8 RID: 216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public PropertyOrderAttribute()
		{
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0xA308E0", Offset = "0xA2EEE0", VA = "0x180A308E0")]
		public PropertyOrderAttribute(float order)
		{
		}

		// Token: 0x040000BD RID: 189
		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x10")]
		public float Order;
	}
}
