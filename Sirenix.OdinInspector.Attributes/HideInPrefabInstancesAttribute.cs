using System;
using System.ComponentModel;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000033 RID: 51
	[Token(Token = "0x2000033")]
	[Obsolete("Use [HideIn(PrefabKind.PrefabInstance)] instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.All)]
	[DontApplyToListElements]
	public class HideInPrefabInstancesAttribute : Attribute
	{
		// Token: 0x06000065 RID: 101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public HideInPrefabInstancesAttribute()
		{
		}
	}
}
