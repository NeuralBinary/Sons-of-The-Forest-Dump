using System;
using System.ComponentModel;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000032 RID: 50
	[Token(Token = "0x2000032")]
	[DontApplyToListElements]
	[Obsolete("Use [HideIn(PrefabKind.PrefabAsset)] instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[AttributeUsage(AttributeTargets.All)]
	[Conditional("UNITY_EDITOR")]
	public class HideInPrefabAssetsAttribute : Attribute
	{
		// Token: 0x06000064 RID: 100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public HideInPrefabAssetsAttribute()
		{
		}
	}
}
