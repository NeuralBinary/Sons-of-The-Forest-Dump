using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001EF RID: 495
[Token(Token = "0x20001EF")]
public class EffectorSway : MonoBehaviour
{
	// Token: 0x06000E02 RID: 3586 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E02")]
	[Address(RVA = "0x37105A0", Offset = "0x370EBA0", VA = "0x1837105A0")]
	private void Start()
	{
	}

	// Token: 0x06000E03 RID: 3587 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E03")]
	[Address(RVA = "0x3710670", Offset = "0x370EC70", VA = "0x183710670")]
	private void Update()
	{
	}

	// Token: 0x06000E04 RID: 3588 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E04")]
	[Address(RVA = "0x3710990", Offset = "0x370EF90", VA = "0x183710990")]
	public EffectorSway()
	{
	}

	// Token: 0x04000CF9 RID: 3321
	[Token(Token = "0x4000CF9")]
	[FieldOffset(Offset = "0x20")]
	private float time;

	// Token: 0x04000CFA RID: 3322
	[Token(Token = "0x4000CFA")]
	[FieldOffset(Offset = "0x24")]
	private Vector3 initialPosition;

	// Token: 0x04000CFB RID: 3323
	[Token(Token = "0x4000CFB")]
	[FieldOffset(Offset = "0x30")]
	private float direction;

	// Token: 0x04000CFC RID: 3324
	[Token(Token = "0x4000CFC")]
	[FieldOffset(Offset = "0x34")]
	public float travel;

	// Token: 0x04000CFD RID: 3325
	[Token(Token = "0x4000CFD")]
	[FieldOffset(Offset = "0x38")]
	public float period;
}
