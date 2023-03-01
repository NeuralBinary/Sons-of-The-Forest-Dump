using System;
using Ballistics;
using Endnight.Utilities;
using FMOD.Studio;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using Sons.Weapon;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x0200004E RID: 78
[Token(Token = "0x200004E")]
[AddComponentMenu("Sons/Gameplay/ProjectileImpactObject")]
public class ProjectileImpactObject : ImpactObject, IImpactSender, IImpactAudio, IParentNotification
{
	// Token: 0x1700007A RID: 122
	// (get) Token: 0x06000244 RID: 580 RVA: 0x00002DA8 File Offset: 0x00000FA8
	[Token(Token = "0x1700007A")]
	public bool SticksToTarget
	{
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x8A27A0", Offset = "0x8A17A0", VA = "0x1808A27A0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000245 RID: 581 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000245")]
	[Address(RVA = "0x2B7D780", Offset = "0x2B7C780", VA = "0x182B7D780", Slot = "5")]
	public override void Impact(SurfaceImpactInfo surfaceImpactInfo)
	{
	}

	// Token: 0x06000246 RID: 582 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000246")]
	[Address(RVA = "0x2B7EB60", Offset = "0x2B7DB60", VA = "0x182B7EB60", Slot = "11")]
	public void TryPlayAudio(FMODCommon.NetworkRole networkRole)
	{
	}

	// Token: 0x06000247 RID: 583 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000247")]
	[Address(RVA = "0x2B7E470", Offset = "0x2B7D470", VA = "0x182B7E470")]
	private void PlayParticles()
	{
	}

	// Token: 0x06000248 RID: 584 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000248")]
	[Address(RVA = "0x2B7EC30", Offset = "0x2B7DC30", VA = "0x182B7EC30")]
	private void UpdateRootTransform(SurfaceImpactInfo surfaceImpactInfo)
	{
	}

	// Token: 0x06000249 RID: 585 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000249")]
	[Address(RVA = "0x5A2410", Offset = "0x5A1410", VA = "0x1805A2410", Slot = "9")]
	public Transform GetRootTransform()
	{
		return null;
	}

	// Token: 0x0600024A RID: 586 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600024A")]
	[Address(RVA = "0x2B7D760", Offset = "0x2B7C760", VA = "0x182B7D760", Slot = "10")]
	public MonoBehaviour GetSourceStimuli()
	{
		return null;
	}

	// Token: 0x0600024B RID: 587 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600024B")]
	[Address(RVA = "0x2B7D650", Offset = "0x2B7C650", VA = "0x182B7D650")]
	private MonoBehaviour GetSourceStimuliInternal(out VailActor actorSource)
	{
		return null;
	}

	// Token: 0x0600024C RID: 588 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600024C")]
	[Address(RVA = "0x2B7E510", Offset = "0x2B7D510", VA = "0x182B7E510")]
	private void ProcessReceivers(SurfaceImpactInfo surfaceImpactInfo)
	{
	}

	// Token: 0x0600024D RID: 589 RVA: 0x00002DC0 File Offset: 0x00000FC0
	[Token(Token = "0x600024D")]
	[Address(RVA = "0x2B7E930", Offset = "0x2B7D930", VA = "0x182B7E930")]
	private EventInstance StartAudioPlayback(FMODCommon.NetworkRole networkRole)
	{
		return default(EventInstance);
	}

	// Token: 0x0600024E RID: 590 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600024E")]
	[Address(RVA = "0x2B7EB10", Offset = "0x2B7DB10", VA = "0x182B7EB10")]
	private void StopAudioPlayback()
	{
	}

	// Token: 0x0600024F RID: 591 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600024F")]
	[Address(RVA = "0x2B7E800", Offset = "0x2B7D800", VA = "0x182B7E800")]
	private void SpawnVailImpactEvent()
	{
	}

	// Token: 0x06000250 RID: 592 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000250")]
	[Address(RVA = "0x2B7E9B0", Offset = "0x2B7D9B0", VA = "0x182B7E9B0")]
	private void StickToTarget(Transform attachTarget)
	{
	}

	// Token: 0x06000251 RID: 593 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000251")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "6")]
	public void OnDamageSuccess(DamageNode damageNode, IImpactData impactData)
	{
	}

	// Token: 0x06000252 RID: 594 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000252")]
	[Address(RVA = "0x2B7E060", Offset = "0x2B7D060", VA = "0x182B7E060", Slot = "12")]
	public void OnParentDisabled()
	{
	}

	// Token: 0x06000253 RID: 595 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000253")]
	[Address(RVA = "0x2B7ECF0", Offset = "0x2B7DCF0", VA = "0x182B7ECF0")]
	public ProjectileImpactObject()
	{
	}

	// Token: 0x0400021A RID: 538
	[Token(Token = "0x400021A")]
	[FieldOffset(Offset = "0x30")]
	[EventRef]
	public string _impactAudioEvent;

	// Token: 0x0400021B RID: 539
	[Token(Token = "0x400021B")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public GameObject _impactEventStimuli;

	// Token: 0x0400021C RID: 540
	[Token(Token = "0x400021C")]
	[FieldOffset(Offset = "0x40")]
	public ParticleSystem _particle;

	// Token: 0x0400021D RID: 541
	[Token(Token = "0x400021D")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private bool _shouldLookupItemInstance;

	// Token: 0x0400021E RID: 542
	[Token(Token = "0x400021E")]
	[FieldOffset(Offset = "0x49")]
	[SerializeField]
	private bool _stickToTarget;

	// Token: 0x0400021F RID: 543
	[Token(Token = "0x400021F")]
	[FieldOffset(Offset = "0x4A")]
	[SerializeField]
	private bool _applyVelocityOnImpact;

	// Token: 0x04000220 RID: 544
	[Token(Token = "0x4000220")]
	[FieldOffset(Offset = "0x4B")]
	[SerializeField]
	private bool _alignToVelocity;

	// Token: 0x04000221 RID: 545
	[Token(Token = "0x4000221")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[Range(0f, 1f)]
	private float _bounciness;

	// Token: 0x04000222 RID: 546
	[Token(Token = "0x4000222")]
	[FieldOffset(Offset = "0x50")]
	private EventInstance _activeAudioEventInstance;

	// Token: 0x04000223 RID: 547
	[Token(Token = "0x4000223")]
	[FieldOffset(Offset = "0x58")]
	public UnityEvent<SurfaceImpactInfo> OnImpactEvent;

	// Token: 0x04000224 RID: 548
	[Token(Token = "0x4000224")]
	[FieldOffset(Offset = "0x60")]
	private Transform _weaponRootTransform;
}
