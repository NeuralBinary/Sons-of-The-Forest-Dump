using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000014 RID: 20
	[Token(Token = "0x2000014")]
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.All)]
	[DontApplyToListElements]
	public class DisableInEditorModeAttribute : Attribute
	{
		// Token: 0x0600002E RID: 46 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public DisableInEditorModeAttribute()
		{
		}
	}
}
