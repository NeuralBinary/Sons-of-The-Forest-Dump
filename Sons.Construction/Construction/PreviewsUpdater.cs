using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Construction
{
	// Token: 0x020000C4 RID: 196
	[Token(Token = "0x20000C4")]
	public class PreviewsUpdater : IIdleStateUpdateReceiver
	{
		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000590 RID: 1424 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170001C8")]
		private ConstructionManager Manager
		{
			[Token(Token = "0x6000590")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000591")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public PreviewsUpdater(ConstructionManager manager)
		{
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000592")]
		[Address(RVA = "0x2E1EFC0", Offset = "0x2E1D5C0", VA = "0x182E1EFC0", Slot = "4")]
		public void IdleStateUpdate(out ExitStatus exitStatus)
		{
		}
	}
}
