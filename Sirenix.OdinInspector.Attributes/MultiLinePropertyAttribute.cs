using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000046 RID: 70
	[Token(Token = "0x2000046")]
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	public sealed class MultiLinePropertyAttribute : Attribute
	{
		// Token: 0x060000A6 RID: 166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x2A890C0", Offset = "0x2A876C0", VA = "0x182A890C0")]
		public MultiLinePropertyAttribute(int lines = 3)
		{
		}

		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x10")]
		public int Lines;
	}
}
