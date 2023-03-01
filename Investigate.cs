using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200020A RID: 522
[Token(Token = "0x200020A")]
public class Investigate : MonoBehaviour
{
	// Token: 0x06000DF8 RID: 3576 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DF8")]
	[Address(RVA = "0x2F8EA80", Offset = "0x2F8DA80", VA = "0x182F8EA80")]
	private void Update()
	{
	}

	// Token: 0x06000DF9 RID: 3577 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DF9")]
	[Address(RVA = "0x2F8EC60", Offset = "0x2F8DC60", VA = "0x182F8EC60")]
	public Investigate()
	{
	}

	// Token: 0x04000D18 RID: 3352
	[Token(Token = "0x4000D18")]
	[FieldOffset(Offset = "0x20")]
	[NonSerialized]
	public float InvestigationAmount;

	// Token: 0x04000D19 RID: 3353
	[Token(Token = "0x4000D19")]
	[FieldOffset(Offset = "0x24")]
	[Range(1f, 10f)]
	public float InvestigateDelay;

	// Token: 0x04000D1A RID: 3354
	[Token(Token = "0x4000D1A")]
	[FieldOffset(Offset = "0x28")]
	[Range(0f, 0.25f)]
	public float MotionTollerance;

	// Token: 0x04000D1B RID: 3355
	[Token(Token = "0x4000D1B")]
	[FieldOffset(Offset = "0x2C")]
	[Range(1f, 10f)]
	public float TransitionSpeed;

	// Token: 0x04000D1C RID: 3356
	[Token(Token = "0x4000D1C")]
	[FieldOffset(Offset = "0x30")]
	private float timer;

	// Token: 0x04000D1D RID: 3357
	[Token(Token = "0x4000D1D")]
	[FieldOffset(Offset = "0x34")]
	private Vector3 lastPosition;
}
