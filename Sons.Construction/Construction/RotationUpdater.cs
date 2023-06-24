using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Construction
{
	// Token: 0x020000C5 RID: 197
	[Token(Token = "0x20000C5")]
	public class RotationUpdater : IIdleStateUpdateReceiver
	{
		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000593 RID: 1427 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170001C9")]
		private ConstructionManager Manager
		{
			[Token(Token = "0x6000593")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000594 RID: 1428 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170001CA")]
		private ConstructionManager.StagedModuleInfo StagedModuleInfo
		{
			[Token(Token = "0x6000594")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000595")]
		[Address(RVA = "0x992FC0", Offset = "0x9915C0", VA = "0x180992FC0")]
		public RotationUpdater(ConstructionManager manager, ConstructionManager.StagedModuleInfo stagedModuleInfo)
		{
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000596")]
		[Address(RVA = "0x2E1F040", Offset = "0x2E1D640", VA = "0x182E1F040", Slot = "4")]
		public void IdleStateUpdate(out ExitStatus exitStatus)
		{
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000597")]
		[Address(RVA = "0x2E1F060", Offset = "0x2E1D660", VA = "0x182E1F060")]
		private void ProcessRotation()
		{
		}
	}
}
