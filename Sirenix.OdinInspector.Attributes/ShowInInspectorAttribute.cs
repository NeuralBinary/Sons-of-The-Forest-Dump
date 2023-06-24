using System;
using System.Diagnostics;
using Il2CppDummyDll;
using JetBrains.Annotations;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000062 RID: 98
	[Token(Token = "0x2000062")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = false)]
	[Conditional("UNITY_EDITOR")]
	[MeansImplicitUse]
	public class ShowInInspectorAttribute : Attribute
	{
		// Token: 0x06000108 RID: 264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ShowInInspectorAttribute()
		{
		}
	}
}
