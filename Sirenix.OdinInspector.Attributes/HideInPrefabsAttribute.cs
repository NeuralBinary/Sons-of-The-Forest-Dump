using System;
using System.ComponentModel;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000034 RID: 52
	[Token(Token = "0x2000034")]
	[AttributeUsage(AttributeTargets.All)]
	[DontApplyToListElements]
	[Conditional("UNITY_EDITOR")]
	[Obsolete("Use [HideIn(PrefabKind.PrefabAsset | PrefabKind.PrefabInstance)] instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class HideInPrefabsAttribute : Attribute
	{
		// Token: 0x06000066 RID: 102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public HideInPrefabsAttribute()
		{
		}
	}
}
