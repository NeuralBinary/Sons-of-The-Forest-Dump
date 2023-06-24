using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200003B RID: 59
	[Token(Token = "0x200003B")]
	[DontApplyToListElements]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public sealed class IndentAttribute : Attribute
	{
		// Token: 0x0600006F RID: 111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40")]
		public IndentAttribute(int indentLevel = 1)
		{
		}

		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x10")]
		public int IndentLevel;
	}
}
