using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200005B RID: 91
	[Token(Token = "0x200005B")]
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	public sealed class SceneObjectsOnlyAttribute : Attribute
	{
		// Token: 0x060000F6 RID: 246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public SceneObjectsOnlyAttribute()
		{
		}
	}
}
