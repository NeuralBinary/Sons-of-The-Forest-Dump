using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

// Token: 0x02000030 RID: 48
[Token(Token = "0x2000030")]
public class SunRotator : MonoBehaviour
{
	// Token: 0x060000B1 RID: 177 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x5DF100", Offset = "0x5DD700", VA = "0x1805DF100")]
	private void Start()
	{
	}

	// Token: 0x060000B2 RID: 178 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x5DF1B0", Offset = "0x5DD7B0", VA = "0x1805DF1B0")]
	private void Update()
	{
	}

	// Token: 0x060000B3 RID: 179 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x5DF4B0", Offset = "0x5DDAB0", VA = "0x1805DF4B0")]
	public SunRotator()
	{
	}

	// Token: 0x04000182 RID: 386
	[Token(Token = "0x4000182")]
	[FieldOffset(Offset = "0x20")]
	public Transform sunTrans;

	// Token: 0x04000183 RID: 387
	[Token(Token = "0x4000183")]
	[FieldOffset(Offset = "0x28")]
	public float speed;

	// Token: 0x04000184 RID: 388
	[Token(Token = "0x4000184")]
	[FieldOffset(Offset = "0x2C")]
	public float minAmbient;

	// Token: 0x04000185 RID: 389
	[Token(Token = "0x4000185")]
	[FieldOffset(Offset = "0x30")]
	public Volume m_Volume;

	// Token: 0x04000186 RID: 390
	[Token(Token = "0x4000186")]
	[FieldOffset(Offset = "0x38")]
	private IndirectLightingController _indirectLightingController;

	// Token: 0x04000187 RID: 391
	[Token(Token = "0x4000187")]
	[FieldOffset(Offset = "0x40")]
	private VolumeProfile profile;
}
