using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000057 RID: 87
	[Token(Token = "0x2000057")]
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	public class RequiredInAttribute : Attribute
	{
		// Token: 0x060000EB RID: 235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x6DDE70", Offset = "0x6DC470", VA = "0x1806DDE70")]
		public RequiredInAttribute(PrefabKind kind)
		{
		}

		// Token: 0x040000C7 RID: 199
		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x10")]
		public string ErrorMessage;

		// Token: 0x040000C8 RID: 200
		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x18")]
		public PrefabKind PrefabKind;
	}
}
