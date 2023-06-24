using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020000F3 RID: 243
	[Token(Token = "0x20000F3")]
	[Serializable]
	public abstract class PlaceOnGroundModule : ConstructionModule, INonStructureDynamicSnapPointModule, IDynamicSnapPointModule, IConstructionModule
	{
		// Token: 0x1700022E RID: 558
		// (get) Token: 0x060006E5 RID: 1765 RVA: 0x00004F64 File Offset: 0x00003164
		[Token(Token = "0x1700022E")]
		protected virtual bool ShowVerticalDashedLine
		{
			[Token(Token = "0x60006E5")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "78")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x060006E6 RID: 1766 RVA: 0x00004F7C File Offset: 0x0000317C
		[Token(Token = "0x1700022F")]
		protected virtual bool AllowPlacingOnBuiltGround
		{
			[Token(Token = "0x60006E6")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "79")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x060006E7 RID: 1767 RVA: 0x00004F94 File Offset: 0x00003194
		[Token(Token = "0x17000230")]
		protected virtual bool OnFlatGroundOnly
		{
			[Token(Token = "0x60006E7")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x060006E8 RID: 1768 RVA: 0x00004FAC File Offset: 0x000031AC
		[Token(Token = "0x17000231")]
		protected virtual float FlatGroundMinDot
		{
			[Token(Token = "0x60006E8")]
			[Address(RVA = "0x2E34C10", Offset = "0x2E33210", VA = "0x182E34C10", Slot = "81")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x060006E9 RID: 1769 RVA: 0x00004FC4 File Offset: 0x000031C4
		[Token(Token = "0x17000232")]
		public override UiMessages StagedUiMessages
		{
			[Token(Token = "0x60006E9")]
			[Address(RVA = "0x6A2B30", Offset = "0x6A1130", VA = "0x1806A2B30", Slot = "43")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x2E34C20", Offset = "0x2E33220", VA = "0x182E34C20")]
		protected PlaceOnGroundModule(ModuleProfileDatabase horizontalDB, ModuleProfileDatabase verticalDB, [Optional] IPlacementModeGroup placementModeGroup)
		{
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x00004FDC File Offset: 0x000031DC
		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x2E34C30", Offset = "0x2E33230", VA = "0x182E34C30", Slot = "77")]
		public bool TryStage(ModuleState state)
		{
			return default(bool);
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x00004FF4 File Offset: 0x000031F4
		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x2E34D60", Offset = "0x2E33360", VA = "0x182E34D60", Slot = "55")]
		public override bool TogglePlacementMode(ModuleState state)
		{
			return default(bool);
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x2E34E90", Offset = "0x2E33490", VA = "0x182E34E90", Slot = "60")]
		public override void StagedUpdate(ModuleState state)
		{
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x0000500C File Offset: 0x0000320C
		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x2E35120", Offset = "0x2E33720", VA = "0x182E35120", Slot = "82")]
		protected virtual Vector3 GetPlacePosition(TargetInfo targetInfo)
		{
			return default(Vector3);
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x2E35150", Offset = "0x2E33750", VA = "0x182E35150", Slot = "83")]
		protected virtual void GetOverlapCheckSize(ModuleState state, TargetInfo targetInfo, out Vector3 structureProximitySize, out Vector3 sceneryOverlapSize, out Vector3 offset, out Quaternion rot)
		{
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x2E35350", Offset = "0x2E33950", VA = "0x182E35350", Slot = "84")]
		protected virtual void CheckForInvalidPlacement(ModuleState state)
		{
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x00005024 File Offset: 0x00003224
		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x2E35700", Offset = "0x2E33D00", VA = "0x182E35700", Slot = "85")]
		protected virtual bool UsingAltPlacement(ModuleState state)
		{
			return default(bool);
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x2E35760", Offset = "0x2E33D60", VA = "0x182E35760", Slot = "86")]
		protected virtual void GetPreviewUiPositioningInfo(ModuleState state, TargetInfo targetInfo, out Vector3 snapPos, out Vector3 placeAxis, out Vector3 size, out bool reUseActive)
		{
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x2E357E0", Offset = "0x2E33DE0", VA = "0x182E357E0", Slot = "57")]
		protected override void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x2E35F30", Offset = "0x2E34530", VA = "0x182E35F30", Slot = "87")]
		protected virtual void ShowDetachedPlacementPreview(TargetInfo targetInfo, ref Vector3 elementSize, ref Vector3 snapPos)
		{
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x0000503C File Offset: 0x0000323C
		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x2E36400", Offset = "0x2E34A00", VA = "0x182E36400")]
		private bool TryGetSnapPointOnGround(ConstructionManager manager, TargetInfo targetInfo, ModuleProfile profile, int placementMode, out Vector3 snapPos, out Vector3 placeAxis)
		{
			return default(bool);
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x00005054 File Offset: 0x00003254
		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x2E36E90", Offset = "0x2E35490", VA = "0x182E36E90")]
		private float CalcFlatDistance(Vector3 from, Vector3 to)
		{
			return 0f;
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x0000506C File Offset: 0x0000326C
		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x2E36F80", Offset = "0x2E35580", VA = "0x182E36F80", Slot = "64")]
		public override bool TryActivate(ModuleState state)
		{
			return default(bool);
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x00005084 File Offset: 0x00003284
		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x2E37000", Offset = "0x2E35600", VA = "0x182E37000")]
		[CompilerGenerated]
		internal static bool <CheckForInvalidPlacement>g__CheckForSceneryOverlaps|16_0(Vector3 snapPos, Quaternion rot, Vector3 structureProximitySize)
		{
			return default(bool);
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x0000509C File Offset: 0x0000329C
		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x2E372B0", Offset = "0x2E358B0", VA = "0x182E372B0")]
		[CompilerGenerated]
		private bool <CheckForInvalidPlacement>g__CheckForStructureProximity|16_1(TargetInfo targetInfo, Vector3 snapPos, Quaternion rot, Vector3 structureProximitySize)
		{
			return default(bool);
		}
	}
}
