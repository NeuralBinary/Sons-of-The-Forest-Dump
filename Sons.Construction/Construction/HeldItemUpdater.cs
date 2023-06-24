using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Construction
{
	// Token: 0x020000BD RID: 189
	[Token(Token = "0x20000BD")]
	public class HeldItemUpdater : IIdleStateUpdateReceiver
	{
		// Token: 0x170001BF RID: 447
		// (get) Token: 0x0600057B RID: 1403 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170001BF")]
		private ConstructionManager Manager
		{
			[Token(Token = "0x600057B")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600057C")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public HeldItemUpdater(ConstructionManager manager)
		{
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600057D")]
		[Address(RVA = "0x2E1E960", Offset = "0x2E1CF60", VA = "0x182E1E960", Slot = "4")]
		public void IdleStateUpdate(out ExitStatus exitStatus)
		{
		}
	}
}
