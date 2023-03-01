using System;
using Il2CppDummyDll;
using Sons.Weapon;
using UnityEngine;

// Token: 0x0200003C RID: 60
[Token(Token = "0x200003C")]
[AddComponentMenu("Sons/Gameplay/EnvironmentBreaker")]
public class EnvironmentBreaker : MonoBehaviour, IImpactSender
{
	// Token: 0x06000183 RID: 387 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000183")]
	[Address(RVA = "0x299EDB0", Offset = "0x299DDB0", VA = "0x18299EDB0")]
	public void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06000184 RID: 388 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000184")]
	[Address(RVA = "0x299E990", Offset = "0x299D990", VA = "0x18299E990")]
	private void DoImpact(Collider other)
	{
	}

	// Token: 0x06000185 RID: 389 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000185")]
	[Address(RVA = "0x299EBF0", Offset = "0x299DBF0", VA = "0x18299EBF0")]
	private MeleeImpactData GetMeleeImpactData(Component other)
	{
		return null;
	}

	// Token: 0x06000186 RID: 390 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000186")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "4")]
	private void OnDamageSuccess(DamageNode damageNode, IImpactData impactData)
	{
	}

	// Token: 0x06000187 RID: 391 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000187")]
	[Address(RVA = "0x580AF0", Offset = "0x57FAF0", VA = "0x180580AF0", Slot = "8")]
	private MonoBehaviour GetSourceStimuli()
	{
		return null;
	}

	// Token: 0x06000188 RID: 392 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000188")]
	[Address(RVA = "0x286CA80", Offset = "0x286BA80", VA = "0x18286CA80", Slot = "7")]
	public Transform GetRootTransform()
	{
		return null;
	}

	// Token: 0x06000189 RID: 393 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000189")]
	[Address(RVA = "0x299EE20", Offset = "0x299DE20", VA = "0x18299EE20")]
	public EnvironmentBreaker()
	{
	}

	// Token: 0x04000187 RID: 391
	[Token(Token = "0x4000187")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Header("Impact Values")]
	private ImpactMeleeType _impactMeleeType;

	// Token: 0x04000188 RID: 392
	[Token(Token = "0x4000188")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float _impactDamage;

	// Token: 0x04000189 RID: 393
	[Token(Token = "0x4000189")]
	[FieldOffset(Offset = "0x28")]
	private MeleeImpactData _cachedMeleeImpactData;
}
