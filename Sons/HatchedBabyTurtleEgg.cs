using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000044 RID: 68
[Token(Token = "0x2000044")]
public class HatchedBabyTurtleEgg : MonoBehaviour
{
	// Token: 0x060001D7 RID: 471 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x31A7710", Offset = "0x31A5D10", VA = "0x1831A7710")]
	private void Start()
	{
	}

	// Token: 0x060001D8 RID: 472 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x31A7A40", Offset = "0x31A6040", VA = "0x1831A7A40")]
	private void LateUpdate()
	{
	}

	// Token: 0x060001D9 RID: 473 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x31A7A60", Offset = "0x31A6060", VA = "0x1831A7A60")]
	private void Crawl()
	{
	}

	// Token: 0x060001DA RID: 474 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x31A7F00", Offset = "0x31A6500", VA = "0x1831A7F00")]
	private void Swim()
	{
	}

	// Token: 0x060001DB RID: 475 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x31A8230", Offset = "0x31A6830", VA = "0x1831A8230")]
	public void SetLayersTo(int layer)
	{
	}

	// Token: 0x060001DC RID: 476 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x31A8380", Offset = "0x31A6980", VA = "0x1831A8380")]
	public HatchedBabyTurtleEgg()
	{
	}

	// Token: 0x040001E4 RID: 484
	[Token(Token = "0x40001E4")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject _egg;

	// Token: 0x040001E5 RID: 485
	[Token(Token = "0x40001E5")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject _turtle;

	// Token: 0x040001E6 RID: 486
	[Token(Token = "0x40001E6")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Animator _turtleAnimator;

	// Token: 0x040001E7 RID: 487
	[Token(Token = "0x40001E7")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float _underWaterDepth;

	// Token: 0x040001E8 RID: 488
	[Token(Token = "0x40001E8")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float _beginCrawlAfterXSeconds;

	// Token: 0x040001E9 RID: 489
	[Token(Token = "0x40001E9")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float _destroyAfterSwimmingForXSeconds;

	// Token: 0x040001EA RID: 490
	[Token(Token = "0x40001EA")]
	[FieldOffset(Offset = "0x44")]
	private bool _isUnderWater;

	// Token: 0x040001EB RID: 491
	[Token(Token = "0x40001EB")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int SwimAnimParamHash;
}
