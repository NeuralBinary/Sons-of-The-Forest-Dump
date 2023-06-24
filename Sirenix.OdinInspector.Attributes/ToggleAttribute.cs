using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200006E RID: 110
	[Token(Token = "0x200006E")]
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	public sealed class ToggleAttribute : Attribute
	{
		// Token: 0x06000120 RID: 288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000120")]
		[Address(RVA = "0xA90600", Offset = "0xA8EC00", VA = "0x180A90600")]
		public ToggleAttribute(string toggleMemberName)
		{
		}

		// Token: 0x04000102 RID: 258
		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0x10")]
		public string ToggleMemberName;

		// Token: 0x04000103 RID: 259
		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0x18")]
		public bool CollapseOthersOnExpand;
	}
}
