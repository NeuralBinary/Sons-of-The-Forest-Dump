using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000194 RID: 404
[Token(Token = "0x2000194")]
[Serializable]
public class MasterFire : MonoBehaviour
{
	// Token: 0x06000C2A RID: 3114 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C2A")]
	[Address(RVA = "0x7AAC00", Offset = "0x7A9200", VA = "0x1807AAC00", Slot = "4")]
	public virtual void Update()
	{
	}

	// Token: 0x06000C2B RID: 3115 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C2B")]
	[Address(RVA = "0x36E1520", Offset = "0x36DFB20", VA = "0x1836E1520", Slot = "5")]
	public virtual void startFire()
	{
	}

	// Token: 0x06000C2C RID: 3116 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C2C")]
	[Address(RVA = "0x36E1790", Offset = "0x36DFD90", VA = "0x1836E1790", Slot = "6")]
	public virtual void endFire()
	{
	}

	// Token: 0x06000C2D RID: 3117 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C2D")]
	[Address(RVA = "0x36E17E0", Offset = "0x36DFDE0", VA = "0x1836E17E0", Slot = "7")]
	public virtual void spreadFire()
	{
	}

	// Token: 0x06000C2E RID: 3118 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C2E")]
	[Address(RVA = "0x36E1B30", Offset = "0x36E0130", VA = "0x1836E1B30", Slot = "8")]
	public virtual void Start()
	{
	}

	// Token: 0x06000C2F RID: 3119 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C2F")]
	[Address(RVA = "0x36E1B50", Offset = "0x36E0150", VA = "0x1836E1B50")]
	public MasterFire()
	{
	}

	// Token: 0x04000ABA RID: 2746
	[Token(Token = "0x4000ABA")]
	[FieldOffset(Offset = "0x20")]
	public float fireSpread;

	// Token: 0x04000ABB RID: 2747
	[Token(Token = "0x4000ABB")]
	[FieldOffset(Offset = "0x28")]
	public Transform fireParticle;

	// Token: 0x04000ABC RID: 2748
	[Token(Token = "0x4000ABC")]
	[FieldOffset(Offset = "0x30")]
	public float spreadTime;

	// Token: 0x04000ABD RID: 2749
	[Token(Token = "0x4000ABD")]
	[FieldOffset(Offset = "0x34")]
	public float burnTime;

	// Token: 0x04000ABE RID: 2750
	[Token(Token = "0x4000ABE")]
	[FieldOffset(Offset = "0x38")]
	public bool burnOnStart;

	// Token: 0x04000ABF RID: 2751
	[Token(Token = "0x4000ABF")]
	[FieldOffset(Offset = "0x39")]
	private bool fireStarted;

	// Token: 0x04000AC0 RID: 2752
	[Token(Token = "0x4000AC0")]
	[FieldOffset(Offset = "0x3C")]
	private float fTime;

	// Token: 0x04000AC1 RID: 2753
	[Token(Token = "0x4000AC1")]
	[FieldOffset(Offset = "0x40")]
	private Transform burnP;

	// Token: 0x04000AC2 RID: 2754
	[Token(Token = "0x4000AC2")]
	[FieldOffset(Offset = "0x48")]
	private bool fireSp;
}
