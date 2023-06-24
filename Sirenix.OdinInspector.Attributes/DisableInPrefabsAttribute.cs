using System;
using System.ComponentModel;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200001A RID: 26
	[Token(Token = "0x200001A")]
	[Obsolete("Use [DisableIn(PrefabKind.PrefabAsset | PrefabKind.PrefabInstance)] instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DontApplyToListElements]
	[AttributeUsage(AttributeTargets.All)]
	[Conditional("UNITY_EDITOR")]
	public class DisableInPrefabsAttribute : Attribute
	{
		// Token: 0x06000034 RID: 52 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public DisableInPrefabsAttribute()
		{
		}
	}
}
