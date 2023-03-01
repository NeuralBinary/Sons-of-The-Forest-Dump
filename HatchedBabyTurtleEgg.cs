using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000042 RID: 66
[Token(Token = "0x2000042")]
public class HatchedBabyTurtleEgg : MonoBehaviour
{
	// Token: 0x060001C1 RID: 449 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x29A8470", Offset = "0x29A7470", VA = "0x1829A8470")]
	private void Start()
	{
	}

	// Token: 0x060001C2 RID: 450 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x29A81F0", Offset = "0x29A71F0", VA = "0x1829A81F0")]
	private void LateUpdate()
	{
	}

	// Token: 0x060001C3 RID: 451 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x29A7F50", Offset = "0x29A6F50", VA = "0x1829A7F50")]
	private void Crawl()
	{
	}

	// Token: 0x060001C4 RID: 452 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x29A8610", Offset = "0x29A7610", VA = "0x1829A8610")]
	private void Swim()
	{
	}

	// Token: 0x060001C5 RID: 453 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x29A83C0", Offset = "0x29A73C0", VA = "0x1829A83C0")]
	public void SetLayersTo(int layer)
	{
	}

	// Token: 0x060001C6 RID: 454 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x29A8810", Offset = "0x29A7810", VA = "0x1829A8810")]
	public HatchedBabyTurtleEgg()
	{
	}

	// Token: 0x040001B5 RID: 437
	[Token(Token = "0x40001B5")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject _egg;

	// Token: 0x040001B6 RID: 438
	[Token(Token = "0x40001B6")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject _turtle;

	// Token: 0x040001B7 RID: 439
	[Token(Token = "0x40001B7")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Animator _turtleAnimator;

	// Token: 0x040001B8 RID: 440
	[Token(Token = "0x40001B8")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float _underWaterDepth;

	// Token: 0x040001B9 RID: 441
	[Token(Token = "0x40001B9")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float _beginCrawlAfterXSeconds;

	// Token: 0x040001BA RID: 442
	[Token(Token = "0x40001BA")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float _destroyAfterSwimmingForXSeconds;

	// Token: 0x040001BB RID: 443
	[Token(Token = "0x40001BB")]
	[FieldOffset(Offset = "0x44")]
	private bool _isUnderWater;

	// Token: 0x040001BC RID: 444
	[Token(Token = "0x40001BC")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int SwimAnimParamHash;
}
