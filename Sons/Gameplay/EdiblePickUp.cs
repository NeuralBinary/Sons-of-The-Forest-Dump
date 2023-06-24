using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Inventory;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x0200079F RID: 1951
	[Token(Token = "0x200079F")]
	[AddComponentMenu("Sons/Pickup/EdiblePickUp")]
	public class EdiblePickUp : PickUp
	{
		// Token: 0x0600347F RID: 13439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600347F")]
		[Address(RVA = "0x34CB610", Offset = "0x34C9C10", VA = "0x1834CB610", Slot = "15")]
		protected override void SetupLinkUi()
		{
		}

		// Token: 0x06003480 RID: 13440 RVA: 0x0000FAC8 File Offset: 0x0000DCC8
		[Token(Token = "0x6003480")]
		[Address(RVA = "0x34CBA60", Offset = "0x34CA060", VA = "0x1834CBA60")]
		private bool HasConsumed(ItemInstance itemInstance)
		{
			return default(bool);
		}

		// Token: 0x06003481 RID: 13441 RVA: 0x0000FAE0 File Offset: 0x0000DCE0
		[Token(Token = "0x6003481")]
		[Address(RVA = "0x34CBB80", Offset = "0x34CA180", VA = "0x1834CBB80", Slot = "29")]
		protected override bool MainEffect()
		{
			return default(bool);
		}

		// Token: 0x06003482 RID: 13442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003482")]
		[Address(RVA = "0x34CBE20", Offset = "0x34CA420", VA = "0x1834CBE20", Slot = "21")]
		protected override void OnSecondaryHoldInputMethodActive()
		{
		}

		// Token: 0x06003483 RID: 13443 RVA: 0x0000FAF8 File Offset: 0x0000DCF8
		[Token(Token = "0x6003483")]
		[Address(RVA = "0x34CBE40", Offset = "0x34CA440", VA = "0x1834CBE40")]
		private bool TryConsumePickup()
		{
			return default(bool);
		}

		// Token: 0x06003484 RID: 13444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003484")]
		[Address(RVA = "0x34CBFE0", Offset = "0x34CA5E0", VA = "0x1834CBFE0", Slot = "20")]
		public override void SetItemInstance(ItemInstance itemInstance, bool pushToBolt = true)
		{
		}

		// Token: 0x06003485 RID: 13445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003485")]
		[Address(RVA = "0x34CC0F0", Offset = "0x34CA6F0", VA = "0x1834CC0F0", Slot = "14")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06003486 RID: 13446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003486")]
		[Address(RVA = "0x34CC210", Offset = "0x34CA810", VA = "0x1834CC210", Slot = "22")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06003487 RID: 13447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003487")]
		[Address(RVA = "0x34CC300", Offset = "0x34CA900", VA = "0x1834CC300")]
		private void OnPerishableStateChanged(PerishableItemData.State newState)
		{
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x06003488 RID: 13448 RVA: 0x0000FB10 File Offset: 0x0000DD10
		// (set) Token: 0x06003489 RID: 13449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006AA")]
		public bool ForcePickup
		{
			[Token(Token = "0x6003488")]
			[Address(RVA = "0x61C530", Offset = "0x61AB30", VA = "0x18061C530")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003489")]
			[Address(RVA = "0x61C540", Offset = "0x61AB40", VA = "0x18061C540")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600348A RID: 13450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600348A")]
		[Address(RVA = "0x34C7ED0", Offset = "0x34C64D0", VA = "0x1834C7ED0")]
		public EdiblePickUp()
		{
		}

		// Token: 0x04002D42 RID: 11586
		[Token(Token = "0x4002D42")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private EdiblePickUp.PlayerStatConditionList _playerStatConditionList;

		// Token: 0x04002D43 RID: 11587
		[Token(Token = "0x4002D43")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private bool _shouldPlayConsumeAnimation;

		// Token: 0x04002D44 RID: 11588
		[Token(Token = "0x4002D44")]
		[FieldOffset(Offset = "0x111")]
		private bool _secondaryHoldInputMethodIsActive;

		// Token: 0x04002D45 RID: 11589
		[Token(Token = "0x4002D45")]
		[FieldOffset(Offset = "0x118")]
		private PerishableItemInstanceModule _perishableItemInstanceModule;

		// Token: 0x04002D46 RID: 11590
		[Token(Token = "0x4002D46")]
		private const string ScreenTakeAndConsumeElementId = "screen.takeAndConsume";

		// Token: 0x04002D47 RID: 11591
		[Token(Token = "0x4002D47")]
		private const string ScreenTakeAndConsumeKnownBadElementId = "screen.takeAndConsumeKnownBad";

		// Token: 0x04002D48 RID: 11592
		[Token(Token = "0x4002D48")]
		private const string ScreenTakeAndConsumeKnownGoodElementId = "screen.takeAndConsumeKnownGood";

		// Token: 0x020007A0 RID: 1952
		[Token(Token = "0x20007A0")]
		[Serializable]
		public class PlayerStatCondition
		{
			// Token: 0x0600348B RID: 13451 RVA: 0x0000FB28 File Offset: 0x0000DD28
			[Token(Token = "0x600348B")]
			[Address(RVA = "0x34CC3D0", Offset = "0x34CA9D0", VA = "0x1834CC3D0")]
			public bool IsValid(PlayerStats playerStats, Vitals vitals)
			{
				return default(bool);
			}

			// Token: 0x0600348C RID: 13452 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600348C")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public PlayerStatCondition()
			{
			}

			// Token: 0x04002D4A RID: 11594
			[Token(Token = "0x4002D4A")]
			[FieldOffset(Offset = "0x10")]
			public EdiblePickUp.PlayerStatCondition.Stats _stat;

			// Token: 0x04002D4B RID: 11595
			[Token(Token = "0x4002D4B")]
			[FieldOffset(Offset = "0x14")]
			public EdiblePickUp.PlayerStatCondition.Operators _op;

			// Token: 0x04002D4C RID: 11596
			[Token(Token = "0x4002D4C")]
			[FieldOffset(Offset = "0x18")]
			public float _value;

			// Token: 0x020007A1 RID: 1953
			[Token(Token = "0x20007A1")]
			public enum Operators
			{
				// Token: 0x04002D4E RID: 11598
				[Token(Token = "0x4002D4E")]
				Superior,
				// Token: 0x04002D4F RID: 11599
				[Token(Token = "0x4002D4F")]
				SuperiorOrEqual,
				// Token: 0x04002D50 RID: 11600
				[Token(Token = "0x4002D50")]
				Equal,
				// Token: 0x04002D51 RID: 11601
				[Token(Token = "0x4002D51")]
				Inferior,
				// Token: 0x04002D52 RID: 11602
				[Token(Token = "0x4002D52")]
				InferiorOrEqual,
				// Token: 0x04002D53 RID: 11603
				[Token(Token = "0x4002D53")]
				Different
			}

			// Token: 0x020007A2 RID: 1954
			[Token(Token = "0x20007A2")]
			public enum Stats
			{
				// Token: 0x04002D55 RID: 11605
				[Token(Token = "0x4002D55")]
				Stamina,
				// Token: 0x04002D56 RID: 11606
				[Token(Token = "0x4002D56")]
				Health,
				// Token: 0x04002D57 RID: 11607
				[Token(Token = "0x4002D57")]
				Rest,
				// Token: 0x04002D58 RID: 11608
				[Token(Token = "0x4002D58")]
				UNUSED3,
				// Token: 0x04002D59 RID: 11609
				[Token(Token = "0x4002D59")]
				Hunger,
				// Token: 0x04002D5A RID: 11610
				[Token(Token = "0x4002D5A")]
				UNUSED5,
				// Token: 0x04002D5B RID: 11611
				[Token(Token = "0x4002D5B")]
				RebreatherAir
			}
		}

		// Token: 0x020007A3 RID: 1955
		[Token(Token = "0x20007A3")]
		[Serializable]
		public class PlayerStatConditionList
		{
			// Token: 0x0600348D RID: 13453 RVA: 0x0000FB40 File Offset: 0x0000DD40
			[Token(Token = "0x600348D")]
			[Address(RVA = "0x34CC590", Offset = "0x34CAB90", VA = "0x1834CC590")]
			public bool IsValid(PlayerStats playerStats, Vitals vitals)
			{
				return default(bool);
			}

			// Token: 0x0600348E RID: 13454 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600348E")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public PlayerStatConditionList()
			{
			}

			// Token: 0x04002D5C RID: 11612
			[Token(Token = "0x4002D5C")]
			[FieldOffset(Offset = "0x10")]
			public EdiblePickUp.PlayerStatConditionList.ValidationTypes _validationType;

			// Token: 0x04002D5D RID: 11613
			[Token(Token = "0x4002D5D")]
			[FieldOffset(Offset = "0x18")]
			public List<EdiblePickUp.PlayerStatCondition> _conditions;

			// Token: 0x020007A4 RID: 1956
			[Token(Token = "0x20007A4")]
			public enum ValidationTypes
			{
				// Token: 0x04002D5F RID: 11615
				[Token(Token = "0x4002D5F")]
				AnyTrue,
				// Token: 0x04002D60 RID: 11616
				[Token(Token = "0x4002D60")]
				AllTrue
			}
		}
	}
}
