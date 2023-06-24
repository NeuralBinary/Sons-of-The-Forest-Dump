using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	[Conditional("UNITY_EDITOR")]
	public class ChildGameObjectsOnlyAttribute : Attribute
	{
		// Token: 0x0600001C RID: 28 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x704F00", Offset = "0x703500", VA = "0x180704F00")]
		public ChildGameObjectsOnlyAttribute()
		{
		}

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x10")]
		public bool IncludeSelf;

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x11")]
		public bool IncludeInactive;
	}
}
