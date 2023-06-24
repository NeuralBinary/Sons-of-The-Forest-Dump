using System;
using System.ComponentModel;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000019")]
	[DontApplyToListElements]
	[AttributeUsage(AttributeTargets.All)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("Use [DisableIn(PrefabKind.PrefabInstance)] instead.", false)]
	[Conditional("UNITY_EDITOR")]
	public class DisableInPrefabInstancesAttribute : Attribute
	{
		// Token: 0x06000033 RID: 51 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public DisableInPrefabInstancesAttribute()
		{
		}
	}
}
