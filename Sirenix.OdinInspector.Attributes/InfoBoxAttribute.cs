using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200003C RID: 60
	[Token(Token = "0x200003C")]
	[DontApplyToListElements]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public sealed class InfoBoxAttribute : Attribute
	{
		// Token: 0x06000070 RID: 112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x24EBAB0", Offset = "0x24EA0B0", VA = "0x1824EBAB0")]
		public InfoBoxAttribute(string message, InfoMessageType infoMessageType = InfoMessageType.Info, [Optional] string visibleIfMemberName)
		{
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x2A88BE0", Offset = "0x2A871E0", VA = "0x182A88BE0")]
		public InfoBoxAttribute(string message, string visibleIfMemberName)
		{
		}

		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Message;

		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InfoMessageType InfoMessageType;

		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string VisibleIf;

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool GUIAlwaysEnabled;
	}
}
