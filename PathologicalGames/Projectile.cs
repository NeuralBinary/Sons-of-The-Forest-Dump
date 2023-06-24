using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace PathologicalGames
{
	// Token: 0x02000041 RID: 65
	[Token(Token = "0x2000041")]
	[AddComponentMenu("Path-o-logical/TargetPro/Projectile")]
	[RequireComponent(typeof(Rigidbody))]
	public class Projectile : TargetTracker
	{
		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x000028E0 File Offset: 0x00000AE0
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005A")]
		public Target target
		{
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x28CA210", Offset = "0x28C8810", VA = "0x1828CA210")]
			[CompilerGenerated]
			get
			{
				return default(Target);
			}
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x28CA240", Offset = "0x28C8840", VA = "0x1828CA240")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005B")]
		public HitEffectList effectsOnTarget
		{
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x28CA2B0", Offset = "0x28C88B0", VA = "0x1828CA2B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x28CA610", Offset = "0x28C8C10", VA = "0x1828CA610")]
			set
			{
			}
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x28CA870", Offset = "0x28C8E70", VA = "0x1828CA870", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x28CA910", Offset = "0x28C8F10", VA = "0x1828CA910", Slot = "6")]
		protected override void OnEnable()
		{
		}

		// Token: 0x060001FC RID: 508 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x28CAA10", Offset = "0x28C9010", VA = "0x1828CAA10")]
		private IEnumerator Launch()
		{
			return null;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x28CAAA0", Offset = "0x28C90A0", VA = "0x1828CAAA0")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x28CAEA0", Offset = "0x28C94A0", VA = "0x1828CAEA0")]
		public void DetonateProjectile()
		{
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x28CBAC0", Offset = "0x28CA0C0", VA = "0x1828CBAC0")]
		private void SpawnDetonatorPrefab(bool passEffects)
		{
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000200")]
		[Address(RVA = "0x28CBF00", Offset = "0x28CA500", VA = "0x1828CBF00")]
		public void AddOnLaunchedDelegate(Projectile.OnLaunched del)
		{
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x8DF500", Offset = "0x8DDB00", VA = "0x1808DF500")]
		public void SetOnLaunchedDelegate(Projectile.OnLaunched del)
		{
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x28CBFF0", Offset = "0x28CA5F0", VA = "0x1828CBFF0")]
		public void RemoveOnLaunchedDelegate(Projectile.OnLaunched del)
		{
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000203")]
		[Address(RVA = "0x28CC0E0", Offset = "0x28CA6E0", VA = "0x1828CC0E0")]
		public void AddOnLaunchedUpdateDelegate(Projectile.OnLaunchedUpdate del)
		{
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x8DF570", Offset = "0x8DDB70", VA = "0x1808DF570")]
		public void SetOnLaunchedUpdateDelegate(Projectile.OnLaunchedUpdate del)
		{
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000205")]
		[Address(RVA = "0x28CC1D0", Offset = "0x28CA7D0", VA = "0x1828CC1D0")]
		public void RemoveOnLaunchedUpdateDelegate(Projectile.OnLaunchedUpdate del)
		{
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000206")]
		[Address(RVA = "0x28CC2C0", Offset = "0x28CA8C0", VA = "0x1828CC2C0")]
		public void AddOnDetonationDelegate(Projectile.OnDetonation del)
		{
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000207")]
		[Address(RVA = "0x25A72B0", Offset = "0x25A58B0", VA = "0x1825A72B0")]
		public void SetOnDetonationDelegate(Projectile.OnDetonation del)
		{
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x28CC3B0", Offset = "0x28CA9B0", VA = "0x1828CC3B0")]
		public void RemoveOnDetonationDelegate(Projectile.OnDetonation del)
		{
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000209")]
		[Address(RVA = "0x28CC4A0", Offset = "0x28CAAA0", VA = "0x1828CC4A0")]
		public Projectile()
		{
		}

		// Token: 0x040000FF RID: 255
		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0xC8")]
		public List<HitEffectGUIBacker> _effectsOnTarget;

		// Token: 0x04000100 RID: 256
		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0xD0")]
		public bool areaHit;

		// Token: 0x04000101 RID: 257
		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0xD1")]
		public bool detonateOnRigidBodySleep;

		// Token: 0x04000102 RID: 258
		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0xD4")]
		public Projectile.DETONATION_MODES detonationMode;

		// Token: 0x04000103 RID: 259
		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0xD8")]
		public float timer;

		// Token: 0x04000104 RID: 260
		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0xDC")]
		public Projectile.NOTIFY_TARGET_OPTIONS notifyTargets;

		// Token: 0x04000105 RID: 261
		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0xE0")]
		public Transform detonationPrefab;

		// Token: 0x04000106 RID: 262
		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0xE8")]
		public FireController fireController;

		// Token: 0x04000107 RID: 263
		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0xF0")]
		public Dictionary<object, bool> _editorListItemStates;

		// Token: 0x04000108 RID: 264
		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0xF8")]
		private float curTimer;

		// Token: 0x04000109 RID: 265
		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0x100")]
		private Rigidbody rbd;

		// Token: 0x0400010A RID: 266
		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0x108")]
		private Projectile.OnLaunched OnLaunchedDelegates;

		// Token: 0x0400010B RID: 267
		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0x110")]
		private Projectile.OnLaunchedUpdate OnLaunchedUpdateDelegates;

		// Token: 0x0400010C RID: 268
		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x118")]
		private Projectile.OnDetonation OnDetonationDelegates;

		// Token: 0x02000042 RID: 66
		[Token(Token = "0x2000042")]
		public enum DETONATION_MODES
		{
			// Token: 0x0400010E RID: 270
			[Token(Token = "0x400010E")]
			TargetOnly,
			// Token: 0x0400010F RID: 271
			[Token(Token = "0x400010F")]
			HitLayers
		}

		// Token: 0x02000043 RID: 67
		[Token(Token = "0x2000043")]
		public enum NOTIFY_TARGET_OPTIONS
		{
			// Token: 0x04000111 RID: 273
			[Token(Token = "0x4000111")]
			Off,
			// Token: 0x04000112 RID: 274
			[Token(Token = "0x4000112")]
			Direct,
			// Token: 0x04000113 RID: 275
			[Token(Token = "0x4000113")]
			PassToDetonator
		}

		// Token: 0x02000044 RID: 68
		// (Invoke) Token: 0x0600020B RID: 523
		[Token(Token = "0x2000044")]
		public delegate void OnLaunched();

		// Token: 0x02000045 RID: 69
		// (Invoke) Token: 0x0600020F RID: 527
		[Token(Token = "0x2000045")]
		public delegate void OnLaunchedUpdate();

		// Token: 0x02000046 RID: 70
		// (Invoke) Token: 0x06000213 RID: 531
		[Token(Token = "0x2000046")]
		public delegate void OnDetonation(TargetList targets);
	}
}
