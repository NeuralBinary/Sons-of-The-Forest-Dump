using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Construction
{
	// Token: 0x020000C3 RID: 195
	[Token(Token = "0x20000C3")]
	public class PredictedSnapPointsUpdater : IIdleStateUpdateReceiver
	{
		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x0600058C RID: 1420 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170001C6")]
		private ConstructionManager.PredictedSnapPointsLookup PredictedSnapPointsLookup
		{
			[Token(Token = "0x600058C")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x0600058D RID: 1421 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170001C7")]
		private ConstructionManager.PredictedSnapPointRepository PredictedSnapPointRepos
		{
			[Token(Token = "0x600058D")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600058E")]
		[Address(RVA = "0x992FC0", Offset = "0x9915C0", VA = "0x180992FC0")]
		public PredictedSnapPointsUpdater(ConstructionManager.PredictedSnapPointsLookup predictedSnapPointsLookup, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600058F")]
		[Address(RVA = "0x2E1ED90", Offset = "0x2E1D390", VA = "0x182E1ED90", Slot = "4")]
		public void IdleStateUpdate(out ExitStatus exitStatus)
		{
		}
	}
}
