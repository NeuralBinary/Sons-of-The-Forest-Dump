using System;
using Il2CppDummyDll;

namespace Sons.Ai.Vail
{
	// Token: 0x020000D5 RID: 213
	[Token(Token = "0x20000D5")]
	internal enum VailAnimStateTag
	{
		// Token: 0x04000677 RID: 1655
		[Token(Token = "0x4000677")]
		AlignToGround,
		// Token: 0x04000678 RID: 1656
		[Token(Token = "0x4000678")]
		NoGravity,
		// Token: 0x04000679 RID: 1657
		[Token(Token = "0x4000679")]
		VeryHighPriority,
		// Token: 0x0400067A RID: 1658
		[Token(Token = "0x400067A")]
		NoHeadLook,
		// Token: 0x0400067B RID: 1659
		[Token(Token = "0x400067B")]
		AimAssist,
		// Token: 0x0400067C RID: 1660
		[Token(Token = "0x400067C")]
		FireWeapon,
		// Token: 0x0400067D RID: 1661
		[Token(Token = "0x400067D")]
		RagdollOn,
		// Token: 0x0400067E RID: 1662
		[Token(Token = "0x400067E")]
		Pickup,
		// Token: 0x0400067F RID: 1663
		[Token(Token = "0x400067F")]
		Carry,
		// Token: 0x04000680 RID: 1664
		[Token(Token = "0x4000680")]
		Drop,
		// Token: 0x04000681 RID: 1665
		[Token(Token = "0x4000681")]
		MeleeOn,
		// Token: 0x04000682 RID: 1666
		[Token(Token = "0x4000682")]
		SnapTo,
		// Token: 0x04000683 RID: 1667
		[Token(Token = "0x4000683")]
		AudioEvent,
		// Token: 0x04000684 RID: 1668
		[Token(Token = "0x4000684")]
		PitchAimAssist,
		// Token: 0x04000685 RID: 1669
		[Token(Token = "0x4000685")]
		TriggerFX,
		// Token: 0x04000686 RID: 1670
		[Token(Token = "0x4000686")]
		ChangeVailState,
		// Token: 0x04000687 RID: 1671
		[Token(Token = "0x4000687")]
		ProneStomach,
		// Token: 0x04000688 RID: 1672
		[Token(Token = "0x4000688")]
		ProneBack,
		// Token: 0x04000689 RID: 1673
		[Token(Token = "0x4000689")]
		NoCollision,
		// Token: 0x0400068A RID: 1674
		[Token(Token = "0x400068A")]
		RagdollIfDead,
		// Token: 0x0400068B RID: 1675
		[Token(Token = "0x400068B")]
		KeepRotation,
		// Token: 0x0400068C RID: 1676
		[Token(Token = "0x400068C")]
		ShowObject,
		// Token: 0x0400068D RID: 1677
		[Token(Token = "0x400068D")]
		Dodge,
		// Token: 0x0400068E RID: 1678
		[Token(Token = "0x400068E")]
		NoHitCancel,
		// Token: 0x0400068F RID: 1679
		[Token(Token = "0x400068F")]
		LockTargetDistance,
		// Token: 0x04000690 RID: 1680
		[Token(Token = "0x4000690")]
		HitSnapDir,
		// Token: 0x04000691 RID: 1681
		[Token(Token = "0x4000691")]
		RagdollNamed,
		// Token: 0x04000692 RID: 1682
		[Token(Token = "0x4000692")]
		LoopingAudio,
		// Token: 0x04000693 RID: 1683
		[Token(Token = "0x4000693")]
		RotationRescale,
		// Token: 0x04000694 RID: 1684
		[Token(Token = "0x4000694")]
		Interact,
		// Token: 0x04000695 RID: 1685
		[Token(Token = "0x4000695")]
		Hidden,
		// Token: 0x04000696 RID: 1686
		[Token(Token = "0x4000696")]
		Block,
		// Token: 0x04000697 RID: 1687
		[Token(Token = "0x4000697")]
		StashHeld,
		// Token: 0x04000698 RID: 1688
		[Token(Token = "0x4000698")]
		PlaceItem,
		// Token: 0x04000699 RID: 1689
		[Token(Token = "0x4000699")]
		UseRagdollDeath,
		// Token: 0x0400069A RID: 1690
		[Token(Token = "0x400069A")]
		UseActorMover,
		// Token: 0x0400069B RID: 1691
		[Token(Token = "0x400069B")]
		YellFace,
		// Token: 0x0400069C RID: 1692
		[Token(Token = "0x400069C")]
		Killable,
		// Token: 0x0400069D RID: 1693
		[Token(Token = "0x400069D")]
		IgnoreBounds,
		// Token: 0x0400069E RID: 1694
		[Token(Token = "0x400069E")]
		Invincible,
		// Token: 0x0400069F RID: 1695
		[Token(Token = "0x400069F")]
		CameraShake,
		// Token: 0x040006A0 RID: 1696
		[Token(Token = "0x40006A0")]
		Performing,
		// Token: 0x040006A1 RID: 1697
		[Token(Token = "0x40006A1")]
		TreeSnap,
		// Token: 0x040006A2 RID: 1698
		[Token(Token = "0x40006A2")]
		AttachPickup,
		// Token: 0x040006A3 RID: 1699
		[Token(Token = "0x40006A3")]
		DyingBack,
		// Token: 0x040006A4 RID: 1700
		[Token(Token = "0x40006A4")]
		Dragging,
		// Token: 0x040006A5 RID: 1701
		[Token(Token = "0x40006A5")]
		TreeJump,
		// Token: 0x040006A6 RID: 1702
		[Token(Token = "0x40006A6")]
		SpawnActor,
		// Token: 0x040006A7 RID: 1703
		[Token(Token = "0x40006A7")]
		ThrowObject,
		// Token: 0x040006A8 RID: 1704
		[Token(Token = "0x40006A8")]
		NoPushCollision
	}
}
