using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Items.Core;
using UnityEngine;

namespace Construction
{
	// Token: 0x020000D3 RID: 211
	[Token(Token = "0x20000D3")]
	[Serializable]
	public abstract class ConstructionModule : IConstructionModule, IIkDualGoalsProviderModule, IIkSingleGoalProviderModule
	{
		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000605 RID: 1541 RVA: 0x00004874 File Offset: 0x00002A74
		// (set) Token: 0x06000606 RID: 1542 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001EF")]
		public int ID
		{
			[Token(Token = "0x6000605")]
			[Address(RVA = "0x632000", Offset = "0x630600", VA = "0x180632000", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000606")]
			[Address(RVA = "0x670F30", Offset = "0x66F530", VA = "0x180670F30", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000607 RID: 1543 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000608 RID: 1544 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001F0")]
		public string Name
		{
			[Token(Token = "0x6000607")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000608")]
			[Address(RVA = "0x5B2E90", Offset = "0x5B1490", VA = "0x1805B2E90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000609 RID: 1545 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x0600060A RID: 1546 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001F1")]
		private protected ConstructionManager Manager
		{
			[Token(Token = "0x6000609")]
			[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x600060A")]
			[Address(RVA = "0x5B2F00", Offset = "0x5B1500", VA = "0x1805B2F00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x0600060B RID: 1547 RVA: 0x0000488C File Offset: 0x00002A8C
		// (set) Token: 0x0600060C RID: 1548 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001F2")]
		public virtual bool ConsumesProfileItem
		{
			[Token(Token = "0x600060B")]
			[Address(RVA = "0x674880", Offset = "0x672E80", VA = "0x180674880", Slot = "36")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600060C")]
			[Address(RVA = "0x674890", Offset = "0x672E90", VA = "0x180674890", Slot = "37")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x0600060D RID: 1549 RVA: 0x000048A4 File Offset: 0x00002AA4
		// (set) Token: 0x0600060E RID: 1550 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001F3")]
		public virtual bool AllowInCaves
		{
			[Token(Token = "0x600060D")]
			[Address(RVA = "0x2094CC0", Offset = "0x20932C0", VA = "0x182094CC0", Slot = "38")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600060E")]
			[Address(RVA = "0x2094CD0", Offset = "0x20932D0", VA = "0x182094CD0", Slot = "39")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x0600060F RID: 1551 RVA: 0x000048BC File Offset: 0x00002ABC
		[Token(Token = "0x170001F4")]
		public virtual bool AllowsPlaceWhenDamaged
		{
			[Token(Token = "0x600060F")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000610 RID: 1552 RVA: 0x000048D4 File Offset: 0x00002AD4
		// (set) Token: 0x06000611 RID: 1553 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001F5")]
		public bool InPlacePromptState
		{
			[Token(Token = "0x6000610")]
			[Address(RVA = "0x2E29220", Offset = "0x2E27820", VA = "0x182E29220", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000611")]
			[Address(RVA = "0x2E29230", Offset = "0x2E27830", VA = "0x182E29230")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000612 RID: 1554 RVA: 0x000048EC File Offset: 0x00002AEC
		// (set) Token: 0x06000613 RID: 1555 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001F6")]
		public bool IsPerformingAnimation
		{
			[Token(Token = "0x6000612")]
			[Address(RVA = "0x2299890", Offset = "0x2297E90", VA = "0x182299890", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000613")]
			[Address(RVA = "0x2E29240", Offset = "0x2E27840", VA = "0x182E29240")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000614 RID: 1556 RVA: 0x00004904 File Offset: 0x00002B04
		[Token(Token = "0x170001F7")]
		public virtual bool AllowsMovementWhenActivated
		{
			[Token(Token = "0x6000614")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "41")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000615 RID: 1557 RVA: 0x0000491C File Offset: 0x00002B1C
		[Token(Token = "0x170001F8")]
		public virtual bool AllowsStagingWhileFacingEnemies
		{
			[Token(Token = "0x6000615")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "42")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000616 RID: 1558 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000617 RID: 1559 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001F9")]
		public TargetInfo StitchingTarget
		{
			[Token(Token = "0x6000616")]
			[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000617")]
			[Address(RVA = "0x6710D0", Offset = "0x66F6D0", VA = "0x1806710D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000618 RID: 1560 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000619 RID: 1561 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001FA")]
		public IConstructionModule BounceToAfterPlace
		{
			[Token(Token = "0x6000618")]
			[Address(RVA = "0x661070", Offset = "0x65F670", VA = "0x180661070", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000619")]
			[Address(RVA = "0x661080", Offset = "0x65F680", VA = "0x180661080")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x0600061A RID: 1562 RVA: 0x00004934 File Offset: 0x00002B34
		// (set) Token: 0x0600061B RID: 1563 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001FB")]
		public virtual UiMessages StagedUiMessages
		{
			[Token(Token = "0x600061A")]
			[Address(RVA = "0x8F47A0", Offset = "0x8F2DA0", VA = "0x1808F47A0", Slot = "43")]
			[CompilerGenerated]
			get
			{
				return UiMessages.None;
			}
			[Token(Token = "0x600061B")]
			[Address(RVA = "0x22A59E0", Offset = "0x22A3FE0", VA = "0x1822A59E0", Slot = "44")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x0600061C RID: 1564 RVA: 0x0000494C File Offset: 0x00002B4C
		// (set) Token: 0x0600061D RID: 1565 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001FC")]
		public virtual UiMessages StagedUiMessages3D
		{
			[Token(Token = "0x600061C")]
			[Address(RVA = "0x784B50", Offset = "0x783150", VA = "0x180784B50", Slot = "45")]
			[CompilerGenerated]
			get
			{
				return UiMessages.None;
			}
			[Token(Token = "0x600061D")]
			[Address(RVA = "0x287DC40", Offset = "0x287C240", VA = "0x18287DC40", Slot = "46")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x0600061E RID: 1566 RVA: 0x00004964 File Offset: 0x00002B64
		// (set) Token: 0x0600061F RID: 1567 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001FD")]
		public virtual UiMessages PlacePromptUiMessages
		{
			[Token(Token = "0x600061E")]
			[Address(RVA = "0x75C1D0", Offset = "0x75A7D0", VA = "0x18075C1D0", Slot = "47")]
			[CompilerGenerated]
			get
			{
				return UiMessages.None;
			}
			[Token(Token = "0x600061F")]
			[Address(RVA = "0x233AD40", Offset = "0x2339340", VA = "0x18233AD40", Slot = "48")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000620")]
		[Address(RVA = "0x2E29250", Offset = "0x2E27850", VA = "0x182E29250")]
		protected ConstructionModule(ModuleProfileDatabase profileDatabase, [Optional] ModuleProfileDatabase altProfileDatabase, [Optional] IPlacementModeGroup placementModeGroup)
		{
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000621")]
		[Address(RVA = "0x5B2F00", Offset = "0x5B1500", VA = "0x1805B2F00", Slot = "49")]
		public virtual void SetManager(ConstructionManager manager)
		{
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000622")]
		[Address(RVA = "0x2E296B0", Offset = "0x2E27CB0", VA = "0x182E296B0", Slot = "31")]
		public void InitState(ModuleState state)
		{
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000623")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "50")]
		public virtual void Shutdown()
		{
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x0000497C File Offset: 0x00002B7C
		[Token(Token = "0x6000624")]
		[Address(RVA = "0x2E29710", Offset = "0x2E27D10", VA = "0x182E29710", Slot = "51")]
		public virtual bool TryGetValidProfile(ItemData heldItem, int placementMode, out ModuleProfile profile)
		{
			return default(bool);
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00004994 File Offset: 0x00002B94
		[Token(Token = "0x6000625")]
		[Address(RVA = "0x2E29890", Offset = "0x2E27E90", VA = "0x182E29890", Slot = "52")]
		public virtual bool ValidateFilters(TargetInfo targetInfo, ModuleProfile profile)
		{
			return default(bool);
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x000049AC File Offset: 0x00002BAC
		[Token(Token = "0x6000626")]
		[Address(RVA = "0x2E29920", Offset = "0x2E27F20", VA = "0x182E29920", Slot = "53")]
		public virtual bool ValidateFilters(ElementProfile elementProfile, ModuleProfile profile)
		{
			return default(bool);
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x000049C4 File Offset: 0x00002BC4
		[Token(Token = "0x6000627")]
		[Address(RVA = "0x2E29A80", Offset = "0x2E28080", VA = "0x182E29A80")]
		private static bool TryGetElementProfile(TargetInfo targetInfo, out ElementProfile elementProfile)
		{
			return default(bool);
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x000049DC File Offset: 0x00002BDC
		[Token(Token = "0x6000628")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "54")]
		public virtual bool TryValidateProfile(ItemData targetItem, int placementMode, TargetInfo targetInfo, ref ModuleProfile profile)
		{
			return default(bool);
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x000049F4 File Offset: 0x00002BF4
		[Token(Token = "0x6000629")]
		[Address(RVA = "0x2E29DE0", Offset = "0x2E283E0", VA = "0x182E29DE0", Slot = "55")]
		public virtual bool TogglePlacementMode(ModuleState state)
		{
			return default(bool);
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600062A")]
		[Address(RVA = "0x2E29E30", Offset = "0x2E28430", VA = "0x182E29E30", Slot = "56")]
		public void SetBlockedByPlacementMode()
		{
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00004A0C File Offset: 0x00002C0C
		[Token(Token = "0x600062B")]
		[Address(RVA = "0x2E29E80", Offset = "0x2E28480", VA = "0x182E29E80", Slot = "18")]
		public bool ValidateActiveProfileStageDelay(ModuleProfile profile)
		{
			return default(bool);
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600062C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "57")]
		protected virtual void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600062D")]
		[Address(RVA = "0x2E2A010", Offset = "0x2E28610", VA = "0x182E2A010", Slot = "58")]
		public virtual void Staged(ModuleState state)
		{
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x00004A24 File Offset: 0x00002C24
		[Token(Token = "0x600062E")]
		[Address(RVA = "0x2E2A280", Offset = "0x2E28880", VA = "0x182E2A280", Slot = "59")]
		protected virtual bool TryGetStageMessageOverride(ModuleState state, out UiMessages stagedUiMessages)
		{
			return default(bool);
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600062F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "60")]
		public virtual void StagedUpdate(ModuleState state)
		{
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000630")]
		[Address(RVA = "0x2E2A300", Offset = "0x2E28900", VA = "0x182E2A300", Slot = "61")]
		public virtual void Unstaged(ModuleProfile profile)
		{
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00004A3C File Offset: 0x00002C3C
		[Token(Token = "0x6000631")]
		[Address(RVA = "0x2E2A450", Offset = "0x2E28A50", VA = "0x182E2A450", Slot = "62")]
		public virtual bool TryBounceTo(ModuleState state)
		{
			return default(bool);
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x00004A54 File Offset: 0x00002C54
		[Token(Token = "0x6000632")]
		[Address(RVA = "0x2E2A5D0", Offset = "0x2E28BD0", VA = "0x182E2A5D0", Slot = "63")]
		protected virtual InputModes GetActivationInputMode(ModuleState state)
		{
			return InputModes.AlwaysTwoSteps;
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x00004A6C File Offset: 0x00002C6C
		[Token(Token = "0x6000633")]
		[Address(RVA = "0x2E2A6B0", Offset = "0x2E28CB0", VA = "0x182E2A6B0", Slot = "64")]
		public virtual bool TryActivate(ModuleState state)
		{
			return default(bool);
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x00004A84 File Offset: 0x00002C84
		[Token(Token = "0x6000634")]
		[Address(RVA = "0x2E2AA50", Offset = "0x2E29050", VA = "0x182E2AA50")]
		private bool TryEnsureHeldItem(ModuleState state)
		{
			return default(bool);
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x00004A9C File Offset: 0x00002C9C
		[Token(Token = "0x6000635")]
		[Address(RVA = "0x2E2AAE0", Offset = "0x2E290E0", VA = "0x182E2AAE0", Slot = "65")]
		public bool ValidateHeldItem(ModuleState state)
		{
			return default(bool);
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x00004AB4 File Offset: 0x00002CB4
		[Token(Token = "0x6000636")]
		[Address(RVA = "0x2E2AB70", Offset = "0x2E29170", VA = "0x182E2AB70", Slot = "66")]
		public virtual bool TrySecondStepActivation(ModuleState state)
		{
			return default(bool);
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x00004ACC File Offset: 0x00002CCC
		[Token(Token = "0x6000637")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "67")]
		protected virtual bool CanPlayPlayerPlaceAnim(ModuleState state)
		{
			return default(bool);
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000638")]
		[Address(RVA = "0x2E2ABD0", Offset = "0x2E291D0", VA = "0x182E2ABD0", Slot = "68")]
		public virtual void Activated(ModuleState state)
		{
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000639")]
		[Address(RVA = "0x2E2B030", Offset = "0x2E29630", VA = "0x182E2B030", Slot = "69")]
		public virtual void Deactivated(ModuleState state)
		{
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x00004AE4 File Offset: 0x00002CE4
		[Token(Token = "0x600063A")]
		[Address(RVA = "0x2E2B360", Offset = "0x2E29960", VA = "0x182E2B360", Slot = "70")]
		public virtual bool TryValidateTargetInfo(TargetInfo targetInfo, int placementMode)
		{
			return default(bool);
		}

		// Token: 0x0600063B RID: 1595
		[Token(Token = "0x600063B")]
		public abstract void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode);

		// Token: 0x0600063C RID: 1596 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600063C")]
		[Address(RVA = "0x2E2B690", Offset = "0x2E29C90", VA = "0x182E2B690", Slot = "72")]
		public virtual void Reset(ModuleState state)
		{
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x00004AFC File Offset: 0x00002CFC
		[Token(Token = "0x600063D")]
		[Address(RVA = "0x2E2B6C0", Offset = "0x2E29CC0", VA = "0x182E2B6C0", Slot = "73")]
		protected virtual Quaternion GetStructureRotation(TargetInfo targetInfo)
		{
			return default(Quaternion);
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00004B14 File Offset: 0x00002D14
		[Token(Token = "0x600063E")]
		[Address(RVA = "0x2E2B7B0", Offset = "0x2E29DB0", VA = "0x182E2B7B0", Slot = "74")]
		public virtual bool TryGetIkGoals(StructureElement prefab, TargetInfo targetInfo, out Vector3 leftPos, out Quaternion leftRot, out Vector3 leftScale, out Vector3 rightPos, out Quaternion rightRot, out Vector3 rightScale)
		{
			return default(bool);
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x00004B2C File Offset: 0x00002D2C
		[Token(Token = "0x600063F")]
		[Address(RVA = "0x2E2BC40", Offset = "0x2E2A240", VA = "0x182E2BC40", Slot = "75")]
		public virtual bool TryGetIkGoals(StructureElement element, TargetInfo targetInfo, IkLimbs limb, out Vector3 pos, out Quaternion rot, out Vector3 scale)
		{
			return default(bool);
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000640")]
		[Address(RVA = "0x2E2C160", Offset = "0x2E2A760", VA = "0x182E2C160", Slot = "76")]
		protected virtual void CalcRendererWorldOffset(TargetInfo targetInfo, StructureElement prefab, out Vector3 worldPos, out Quaternion worldRot)
		{
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x00004B44 File Offset: 0x00002D44
		[Token(Token = "0x6000641")]
		[Address(RVA = "0x634EA0", Offset = "0x6334A0", VA = "0x180634EA0")]
		public static UiMessages Combine(PrimaryUiMessages primaryUiMessages, SecondaryUiMessages secondaryUiMessages)
		{
			return UiMessages.None;
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x00004B5C File Offset: 0x00002D5C
		[Token(Token = "0x6000642")]
		[Address(RVA = "0x2E2C1B0", Offset = "0x2E2A7B0", VA = "0x182E2C1B0")]
		public static UiMessages Combine(PrimaryUiMessages primaryUiMessages, SecondaryUiMessages secondaryUiMessages, TertiaryUiMessages tertiaryUiMessages)
		{
			return UiMessages.None;
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000643")]
		[Address(RVA = "0x2E2C1C0", Offset = "0x2E2A7C0", VA = "0x182E2C1C0")]
		public void ForeachProfile(Action<ModuleProfile> action, int placementMode = 1)
		{
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000644")]
		[Address(RVA = "0x2E2C310", Offset = "0x2E2A910", VA = "0x182E2C310")]
		public void ForeachProfile(Func<ModuleProfile, ConstructionModule.Loop> action, int placementMode = 1)
		{
		}

		// Token: 0x040004E0 RID: 1248
		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected Dictionary<int, ModuleProfileDatabase> _profileDatabases;

		// Token: 0x040004E1 RID: 1249
		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected IPlacementModeGroup _placementModeGroup;

		// Token: 0x040004E2 RID: 1250
		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private StagingDelay _stagingDelay;

		// Token: 0x020000D4 RID: 212
		[Token(Token = "0x20000D4")]
		public enum Loop
		{
			// Token: 0x040004F0 RID: 1264
			[Token(Token = "0x40004F0")]
			Continue,
			// Token: 0x040004F1 RID: 1265
			[Token(Token = "0x40004F1")]
			Exit
		}
	}
}
