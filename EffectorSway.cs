using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001F0 RID: 496
[Token(Token = "0x20001F0")]
public class EffectorSway : MonoBehaviour
{
	// Token: 0x06000DA7 RID: 3495 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DA7")]
	[Address(RVA = "0x2F87960", Offset = "0x2F86960", VA = "0x182F87960")]
	private void Start()
	{
	}

	// Token: 0x06000DA8 RID: 3496 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DA8")]
	[Address(RVA = "0x2F879A0", Offset = "0x2F869A0", VA = "0x182F879A0")]
	private void Update()
	{
	}

	// Token: 0x06000DA9 RID: 3497 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DA9")]
	[Address(RVA = "0x2F87B20", Offset = "0x2F86B20", VA = "0x182F87B20")]
	public EffectorSway()
	{
	}

	// Token: 0x04000CCA RID: 3274
	[Token(Token = "0x4000CCA")]
	[FieldOffset(Offset = "0x20")]
	private float time;

	// Token: 0x04000CCB RID: 3275
	[Token(Token = "0x4000CCB")]
	[FieldOffset(Offset = "0x24")]
	private Vector3 initialPosition;

	// Token: 0x04000CCC RID: 3276
	[Token(Token = "0x4000CCC")]
	[FieldOffset(Offset = "0x30")]
	private float direction;

	// Token: 0x04000CCD RID: 3277
	[Token(Token = "0x4000CCD")]
	[FieldOffset(Offset = "0x34")]
	public float travel;

	// Token: 0x04000CCE RID: 3278
	[Token(Token = "0x4000CCE")]
	[FieldOffset(Offset = "0x38")]
	public float period;
}
