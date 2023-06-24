using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.ConstructionBoltToken;
using Sons.Items.Core;
using UnityEngine;

namespace Construction.Multiplayer
{
	// Token: 0x0200028E RID: 654
	[Token(Token = "0x200028E")]
	[AddComponentMenu("Sons/Construction/FreeFormSystemNetworkProxy - Server")]
	public class FreeFormSystemNetworkProxyServer : FreeFormSystemNetworkProxyBase
	{
		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x060013F5 RID: 5109 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x060013F6 RID: 5110 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700043A")]
		public static FreeFormSystemNetworkProxyServer Instance
		{
			[Token(Token = "0x60013F5")]
			[Address(RVA = "0x2DE4140", Offset = "0x2DE2740", VA = "0x182DE4140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60013F6")]
			[Address(RVA = "0x2DE4180", Offset = "0x2DE2780", VA = "0x182DE4180")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060013F7 RID: 5111 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013F7")]
		[Address(RVA = "0x2DE4210", Offset = "0x2DE2810", VA = "0x182DE4210")]
		private void Awake()
		{
		}

		// Token: 0x060013F8 RID: 5112 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013F8")]
		[Address(RVA = "0x2DE4530", Offset = "0x2DE2B30", VA = "0x182DE4530")]
		private void Update()
		{
		}

		// Token: 0x060013F9 RID: 5113 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013F9")]
		[Address(RVA = "0x2DE4540", Offset = "0x2DE2B40", VA = "0x182DE4540")]
		private void OnDestroy()
		{
		}

		// Token: 0x060013FA RID: 5114 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013FA")]
		[Address(RVA = "0x2DE4730", Offset = "0x2DE2D30", VA = "0x182DE4730")]
		private void ToggleSyncCallbacks(bool onOff)
		{
		}

		// Token: 0x060013FB RID: 5115 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013FB")]
		[Address(RVA = "0x2DE4D00", Offset = "0x2DE3300", VA = "0x182DE4D00")]
		private void OnBeforeLoadSave()
		{
		}

		// Token: 0x060013FC RID: 5116 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013FC")]
		[Address(RVA = "0x2DE4D10", Offset = "0x2DE3310", VA = "0x182DE4D10")]
		private void OnAfterLoadSave()
		{
		}

		// Token: 0x060013FD RID: 5117 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013FD")]
		[Address(RVA = "0x2DE4E30", Offset = "0x2DE3430", VA = "0x182DE4E30", Slot = "384")]
		protected override void OnPlace(IConstructionModule module, TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x060013FE RID: 5118 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013FE")]
		[Address(RVA = "0x2DE4EB0", Offset = "0x2DE34B0", VA = "0x182DE4EB0", Slot = "307")]
		public override void OnEvent(FreeFormRequestAllData evnt)
		{
		}

		// Token: 0x060013FF RID: 5119 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013FF")]
		[Address(RVA = "0x2DE4FD0", Offset = "0x2DE35D0", VA = "0x182DE4FD0", Slot = "385")]
		protected override void SendStructurePlacementRejectedEvent(BoltConnection targetClient, int actionNum)
		{
		}

		// Token: 0x06001400 RID: 5120 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001400")]
		[Address(RVA = "0x2DE5080", Offset = "0x2DE3680", VA = "0x182DE5080")]
		private static void OnStructureCreated(Structure structure)
		{
		}

		// Token: 0x06001401 RID: 5121 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001401")]
		[Address(RVA = "0x2DE5770", Offset = "0x2DE3D70", VA = "0x182DE5770")]
		private static void OnStructureEditedTransform(Structure structure)
		{
		}

		// Token: 0x06001402 RID: 5122 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001402")]
		[Address(RVA = "0x2DE5BD0", Offset = "0x2DE41D0", VA = "0x182DE5BD0")]
		private static void OnStructureEditedElements(Structure structure)
		{
		}

		// Token: 0x06001403 RID: 5123 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001403")]
		[Address(RVA = "0x2DE5F60", Offset = "0x2DE4560", VA = "0x182DE5F60")]
		private static void OnStructureEditedLinks(Structure structure)
		{
		}

		// Token: 0x06001404 RID: 5124 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001404")]
		[Address(RVA = "0x2DE62F0", Offset = "0x2DE48F0", VA = "0x182DE62F0")]
		private static void OnCascadeRepositionSupported(List<Structure> structures)
		{
		}

		// Token: 0x06001405 RID: 5125 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001405")]
		[Address(RVA = "0x2DE6540", Offset = "0x2DE4B40", VA = "0x182DE6540")]
		private static void OnDestroyingStructure(Structure structure)
		{
		}

		// Token: 0x06001406 RID: 5126 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001406")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private static void OnModifyingStructureId(Structure structure, uint newInstanceId)
		{
		}

		// Token: 0x06001407 RID: 5127 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001407")]
		[Address(RVA = "0x2DE6780", Offset = "0x2DE4D80", VA = "0x182DE6780")]
		private static void RegisterDestroyedStructureVersion(Structure structure, int dbVersion)
		{
		}

		// Token: 0x06001408 RID: 5128 RVA: 0x0000BE34 File Offset: 0x0000A034
		[Token(Token = "0x6001408")]
		[Address(RVA = "0x2DE69F0", Offset = "0x2DE4FF0", VA = "0x182DE69F0")]
		public static bool PlacingFromRemote()
		{
			return default(bool);
		}

		// Token: 0x06001409 RID: 5129 RVA: 0x0000BE4C File Offset: 0x0000A04C
		[Token(Token = "0x6001409")]
		[Address(RVA = "0x2DE6A40", Offset = "0x2DE5040", VA = "0x182DE6A40")]
		public static bool TrySendItemToRemotePlayer(ItemData item, int amount)
		{
			return default(bool);
		}

		// Token: 0x0600140A RID: 5130 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600140A")]
		[Address(RVA = "0x2DE6BC0", Offset = "0x2DE51C0", VA = "0x182DE6BC0")]
		private static CoopStructureElementsToken GetElementsPayload(Structure structure)
		{
			return null;
		}

		// Token: 0x0600140B RID: 5131 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600140B")]
		[Address(RVA = "0x2DE6F30", Offset = "0x2DE5530", VA = "0x182DE6F30")]
		private static CoopStructureListToken GetLinksPayload(Structure structure)
		{
			return null;
		}

		// Token: 0x0600140C RID: 5132 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600140C")]
		[Address(RVA = "0x2DE7150", Offset = "0x2DE5750", VA = "0x182DE7150")]
		private static CoopStructureListToken GetStructureListToken(List<Structure> structures)
		{
			return null;
		}

		// Token: 0x0600140D RID: 5133 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600140D")]
		[Address(RVA = "0x2DE7330", Offset = "0x2DE5930", VA = "0x182DE7330", Slot = "372")]
		public override void OnEvent(FreeFormSwitchState evnt)
		{
		}

		// Token: 0x0600140E RID: 5134 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600140E")]
		[Address(RVA = "0x2DE77A0", Offset = "0x2DE5DA0", VA = "0x182DE77A0", Slot = "342")]
		public override void OnEvent(StructureCraftingNodeCreate boltEvent)
		{
		}

		// Token: 0x0600140F RID: 5135 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600140F")]
		[Address(RVA = "0x2DE7F00", Offset = "0x2DE6500", VA = "0x182DE7F00", Slot = "367")]
		public override void OnEvent(DismantleScrewStructure dismantleEvent)
		{
		}

		// Token: 0x06001410 RID: 5136 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001410")]
		[Address(RVA = "0x2DE80D0", Offset = "0x2DE66D0", VA = "0x182DE80D0", Slot = "368")]
		public override void OnEvent(ThrowHeldScrewStructure throwHeldEvent)
		{
		}

		// Token: 0x06001411 RID: 5137 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001411")]
		[Address(RVA = "0x2DE8200", Offset = "0x2DE6800", VA = "0x182DE8200", Slot = "366")]
		public override void OnEvent(FreeFormSwitchLightState evnt)
		{
		}

		// Token: 0x06001412 RID: 5138 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001412")]
		[Address(RVA = "0x2DE8680", Offset = "0x2DE6C80", VA = "0x182DE8680", Slot = "323")]
		public override void OnEvent(FireLightEvent evnt)
		{
		}

		// Token: 0x06001413 RID: 5139 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001413")]
		[Address(RVA = "0x2DE8800", Offset = "0x2DE6E00", VA = "0x182DE8800", Slot = "351")]
		public override void OnEvent(FireStokeEvent evnt)
		{
		}

		// Token: 0x06001414 RID: 5140 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001414")]
		[Address(RVA = "0x2DE8980", Offset = "0x2DE6F80", VA = "0x182DE8980", Slot = "224")]
		public override void OnEvent(FireCookEvent evnt)
		{
		}

		// Token: 0x06001415 RID: 5141 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001415")]
		[Address(RVA = "0x2DE8B70", Offset = "0x2DE7170", VA = "0x182DE8B70", Slot = "375")]
		public override void OnEvent(CookingSpotIsBusyEvent boltEvent)
		{
		}

		// Token: 0x06001416 RID: 5142 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001416")]
		[Address(RVA = "0x2DE8D20", Offset = "0x2DE7320", VA = "0x182DE8D20", Slot = "376")]
		public override void OnEvent(CookingBeginCookingEvent boltEvent)
		{
		}

		// Token: 0x06001417 RID: 5143 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001417")]
		[Address(RVA = "0x2DE9010", Offset = "0x2DE7610", VA = "0x182DE9010", Slot = "377")]
		public override void OnEvent(CookingPotRemovedEvent boltEvent)
		{
		}

		// Token: 0x06001418 RID: 5144 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001418")]
		[Address(RVA = "0x2DE91A0", Offset = "0x2DE77A0", VA = "0x182DE91A0", Slot = "378")]
		public override void OnEvent(CookingUpdateVolumeEvent boltEvent)
		{
		}

		// Token: 0x06001419 RID: 5145 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001419")]
		[Address(RVA = "0x2DE9460", Offset = "0x2DE7A60", VA = "0x182DE9460")]
		public FreeFormSystemNetworkProxyServer()
		{
		}

		// Token: 0x040009B3 RID: 2483
		[Token(Token = "0x40009B3")]
		private const int _blobChannel = 1;

		// Token: 0x040009B4 RID: 2484
		[Token(Token = "0x40009B4")]
		[FieldOffset(Offset = "0x48")]
		private ConstructionManager _manager;
	}
}
