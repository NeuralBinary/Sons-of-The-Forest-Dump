using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200003F RID: 63
	[Token(Token = "0x200003F")]
	[AttributeUsage(AttributeTargets.All, Inherited = false)]
	[Conditional("UNITY_EDITOR")]
	public class InlinePropertyAttribute : Attribute
	{
		// Token: 0x0600007B RID: 123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public InlinePropertyAttribute()
		{
		}

		// Token: 0x0400006E RID: 110
		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x10")]
		public int LabelWidth;
	}
}
