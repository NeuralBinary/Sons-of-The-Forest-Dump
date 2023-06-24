using System;
using Il2CppDummyDll;

namespace Construction
{
	// Token: 0x020000E0 RID: 224
	[Token(Token = "0x20000E0")]
	public interface ISnapPointPredictingModule : IConstructionModule
	{
		// Token: 0x06000699 RID: 1689
		[Token(Token = "0x6000699")]
		bool TryGetPreComputedSnapPoints(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository managerPredictedSnapPointRepos);

		// Token: 0x0600069A RID: 1690
		[Token(Token = "0x600069A")]
		void SetBlockedByPlacementMode();

		// Token: 0x0600069B RID: 1691
		[Token(Token = "0x600069B")]
		bool ValidateHeldItem(ModuleState state);
	}
}
