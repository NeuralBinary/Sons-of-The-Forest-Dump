using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000209 RID: 521
[Token(Token = "0x2000209")]
public class Investigate : MonoBehaviour
{
	// Token: 0x06000E53 RID: 3667 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E53")]
	[Address(RVA = "0x37177F0", Offset = "0x3715DF0", VA = "0x1837177F0")]
	private void Update()
	{
	}

	// Token: 0x06000E54 RID: 3668 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E54")]
	[Address(RVA = "0x3717AC0", Offset = "0x37160C0", VA = "0x183717AC0")]
	public Investigate()
	{
	}

	// Token: 0x04000D47 RID: 3399
	[Token(Token = "0x4000D47")]
	[FieldOffset(Offset = "0x20")]
	[NonSerialized]
	public float InvestigationAmount;

	// Token: 0x04000D48 RID: 3400
	[Token(Token = "0x4000D48")]
	[FieldOffset(Offset = "0x24")]
	[Range(1f, 10f)]
	public float InvestigateDelay;

	// Token: 0x04000D49 RID: 3401
	[Token(Token = "0x4000D49")]
	[FieldOffset(Offset = "0x28")]
	[Range(0f, 0.25f)]
	public float MotionTollerance;

	// Token: 0x04000D4A RID: 3402
	[Token(Token = "0x4000D4A")]
	[FieldOffset(Offset = "0x2C")]
	[Range(1f, 10f)]
	public float TransitionSpeed;

	// Token: 0x04000D4B RID: 3403
	[Token(Token = "0x4000D4B")]
	[FieldOffset(Offset = "0x30")]
	private float timer;

	// Token: 0x04000D4C RID: 3404
	[Token(Token = "0x4000D4C")]
	[FieldOffset(Offset = "0x34")]
	private Vector3 lastPosition;
}
