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

// Token: 0x02000050 RID: 80
[Token(Token = "0x2000050")]
[AddComponentMenu("Sons/Gameplay/ProjectileImpactObject")]
public class ProjectileImpactObject : ImpactObject, IImpactSender, IImpactAudio, IParentNotification
{
	// Token: 0x17000080 RID: 128
	// (get) Token: 0x06000263 RID: 611 RVA: 0x00002E80 File Offset: 0x00001080
	[Token(Token = "0x17000080")]
	public bool SticksToTarget
	{
		[Token(Token = "0x6000263")]
		[Address(RVA = "0x2197B80", Offset = "0x2196180", VA = "0x182197B80")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000264 RID: 612 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000264")]
	[Address(RVA = "0x31AD370", Offset = "0x31AB970", VA = "0x1831AD370", Slot = "5")]
	public override void Impact(SurfaceImpactInfo surfaceImpactInfo)
	{
	}

	// Token: 0x06000265 RID: 613 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000265")]
	[Address(RVA = "0x31AE410", Offset = "0x31ACA10", VA = "0x1831AE410", Slot = "12")]
	public void TryPlayAudio(FMODCommon.NetworkRole networkRole)
	{
	}

	// Token: 0x06000266 RID: 614 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000266")]
	[Address(RVA = "0x31AE520", Offset = "0x31ACB20", VA = "0x1831AE520")]
	private void PlayParticles()
	{
	}

	// Token: 0x06000267 RID: 615 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000267")]
	[Address(RVA = "0x31AE690", Offset = "0x31ACC90", VA = "0x1831AE690")]
	private void UpdateRootTransform(SurfaceImpactInfo surfaceImpactInfo)
	{
	}

	// Token: 0x06000268 RID: 616 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000268")]
	[Address(RVA = "0x6F1D00", Offset = "0x6F0300", VA = "0x1806F1D00", Slot = "9")]
	public Transform GetRootTransform()
	{
		return null;
	}

	// Token: 0x06000269 RID: 617 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000269")]
	[Address(RVA = "0x31AE8E0", Offset = "0x31ACEE0", VA = "0x1831AE8E0", Slot = "10")]
	public MonoBehaviour GetSourceStimuli()
	{
		return null;
	}

	// Token: 0x0600026A RID: 618 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600026A")]
	[Address(RVA = "0x31AE900", Offset = "0x31ACF00", VA = "0x1831AE900")]
	private MonoBehaviour GetSourceStimuliInternal(out VailActor actorSource)
	{
		return null;
	}

	// Token: 0x0600026B RID: 619 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600026B")]
	[Address(RVA = "0x31AEAF0", Offset = "0x31AD0F0", VA = "0x1831AEAF0")]
	private void ProcessReceivers(SurfaceImpactInfo surfaceImpactInfo)
	{
	}

	// Token: 0x0600026C RID: 620 RVA: 0x00002E98 File Offset: 0x00001098
	[Token(Token = "0x600026C")]
	[Address(RVA = "0x31AEEF0", Offset = "0x31AD4F0", VA = "0x1831AEEF0")]
	private EventInstance StartAudioPlayback(FMODCommon.NetworkRole networkRole)
	{
		return default(EventInstance);
	}

	// Token: 0x0600026D RID: 621 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600026D")]
	[Address(RVA = "0x31AEFA0", Offset = "0x31AD5A0", VA = "0x1831AEFA0")]
	private void StopAudioPlayback()
	{
	}

	// Token: 0x0600026E RID: 622 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600026E")]
	[Address(RVA = "0x31AEFF0", Offset = "0x31AD5F0", VA = "0x1831AEFF0")]
	private void SpawnVailImpactEvent()
	{
	}

	// Token: 0x0600026F RID: 623 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600026F")]
	[Address(RVA = "0x31AF260", Offset = "0x31AD860", VA = "0x1831AF260")]
	private void StickToTarget(Transform attachTarget)
	{
	}

	// Token: 0x06000270 RID: 624 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000270")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "6")]
	public void OnDamageSuccess(DamageNode damageNode, IImpactData impactData)
	{
	}

	// Token: 0x06000271 RID: 625 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000271")]
	[Address(RVA = "0x31AF540", Offset = "0x31ADB40", VA = "0x1831AF540", Slot = "13")]
	public void OnParentDisabled()
	{
	}

	// Token: 0x06000272 RID: 626 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000272")]
	[Address(RVA = "0x31AFCA0", Offset = "0x31AE2A0", VA = "0x1831AFCA0")]
	public ProjectileImpactObject()
	{
	}

	// Token: 0x0400024B RID: 587
	[Token(Token = "0x400024B")]
	[FieldOffset(Offset = "0x30")]
	[EventRef]
	public string _impactAudioEvent;

	// Token: 0x0400024C RID: 588
	[Token(Token = "0x400024C")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public GameObject _impactEventStimuli;

	// Token: 0x0400024D RID: 589
	[Token(Token = "0x400024D")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private ImpactEffectManager.ParticleType _impactReplicationType;

	// Token: 0x0400024E RID: 590
	[Token(Token = "0x400024E")]
	[FieldOffset(Offset = "0x48")]
	public ParticleSystem _particle;

	// Token: 0x0400024F RID: 591
	[Token(Token = "0x400024F")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private bool _shouldLookupItemInstance;

	// Token: 0x04000250 RID: 592
	[Token(Token = "0x4000250")]
	[FieldOffset(Offset = "0x51")]
	[SerializeField]
	private bool _stickToTarget;

	// Token: 0x04000251 RID: 593
	[Token(Token = "0x4000251")]
	[FieldOffset(Offset = "0x52")]
	[SerializeField]
	private bool _applyVelocityOnImpact;

	// Token: 0x04000252 RID: 594
	[Token(Token = "0x4000252")]
	[FieldOffset(Offset = "0x53")]
	[SerializeField]
	private bool _alignToVelocity;

	// Token: 0x04000253 RID: 595
	[Token(Token = "0x4000253")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	[Range(0f, 1f)]
	private float _bounciness;

	// Token: 0x04000254 RID: 596
	[Token(Token = "0x4000254")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Tooltip("This is only required for pickups that the collision is disabled by default")]
	private bool _enablePickupCollision;

	// Token: 0x04000255 RID: 597
	[Token(Token = "0x4000255")]
	[FieldOffset(Offset = "0x60")]
	private EventInstance _activeAudioEventInstance;

	// Token: 0x04000256 RID: 598
	[Token(Token = "0x4000256")]
	[FieldOffset(Offset = "0x68")]
	public UnityEvent<SurfaceImpactInfo> OnImpactEvent;

	// Token: 0x04000257 RID: 599
	[Token(Token = "0x4000257")]
	[FieldOffset(Offset = "0x70")]
	private Transform _weaponRootTransform;
}
