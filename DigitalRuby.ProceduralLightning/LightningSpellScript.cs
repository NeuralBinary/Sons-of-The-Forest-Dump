using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x02000043 RID: 67
	[Token(Token = "0x2000043")]
	public abstract class LightningSpellScript : MonoBehaviour
	{
		// Token: 0x06000195 RID: 405 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000195")]
		[Address(RVA = "0xA4F8D0", Offset = "0xA4DED0", VA = "0x180A4F8D0")]
		private IEnumerator StopAfterSecondsCoRoutine(float seconds)
		{
			return null;
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000196 RID: 406 RVA: 0x000025AC File Offset: 0x000007AC
		// (set) Token: 0x06000197 RID: 407 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000035")]
		private protected float DurationTimer
		{
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x728340", Offset = "0x726940", VA = "0x180728340")]
			[CompilerGenerated]
			protected get
			{
				return 0f;
			}
			[Token(Token = "0x6000197")]
			[Address(RVA = "0x728350", Offset = "0x726950", VA = "0x180728350")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000198 RID: 408 RVA: 0x000025C4 File Offset: 0x000007C4
		// (set) Token: 0x06000199 RID: 409 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000036")]
		private protected float CooldownTimer
		{
			[Token(Token = "0x6000198")]
			[Address(RVA = "0x727F30", Offset = "0x726530", VA = "0x180727F30")]
			[CompilerGenerated]
			protected get
			{
				return 0f;
			}
			[Token(Token = "0x6000199")]
			[Address(RVA = "0x728360", Offset = "0x726960", VA = "0x180728360")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600019A")]
		[Address(RVA = "0xA4F990", Offset = "0xA4DF90", VA = "0x180A4F990")]
		protected void ApplyCollisionForce(Vector3 point)
		{
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600019B")]
		[Address(RVA = "0xA4FCC0", Offset = "0xA4E2C0", VA = "0x180A4FCC0")]
		protected void PlayCollisionSound(Vector3 pos)
		{
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600019C")]
		[Address(RVA = "0xA4FE90", Offset = "0xA4E490", VA = "0x180A4FE90", Slot = "4")]
		protected virtual void Start()
		{
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600019D")]
		[Address(RVA = "0xA4FFB0", Offset = "0xA4E5B0", VA = "0x180A4FFB0", Slot = "5")]
		protected virtual void Update()
		{
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600019E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "6")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "7")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x060001A0 RID: 416
		[Token(Token = "0x60001A0")]
		protected abstract void OnCastSpell();

		// Token: 0x060001A1 RID: 417
		[Token(Token = "0x60001A1")]
		protected abstract void OnStopSpell();

		// Token: 0x060001A2 RID: 418 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "10")]
		protected virtual void OnActivated()
		{
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "11")]
		protected virtual void OnDeactivated()
		{
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x000025DC File Offset: 0x000007DC
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xA500D0", Offset = "0xA4E6D0", VA = "0x180A500D0")]
		public bool CastSpell()
		{
			return default(bool);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xA50600", Offset = "0xA4EC00", VA = "0x180A50600")]
		public void StopSpell()
		{
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xA508B0", Offset = "0xA4EEB0", VA = "0x180A508B0")]
		public void ActivateSpell()
		{
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xA508D0", Offset = "0xA4EED0", VA = "0x180A508D0")]
		public void DeactivateSpell()
		{
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xA508F0", Offset = "0xA4EEF0", VA = "0x180A508F0")]
		public void StopAfterSeconds(float seconds)
		{
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xA509B0", Offset = "0xA4EFB0", VA = "0x180A509B0")]
		public static GameObject FindChildRecursively(Transform t, string name)
		{
			return null;
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060001AA RID: 426 RVA: 0x000025F4 File Offset: 0x000007F4
		// (set) Token: 0x060001AB RID: 427 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000037")]
		public bool Casting
		{
			[Token(Token = "0x60001AA")]
			[Address(RVA = "0xA50BE0", Offset = "0xA4F1E0", VA = "0x180A50BE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0xA50BF0", Offset = "0xA4F1F0", VA = "0x180A50BF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060001AC RID: 428 RVA: 0x0000260C File Offset: 0x0000080C
		[Token(Token = "0x17000038")]
		public bool CanCastSpell
		{
			[Token(Token = "0x60001AC")]
			[Address(RVA = "0xA50C00", Offset = "0xA4F200", VA = "0x180A50C00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xA50C20", Offset = "0xA4F220", VA = "0x180A50C20")]
		protected LightningSpellScript()
		{
		}

		// Token: 0x040001F8 RID: 504
		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("The start point of the spell. Set this to a muzzle end or hand.")]
		[Header("Direction and distance")]
		public GameObject SpellStart;

		// Token: 0x040001F9 RID: 505
		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("The end point of the spell. Set this to an empty game object. This will change depending on things like collisions, randomness, etc. Not all spells need an end object, but create this anyway to be sure.")]
		public GameObject SpellEnd;

		// Token: 0x040001FA RID: 506
		[Token(Token = "0x40001FA")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("The direction of the spell. Should be normalized. Does not change unless explicitly modified.")]
		[HideInInspector]
		public Vector3 Direction;

		// Token: 0x040001FB RID: 507
		[Token(Token = "0x40001FB")]
		[FieldOffset(Offset = "0x3C")]
		[Tooltip("The maximum distance of the spell")]
		public float MaxDistance;

		// Token: 0x040001FC RID: 508
		[Token(Token = "0x40001FC")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("Whether the collision is an exploision. If not explosion, collision is directional.")]
		[Header("Collision")]
		public bool CollisionIsExplosion;

		// Token: 0x040001FD RID: 509
		[Token(Token = "0x40001FD")]
		[FieldOffset(Offset = "0x44")]
		[Tooltip("The radius of the collision explosion")]
		public float CollisionRadius;

		// Token: 0x040001FE RID: 510
		[Token(Token = "0x40001FE")]
		[FieldOffset(Offset = "0x48")]
		[Tooltip("The force to explode with when there is a collision")]
		public float CollisionForce;

		// Token: 0x040001FF RID: 511
		[Token(Token = "0x40001FF")]
		[FieldOffset(Offset = "0x4C")]
		[Tooltip("Collision force mode")]
		public ForceMode CollisionForceMode;

		// Token: 0x04000200 RID: 512
		[Token(Token = "0x4000200")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("The particle system for collisions. For best effects, this should emit particles in bursts at time 0 and not loop.")]
		public ParticleSystem CollisionParticleSystem;

		// Token: 0x04000201 RID: 513
		[Token(Token = "0x4000201")]
		[FieldOffset(Offset = "0x58")]
		[Tooltip("The layers that the spell should collide with")]
		public LayerMask CollisionMask;

		// Token: 0x04000202 RID: 514
		[Token(Token = "0x4000202")]
		[FieldOffset(Offset = "0x60")]
		[Tooltip("Collision audio source")]
		public AudioSource CollisionAudioSource;

		// Token: 0x04000203 RID: 515
		[Token(Token = "0x4000203")]
		[FieldOffset(Offset = "0x68")]
		[Tooltip("Collision audio clips. One will be chosen at random and played one shot with CollisionAudioSource.")]
		public AudioClip[] CollisionAudioClips;

		// Token: 0x04000204 RID: 516
		[Token(Token = "0x4000204")]
		[FieldOffset(Offset = "0x70")]
		[Tooltip("Collision sound volume range.")]
		public RangeOfFloats CollisionVolumeRange;

		// Token: 0x04000205 RID: 517
		[Token(Token = "0x4000205")]
		[FieldOffset(Offset = "0x78")]
		[Tooltip("The duration in seconds that the spell will last. Not all spells support a duration. For one shot spells, this is how long the spell cast / emission light, etc. will last.")]
		[Header("Duration and Cooldown")]
		public float Duration;

		// Token: 0x04000206 RID: 518
		[Token(Token = "0x4000206")]
		[FieldOffset(Offset = "0x7C")]
		[Tooltip("The cooldown in seconds. Once cast, the spell must wait for the cooldown before being cast again.")]
		public float Cooldown;

		// Token: 0x04000207 RID: 519
		[Token(Token = "0x4000207")]
		[FieldOffset(Offset = "0x80")]
		[Tooltip("Emission sound")]
		[Header("Emission")]
		public AudioSource EmissionSound;

		// Token: 0x04000208 RID: 520
		[Token(Token = "0x4000208")]
		[FieldOffset(Offset = "0x88")]
		[Tooltip("Emission particle system. For best results use world space, turn off looping and play on awake.")]
		public ParticleSystem EmissionParticleSystem;

		// Token: 0x04000209 RID: 521
		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0x90")]
		[Tooltip("Light to illuminate when spell is cast")]
		public Light EmissionLight;

		// Token: 0x0400020A RID: 522
		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x98")]
		private int stopToken;
	}
}
