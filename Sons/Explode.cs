using System;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using Sons.Weapon;
using UnityEngine;

// Token: 0x0200003D RID: 61
[Token(Token = "0x200003D")]
public class Explode : MonoBehaviour, IDamageCallbackSender, IImpactSender
{
	// Token: 0x06000193 RID: 403 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000193")]
	[Address(RVA = "0x2F80610", Offset = "0x2F7EC10", VA = "0x182F80610")]
	private void OnDrawGizmosSelected()
	{
	}

	// Token: 0x06000194 RID: 404 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000194")]
	[Address(RVA = "0x2F80740", Offset = "0x2F7ED40", VA = "0x182F80740")]
	private void OnEnable()
	{
	}

	// Token: 0x06000195 RID: 405 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000195")]
	[Address(RVA = "0x2F814F0", Offset = "0x2F7FAF0", VA = "0x182F814F0")]
	private ExplosionImpactData GetImpactData(ProjectileInfo projectileInfo, Transform other)
	{
		return null;
	}

	// Token: 0x06000196 RID: 406 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000196")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "6")]
	public void OnDamageSuccess(DamageNode damageNode, IImpactData impactData)
	{
	}

	// Token: 0x06000197 RID: 407 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000197")]
	[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "9")]
	public Transform GetRootTransform()
	{
		return null;
	}

	// Token: 0x06000198 RID: 408 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000198")]
	[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0", Slot = "10")]
	private MonoBehaviour GetSourceStimuli()
	{
		return null;
	}

	// Token: 0x06000199 RID: 409 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000199")]
	[Address(RVA = "0x6610F0", Offset = "0x65F6F0", VA = "0x1806610F0")]
	public void SetSourceStimuli(MonoBehaviour sourceStimuli)
	{
	}

	// Token: 0x0600019A RID: 410 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600019A")]
	[Address(RVA = "0x2F81970", Offset = "0x2F7FF70", VA = "0x182F81970", Slot = "4")]
	public string GetName()
	{
		return null;
	}

	// Token: 0x0600019B RID: 411 RVA: 0x00002670 File Offset: 0x00000870
	[Token(Token = "0x600019B")]
	[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "5")]
	public int GetId()
	{
		return 0;
	}

	// Token: 0x0600019C RID: 412 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600019C")]
	[Address(RVA = "0x2F819A0", Offset = "0x2F7FFA0", VA = "0x182F819A0")]
	public Explode()
	{
	}

	// Token: 0x0400018E RID: 398
	[Token(Token = "0x400018E")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _radius;

	// Token: 0x0400018F RID: 399
	[Token(Token = "0x400018F")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float _explosiveForceMultiplier;

	// Token: 0x04000190 RID: 400
	[Token(Token = "0x4000190")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool _doCameraShake;

	// Token: 0x04000191 RID: 401
	[Token(Token = "0x4000191")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AmmoProperties _ammoProperties;

	// Token: 0x04000192 RID: 402
	[Token(Token = "0x4000192")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private bool _snapToGround;

	// Token: 0x04000193 RID: 403
	[Token(Token = "0x4000193")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private VailAudioManager.Noise _noiseStimuli;

	// Token: 0x04000194 RID: 404
	[Token(Token = "0x4000194")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Tooltip("For larger explosions, scare closer vail actors more, etc.")]
	private bool _explodeStimuliEvent;

	// Token: 0x04000195 RID: 405
	[Token(Token = "0x4000195")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject _landExplosionFx;

	// Token: 0x04000196 RID: 406
	[Token(Token = "0x4000196")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private GameObject _waterExplosionFx;

	// Token: 0x04000197 RID: 407
	[Token(Token = "0x4000197")]
	[FieldOffset(Offset = "0x58")]
	private MonoBehaviour _sourceStimuli;
}
