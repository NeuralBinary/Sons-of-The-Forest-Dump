using System;
using System.ComponentModel;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000030 RID: 48
	[Token(Token = "0x2000030")]
	[Obsolete("Use [HideIn(PrefabKind.NonPrefabInstance)] instead.", false)]
	[DontApplyToListElements]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.All)]
	public class HideInNonPrefabsAttribute : Attribute
	{
		// Token: 0x06000062 RID: 98 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public HideInNonPrefabsAttribute()
		{
		}
	}
}
