using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace PathologicalGames
{
	// Token: 0x0200002C RID: 44
	[Token(Token = "0x200002C")]
	[AddComponentMenu("Path-o-logical/TargetPro/Detonator")]
	public class Detonator : TargetTracker
	{
		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600015C RID: 348 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x0600015D RID: 349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000049")]
		public HitEffectList effectsOnTarget
		{
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x28C1AB0", Offset = "0x28C00B0", VA = "0x1828C1AB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x28C1E10", Offset = "0x28C0410", VA = "0x1828C1E10")]
			set
			{
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x28C2070", Offset = "0x28C0670", VA = "0x1828C2070", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x28C20F0", Offset = "0x28C06F0", VA = "0x1828C20F0", Slot = "6")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06000160 RID: 352 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000160")]
		[Address(RVA = "0x28C21F0", Offset = "0x28C07F0", VA = "0x1828C21F0")]
		private IEnumerator Detonate()
		{
			return null;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000161")]
		[Address(RVA = "0x28C2280", Offset = "0x28C0880", VA = "0x1828C2280")]
		public void AddOnDetonatingDelegate(Detonator.OnDetonating del)
		{
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000162")]
		[Address(RVA = "0x728460", Offset = "0x726A60", VA = "0x180728460")]
		public void SetOnDetonatingDelegate(Detonator.OnDetonating del)
		{
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000163")]
		[Address(RVA = "0x28C2370", Offset = "0x28C0970", VA = "0x1828C2370")]
		public void RemoveOnDetonatingDelegate(Detonator.OnDetonating del)
		{
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000164")]
		[Address(RVA = "0x28C2460", Offset = "0x28C0A60", VA = "0x1828C2460")]
		public void AddOnDetonatingUpdateDelegate(Detonator.OnDetonatingUpdate del)
		{
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000165")]
		[Address(RVA = "0x8ECC90", Offset = "0x8EB290", VA = "0x1808ECC90")]
		public void SetOnDetonatingUpdateDelegate(Detonator.OnDetonatingUpdate del)
		{
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000166")]
		[Address(RVA = "0x28C2550", Offset = "0x28C0B50", VA = "0x1828C2550")]
		public void RemoveOnDetonatingUpdateDelegate(Detonator.OnDetonatingUpdate del)
		{
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000167")]
		[Address(RVA = "0x28C2640", Offset = "0x28C0C40", VA = "0x1828C2640")]
		public void AddOnDetonationDelegate(Detonator.OnDetonation del)
		{
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x7849D0", Offset = "0x782FD0", VA = "0x1807849D0")]
		public void SetOnDetonationDelegate(Detonator.OnDetonation del)
		{
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000169")]
		[Address(RVA = "0x28C2730", Offset = "0x28C0D30", VA = "0x1828C2730")]
		public void RemoveOnDetonationDelegate(Detonator.OnDetonation del)
		{
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016A")]
		[Address(RVA = "0x28C2820", Offset = "0x28C0E20", VA = "0x1828C2820")]
		public Detonator()
		{
		}

		// Token: 0x040000B9 RID: 185
		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x98")]
		public float durration;

		// Token: 0x040000BA RID: 186
		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x9C")]
		public Vector3 maxRange;

		// Token: 0x040000BB RID: 187
		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0xA8")]
		public List<HitEffectGUIBacker> _effectsOnTarget;

		// Token: 0x040000BC RID: 188
		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0xB0")]
		public Dictionary<object, bool> _editorListItemStates;

		// Token: 0x040000BD RID: 189
		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0xB8")]
		private Detonator.OnDetonating OnDetonatingDelegates;

		// Token: 0x040000BE RID: 190
		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0xC0")]
		private Detonator.OnDetonatingUpdate OnDetonatingUpdateDelegates;

		// Token: 0x040000BF RID: 191
		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0xC8")]
		private Detonator.OnDetonation OnDetonationDelegates;

		// Token: 0x0200002D RID: 45
		// (Invoke) Token: 0x0600016C RID: 364
		[Token(Token = "0x200002D")]
		public delegate void OnDetonating();

		// Token: 0x0200002E RID: 46
		// (Invoke) Token: 0x06000170 RID: 368
		[Token(Token = "0x200002E")]
		public delegate void OnDetonatingUpdate(float progress);

		// Token: 0x0200002F RID: 47
		// (Invoke) Token: 0x06000174 RID: 372
		[Token(Token = "0x200002F")]
		public delegate void OnDetonation(TargetList targets);
	}
}
