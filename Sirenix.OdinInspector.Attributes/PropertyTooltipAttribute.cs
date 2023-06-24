using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000054 RID: 84
	[Token(Token = "0x2000054")]
	[DontApplyToListElements]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public sealed class PropertyTooltipAttribute : Attribute
	{
		// Token: 0x060000E5 RID: 229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public PropertyTooltipAttribute(string tooltip)
		{
		}

		// Token: 0x040000C4 RID: 196
		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x10")]
		public string Tooltip;
	}
}
