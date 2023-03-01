using System;
using System.Collections.Generic;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

// Token: 0x02000044 RID: 68
[Token(Token = "0x2000044")]
public class InteractableWaterNode : MonoBehaviour
{
	// Token: 0x060001C9 RID: 457 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x244EE00", Offset = "0x244DE00", VA = "0x18244EE00")]
	public void SetDistanceToNode(float distance)
	{
	}

	// Token: 0x060001CA RID: 458 RVA: 0x000028B0 File Offset: 0x00000AB0
	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x200F4C0", Offset = "0x200E4C0", VA = "0x18200F4C0")]
	public float GetDistanceToNode()
	{
		return default(float);
	}

	// Token: 0x060001CB RID: 459 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x692A50", Offset = "0x691A50", VA = "0x180692A50")]
	public void SetRecipe(StatRecipe recipe)
	{
	}

	// Token: 0x060001CC RID: 460 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x52F1A0", Offset = "0x52E1A0", VA = "0x18052F1A0")]
	public StatRecipe GetRecipe()
	{
		return null;
	}

	// Token: 0x060001CD RID: 461 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x29A98F0", Offset = "0x29A88F0", VA = "0x1829A98F0")]
	private void Update()
	{
	}

	// Token: 0x060001CE RID: 462 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x29A90B0", Offset = "0x29A80B0", VA = "0x1829A90B0")]
	private void OnEnable()
	{
	}

	// Token: 0x060001CF RID: 463 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x29A8EF0", Offset = "0x29A7EF0", VA = "0x1829A8EF0")]
	private void OnDisable()
	{
	}

	// Token: 0x060001D0 RID: 464 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x29A9470", Offset = "0x29A8470", VA = "0x1829A9470")]
	private void SetupLinkUi()
	{
	}

	// Token: 0x060001D1 RID: 465 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x29A9330", Offset = "0x29A8330", VA = "0x1829A9330")]
	private void OnTakeAction(InputAction.CallbackContext obj)
	{
	}

	// Token: 0x060001D2 RID: 466 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x29A9350", Offset = "0x29A8350", VA = "0x1829A9350")]
	private void OnUseAction(InputAction.CallbackContext obj)
	{
	}

	// Token: 0x060001D3 RID: 467 RVA: 0x000028C8 File Offset: 0x00000AC8
	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x29A8D10", Offset = "0x29A7D10", VA = "0x1829A8D10")]
	public bool HasValidContainerEquipped()
	{
		return default(bool);
	}

	// Token: 0x060001D4 RID: 468 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x29A8CF0", Offset = "0x29A7CF0", VA = "0x1829A8CF0", Slot = "4")]
	public virtual void GrabEnter()
	{
	}

	// Token: 0x060001D5 RID: 469 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x29A8D00", Offset = "0x29A7D00", VA = "0x1829A8D00", Slot = "5")]
	public virtual void GrabExit()
	{
	}

	// Token: 0x060001D6 RID: 470 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x29A8C00", Offset = "0x29A7C00", VA = "0x1829A8C00")]
	public void EnableIcons(bool enable)
	{
	}

	// Token: 0x060001D7 RID: 471 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x29A9530", Offset = "0x29A8530", VA = "0x1829A9530")]
	public void TriggerStatEffects()
	{
	}

	// Token: 0x060001D8 RID: 472 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x29A96E0", Offset = "0x29A86E0", VA = "0x1829A96E0")]
	public void UpdatePosition(Vector3 newPosition)
	{
	}

	// Token: 0x060001D9 RID: 473 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x29A99E0", Offset = "0x29A89E0", VA = "0x1829A99E0")]
	public InteractableWaterNode()
	{
	}

	// Token: 0x040001BD RID: 445
	[Token(Token = "0x40001BD")]
	private const string ScreenTakeAndUseUiElementId = "screen.use";

	// Token: 0x040001BE RID: 446
	[Token(Token = "0x40001BE")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[ItemIdPicker(true)]
	private List<int> _validContainers;

	// Token: 0x040001BF RID: 447
	[Token(Token = "0x40001BF")]
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("_sheen")]
	[SerializeField]
	private GameObject _drinkIcon;

	// Token: 0x040001C0 RID: 448
	[Token(Token = "0x40001C0")]
	[FieldOffset(Offset = "0x30")]
	[FormerlySerializedAs("_refillContainerUi")]
	[SerializeField]
	private GameObject _refillIcon;

	// Token: 0x040001C1 RID: 449
	[Token(Token = "0x40001C1")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[EventRef]
	[HideInInspector]
	private string _drinkAudio;

	// Token: 0x040001C2 RID: 450
	[Token(Token = "0x40001C2")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private StatRecipe _statRecipe;

	// Token: 0x040001C3 RID: 451
	[Token(Token = "0x40001C3")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private bool _animateOnly;

	// Token: 0x040001C4 RID: 452
	[Token(Token = "0x40001C4")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private float _positionSmoothTime;

	// Token: 0x040001C5 RID: 453
	[Token(Token = "0x40001C5")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private float _smoothDampMaxSpeed;

	// Token: 0x040001C6 RID: 454
	[Token(Token = "0x40001C6")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	private float _positionJumpDistance;

	// Token: 0x040001C7 RID: 455
	[Token(Token = "0x40001C7")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private float _positionIgnoreDistance;

	// Token: 0x040001C8 RID: 456
	[Token(Token = "0x40001C8")]
	[FieldOffset(Offset = "0x5C")]
	private bool _isActive;

	// Token: 0x040001C9 RID: 457
	[Token(Token = "0x40001C9")]
	[FieldOffset(Offset = "0x60")]
	public Action OnInteractionEvent;

	// Token: 0x040001CA RID: 458
	[Token(Token = "0x40001CA")]
	[FieldOffset(Offset = "0x68")]
	public Action OnTakeEvent;

	// Token: 0x040001CB RID: 459
	[Token(Token = "0x40001CB")]
	[FieldOffset(Offset = "0x70")]
	public Action OnUseEvent;

	// Token: 0x040001CC RID: 460
	[Token(Token = "0x40001CC")]
	[FieldOffset(Offset = "0x78")]
	private Vector3 _smoothDampVelocity;

	// Token: 0x040001CD RID: 461
	[Token(Token = "0x40001CD")]
	[FieldOffset(Offset = "0x84")]
	private float _distanceToNode;
}
