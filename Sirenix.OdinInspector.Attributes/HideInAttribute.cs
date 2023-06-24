using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200002D RID: 45
	[Token(Token = "0x200002D")]
	[AttributeUsage(AttributeTargets.All)]
	[Conditional("UNITY_EDITOR")]
	public class HideInAttribute : Attribute
	{
		// Token: 0x0600005F RID: 95 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40")]
		public HideInAttribute(PrefabKind prefabKind)
		{
		}

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x10")]
		public PrefabKind PrefabKind;
	}
}
