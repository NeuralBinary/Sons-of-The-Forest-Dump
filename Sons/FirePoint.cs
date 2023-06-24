using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000191 RID: 401
[Token(Token = "0x2000191")]
public class FirePoint : MonoBehaviour
{
	// Token: 0x06000C13 RID: 3091 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C13")]
	[Address(RVA = "0x36DFA40", Offset = "0x36DE040", VA = "0x1836DFA40")]
	private void Start()
	{
	}

	// Token: 0x06000C14 RID: 3092 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C14")]
	[Address(RVA = "0x36DFA50", Offset = "0x36DE050", VA = "0x1836DFA50")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000C15 RID: 3093 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C15")]
	[Address(RVA = "0x36DFA60", Offset = "0x36DE060", VA = "0x1836DFA60")]
	private void Burn()
	{
	}

	// Token: 0x06000C16 RID: 3094 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C16")]
	[Address(RVA = "0x36DFA70", Offset = "0x36DE070", VA = "0x1836DFA70")]
	private void Update()
	{
	}

	// Token: 0x06000C17 RID: 3095 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C17")]
	[Address(RVA = "0x36DFFF0", Offset = "0x36DE5F0", VA = "0x1836DFFF0")]
	public void startFire()
	{
	}

	// Token: 0x06000C18 RID: 3096 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C18")]
	[Address(RVA = "0x36E03C0", Offset = "0x36DE9C0", VA = "0x1836E03C0")]
	public void endFire()
	{
	}

	// Token: 0x06000C19 RID: 3097 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C19")]
	[Address(RVA = "0x36E0840", Offset = "0x36DEE40", VA = "0x1836E0840")]
	public void Awake()
	{
	}

	// Token: 0x06000C1A RID: 3098 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C1A")]
	[Address(RVA = "0x36E0980", Offset = "0x36DEF80", VA = "0x1836E0980")]
	public IEnumerator spreadFire()
	{
		return null;
	}

	// Token: 0x06000C1B RID: 3099 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C1B")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	public void fallOut()
	{
	}

	// Token: 0x06000C1C RID: 3100 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C1C")]
	[Address(RVA = "0x36E0A10", Offset = "0x36DF010", VA = "0x1836E0A10")]
	public IEnumerator setWind()
	{
		return null;
	}

	// Token: 0x06000C1D RID: 3101 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C1D")]
	[Address(RVA = "0x36E0AA0", Offset = "0x36DF0A0", VA = "0x1836E0AA0")]
	public FirePoint()
	{
	}

	// Token: 0x04000AA0 RID: 2720
	[Token(Token = "0x4000AA0")]
	[FieldOffset(Offset = "0x20")]
	public Transform fireParticle;

	// Token: 0x04000AA1 RID: 2721
	[Token(Token = "0x4000AA1")]
	[FieldOffset(Offset = "0x28")]
	public Transform[] firePoints;

	// Token: 0x04000AA2 RID: 2722
	[Token(Token = "0x4000AA2")]
	[FieldOffset(Offset = "0x30")]
	public float startingFuel;

	// Token: 0x04000AA3 RID: 2723
	[Token(Token = "0x4000AA3")]
	[FieldOffset(Offset = "0x34")]
	public float fuel;

	// Token: 0x04000AA4 RID: 2724
	[Token(Token = "0x4000AA4")]
	[FieldOffset(Offset = "0x38")]
	public float fuelConsumption;

	// Token: 0x04000AA5 RID: 2725
	[Token(Token = "0x4000AA5")]
	[FieldOffset(Offset = "0x3C")]
	public float fireSpread;

	// Token: 0x04000AA6 RID: 2726
	[Token(Token = "0x4000AA6")]
	[FieldOffset(Offset = "0x40")]
	public float spreadTime;

	// Token: 0x04000AA7 RID: 2727
	[Token(Token = "0x4000AA7")]
	[FieldOffset(Offset = "0x44")]
	public float randomRange;

	// Token: 0x04000AA8 RID: 2728
	[Token(Token = "0x4000AA8")]
	[FieldOffset(Offset = "0x48")]
	public float fallOutC;

	// Token: 0x04000AA9 RID: 2729
	[Token(Token = "0x4000AA9")]
	[FieldOffset(Offset = "0x4C")]
	private bool fireStarted;

	// Token: 0x04000AAA RID: 2730
	[Token(Token = "0x4000AAA")]
	[FieldOffset(Offset = "0x50")]
	private Transform[] fireC;

	// Token: 0x04000AAB RID: 2731
	[Token(Token = "0x4000AAB")]
	[FieldOffset(Offset = "0x58")]
	private int count;

	// Token: 0x04000AAC RID: 2732
	[Token(Token = "0x4000AAC")]
	[FieldOffset(Offset = "0x5C")]
	private float fTime;

	// Token: 0x04000AAD RID: 2733
	[Token(Token = "0x4000AAD")]
	[FieldOffset(Offset = "0x60")]
	private bool fSpread;

	// Token: 0x04000AAE RID: 2734
	[Token(Token = "0x4000AAE")]
	[FieldOffset(Offset = "0x61")]
	private bool fellOut;

	// Token: 0x04000AAF RID: 2735
	[Token(Token = "0x4000AAF")]
	[FieldOffset(Offset = "0x62")]
	private bool bColor;

	// Token: 0x04000AB0 RID: 2736
	[Token(Token = "0x4000AB0")]
	[FieldOffset(Offset = "0x64")]
	private Vector3 spPos;
}
