using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x02000042 RID: 66
	[Token(Token = "0x2000042")]
	public class LightningParticleSpellScript : LightningSpellScript, ICollisionHandler
	{
		// Token: 0x0600018B RID: 395 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600018B")]
		[Address(RVA = "0xA4E3A0", Offset = "0xA4C9A0", VA = "0x180A4E3A0")]
		private void PopulateParticleLight(Light src)
		{
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600018C")]
		[Address(RVA = "0xA4E690", Offset = "0xA4CC90", VA = "0x180A4E690")]
		private void UpdateParticleLights()
		{
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600018D")]
		[Address(RVA = "0xA4EB20", Offset = "0xA4D120", VA = "0x180A4EB20")]
		private void UpdateParticleSystems()
		{
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600018E")]
		[Address(RVA = "0xA4F120", Offset = "0xA4D720", VA = "0x180A4F120", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600018F")]
		[Address(RVA = "0xA4F2E0", Offset = "0xA4D8E0", VA = "0x180A4F2E0", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000190")]
		[Address(RVA = "0xA4F2F0", Offset = "0xA4D8F0", VA = "0x180A4F2F0", Slot = "5")]
		protected override void Update()
		{
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000191")]
		[Address(RVA = "0xA4F3B0", Offset = "0xA4D9B0", VA = "0x180A4F3B0", Slot = "8")]
		protected override void OnCastSpell()
		{
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000192")]
		[Address(RVA = "0xA4F4D0", Offset = "0xA4DAD0", VA = "0x180A4F4D0", Slot = "9")]
		protected override void OnStopSpell()
		{
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000193")]
		[Address(RVA = "0xA4F5F0", Offset = "0xA4DBF0", VA = "0x180A4F5F0", Slot = "12")]
		private void HandleCollision(GameObject obj, List<ParticleCollisionEvent> collisions, int collisionCount)
		{
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000194")]
		[Address(RVA = "0xA4F730", Offset = "0xA4DD30", VA = "0x180A4F730")]
		public LightningParticleSpellScript()
		{
		}

		// Token: 0x040001EC RID: 492
		[Token(Token = "0x40001EC")]
		[FieldOffset(Offset = "0xA8")]
		[Header("Particle system")]
		public ParticleSystem ParticleSystem;

		// Token: 0x040001ED RID: 493
		[Token(Token = "0x40001ED")]
		[FieldOffset(Offset = "0xB0")]
		[Tooltip("Particle system collision interval. This time must elapse before another collision will be registered.")]
		public float CollisionInterval;

		// Token: 0x040001EE RID: 494
		[Token(Token = "0x40001EE")]
		[FieldOffset(Offset = "0xB4")]
		protected float collisionTimer;

		// Token: 0x040001EF RID: 495
		[Token(Token = "0x40001EF")]
		[FieldOffset(Offset = "0xB8")]
		[HideInInspector]
		public Action<GameObject, List<ParticleCollisionEvent>, int> CollisionCallback;

		// Token: 0x040001F0 RID: 496
		[Token(Token = "0x40001F0")]
		[FieldOffset(Offset = "0xC0")]
		[Header("Particle Light Properties")]
		[Tooltip("Whether to enable point lights for the particles")]
		public bool EnableParticleLights;

		// Token: 0x040001F1 RID: 497
		[Token(Token = "0x40001F1")]
		[FieldOffset(Offset = "0xC4")]
		[SingleLineClamp("Possible range for particle lights", 0.001, 100.0)]
		public RangeOfFloats ParticleLightRange;

		// Token: 0x040001F2 RID: 498
		[Token(Token = "0x40001F2")]
		[FieldOffset(Offset = "0xCC")]
		[SingleLineClamp("Possible range of intensity for particle lights", 0.009999999776482582, 8.0)]
		public RangeOfFloats ParticleLightIntensity;

		// Token: 0x040001F3 RID: 499
		[Token(Token = "0x40001F3")]
		[FieldOffset(Offset = "0xD4")]
		[Tooltip("Possible range of colors for particle lights")]
		public Color ParticleLightColor1;

		// Token: 0x040001F4 RID: 500
		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0xE4")]
		[Tooltip("Possible range of colors for particle lights")]
		public Color ParticleLightColor2;

		// Token: 0x040001F5 RID: 501
		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0xF4")]
		[Tooltip("The culling mask for particle lights")]
		public LayerMask ParticleLightCullingMask;

		// Token: 0x040001F6 RID: 502
		[Token(Token = "0x40001F6")]
		[FieldOffset(Offset = "0xF8")]
		private ParticleSystem.Particle[] particles;

		// Token: 0x040001F7 RID: 503
		[Token(Token = "0x40001F7")]
		[FieldOffset(Offset = "0x100")]
		private readonly List<GameObject> particleLights;
	}
}
