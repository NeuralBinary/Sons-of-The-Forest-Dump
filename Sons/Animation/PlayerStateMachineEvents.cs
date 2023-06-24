using System;
using Endnight.Animation;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation
{
	// Token: 0x02000922 RID: 2338
	[Token(Token = "0x2000922")]
	public class PlayerStateMachineEvents : SonsAnimStateEvents<PlayerStateMachineEvents.PlayerEvent>
	{
		// Token: 0x06004333 RID: 17203 RVA: 0x000145B0 File Offset: 0x000127B0
		[Token(Token = "0x6004333")]
		[Address(RVA = "0x3641A80", Offset = "0x3640080", VA = "0x183641A80", Slot = "18")]
		protected override bool InitEventReceiver(Animator animator)
		{
			return default(bool);
		}

		// Token: 0x06004334 RID: 17204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004334")]
		[Address(RVA = "0x3641BD0", Offset = "0x36401D0", VA = "0x183641BD0", Slot = "19")]
		protected override void SendRangeEvent(AnimStateEventBase ev, bool active, int stateNameHash)
		{
		}

		// Token: 0x06004335 RID: 17205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004335")]
		[Address(RVA = "0x3642210", Offset = "0x3640810", VA = "0x183642210", Slot = "20")]
		protected override void SendSingleEvent(AnimStateEventBase ev)
		{
		}

		// Token: 0x06004336 RID: 17206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004336")]
		[Address(RVA = "0x36426E0", Offset = "0x3640CE0", VA = "0x1836426E0")]
		public PlayerStateMachineEvents()
		{
		}

		// Token: 0x04004655 RID: 18005
		[Token(Token = "0x4004655")]
		[FieldOffset(Offset = "0x30")]
		private AnimationEventReceiver _eventReceiver;

		// Token: 0x02000923 RID: 2339
		[Token(Token = "0x2000923")]
		public enum PlayerEventType
		{
			// Token: 0x04004657 RID: 18007
			[Token(Token = "0x4004657")]
			Attack,
			// Token: 0x04004658 RID: 18008
			[Token(Token = "0x4004658")]
			GroundAttack,
			// Token: 0x04004659 RID: 18009
			[Token(Token = "0x4004659")]
			CheckCombo,
			// Token: 0x0400465A RID: 18010
			[Token(Token = "0x400465A")]
			MeleeCollision,
			// Token: 0x0400465B RID: 18011
			[Token(Token = "0x400465B")]
			SmashCollision,
			// Token: 0x0400465C RID: 18012
			[Token(Token = "0x400465C")]
			ItemActivated,
			// Token: 0x0400465D RID: 18013
			[Token(Token = "0x400465D")]
			TreeAttack,
			// Token: 0x0400465E RID: 18014
			[Token(Token = "0x400465E")]
			MeleeAttackEvent,
			// Token: 0x0400465F RID: 18015
			[Token(Token = "0x400465F")]
			HitDirection,
			// Token: 0x04004660 RID: 18016
			[Token(Token = "0x4004660")]
			BlockRange,
			// Token: 0x04004661 RID: 18017
			[Token(Token = "0x4004661")]
			ComboTransition,
			// Token: 0x04004662 RID: 18018
			[Token(Token = "0x4004662")]
			ChargeAttack,
			// Token: 0x04004663 RID: 18019
			[Token(Token = "0x4004663")]
			StepLeft,
			// Token: 0x04004664 RID: 18020
			[Token(Token = "0x4004664")]
			StepRight,
			// Token: 0x04004665 RID: 18021
			[Token(Token = "0x4004665")]
			LandLight,
			// Token: 0x04004666 RID: 18022
			[Token(Token = "0x4004666")]
			LandHeavy,
			// Token: 0x04004667 RID: 18023
			[Token(Token = "0x4004667")]
			Dig,
			// Token: 0x04004668 RID: 18024
			[Token(Token = "0x4004668")]
			Parry,
			// Token: 0x04004669 RID: 18025
			[Token(Token = "0x4004669")]
			Locked,
			// Token: 0x0400466A RID: 18026
			[Token(Token = "0x400466A")]
			BlockActive,
			// Token: 0x0400466B RID: 18027
			[Token(Token = "0x400466B")]
			DigDirtAttach,
			// Token: 0x0400466C RID: 18028
			[Token(Token = "0x400466C")]
			MeleeSwingAudio,
			// Token: 0x0400466D RID: 18029
			[Token(Token = "0x400466D")]
			MeleeResetDamage,
			// Token: 0x0400466E RID: 18030
			[Token(Token = "0x400466E")]
			SpineOff,
			// Token: 0x0400466F RID: 18031
			[Token(Token = "0x400466F")]
			ItemLeavesHand,
			// Token: 0x04004670 RID: 18032
			[Token(Token = "0x4004670")]
			ThrowAttack,
			// Token: 0x04004671 RID: 18033
			[Token(Token = "0x4004671")]
			ChainSawHold,
			// Token: 0x04004672 RID: 18034
			[Token(Token = "0x4004672")]
			HeadWallPusher,
			// Token: 0x04004673 RID: 18035
			[Token(Token = "0x4004673")]
			PropHide,
			// Token: 0x04004674 RID: 18036
			[Token(Token = "0x4004674")]
			HeavyAttackEvent,
			// Token: 0x04004675 RID: 18037
			[Token(Token = "0x4004675")]
			ItemActivatedRange,
			// Token: 0x04004676 RID: 18038
			[Token(Token = "0x4004676")]
			BodyFallEvent
		}

		// Token: 0x02000924 RID: 2340
		[Token(Token = "0x2000924")]
		[Serializable]
		public class PlayerEvent : AnimStateEventBase
		{
			// Token: 0x06004337 RID: 17207 RVA: 0x000145C8 File Offset: 0x000127C8
			[Token(Token = "0x6004337")]
			[Address(RVA = "0x3642720", Offset = "0x3640D20", VA = "0x183642720", Slot = "7")]
			public virtual Color GetGuiColor()
			{
				return default(Color);
			}

			// Token: 0x06004338 RID: 17208 RVA: 0x000145E0 File Offset: 0x000127E0
			[Token(Token = "0x6004338")]
			[Address(RVA = "0x3642870", Offset = "0x3640E70", VA = "0x183642870", Slot = "4")]
			public override bool IsRange()
			{
				return default(bool);
			}

			// Token: 0x06004339 RID: 17209 RVA: 0x000145F8 File Offset: 0x000127F8
			[Token(Token = "0x6004339")]
			[Address(RVA = "0x3642890", Offset = "0x3640E90", VA = "0x183642890", Slot = "5")]
			public override bool EndOnExitStart()
			{
				return default(bool);
			}

			// Token: 0x0600433A RID: 17210 RVA: 0x00014610 File Offset: 0x00012810
			[Token(Token = "0x600433A")]
			[Address(RVA = "0x36428B0", Offset = "0x3640EB0", VA = "0x1836428B0")]
			public bool ShowValue()
			{
				return default(bool);
			}

			// Token: 0x0600433B RID: 17211 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600433B")]
			[Address(RVA = "0x36428D0", Offset = "0x3640ED0", VA = "0x1836428D0", Slot = "6")]
			public override AnimStateEventBase Clone()
			{
				return null;
			}

			// Token: 0x0600433C RID: 17212 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600433C")]
			[Address(RVA = "0xAB20A0", Offset = "0xAB06A0", VA = "0x180AB20A0")]
			public PlayerEvent()
			{
			}

			// Token: 0x04004677 RID: 18039
			[Token(Token = "0x4004677")]
			[FieldOffset(Offset = "0x28")]
			public PlayerStateMachineEvents.PlayerEventType _type;

			// Token: 0x04004678 RID: 18040
			[Token(Token = "0x4004678")]
			[FieldOffset(Offset = "0x2C")]
			public int _value;
		}
	}
}
