using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000155 RID: 341
	[Token(Token = "0x2000155")]
	public class PlaceDecorationModule : ConstructionModule, IOnStructureDynamicSnapPointModule, IDynamicSnapPointModule, IConstructionModule
	{
		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000A16 RID: 2582 RVA: 0x000069BC File Offset: 0x00004BBC
		[Token(Token = "0x17000294")]
		public override bool ConsumesProfileItem
		{
			[Token(Token = "0x6000A16")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A17")]
		[Address(RVA = "0x2E2C400", Offset = "0x2E2AA00", VA = "0x182E2C400")]
		public PlaceDecorationModule(ModuleProfileDatabase doorProfileDb)
		{
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x000069D4 File Offset: 0x00004BD4
		[Token(Token = "0x6000A18")]
		[Address(RVA = "0x2E8FE10", Offset = "0x2E8E410", VA = "0x182E8FE10", Slot = "77")]
		public bool TryStage(ModuleState state)
		{
			return default(bool);
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A19")]
		[Address(RVA = "0x2E72FE0", Offset = "0x2E715E0", VA = "0x182E72FE0", Slot = "60")]
		public override void StagedUpdate(ModuleState state)
		{
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0x2E90040", Offset = "0x2E8E640", VA = "0x182E90040", Slot = "57")]
		protected override void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x000069EC File Offset: 0x00004BEC
		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0x2E90210", Offset = "0x2E8E810", VA = "0x182E90210")]
		private bool TryGetSnapPointFromWall(TargetInfo targetInfo, out Vector3 snapPos, out Vector3 placeAxis, out WallStructure supportingWall)
		{
			return default(bool);
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x00006A04 File Offset: 0x00004C04
		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0x2E907A0", Offset = "0x2E8EDA0", VA = "0x182E907A0")]
		private bool TryGetSnapPointFromTree(TargetInfo targetInfo, out Vector3 snapPos, out Vector3 placeAxis)
		{
			return default(bool);
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0x2E90AC0", Offset = "0x2E8F0C0", VA = "0x182E90AC0", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0x2E90FB0", Offset = "0x2E8F5B0", VA = "0x182E90FB0")]
		private void SetupDecorationFromWall(TargetInfo targetInfo)
		{
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0x2E91130", Offset = "0x2E8F730", VA = "0x182E91130")]
		private void SetupDecorationFromTree(TargetInfo targetInfo)
		{
		}
	}
}
