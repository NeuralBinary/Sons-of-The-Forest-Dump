using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000070 RID: 112
	[Token(Token = "0x2000070")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public sealed class ToggleLeftAttribute : Attribute
	{
		// Token: 0x06000128 RID: 296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ToggleLeftAttribute()
		{
		}
	}
}
