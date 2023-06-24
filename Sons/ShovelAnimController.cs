using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Environment;
using Sons.Environment.Digging;
using Sons.Environment.Digging.TerrainDig;
using Sons.Gameplay;
using Sons.Gui.Input;
using Sons.Inventory;
using Sons.Weapon;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x02000164 RID: 356
[Token(Token = "0x2000164")]
public class ShovelAnimController : HeldControllerBase, IDiggingTool
{
	// Token: 0x17000156 RID: 342
	// (get) Token: 0x06000AC2 RID: 2754 RVA: 0x00004B48 File Offset: 0x00002D48
	[Token(Token = "0x17000156")]
	public LayerMask DigLayerMask
	{
		[Token(Token = "0x6000AC2")]
		[Address(RVA = "0x67E8C0", Offset = "0x67CEC0", VA = "0x18067E8C0")]
		get
		{
			return default(LayerMask);
		}
	}

	// Token: 0x17000157 RID: 343
	// (get) Token: 0x06000AC3 RID: 2755 RVA: 0x00004B60 File Offset: 0x00002D60
	[Token(Token = "0x17000157")]
	public bool IsDigging
	{
		[Token(Token = "0x6000AC3")]
		[Address(RVA = "0x625BD0", Offset = "0x6241D0", VA = "0x180625BD0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000158 RID: 344
	// (get) Token: 0x06000AC4 RID: 2756 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000158")]
	private PlayerAnimatorControl AnimControl
	{
		[Token(Token = "0x6000AC4")]
		[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000159 RID: 345
	// (get) Token: 0x06000AC5 RID: 2757 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000159")]
	private Animator PlayerAnimator
	{
		[Token(Token = "0x6000AC5")]
		[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700015A RID: 346
	// (get) Token: 0x06000AC6 RID: 2758 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700015A")]
	private Transform PlayerTransform
	{
		[Token(Token = "0x6000AC6")]
		[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700015B RID: 347
	// (get) Token: 0x06000AC7 RID: 2759 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700015B")]
	private ILayerBehaviourActivator[] DisableSpineActivators
	{
		[Token(Token = "0x6000AC7")]
		[Address(RVA = "0x36BC370", Offset = "0x36BA970", VA = "0x1836BC370")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000AC8 RID: 2760 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AC8")]
	[Address(RVA = "0x36BC510", Offset = "0x36BAB10", VA = "0x1836BC510", Slot = "5")]
	public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, ItemInstance itemInstance)
	{
	}

	// Token: 0x06000AC9 RID: 2761 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AC9")]
	[Address(RVA = "0x36BC900", Offset = "0x36BAF00", VA = "0x1836BC900")]
	private void OnEnable()
	{
	}

	// Token: 0x06000ACA RID: 2762 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ACA")]
	[Address(RVA = "0x36BD1B0", Offset = "0x36BB7B0", VA = "0x1836BD1B0")]
	private void OnDisable()
	{
	}

	// Token: 0x06000ACB RID: 2763 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ACB")]
	[Address(RVA = "0x36BDB20", Offset = "0x36BC120", VA = "0x1836BDB20")]
	private void Update()
	{
	}

	// Token: 0x06000ACC RID: 2764 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ACC")]
	[Address(RVA = "0x36BDCA0", Offset = "0x36BC2A0", VA = "0x1836BDCA0")]
	private void ClearIsInMidAction()
	{
	}

	// Token: 0x06000ACD RID: 2765 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ACD")]
	[Address(RVA = "0x36BDD50", Offset = "0x36BC350", VA = "0x1836BDD50")]
	private void SetIsInMidAction()
	{
	}

	// Token: 0x06000ACE RID: 2766 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ACE")]
	[Address(RVA = "0x36BDDB0", Offset = "0x36BC3B0", VA = "0x1836BDDB0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06000ACF RID: 2767 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ACF")]
	[Address(RVA = "0x36BDEA0", Offset = "0x36BC4A0", VA = "0x1836BDEA0")]
	public void TriggerWaterHitFX()
	{
	}

	// Token: 0x06000AD0 RID: 2768 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AD0")]
	[Address(RVA = "0x36BE340", Offset = "0x36BC940", VA = "0x1836BE340")]
	private void SetUiTarget(bool value)
	{
	}

	// Token: 0x06000AD1 RID: 2769 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AD1")]
	[Address(RVA = "0x36BE3B0", Offset = "0x36BC9B0", VA = "0x1836BE3B0")]
	private void UpdateAimDetection()
	{
	}

	// Token: 0x06000AD2 RID: 2770 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AD2")]
	[Address(RVA = "0x36BE650", Offset = "0x36BCC50", VA = "0x1836BE650")]
	private void CheckAttackInput()
	{
	}

	// Token: 0x06000AD3 RID: 2771 RVA: 0x00004B78 File Offset: 0x00002D78
	[Token(Token = "0x6000AD3")]
	[Address(RVA = "0x36BE720", Offset = "0x36BCD20", VA = "0x1836BE720")]
	private bool GetAttackInput()
	{
		return default(bool);
	}

	// Token: 0x06000AD4 RID: 2772 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AD4")]
	[Address(RVA = "0x36BE7E0", Offset = "0x36BCDE0", VA = "0x1836BE7E0")]
	private void CheckDigInput()
	{
	}

	// Token: 0x06000AD5 RID: 2773 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AD5")]
	[Address(RVA = "0x36BECE0", Offset = "0x36BD2E0", VA = "0x1836BECE0")]
	private void RefreshUiTarget(Vector3 aimDir, Vector3 aimBase)
	{
	}

	// Token: 0x06000AD6 RID: 2774 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AD6")]
	[Address(RVA = "0x36BEF30", Offset = "0x36BD530", VA = "0x1836BEF30")]
	private void CalculateAimBaseAndDir(Transform playerTransform, PlayerAnimatorControl playerAnimatorControl, out Vector3 aimBase, out Vector3 aimDir)
	{
	}

	// Token: 0x06000AD7 RID: 2775 RVA: 0x00004B90 File Offset: 0x00002D90
	[Token(Token = "0x6000AD7")]
	[Address(RVA = "0x36BF6C0", Offset = "0x36BDCC0", VA = "0x1836BF6C0")]
	private bool GetDigInput()
	{
		return default(bool);
	}

	// Token: 0x06000AD8 RID: 2776 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AD8")]
	[Address(RVA = "0x36BF780", Offset = "0x36BDD80", VA = "0x1836BF780")]
	private void TryDig(Vector3 aimBase, Vector3 aimDir, int digParamHash, ShovelAnimController.DigType digType)
	{
	}

	// Token: 0x06000AD9 RID: 2777 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AD9")]
	[Address(RVA = "0x36C0150", Offset = "0x36BE750", VA = "0x1836C0150")]
	private void SetActiveDiggingGroup(DiggingTileGroup target)
	{
	}

	// Token: 0x06000ADA RID: 2778 RVA: 0x00004BA8 File Offset: 0x00002DA8
	[Token(Token = "0x6000ADA")]
	[Address(RVA = "0x36C0230", Offset = "0x36BE830", VA = "0x1836C0230")]
	private ShovelAnimController.DigType GetBlocked(ShovelAnimController.DigType digType)
	{
		return ShovelAnimController.DigType.Hole;
	}

	// Token: 0x06000ADB RID: 2779 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ADB")]
	[Address(RVA = "0x36C02F0", Offset = "0x36BE8F0", VA = "0x1836C02F0")]
	private void DoAttack()
	{
	}

	// Token: 0x06000ADC RID: 2780 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ADC")]
	[Address(RVA = "0x36C0430", Offset = "0x36BEA30", VA = "0x1836C0430")]
	private void DoBlockedDig(Transform playerTransform, ShovelAnimController.DigType digType)
	{
	}

	// Token: 0x06000ADD RID: 2781 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ADD")]
	[Address(RVA = "0x36C0430", Offset = "0x36BEA30", VA = "0x1836C0430")]
	private void DoTerrainDig(Transform playerTransform, ShovelAnimController.DigType digType)
	{
	}

	// Token: 0x06000ADE RID: 2782 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ADE")]
	[Address(RVA = "0x36C04B0", Offset = "0x36BEAB0", VA = "0x1836C04B0")]
	private void DoDiggingGroupDig(Transform playerTransform, ShovelAnimController.DigType digType)
	{
	}

	// Token: 0x06000ADF RID: 2783 RVA: 0x00004BC0 File Offset: 0x00002DC0
	[Token(Token = "0x6000ADF")]
	[Address(RVA = "0x36C0640", Offset = "0x36BEC40", VA = "0x1836C0640")]
	private bool RaycastDig(Vector3 aimDir, Vector3 rayStart, out RaycastHit hit, out TerrainCollider terrainCollider, out bool maskedBlocked)
	{
		return default(bool);
	}

	// Token: 0x06000AE0 RID: 2784 RVA: 0x00004BD8 File Offset: 0x00002DD8
	[Token(Token = "0x6000AE0")]
	[Address(RVA = "0x36C1410", Offset = "0x36BFA10", VA = "0x1836C1410")]
	private bool DigRaycast(Vector3 aimDir, Vector3 rayStart, out RaycastHit hit)
	{
		return default(bool);
	}

	// Token: 0x06000AE1 RID: 2785 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AE1")]
	[Address(RVA = "0x36C1610", Offset = "0x36BFC10", VA = "0x1836C1610")]
	private void Stop(ref Coroutine existingRoutine)
	{
	}

	// Token: 0x06000AE2 RID: 2786 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AE2")]
	[Address(RVA = "0x36C1680", Offset = "0x36BFC80", VA = "0x1836C1680")]
	private void UpdateAttachedVelocity()
	{
	}

	// Token: 0x06000AE3 RID: 2787 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AE3")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	public void ShowMudOnShovel()
	{
	}

	// Token: 0x06000AE4 RID: 2788 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AE4")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	public void HideMudOnShovel()
	{
	}

	// Token: 0x06000AE5 RID: 2789 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AE5")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	public void DiggingFillStart()
	{
	}

	// Token: 0x06000AE6 RID: 2790 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AE6")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	public void DiggingFillEnd()
	{
	}

	// Token: 0x06000AE7 RID: 2791 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AE7")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	public void DiggingStart()
	{
	}

	// Token: 0x06000AE8 RID: 2792 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AE8")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	public void DiggingEnd()
	{
	}

	// Token: 0x06000AE9 RID: 2793 RVA: 0x00004BF0 File Offset: 0x00002DF0
	[Token(Token = "0x6000AE9")]
	[Address(RVA = "0x36C1970", Offset = "0x36BFF70", VA = "0x1836C1970")]
	private float GetStaminaFactor()
	{
		return 0f;
	}

	// Token: 0x06000AEA RID: 2794 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AEA")]
	[Address(RVA = "0x36C1A70", Offset = "0x36C0070", VA = "0x1836C1A70")]
	private void ApplySwingSpeed()
	{
	}

	// Token: 0x06000AEB RID: 2795 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AEB")]
	[Address(RVA = "0x36C1D40", Offset = "0x36C0340", VA = "0x1836C1D40")]
	private IEnumerator ShovelAttackRoutine()
	{
		return null;
	}

	// Token: 0x06000AEC RID: 2796 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AEC")]
	[Address(RVA = "0x36C1DD0", Offset = "0x36C03D0", VA = "0x1836C1DD0")]
	private IEnumerator DiggingTerrainRoutine(Transform playerTransform, ShovelAnimController.DigType digType)
	{
		return null;
	}

	// Token: 0x06000AED RID: 2797 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AED")]
	[Address(RVA = "0x36C1EE0", Offset = "0x36C04E0", VA = "0x1836C1EE0")]
	private IEnumerator DiggingGeneralizedWorker(Vector3 finalAlignPos, Quaternion finalAlignRotation, float digDirection, Transform playerTransform, int animDigTagHash, ShovelAnimController.DigType digType)
	{
		return null;
	}

	// Token: 0x06000AEE RID: 2798 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AEE")]
	[Address(RVA = "0x36C2030", Offset = "0x36C0630", VA = "0x1836C2030")]
	private void DisableFullBodyLayer()
	{
	}

	// Token: 0x06000AEF RID: 2799 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AEF")]
	[Address(RVA = "0x36C2120", Offset = "0x36C0720", VA = "0x1836C2120")]
	private void EnableFullBodyLayer()
	{
	}

	// Token: 0x06000AF0 RID: 2800 RVA: 0x00004C08 File Offset: 0x00002E08
	[Token(Token = "0x6000AF0")]
	[Address(RVA = "0x36C2210", Offset = "0x36C0810", VA = "0x1836C2210")]
	private AnimatorStateInfo GetNextStateInfoUpperBody()
	{
		return default(AnimatorStateInfo);
	}

	// Token: 0x06000AF1 RID: 2801 RVA: 0x00004C20 File Offset: 0x00002E20
	[Token(Token = "0x6000AF1")]
	[Address(RVA = "0x36C22C0", Offset = "0x36C08C0", VA = "0x1836C22C0")]
	private AnimatorStateInfo GetCurrentStateInfoUpperBody()
	{
		return default(AnimatorStateInfo);
	}

	// Token: 0x06000AF2 RID: 2802 RVA: 0x00004C38 File Offset: 0x00002E38
	[Token(Token = "0x6000AF2")]
	[Address(RVA = "0x36C2370", Offset = "0x36C0970", VA = "0x1836C2370")]
	private AnimatorStateInfo GetNextStateInfoFullBody()
	{
		return default(AnimatorStateInfo);
	}

	// Token: 0x06000AF3 RID: 2803 RVA: 0x00004C50 File Offset: 0x00002E50
	[Token(Token = "0x6000AF3")]
	[Address(RVA = "0x36C2420", Offset = "0x36C0A20", VA = "0x1836C2420")]
	private AnimatorStateInfo GetCurrentStateInfoFullBody()
	{
		return default(AnimatorStateInfo);
	}

	// Token: 0x06000AF4 RID: 2804 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AF4")]
	[Address(RVA = "0x36C24D0", Offset = "0x36C0AD0", VA = "0x1836C24D0")]
	private void LockPlayerMovement()
	{
	}

	// Token: 0x06000AF5 RID: 2805 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AF5")]
	[Address(RVA = "0x36C2810", Offset = "0x36C0E10", VA = "0x1836C2810")]
	private void LockMovement()
	{
	}

	// Token: 0x06000AF6 RID: 2806 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AF6")]
	[Address(RVA = "0x36C2870", Offset = "0x36C0E70", VA = "0x1836C2870")]
	private void UnlockMovement()
	{
	}

	// Token: 0x06000AF7 RID: 2807 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AF7")]
	[Address(RVA = "0x36C28D0", Offset = "0x36C0ED0", VA = "0x1836C28D0")]
	private void ApplyMovementSlow()
	{
	}

	// Token: 0x06000AF8 RID: 2808 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AF8")]
	[Address(RVA = "0x36C2980", Offset = "0x36C0F80", VA = "0x1836C2980")]
	private void DisableMovementSlow()
	{
	}

	// Token: 0x06000AF9 RID: 2809 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AF9")]
	[Address(RVA = "0x36C29E0", Offset = "0x36C0FE0", VA = "0x1836C29E0")]
	private void PartialUnlockPlayer(out bool partialUnlock)
	{
	}

	// Token: 0x06000AFA RID: 2810 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AFA")]
	[Address(RVA = "0x36C2D70", Offset = "0x36C1370", VA = "0x1836C2D70")]
	private void CheckRemoveTile(float digDirection, ref bool hasBrokenTile)
	{
	}

	// Token: 0x06000AFB RID: 2811 RVA: 0x00004C68 File Offset: 0x00002E68
	[Token(Token = "0x6000AFB")]
	[Address(RVA = "0x36C2E90", Offset = "0x36C1490", VA = "0x1836C2E90")]
	private bool IsBlocked(ShovelAnimController.DigType digType)
	{
		return default(bool);
	}

	// Token: 0x06000AFC RID: 2812 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AFC")]
	[Address(RVA = "0x36C2EA0", Offset = "0x36C14A0", VA = "0x1836C2EA0")]
	private IEnumerator FinalizePrevious()
	{
		return null;
	}

	// Token: 0x06000AFD RID: 2813 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AFD")]
	[Address(RVA = "0x36C2F30", Offset = "0x36C1530", VA = "0x1836C2F30")]
	private IEnumerator DiggingGroupRoutine(Transform playerTransform, ShovelAnimController.DigType digType)
	{
		return null;
	}

	// Token: 0x06000AFE RID: 2814 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AFE")]
	[Address(RVA = "0x36C3040", Offset = "0x36C1640", VA = "0x1836C3040")]
	private void FinalizeDig()
	{
	}

	// Token: 0x06000AFF RID: 2815 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AFF")]
	[Address(RVA = "0x36C3300", Offset = "0x36C1900", VA = "0x1836C3300")]
	private void UnlockPlayer()
	{
	}

	// Token: 0x06000B00 RID: 2816 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B00")]
	[Address(RVA = "0x36C3650", Offset = "0x36C1C50", VA = "0x1836C3650")]
	private void ReparentAlignTransform()
	{
	}

	// Token: 0x06000B01 RID: 2817 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B01")]
	[Address(RVA = "0x36C38F0", Offset = "0x36C1EF0", VA = "0x1836C38F0")]
	private IEnumerator AlignPlayerToTileRoutine(Transform sourceTransform)
	{
		return null;
	}

	// Token: 0x06000B02 RID: 2818 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B02")]
	[Address(RVA = "0x36C39F0", Offset = "0x36C1FF0", VA = "0x1836C39F0")]
	private void CheckAttachDetach(float digDirection, ShovelAnimController.DigType digType, ref float digStart, ref bool hasAttached, ref bool hasDetached)
	{
	}

	// Token: 0x06000B03 RID: 2819 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B03")]
	[Address(RVA = "0x36C4060", Offset = "0x36C2660", VA = "0x1836C4060")]
	private void InitializeAttachedObjectVelocity(Vector3 transformPosition)
	{
	}

	// Token: 0x06000B04 RID: 2820 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B04")]
	[Address(RVA = "0x36C4150", Offset = "0x36C2750", VA = "0x1836C4150")]
	private void CreateTerrainDigHole(GameObject terrainHoleProjectorPrefab, out Vector3 position, out Quaternion rotation)
	{
	}

	// Token: 0x06000B05 RID: 2821 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B05")]
	[Address(RVA = "0x36C4990", Offset = "0x36C2F90", VA = "0x1836C4990")]
	private static void InitializeTerrainHoleParent(ref TerrainDigManager terrainDigManager)
	{
	}

	// Token: 0x06000B06 RID: 2822 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B06")]
	[Address(RVA = "0x36C4B60", Offset = "0x36C3160", VA = "0x1836C4B60")]
	private void UpdateAttachRest()
	{
	}

	// Token: 0x06000B07 RID: 2823 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B07")]
	[Address(RVA = "0x36C50F0", Offset = "0x36C36F0", VA = "0x1836C50F0")]
	private void DetachPrefab()
	{
	}

	// Token: 0x06000B08 RID: 2824 RVA: 0x00004C80 File Offset: 0x00002E80
	[Token(Token = "0x6000B08")]
	[Address(RVA = "0x36C55E0", Offset = "0x36C3BE0", VA = "0x1836C55E0")]
	private bool TryGetAttachedObjectVelocity(out Vector3 result)
	{
		return default(bool);
	}

	// Token: 0x06000B09 RID: 2825 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B09")]
	[Address(RVA = "0x36C5930", Offset = "0x36C3F30", VA = "0x1836C5930")]
	private void AttachPrefab(Vector3 attachPos, GameObject prefabSource)
	{
	}

	// Token: 0x06000B0A RID: 2826 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B0A")]
	[Address(RVA = "0x36C5F40", Offset = "0x36C4540", VA = "0x1836C5F40")]
	private void ClearAttached()
	{
	}

	// Token: 0x06000B0B RID: 2827 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B0B")]
	[Address(RVA = "0x36C5FF0", Offset = "0x36C45F0", VA = "0x1836C5FF0", Slot = "10")]
	public void AddActiveDiggingGroup(DiggingTileGroup groupValue)
	{
	}

	// Token: 0x06000B0C RID: 2828 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B0C")]
	[Address(RVA = "0x36C6100", Offset = "0x36C4700", VA = "0x1836C6100", Slot = "11")]
	public void RemoveActiveDiggingGroup(DiggingTileGroup groupValue)
	{
	}

	// Token: 0x06000B0D RID: 2829 RVA: 0x00004C98 File Offset: 0x00002E98
	[Token(Token = "0x6000B0D")]
	[Address(RVA = "0x36C6180", Offset = "0x36C4780", VA = "0x1836C6180", Slot = "7")]
	public override bool IsItemIdle()
	{
		return default(bool);
	}

	// Token: 0x06000B0E RID: 2830 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B0E")]
	[Address(RVA = "0x36C6300", Offset = "0x36C4900", VA = "0x1836C6300")]
	private void SetupEvents()
	{
	}

	// Token: 0x06000B0F RID: 2831 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B0F")]
	[Address(RVA = "0x36C6A50", Offset = "0x36C5050", VA = "0x1836C6A50", Slot = "6")]
	protected override void OnDestroy()
	{
	}

	// Token: 0x06000B10 RID: 2832 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B10")]
	[Address(RVA = "0x36C7250", Offset = "0x36C5850", VA = "0x1836C7250")]
	private void OnDigDirtAttachEvent()
	{
	}

	// Token: 0x06000B11 RID: 2833 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B11")]
	[Address(RVA = "0x36C7260", Offset = "0x36C5860", VA = "0x1836C7260")]
	private void OnDigDirtDetachEvent()
	{
	}

	// Token: 0x06000B12 RID: 2834 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B12")]
	[Address(RVA = "0x36C7270", Offset = "0x36C5870", VA = "0x1836C7270")]
	private void OnLockedStartEvent()
	{
	}

	// Token: 0x06000B13 RID: 2835 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B13")]
	[Address(RVA = "0x36C7280", Offset = "0x36C5880", VA = "0x1836C7280")]
	private void OnLockedEndEvent()
	{
	}

	// Token: 0x06000B14 RID: 2836 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B14")]
	[Address(RVA = "0x36C7290", Offset = "0x36C5890", VA = "0x1836C7290")]
	private void OnDigEndEvent()
	{
	}

	// Token: 0x06000B15 RID: 2837 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B15")]
	[Address(RVA = "0x36C72A0", Offset = "0x36C58A0", VA = "0x1836C72A0")]
	private void OnDigStartEvent()
	{
	}

	// Token: 0x06000B16 RID: 2838 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B16")]
	[Address(RVA = "0x36C7330", Offset = "0x36C5930", VA = "0x1836C7330")]
	private void OnCheckComboStart()
	{
	}

	// Token: 0x06000B17 RID: 2839 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B17")]
	[Address(RVA = "0x36C7340", Offset = "0x36C5940", VA = "0x1836C7340")]
	private void OnCheckComboEnd()
	{
	}

	// Token: 0x06000B18 RID: 2840 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B18")]
	[Address(RVA = "0x36C7350", Offset = "0x36C5950", VA = "0x1836C7350")]
	private void OnMeleeAttackEvent()
	{
	}

	// Token: 0x06000B19 RID: 2841 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B19")]
	[Address(RVA = "0x36C7440", Offset = "0x36C5A40", VA = "0x1836C7440")]
	public ShovelAnimController()
	{
	}

	// Token: 0x0400091E RID: 2334
	[Token(Token = "0x400091E")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private ShovelDirtVfxController _shovelDirtVfxController;

	// Token: 0x0400091F RID: 2335
	[Token(Token = "0x400091F")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Transform _terrainDigEffectLocator;

	// Token: 0x04000920 RID: 2336
	[Token(Token = "0x4000920")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private float _maxRayDistance;

	// Token: 0x04000921 RID: 2337
	[Token(Token = "0x4000921")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Transform _digPrefabLocator;

	// Token: 0x04000922 RID: 2338
	[Token(Token = "0x4000922")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private GameObject _digAnimatedChunk;

	// Token: 0x04000923 RID: 2339
	[Token(Token = "0x4000923")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private TerrainDigObjectDefSet _terrainDigObjectDefSet;

	// Token: 0x04000924 RID: 2340
	[Token(Token = "0x4000924")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private Transform _terrainHolePrefabLocator;

	// Token: 0x04000925 RID: 2341
	[Token(Token = "0x4000925")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private Vector3 _digPrefabRestOffset;

	// Token: 0x04000926 RID: 2342
	[Token(Token = "0x4000926")]
	[FieldOffset(Offset = "0xAC")]
	[SerializeField]
	private float _digPrefabRestTimer;

	// Token: 0x04000927 RID: 2343
	[Token(Token = "0x4000927")]
	[FieldOffset(Offset = "0xB0")]
	private List<DiggingTileGroup> _activeDiggingGroups;

	// Token: 0x04000928 RID: 2344
	[Token(Token = "0x4000928")]
	[FieldOffset(Offset = "0xB8")]
	private DiggingTileGroup _tempDiggingGroup;

	// Token: 0x04000929 RID: 2345
	[Token(Token = "0x4000929")]
	[FieldOffset(Offset = "0xC0")]
	private DiggingTile _targetTile;

	// Token: 0x0400092A RID: 2346
	[Token(Token = "0x400092A")]
	[FieldOffset(Offset = "0xC8")]
	private GameObject _attachedObject;

	// Token: 0x0400092B RID: 2347
	[Token(Token = "0x400092B")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private float _detachSpeed;

	// Token: 0x0400092C RID: 2348
	[Token(Token = "0x400092C")]
	[FieldOffset(Offset = "0xD4")]
	[SerializeField]
	private float _alignTime;

	// Token: 0x0400092D RID: 2349
	[Token(Token = "0x400092D")]
	[FieldOffset(Offset = "0xD8")]
	[FormerlySerializedAs("_terrainMask")]
	[SerializeField]
	private LayerMask _digLayerMask;

	// Token: 0x0400092E RID: 2350
	[Token(Token = "0x400092E")]
	[FieldOffset(Offset = "0xDC")]
	[SerializeField]
	private LayerMask _digLayerBlockMask;

	// Token: 0x0400092F RID: 2351
	[Token(Token = "0x400092F")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	public int[] _terrainTextureMask;

	// Token: 0x04000930 RID: 2352
	[Token(Token = "0x4000930")]
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	private int _velocityFrames;

	// Token: 0x04000931 RID: 2353
	[Token(Token = "0x4000931")]
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	private ContainerItemSpawnerData _terrainDigItemData;

	// Token: 0x04000932 RID: 2354
	[Token(Token = "0x4000932")]
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	private Vector3 _terrainDigItemRandomOffset;

	// Token: 0x04000933 RID: 2355
	[Token(Token = "0x4000933")]
	[FieldOffset(Offset = "0x104")]
	[SerializeField]
	private Vector3 _terrainDigItemRandomRotation;

	// Token: 0x04000934 RID: 2356
	[Token(Token = "0x4000934")]
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	private float _sphereCastRadius;

	// Token: 0x04000935 RID: 2357
	[Token(Token = "0x4000935")]
	[FieldOffset(Offset = "0x114")]
	[SerializeField]
	private float _aimBaseForward;

	// Token: 0x04000936 RID: 2358
	[Token(Token = "0x4000936")]
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	private float _aimBaseUp;

	// Token: 0x04000937 RID: 2359
	[Token(Token = "0x4000937")]
	[FieldOffset(Offset = "0x11C")]
	[SerializeField]
	private Vector3 _aimRelativeOffset;

	// Token: 0x04000938 RID: 2360
	[Token(Token = "0x4000938")]
	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	private float _normCamXScale;

	// Token: 0x04000939 RID: 2361
	[Token(Token = "0x4000939")]
	[FieldOffset(Offset = "0x12C")]
	[SerializeField]
	private bool _skipDirtClump;

	// Token: 0x0400093A RID: 2362
	[Token(Token = "0x400093A")]
	[FieldOffset(Offset = "0x12D")]
	[SerializeField]
	private bool _skipDigEffects;

	// Token: 0x0400093B RID: 2363
	[Token(Token = "0x400093B")]
	[FieldOffset(Offset = "0x130")]
	[SerializeField]
	private float _diggingTileMaxDistance;

	// Token: 0x0400093C RID: 2364
	[Token(Token = "0x400093C")]
	[FieldOffset(Offset = "0x134")]
	[SerializeField]
	private float _groundAimThreshold;

	// Token: 0x0400093D RID: 2365
	[Token(Token = "0x400093D")]
	[FieldOffset(Offset = "0x138")]
	[SerializeField]
	private float _movementSlowSpeed;

	// Token: 0x0400093E RID: 2366
	[Token(Token = "0x400093E")]
	[FieldOffset(Offset = "0x13C")]
	[SerializeField]
	private float _diggingMovementSlowSpeed;

	// Token: 0x0400093F RID: 2367
	[Token(Token = "0x400093F")]
	[FieldOffset(Offset = "0x140")]
	[SerializeField]
	private float _rotationSlowSpeed;

	// Token: 0x04000940 RID: 2368
	[Token(Token = "0x4000940")]
	[FieldOffset(Offset = "0x148")]
	[SerializeField]
	private LinkUiElement _uiTarget;

	// Token: 0x04000941 RID: 2369
	[Token(Token = "0x4000941")]
	[FieldOffset(Offset = "0x150")]
	[SerializeField]
	private float _uiTargetOffset;

	// Token: 0x04000942 RID: 2370
	[Token(Token = "0x4000942")]
	[FieldOffset(Offset = "0x154")]
	[SerializeField]
	private float _digStaminaCost;

	// Token: 0x04000943 RID: 2371
	[Token(Token = "0x4000943")]
	[FieldOffset(Offset = "0x158")]
	[SerializeField]
	private weaponInfo _weaponInfo;

	// Token: 0x04000944 RID: 2372
	[Token(Token = "0x4000944")]
	[FieldOffset(Offset = "0x160")]
	private float _groundAimDetection;

	// Token: 0x04000945 RID: 2373
	[Token(Token = "0x4000945")]
	[FieldOffset(Offset = "0x164")]
	private bool _isDigAimActive;

	// Token: 0x04000946 RID: 2374
	[Token(Token = "0x4000946")]
	[FieldOffset(Offset = "0x168")]
	private Queue<Vector3> _attachedObjectVelocityFrames;

	// Token: 0x04000947 RID: 2375
	[Token(Token = "0x4000947")]
	[FieldOffset(Offset = "0x170")]
	private Transform _alignTr;

	// Token: 0x04000948 RID: 2376
	[Token(Token = "0x4000948")]
	[FieldOffset(Offset = "0x178")]
	private bool _isDigging;

	// Token: 0x04000949 RID: 2377
	[Token(Token = "0x4000949")]
	[FieldOffset(Offset = "0x17C")]
	private Vector3 smoothPos;

	// Token: 0x0400094A RID: 2378
	[Token(Token = "0x400094A")]
	[FieldOffset(Offset = "0x188")]
	private Quaternion smoothRot;

	// Token: 0x0400094B RID: 2379
	[Token(Token = "0x400094B")]
	[FieldOffset(Offset = "0x198")]
	private Vector3 lastShovelPos;

	// Token: 0x0400094C RID: 2380
	[Token(Token = "0x400094C")]
	[FieldOffset(Offset = "0x1A4")]
	private Vector3 _lastTargetPos;

	// Token: 0x0400094D RID: 2381
	[Token(Token = "0x400094D")]
	[FieldOffset(Offset = "0x0")]
	private static GameObject _terrainHoleParent;

	// Token: 0x0400094E RID: 2382
	[Token(Token = "0x400094E")]
	[FieldOffset(Offset = "0x1B0")]
	private int _terrainHoleCount;

	// Token: 0x0400094F RID: 2383
	[Token(Token = "0x400094F")]
	[FieldOffset(Offset = "0x1B4")]
	private int _terrainLineCount;

	// Token: 0x04000950 RID: 2384
	[Token(Token = "0x4000950")]
	[FieldOffset(Offset = "0x1B8")]
	private float _attachedTime;

	// Token: 0x04000951 RID: 2385
	[Token(Token = "0x4000951")]
	[FieldOffset(Offset = "0x1BC")]
	private Vector3 _attachedLocalPosition;

	// Token: 0x04000952 RID: 2386
	[Token(Token = "0x4000952")]
	[FieldOffset(Offset = "0x1C8")]
	private Quaternion _attachedLocalRotation;

	// Token: 0x04000953 RID: 2387
	[Token(Token = "0x4000953")]
	[FieldOffset(Offset = "0x1D8")]
	private bool _canDigAgain;

	// Token: 0x04000954 RID: 2388
	[Token(Token = "0x4000954")]
	[FieldOffset(Offset = "0x1E0")]
	private Coroutine _existingRoutine;

	// Token: 0x04000955 RID: 2389
	[Token(Token = "0x4000955")]
	[FieldOffset(Offset = "0x1E8")]
	private Coroutine _alignRoutine;

	// Token: 0x04000956 RID: 2390
	[Token(Token = "0x4000956")]
	[FieldOffset(Offset = "0x1F0")]
	private Coroutine _disableLayerCoroutine;

	// Token: 0x04000957 RID: 2391
	[Token(Token = "0x4000957")]
	[FieldOffset(Offset = "0x1F8")]
	private Coroutine _enableLayerCoroutine;

	// Token: 0x04000958 RID: 2392
	[Token(Token = "0x4000958")]
	[FieldOffset(Offset = "0x200")]
	private DiggingEvents _diggingEvents;

	// Token: 0x04000959 RID: 2393
	[Token(Token = "0x4000959")]
	[FieldOffset(Offset = "0x208")]
	private bool _checkCombo;

	// Token: 0x0400095A RID: 2394
	[Token(Token = "0x400095A")]
	[FieldOffset(Offset = "0x209")]
	private bool _digEvent;

	// Token: 0x0400095B RID: 2395
	[Token(Token = "0x400095B")]
	[FieldOffset(Offset = "0x20A")]
	private bool _playerLockedEvent;

	// Token: 0x0400095C RID: 2396
	[Token(Token = "0x400095C")]
	[FieldOffset(Offset = "0x20C")]
	private readonly int _attackHash;

	// Token: 0x0400095D RID: 2397
	[Token(Token = "0x400095D")]
	[FieldOffset(Offset = "0x210")]
	private readonly int _shovelDigHash;

	// Token: 0x0400095E RID: 2398
	[Token(Token = "0x400095E")]
	[FieldOffset(Offset = "0x214")]
	private readonly int _shovelDigLineHash;

	// Token: 0x0400095F RID: 2399
	[Token(Token = "0x400095F")]
	[FieldOffset(Offset = "0x218")]
	private readonly int _shovelDigBlockedHash;

	// Token: 0x04000960 RID: 2400
	[Token(Token = "0x4000960")]
	[FieldOffset(Offset = "0x21C")]
	private readonly int _shovelDigEmptyHash;

	// Token: 0x04000961 RID: 2401
	[Token(Token = "0x4000961")]
	[FieldOffset(Offset = "0x220")]
	private readonly int _animDigTagHash;

	// Token: 0x04000962 RID: 2402
	[Token(Token = "0x4000962")]
	[FieldOffset(Offset = "0x224")]
	private readonly int _dirtChunkDigAnimationStateHash;

	// Token: 0x04000963 RID: 2403
	[Token(Token = "0x4000963")]
	[FieldOffset(Offset = "0x228")]
	private readonly int _digAttackingTag;

	// Token: 0x04000964 RID: 2404
	[Token(Token = "0x4000964")]
	[FieldOffset(Offset = "0x230")]
	private Transform _alignTrParent;

	// Token: 0x04000965 RID: 2405
	[Token(Token = "0x4000965")]
	[FieldOffset(Offset = "0x238")]
	private int _currentDigIndex;

	// Token: 0x04000966 RID: 2406
	[Token(Token = "0x4000966")]
	[FieldOffset(Offset = "0x23C")]
	private bool _digDirtAttachEvent;

	// Token: 0x04000967 RID: 2407
	[Token(Token = "0x4000967")]
	[FieldOffset(Offset = "0x23D")]
	private bool _isAttacking;

	// Token: 0x04000968 RID: 2408
	[Token(Token = "0x4000968")]
	[FieldOffset(Offset = "0x240")]
	private int _prominentTerrainLayer;

	// Token: 0x04000969 RID: 2409
	[Token(Token = "0x4000969")]
	[FieldOffset(Offset = "0x244")]
	private int _prominentLayer;

	// Token: 0x0400096A RID: 2410
	[Token(Token = "0x400096A")]
	[FieldOffset(Offset = "0x248")]
	private Vector3 _playerPreviousPos;

	// Token: 0x0400096B RID: 2411
	[Token(Token = "0x400096B")]
	[FieldOffset(Offset = "0x258")]
	private Vitals _playerStats;

	// Token: 0x0400096C RID: 2412
	[Token(Token = "0x400096C")]
	[FieldOffset(Offset = "0x260")]
	[SerializeField]
	private GameObject _waterRippleProjector;

	// Token: 0x0400096D RID: 2413
	[Token(Token = "0x400096D")]
	[FieldOffset(Offset = "0x268")]
	[SerializeField]
	private GameObject _splashFXPrefab;

	// Token: 0x0400096E RID: 2414
	[Token(Token = "0x400096E")]
	[FieldOffset(Offset = "0x270")]
	[SerializeField]
	private float _destroyWaterFXAfterDelay;

	// Token: 0x0400096F RID: 2415
	[Token(Token = "0x400096F")]
	[FieldOffset(Offset = "0x278")]
	[SerializeField]
	private Transform _shovelTip;

	// Token: 0x04000970 RID: 2416
	[Token(Token = "0x4000970")]
	[FieldOffset(Offset = "0x280")]
	private bool _setIsInMidAction;

	// Token: 0x04000971 RID: 2417
	[Token(Token = "0x4000971")]
	[FieldOffset(Offset = "0x288")]
	private ILayerBehaviourActivator[] _cachedDisableSpineActivators;

	// Token: 0x04000972 RID: 2418
	[Token(Token = "0x4000972")]
	[FieldOffset(Offset = "0x290")]
	private bool _appliedMovementSlow;

	// Token: 0x04000973 RID: 2419
	[Token(Token = "0x4000973")]
	[FieldOffset(Offset = "0x291")]
	private bool _appliedMovementLock;

	// Token: 0x04000974 RID: 2420
	[Token(Token = "0x4000974")]
	[FieldOffset(Offset = "0x292")]
	private bool _hasLockedPlayer;

	// Token: 0x02000165 RID: 357
	[Token(Token = "0x2000165")]
	internal enum DigType
	{
		// Token: 0x04000976 RID: 2422
		[Token(Token = "0x4000976")]
		Hole,
		// Token: 0x04000977 RID: 2423
		[Token(Token = "0x4000977")]
		Line,
		// Token: 0x04000978 RID: 2424
		[Token(Token = "0x4000978")]
		BlockedHole,
		// Token: 0x04000979 RID: 2425
		[Token(Token = "0x4000979")]
		BlockedLine
	}
}
