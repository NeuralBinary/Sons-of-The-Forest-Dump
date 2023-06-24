using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000045 RID: 69
	[Token(Token = "0x2000045")]
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	public sealed class MinValueAttribute : Attribute
	{
		// Token: 0x060000A4 RID: 164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x1240180", Offset = "0x123E780", VA = "0x181240180")]
		public MinValueAttribute(double minValue)
		{
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
		public MinValueAttribute(string expression)
		{
		}

		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x10")]
		public double MinValue;

		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x18")]
		public string Expression;
	}
}
