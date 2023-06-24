using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Construction
{
	// Token: 0x020000C0 RID: 192
	[Token(Token = "0x20000C0")]
	public class ManagerValuesUpdater : IIdleStateUpdateReceiver
	{
		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x0600057F RID: 1407 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170001C0")]
		private ConstructionManager Manager
		{
			[Token(Token = "0x600057F")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000580")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public ManagerValuesUpdater(ConstructionManager manager)
		{
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000581")]
		[Address(RVA = "0x2E1E9B0", Offset = "0x2E1CFB0", VA = "0x182E1E9B0", Slot = "4")]
		public void IdleStateUpdate(out ExitStatus exitStatus)
		{
		}
	}
}
