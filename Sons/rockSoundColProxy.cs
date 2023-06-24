using System;
using FMODUnity;
using Il2CppDummyDll;
using TheForest.Utils.Physics;
using UnityEngine;

// Token: 0x0200015E RID: 350
[Token(Token = "0x200015E")]
public class rockSoundColProxy : MonoBehaviour, IOnCollisionEnterProxy
{
	// Token: 0x06000AA4 RID: 2724 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AA4")]
	[Address(RVA = "0x36B98E0", Offset = "0x36B7EE0", VA = "0x1836B98E0")]
	private void Awake()
	{
	}

	// Token: 0x06000AA5 RID: 2725 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AA5")]
	[Address(RVA = "0x36B99D0", Offset = "0x36B7FD0", VA = "0x1836B99D0")]
	private void Start()
	{
	}

	// Token: 0x06000AA6 RID: 2726 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AA6")]
	[Address(RVA = "0x36B9B60", Offset = "0x36B8160", VA = "0x1836B9B60")]
	private void PlayEvent(string path)
	{
	}

	// Token: 0x06000AA7 RID: 2727 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AA7")]
	[Address(RVA = "0x36B9F80", Offset = "0x36B8580", VA = "0x1836B9F80", Slot = "4")]
	public void OnCollisionEnterProxied(Collision collision)
	{
	}

	// Token: 0x17000153 RID: 339
	// (get) Token: 0x06000AA8 RID: 2728 RVA: 0x00004B18 File Offset: 0x00002D18
	[Token(Token = "0x17000153")]
	private bool InWater
	{
		[Token(Token = "0x6000AA8")]
		[Address(RVA = "0x36BA520", Offset = "0x36B8B20", VA = "0x1836BA520")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000AA9 RID: 2729 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AA9")]
	[Address(RVA = "0x36BA530", Offset = "0x36B8B30", VA = "0x1836BA530")]
	public void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06000AAA RID: 2730 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AAA")]
	[Address(RVA = "0x36BAA60", Offset = "0x36B9060", VA = "0x1836BAA60")]
	public void OnTriggerExit(Collider other)
	{
	}

	// Token: 0x06000AAB RID: 2731 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AAB")]
	[Address(RVA = "0x36B0100", Offset = "0x36AE700", VA = "0x1836B0100")]
	private void disableEffectDelay()
	{
	}

	// Token: 0x06000AAC RID: 2732 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AAC")]
	[Address(RVA = "0x36B93C0", Offset = "0x36B79C0", VA = "0x1836B93C0")]
	public rockSoundColProxy()
	{
	}

	// Token: 0x040008FE RID: 2302
	[Token(Token = "0x40008FE")]
	[FieldOffset(Offset = "0x20")]
	public float maximumSpeed;

	// Token: 0x040008FF RID: 2303
	[Token(Token = "0x40008FF")]
	[FieldOffset(Offset = "0x24")]
	public float speedThreshold;

	// Token: 0x04000900 RID: 2304
	[Token(Token = "0x4000900")]
	[FieldOffset(Offset = "0x28")]
	[EventRef]
	public string rockOnTree;

	// Token: 0x04000901 RID: 2305
	[Token(Token = "0x4000901")]
	[FieldOffset(Offset = "0x30")]
	[EventRef]
	public string rockBush;

	// Token: 0x04000902 RID: 2306
	[Token(Token = "0x4000902")]
	[FieldOffset(Offset = "0x38")]
	[EventRef]
	public string rockWater;

	// Token: 0x04000903 RID: 2307
	[Token(Token = "0x4000903")]
	[FieldOffset(Offset = "0x40")]
	[EventRef]
	public string rockOnGround;

	// Token: 0x04000904 RID: 2308
	[Token(Token = "0x4000904")]
	[FieldOffset(Offset = "0x48")]
	[EventRef]
	public string stickHitTree;

	// Token: 0x04000905 RID: 2309
	[Token(Token = "0x4000905")]
	[FieldOffset(Offset = "0x50")]
	public GameObject waterSplashGo;

	// Token: 0x04000906 RID: 2310
	[Token(Token = "0x4000906")]
	[FieldOffset(Offset = "0x58")]
	private Transform spawnedSound;

	// Token: 0x04000907 RID: 2311
	[Token(Token = "0x4000907")]
	[FieldOffset(Offset = "0x60")]
	private int waterLayer;

	// Token: 0x04000908 RID: 2312
	[Token(Token = "0x4000908")]
	[FieldOffset(Offset = "0x64")]
	private bool effectDelay;

	// Token: 0x04000909 RID: 2313
	[Token(Token = "0x4000909")]
	[FieldOffset(Offset = "0x68")]
	public Rigidbody rigidBody;

	// Token: 0x0400090A RID: 2314
	[Token(Token = "0x400090A")]
	[FieldOffset(Offset = "0x70")]
	private int inWaterCount;
}
