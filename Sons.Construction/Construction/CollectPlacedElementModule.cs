using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Gameplay.Grabber;
using Sons.Items.Core;

namespace Construction
{
	// Token: 0x020000D0 RID: 208
	[Token(Token = "0x20000D0")]
	public class CollectPlacedElementModule : ConstructionModule, IOnStructureDynamicSnapPointModule, IDynamicSnapPointModule, IConstructionModule
	{
		// Token: 0x170001EA RID: 490
		// (get) Token: 0x060005ED RID: 1517 RVA: 0x00004784 File Offset: 0x00002984
		[Token(Token = "0x170001EA")]
		public override UiMessages StagedUiMessages
		{
			[Token(Token = "0x60005ED")]
			[Address(RVA = "0x2E25FD0", Offset = "0x2E245D0", VA = "0x182E25FD0", Slot = "43")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x060005EE RID: 1518 RVA: 0x0000479C File Offset: 0x0000299C
		[Token(Token = "0x170001EB")]
		public override bool AllowInCaves
		{
			[Token(Token = "0x60005EE")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "38")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x060005EF RID: 1519 RVA: 0x000047B4 File Offset: 0x000029B4
		[Token(Token = "0x170001EC")]
		public override bool AllowsPlaceWhenDamaged
		{
			[Token(Token = "0x60005EF")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x2E25FE0", Offset = "0x2E245E0", VA = "0x182E25FE0")]
		public CollectPlacedElementModule(ModuleProfileDatabase profileDatabase)
		{
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x2E260D0", Offset = "0x2E246D0", VA = "0x182E260D0", Slot = "50")]
		public override void Shutdown()
		{
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x000047CC File Offset: 0x000029CC
		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x2E26120", Offset = "0x2E24720", VA = "0x182E26120", Slot = "51")]
		public override bool TryGetValidProfile(ItemData heldItem, int placementMode, out ModuleProfile profile)
		{
			return default(bool);
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x000047E4 File Offset: 0x000029E4
		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x2E26290", Offset = "0x2E24890", VA = "0x182E26290", Slot = "77")]
		public bool TryStage(ModuleState state)
		{
			return default(bool);
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x000047FC File Offset: 0x000029FC
		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x2E26770", Offset = "0x2E24D70", VA = "0x182E26770")]
		private bool BlockedOnClient()
		{
			return default(bool);
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x2E268B0", Offset = "0x2E24EB0", VA = "0x182E268B0", Slot = "61")]
		public override void Unstaged(ModuleProfile profile)
		{
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x00004814 File Offset: 0x00002A14
		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x2E268F0", Offset = "0x2E24EF0", VA = "0x182E268F0", Slot = "64")]
		public override bool TryActivate(ModuleState state)
		{
			return default(bool);
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x2E26900", Offset = "0x2E24F00", VA = "0x182E26900", Slot = "68")]
		public override void Activated(ModuleState state)
		{
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x0000482C File Offset: 0x00002A2C
		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x2E270B0", Offset = "0x2E256B0", VA = "0x182E270B0", Slot = "66")]
		public override bool TrySecondStepActivation(ModuleState state)
		{
			return default(bool);
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x00004844 File Offset: 0x00002A44
		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x2E27340", Offset = "0x2E25940", VA = "0x182E27340", Slot = "70")]
		public override bool TryValidateTargetInfo(TargetInfo targetInfo, int placementMode)
		{
			return default(bool);
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x2E27470", Offset = "0x2E25A70", VA = "0x182E27470", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x2E27CD0", Offset = "0x2E262D0", VA = "0x182E27CD0")]
		private void InitAnimation(ConstructionManager manager, StructureElement removeableElement)
		{
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x2E27E20", Offset = "0x2E26420", VA = "0x182E27E20")]
		private static void SwapElement(StructureElement removingElement, StructureElement newElementPrefab)
		{
		}

		// Token: 0x040004DD RID: 1245
		[Token(Token = "0x40004DD")]
		[FieldOffset(Offset = "0x68")]
		private readonly GenericGrabberTargetProvider _grabberTargetProvider;

		// Token: 0x020000D1 RID: 209
		[Token(Token = "0x20000D1")]
		public class StructurallyBlockedElementCollect : IIdleStateUpdateReceiver
		{
			// Token: 0x170001ED RID: 493
			// (get) Token: 0x060005FD RID: 1533 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170001ED")]
			private ConstructionManager Manager
			{
				[Token(Token = "0x60005FD")]
				[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x170001EE RID: 494
			// (get) Token: 0x060005FE RID: 1534 RVA: 0x00002068 File Offset: 0x00000268
			// (set) Token: 0x060005FF RID: 1535 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x170001EE")]
			public static StructureElement ElementToRemove
			{
				[Token(Token = "0x60005FE")]
				[Address(RVA = "0x2E281B0", Offset = "0x2E267B0", VA = "0x182E281B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60005FF")]
				[Address(RVA = "0x2E281F0", Offset = "0x2E267F0", VA = "0x182E281F0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06000600 RID: 1536 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000600")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			public StructurallyBlockedElementCollect(ConstructionManager manager)
			{
			}

			// Token: 0x06000601 RID: 1537 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000601")]
			[Address(RVA = "0x2E28280", Offset = "0x2E26880", VA = "0x182E28280", Slot = "4")]
			private void IdleStateUpdate(out ExitStatus exitStatus)
			{
			}
		}
	}
}
