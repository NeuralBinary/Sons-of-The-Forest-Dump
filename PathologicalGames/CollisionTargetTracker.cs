using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace PathologicalGames
{
	// Token: 0x0200002A RID: 42
	[Token(Token = "0x200002A")]
	[AddComponentMenu("Path-o-logical/TargetPro/CollisionTargetTracker")]
	public class CollisionTargetTracker : TargetTracker
	{
		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600014D RID: 333 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000046")]
		public override TargetList targets
		{
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x28C0730", Offset = "0x28BED30", VA = "0x1828C0730", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x28C0C50", Offset = "0x28BF250", VA = "0x1828C0C50", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x28C0F10", Offset = "0x28BF510", VA = "0x1828C0F10")]
		private void OnCollisionEnter(Collision collisionInfo)
		{
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x28C1150", Offset = "0x28BF750", VA = "0x1828C1150")]
		private void OnCollisionExit(Collision collisionInfo)
		{
		}

		// Token: 0x06000151 RID: 337 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x28C1660", Offset = "0x28BFC60", VA = "0x1828C1660")]
		private IEnumerator DelayRemove(Target target)
		{
			return null;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "6")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00002718 File Offset: 0x00000918
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x28C1770", Offset = "0x28BFD70", VA = "0x1828C1770")]
		private bool IsInLayerMask(GameObject obj)
		{
			return default(bool);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x28C17F0", Offset = "0x28BFDF0", VA = "0x1828C17F0")]
		public CollisionTargetTracker()
		{
		}

		// Token: 0x040000B3 RID: 179
		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x98")]
		private TargetList allTargets;

		// Token: 0x040000B4 RID: 180
		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0xA0")]
		public Collider coll;
	}
}
