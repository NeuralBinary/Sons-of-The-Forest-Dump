using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002B2 RID: 690
[Token(Token = "0x20002B2")]
public class VRShowTutorials : MonoBehaviour
{
	// Token: 0x0600123F RID: 4671 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600123F")]
	[Address(RVA = "0x31D6920", Offset = "0x31D4F20", VA = "0x1831D6920")]
	private void Awake()
	{
	}

	// Token: 0x06001240 RID: 4672 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001240")]
	[Address(RVA = "0x31D6A50", Offset = "0x31D5050", VA = "0x1831D6A50")]
	private void Update()
	{
	}

	// Token: 0x06001241 RID: 4673 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001241")]
	[Address(RVA = "0x31D6DB0", Offset = "0x31D53B0", VA = "0x1831D6DB0")]
	private void RefreshVisibility()
	{
	}

	// Token: 0x06001242 RID: 4674 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001242")]
	[Address(RVA = "0x31D6FA0", Offset = "0x31D55A0", VA = "0x1831D6FA0")]
	private void RefreshHudCamVisibility()
	{
	}

	// Token: 0x06001243 RID: 4675 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001243")]
	[Address(RVA = "0x31D7310", Offset = "0x31D5910", VA = "0x1831D7310")]
	private void RefreshTutCamVisibility()
	{
	}

	// Token: 0x06001244 RID: 4676 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001244")]
	[Address(RVA = "0x31D7580", Offset = "0x31D5B80", VA = "0x1831D7580")]
	private void UpdateAlpha()
	{
	}

	// Token: 0x06001245 RID: 4677 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001245")]
	[Address(RVA = "0x31D76C0", Offset = "0x31D5CC0", VA = "0x1831D76C0")]
	public VRShowTutorials()
	{
	}

	// Token: 0x0400121C RID: 4636
	[Token(Token = "0x400121C")]
	[FieldOffset(Offset = "0x20")]
	public float _distanceToCam;

	// Token: 0x0400121D RID: 4637
	[Token(Token = "0x400121D")]
	[FieldOffset(Offset = "0x24")]
	public float _dotMin;

	// Token: 0x0400121E RID: 4638
	[Token(Token = "0x400121E")]
	[FieldOffset(Offset = "0x28")]
	public float _dotMax;

	// Token: 0x0400121F RID: 4639
	[Token(Token = "0x400121F")]
	[FieldOffset(Offset = "0x2C")]
	public float _timeInViewToShow;

	// Token: 0x04001220 RID: 4640
	[Token(Token = "0x4001220")]
	[FieldOffset(Offset = "0x30")]
	public float _timeInViewToShowHud;

	// Token: 0x04001221 RID: 4641
	[Token(Token = "0x4001221")]
	[FieldOffset(Offset = "0x34")]
	public float _fadeDuration;

	// Token: 0x04001222 RID: 4642
	[Token(Token = "0x4001222")]
	[FieldOffset(Offset = "0x38")]
	public Renderer _renderer;

	// Token: 0x04001223 RID: 4643
	[Token(Token = "0x4001223")]
	[FieldOffset(Offset = "0x40")]
	public GameObject _powerOffGo;

	// Token: 0x04001224 RID: 4644
	[Token(Token = "0x4001224")]
	[FieldOffset(Offset = "0x48")]
	public GameObject _hudGo;

	// Token: 0x04001225 RID: 4645
	[Token(Token = "0x4001225")]
	[FieldOffset(Offset = "0x50")]
	private bool _visible;

	// Token: 0x04001226 RID: 4646
	[Token(Token = "0x4001226")]
	[FieldOffset(Offset = "0x54")]
	private float _timeInView;

	// Token: 0x04001227 RID: 4647
	[Token(Token = "0x4001227")]
	[FieldOffset(Offset = "0x58")]
	private float _alpha;

	// Token: 0x04001228 RID: 4648
	[Token(Token = "0x4001228")]
	[FieldOffset(Offset = "0x60")]
	private MaterialPropertyBlock _materialProp;
}
