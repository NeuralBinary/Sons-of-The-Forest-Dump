using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Pathfinding
{
	// Token: 0x0200006D RID: 109
	[Token(Token = "0x200006D")]
	public struct AstarWorkItem
	{
		// Token: 0x060003E3 RID: 995 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x66E2E0", Offset = "0x66C8E0", VA = "0x18066E2E0")]
		public AstarWorkItem(Func<bool, bool> update)
		{
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x66E440", Offset = "0x66CA40", VA = "0x18066E440")]
		public AstarWorkItem(Func<IWorkItemContext, bool, bool> update)
		{
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x66E5A0", Offset = "0x66CBA0", VA = "0x18066E5A0")]
		public AstarWorkItem(Action init, [Optional] Func<bool, bool> update)
		{
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x66E700", Offset = "0x66CD00", VA = "0x18066E700")]
		public AstarWorkItem(Action<IWorkItemContext> init, [Optional] Func<IWorkItemContext, bool, bool> update)
		{
		}

		// Token: 0x040002B9 RID: 697
		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Action init;

		// Token: 0x040002BA RID: 698
		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Action<IWorkItemContext> initWithContext;

		// Token: 0x040002BB RID: 699
		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Func<bool, bool> update;

		// Token: 0x040002BC RID: 700
		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<IWorkItemContext, bool, bool> updateWithContext;
	}
}
