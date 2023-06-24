using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200022A RID: 554
	[Token(Token = "0x200022A")]
	[Serializable]
	public class PlaceTarpOnGroundModule : PlaceOnGroundModule, ISnapPointPredictingModule, IConstructionModule, IOnStructureDynamicSnapPointModule, IDynamicSnapPointModule
	{
		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x060010E9 RID: 4329 RVA: 0x0000A5BC File Offset: 0x000087BC
		[Token(Token = "0x170003E2")]
		public override bool ConsumesProfileItem
		{
			[Token(Token = "0x60010E9")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x060010EA RID: 4330 RVA: 0x0000A5D4 File Offset: 0x000087D4
		[Token(Token = "0x170003E3")]
		public override bool AllowInCaves
		{
			[Token(Token = "0x60010EA")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "38")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x060010EB RID: 4331 RVA: 0x0000A5EC File Offset: 0x000087EC
		[Token(Token = "0x170003E4")]
		protected override bool AllowPlacingOnBuiltGround
		{
			[Token(Token = "0x60010EB")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "79")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x060010EC RID: 4332 RVA: 0x0000A604 File Offset: 0x00008804
		[Token(Token = "0x170003E5")]
		public override UiMessages StagedUiMessages
		{
			[Token(Token = "0x60010EC")]
			[Address(RVA = "0xE59CE0", Offset = "0xE582E0", VA = "0x180E59CE0", Slot = "43")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x060010ED RID: 4333 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010ED")]
		[Address(RVA = "0x2F19420", Offset = "0x2F17A20", VA = "0x182F19420")]
		public PlaceTarpOnGroundModule(ModuleProfileDatabase horizontalDB)
		{
		}

		// Token: 0x060010EE RID: 4334 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010EE")]
		[Address(RVA = "0x2F194A0", Offset = "0x2F17AA0", VA = "0x182F194A0", Slot = "83")]
		protected override void GetOverlapCheckSize(ModuleState state, TargetInfo targetInfo, out Vector3 structureProximitySize, out Vector3 sceneryOverlapSize, out Vector3 offset, out Quaternion rot)
		{
		}

		// Token: 0x060010EF RID: 4335 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010EF")]
		[Address(RVA = "0x2F197D0", Offset = "0x2F17DD0", VA = "0x182F197D0", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x060010F0 RID: 4336 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010F0")]
		[Address(RVA = "0x2F19990", Offset = "0x2F17F90", VA = "0x182F19990")]
		private static void LinkWithNearbyTarps(TarpStructure tarpC)
		{
		}

		// Token: 0x060010F1 RID: 4337 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60010F1")]
		[Address(RVA = "0x2F1A370", Offset = "0x2F18970", VA = "0x182F1A370")]
		private IEnumerator TestTweenRoutine(TarpStructure tarp, TarpDirections dir, Vector3 groundPos)
		{
			return null;
		}

		// Token: 0x060010F2 RID: 4338 RVA: 0x0000A61C File Offset: 0x0000881C
		[Token(Token = "0x60010F2")]
		[Address(RVA = "0x2F1A430", Offset = "0x2F18A30", VA = "0x182F1A430", Slot = "88")]
		public bool TryGetPreComputedSnapPoints(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x040008A9 RID: 2217
		[Token(Token = "0x40008A9")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Directions[] TarpDirs;
	}
}
