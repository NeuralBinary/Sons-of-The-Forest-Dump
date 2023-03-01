using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002BE RID: 702
[Token(Token = "0x20002BE")]
public class VRShowTutorials : MonoBehaviour
{
	// Token: 0x0600120A RID: 4618 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600120A")]
	[Address(RVA = "0x2B8AC50", Offset = "0x2B89C50", VA = "0x182B8AC50")]
	private void Awake()
	{
	}

	// Token: 0x0600120B RID: 4619 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600120B")]
	[Address(RVA = "0x2B8B1D0", Offset = "0x2B8A1D0", VA = "0x182B8B1D0")]
	private void Update()
	{
	}

	// Token: 0x0600120C RID: 4620 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600120C")]
	[Address(RVA = "0x2B8B030", Offset = "0x2B8A030", VA = "0x182B8B030")]
	private void RefreshVisibility()
	{
	}

	// Token: 0x0600120D RID: 4621 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600120D")]
	[Address(RVA = "0x2B8ACD0", Offset = "0x2B89CD0", VA = "0x182B8ACD0")]
	private void RefreshHudCamVisibility()
	{
	}

	// Token: 0x0600120E RID: 4622 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600120E")]
	[Address(RVA = "0x2B8AEC0", Offset = "0x2B89EC0", VA = "0x182B8AEC0")]
	private void RefreshTutCamVisibility()
	{
	}

	// Token: 0x0600120F RID: 4623 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600120F")]
	[Address(RVA = "0x2B8B130", Offset = "0x2B8A130", VA = "0x182B8B130")]
	private void UpdateAlpha()
	{
	}

	// Token: 0x06001210 RID: 4624 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001210")]
	[Address(RVA = "0x2B8B640", Offset = "0x2B8A640", VA = "0x182B8B640")]
	public VRShowTutorials()
	{
	}

	// Token: 0x040011F5 RID: 4597
	[Token(Token = "0x40011F5")]
	[FieldOffset(Offset = "0x20")]
	public float _distanceToCam;

	// Token: 0x040011F6 RID: 4598
	[Token(Token = "0x40011F6")]
	[FieldOffset(Offset = "0x24")]
	public float _dotMin;

	// Token: 0x040011F7 RID: 4599
	[Token(Token = "0x40011F7")]
	[FieldOffset(Offset = "0x28")]
	public float _dotMax;

	// Token: 0x040011F8 RID: 4600
	[Token(Token = "0x40011F8")]
	[FieldOffset(Offset = "0x2C")]
	public float _timeInViewToShow;

	// Token: 0x040011F9 RID: 4601
	[Token(Token = "0x40011F9")]
	[FieldOffset(Offset = "0x30")]
	public float _timeInViewToShowHud;

	// Token: 0x040011FA RID: 4602
	[Token(Token = "0x40011FA")]
	[FieldOffset(Offset = "0x34")]
	public float _fadeDuration;

	// Token: 0x040011FB RID: 4603
	[Token(Token = "0x40011FB")]
	[FieldOffset(Offset = "0x38")]
	public Renderer _renderer;

	// Token: 0x040011FC RID: 4604
	[Token(Token = "0x40011FC")]
	[FieldOffset(Offset = "0x40")]
	public GameObject _powerOffGo;

	// Token: 0x040011FD RID: 4605
	[Token(Token = "0x40011FD")]
	[FieldOffset(Offset = "0x48")]
	public GameObject _hudGo;

	// Token: 0x040011FE RID: 4606
	[Token(Token = "0x40011FE")]
	[FieldOffset(Offset = "0x50")]
	private bool _visible;

	// Token: 0x040011FF RID: 4607
	[Token(Token = "0x40011FF")]
	[FieldOffset(Offset = "0x54")]
	private float _timeInView;

	// Token: 0x04001200 RID: 4608
	[Token(Token = "0x4001200")]
	[FieldOffset(Offset = "0x58")]
	private float _alpha;

	// Token: 0x04001201 RID: 4609
	[Token(Token = "0x4001201")]
	[FieldOffset(Offset = "0x60")]
	private MaterialPropertyBlock _materialProp;
}
