using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000132 RID: 306
[Token(Token = "0x2000132")]
public class limitBlurDistance : MonoBehaviour
{
	// Token: 0x060008FC RID: 2300 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008FC")]
	[Address(RVA = "0x368EBE0", Offset = "0x368D1E0", VA = "0x18368EBE0")]
	private void Start()
	{
	}

	// Token: 0x060008FD RID: 2301 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008FD")]
	[Address(RVA = "0x368EF60", Offset = "0x368D560", VA = "0x18368EF60")]
	private void checkPlayerDist()
	{
	}

	// Token: 0x060008FE RID: 2302 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008FE")]
	[Address(RVA = "0x368F3D0", Offset = "0x368D9D0", VA = "0x18368F3D0")]
	private void enableRenderers()
	{
	}

	// Token: 0x060008FF RID: 2303 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008FF")]
	[Address(RVA = "0x368F530", Offset = "0x368DB30", VA = "0x18368F530")]
	private void disableRenderers()
	{
	}

	// Token: 0x06000900 RID: 2304 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000900")]
	[Address(RVA = "0x368F690", Offset = "0x368DC90", VA = "0x18368F690")]
	private void reduceAnimation()
	{
	}

	// Token: 0x06000901 RID: 2305 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000901")]
	[Address(RVA = "0x368F750", Offset = "0x368DD50", VA = "0x18368F750")]
	private void enableAnimation()
	{
	}

	// Token: 0x06000902 RID: 2306 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000902")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public limitBlurDistance()
	{
	}

	// Token: 0x0400072A RID: 1834
	[Token(Token = "0x400072A")]
	[FieldOffset(Offset = "0x20")]
	public GameObject[] joints;

	// Token: 0x0400072B RID: 1835
	[Token(Token = "0x400072B")]
	[FieldOffset(Offset = "0x28")]
	public Renderer[] renderers;

	// Token: 0x0400072C RID: 1836
	[Token(Token = "0x400072C")]
	[FieldOffset(Offset = "0x30")]
	private bool doAmplify;

	// Token: 0x0400072D RID: 1837
	[Token(Token = "0x400072D")]
	[FieldOffset(Offset = "0x38")]
	private Transform thisTr;

	// Token: 0x0400072E RID: 1838
	[Token(Token = "0x400072E")]
	[FieldOffset(Offset = "0x40")]
	private float playerDist;

	// Token: 0x0400072F RID: 1839
	[Token(Token = "0x400072F")]
	[FieldOffset(Offset = "0x44")]
	public bool useParentAsSource;

	// Token: 0x04000730 RID: 1840
	[Token(Token = "0x4000730")]
	[FieldOffset(Offset = "0x45")]
	public bool hideJoints;

	// Token: 0x04000731 RID: 1841
	[Token(Token = "0x4000731")]
	[FieldOffset(Offset = "0x46")]
	public bool hideRenderers;

	// Token: 0x04000732 RID: 1842
	[Token(Token = "0x4000732")]
	[FieldOffset(Offset = "0x47")]
	private bool doJoints;

	// Token: 0x04000733 RID: 1843
	[Token(Token = "0x4000733")]
	[FieldOffset(Offset = "0x48")]
	private bool doRenderers;

	// Token: 0x04000734 RID: 1844
	[Token(Token = "0x4000734")]
	[FieldOffset(Offset = "0x4C")]
	private float rendererDist;
}
