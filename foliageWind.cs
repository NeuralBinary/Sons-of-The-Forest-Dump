using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001FB RID: 507
[Token(Token = "0x20001FB")]
public class foliageWind : MonoBehaviour
{
	// Token: 0x06000DCF RID: 3535 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DCF")]
	[Address(RVA = "0x2F91210", Offset = "0x2F90210", VA = "0x182F91210")]
	private void Awake()
	{
	}

	// Token: 0x06000DD0 RID: 3536 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DD0")]
	[Address(RVA = "0x2F91320", Offset = "0x2F90320", VA = "0x182F91320")]
	private void Update()
	{
	}

	// Token: 0x06000DD1 RID: 3537 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DD1")]
	[Address(RVA = "0x2F912B0", Offset = "0x2F902B0", VA = "0x182F912B0")]
	private void ChangeWindAmount()
	{
	}

	// Token: 0x06000DD2 RID: 3538 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DD2")]
	[Address(RVA = "0x2F913A0", Offset = "0x2F903A0", VA = "0x182F913A0")]
	public foliageWind()
	{
	}

	// Token: 0x04000CE8 RID: 3304
	[Token(Token = "0x4000CE8")]
	[FieldOffset(Offset = "0x20")]
	public Vector4 Wind;

	// Token: 0x04000CE9 RID: 3305
	[Token(Token = "0x4000CE9")]
	[FieldOffset(Offset = "0x30")]
	private float WaveSizeFoliageShader;

	// Token: 0x04000CEA RID: 3306
	[Token(Token = "0x4000CEA")]
	[FieldOffset(Offset = "0x34")]
	private float WindRandomAmt;

	// Token: 0x04000CEB RID: 3307
	[Token(Token = "0x4000CEB")]
	[FieldOffset(Offset = "0x38")]
	private float WindForce;
}
