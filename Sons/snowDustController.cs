using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000178 RID: 376
[Token(Token = "0x2000178")]
[AddComponentMenu("TheForest/FX/Snow Dust Controller")]
public class snowDustController : MonoBehaviour
{
	// Token: 0x06000B70 RID: 2928 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B70")]
	[Address(RVA = "0x36CFAF0", Offset = "0x36CE0F0", VA = "0x1836CFAF0")]
	private void Start()
	{
	}

	// Token: 0x06000B71 RID: 2929 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B71")]
	[Address(RVA = "0x36CFCD0", Offset = "0x36CE2D0", VA = "0x1836CFCD0")]
	private void Update()
	{
	}

	// Token: 0x06000B72 RID: 2930 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B72")]
	[Address(RVA = "0x36CFDC0", Offset = "0x36CE3C0", VA = "0x1836CFDC0")]
	private void spawnWorms()
	{
	}

	// Token: 0x06000B73 RID: 2931 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B73")]
	[Address(RVA = "0x36D0820", Offset = "0x36CEE20", VA = "0x1836D0820")]
	private void spawnParticleAroundPlayer()
	{
	}

	// Token: 0x06000B74 RID: 2932 RVA: 0x00004D70 File Offset: 0x00002F70
	[Token(Token = "0x6000B74")]
	[Address(RVA = "0x36D1350", Offset = "0x36CF950", VA = "0x1836D1350")]
	private Vector2 Circle2(float radius)
	{
		return default(Vector2);
	}

	// Token: 0x06000B75 RID: 2933 RVA: 0x00004D88 File Offset: 0x00002F88
	[Token(Token = "0x6000B75")]
	[Address(RVA = "0x36D13F0", Offset = "0x36CF9F0", VA = "0x1836D13F0")]
	private bool checkKillMask(Vector3 pos)
	{
		return default(bool);
	}

	// Token: 0x06000B76 RID: 2934 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B76")]
	[Address(RVA = "0x36D1810", Offset = "0x36CFE10", VA = "0x1836D1810")]
	public snowDustController()
	{
	}

	// Token: 0x040009FF RID: 2559
	[Token(Token = "0x40009FF")]
	[FieldOffset(Offset = "0x20")]
	public GameObject snowParticle;

	// Token: 0x04000A00 RID: 2560
	[Token(Token = "0x4000A00")]
	[FieldOffset(Offset = "0x28")]
	public GameObject snowParticleSlow;

	// Token: 0x04000A01 RID: 2561
	[Token(Token = "0x4000A01")]
	[FieldOffset(Offset = "0x30")]
	public GameObject forestFluffParticle;

	// Token: 0x04000A02 RID: 2562
	[Token(Token = "0x4000A02")]
	[FieldOffset(Offset = "0x38")]
	public GameObject lightningBugsParticle;

	// Token: 0x04000A03 RID: 2563
	[Token(Token = "0x4000A03")]
	[FieldOffset(Offset = "0x40")]
	public GameObject wormsParticle;

	// Token: 0x04000A04 RID: 2564
	[Token(Token = "0x4000A04")]
	[FieldOffset(Offset = "0x48")]
	public float minRange;

	// Token: 0x04000A05 RID: 2565
	[Token(Token = "0x4000A05")]
	[FieldOffset(Offset = "0x4C")]
	public float maxRange;

	// Token: 0x04000A06 RID: 2566
	[Token(Token = "0x4000A06")]
	[FieldOffset(Offset = "0x50")]
	public float updateRate;

	// Token: 0x04000A07 RID: 2567
	[Token(Token = "0x4000A07")]
	[FieldOffset(Offset = "0x54")]
	public float fluffUpdateRate;

	// Token: 0x04000A08 RID: 2568
	[Token(Token = "0x4000A08")]
	[FieldOffset(Offset = "0x58")]
	public float lightningBugsUpdateRate;

	// Token: 0x04000A09 RID: 2569
	[Token(Token = "0x4000A09")]
	[FieldOffset(Offset = "0x5C")]
	public float wormsUpdateRate;

	// Token: 0x04000A0A RID: 2570
	[Token(Token = "0x4000A0A")]
	[FieldOffset(Offset = "0x60")]
	public int[] TerrainTextureMask;

	// Token: 0x04000A0B RID: 2571
	[Token(Token = "0x4000A0B")]
	[FieldOffset(Offset = "0x68")]
	public int[] wormsTerrainTextureMask;

	// Token: 0x04000A0C RID: 2572
	[Token(Token = "0x4000A0C")]
	[FieldOffset(Offset = "0x70")]
	private float nextUpdateDelay;

	// Token: 0x04000A0D RID: 2573
	[Token(Token = "0x4000A0D")]
	[FieldOffset(Offset = "0x74")]
	private float fluffNextUpdateDelay;

	// Token: 0x04000A0E RID: 2574
	[Token(Token = "0x4000A0E")]
	[FieldOffset(Offset = "0x78")]
	private float lightningBugsNextUpdateDelay;

	// Token: 0x04000A0F RID: 2575
	[Token(Token = "0x4000A0F")]
	[FieldOffset(Offset = "0x7C")]
	private float wormsNextUpdateDelay;

	// Token: 0x04000A10 RID: 2576
	[Token(Token = "0x4000A10")]
	[FieldOffset(Offset = "0x80")]
	private float snowStartHeight;
}
