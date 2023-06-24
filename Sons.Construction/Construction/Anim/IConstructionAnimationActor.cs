using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Inventory;
using UnityEngine;

namespace Construction.Anim
{
	// Token: 0x020002BB RID: 699
	[Token(Token = "0x20002BB")]
	public interface IConstructionAnimationActor
	{
		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06001519 RID: 5401
		[Token(Token = "0x17000466")]
		Transform MainTr { [Token(Token = "0x6001519")] get; }

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x0600151A RID: 5402
		[Token(Token = "0x17000467")]
		Transform LookTr { [Token(Token = "0x600151A")] get; }

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x0600151B RID: 5403
		[Token(Token = "0x17000468")]
		ItemInstance RightHandItem { [Token(Token = "0x600151B")] get; }

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x0600151C RID: 5404
		[Token(Token = "0x17000469")]
		Animator Animator { [Token(Token = "0x600151C")] get; }

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x0600151D RID: 5405
		[Token(Token = "0x1700046A")]
		AnimatorStateInfo UpperBodyState { [Token(Token = "0x600151D")] get; }

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x0600151E RID: 5406
		[Token(Token = "0x1700046B")]
		AnimatorStateInfo NextUpperBodyState { [Token(Token = "0x600151E")] get; }

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x0600151F RID: 5407
		[Token(Token = "0x1700046C")]
		Transform LeftHandWeapon { [Token(Token = "0x600151F")] get; }

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06001520 RID: 5408
		[Token(Token = "0x1700046D")]
		Transform RightHandWeapon { [Token(Token = "0x6001520")] get; }

		// Token: 0x06001521 RID: 5409
		[Token(Token = "0x6001521")]
		void InitiatePlaceAnim();

		// Token: 0x06001522 RID: 5410
		[Token(Token = "0x6001522")]
		void ClearPlaceAnim();

		// Token: 0x06001523 RID: 5411
		[Token(Token = "0x6001523")]
		IkHeldRenderer GetRightHandIkRenderer();

		// Token: 0x06001524 RID: 5412
		[Token(Token = "0x6001524")]
		void SetStateAnimControlledCamera(State state);

		// Token: 0x06001525 RID: 5413
		[Token(Token = "0x6001525")]
		void SetStateMovementLockedAndGrounded(State state);

		// Token: 0x06001526 RID: 5414
		[Token(Token = "0x6001526")]
		void SetStateBlockedInput(State state);

		// Token: 0x06001527 RID: 5415
		[Token(Token = "0x6001527")]
		void SetStateAnimationControllingWeaponClipBlend(State state);

		// Token: 0x06001528 RID: 5416
		[Token(Token = "0x6001528")]
		void SetStateBuildMode(State state);

		// Token: 0x06001529 RID: 5417
		[Token(Token = "0x6001529")]
		void EnableAnimatedMode();

		// Token: 0x0600152A RID: 5418
		[Token(Token = "0x600152A")]
		bool IsLookingDown();

		// Token: 0x0600152B RID: 5419
		[Token(Token = "0x600152B")]
		bool IsBelowWaist(float worldHeight);

		// Token: 0x0600152C RID: 5420
		[Token(Token = "0x600152C")]
		void StashLeftHandItem(bool memorizeItem);

		// Token: 0x0600152D RID: 5421
		[Token(Token = "0x600152D")]
		void EquipPreviousLeftHandItem();

		// Token: 0x0600152E RID: 5422
		[Token(Token = "0x600152E")]
		void BeginHorizontalCutPromptIk(TargetInfo target);

		// Token: 0x0600152F RID: 5423
		[Token(Token = "0x600152F")]
		void BeginVerticalCutPromptIk(TargetInfo target, bool allowAimingAbove);

		// Token: 0x06001530 RID: 5424
		[Token(Token = "0x6001530")]
		void BeginHeldItemPromptIk(Vector3 rightHandIkPos, Quaternion rotation, float ikWeight = 1f, bool bothHands = true);

		// Token: 0x06001531 RID: 5425
		[Token(Token = "0x6001531")]
		void BeginHeldItemIk(float smoothDuration, Vector3 rightHandIkPos, Quaternion rotation, float ikWeight = 1f, bool bothHands = true, float delay = 0f);

		// Token: 0x06001532 RID: 5426
		[Token(Token = "0x6001532")]
		void StopHeldItemIk();

		// Token: 0x06001533 RID: 5427
		[Token(Token = "0x6001533")]
		void BeginHeldRendererOnlyIK(Vector3 pos, Quaternion rot, Vector3 scale, IkSides sides, IkFilters filter = IkFilters.PosRotScale);

		// Token: 0x06001534 RID: 5428
		[Token(Token = "0x6001534")]
		void BeginHeldRendererOnlyIK(Vector3 pos, Quaternion rot, Vector3 scale, IkSides sides, float delay, float smoothDuration, IkFilters filter = IkFilters.PosRotScale);

		// Token: 0x06001535 RID: 5429
		[Token(Token = "0x6001535")]
		void StopHeldRendererOnlyIK(IkSides sides, bool smooth = false);

		// Token: 0x06001536 RID: 5430
		[Token(Token = "0x6001536")]
		void BeginHandIk(float smoothDuration, Vector3 handIkPos, Quaternion rotation, bool rightHand, bool maintainRotation, float ikWeight = 1f, float delay = 0f);

		// Token: 0x06001537 RID: 5431
		[Token(Token = "0x6001537")]
		void StopHandsIk(bool rightHand = true, bool leftHand = true);

		// Token: 0x06001538 RID: 5432
		[Token(Token = "0x6001538")]
		void BeginAimIk(Vector3 worldPos, IkAimModes aimModes = IkAimModes.Position);

		// Token: 0x06001539 RID: 5433
		[Token(Token = "0x6001539")]
		void BeginAimIk(float smoothDuration, Vector3 worldPos, IkAimModes aimModes = IkAimModes.Position, float delay = 0f);

		// Token: 0x0600153A RID: 5434
		[Token(Token = "0x600153A")]
		void BeginPlaceAimIk(TargetInfo target, IkAimModes aimModes = IkAimModes.Position);

		// Token: 0x0600153B RID: 5435
		[Token(Token = "0x600153B")]
		void BeginCutAimIk(TargetInfo target, IkAimModes aimModes = IkAimModes.Position);

		// Token: 0x0600153C RID: 5436
		[Token(Token = "0x600153C")]
		void StopAimIk();

		// Token: 0x0600153D RID: 5437
		[Token(Token = "0x600153D")]
		void SpawnHeldRendererPlaceHolder(IkSides rightHand, [Optional] Transform rendererTr);

		// Token: 0x0600153E RID: 5438
		[Token(Token = "0x600153E")]
		void AimAxeAtBuildingBlock(Vector3 targetPosition);

		// Token: 0x0600153F RID: 5439
		[Token(Token = "0x600153F")]
		void OnTogglePlacementMode();
	}
}
