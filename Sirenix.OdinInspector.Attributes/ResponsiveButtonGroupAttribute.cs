using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200005A RID: 90
	[Token(Token = "0x200005A")]
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
	[ShowInInspector]
	[IncludeMyAttributes]
	public class ResponsiveButtonGroupAttribute : PropertyGroupAttribute
	{
		// Token: 0x060000F4 RID: 244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x2A89B20", Offset = "0x2A88120", VA = "0x182A89B20")]
		public ResponsiveButtonGroupAttribute(string group = "_DefaultResponsiveButtonGroup")
		{
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x2A89B40", Offset = "0x2A88140", VA = "0x182A89B40", Slot = "7")]
		protected override void CombineValuesWith(PropertyGroupAttribute other)
		{
		}

		// Token: 0x040000CD RID: 205
		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x38")]
		public ButtonSizes DefaultButtonSize;

		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x3C")]
		public bool UniformLayout;
	}
}
