using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200013B RID: 315
[Token(Token = "0x200013B")]
public class particleController : MonoBehaviour
{
	// Token: 0x060008D3 RID: 2259 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008D3")]
	[Address(RVA = "0x2F4A990", Offset = "0x2F49990", VA = "0x182F4A990")]
	private void Start()
	{
	}

	// Token: 0x060008D4 RID: 2260 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008D4")]
	[Address(RVA = "0x2F4A930", Offset = "0x2F49930", VA = "0x182F4A930")]
	private void OnEnable()
	{
	}

	// Token: 0x060008D5 RID: 2261 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008D5")]
	[Address(RVA = "0x2F4A600", Offset = "0x2F49600", VA = "0x182F4A600")]
	private void LateUpdate()
	{
	}

	// Token: 0x060008D6 RID: 2262 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008D6")]
	[Address(RVA = "0x2F4AA80", Offset = "0x2F49A80", VA = "0x182F4AA80")]
	public particleController()
	{
	}

	// Token: 0x0400072A RID: 1834
	[Token(Token = "0x400072A")]
	[FieldOffset(Offset = "0x20")]
	public bool applyLocalDrift;

	// Token: 0x0400072B RID: 1835
	[Token(Token = "0x400072B")]
	[FieldOffset(Offset = "0x24")]
	public float driftAmount;

	// Token: 0x0400072C RID: 1836
	[Token(Token = "0x400072C")]
	[FieldOffset(Offset = "0x28")]
	private Transform velocityTarget;

	// Token: 0x0400072D RID: 1837
	[Token(Token = "0x400072D")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 lastPos;

	// Token: 0x0400072E RID: 1838
	[Token(Token = "0x400072E")]
	[FieldOffset(Offset = "0x40")]
	private ParticleSystem p;

	// Token: 0x0400072F RID: 1839
	[Token(Token = "0x400072F")]
	[FieldOffset(Offset = "0x48")]
	private ParticleSystem.Particle[] particles;
}
