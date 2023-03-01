using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Inventory;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x0200067D RID: 1661
	[Token(Token = "0x200067D")]
	[AddComponentMenu("Sons/Pickup/EdiblePickUp")]
	public class EdiblePickUp : PickUp
	{
		// Token: 0x06002A73 RID: 10867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A73")]
		[Address(RVA = "0x2DC8B40", Offset = "0x2DC7B40", VA = "0x182DC8B40", Slot = "13")]
		protected override void SetupLinkUi()
		{
		}

		// Token: 0x06002A74 RID: 10868 RVA: 0x0000C348 File Offset: 0x0000A548
		[Token(Token = "0x6002A74")]
		[Address(RVA = "0x2DC8410", Offset = "0x2DC7410", VA = "0x182DC8410")]
		private bool HasConsumed(ItemInstance itemInstance)
		{
			return default(bool);
		}

		// Token: 0x06002A75 RID: 10869 RVA: 0x0000C360 File Offset: 0x0000A560
		[Token(Token = "0x6002A75")]
		[Address(RVA = "0x2DC84D0", Offset = "0x2DC74D0", VA = "0x182DC84D0", Slot = "27")]
		protected override bool MainEffect()
		{
			return default(bool);
		}

		// Token: 0x06002A76 RID: 10870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A76")]
		[Address(RVA = "0x2DC89D0", Offset = "0x2DC79D0", VA = "0x182DC89D0", Slot = "19")]
		protected override void OnSecondaryHoldInputMethodActive()
		{
		}

		// Token: 0x06002A77 RID: 10871 RVA: 0x0000C378 File Offset: 0x0000A578
		[Token(Token = "0x6002A77")]
		[Address(RVA = "0x2DC8D40", Offset = "0x2DC7D40", VA = "0x182DC8D40")]
		private bool TryConsumePickup()
		{
			return default(bool);
		}

		// Token: 0x06002A78 RID: 10872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A78")]
		[Address(RVA = "0x2DC89F0", Offset = "0x2DC79F0", VA = "0x182DC89F0", Slot = "18")]
		public override void SetItemInstance(ItemInstance itemInstance, bool pushToBolt = true)
		{
		}

		// Token: 0x06002A79 RID: 10873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A79")]
		[Address(RVA = "0x2DC8820", Offset = "0x2DC7820", VA = "0x182DC8820", Slot = "12")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06002A7A RID: 10874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A7A")]
		[Address(RVA = "0x2DC8750", Offset = "0x2DC7750", VA = "0x182DC8750", Slot = "20")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06002A7B RID: 10875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A7B")]
		[Address(RVA = "0x2DC8950", Offset = "0x2DC7950", VA = "0x182DC8950")]
		private void OnPerishableStateChanged(PerishableItemData.State newState)
		{
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06002A7C RID: 10876 RVA: 0x0000C390 File Offset: 0x0000A590
		// (set) Token: 0x06002A7D RID: 10877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700057E")]
		public bool ForcePickup
		{
			[Token(Token = "0x6002A7C")]
			[Address(RVA = "0x217BF20", Offset = "0x217AF20", VA = "0x18217BF20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002A7D")]
			[Address(RVA = "0x217C040", Offset = "0x217B040", VA = "0x18217C040")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002A7E RID: 10878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A7E")]
		[Address(RVA = "0x2DC6290", Offset = "0x2DC5290", VA = "0x182DC6290")]
		public EdiblePickUp()
		{
		}

		// Token: 0x040025E1 RID: 9697
		[Token(Token = "0x40025E1")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private EdiblePickUp.PlayerStatConditionList _playerStatConditionList;

		// Token: 0x040025E2 RID: 9698
		[Token(Token = "0x40025E2")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private bool _shouldPlayConsumeAnimation;

		// Token: 0x040025E3 RID: 9699
		[Token(Token = "0x40025E3")]
		[FieldOffset(Offset = "0x101")]
		private bool _secondaryHoldInputMethodIsActive;

		// Token: 0x040025E4 RID: 9700
		[Token(Token = "0x40025E4")]
		[FieldOffset(Offset = "0x108")]
		private PerishableItemInstanceModule _perishableItemInstanceModule;

		// Token: 0x040025E5 RID: 9701
		[Token(Token = "0x40025E5")]
		private const string ScreenTakeAndConsumeElementId = "screen.takeAndConsume";

		// Token: 0x040025E6 RID: 9702
		[Token(Token = "0x40025E6")]
		private const string ScreenTakeAndConsumeKnownBadElementId = "screen.takeAndConsumeKnownBad";

		// Token: 0x040025E7 RID: 9703
		[Token(Token = "0x40025E7")]
		private const string ScreenTakeAndConsumeKnownGoodElementId = "screen.takeAndConsumeKnownGood";

		// Token: 0x0200067E RID: 1662
		[Token(Token = "0x200067E")]
		[Serializable]
		public class PlayerStatCondition
		{
			// Token: 0x06002A7F RID: 10879 RVA: 0x0000C3A8 File Offset: 0x0000A5A8
			[Token(Token = "0x6002A7F")]
			[Address(RVA = "0x2DDDF10", Offset = "0x2DDCF10", VA = "0x182DDDF10")]
			public bool IsValid(PlayerStats playerStats, Vitals vitals)
			{
				return default(bool);
			}

			// Token: 0x06002A80 RID: 10880 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002A80")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public PlayerStatCondition()
			{
			}

			// Token: 0x040025E9 RID: 9705
			[Token(Token = "0x40025E9")]
			[FieldOffset(Offset = "0x10")]
			public EdiblePickUp.PlayerStatCondition.Stats _stat;

			// Token: 0x040025EA RID: 9706
			[Token(Token = "0x40025EA")]
			[FieldOffset(Offset = "0x14")]
			public EdiblePickUp.PlayerStatCondition.Operators _op;

			// Token: 0x040025EB RID: 9707
			[Token(Token = "0x40025EB")]
			[FieldOffset(Offset = "0x18")]
			public float _value;

			// Token: 0x0200067F RID: 1663
			[Token(Token = "0x200067F")]
			public enum Operators
			{
				// Token: 0x040025ED RID: 9709
				[Token(Token = "0x40025ED")]
				Superior,
				// Token: 0x040025EE RID: 9710
				[Token(Token = "0x40025EE")]
				SuperiorOrEqual,
				// Token: 0x040025EF RID: 9711
				[Token(Token = "0x40025EF")]
				Equal,
				// Token: 0x040025F0 RID: 9712
				[Token(Token = "0x40025F0")]
				Inferior,
				// Token: 0x040025F1 RID: 9713
				[Token(Token = "0x40025F1")]
				InferiorOrEqual,
				// Token: 0x040025F2 RID: 9714
				[Token(Token = "0x40025F2")]
				Different
			}

			// Token: 0x02000680 RID: 1664
			[Token(Token = "0x2000680")]
			public enum Stats
			{
				// Token: 0x040025F4 RID: 9716
				[Token(Token = "0x40025F4")]
				Stamina,
				// Token: 0x040025F5 RID: 9717
				[Token(Token = "0x40025F5")]
				Health,
				// Token: 0x040025F6 RID: 9718
				[Token(Token = "0x40025F6")]
				Rest,
				// Token: 0x040025F7 RID: 9719
				[Token(Token = "0x40025F7")]
				UNUSED3,
				// Token: 0x040025F8 RID: 9720
				[Token(Token = "0x40025F8")]
				Hunger,
				// Token: 0x040025F9 RID: 9721
				[Token(Token = "0x40025F9")]
				UNUSED5,
				// Token: 0x040025FA RID: 9722
				[Token(Token = "0x40025FA")]
				RebreatherAir
			}
		}

		// Token: 0x02000681 RID: 1665
		[Token(Token = "0x2000681")]
		[Serializable]
		public class PlayerStatConditionList
		{
			// Token: 0x06002A81 RID: 10881 RVA: 0x0000C3C0 File Offset: 0x0000A5C0
			[Token(Token = "0x6002A81")]
			[Address(RVA = "0x2DDDC20", Offset = "0x2DDCC20", VA = "0x182DDDC20")]
			public bool IsValid(PlayerStats playerStats, Vitals vitals)
			{
				return default(bool);
			}

			// Token: 0x06002A82 RID: 10882 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002A82")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public PlayerStatConditionList()
			{
			}

			// Token: 0x040025FB RID: 9723
			[Token(Token = "0x40025FB")]
			[FieldOffset(Offset = "0x10")]
			public EdiblePickUp.PlayerStatConditionList.ValidationTypes _validationType;

			// Token: 0x040025FC RID: 9724
			[Token(Token = "0x40025FC")]
			[FieldOffset(Offset = "0x18")]
			public List<EdiblePickUp.PlayerStatCondition> _conditions;

			// Token: 0x02000682 RID: 1666
			[Token(Token = "0x2000682")]
			public enum ValidationTypes
			{
				// Token: 0x040025FE RID: 9726
				[Token(Token = "0x40025FE")]
				AnyTrue,
				// Token: 0x040025FF RID: 9727
				[Token(Token = "0x40025FF")]
				AllTrue
			}
		}
	}
}
