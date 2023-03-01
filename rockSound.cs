using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200015D RID: 349
[Token(Token = "0x200015D")]
public class rockSound : MonoBehaviour
{
	// Token: 0x17000149 RID: 329
	// (get) Token: 0x06000A40 RID: 2624 RVA: 0x000048F0 File Offset: 0x00002AF0
	[Token(Token = "0x17000149")]
	private bool InWater
	{
		[Token(Token = "0x6000A40")]
		[Address(RVA = "0x20BB6D0", Offset = "0x20BA6D0", VA = "0x1820BB6D0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000A41 RID: 2625 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A41")]
	[Address(RVA = "0x2F5DBD0", Offset = "0x2F5CBD0", VA = "0x182F5DBD0")]
	private void Awake()
	{
	}

	// Token: 0x06000A42 RID: 2626 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A42")]
	[Address(RVA = "0x2F5E710", Offset = "0x2F5D710", VA = "0x182F5E710")]
	private void Start()
	{
	}

	// Token: 0x06000A43 RID: 2627 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A43")]
	[Address(RVA = "0x2F5E060", Offset = "0x2F5D060", VA = "0x182F5E060")]
	private void OnDisable()
	{
	}

	// Token: 0x06000A44 RID: 2628 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A44")]
	[Address(RVA = "0x2F5E060", Offset = "0x2F5D060", VA = "0x182F5E060")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000A45 RID: 2629 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A45")]
	[Address(RVA = "0x2F5DC70", Offset = "0x2F5CC70", VA = "0x182F5DC70")]
	public void OnCollisionEnter(Collision collision)
	{
	}

	// Token: 0x06000A46 RID: 2630 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A46")]
	[Address(RVA = "0x2F5E070", Offset = "0x2F5D070", VA = "0x182F5E070")]
	public void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06000A47 RID: 2631 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A47")]
	[Address(RVA = "0x2F5E390", Offset = "0x2F5D390", VA = "0x182F5E390")]
	public void OnTriggerExit(Collider other)
	{
	}

	// Token: 0x06000A48 RID: 2632 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A48")]
	[Address(RVA = "0x27E6920", Offset = "0x27E5920", VA = "0x1827E6920")]
	private void disableSoundDelay()
	{
	}

	// Token: 0x06000A49 RID: 2633 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A49")]
	[Address(RVA = "0x2F5E3E0", Offset = "0x2F5D3E0", VA = "0x182F5E3E0")]
	private void PlayEvent(string path)
	{
	}

	// Token: 0x06000A4A RID: 2634 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A4A")]
	[Address(RVA = "0x2F5E7C0", Offset = "0x2F5D7C0", VA = "0x182F5E7C0")]
	private void calculateDamage(GameObject go)
	{
	}

	// Token: 0x06000A4B RID: 2635 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A4B")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	private void enableSound()
	{
	}

	// Token: 0x06000A4C RID: 2636 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A4C")]
	[Address(RVA = "0x2F5ED20", Offset = "0x2F5DD20", VA = "0x182F5ED20")]
	private void disableSound()
	{
	}

	// Token: 0x06000A4D RID: 2637 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A4D")]
	[Address(RVA = "0x2F5ED10", Offset = "0x2F5DD10", VA = "0x182F5ED10")]
	private void disableEffectDelay()
	{
	}

	// Token: 0x06000A4E RID: 2638 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A4E")]
	[Address(RVA = "0x2F5DBA0", Offset = "0x2F5CBA0", VA = "0x182F5DBA0")]
	public rockSound()
	{
	}

	// Token: 0x040008C8 RID: 2248
	[Token(Token = "0x40008C8")]
	[FieldOffset(Offset = "0x20")]
	public float maximumSpeed;

	// Token: 0x040008C9 RID: 2249
	[Token(Token = "0x40008C9")]
	[FieldOffset(Offset = "0x24")]
	public float speedThreshold;

	// Token: 0x040008CA RID: 2250
	[Token(Token = "0x40008CA")]
	[FieldOffset(Offset = "0x28")]
	public string rockOnTree;

	// Token: 0x040008CB RID: 2251
	[Token(Token = "0x40008CB")]
	[FieldOffset(Offset = "0x30")]
	public string rockBush;

	// Token: 0x040008CC RID: 2252
	[Token(Token = "0x40008CC")]
	[FieldOffset(Offset = "0x38")]
	public string rockWater;

	// Token: 0x040008CD RID: 2253
	[Token(Token = "0x40008CD")]
	[FieldOffset(Offset = "0x40")]
	public string rockOnGround;

	// Token: 0x040008CE RID: 2254
	[Token(Token = "0x40008CE")]
	[FieldOffset(Offset = "0x48")]
	public string stickHitTree;

	// Token: 0x040008CF RID: 2255
	[Token(Token = "0x40008CF")]
	[FieldOffset(Offset = "0x50")]
	public GameObject soundDetect;

	// Token: 0x040008D0 RID: 2256
	[Token(Token = "0x40008D0")]
	[FieldOffset(Offset = "0x58")]
	public GameObject waterSplashGo;

	// Token: 0x040008D1 RID: 2257
	[Token(Token = "0x40008D1")]
	[FieldOffset(Offset = "0x60")]
	public float soundRange;

	// Token: 0x040008D2 RID: 2258
	[Token(Token = "0x40008D2")]
	[FieldOffset(Offset = "0x68")]
	public Rigidbody rigidBody;

	// Token: 0x040008D3 RID: 2259
	[Token(Token = "0x40008D3")]
	[FieldOffset(Offset = "0x70")]
	public bool allowDamage;

	// Token: 0x040008D4 RID: 2260
	[Token(Token = "0x40008D4")]
	[FieldOffset(Offset = "0x71")]
	public bool flintLock;

	// Token: 0x040008D5 RID: 2261
	[Token(Token = "0x40008D5")]
	[FieldOffset(Offset = "0x72")]
	public bool slingShot;

	// Token: 0x040008D6 RID: 2262
	[Token(Token = "0x40008D6")]
	[FieldOffset(Offset = "0x73")]
	private bool effectDelay;

	// Token: 0x040008D7 RID: 2263
	[Token(Token = "0x40008D7")]
	[FieldOffset(Offset = "0x74")]
	private int inWaterCount;

	// Token: 0x040008D8 RID: 2264
	[Token(Token = "0x40008D8")]
	[FieldOffset(Offset = "0x78")]
	private bool soundDelay;

	// Token: 0x040008D9 RID: 2265
	[Token(Token = "0x40008D9")]
	[FieldOffset(Offset = "0x80")]
	private GameObject soundGo;

	// Token: 0x040008DA RID: 2266
	[Token(Token = "0x40008DA")]
	[FieldOffset(Offset = "0x88")]
	private Transform spawnedSound;

	// Token: 0x040008DB RID: 2267
	[Token(Token = "0x40008DB")]
	[FieldOffset(Offset = "0x90")]
	private int waterLayer;
}
