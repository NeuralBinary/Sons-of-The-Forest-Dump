using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace PathologicalGames
{
	// Token: 0x02000048 RID: 72
	[Token(Token = "0x2000048")]
	[AddComponentMenu("Path-o-logical/TargetPro/Targetable")]
	[RequireComponent(typeof(Rigidbody))]
	public class Targetable : MonoBehaviour
	{
		// Token: 0x0600021C RID: 540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021C")]
		[Address(RVA = "0x28CC9B0", Offset = "0x28CAFB0", VA = "0x1828CC9B0")]
		private void Awake()
		{
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021D")]
		[Address(RVA = "0x28CCB00", Offset = "0x28CB100", VA = "0x1828CCB00")]
		private void OnDisable()
		{
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021E")]
		[Address(RVA = "0x28CCB00", Offset = "0x28CB100", VA = "0x1828CCB00")]
		private void OnDetroy()
		{
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021F")]
		[Address(RVA = "0x28CCB10", Offset = "0x28CB110", VA = "0x1828CCB10")]
		private void CleanUp()
		{
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000220")]
		[Address(RVA = "0x28CCDF0", Offset = "0x28CB3F0", VA = "0x1828CCDF0")]
		public void OnHit(HitEffectList effects, Target target)
		{
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000221")]
		[Address(RVA = "0x28CCE30", Offset = "0x28CB430", VA = "0x1828CCE30")]
		public void OnHit(HitEffectList effects, Target target, Collider other)
		{
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000222")]
		[Address(RVA = "0x28CD050", Offset = "0x28CB650", VA = "0x1828CD050")]
		internal void OnDetected(TargetTracker source)
		{
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000223")]
		[Address(RVA = "0x28CD070", Offset = "0x28CB670", VA = "0x1828CD070")]
		internal void OnNotDetected(TargetTracker source)
		{
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000224 RID: 548 RVA: 0x00002910 File Offset: 0x00000B10
		// (set) Token: 0x06000225 RID: 549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005E")]
		public float strength
		{
			[Token(Token = "0x6000224")]
			[Address(RVA = "0x1F3D0A0", Offset = "0x1F3B6A0", VA = "0x181F3D0A0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000225")]
			[Address(RVA = "0x200ACE0", Offset = "0x20092E0", VA = "0x18200ACE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000226 RID: 550 RVA: 0x00002928 File Offset: 0x00000B28
		[Token(Token = "0x1700005F")]
		public float distToDest
		{
			[Token(Token = "0x6000226")]
			[Address(RVA = "0x28CD090", Offset = "0x28CB690", VA = "0x1828CD090")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00002940 File Offset: 0x00000B40
		[Token(Token = "0x6000227")]
		[Address(RVA = "0x28CD210", Offset = "0x28CB810", VA = "0x1828CD210")]
		public float GetDistToPos(Vector3 other)
		{
			return 0f;
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000228")]
		[Address(RVA = "0x28CD2E0", Offset = "0x28CB8E0", VA = "0x1828CD2E0")]
		public void AddOnDetectedDelegate(Targetable.OnDetectedDelegate del)
		{
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000229")]
		[Address(RVA = "0x5B2560", Offset = "0x5B0B60", VA = "0x1805B2560")]
		public void SetOnDetectedDelegate(Targetable.OnDetectedDelegate del)
		{
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022A")]
		[Address(RVA = "0x28CD3C0", Offset = "0x28CB9C0", VA = "0x1828CD3C0")]
		public void RemoveOnDetectedDelegate(Targetable.OnDetectedDelegate del)
		{
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022B")]
		[Address(RVA = "0x28CD4A0", Offset = "0x28CBAA0", VA = "0x1828CD4A0")]
		public void AddOnNotDetectedDelegate(Targetable.OnNotDetectedDelegate del)
		{
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022C")]
		[Address(RVA = "0x6710D0", Offset = "0x66F6D0", VA = "0x1806710D0")]
		public void SetOnNotDetectedDelegate(Targetable.OnNotDetectedDelegate del)
		{
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022D")]
		[Address(RVA = "0x28CD580", Offset = "0x28CBB80", VA = "0x1828CD580")]
		public void RemoveOnNotDetectedDelegate(Targetable.OnNotDetectedDelegate del)
		{
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022E")]
		[Address(RVA = "0x28CD660", Offset = "0x28CBC60", VA = "0x1828CD660")]
		public void AddOnHitDelegate(Targetable.OnHitDelegate del)
		{
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022F")]
		[Address(RVA = "0x661080", Offset = "0x65F680", VA = "0x180661080")]
		public void SetOnHitDelegate(Targetable.OnHitDelegate del)
		{
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x28CD740", Offset = "0x28CBD40", VA = "0x1828CD740")]
		public void RemoveOnHitDelegate(Targetable.OnHitDelegate del)
		{
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000231")]
		[Address(RVA = "0x28CD820", Offset = "0x28CBE20", VA = "0x1828CD820")]
		public void AddOnHitColliderDelegate(Targetable.OnHitColliderDelegate del)
		{
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x6610F0", Offset = "0x65F6F0", VA = "0x1806610F0")]
		public void SetOnHitColliderDelegate(Targetable.OnHitColliderDelegate del)
		{
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x28CD900", Offset = "0x28CBF00", VA = "0x1828CD900")]
		public void RemoveOnHitColliderDelegate(Targetable.OnHitColliderDelegate del)
		{
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x28CD9E0", Offset = "0x28CBFE0", VA = "0x1828CD9E0")]
		public Targetable()
		{
		}

		// Token: 0x04000117 RID: 279
		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x20")]
		public bool isTargetable;

		// Token: 0x04000118 RID: 280
		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x24")]
		public DEBUG_LEVELS debugLevel;

		// Token: 0x04000119 RID: 281
		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x28")]
		public List<Perimeter> perimeters;

		// Token: 0x0400011A RID: 282
		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x30")]
		public Transform xform;

		// Token: 0x0400011B RID: 283
		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x38")]
		public GameObject go;

		// Token: 0x0400011C RID: 284
		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x40")]
		private Targetable.OnDetectedDelegate onDetectedDelegates;

		// Token: 0x0400011D RID: 285
		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x48")]
		private Targetable.OnNotDetectedDelegate onNotDetectedDelegates;

		// Token: 0x0400011E RID: 286
		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x50")]
		private Targetable.OnHitDelegate onHitDelegates;

		// Token: 0x0400011F RID: 287
		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x58")]
		private Targetable.OnHitColliderDelegate onHitColliderDelegates;

		// Token: 0x04000121 RID: 289
		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x68")]
		[HideInInspector]
		public List<Vector3> waypoints;

		// Token: 0x02000049 RID: 73
		// (Invoke) Token: 0x06000236 RID: 566
		[Token(Token = "0x2000049")]
		public delegate void OnDetectedDelegate(TargetTracker source);

		// Token: 0x0200004A RID: 74
		// (Invoke) Token: 0x0600023A RID: 570
		[Token(Token = "0x200004A")]
		public delegate void OnNotDetectedDelegate(TargetTracker source);

		// Token: 0x0200004B RID: 75
		// (Invoke) Token: 0x0600023E RID: 574
		[Token(Token = "0x200004B")]
		public delegate void OnHitDelegate(HitEffectList effects, Target target);

		// Token: 0x0200004C RID: 76
		// (Invoke) Token: 0x06000242 RID: 578
		[Token(Token = "0x200004C")]
		public delegate void OnHitColliderDelegate(HitEffectList effects, Target target, Collider other);
	}
}
