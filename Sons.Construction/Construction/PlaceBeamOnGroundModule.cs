using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200013C RID: 316
	[Token(Token = "0x200013C")]
	public class PlaceBeamOnGroundModule : PlaceOnGroundModule
	{
		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000944 RID: 2372 RVA: 0x000060EC File Offset: 0x000042EC
		[Token(Token = "0x17000272")]
		public override bool ConsumesProfileItem
		{
			[Token(Token = "0x6000944")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000945 RID: 2373 RVA: 0x00006104 File Offset: 0x00004304
		[Token(Token = "0x17000273")]
		protected override bool ShowVerticalDashedLine
		{
			[Token(Token = "0x6000945")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "78")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000946 RID: 2374 RVA: 0x0000611C File Offset: 0x0000431C
		[Token(Token = "0x17000274")]
		public override UiMessages StagedUiMessages
		{
			[Token(Token = "0x6000946")]
			[Address(RVA = "0x2E73E30", Offset = "0x2E72430", VA = "0x182E73E30", Slot = "43")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000947")]
		[Address(RVA = "0x2E73E40", Offset = "0x2E72440", VA = "0x182E73E40")]
		public PlaceBeamOnGroundModule(ModuleProfileDatabase horizontalDB, ModuleProfileDatabase fakePilarProfileDB, IPlacementModeGroup placementModeGroup)
		{
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000948")]
		[Address(RVA = "0x2E73EB0", Offset = "0x2E724B0", VA = "0x182E73EB0", Slot = "86")]
		protected override void GetPreviewUiPositioningInfo(ModuleState state, TargetInfo targetInfo, out Vector3 snapPos, out Vector3 placeAxis, out Vector3 size, out bool reUseActive)
		{
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000949")]
		[Address(RVA = "0x2E741D0", Offset = "0x2E727D0", VA = "0x182E741D0", Slot = "87")]
		protected override void ShowDetachedPlacementPreview(TargetInfo targetInfo, ref Vector3 elementSize, ref Vector3 snapPos)
		{
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x00006134 File Offset: 0x00004334
		[Token(Token = "0x600094A")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "85")]
		protected override bool UsingAltPlacement(ModuleState state)
		{
			return default(bool);
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600094B")]
		[Address(RVA = "0x2E74610", Offset = "0x2E72C10", VA = "0x182E74610", Slot = "83")]
		protected override void GetOverlapCheckSize(ModuleState state, TargetInfo targetInfo, out Vector3 structureProximitySize, out Vector3 sceneryOverlapSize, out Vector3 offset, out Quaternion rot)
		{
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600094C")]
		[Address(RVA = "0x2E74850", Offset = "0x2E72E50", VA = "0x182E74850", Slot = "84")]
		protected override void CheckForInvalidPlacement(ModuleState state)
		{
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x0000614C File Offset: 0x0000434C
		[Token(Token = "0x600094D")]
		[Address(RVA = "0x2E75030", Offset = "0x2E73630", VA = "0x182E75030", Slot = "70")]
		public override bool TryValidateTargetInfo(TargetInfo targetInfo, int placementMode)
		{
			return default(bool);
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600094E")]
		[Address(RVA = "0x2E75340", Offset = "0x2E73940", VA = "0x182E75340", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x00006164 File Offset: 0x00004364
		[Token(Token = "0x600094F")]
		[Address(RVA = "0x2E75950", Offset = "0x2E73F50", VA = "0x182E75950")]
		private bool TryGetAboveGroundPlaceHeight(Vector3 placePos, Vector3 placeAxis, out float groundHeight)
		{
			return default(bool);
		}

		// Token: 0x0400065D RID: 1629
		[Token(Token = "0x400065D")]
		[FieldOffset(Offset = "0x68")]
		private ModuleProfileDatabase _fakePilarProfileDB;
	}
}
