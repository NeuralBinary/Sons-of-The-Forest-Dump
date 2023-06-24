using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200015C RID: 348
[Token(Token = "0x200015C")]
public class rockSound : MonoBehaviour
{
	// Token: 0x17000152 RID: 338
	// (get) Token: 0x06000A90 RID: 2704 RVA: 0x00004B00 File Offset: 0x00002D00
	[Token(Token = "0x17000152")]
	private bool InWater
	{
		[Token(Token = "0x6000A90")]
		[Address(RVA = "0x2486D60", Offset = "0x2485360", VA = "0x182486D60")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000A91 RID: 2705 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A91")]
	[Address(RVA = "0x36B7940", Offset = "0x36B5F40", VA = "0x1836B7940")]
	private void Awake()
	{
	}

	// Token: 0x06000A92 RID: 2706 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A92")]
	[Address(RVA = "0x36B7A60", Offset = "0x36B6060", VA = "0x1836B7A60")]
	private void Start()
	{
	}

	// Token: 0x06000A93 RID: 2707 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A93")]
	[Address(RVA = "0x36B7BF0", Offset = "0x36B61F0", VA = "0x1836B7BF0")]
	private void OnDisable()
	{
	}

	// Token: 0x06000A94 RID: 2708 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A94")]
	[Address(RVA = "0x36B7BF0", Offset = "0x36B61F0", VA = "0x1836B7BF0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000A95 RID: 2709 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A95")]
	[Address(RVA = "0x36B7C00", Offset = "0x36B6200", VA = "0x1836B7C00")]
	public void OnCollisionEnter(Collision collision)
	{
	}

	// Token: 0x06000A96 RID: 2710 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A96")]
	[Address(RVA = "0x36B81E0", Offset = "0x36B67E0", VA = "0x1836B81E0")]
	public void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06000A97 RID: 2711 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A97")]
	[Address(RVA = "0x36B8770", Offset = "0x36B6D70", VA = "0x1836B8770")]
	public void OnTriggerExit(Collider other)
	{
	}

	// Token: 0x06000A98 RID: 2712 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A98")]
	[Address(RVA = "0x36B8830", Offset = "0x36B6E30", VA = "0x1836B8830")]
	private void disableSoundDelay()
	{
	}

	// Token: 0x06000A99 RID: 2713 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A99")]
	[Address(RVA = "0x36B8840", Offset = "0x36B6E40", VA = "0x1836B8840")]
	private void PlayEvent(string path)
	{
	}

	// Token: 0x06000A9A RID: 2714 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A9A")]
	[Address(RVA = "0x36B8C60", Offset = "0x36B7260", VA = "0x1836B8C60")]
	private void calculateDamage(GameObject go)
	{
	}

	// Token: 0x06000A9B RID: 2715 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A9B")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void enableSound()
	{
	}

	// Token: 0x06000A9C RID: 2716 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A9C")]
	[Address(RVA = "0x36B9270", Offset = "0x36B7870", VA = "0x1836B9270")]
	private void disableSound()
	{
	}

	// Token: 0x06000A9D RID: 2717 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A9D")]
	[Address(RVA = "0x36B93B0", Offset = "0x36B79B0", VA = "0x1836B93B0")]
	private void disableEffectDelay()
	{
	}

	// Token: 0x06000A9E RID: 2718 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A9E")]
	[Address(RVA = "0x36B93C0", Offset = "0x36B79C0", VA = "0x1836B93C0")]
	public rockSound()
	{
	}

	// Token: 0x040008E9 RID: 2281
	[Token(Token = "0x40008E9")]
	[FieldOffset(Offset = "0x20")]
	public float maximumSpeed;

	// Token: 0x040008EA RID: 2282
	[Token(Token = "0x40008EA")]
	[FieldOffset(Offset = "0x24")]
	public float speedThreshold;

	// Token: 0x040008EB RID: 2283
	[Token(Token = "0x40008EB")]
	[FieldOffset(Offset = "0x28")]
	public string rockOnTree;

	// Token: 0x040008EC RID: 2284
	[Token(Token = "0x40008EC")]
	[FieldOffset(Offset = "0x30")]
	public string rockBush;

	// Token: 0x040008ED RID: 2285
	[Token(Token = "0x40008ED")]
	[FieldOffset(Offset = "0x38")]
	public string rockWater;

	// Token: 0x040008EE RID: 2286
	[Token(Token = "0x40008EE")]
	[FieldOffset(Offset = "0x40")]
	public string rockOnGround;

	// Token: 0x040008EF RID: 2287
	[Token(Token = "0x40008EF")]
	[FieldOffset(Offset = "0x48")]
	public string stickHitTree;

	// Token: 0x040008F0 RID: 2288
	[Token(Token = "0x40008F0")]
	[FieldOffset(Offset = "0x50")]
	public GameObject soundDetect;

	// Token: 0x040008F1 RID: 2289
	[Token(Token = "0x40008F1")]
	[FieldOffset(Offset = "0x58")]
	public GameObject waterSplashGo;

	// Token: 0x040008F2 RID: 2290
	[Token(Token = "0x40008F2")]
	[FieldOffset(Offset = "0x60")]
	public float soundRange;

	// Token: 0x040008F3 RID: 2291
	[Token(Token = "0x40008F3")]
	[FieldOffset(Offset = "0x68")]
	public Rigidbody rigidBody;

	// Token: 0x040008F4 RID: 2292
	[Token(Token = "0x40008F4")]
	[FieldOffset(Offset = "0x70")]
	public bool allowDamage;

	// Token: 0x040008F5 RID: 2293
	[Token(Token = "0x40008F5")]
	[FieldOffset(Offset = "0x71")]
	public bool flintLock;

	// Token: 0x040008F6 RID: 2294
	[Token(Token = "0x40008F6")]
	[FieldOffset(Offset = "0x72")]
	public bool slingShot;

	// Token: 0x040008F7 RID: 2295
	[Token(Token = "0x40008F7")]
	[FieldOffset(Offset = "0x73")]
	private bool effectDelay;

	// Token: 0x040008F8 RID: 2296
	[Token(Token = "0x40008F8")]
	[FieldOffset(Offset = "0x74")]
	private int inWaterCount;

	// Token: 0x040008F9 RID: 2297
	[Token(Token = "0x40008F9")]
	[FieldOffset(Offset = "0x78")]
	private bool soundDelay;

	// Token: 0x040008FA RID: 2298
	[Token(Token = "0x40008FA")]
	[FieldOffset(Offset = "0x80")]
	private GameObject soundGo;

	// Token: 0x040008FB RID: 2299
	[Token(Token = "0x40008FB")]
	[FieldOffset(Offset = "0x88")]
	private Transform spawnedSound;

	// Token: 0x040008FC RID: 2300
	[Token(Token = "0x40008FC")]
	[FieldOffset(Offset = "0x90")]
	private int waterLayer;
}
