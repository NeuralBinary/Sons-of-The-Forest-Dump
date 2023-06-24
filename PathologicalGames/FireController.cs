using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace PathologicalGames
{
	// Token: 0x02000031 RID: 49
	[Token(Token = "0x2000031")]
	[RequireComponent(typeof(TargetTracker))]
	[AddComponentMenu("Path-o-logical/TargetPro/Fire Controller")]
	public class FireController : MonoBehaviour
	{
		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600017D RID: 381 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x0600017E RID: 382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004C")]
		public HitEffectList effectsOnTarget
		{
			[Token(Token = "0x600017D")]
			[Address(RVA = "0x28C3400", Offset = "0x28C1A00", VA = "0x1828C3400")]
			get
			{
				return null;
			}
			[Token(Token = "0x600017E")]
			[Address(RVA = "0x28C3760", Offset = "0x28C1D60", VA = "0x1828C3760")]
			set
			{
			}
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017F")]
		[Address(RVA = "0x28C39C0", Offset = "0x28C1FC0", VA = "0x1828C39C0")]
		private void Awake()
		{
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000180")]
		[Address(RVA = "0x28C3BA0", Offset = "0x28C21A0", VA = "0x1828C3BA0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000181")]
		[Address(RVA = "0x28C3C40", Offset = "0x28C2240", VA = "0x1828C3C40")]
		private void OnDisable()
		{
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000182")]
		[Address(RVA = "0x28C3D40", Offset = "0x28C2340", VA = "0x1828C3D40")]
		private void OnStart()
		{
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000183")]
		[Address(RVA = "0x28C3DF0", Offset = "0x28C23F0", VA = "0x1828C3DF0")]
		private void OnUpdate()
		{
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000184")]
		[Address(RVA = "0xA711A0", Offset = "0xA6F7A0", VA = "0x180A711A0")]
		private void OnTargetUpdate(TargetList targets)
		{
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000185")]
		[Address(RVA = "0x28C3E10", Offset = "0x28C2410", VA = "0x1828C3E10")]
		private void OnIdleUpdate()
		{
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000186")]
		[Address(RVA = "0x28C3E30", Offset = "0x28C2430", VA = "0x1828C3E30")]
		private void OnStop()
		{
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000187")]
		[Address(RVA = "0x28C3EF0", Offset = "0x28C24F0", VA = "0x1828C3EF0")]
		private void OnFire()
		{
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000188")]
		[Address(RVA = "0x28C4710", Offset = "0x28C2D10", VA = "0x1828C4710")]
		private void SpawnAmmunition(Target target, bool passTarget, bool passEffects)
		{
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000189")]
		[Address(RVA = "0x28C4B70", Offset = "0x28C3170", VA = "0x1828C4B70")]
		public void AddOnStartDelegate(FireController.OnStartDelegate del)
		{
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018A")]
		[Address(RVA = "0x73EE10", Offset = "0x73D410", VA = "0x18073EE10")]
		public void SetOnStartDelegate(FireController.OnStartDelegate del)
		{
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x28C4C50", Offset = "0x28C3250", VA = "0x1828C4C50")]
		public void RemoveOnStartDelegate(FireController.OnStartDelegate del)
		{
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x28C4D30", Offset = "0x28C3330", VA = "0x1828C4D30")]
		public void AddOnUpdateDelegate(FireController.OnUpdateDelegate del)
		{
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x8DD040", Offset = "0x8DB640", VA = "0x1808DD040")]
		public void SetOnUpdateDelegate(FireController.OnUpdateDelegate del)
		{
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x28C4E10", Offset = "0x28C3410", VA = "0x1828C4E10")]
		public void RemoveOnUpdateDelegate(FireController.OnUpdateDelegate del)
		{
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x28C4EF0", Offset = "0x28C34F0", VA = "0x1828C4EF0")]
		public void AddOnTargetUpdateDelegate(FireController.OnTargetUpdateDelegate del)
		{
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x8DD0B0", Offset = "0x8DB6B0", VA = "0x1808DD0B0")]
		public void SetOnTargetUpdateDelegate(FireController.OnTargetUpdateDelegate del)
		{
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x28C4FE0", Offset = "0x28C35E0", VA = "0x1828C4FE0")]
		public void RemoveOnTargetUpdateDelegate(FireController.OnTargetUpdateDelegate del)
		{
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x28C50D0", Offset = "0x28C36D0", VA = "0x1828C50D0")]
		public void AddOnIdleUpdateDelegate(FireController.OnIdleUpdateDelegate del)
		{
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000193")]
		[Address(RVA = "0x8DD110", Offset = "0x8DB710", VA = "0x1808DD110")]
		public void SetOnIdleUpdateDelegate(FireController.OnIdleUpdateDelegate del)
		{
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x28C51C0", Offset = "0x28C37C0", VA = "0x1828C51C0")]
		public void RemoveOnIdleUpdateDelegate(FireController.OnIdleUpdateDelegate del)
		{
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000195")]
		[Address(RVA = "0x28C52B0", Offset = "0x28C38B0", VA = "0x1828C52B0")]
		public void AddOnStopDelegate(FireController.OnStopDelegate del)
		{
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x1D4F140", Offset = "0x1D4D740", VA = "0x181D4F140")]
		public void SetOnStopDelegate(FireController.OnStopDelegate del)
		{
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x28C53A0", Offset = "0x28C39A0", VA = "0x1828C53A0")]
		public void RemoveOnStopDelegate(FireController.OnStopDelegate del)
		{
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x28C5490", Offset = "0x28C3A90", VA = "0x1828C5490")]
		public void AddOnPreFireDelegate(FireController.OnPreFireDelegate del)
		{
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x750FB0", Offset = "0x74F5B0", VA = "0x180750FB0")]
		public void SetOnPreFireDelegate(FireController.OnPreFireDelegate del)
		{
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x28C5580", Offset = "0x28C3B80", VA = "0x1828C5580")]
		public void RemoveOnPreFireDelegate(FireController.OnPreFireDelegate del)
		{
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019B")]
		[Address(RVA = "0x28C5670", Offset = "0x28C3C70", VA = "0x1828C5670")]
		public void AddOnFireDelegate(FireController.OnFireDelegate del)
		{
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019C")]
		[Address(RVA = "0x13428C0", Offset = "0x1340EC0", VA = "0x1813428C0")]
		public void SetOnFireDelegate(FireController.OnFireDelegate del)
		{
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x28C5760", Offset = "0x28C3D60", VA = "0x1828C5760")]
		public void RemoveOnFireDelegate(FireController.OnFireDelegate del)
		{
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019E")]
		[Address(RVA = "0x28C5850", Offset = "0x28C3E50", VA = "0x1828C5850")]
		public void FireImmediately(bool resetIntervalCounter)
		{
		}

		// Token: 0x0600019F RID: 415 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x28C5890", Offset = "0x28C3E90", VA = "0x1828C5890")]
		private IEnumerator FiringSystem()
		{
			return null;
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x00002760 File Offset: 0x00000960
		[Token(Token = "0x1700004D")]
		private bool isLockedOnTarget
		{
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x28C5920", Offset = "0x28C3F20", VA = "0x1828C5920")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700004E")]
		private string targetsString
		{
			[Token(Token = "0x60001A1")]
			[Address(RVA = "0x28C5E40", Offset = "0x28C4440", VA = "0x1828C5E40")]
			get
			{
				return null;
			}
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x28C61E0", Offset = "0x28C47E0", VA = "0x1828C61E0")]
		public FireController()
		{
		}

		// Token: 0x040000C6 RID: 198
		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x20")]
		public float interval;

		// Token: 0x040000C7 RID: 199
		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x24")]
		public bool initIntervalCountdownAtZero;

		// Token: 0x040000C8 RID: 200
		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x28")]
		public FireController.NOTIFY_TARGET_OPTIONS notifyTargets;

		// Token: 0x040000C9 RID: 201
		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x30")]
		public Transform ammoPrefab;

		// Token: 0x040000CA RID: 202
		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x38")]
		public List<HitEffectGUIBacker> _effectsOnTarget;

		// Token: 0x040000CB RID: 203
		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x40")]
		public bool waitForAlignment;

		// Token: 0x040000CC RID: 204
		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0x41")]
		public bool flatAngleCompare;

		// Token: 0x040000CD RID: 205
		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x48")]
		public Transform emitter;

		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x50")]
		public float lockOnAngleTolerance;

		// Token: 0x040000CF RID: 207
		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x54")]
		public DEBUG_LEVELS debugLevel;

		// Token: 0x040000D0 RID: 208
		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x58")]
		public float fireIntervalCounter;

		// Token: 0x040000D1 RID: 209
		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x60")]
		public Dictionary<object, bool> _editorListItemStates;

		// Token: 0x040000D2 RID: 210
		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x68")]
		private TargetTracker targetTracker;

		// Token: 0x040000D3 RID: 211
		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x70")]
		private TargetList targets;

		// Token: 0x040000D4 RID: 212
		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x78")]
		private FireController.OnStartDelegate onStartDelegates;

		// Token: 0x040000D5 RID: 213
		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x80")]
		private FireController.OnUpdateDelegate onUpdateDelegates;

		// Token: 0x040000D6 RID: 214
		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x88")]
		private FireController.OnTargetUpdateDelegate onTargetUpdateDelegates;

		// Token: 0x040000D7 RID: 215
		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0x90")]
		private FireController.OnIdleUpdateDelegate onIdleUpdateDelegates;

		// Token: 0x040000D8 RID: 216
		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x98")]
		private FireController.OnStopDelegate onStopDelegates;

		// Token: 0x040000D9 RID: 217
		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0xA0")]
		private FireController.OnPreFireDelegate onPreFireDelegates;

		// Token: 0x040000DA RID: 218
		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0xA8")]
		private FireController.OnFireDelegate onFireDelegates;

		// Token: 0x02000032 RID: 50
		[Token(Token = "0x2000032")]
		public enum NOTIFY_TARGET_OPTIONS
		{
			// Token: 0x040000DC RID: 220
			[Token(Token = "0x40000DC")]
			Off,
			// Token: 0x040000DD RID: 221
			[Token(Token = "0x40000DD")]
			Direct,
			// Token: 0x040000DE RID: 222
			[Token(Token = "0x40000DE")]
			PassToProjectile,
			// Token: 0x040000DF RID: 223
			[Token(Token = "0x40000DF")]
			UseProjectileEffects
		}

		// Token: 0x02000033 RID: 51
		// (Invoke) Token: 0x060001A4 RID: 420
		[Token(Token = "0x2000033")]
		public delegate void OnStartDelegate();

		// Token: 0x02000034 RID: 52
		// (Invoke) Token: 0x060001A8 RID: 424
		[Token(Token = "0x2000034")]
		public delegate void OnUpdateDelegate();

		// Token: 0x02000035 RID: 53
		// (Invoke) Token: 0x060001AC RID: 428
		[Token(Token = "0x2000035")]
		public delegate void OnTargetUpdateDelegate(TargetList targets);

		// Token: 0x02000036 RID: 54
		// (Invoke) Token: 0x060001B0 RID: 432
		[Token(Token = "0x2000036")]
		public delegate void OnIdleUpdateDelegate();

		// Token: 0x02000037 RID: 55
		// (Invoke) Token: 0x060001B4 RID: 436
		[Token(Token = "0x2000037")]
		public delegate void OnStopDelegate();

		// Token: 0x02000038 RID: 56
		// (Invoke) Token: 0x060001B8 RID: 440
		[Token(Token = "0x2000038")]
		public delegate void OnPreFireDelegate(TargetList targets);

		// Token: 0x02000039 RID: 57
		// (Invoke) Token: 0x060001BC RID: 444
		[Token(Token = "0x2000039")]
		public delegate void OnFireDelegate(TargetList targets);
	}
}
