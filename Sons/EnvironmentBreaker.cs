using System;
using Il2CppDummyDll;
using Sons.Weapon;
using UnityEngine;

// Token: 0x0200003C RID: 60
[Token(Token = "0x200003C")]
[AddComponentMenu("Sons/Gameplay/EnvironmentBreaker")]
public class EnvironmentBreaker : MonoBehaviour, IImpactSender
{
	// Token: 0x0600018C RID: 396 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600018C")]
	[Address(RVA = "0x2F800B0", Offset = "0x2F7E6B0", VA = "0x182F800B0")]
	public void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x0600018D RID: 397 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600018D")]
	[Address(RVA = "0x2F80200", Offset = "0x2F7E800", VA = "0x182F80200")]
	private void DoImpact(Collider other)
	{
	}

	// Token: 0x0600018E RID: 398 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600018E")]
	[Address(RVA = "0x2F80310", Offset = "0x2F7E910", VA = "0x182F80310")]
	private MeleeImpactData GetMeleeImpactData(Component other)
	{
		return null;
	}

	// Token: 0x0600018F RID: 399 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600018F")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	private void OnDamageSuccess(DamageNode damageNode, IImpactData impactData)
	{
	}

	// Token: 0x06000190 RID: 400 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000190")]
	[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "8")]
	private MonoBehaviour GetSourceStimuli()
	{
		return null;
	}

	// Token: 0x06000191 RID: 401 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000191")]
	[Address(RVA = "0x2DBF050", Offset = "0x2DBD650", VA = "0x182DBF050", Slot = "7")]
	public Transform GetRootTransform()
	{
		return null;
	}

	// Token: 0x06000192 RID: 402 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000192")]
	[Address(RVA = "0x2F805C0", Offset = "0x2F7EBC0", VA = "0x182F805C0")]
	public EnvironmentBreaker()
	{
	}

	// Token: 0x0400018B RID: 395
	[Token(Token = "0x400018B")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Header("Impact Values")]
	private ImpactMeleeType _impactMeleeType;

	// Token: 0x0400018C RID: 396
	[Token(Token = "0x400018C")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float _impactDamage;

	// Token: 0x0400018D RID: 397
	[Token(Token = "0x400018D")]
	[FieldOffset(Offset = "0x28")]
	private MeleeImpactData _cachedMeleeImpactData;
}
