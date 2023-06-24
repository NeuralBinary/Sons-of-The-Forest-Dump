using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000072 RID: 114
	[Token(Token = "0x2000072")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface, AllowMultiple = true, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public class TypeInfoBoxAttribute : Attribute
	{
		// Token: 0x0600012C RID: 300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public TypeInfoBoxAttribute(string message)
		{
		}

		// Token: 0x0400010A RID: 266
		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0x10")]
		public string Message;
	}
}
