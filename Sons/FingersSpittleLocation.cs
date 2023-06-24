using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200000A RID: 10
[Token(Token = "0x200000A")]
public class FingersSpittleLocation : MonoBehaviour
{
	// Token: 0x06000022 RID: 34 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000022")]
	[Address(RVA = "0x2F63B60", Offset = "0x2F62160", VA = "0x182F63B60")]
	private void Start()
	{
	}

	// Token: 0x06000023 RID: 35 RVA: 0x000020A0 File Offset: 0x000002A0
	[Token(Token = "0x6000023")]
	[Address(RVA = "0x2F63BD0", Offset = "0x2F621D0", VA = "0x182F63BD0")]
	public bool UpdateIncrement(float time)
	{
		return default(bool);
	}

	// Token: 0x06000024 RID: 36 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000024")]
	[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
	public Transform GetLocation()
	{
		return null;
	}

	// Token: 0x06000025 RID: 37 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000025")]
	[Address(RVA = "0x2F63C60", Offset = "0x2F62260", VA = "0x182F63C60")]
	public FingersSpittleLocation()
	{
	}

	// Token: 0x04000024 RID: 36
	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _Frequency;

	// Token: 0x04000025 RID: 37
	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float _Countdown;

	// Token: 0x04000026 RID: 38
	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _RandomizeTiming;

	// Token: 0x04000027 RID: 39
	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Transform _EmissionTransform;
}
