using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200004B RID: 75
	[Token(Token = "0x200004B")]
	[DontApplyToListElements]
	[IncludeMyAttributes]
	[HideInTables]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public sealed class OnStateUpdateAttribute : Attribute
	{
		// Token: 0x060000B1 RID: 177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public OnStateUpdateAttribute(string action)
		{
		}

		// Token: 0x0400009F RID: 159
		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x10")]
		public string Action;
	}
}
