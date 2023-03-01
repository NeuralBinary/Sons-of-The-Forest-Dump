using System;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using Sons.Weapon;
using UnityEngine;

// Token: 0x0200003D RID: 61
[Token(Token = "0x200003D")]
public class Explode : MonoBehaviour, IDamageCallbackSender, IImpactSender
{
	// Token: 0x0600018A RID: 394 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600018A")]
	[Address(RVA = "0x299F140", Offset = "0x299E140", VA = "0x18299F140")]
	private void OnDrawGizmosSelected()
	{
	}

	// Token: 0x0600018B RID: 395 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600018B")]
	[Address(RVA = "0x299F1B0", Offset = "0x299E1B0", VA = "0x18299F1B0")]
	private void OnEnable()
	{
	}

	// Token: 0x0600018C RID: 396 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600018C")]
	[Address(RVA = "0x299EE40", Offset = "0x299DE40", VA = "0x18299EE40")]
	private ExplosionImpactData GetImpactData(ProjectileInfo projectileInfo, Transform other)
	{
		return null;
	}

	// Token: 0x0600018D RID: 397 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600018D")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "6")]
	public void OnDamageSuccess(DamageNode damageNode, IImpactData impactData)
	{
	}

	// Token: 0x0600018E RID: 398 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600018E")]
	[Address(RVA = "0x5E9620", Offset = "0x5E8620", VA = "0x1805E9620", Slot = "9")]
	public Transform GetRootTransform()
	{
		return null;
	}

	// Token: 0x0600018F RID: 399 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600018F")]
	[Address(RVA = "0x5E65C0", Offset = "0x5E55C0", VA = "0x1805E65C0", Slot = "10")]
	private MonoBehaviour GetSourceStimuli()
	{
		return null;
	}

	// Token: 0x06000190 RID: 400 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000190")]
	[Address(RVA = "0x5E65D0", Offset = "0x5E55D0", VA = "0x1805E65D0")]
	public void SetSourceStimuli(MonoBehaviour sourceStimuli)
	{
	}

	// Token: 0x06000191 RID: 401 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000191")]
	[Address(RVA = "0x299F110", Offset = "0x299E110", VA = "0x18299F110", Slot = "4")]
	public string GetName()
	{
		return null;
	}

	// Token: 0x06000192 RID: 402 RVA: 0x00002658 File Offset: 0x00000858
	[Token(Token = "0x6000192")]
	[Address(RVA = "0x580AF0", Offset = "0x57FAF0", VA = "0x180580AF0", Slot = "5")]
	public int GetId()
	{
		return default(int);
	}

	// Token: 0x06000193 RID: 403 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000193")]
	[Address(RVA = "0x299F890", Offset = "0x299E890", VA = "0x18299F890")]
	public Explode()
	{
	}

	// Token: 0x0400018A RID: 394
	[Token(Token = "0x400018A")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _radius;

	// Token: 0x0400018B RID: 395
	[Token(Token = "0x400018B")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float _explosiveForceMultiplier;

	// Token: 0x0400018C RID: 396
	[Token(Token = "0x400018C")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool _doCameraShake;

	// Token: 0x0400018D RID: 397
	[Token(Token = "0x400018D")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AmmoProperties _ammoProperties;

	// Token: 0x0400018E RID: 398
	[Token(Token = "0x400018E")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private bool _snapToGround;

	// Token: 0x0400018F RID: 399
	[Token(Token = "0x400018F")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private VailAudioManager.Noise _noiseStimuli;

	// Token: 0x04000190 RID: 400
	[Token(Token = "0x4000190")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Tooltip("For larger explosions, scare closer vail actors more, etc.")]
	private bool _explodeStimuliEvent;

	// Token: 0x04000191 RID: 401
	[Token(Token = "0x4000191")]
	[FieldOffset(Offset = "0x48")]
	private MonoBehaviour _sourceStimuli;
}
