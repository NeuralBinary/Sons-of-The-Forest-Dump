using System;
using Il2CppDummyDll;
using TheForest.UI;
using UnityEngine;

// Token: 0x020002A0 RID: 672
[Token(Token = "0x20002A0")]
public class VRButtonAction : MonoBehaviour
{
	// Token: 0x17000212 RID: 530
	// (get) Token: 0x060011EA RID: 4586 RVA: 0x00006528 File Offset: 0x00004728
	// (set) Token: 0x060011EB RID: 4587 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000212")]
	public bool ButtonActive
	{
		[Token(Token = "0x60011EA")]
		[Address(RVA = "0x9ABDB0", Offset = "0x9AA3B0", VA = "0x1809ABDB0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60011EB")]
		[Address(RVA = "0x2586730", Offset = "0x2584D30", VA = "0x182586730")]
		set
		{
		}
	}

	// Token: 0x060011EC RID: 4588 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011EC")]
	[Address(RVA = "0x31D1020", Offset = "0x31CF620", VA = "0x1831D1020")]
	private void Awake()
	{
	}

	// Token: 0x060011ED RID: 4589 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011ED")]
	[Address(RVA = "0x31D1240", Offset = "0x31CF840", VA = "0x1831D1240")]
	private void LateUpdate()
	{
	}

	// Token: 0x060011EE RID: 4590 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011EE")]
	[Address(RVA = "0x31D1370", Offset = "0x31CF970", VA = "0x1831D1370")]
	private void UpdateFill()
	{
	}

	// Token: 0x060011EF RID: 4591 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011EF")]
	[Address(RVA = "0x31D1730", Offset = "0x31CFD30", VA = "0x1831D1730")]
	private void OnDestroy()
	{
	}

	// Token: 0x060011F0 RID: 4592 RVA: 0x00006540 File Offset: 0x00004740
	[Token(Token = "0x60011F0")]
	[Address(RVA = "0x31D1980", Offset = "0x31CFF80", VA = "0x1831D1980")]
	public bool IsType(string buttonType)
	{
		return default(bool);
	}

	// Token: 0x060011F1 RID: 4593 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011F1")]
	[Address(RVA = "0x13428C0", Offset = "0x1340EC0", VA = "0x1813428C0")]
	public void SetFillLink(DelayedAction delayedAction)
	{
	}

	// Token: 0x060011F2 RID: 4594 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011F2")]
	[Address(RVA = "0x31D1A20", Offset = "0x31D0020", VA = "0x1831D1A20")]
	public void SetUseFillSprite(bool useFillSprite)
	{
	}

	// Token: 0x060011F3 RID: 4595 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011F3")]
	[Address(RVA = "0x31D1A30", Offset = "0x31D0030", VA = "0x1831D1A30")]
	public void SetText(string text, bool showBacking = false)
	{
	}

	// Token: 0x060011F4 RID: 4596 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011F4")]
	[Address(RVA = "0x31D1C30", Offset = "0x31D0230", VA = "0x1831D1C30")]
	public void SetIcon(Texture2D sourceTexture)
	{
	}

	// Token: 0x060011F5 RID: 4597 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011F5")]
	[Address(RVA = "0x31D1FD0", Offset = "0x31D05D0", VA = "0x1831D1FD0")]
	public void SetSideIcon(Texture2D sourceTexture)
	{
	}

	// Token: 0x060011F6 RID: 4598 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011F6")]
	[Address(RVA = "0x31D22E0", Offset = "0x31D08E0", VA = "0x1831D22E0")]
	public void SetInactive()
	{
	}

	// Token: 0x060011F7 RID: 4599 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011F7")]
	[Address(RVA = "0x31D2460", Offset = "0x31D0A60", VA = "0x1831D2460")]
	public void RevertIcon()
	{
	}

	// Token: 0x060011F8 RID: 4600 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011F8")]
	[Address(RVA = "0x31D2540", Offset = "0x31D0B40", VA = "0x1831D2540")]
	private void UpdateTransition(VRButtonAction.VRButtonState idleState, VRButtonAction.VRButtonState transitionState, Vector3 localScale, float speed)
	{
	}

	// Token: 0x060011F9 RID: 4601 RVA: 0x00006558 File Offset: 0x00004758
	[Token(Token = "0x60011F9")]
	[Address(RVA = "0x31D2750", Offset = "0x31D0D50", VA = "0x1831D2750")]
	private bool ShouldIdle()
	{
		return default(bool);
	}

	// Token: 0x060011FA RID: 4602 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011FA")]
	[Address(RVA = "0x31D27B0", Offset = "0x31D0DB0", VA = "0x1831D27B0")]
	private void ApplyTransforms(Vector3 targetLocalScale, float speed)
	{
	}

	// Token: 0x060011FB RID: 4603 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011FB")]
	[Address(RVA = "0x31D2C60", Offset = "0x31D1260", VA = "0x1831D2C60")]
	public VRButtonAction()
	{
	}

	// Token: 0x040011AE RID: 4526
	[Token(Token = "0x40011AE")]
	[FieldOffset(Offset = "0x20")]
	public string[] ButtonTypes;

	// Token: 0x040011AF RID: 4527
	[Token(Token = "0x40011AF")]
	[FieldOffset(Offset = "0x28")]
	public GameObject Pivot;

	// Token: 0x040011B0 RID: 4528
	[Token(Token = "0x40011B0")]
	[FieldOffset(Offset = "0x30")]
	public TextMesh Text;

	// Token: 0x040011B1 RID: 4529
	[Token(Token = "0x40011B1")]
	[FieldOffset(Offset = "0x38")]
	public GameObject TextBacking;

	// Token: 0x040011B2 RID: 4530
	[Token(Token = "0x40011B2")]
	[FieldOffset(Offset = "0x40")]
	public Renderer Icon;

	// Token: 0x040011B3 RID: 4531
	[Token(Token = "0x40011B3")]
	[FieldOffset(Offset = "0x48")]
	public Renderer SideIcon;

	// Token: 0x040011B4 RID: 4532
	[Token(Token = "0x40011B4")]
	[FieldOffset(Offset = "0x50")]
	public float ActiveSpeed;

	// Token: 0x040011B5 RID: 4533
	[Token(Token = "0x40011B5")]
	[FieldOffset(Offset = "0x58")]
	public GameObject FillParent;

	// Token: 0x040011B6 RID: 4534
	[Token(Token = "0x40011B6")]
	[FieldOffset(Offset = "0x60")]
	public Renderer FillRenderer;

	// Token: 0x040011B7 RID: 4535
	[Token(Token = "0x40011B7")]
	[FieldOffset(Offset = "0x68")]
	public float InactiveSpeed;

	// Token: 0x040011B8 RID: 4536
	[Token(Token = "0x40011B8")]
	[FieldOffset(Offset = "0x6C")]
	public Vector3 InactiveScale;

	// Token: 0x040011B9 RID: 4537
	[Token(Token = "0x40011B9")]
	[FieldOffset(Offset = "0x78")]
	public float IdleAfter;

	// Token: 0x040011BA RID: 4538
	[Token(Token = "0x40011BA")]
	[FieldOffset(Offset = "0x7C")]
	public float FillAmount;

	// Token: 0x040011BB RID: 4539
	[Token(Token = "0x40011BB")]
	[FieldOffset(Offset = "0x80")]
	private bool _buttonActive;

	// Token: 0x040011BC RID: 4540
	[Token(Token = "0x40011BC")]
	[FieldOffset(Offset = "0x84")]
	private float _transitionStarted;

	// Token: 0x040011BD RID: 4541
	[Token(Token = "0x40011BD")]
	[FieldOffset(Offset = "0x88")]
	private VRButtonAction.VRButtonState _state;

	// Token: 0x040011BE RID: 4542
	[Token(Token = "0x40011BE")]
	[FieldOffset(Offset = "0x8C")]
	private Vector3 _basePos;

	// Token: 0x040011BF RID: 4543
	[Token(Token = "0x40011BF")]
	[FieldOffset(Offset = "0x98")]
	private Texture2D _iconDefault;

	// Token: 0x040011C0 RID: 4544
	[Token(Token = "0x40011C0")]
	[FieldOffset(Offset = "0xA0")]
	private Material _iconMaterialInstance;

	// Token: 0x040011C1 RID: 4545
	[Token(Token = "0x40011C1")]
	[FieldOffset(Offset = "0xA8")]
	private DelayedAction _delayedAction;

	// Token: 0x040011C2 RID: 4546
	[Token(Token = "0x40011C2")]
	[FieldOffset(Offset = "0xB0")]
	private Material _sideIconMaterialInstance;

	// Token: 0x040011C3 RID: 4547
	[Token(Token = "0x40011C3")]
	[FieldOffset(Offset = "0xB8")]
	private Material _fillMaterial;

	// Token: 0x040011C4 RID: 4548
	[Token(Token = "0x40011C4")]
	[FieldOffset(Offset = "0xC0")]
	private bool _useFillSprite;

	// Token: 0x020002A1 RID: 673
	[Token(Token = "0x20002A1")]
	internal enum VRButtonState
	{
		// Token: 0x040011C6 RID: 4550
		[Token(Token = "0x40011C6")]
		IdleActive,
		// Token: 0x040011C7 RID: 4551
		[Token(Token = "0x40011C7")]
		Activating,
		// Token: 0x040011C8 RID: 4552
		[Token(Token = "0x40011C8")]
		IdleInactive,
		// Token: 0x040011C9 RID: 4553
		[Token(Token = "0x40011C9")]
		Inactivating
	}
}
