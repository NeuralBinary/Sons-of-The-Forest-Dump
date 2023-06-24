using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000069 RID: 105
	[Token(Token = "0x2000069")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
	[Conditional("UNITY_EDITOR")]
	public class TableColumnWidthAttribute : Attribute
	{
		// Token: 0x06000115 RID: 277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x98F6C0", Offset = "0x98DCC0", VA = "0x18098F6C0")]
		public TableColumnWidthAttribute(int width, bool resizable = true)
		{
		}

		// Token: 0x040000DF RID: 223
		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x10")]
		public int Width;

		// Token: 0x040000E0 RID: 224
		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x14")]
		public bool Resizable;
	}
}
