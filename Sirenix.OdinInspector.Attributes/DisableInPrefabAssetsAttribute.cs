using System;
using System.ComponentModel;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000018 RID: 24
	[Token(Token = "0x2000018")]
	[DontApplyToListElements]
	[AttributeUsage(AttributeTargets.All)]
	[Conditional("UNITY_EDITOR")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("Use [DisableIn(PrefabKind.PrefabAsset)] instead.", false)]
	public class DisableInPrefabAssetsAttribute : Attribute
	{
		// Token: 0x06000032 RID: 50 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public DisableInPrefabAssetsAttribute()
		{
		}
	}
}
