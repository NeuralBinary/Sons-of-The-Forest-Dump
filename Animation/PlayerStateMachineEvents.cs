using System;
using Endnight.Animation;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation
{
	// Token: 0x020008B0 RID: 2224
	[Token(Token = "0x20008B0")]
	public class PlayerStateMachineEvents : SonsAnimStateEvents<PlayerStateMachineEvents.PlayerEvent>
	{
		// Token: 0x06003C02 RID: 15362 RVA: 0x00011718 File Offset: 0x0000F918
		[Token(Token = "0x6003C02")]
		[Address(RVA = "0x2F21D20", Offset = "0x2F20D20", VA = "0x182F21D20", Slot = "18")]
		protected override bool InitEventReceiver(Animator animator)
		{
			return default(bool);
		}

		// Token: 0x06003C03 RID: 15363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C03")]
		[Address(RVA = "0x2F21DC0", Offset = "0x2F20DC0", VA = "0x182F21DC0", Slot = "19")]
		protected override void SendRangeEvent(AnimStateEventBase ev, bool active, int stateNameHash)
		{
		}

		// Token: 0x06003C04 RID: 15364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C04")]
		[Address(RVA = "0x2F22260", Offset = "0x2F21260", VA = "0x182F22260", Slot = "20")]
		protected override void SendSingleEvent(AnimStateEventBase ev)
		{
		}

		// Token: 0x06003C05 RID: 15365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C05")]
		[Address(RVA = "0x2F224B0", Offset = "0x2F214B0", VA = "0x182F224B0")]
		public PlayerStateMachineEvents()
		{
		}

		// Token: 0x04004029 RID: 16425
		[Token(Token = "0x4004029")]
		[FieldOffset(Offset = "0x30")]
		private AnimationEventReceiver _eventReceiver;

		// Token: 0x020008B1 RID: 2225
		[Token(Token = "0x20008B1")]
		public enum PlayerEventType
		{
			// Token: 0x0400402B RID: 16427
			[Token(Token = "0x400402B")]
			Attack,
			// Token: 0x0400402C RID: 16428
			[Token(Token = "0x400402C")]
			GroundAttack,
			// Token: 0x0400402D RID: 16429
			[Token(Token = "0x400402D")]
			CheckCombo,
			// Token: 0x0400402E RID: 16430
			[Token(Token = "0x400402E")]
			MeleeCollision,
			// Token: 0x0400402F RID: 16431
			[Token(Token = "0x400402F")]
			SmashCollision,
			// Token: 0x04004030 RID: 16432
			[Token(Token = "0x4004030")]
			ItemActivated,
			// Token: 0x04004031 RID: 16433
			[Token(Token = "0x4004031")]
			TreeAttack,
			// Token: 0x04004032 RID: 16434
			[Token(Token = "0x4004032")]
			MeleeAttackEvent,
			// Token: 0x04004033 RID: 16435
			[Token(Token = "0x4004033")]
			HitDirection,
			// Token: 0x04004034 RID: 16436
			[Token(Token = "0x4004034")]
			BlockRange,
			// Token: 0x04004035 RID: 16437
			[Token(Token = "0x4004035")]
			ComboTransition,
			// Token: 0x04004036 RID: 16438
			[Token(Token = "0x4004036")]
			ChargeAttack,
			// Token: 0x04004037 RID: 16439
			[Token(Token = "0x4004037")]
			StepLeft,
			// Token: 0x04004038 RID: 16440
			[Token(Token = "0x4004038")]
			StepRight,
			// Token: 0x04004039 RID: 16441
			[Token(Token = "0x4004039")]
			LandLight,
			// Token: 0x0400403A RID: 16442
			[Token(Token = "0x400403A")]
			LandHeavy,
			// Token: 0x0400403B RID: 16443
			[Token(Token = "0x400403B")]
			Dig,
			// Token: 0x0400403C RID: 16444
			[Token(Token = "0x400403C")]
			Parry,
			// Token: 0x0400403D RID: 16445
			[Token(Token = "0x400403D")]
			Locked,
			// Token: 0x0400403E RID: 16446
			[Token(Token = "0x400403E")]
			BlockActive,
			// Token: 0x0400403F RID: 16447
			[Token(Token = "0x400403F")]
			DigDirtAttach,
			// Token: 0x04004040 RID: 16448
			[Token(Token = "0x4004040")]
			MeleeSwingAudio,
			// Token: 0x04004041 RID: 16449
			[Token(Token = "0x4004041")]
			MeleeResetDamage,
			// Token: 0x04004042 RID: 16450
			[Token(Token = "0x4004042")]
			SpineOff,
			// Token: 0x04004043 RID: 16451
			[Token(Token = "0x4004043")]
			ItemLeavesHand,
			// Token: 0x04004044 RID: 16452
			[Token(Token = "0x4004044")]
			ThrowAttack,
			// Token: 0x04004045 RID: 16453
			[Token(Token = "0x4004045")]
			ChainSawHold,
			// Token: 0x04004046 RID: 16454
			[Token(Token = "0x4004046")]
			HeadWallPusher,
			// Token: 0x04004047 RID: 16455
			[Token(Token = "0x4004047")]
			PropHide
		}

		// Token: 0x020008B2 RID: 2226
		[Token(Token = "0x20008B2")]
		[Serializable]
		public class PlayerEvent : AnimStateEventBase
		{
			// Token: 0x06003C06 RID: 15366 RVA: 0x00011730 File Offset: 0x0000F930
			[Token(Token = "0x6003C06")]
			[Address(RVA = "0x2F21BA0", Offset = "0x2F20BA0", VA = "0x182F21BA0", Slot = "7")]
			public virtual Color GetGuiColor()
			{
				return default(Color);
			}

			// Token: 0x06003C07 RID: 15367 RVA: 0x00011748 File Offset: 0x0000F948
			[Token(Token = "0x6003C07")]
			[Address(RVA = "0x2F21CE0", Offset = "0x2F20CE0", VA = "0x182F21CE0", Slot = "4")]
			public override bool IsRange()
			{
				return default(bool);
			}

			// Token: 0x06003C08 RID: 15368 RVA: 0x00011760 File Offset: 0x0000F960
			[Token(Token = "0x6003C08")]
			[Address(RVA = "0x2F21B80", Offset = "0x2F20B80", VA = "0x182F21B80", Slot = "5")]
			public override bool EndOnExitStart()
			{
				return default(bool);
			}

			// Token: 0x06003C09 RID: 15369 RVA: 0x00011778 File Offset: 0x0000F978
			[Token(Token = "0x6003C09")]
			[Address(RVA = "0x2F21D00", Offset = "0x2F20D00", VA = "0x182F21D00")]
			public bool ShowValue()
			{
				return default(bool);
			}

			// Token: 0x06003C0A RID: 15370 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003C0A")]
			[Address(RVA = "0x2F21B00", Offset = "0x2F20B00", VA = "0x182F21B00", Slot = "6")]
			public override AnimStateEventBase Clone()
			{
				return null;
			}

			// Token: 0x06003C0B RID: 15371 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003C0B")]
			[Address(RVA = "0x2666370", Offset = "0x2665370", VA = "0x182666370")]
			public PlayerEvent()
			{
			}

			// Token: 0x04004048 RID: 16456
			[Token(Token = "0x4004048")]
			[FieldOffset(Offset = "0x28")]
			public PlayerStateMachineEvents.PlayerEventType _type;

			// Token: 0x04004049 RID: 16457
			[Token(Token = "0x4004049")]
			[FieldOffset(Offset = "0x2C")]
			public int _value;
		}
	}
}
