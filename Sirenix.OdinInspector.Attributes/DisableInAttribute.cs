using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.All)]
	[DontApplyToListElements]
	public class DisableInAttribute : Attribute
	{
		// Token: 0x0600002D RID: 45 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40")]
		public DisableInAttribute(PrefabKind prefabKind)
		{
		}

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x10")]
		public PrefabKind PrefabKind;
	}
}
