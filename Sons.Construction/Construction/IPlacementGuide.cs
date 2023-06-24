using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020000E5 RID: 229
	[Token(Token = "0x20000E5")]
	public interface IPlacementGuide
	{
		// Token: 0x1700021A RID: 538
		// (get) Token: 0x060006AD RID: 1709
		[Token(Token = "0x1700021A")]
		UiMessages StagedUiMessage { [Token(Token = "0x60006AD")] get; }

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x060006AE RID: 1710
		[Token(Token = "0x1700021B")]
		bool AllowAlternatingPlacement { [Token(Token = "0x60006AE")] get; }

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x060006AF RID: 1711
		[Token(Token = "0x1700021C")]
		bool AllowFreeSnap { [Token(Token = "0x60006AF")] get; }

		// Token: 0x060006B0 RID: 1712
		[Token(Token = "0x60006B0")]
		void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state);

		// Token: 0x060006B1 RID: 1713
		[Token(Token = "0x60006B1")]
		void ValidateGroundedPlacementPosition(ConstructionManager manager, Transform canvasTr, float distanceBetweenElements, ref Vector3 placePosition, out bool splitToNewCanvas);

		// Token: 0x060006B2 RID: 1714
		[Token(Token = "0x60006B2")]
		void CheckAxisSnapping(ref Vector3 placeAxis);
	}
}
