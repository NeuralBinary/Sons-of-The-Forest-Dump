using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

// Token: 0x02000046 RID: 70
[Token(Token = "0x2000046")]
public class InteractableWaterNode : MonoBehaviour
{
	// Token: 0x060001DF RID: 479 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x28E2200", Offset = "0x28E0800", VA = "0x1828E2200")]
	public void SetDistanceToNode(float distance)
	{
	}

	// Token: 0x060001E0 RID: 480 RVA: 0x000028F8 File Offset: 0x00000AF8
	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x23BB730", Offset = "0x23B9D30", VA = "0x1823BB730")]
	public float GetDistanceToNode()
	{
		return 0f;
	}

	// Token: 0x060001E1 RID: 481 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x5B2560", Offset = "0x5B0B60", VA = "0x1805B2560")]
	public void SetRecipe(StatRecipe recipe)
	{
	}

	// Token: 0x060001E2 RID: 482 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
	public StatRecipe GetRecipe()
	{
		return null;
	}

	// Token: 0x060001E3 RID: 483 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x31A8470", Offset = "0x31A6A70", VA = "0x1831A8470")]
	private void Update()
	{
	}

	// Token: 0x060001E4 RID: 484 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x31A8480", Offset = "0x31A6A80", VA = "0x1831A8480")]
	private void OnEnable()
	{
	}

	// Token: 0x060001E5 RID: 485 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x31A8750", Offset = "0x31A6D50", VA = "0x1831A8750")]
	private void OnDisable()
	{
	}

	// Token: 0x060001E6 RID: 486 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x31A8A10", Offset = "0x31A7010", VA = "0x1831A8A10")]
	private void SetupLinkUi()
	{
	}

	// Token: 0x060001E7 RID: 487 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x31A8CC0", Offset = "0x31A72C0", VA = "0x1831A8CC0")]
	private void OnTakeAction(InputAction.CallbackContext obj)
	{
	}

	// Token: 0x060001E8 RID: 488 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x31A8CE0", Offset = "0x31A72E0", VA = "0x1831A8CE0")]
	private void OnUseAction(InputAction.CallbackContext obj)
	{
	}

	// Token: 0x060001E9 RID: 489 RVA: 0x00002910 File Offset: 0x00000B10
	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x31A8E10", Offset = "0x31A7410", VA = "0x1831A8E10")]
	public bool HasValidContainerEquipped(out int outItemId)
	{
		return default(bool);
	}

	// Token: 0x060001EA RID: 490 RVA: 0x00002928 File Offset: 0x00000B28
	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x31A91C0", Offset = "0x31A77C0", VA = "0x1831A91C0")]
	public bool TrySetActive(bool setActive)
	{
		return default(bool);
	}

	// Token: 0x060001EB RID: 491 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x31A9200", Offset = "0x31A7800", VA = "0x1831A9200", Slot = "4")]
	public virtual void GrabEnter()
	{
	}

	// Token: 0x060001EC RID: 492 RVA: 0x00002940 File Offset: 0x00000B40
	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x31A9220", Offset = "0x31A7820", VA = "0x1831A9220")]
	private static bool CanInteract()
	{
		return default(bool);
	}

	// Token: 0x060001ED RID: 493 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x268E470", Offset = "0x268CA70", VA = "0x18268E470")]
	private void GrabStay()
	{
	}

	// Token: 0x060001EE RID: 494 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x31A9290", Offset = "0x31A7890", VA = "0x1831A9290", Slot = "5")]
	public virtual void GrabExit()
	{
	}

	// Token: 0x060001EF RID: 495 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x31A92A0", Offset = "0x31A78A0", VA = "0x1831A92A0")]
	public void EnableIcons(bool enable)
	{
	}

	// Token: 0x060001F0 RID: 496 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x31A95D0", Offset = "0x31A7BD0", VA = "0x1831A95D0")]
	public void TriggerStatEffects()
	{
	}

	// Token: 0x060001F1 RID: 497 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x31A9650", Offset = "0x31A7C50", VA = "0x1831A9650")]
	public void UpdatePosition(Vector3 newPosition)
	{
	}

	// Token: 0x060001F2 RID: 498 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x31A99F0", Offset = "0x31A7FF0", VA = "0x1831A99F0")]
	public InteractableWaterNode()
	{
	}

	// Token: 0x040001EC RID: 492
	[Token(Token = "0x40001EC")]
	private const string ScreenTakeAndUseUiElementId = "screen.use";

	// Token: 0x040001ED RID: 493
	[Token(Token = "0x40001ED")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[ItemIdPicker(true)]
	private List<int> _validContainers;

	// Token: 0x040001EE RID: 494
	[Token(Token = "0x40001EE")]
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("_sheen")]
	[SerializeField]
	private GameObject _drinkIcon;

	// Token: 0x040001EF RID: 495
	[Token(Token = "0x40001EF")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[FormerlySerializedAs("_refillContainerUi")]
	[FormerlySerializedAs("_refillIcon")]
	private GameObject _refillFlaskIcon;

	// Token: 0x040001F0 RID: 496
	[Token(Token = "0x40001F0")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject _refillPotIcon;

	// Token: 0x040001F1 RID: 497
	[Token(Token = "0x40001F1")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private StatRecipe _statRecipe;

	// Token: 0x040001F2 RID: 498
	[Token(Token = "0x40001F2")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private bool _animateOnly;

	// Token: 0x040001F3 RID: 499
	[Token(Token = "0x40001F3")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private float _positionSmoothTime;

	// Token: 0x040001F4 RID: 500
	[Token(Token = "0x40001F4")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private float _smoothDampMaxSpeed;

	// Token: 0x040001F5 RID: 501
	[Token(Token = "0x40001F5")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	private float _positionJumpDistance;

	// Token: 0x040001F6 RID: 502
	[Token(Token = "0x40001F6")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private float _positionIgnoreDistance;

	// Token: 0x040001F7 RID: 503
	[Token(Token = "0x40001F7")]
	[FieldOffset(Offset = "0x5C")]
	private bool _isActive;

	// Token: 0x040001F8 RID: 504
	[Token(Token = "0x40001F8")]
	[FieldOffset(Offset = "0x60")]
	public Action OnInteractionEvent;

	// Token: 0x040001F9 RID: 505
	[Token(Token = "0x40001F9")]
	[FieldOffset(Offset = "0x68")]
	public Action OnTakeEvent;

	// Token: 0x040001FA RID: 506
	[Token(Token = "0x40001FA")]
	[FieldOffset(Offset = "0x70")]
	public Action OnUseEvent;

	// Token: 0x040001FB RID: 507
	[Token(Token = "0x40001FB")]
	[FieldOffset(Offset = "0x78")]
	private Vector3 _smoothDampVelocity;

	// Token: 0x040001FC RID: 508
	[Token(Token = "0x40001FC")]
	[FieldOffset(Offset = "0x84")]
	private float _distanceToNode;
}
