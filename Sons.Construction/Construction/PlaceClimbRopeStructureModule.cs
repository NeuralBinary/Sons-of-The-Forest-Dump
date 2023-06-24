using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020001E2 RID: 482
	[Token(Token = "0x20001E2")]
	public class PlaceClimbRopeStructureModule : ConstructionModule, IOnStructureDynamicSnapPointModule, IDynamicSnapPointModule, IConstructionModule
	{
		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000E3E RID: 3646 RVA: 0x00008DA4 File Offset: 0x00006FA4
		[Token(Token = "0x17000352")]
		public override bool ConsumesProfileItem
		{
			[Token(Token = "0x6000E3E")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000E3F RID: 3647 RVA: 0x00008DBC File Offset: 0x00006FBC
		[Token(Token = "0x17000353")]
		public override bool AllowsMovementWhenActivated
		{
			[Token(Token = "0x6000E3F")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "41")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000E40 RID: 3648 RVA: 0x00008DD4 File Offset: 0x00006FD4
		[Token(Token = "0x17000354")]
		public override UiMessages StagedUiMessages
		{
			[Token(Token = "0x6000E40")]
			[Address(RVA = "0x2E87740", Offset = "0x2E85D40", VA = "0x182E87740", Slot = "43")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x06000E41 RID: 3649 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E41")]
		[Address(RVA = "0x2E2C400", Offset = "0x2E2AA00", VA = "0x182E2C400")]
		public PlaceClimbRopeStructureModule(ModuleProfileDatabase profileDatabase)
		{
		}

		// Token: 0x06000E42 RID: 3650 RVA: 0x00008DEC File Offset: 0x00006FEC
		[Token(Token = "0x6000E42")]
		[Address(RVA = "0x2EE7FF0", Offset = "0x2EE65F0", VA = "0x182EE7FF0", Slot = "77")]
		public bool TryStage(ModuleState state)
		{
			return default(bool);
		}

		// Token: 0x06000E43 RID: 3651 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E43")]
		[Address(RVA = "0x2EE8170", Offset = "0x2EE6770", VA = "0x182EE8170", Slot = "57")]
		protected override void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x06000E44 RID: 3652 RVA: 0x00008E04 File Offset: 0x00007004
		[Token(Token = "0x6000E44")]
		[Address(RVA = "0x2EE8330", Offset = "0x2EE6930", VA = "0x182EE8330")]
		private bool TryGetClimbRopeSnapPointFromSupport(TargetInfo targetInfo, out Vector3 snapPos, out Directions snapDir, out IClimbRopeSupport support)
		{
			return default(bool);
		}

		// Token: 0x06000E45 RID: 3653 RVA: 0x00008E1C File Offset: 0x0000701C
		[Token(Token = "0x6000E45")]
		[Address(RVA = "0x2EE8820", Offset = "0x2EE6E20", VA = "0x182EE8820", Slot = "70")]
		public override bool TryValidateTargetInfo(TargetInfo targetInfo, int placementMode)
		{
			return default(bool);
		}

		// Token: 0x06000E46 RID: 3654 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E46")]
		[Address(RVA = "0x2EE8A70", Offset = "0x2EE7070", VA = "0x182EE8A70", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x06000E47 RID: 3655 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E47")]
		[Address(RVA = "0x2EE8B80", Offset = "0x2EE7180", VA = "0x182EE8B80")]
		private void CreateNewClimbingRope(TargetInfo targetInfo)
		{
		}
	}
}
