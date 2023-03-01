using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000179 RID: 377
[Token(Token = "0x2000179")]
[AddComponentMenu("TheForest/FX/Snow Dust Controller")]
public class snowDustController : MonoBehaviour
{
	// Token: 0x06000B17 RID: 2839 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B17")]
	[Address(RVA = "0x2F61600", Offset = "0x2F60600", VA = "0x182F61600")]
	private void Start()
	{
	}

	// Token: 0x06000B18 RID: 2840 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B18")]
	[Address(RVA = "0x2F616B0", Offset = "0x2F606B0", VA = "0x182F616B0")]
	private void Update()
	{
	}

	// Token: 0x06000B19 RID: 2841 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B19")]
	[Address(RVA = "0x2F62030", Offset = "0x2F61030", VA = "0x182F62030")]
	private void spawnWorms()
	{
	}

	// Token: 0x06000B1A RID: 2842 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B1A")]
	[Address(RVA = "0x2F619D0", Offset = "0x2F609D0", VA = "0x182F619D0")]
	private void spawnParticleAroundPlayer()
	{
	}

	// Token: 0x06000B1B RID: 2843 RVA: 0x00004B48 File Offset: 0x00002D48
	[Token(Token = "0x6000B1B")]
	[Address(RVA = "0x2F614F0", Offset = "0x2F604F0", VA = "0x182F614F0")]
	private Vector2 Circle2(float radius)
	{
		return default(Vector2);
	}

	// Token: 0x06000B1C RID: 2844 RVA: 0x00004B60 File Offset: 0x00002D60
	[Token(Token = "0x6000B1C")]
	[Address(RVA = "0x2F61770", Offset = "0x2F60770", VA = "0x182F61770")]
	private bool checkKillMask(Vector3 pos)
	{
		return default(bool);
	}

	// Token: 0x06000B1D RID: 2845 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B1D")]
	[Address(RVA = "0x2F61730", Offset = "0x2F60730", VA = "0x182F61730")]
	public snowDustController()
	{
	}

	// Token: 0x040009D6 RID: 2518
	[Token(Token = "0x40009D6")]
	[FieldOffset(Offset = "0x20")]
	public GameObject snowParticle;

	// Token: 0x040009D7 RID: 2519
	[Token(Token = "0x40009D7")]
	[FieldOffset(Offset = "0x28")]
	public GameObject snowParticleSlow;

	// Token: 0x040009D8 RID: 2520
	[Token(Token = "0x40009D8")]
	[FieldOffset(Offset = "0x30")]
	public GameObject forestFluffParticle;

	// Token: 0x040009D9 RID: 2521
	[Token(Token = "0x40009D9")]
	[FieldOffset(Offset = "0x38")]
	public GameObject lightningBugsParticle;

	// Token: 0x040009DA RID: 2522
	[Token(Token = "0x40009DA")]
	[FieldOffset(Offset = "0x40")]
	public GameObject wormsParticle;

	// Token: 0x040009DB RID: 2523
	[Token(Token = "0x40009DB")]
	[FieldOffset(Offset = "0x48")]
	public float minRange;

	// Token: 0x040009DC RID: 2524
	[Token(Token = "0x40009DC")]
	[FieldOffset(Offset = "0x4C")]
	public float maxRange;

	// Token: 0x040009DD RID: 2525
	[Token(Token = "0x40009DD")]
	[FieldOffset(Offset = "0x50")]
	public float updateRate;

	// Token: 0x040009DE RID: 2526
	[Token(Token = "0x40009DE")]
	[FieldOffset(Offset = "0x54")]
	public float fluffUpdateRate;

	// Token: 0x040009DF RID: 2527
	[Token(Token = "0x40009DF")]
	[FieldOffset(Offset = "0x58")]
	public float lightningBugsUpdateRate;

	// Token: 0x040009E0 RID: 2528
	[Token(Token = "0x40009E0")]
	[FieldOffset(Offset = "0x5C")]
	public float wormsUpdateRate;

	// Token: 0x040009E1 RID: 2529
	[Token(Token = "0x40009E1")]
	[FieldOffset(Offset = "0x60")]
	public int[] TerrainTextureMask;

	// Token: 0x040009E2 RID: 2530
	[Token(Token = "0x40009E2")]
	[FieldOffset(Offset = "0x68")]
	public int[] wormsTerrainTextureMask;

	// Token: 0x040009E3 RID: 2531
	[Token(Token = "0x40009E3")]
	[FieldOffset(Offset = "0x70")]
	private float nextUpdateDelay;

	// Token: 0x040009E4 RID: 2532
	[Token(Token = "0x40009E4")]
	[FieldOffset(Offset = "0x74")]
	private float fluffNextUpdateDelay;

	// Token: 0x040009E5 RID: 2533
	[Token(Token = "0x40009E5")]
	[FieldOffset(Offset = "0x78")]
	private float lightningBugsNextUpdateDelay;

	// Token: 0x040009E6 RID: 2534
	[Token(Token = "0x40009E6")]
	[FieldOffset(Offset = "0x7C")]
	private float wormsNextUpdateDelay;

	// Token: 0x040009E7 RID: 2535
	[Token(Token = "0x40009E7")]
	[FieldOffset(Offset = "0x80")]
	private float snowStartHeight;
}
