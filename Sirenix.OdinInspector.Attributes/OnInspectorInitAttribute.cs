using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200004A RID: 74
	[Token(Token = "0x200004A")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
	[Conditional("UNITY_EDITOR")]
	[DontApplyToListElements]
	[IncludeMyAttributes]
	[HideInTables]
	public class OnInspectorInitAttribute : ShowInInspectorAttribute
	{
		// Token: 0x060000AF RID: 175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public OnInspectorInitAttribute()
		{
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public OnInspectorInitAttribute(string action)
		{
		}

		// Token: 0x0400009E RID: 158
		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x10")]
		public string Action;
	}
}
