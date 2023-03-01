using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000134 RID: 308
[Token(Token = "0x2000134")]
public class limitBlurDistance : MonoBehaviour
{
	// Token: 0x060008B4 RID: 2228 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008B4")]
	[Address(RVA = "0x2F493C0", Offset = "0x2F483C0", VA = "0x182F493C0")]
	private void Start()
	{
	}

	// Token: 0x060008B5 RID: 2229 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008B5")]
	[Address(RVA = "0x2F494D0", Offset = "0x2F484D0", VA = "0x182F494D0")]
	private void checkPlayerDist()
	{
	}

	// Token: 0x060008B6 RID: 2230 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008B6")]
	[Address(RVA = "0x2F499A0", Offset = "0x2F489A0", VA = "0x182F499A0")]
	private void enableRenderers()
	{
	}

	// Token: 0x060008B7 RID: 2231 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008B7")]
	[Address(RVA = "0x2F49820", Offset = "0x2F48820", VA = "0x182F49820")]
	private void disableRenderers()
	{
	}

	// Token: 0x060008B8 RID: 2232 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008B8")]
	[Address(RVA = "0x2F49AA0", Offset = "0x2F48AA0", VA = "0x182F49AA0")]
	private void reduceAnimation()
	{
	}

	// Token: 0x060008B9 RID: 2233 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008B9")]
	[Address(RVA = "0x2F49920", Offset = "0x2F48920", VA = "0x182F49920")]
	private void enableAnimation()
	{
	}

	// Token: 0x060008BA RID: 2234 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008BA")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public limitBlurDistance()
	{
	}

	// Token: 0x0400070E RID: 1806
	[Token(Token = "0x400070E")]
	[FieldOffset(Offset = "0x20")]
	public GameObject[] joints;

	// Token: 0x0400070F RID: 1807
	[Token(Token = "0x400070F")]
	[FieldOffset(Offset = "0x28")]
	public Renderer[] renderers;

	// Token: 0x04000710 RID: 1808
	[Token(Token = "0x4000710")]
	[FieldOffset(Offset = "0x30")]
	private bool doAmplify;

	// Token: 0x04000711 RID: 1809
	[Token(Token = "0x4000711")]
	[FieldOffset(Offset = "0x38")]
	private Transform thisTr;

	// Token: 0x04000712 RID: 1810
	[Token(Token = "0x4000712")]
	[FieldOffset(Offset = "0x40")]
	private float playerDist;

	// Token: 0x04000713 RID: 1811
	[Token(Token = "0x4000713")]
	[FieldOffset(Offset = "0x44")]
	public bool useParentAsSource;

	// Token: 0x04000714 RID: 1812
	[Token(Token = "0x4000714")]
	[FieldOffset(Offset = "0x45")]
	public bool hideJoints;

	// Token: 0x04000715 RID: 1813
	[Token(Token = "0x4000715")]
	[FieldOffset(Offset = "0x46")]
	public bool hideRenderers;

	// Token: 0x04000716 RID: 1814
	[Token(Token = "0x4000716")]
	[FieldOffset(Offset = "0x47")]
	private bool doJoints;

	// Token: 0x04000717 RID: 1815
	[Token(Token = "0x4000717")]
	[FieldOffset(Offset = "0x48")]
	private bool doRenderers;

	// Token: 0x04000718 RID: 1816
	[Token(Token = "0x4000718")]
	[FieldOffset(Offset = "0x4C")]
	private float rendererDist;
}
