using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000041 RID: 65
	[Token(Token = "0x2000041")]
	[DontApplyToListElements]
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	public class LabelWidthAttribute : Attribute
	{
		// Token: 0x0600007E RID: 126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007E")]
		[Address(RVA = "0xA308E0", Offset = "0xA2EEE0", VA = "0x180A308E0")]
		public LabelWidthAttribute(float width)
		{
		}

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x10")]
		public float Width;
	}
}
