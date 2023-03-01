using System;
using Il2CppDummyDll;
using TheForest.UI;
using UnityEngine;

// Token: 0x020002AC RID: 684
[Token(Token = "0x20002AC")]
public class VRButtonAction : MonoBehaviour
{
	// Token: 0x17000209 RID: 521
	// (get) Token: 0x060011B5 RID: 4533 RVA: 0x000062A0 File Offset: 0x000044A0
	// (set) Token: 0x060011B6 RID: 4534 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000209")]
	public bool ButtonActive
	{
		[Token(Token = "0x60011B5")]
		[Address(RVA = "0x20452A0", Offset = "0x20442A0", VA = "0x1820452A0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60011B6")]
		[Address(RVA = "0x2180920", Offset = "0x217F920", VA = "0x182180920")]
		set
		{
		}
	}

	// Token: 0x060011B7 RID: 4535 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011B7")]
	[Address(RVA = "0x2B87DC0", Offset = "0x2B86DC0", VA = "0x182B87DC0")]
	private void Awake()
	{
	}

	// Token: 0x060011B8 RID: 4536 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011B8")]
	[Address(RVA = "0x2B87F10", Offset = "0x2B86F10", VA = "0x182B87F10")]
	private void LateUpdate()
	{
	}

	// Token: 0x060011B9 RID: 4537 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011B9")]
	[Address(RVA = "0x2B88630", Offset = "0x2B87630", VA = "0x182B88630")]
	private void UpdateFill()
	{
	}

	// Token: 0x060011BA RID: 4538 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011BA")]
	[Address(RVA = "0x2B88000", Offset = "0x2B87000", VA = "0x182B88000")]
	private void OnDestroy()
	{
	}

	// Token: 0x060011BB RID: 4539 RVA: 0x000062B8 File Offset: 0x000044B8
	[Token(Token = "0x60011BB")]
	[Address(RVA = "0x2B87E90", Offset = "0x2B86E90", VA = "0x182B87E90")]
	public bool IsType(string buttonType)
	{
		return default(bool);
	}

	// Token: 0x060011BC RID: 4540 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011BC")]
	[Address(RVA = "0x1145D90", Offset = "0x1144D90", VA = "0x181145D90")]
	public void SetFillLink(DelayedAction delayedAction)
	{
	}

	// Token: 0x060011BD RID: 4541 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011BD")]
	[Address(RVA = "0x2B885F0", Offset = "0x2B875F0", VA = "0x182B885F0")]
	public void SetUseFillSprite(bool useFillSprite)
	{
	}

	// Token: 0x060011BE RID: 4542 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011BE")]
	[Address(RVA = "0x2B88500", Offset = "0x2B87500", VA = "0x182B88500")]
	public void SetText(string text, bool showBacking = false)
	{
	}

	// Token: 0x060011BF RID: 4543 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011BF")]
	[Address(RVA = "0x2B881A0", Offset = "0x2B871A0", VA = "0x182B881A0")]
	public void SetIcon(Texture2D sourceTexture)
	{
	}

	// Token: 0x060011C0 RID: 4544 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011C0")]
	[Address(RVA = "0x2B883E0", Offset = "0x2B873E0", VA = "0x182B883E0")]
	public void SetSideIcon(Texture2D sourceTexture)
	{
	}

	// Token: 0x060011C1 RID: 4545 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011C1")]
	[Address(RVA = "0x2B88320", Offset = "0x2B87320", VA = "0x182B88320")]
	public void SetInactive()
	{
	}

	// Token: 0x060011C2 RID: 4546 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011C2")]
	[Address(RVA = "0x2B88110", Offset = "0x2B87110", VA = "0x182B88110")]
	public void RevertIcon()
	{
	}

	// Token: 0x060011C3 RID: 4547 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011C3")]
	[Address(RVA = "0x2B88870", Offset = "0x2B87870", VA = "0x182B88870")]
	private void UpdateTransition(VRButtonAction.VRButtonState idleState, VRButtonAction.VRButtonState transitionState, Vector3 localScale, float speed)
	{
	}

	// Token: 0x060011C4 RID: 4548 RVA: 0x000062D0 File Offset: 0x000044D0
	[Token(Token = "0x60011C4")]
	[Address(RVA = "0x2B88600", Offset = "0x2B87600", VA = "0x182B88600")]
	private bool ShouldIdle()
	{
		return default(bool);
	}

	// Token: 0x060011C5 RID: 4549 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011C5")]
	[Address(RVA = "0x2B87BF0", Offset = "0x2B86BF0", VA = "0x182B87BF0")]
	private void ApplyTransforms(Vector3 targetLocalScale, float speed)
	{
	}

	// Token: 0x060011C6 RID: 4550 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011C6")]
	[Address(RVA = "0x2B88B00", Offset = "0x2B87B00", VA = "0x182B88B00")]
	public VRButtonAction()
	{
	}

	// Token: 0x04001187 RID: 4487
	[Token(Token = "0x4001187")]
	[FieldOffset(Offset = "0x20")]
	public string[] ButtonTypes;

	// Token: 0x04001188 RID: 4488
	[Token(Token = "0x4001188")]
	[FieldOffset(Offset = "0x28")]
	public GameObject Pivot;

	// Token: 0x04001189 RID: 4489
	[Token(Token = "0x4001189")]
	[FieldOffset(Offset = "0x30")]
	public TextMesh Text;

	// Token: 0x0400118A RID: 4490
	[Token(Token = "0x400118A")]
	[FieldOffset(Offset = "0x38")]
	public GameObject TextBacking;

	// Token: 0x0400118B RID: 4491
	[Token(Token = "0x400118B")]
	[FieldOffset(Offset = "0x40")]
	public Renderer Icon;

	// Token: 0x0400118C RID: 4492
	[Token(Token = "0x400118C")]
	[FieldOffset(Offset = "0x48")]
	public Renderer SideIcon;

	// Token: 0x0400118D RID: 4493
	[Token(Token = "0x400118D")]
	[FieldOffset(Offset = "0x50")]
	public float ActiveSpeed;

	// Token: 0x0400118E RID: 4494
	[Token(Token = "0x400118E")]
	[FieldOffset(Offset = "0x58")]
	public GameObject FillParent;

	// Token: 0x0400118F RID: 4495
	[Token(Token = "0x400118F")]
	[FieldOffset(Offset = "0x60")]
	public Renderer FillRenderer;

	// Token: 0x04001190 RID: 4496
	[Token(Token = "0x4001190")]
	[FieldOffset(Offset = "0x68")]
	public float InactiveSpeed;

	// Token: 0x04001191 RID: 4497
	[Token(Token = "0x4001191")]
	[FieldOffset(Offset = "0x6C")]
	public Vector3 InactiveScale;

	// Token: 0x04001192 RID: 4498
	[Token(Token = "0x4001192")]
	[FieldOffset(Offset = "0x78")]
	public float IdleAfter;

	// Token: 0x04001193 RID: 4499
	[Token(Token = "0x4001193")]
	[FieldOffset(Offset = "0x7C")]
	public float FillAmount;

	// Token: 0x04001194 RID: 4500
	[Token(Token = "0x4001194")]
	[FieldOffset(Offset = "0x80")]
	private bool _buttonActive;

	// Token: 0x04001195 RID: 4501
	[Token(Token = "0x4001195")]
	[FieldOffset(Offset = "0x84")]
	private float _transitionStarted;

	// Token: 0x04001196 RID: 4502
	[Token(Token = "0x4001196")]
	[FieldOffset(Offset = "0x88")]
	private VRButtonAction.VRButtonState _state;

	// Token: 0x04001197 RID: 4503
	[Token(Token = "0x4001197")]
	[FieldOffset(Offset = "0x8C")]
	private Vector3 _basePos;

	// Token: 0x04001198 RID: 4504
	[Token(Token = "0x4001198")]
	[FieldOffset(Offset = "0x98")]
	private Texture2D _iconDefault;

	// Token: 0x04001199 RID: 4505
	[Token(Token = "0x4001199")]
	[FieldOffset(Offset = "0xA0")]
	private Material _iconMaterialInstance;

	// Token: 0x0400119A RID: 4506
	[Token(Token = "0x400119A")]
	[FieldOffset(Offset = "0xA8")]
	private DelayedAction _delayedAction;

	// Token: 0x0400119B RID: 4507
	[Token(Token = "0x400119B")]
	[FieldOffset(Offset = "0xB0")]
	private Material _sideIconMaterialInstance;

	// Token: 0x0400119C RID: 4508
	[Token(Token = "0x400119C")]
	[FieldOffset(Offset = "0xB8")]
	private Material _fillMaterial;

	// Token: 0x0400119D RID: 4509
	[Token(Token = "0x400119D")]
	[FieldOffset(Offset = "0xC0")]
	private bool _useFillSprite;

	// Token: 0x020002AD RID: 685
	[Token(Token = "0x20002AD")]
	internal enum VRButtonState
	{
		// Token: 0x0400119F RID: 4511
		[Token(Token = "0x400119F")]
		IdleActive,
		// Token: 0x040011A0 RID: 4512
		[Token(Token = "0x40011A0")]
		Activating,
		// Token: 0x040011A1 RID: 4513
		[Token(Token = "0x40011A1")]
		IdleInactive,
		// Token: 0x040011A2 RID: 4514
		[Token(Token = "0x40011A2")]
		Inactivating
	}
}
