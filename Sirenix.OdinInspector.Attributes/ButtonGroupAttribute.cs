using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
	[ShowInInspector]
	[IncludeMyAttributes]
	public class ButtonGroupAttribute : PropertyGroupAttribute
	{
		// Token: 0x0600001B RID: 27 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x2A88380", Offset = "0x2A86980", VA = "0x182A88380")]
		public ButtonGroupAttribute(string group = "_DefaultGroup", float order = 0f)
		{
		}
	}
}
