using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200000F RID: 15
	[Token(Token = "0x200000F")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	[DontApplyToListElements]
	[Conditional("UNITY_EDITOR")]
	public class DetailedInfoBoxAttribute : Attribute
	{
		// Token: 0x06000026 RID: 38 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x2A883F0", Offset = "0x2A869F0", VA = "0x182A883F0")]
		public DetailedInfoBoxAttribute(string message, string details, InfoMessageType infoMessageType = InfoMessageType.Info, [Optional] string visibleIf)
		{
		}

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Message;

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Details;

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InfoMessageType InfoMessageType;

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string VisibleIf;
	}
}
