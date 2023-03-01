using System;
using FMODUnity;
using Il2CppDummyDll;
using TheForest.Utils.Physics;
using UnityEngine;

// Token: 0x0200015F RID: 351
[Token(Token = "0x200015F")]
public class rockSoundColProxy : MonoBehaviour, IOnCollisionEnterProxy
{
	// Token: 0x06000A54 RID: 2644 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A54")]
	[Address(RVA = "0x2F5D050", Offset = "0x2F5C050", VA = "0x182F5D050")]
	private void Awake()
	{
	}

	// Token: 0x06000A55 RID: 2645 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A55")]
	[Address(RVA = "0x2F5DAF0", Offset = "0x2F5CAF0", VA = "0x182F5DAF0")]
	private void Start()
	{
	}

	// Token: 0x06000A56 RID: 2646 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A56")]
	[Address(RVA = "0x2F5D7C0", Offset = "0x2F5C7C0", VA = "0x182F5D7C0")]
	private void PlayEvent(string path)
	{
	}

	// Token: 0x06000A57 RID: 2647 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A57")]
	[Address(RVA = "0x2F5D0C0", Offset = "0x2F5C0C0", VA = "0x182F5D0C0", Slot = "4")]
	public void OnCollisionEnterProxied(Collision collision)
	{
	}

	// Token: 0x1700014A RID: 330
	// (get) Token: 0x06000A58 RID: 2648 RVA: 0x00004908 File Offset: 0x00002B08
	[Token(Token = "0x1700014A")]
	private bool InWater
	{
		[Token(Token = "0x6000A58")]
		[Address(RVA = "0x2F5DBC0", Offset = "0x2F5CBC0", VA = "0x182F5DBC0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000A59 RID: 2649 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A59")]
	[Address(RVA = "0x2F5D480", Offset = "0x2F5C480", VA = "0x182F5D480")]
	public void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06000A5A RID: 2650 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A5A")]
	[Address(RVA = "0x2F5D780", Offset = "0x2F5C780", VA = "0x182F5D780")]
	public void OnTriggerExit(Collider other)
	{
	}

	// Token: 0x06000A5B RID: 2651 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A5B")]
	[Address(RVA = "0x2F5DBB0", Offset = "0x2F5CBB0", VA = "0x182F5DBB0")]
	private void disableEffectDelay()
	{
	}

	// Token: 0x06000A5C RID: 2652 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A5C")]
	[Address(RVA = "0x2F5DBA0", Offset = "0x2F5CBA0", VA = "0x182F5DBA0")]
	public rockSoundColProxy()
	{
	}

	// Token: 0x040008DD RID: 2269
	[Token(Token = "0x40008DD")]
	[FieldOffset(Offset = "0x20")]
	public float maximumSpeed;

	// Token: 0x040008DE RID: 2270
	[Token(Token = "0x40008DE")]
	[FieldOffset(Offset = "0x24")]
	public float speedThreshold;

	// Token: 0x040008DF RID: 2271
	[Token(Token = "0x40008DF")]
	[FieldOffset(Offset = "0x28")]
	[EventRef]
	public string rockOnTree;

	// Token: 0x040008E0 RID: 2272
	[Token(Token = "0x40008E0")]
	[FieldOffset(Offset = "0x30")]
	[EventRef]
	public string rockBush;

	// Token: 0x040008E1 RID: 2273
	[Token(Token = "0x40008E1")]
	[FieldOffset(Offset = "0x38")]
	[EventRef]
	public string rockWater;

	// Token: 0x040008E2 RID: 2274
	[Token(Token = "0x40008E2")]
	[FieldOffset(Offset = "0x40")]
	[EventRef]
	public string rockOnGround;

	// Token: 0x040008E3 RID: 2275
	[Token(Token = "0x40008E3")]
	[FieldOffset(Offset = "0x48")]
	[EventRef]
	public string stickHitTree;

	// Token: 0x040008E4 RID: 2276
	[Token(Token = "0x40008E4")]
	[FieldOffset(Offset = "0x50")]
	public GameObject waterSplashGo;

	// Token: 0x040008E5 RID: 2277
	[Token(Token = "0x40008E5")]
	[FieldOffset(Offset = "0x58")]
	private Transform spawnedSound;

	// Token: 0x040008E6 RID: 2278
	[Token(Token = "0x40008E6")]
	[FieldOffset(Offset = "0x60")]
	private int waterLayer;

	// Token: 0x040008E7 RID: 2279
	[Token(Token = "0x40008E7")]
	[FieldOffset(Offset = "0x64")]
	private bool effectDelay;

	// Token: 0x040008E8 RID: 2280
	[Token(Token = "0x40008E8")]
	[FieldOffset(Offset = "0x68")]
	public Rigidbody rigidBody;

	// Token: 0x040008E9 RID: 2281
	[Token(Token = "0x40008E9")]
	[FieldOffset(Offset = "0x70")]
	private int inWaterCount;
}
