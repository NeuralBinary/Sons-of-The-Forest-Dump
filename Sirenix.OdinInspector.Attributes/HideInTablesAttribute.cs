using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000035 RID: 53
	[Token(Token = "0x2000035")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
	[Conditional("UNITY_EDITOR")]
	public class HideInTablesAttribute : Attribute
	{
		// Token: 0x06000067 RID: 103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public HideInTablesAttribute()
		{
		}
	}
}
