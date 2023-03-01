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
using Sons.Weapon;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x02000165 RID: 357
[Token(Token = "0x2000165")]
public class ShovelAnimController : HeldControllerBase, IDiggingTool
{
	// Token: 0x1700014D RID: 333
	// (get) Token: 0x06000A72 RID: 2674 RVA: 0x00004938 File Offset: 0x00002B38
	[Token(Token = "0x1700014D")]
	public LayerMask DigLayerMask
	{
		[Token(Token = "0x6000A72")]
		[Address(RVA = "0x9862F0", Offset = "0x9852F0", VA = "0x1809862F0")]
		get
		{
			return default(LayerMask);
		}
	}

	// Token: 0x1700014E RID: 334
	// (get) Token: 0x06000A73 RID: 2675 RVA: 0x00004950 File Offset: 0x00002B50
	[Token(Token = "0x1700014E")]
	public bool IsDigging
	{
		[Token(Token = "0x6000A73")]
		[Address(RVA = "0x2224830", Offset = "0x2223830", VA = "0x182224830")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700014F RID: 335
	// (get) Token: 0x06000A74 RID: 2676 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700014F")]
	private PlayerAnimatorControl AnimControl
	{
		[Token(Token = "0x6000A74")]
		[Address(RVA = "0x52F1A0", Offset = "0x52E1A0", VA = "0x18052F1A0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000150 RID: 336
	// (get) Token: 0x06000A75 RID: 2677 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000150")]
	private Animator PlayerAnimator
	{
		[Token(Token = "0x6000A75")]
		[Address(RVA = "0x541220", Offset = "0x540220", VA = "0x180541220")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000151 RID: 337
	// (get) Token: 0x06000A76 RID: 2678 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000151")]
	private Transform PlayerTransform
	{
		[Token(Token = "0x6000A76")]
		[Address(RVA = "0x541230", Offset = "0x540230", VA = "0x180541230")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000152 RID: 338
	// (get) Token: 0x06000A77 RID: 2679 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000152")]
	private ILayerBehaviourActivator[] DisableSpineActivators
	{
		[Token(Token = "0x6000A77")]
		[Address(RVA = "0x2F53B20", Offset = "0x2F52B20", VA = "0x182F53B20")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000A78 RID: 2680 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A78")]
	[Address(RVA = "0x2F50180", Offset = "0x2F4F180", VA = "0x182F50180", Slot = "5")]
	public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, int itemId)
	{
	}

	// Token: 0x06000A79 RID: 2681 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A79")]
	[Address(RVA = "0x2F50E00", Offset = "0x2F4FE00", VA = "0x182F50E00")]
	private void OnEnable()
	{
	}

	// Token: 0x06000A7A RID: 2682 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A7A")]
	[Address(RVA = "0x2F509E0", Offset = "0x2F4F9E0", VA = "0x182F509E0")]
	private void OnDisable()
	{
	}

	// Token: 0x06000A7B RID: 2683 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A7B")]
	[Address(RVA = "0x2F534B0", Offset = "0x2F524B0", VA = "0x182F534B0")]
	private void Update()
	{
	}

	// Token: 0x06000A7C RID: 2684 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A7C")]
	[Address(RVA = "0x2F511C0", Offset = "0x2F501C0", VA = "0x182F511C0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06000A7D RID: 2685 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A7D")]
	[Address(RVA = "0x2F52240", Offset = "0x2F51240", VA = "0x182F52240")]
	public void TriggerWaterHitFX()
	{
	}

	// Token: 0x06000A7E RID: 2686 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A7E")]
	[Address(RVA = "0x2F51E90", Offset = "0x2F50E90", VA = "0x182F51E90")]
	private void SetUiTarget(bool value)
	{
	}

	// Token: 0x06000A7F RID: 2687 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A7F")]
	[Address(RVA = "0x2F52DA0", Offset = "0x2F51DA0", VA = "0x182F52DA0")]
	private void UpdateAimDetection()
	{
	}

	// Token: 0x06000A80 RID: 2688 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A80")]
	[Address(RVA = "0x2F4E390", Offset = "0x2F4D390", VA = "0x182F4E390")]
	private void CheckAttackInput()
	{
	}

	// Token: 0x06000A81 RID: 2689 RVA: 0x00004968 File Offset: 0x00002B68
	[Token(Token = "0x6000A81")]
	[Address(RVA = "0x2F4FC40", Offset = "0x2F4EC40", VA = "0x182F4FC40")]
	private bool GetAttackInput()
	{
		return default(bool);
	}

	// Token: 0x06000A82 RID: 2690 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A82")]
	[Address(RVA = "0x2F4E460", Offset = "0x2F4D460", VA = "0x182F4E460")]
	private void CheckDigInput()
	{
	}

	// Token: 0x06000A83 RID: 2691 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A83")]
	[Address(RVA = "0x2F51A40", Offset = "0x2F50A40", VA = "0x182F51A40")]
	private void RefreshUiTarget(Vector3 aimDir, Vector3 aimBase)
	{
	}

	// Token: 0x06000A84 RID: 2692 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A84")]
	[Address(RVA = "0x2F4D910", Offset = "0x2F4C910", VA = "0x182F4D910")]
	private void CalculateAimBaseAndDir(Transform playerTransform, PlayerAnimatorControl playerAnimatorControl, out Vector3 aimBase, out Vector3 aimDir)
	{
	}

	// Token: 0x06000A85 RID: 2693 RVA: 0x00004980 File Offset: 0x00002B80
	[Token(Token = "0x6000A85")]
	[Address(RVA = "0x2F4FE60", Offset = "0x2F4EE60", VA = "0x182F4FE60")]
	private bool GetDigInput()
	{
		return default(bool);
	}

	// Token: 0x06000A86 RID: 2694 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A86")]
	[Address(RVA = "0x2F524B0", Offset = "0x2F514B0", VA = "0x182F524B0")]
	private void TryDig(Vector3 aimBase, Vector3 aimDir, int digParamHash, ShovelAnimController.DigType digType)
	{
	}

	// Token: 0x06000A87 RID: 2695 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A87")]
	[Address(RVA = "0x2F51E40", Offset = "0x2F50E40", VA = "0x182F51E40")]
	private void SetActiveDiggingGroup(DiggingTileGroup target)
	{
	}

	// Token: 0x06000A88 RID: 2696 RVA: 0x00004998 File Offset: 0x00002B98
	[Token(Token = "0x6000A88")]
	[Address(RVA = "0x2F4FD00", Offset = "0x2F4ED00", VA = "0x182F4FD00")]
	private ShovelAnimController.DigType GetBlocked(ShovelAnimController.DigType digType)
	{
		return ShovelAnimController.DigType.Hole;
	}

	// Token: 0x06000A89 RID: 2697 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A89")]
	[Address(RVA = "0x2F4F520", Offset = "0x2F4E520", VA = "0x182F4F520")]
	private void DoAttack()
	{
	}

	// Token: 0x06000A8A RID: 2698 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A8A")]
	[Address(RVA = "0x2F4F610", Offset = "0x2F4E610", VA = "0x182F4F610")]
	private void DoBlockedDig(Transform playerTransform, ShovelAnimController.DigType digType)
	{
	}

	// Token: 0x06000A8B RID: 2699 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A8B")]
	[Address(RVA = "0x2F4F610", Offset = "0x2F4E610", VA = "0x182F4F610")]
	private void DoTerrainDig(Transform playerTransform, ShovelAnimController.DigType digType)
	{
	}

	// Token: 0x06000A8C RID: 2700 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A8C")]
	[Address(RVA = "0x2F4F650", Offset = "0x2F4E650", VA = "0x182F4F650")]
	private void DoDiggingGroupDig(Transform playerTransform, ShovelAnimController.DigType digType)
	{
	}

	// Token: 0x06000A8D RID: 2701 RVA: 0x000049B0 File Offset: 0x00002BB0
	[Token(Token = "0x6000A8D")]
	[Address(RVA = "0x2F51510", Offset = "0x2F50510", VA = "0x182F51510")]
	private bool RaycastDig(Vector3 aimDir, Vector3 rayStart, out RaycastHit hit, out TerrainCollider terrainCollider, out bool maskedBlocked)
	{
		return default(bool);
	}

	// Token: 0x06000A8E RID: 2702 RVA: 0x000049C8 File Offset: 0x00002BC8
	[Token(Token = "0x6000A8E")]
	[Address(RVA = "0x2F4F0B0", Offset = "0x2F4E0B0", VA = "0x182F4F0B0")]
	private bool DigRaycast(Vector3 aimDir, Vector3 rayStart, out RaycastHit hit)
	{
		return default(bool);
	}

	// Token: 0x06000A8F RID: 2703 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A8F")]
	[Address(RVA = "0x2F52210", Offset = "0x2F51210", VA = "0x182F52210")]
	private void Stop(ref Coroutine existingRoutine)
	{
	}

	// Token: 0x06000A90 RID: 2704 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A90")]
	[Address(RVA = "0x2F53340", Offset = "0x2F52340", VA = "0x182F53340")]
	private void UpdateAttachedVelocity()
	{
	}

	// Token: 0x06000A91 RID: 2705 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A91")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	public void ShowMudOnShovel()
	{
	}

	// Token: 0x06000A92 RID: 2706 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A92")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	public void HideMudOnShovel()
	{
	}

	// Token: 0x06000A93 RID: 2707 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A93")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	public void DiggingFillStart()
	{
	}

	// Token: 0x06000A94 RID: 2708 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A94")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	public void DiggingFillEnd()
	{
	}

	// Token: 0x06000A95 RID: 2709 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A95")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	public void DiggingStart()
	{
	}

	// Token: 0x06000A96 RID: 2710 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A96")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	public void DiggingEnd()
	{
	}

	// Token: 0x06000A97 RID: 2711 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A97")]
	[Address(RVA = "0x2F521A0", Offset = "0x2F511A0", VA = "0x182F521A0")]
	private IEnumerator ShovelAttackRoutine()
	{
		return null;
	}

	// Token: 0x06000A98 RID: 2712 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A98")]
	[Address(RVA = "0x2F4F3D0", Offset = "0x2F4E3D0", VA = "0x182F4F3D0")]
	private IEnumerator DiggingTerrainRoutine(Transform playerTransform, ShovelAnimController.DigType digType)
	{
		return null;
	}

	// Token: 0x06000A99 RID: 2713 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A99")]
	[Address(RVA = "0x2F4F260", Offset = "0x2F4E260", VA = "0x182F4F260")]
	private IEnumerator DiggingGeneralizedWorker(Vector3 finalAlignPos, Quaternion finalAlignRotation, float digDirection, Transform playerTransform, int animDigTagHash, ShovelAnimController.DigType digType)
	{
		return null;
	}

	// Token: 0x06000A9A RID: 2714 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A9A")]
	[Address(RVA = "0x2F4F470", Offset = "0x2F4E470", VA = "0x182F4F470")]
	private void DisableFullBodyLayer()
	{
	}

	// Token: 0x06000A9B RID: 2715 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A9B")]
	[Address(RVA = "0x2F4F700", Offset = "0x2F4E700", VA = "0x182F4F700")]
	private void EnableFullBodyLayer()
	{
	}

	// Token: 0x06000A9C RID: 2716 RVA: 0x000049E0 File Offset: 0x00002BE0
	[Token(Token = "0x6000A9C")]
	[Address(RVA = "0x2F4FF70", Offset = "0x2F4EF70", VA = "0x182F4FF70")]
	private AnimatorStateInfo GetNextStateInfoUpperBody()
	{
		return default(AnimatorStateInfo);
	}

	// Token: 0x06000A9D RID: 2717 RVA: 0x000049F8 File Offset: 0x00002BF8
	[Token(Token = "0x6000A9D")]
	[Address(RVA = "0x2F4FE10", Offset = "0x2F4EE10", VA = "0x182F4FE10")]
	private AnimatorStateInfo GetCurrentStateInfoUpperBody()
	{
		return default(AnimatorStateInfo);
	}

	// Token: 0x06000A9E RID: 2718 RVA: 0x00004A10 File Offset: 0x00002C10
	[Token(Token = "0x6000A9E")]
	[Address(RVA = "0x2F4FF20", Offset = "0x2F4EF20", VA = "0x182F4FF20")]
	private AnimatorStateInfo GetNextStateInfoFullBody()
	{
		return default(AnimatorStateInfo);
	}

	// Token: 0x06000A9F RID: 2719 RVA: 0x00004A28 File Offset: 0x00002C28
	[Token(Token = "0x6000A9F")]
	[Address(RVA = "0x2F4FDC0", Offset = "0x2F4EDC0", VA = "0x182F4FDC0")]
	private AnimatorStateInfo GetCurrentStateInfoFullBody()
	{
		return default(AnimatorStateInfo);
	}

	// Token: 0x06000AA0 RID: 2720 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AA0")]
	[Address(RVA = "0x2F50460", Offset = "0x2F4F460", VA = "0x182F50460")]
	private void LockPlayerMovement()
	{
	}

	// Token: 0x06000AA1 RID: 2721 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AA1")]
	[Address(RVA = "0x2F51290", Offset = "0x2F50290", VA = "0x182F51290")]
	private void PartialUnlockPlayer(out bool partialUnlock)
	{
	}

	// Token: 0x06000AA2 RID: 2722 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AA2")]
	[Address(RVA = "0x2F4E830", Offset = "0x2F4D830", VA = "0x182F4E830")]
	private void CheckRemoveTile(float digDirection, ref bool hasBrokenTile)
	{
	}

	// Token: 0x06000AA3 RID: 2723 RVA: 0x00004A40 File Offset: 0x00002C40
	[Token(Token = "0x6000AA3")]
	[Address(RVA = "0x2F50310", Offset = "0x2F4F310", VA = "0x182F50310")]
	private bool IsBlocked(ShovelAnimController.DigType digType)
	{
		return default(bool);
	}

	// Token: 0x06000AA4 RID: 2724 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AA4")]
	[Address(RVA = "0x2F4FBD0", Offset = "0x2F4EBD0", VA = "0x182F4FBD0")]
	private IEnumerator FinalizePrevious()
	{
		return null;
	}

	// Token: 0x06000AA5 RID: 2725 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AA5")]
	[Address(RVA = "0x2F4F330", Offset = "0x2F4E330", VA = "0x182F4F330")]
	private IEnumerator DiggingGroupRoutine(Transform playerTransform, ShovelAnimController.DigType digType)
	{
		return null;
	}

	// Token: 0x06000AA6 RID: 2726 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AA6")]
	[Address(RVA = "0x2F4F7B0", Offset = "0x2F4E7B0", VA = "0x182F4F7B0")]
	private void FinalizeDig()
	{
	}

	// Token: 0x06000AA7 RID: 2727 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AA7")]
	[Address(RVA = "0x2F51D10", Offset = "0x2F50D10", VA = "0x182F51D10")]
	private void ReparentAlignTransform()
	{
	}

	// Token: 0x06000AA8 RID: 2728 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AA8")]
	[Address(RVA = "0x2F4D5C0", Offset = "0x2F4C5C0", VA = "0x182F4D5C0")]
	private IEnumerator AlignPlayerToTileRoutine(Transform sourceTransform)
	{
		return null;
	}

	// Token: 0x06000AA9 RID: 2729 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AA9")]
	[Address(RVA = "0x2F4DF10", Offset = "0x2F4CF10", VA = "0x182F4DF10")]
	private void CheckAttachDetach(float digDirection, ShovelAnimController.DigType digType, ref float digStart, ref bool hasAttached, ref bool hasDetached)
	{
	}

	// Token: 0x06000AAA RID: 2730 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AAA")]
	[Address(RVA = "0x2F4FFC0", Offset = "0x2F4EFC0", VA = "0x182F4FFC0")]
	private void InitializeAttachedObjectVelocity(Vector3 transformPosition)
	{
	}

	// Token: 0x06000AAB RID: 2731 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AAB")]
	[Address(RVA = "0x2F4E960", Offset = "0x2F4D960", VA = "0x182F4E960")]
	private void CreateTerrainDigHole(GameObject terrainHoleProjectorPrefab, out Vector3 position, out Quaternion rotation)
	{
	}

	// Token: 0x06000AAC RID: 2732 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AAC")]
	[Address(RVA = "0x2F50090", Offset = "0x2F4F090", VA = "0x182F50090")]
	private static void InitializeTerrainHoleParent(ref TerrainDigManager terrainDigManager)
	{
	}

	// Token: 0x06000AAD RID: 2733 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AAD")]
	[Address(RVA = "0x2F52F30", Offset = "0x2F51F30", VA = "0x182F52F30")]
	private void UpdateAttachRest()
	{
	}

	// Token: 0x06000AAE RID: 2734 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AAE")]
	[Address(RVA = "0x2F4EE00", Offset = "0x2F4DE00", VA = "0x182F4EE00")]
	private void DetachPrefab()
	{
	}

	// Token: 0x06000AAF RID: 2735 RVA: 0x00004A58 File Offset: 0x00002C58
	[Token(Token = "0x6000AAF")]
	[Address(RVA = "0x2F52B80", Offset = "0x2F51B80", VA = "0x182F52B80")]
	private bool TryGetAttachedObjectVelocity(out Vector3 result)
	{
		return default(bool);
	}

	// Token: 0x06000AB0 RID: 2736 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AB0")]
	[Address(RVA = "0x2F4D650", Offset = "0x2F4C650", VA = "0x182F4D650")]
	private void AttachPrefab(Vector3 attachPos, GameObject prefabSource)
	{
	}

	// Token: 0x06000AB1 RID: 2737 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AB1")]
	[Address(RVA = "0x2F4E8E0", Offset = "0x2F4D8E0", VA = "0x182F4E8E0")]
	private void ClearAttached()
	{
	}

	// Token: 0x06000AB2 RID: 2738 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AB2")]
	[Address(RVA = "0x2F4D480", Offset = "0x2F4C480", VA = "0x182F4D480", Slot = "10")]
	public void AddActiveDiggingGroup(DiggingTileGroup groupValue)
	{
	}

	// Token: 0x06000AB3 RID: 2739 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AB3")]
	[Address(RVA = "0x2F51C80", Offset = "0x2F50C80", VA = "0x182F51C80", Slot = "11")]
	public void RemoveActiveDiggingGroup(DiggingTileGroup groupValue)
	{
	}

	// Token: 0x06000AB4 RID: 2740 RVA: 0x00004A70 File Offset: 0x00002C70
	[Token(Token = "0x6000AB4")]
	[Address(RVA = "0x2F50320", Offset = "0x2F4F320", VA = "0x182F50320", Slot = "7")]
	public override bool IsItemIdle()
	{
		return default(bool);
	}

	// Token: 0x06000AB5 RID: 2741 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AB5")]
	[Address(RVA = "0x2F51EC0", Offset = "0x2F50EC0", VA = "0x182F51EC0")]
	private void SetupEvents()
	{
	}

	// Token: 0x06000AB6 RID: 2742 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AB6")]
	[Address(RVA = "0x2F50670", Offset = "0x2F4F670", VA = "0x182F50670", Slot = "6")]
	protected override void OnDestroy()
	{
	}

	// Token: 0x06000AB7 RID: 2743 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AB7")]
	[Address(RVA = "0x2F509A0", Offset = "0x2F4F9A0", VA = "0x182F509A0")]
	private void OnDigDirtAttachEvent()
	{
	}

	// Token: 0x06000AB8 RID: 2744 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AB8")]
	[Address(RVA = "0x2F509B0", Offset = "0x2F4F9B0", VA = "0x182F509B0")]
	private void OnDigDirtDetachEvent()
	{
	}

	// Token: 0x06000AB9 RID: 2745 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AB9")]
	[Address(RVA = "0x2F51130", Offset = "0x2F50130", VA = "0x182F51130")]
	private void OnLockedStartEvent()
	{
	}

	// Token: 0x06000ABA RID: 2746 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ABA")]
	[Address(RVA = "0x2F51120", Offset = "0x2F50120", VA = "0x182F51120")]
	private void OnLockedEndEvent()
	{
	}

	// Token: 0x06000ABB RID: 2747 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ABB")]
	[Address(RVA = "0x2F509C0", Offset = "0x2F4F9C0", VA = "0x182F509C0")]
	private void OnDigEndEvent()
	{
	}

	// Token: 0x06000ABC RID: 2748 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ABC")]
	[Address(RVA = "0x2F509D0", Offset = "0x2F4F9D0", VA = "0x182F509D0")]
	private void OnDigStartEvent()
	{
	}

	// Token: 0x06000ABD RID: 2749 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ABD")]
	[Address(RVA = "0x2F50660", Offset = "0x2F4F660", VA = "0x182F50660")]
	private void OnCheckComboStart()
	{
	}

	// Token: 0x06000ABE RID: 2750 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ABE")]
	[Address(RVA = "0x2F50650", Offset = "0x2F4F650", VA = "0x182F50650")]
	private void OnCheckComboEnd()
	{
	}

	// Token: 0x06000ABF RID: 2751 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ABF")]
	[Address(RVA = "0x2F51140", Offset = "0x2F50140", VA = "0x182F51140")]
	private void OnMeleeAttackEvent()
	{
	}

	// Token: 0x06000AC0 RID: 2752 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AC0")]
	[Address(RVA = "0x2F53890", Offset = "0x2F52890", VA = "0x182F53890")]
	public ShovelAnimController()
	{
	}

	// Token: 0x040008FD RID: 2301
	[Token(Token = "0x40008FD")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private ShovelDirtVfxController _shovelDirtVfxController;

	// Token: 0x040008FE RID: 2302
	[Token(Token = "0x40008FE")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Transform _terrainDigEffectLocator;

	// Token: 0x040008FF RID: 2303
	[Token(Token = "0x40008FF")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private float _maxRayDistance;

	// Token: 0x04000900 RID: 2304
	[Token(Token = "0x4000900")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Transform _digPrefabLocator;

	// Token: 0x04000901 RID: 2305
	[Token(Token = "0x4000901")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private GameObject _digAnimatedChunk;

	// Token: 0x04000902 RID: 2306
	[Token(Token = "0x4000902")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private TerrainDigObjectDefSet _terrainDigObjectDefSet;

	// Token: 0x04000903 RID: 2307
	[Token(Token = "0x4000903")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private Transform _terrainHolePrefabLocator;

	// Token: 0x04000904 RID: 2308
	[Token(Token = "0x4000904")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private Vector3 _digPrefabRestOffset;

	// Token: 0x04000905 RID: 2309
	[Token(Token = "0x4000905")]
	[FieldOffset(Offset = "0xB4")]
	[SerializeField]
	private float _digPrefabRestTimer;

	// Token: 0x04000906 RID: 2310
	[Token(Token = "0x4000906")]
	[FieldOffset(Offset = "0xB8")]
	private List<DiggingTileGroup> _activeDiggingGroups;

	// Token: 0x04000907 RID: 2311
	[Token(Token = "0x4000907")]
	[FieldOffset(Offset = "0xC0")]
	private DiggingTileGroup _tempDiggingGroup;

	// Token: 0x04000908 RID: 2312
	[Token(Token = "0x4000908")]
	[FieldOffset(Offset = "0xC8")]
	private DiggingTile _targetTile;

	// Token: 0x04000909 RID: 2313
	[Token(Token = "0x4000909")]
	[FieldOffset(Offset = "0xD0")]
	private GameObject _attachedObject;

	// Token: 0x0400090A RID: 2314
	[Token(Token = "0x400090A")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private float _detachSpeed;

	// Token: 0x0400090B RID: 2315
	[Token(Token = "0x400090B")]
	[FieldOffset(Offset = "0xDC")]
	[SerializeField]
	private float _alignTime;

	// Token: 0x0400090C RID: 2316
	[Token(Token = "0x400090C")]
	[FieldOffset(Offset = "0xE0")]
	[FormerlySerializedAs("_terrainMask")]
	[SerializeField]
	private LayerMask _digLayerMask;

	// Token: 0x0400090D RID: 2317
	[Token(Token = "0x400090D")]
	[FieldOffset(Offset = "0xE4")]
	[SerializeField]
	private LayerMask _digLayerBlockMask;

	// Token: 0x0400090E RID: 2318
	[Token(Token = "0x400090E")]
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	public int[] _terrainTextureMask;

	// Token: 0x0400090F RID: 2319
	[Token(Token = "0x400090F")]
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	private int _velocityFrames;

	// Token: 0x04000910 RID: 2320
	[Token(Token = "0x4000910")]
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	private ContainerItemSpawnerData _terrainDigItemData;

	// Token: 0x04000911 RID: 2321
	[Token(Token = "0x4000911")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	private Vector3 _terrainDigItemRandomOffset;

	// Token: 0x04000912 RID: 2322
	[Token(Token = "0x4000912")]
	[FieldOffset(Offset = "0x10C")]
	[SerializeField]
	private Vector3 _terrainDigItemRandomRotation;

	// Token: 0x04000913 RID: 2323
	[Token(Token = "0x4000913")]
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	private float _sphereCastRadius;

	// Token: 0x04000914 RID: 2324
	[Token(Token = "0x4000914")]
	[FieldOffset(Offset = "0x11C")]
	[SerializeField]
	private float _aimBaseForward;

	// Token: 0x04000915 RID: 2325
	[Token(Token = "0x4000915")]
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	private float _aimBaseUp;

	// Token: 0x04000916 RID: 2326
	[Token(Token = "0x4000916")]
	[FieldOffset(Offset = "0x124")]
	[SerializeField]
	private Vector3 _aimRelativeOffset;

	// Token: 0x04000917 RID: 2327
	[Token(Token = "0x4000917")]
	[FieldOffset(Offset = "0x130")]
	[SerializeField]
	private float _normCamXScale;

	// Token: 0x04000918 RID: 2328
	[Token(Token = "0x4000918")]
	[FieldOffset(Offset = "0x134")]
	[SerializeField]
	private bool _skipDirtClump;

	// Token: 0x04000919 RID: 2329
	[Token(Token = "0x4000919")]
	[FieldOffset(Offset = "0x135")]
	[SerializeField]
	private bool _skipDigEffects;

	// Token: 0x0400091A RID: 2330
	[Token(Token = "0x400091A")]
	[FieldOffset(Offset = "0x138")]
	[SerializeField]
	private float _diggingTileMaxDistance;

	// Token: 0x0400091B RID: 2331
	[Token(Token = "0x400091B")]
	[FieldOffset(Offset = "0x13C")]
	[SerializeField]
	private float _groundAimThreshold;

	// Token: 0x0400091C RID: 2332
	[Token(Token = "0x400091C")]
	[FieldOffset(Offset = "0x140")]
	[SerializeField]
	private float _movementSlowSpeed;

	// Token: 0x0400091D RID: 2333
	[Token(Token = "0x400091D")]
	[FieldOffset(Offset = "0x144")]
	[SerializeField]
	private float _rotationSlowSpeed;

	// Token: 0x0400091E RID: 2334
	[Token(Token = "0x400091E")]
	[FieldOffset(Offset = "0x148")]
	[SerializeField]
	private LinkUiElement _uiTarget;

	// Token: 0x0400091F RID: 2335
	[Token(Token = "0x400091F")]
	[FieldOffset(Offset = "0x150")]
	[SerializeField]
	private float _uiTargetOffset;

	// Token: 0x04000920 RID: 2336
	[Token(Token = "0x4000920")]
	[FieldOffset(Offset = "0x154")]
	private float _groundAimDetection;

	// Token: 0x04000921 RID: 2337
	[Token(Token = "0x4000921")]
	[FieldOffset(Offset = "0x158")]
	private bool _isDigAimActive;

	// Token: 0x04000922 RID: 2338
	[Token(Token = "0x4000922")]
	[FieldOffset(Offset = "0x160")]
	private Queue<Vector3> _attachedObjectVelocityFrames;

	// Token: 0x04000923 RID: 2339
	[Token(Token = "0x4000923")]
	[FieldOffset(Offset = "0x168")]
	private Transform _alignTr;

	// Token: 0x04000924 RID: 2340
	[Token(Token = "0x4000924")]
	[FieldOffset(Offset = "0x170")]
	private bool _isDigging;

	// Token: 0x04000925 RID: 2341
	[Token(Token = "0x4000925")]
	[FieldOffset(Offset = "0x174")]
	private Vector3 smoothPos;

	// Token: 0x04000926 RID: 2342
	[Token(Token = "0x4000926")]
	[FieldOffset(Offset = "0x180")]
	private Quaternion smoothRot;

	// Token: 0x04000927 RID: 2343
	[Token(Token = "0x4000927")]
	[FieldOffset(Offset = "0x190")]
	private Vector3 lastShovelPos;

	// Token: 0x04000928 RID: 2344
	[Token(Token = "0x4000928")]
	[FieldOffset(Offset = "0x19C")]
	private Vector3 _lastTargetPos;

	// Token: 0x04000929 RID: 2345
	[Token(Token = "0x4000929")]
	[FieldOffset(Offset = "0x0")]
	private static GameObject _terrainHoleParent;

	// Token: 0x0400092A RID: 2346
	[Token(Token = "0x400092A")]
	[FieldOffset(Offset = "0x1A8")]
	private int _terrainHoleCount;

	// Token: 0x0400092B RID: 2347
	[Token(Token = "0x400092B")]
	[FieldOffset(Offset = "0x1AC")]
	private int _terrainLineCount;

	// Token: 0x0400092C RID: 2348
	[Token(Token = "0x400092C")]
	[FieldOffset(Offset = "0x1B0")]
	private float _attachedTime;

	// Token: 0x0400092D RID: 2349
	[Token(Token = "0x400092D")]
	[FieldOffset(Offset = "0x1B4")]
	private Vector3 _attachedLocalPosition;

	// Token: 0x0400092E RID: 2350
	[Token(Token = "0x400092E")]
	[FieldOffset(Offset = "0x1C0")]
	private Quaternion _attachedLocalRotation;

	// Token: 0x0400092F RID: 2351
	[Token(Token = "0x400092F")]
	[FieldOffset(Offset = "0x1D0")]
	private bool _canDigAgain;

	// Token: 0x04000930 RID: 2352
	[Token(Token = "0x4000930")]
	[FieldOffset(Offset = "0x1D8")]
	private Coroutine _existingRoutine;

	// Token: 0x04000931 RID: 2353
	[Token(Token = "0x4000931")]
	[FieldOffset(Offset = "0x1E0")]
	private Coroutine _alignRoutine;

	// Token: 0x04000932 RID: 2354
	[Token(Token = "0x4000932")]
	[FieldOffset(Offset = "0x1E8")]
	private Coroutine _disableLayerCoroutine;

	// Token: 0x04000933 RID: 2355
	[Token(Token = "0x4000933")]
	[FieldOffset(Offset = "0x1F0")]
	private Coroutine _enableLayerCoroutine;

	// Token: 0x04000934 RID: 2356
	[Token(Token = "0x4000934")]
	[FieldOffset(Offset = "0x1F8")]
	private DiggingEvents _diggingEvents;

	// Token: 0x04000935 RID: 2357
	[Token(Token = "0x4000935")]
	[FieldOffset(Offset = "0x200")]
	private bool _checkCombo;

	// Token: 0x04000936 RID: 2358
	[Token(Token = "0x4000936")]
	[FieldOffset(Offset = "0x201")]
	private bool _digEvent;

	// Token: 0x04000937 RID: 2359
	[Token(Token = "0x4000937")]
	[FieldOffset(Offset = "0x202")]
	private bool _playerLockedEvent;

	// Token: 0x04000938 RID: 2360
	[Token(Token = "0x4000938")]
	[FieldOffset(Offset = "0x204")]
	private readonly int _attackHash;

	// Token: 0x04000939 RID: 2361
	[Token(Token = "0x4000939")]
	[FieldOffset(Offset = "0x208")]
	private readonly int _shovelDigHash;

	// Token: 0x0400093A RID: 2362
	[Token(Token = "0x400093A")]
	[FieldOffset(Offset = "0x20C")]
	private readonly int _shovelDigLineHash;

	// Token: 0x0400093B RID: 2363
	[Token(Token = "0x400093B")]
	[FieldOffset(Offset = "0x210")]
	private readonly int _shovelDigBlockedHash;

	// Token: 0x0400093C RID: 2364
	[Token(Token = "0x400093C")]
	[FieldOffset(Offset = "0x214")]
	private readonly int _shovelDigEmptyHash;

	// Token: 0x0400093D RID: 2365
	[Token(Token = "0x400093D")]
	[FieldOffset(Offset = "0x218")]
	private readonly int _animDigTagHash;

	// Token: 0x0400093E RID: 2366
	[Token(Token = "0x400093E")]
	[FieldOffset(Offset = "0x21C")]
	private readonly int _dirtChunkDigAnimationStateHash;

	// Token: 0x0400093F RID: 2367
	[Token(Token = "0x400093F")]
	[FieldOffset(Offset = "0x220")]
	private readonly int _digAttackingTag;

	// Token: 0x04000940 RID: 2368
	[Token(Token = "0x4000940")]
	[FieldOffset(Offset = "0x228")]
	private Transform _alignTrParent;

	// Token: 0x04000941 RID: 2369
	[Token(Token = "0x4000941")]
	[FieldOffset(Offset = "0x230")]
	private int _currentDigIndex;

	// Token: 0x04000942 RID: 2370
	[Token(Token = "0x4000942")]
	[FieldOffset(Offset = "0x234")]
	private bool _digDirtAttachEvent;

	// Token: 0x04000943 RID: 2371
	[Token(Token = "0x4000943")]
	[FieldOffset(Offset = "0x235")]
	private bool _isAttacking;

	// Token: 0x04000944 RID: 2372
	[Token(Token = "0x4000944")]
	[FieldOffset(Offset = "0x238")]
	private int _prominentTerrainLayer;

	// Token: 0x04000945 RID: 2373
	[Token(Token = "0x4000945")]
	[FieldOffset(Offset = "0x23C")]
	private int _prominentLayer;

	// Token: 0x04000946 RID: 2374
	[Token(Token = "0x4000946")]
	[FieldOffset(Offset = "0x240")]
	private Vector3 _playerPreviousPos;

	// Token: 0x04000947 RID: 2375
	[Token(Token = "0x4000947")]
	[FieldOffset(Offset = "0x250")]
	private weaponInfo _weaponInfo;

	// Token: 0x04000948 RID: 2376
	[Token(Token = "0x4000948")]
	[FieldOffset(Offset = "0x258")]
	[SerializeField]
	private GameObject _waterRippleProjector;

	// Token: 0x04000949 RID: 2377
	[Token(Token = "0x4000949")]
	[FieldOffset(Offset = "0x260")]
	[SerializeField]
	private GameObject _splashFXPrefab;

	// Token: 0x0400094A RID: 2378
	[Token(Token = "0x400094A")]
	[FieldOffset(Offset = "0x268")]
	[SerializeField]
	private float _destroyWaterFXAfterDelay;

	// Token: 0x0400094B RID: 2379
	[Token(Token = "0x400094B")]
	[FieldOffset(Offset = "0x270")]
	[SerializeField]
	private Transform _shovelTip;

	// Token: 0x0400094C RID: 2380
	[Token(Token = "0x400094C")]
	[FieldOffset(Offset = "0x278")]
	private ILayerBehaviourActivator[] _cachedDisableSpineActivators;

	// Token: 0x02000166 RID: 358
	[Token(Token = "0x2000166")]
	internal enum DigType
	{
		// Token: 0x0400094E RID: 2382
		[Token(Token = "0x400094E")]
		Hole,
		// Token: 0x0400094F RID: 2383
		[Token(Token = "0x400094F")]
		Line,
		// Token: 0x04000950 RID: 2384
		[Token(Token = "0x4000950")]
		BlockedHole,
		// Token: 0x04000951 RID: 2385
		[Token(Token = "0x4000951")]
		BlockedLine
	}
}
