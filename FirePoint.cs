using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000192 RID: 402
[Token(Token = "0x2000192")]
public class FirePoint : MonoBehaviour
{
	// Token: 0x06000BB9 RID: 3001 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BB9")]
	[Address(RVA = "0x2F643A0", Offset = "0x2F633A0", VA = "0x182F643A0")]
	private void Start()
	{
	}

	// Token: 0x06000BBA RID: 3002 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BBA")]
	[Address(RVA = "0x2F64390", Offset = "0x2F63390", VA = "0x182F64390")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000BBB RID: 3003 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BBB")]
	[Address(RVA = "0x2F64380", Offset = "0x2F63380", VA = "0x182F64380")]
	private void Burn()
	{
	}

	// Token: 0x06000BBC RID: 3004 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BBC")]
	[Address(RVA = "0x2F643B0", Offset = "0x2F633B0", VA = "0x182F643B0")]
	private void Update()
	{
	}

	// Token: 0x06000BBD RID: 3005 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BBD")]
	[Address(RVA = "0x2F64BA0", Offset = "0x2F63BA0", VA = "0x182F64BA0")]
	public void startFire()
	{
	}

	// Token: 0x06000BBE RID: 3006 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BBE")]
	[Address(RVA = "0x2F64720", Offset = "0x2F63720", VA = "0x182F64720")]
	public void endFire()
	{
	}

	// Token: 0x06000BBF RID: 3007 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BBF")]
	[Address(RVA = "0x2F642C0", Offset = "0x2F632C0", VA = "0x182F642C0")]
	public void Awake()
	{
	}

	// Token: 0x06000BC0 RID: 3008 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BC0")]
	[Address(RVA = "0x2F64B30", Offset = "0x2F63B30", VA = "0x182F64B30")]
	public IEnumerator spreadFire()
	{
		return null;
	}

	// Token: 0x06000BC1 RID: 3009 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BC1")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	public void fallOut()
	{
	}

	// Token: 0x06000BC2 RID: 3010 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BC2")]
	[Address(RVA = "0x2F64AC0", Offset = "0x2F63AC0", VA = "0x182F64AC0")]
	public IEnumerator setWind()
	{
		return null;
	}

	// Token: 0x06000BC3 RID: 3011 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BC3")]
	[Address(RVA = "0x2F646A0", Offset = "0x2F636A0", VA = "0x182F646A0")]
	public FirePoint()
	{
	}

	// Token: 0x04000A75 RID: 2677
	[Token(Token = "0x4000A75")]
	[FieldOffset(Offset = "0x20")]
	public Transform fireParticle;

	// Token: 0x04000A76 RID: 2678
	[Token(Token = "0x4000A76")]
	[FieldOffset(Offset = "0x28")]
	public Transform[] firePoints;

	// Token: 0x04000A77 RID: 2679
	[Token(Token = "0x4000A77")]
	[FieldOffset(Offset = "0x30")]
	public float startingFuel;

	// Token: 0x04000A78 RID: 2680
	[Token(Token = "0x4000A78")]
	[FieldOffset(Offset = "0x34")]
	public float fuel;

	// Token: 0x04000A79 RID: 2681
	[Token(Token = "0x4000A79")]
	[FieldOffset(Offset = "0x38")]
	public float fuelConsumption;

	// Token: 0x04000A7A RID: 2682
	[Token(Token = "0x4000A7A")]
	[FieldOffset(Offset = "0x3C")]
	public float fireSpread;

	// Token: 0x04000A7B RID: 2683
	[Token(Token = "0x4000A7B")]
	[FieldOffset(Offset = "0x40")]
	public float spreadTime;

	// Token: 0x04000A7C RID: 2684
	[Token(Token = "0x4000A7C")]
	[FieldOffset(Offset = "0x44")]
	public float randomRange;

	// Token: 0x04000A7D RID: 2685
	[Token(Token = "0x4000A7D")]
	[FieldOffset(Offset = "0x48")]
	public float fallOutC;

	// Token: 0x04000A7E RID: 2686
	[Token(Token = "0x4000A7E")]
	[FieldOffset(Offset = "0x4C")]
	private bool fireStarted;

	// Token: 0x04000A7F RID: 2687
	[Token(Token = "0x4000A7F")]
	[FieldOffset(Offset = "0x50")]
	private Transform[] fireC;

	// Token: 0x04000A80 RID: 2688
	[Token(Token = "0x4000A80")]
	[FieldOffset(Offset = "0x58")]
	private int count;

	// Token: 0x04000A81 RID: 2689
	[Token(Token = "0x4000A81")]
	[FieldOffset(Offset = "0x5C")]
	private float fTime;

	// Token: 0x04000A82 RID: 2690
	[Token(Token = "0x4000A82")]
	[FieldOffset(Offset = "0x60")]
	private bool fSpread;

	// Token: 0x04000A83 RID: 2691
	[Token(Token = "0x4000A83")]
	[FieldOffset(Offset = "0x61")]
	private bool fellOut;

	// Token: 0x04000A84 RID: 2692
	[Token(Token = "0x4000A84")]
	[FieldOffset(Offset = "0x62")]
	private bool bColor;

	// Token: 0x04000A85 RID: 2693
	[Token(Token = "0x4000A85")]
	[FieldOffset(Offset = "0x64")]
	private Vector3 spPos;
}
