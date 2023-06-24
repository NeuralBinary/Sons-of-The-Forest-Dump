using System;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200016A RID: 362
	[Token(Token = "0x200016A")]
	public class PlaceEffigyModule : ConstructionModule, IOnStructureDynamicSnapPointModule, IDynamicSnapPointModule, IConstructionModule
	{
		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000AC5 RID: 2757 RVA: 0x00006FD4 File Offset: 0x000051D4
		[Token(Token = "0x170002B5")]
		public override bool ConsumesProfileItem
		{
			[Token(Token = "0x6000AC5")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AC6")]
		[Address(RVA = "0x2EA0FD0", Offset = "0x2E9F5D0", VA = "0x182EA0FD0")]
		public PlaceEffigyModule(ModuleProfileDatabase effigyDB)
		{
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x00006FEC File Offset: 0x000051EC
		[Token(Token = "0x6000AC7")]
		[Address(RVA = "0x2EA1050", Offset = "0x2E9F650", VA = "0x182EA1050", Slot = "77")]
		public bool TryStage(ModuleState state)
		{
			return default(bool);
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x00007004 File Offset: 0x00005204
		[Token(Token = "0x6000AC8")]
		[Address(RVA = "0x2EA17E0", Offset = "0x2E9FDE0", VA = "0x182EA17E0")]
		private bool TryGetEffigySnapPosFromSupport(TargetInfo targetInfo, out Vector3 snapPos, out Vector3 placeAxis, out IEffigySupport targetSupport)
		{
			return default(bool);
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x0000701C File Offset: 0x0000521C
		[Token(Token = "0x6000AC9")]
		[Address(RVA = "0x2EA1B50", Offset = "0x2EA0150", VA = "0x182EA1B50")]
		private bool TryGetEffigySnapPosFromEffigy(TargetInfo targetInfo, ModuleState state, out Vector3 snapPos, out Vector3 placeAxis, out EffigyStructure editingEffigy, out bool isInvalid)
		{
			return default(bool);
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ACA")]
		[Address(RVA = "0x2EA1FD0", Offset = "0x2EA05D0", VA = "0x182EA1FD0", Slot = "60")]
		public override void StagedUpdate(ModuleState state)
		{
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x00007034 File Offset: 0x00005234
		[Token(Token = "0x6000ACB")]
		[Address(RVA = "0x2EA2600", Offset = "0x2EA0C00", VA = "0x182EA2600", Slot = "54")]
		public override bool TryValidateProfile(ItemData targetItem, int placementMode, TargetInfo targetInfo, ref ModuleProfile profile)
		{
			return default(bool);
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ACC")]
		[Address(RVA = "0x2EA2770", Offset = "0x2EA0D70", VA = "0x182EA2770", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}
	}
}
