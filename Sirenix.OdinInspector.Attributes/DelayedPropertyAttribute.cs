using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public class DelayedPropertyAttribute : Attribute
	{
		// Token: 0x06000025 RID: 37 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public DelayedPropertyAttribute()
		{
		}
	}
}
