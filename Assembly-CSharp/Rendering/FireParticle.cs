using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Rendering
{
	// Token: 0x0200004B RID: 75
	[Token(Token = "0x200004B")]
	public class FireParticle : MonoBehaviour
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x060000FE RID: 254 RVA: 0x000023B8 File Offset: 0x000005B8
		// (set) Token: 0x060000FF RID: 255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000004")]
		public float State
		{
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x5EA820", Offset = "0x5E8E20", VA = "0x1805EA820")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x5EA830", Offset = "0x5E8E30", VA = "0x1805EA830")]
			protected set
			{
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000100 RID: 256 RVA: 0x000023D0 File Offset: 0x000005D0
		// (set) Token: 0x06000101 RID: 257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000005")]
		public float BurnTimeSec
		{
			[Token(Token = "0x6000100")]
			[Address(RVA = "0x5EA840", Offset = "0x5E8E40", VA = "0x1805EA840")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x5EA850", Offset = "0x5E8E50", VA = "0x1805EA850")]
			protected set
			{
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000102 RID: 258 RVA: 0x000023E8 File Offset: 0x000005E8
		// (set) Token: 0x06000103 RID: 259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000006")]
		public Vector3 Position
		{
			[Token(Token = "0x6000102")]
			[Address(RVA = "0x5EA860", Offset = "0x5E8E60", VA = "0x1805EA860")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000103")]
			[Address(RVA = "0x5EA8F0", Offset = "0x5E8EF0", VA = "0x1805EA8F0")]
			protected set
			{
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x5EA970", Offset = "0x5E8F70", VA = "0x1805EA970")]
		private void OnEnable()
		{
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x5EAAC0", Offset = "0x5E90C0", VA = "0x1805EAAC0")]
		private void OnDisable()
		{
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x5EAB40", Offset = "0x5E9140", VA = "0x1805EAB40")]
		private void Update()
		{
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x5EABE0", Offset = "0x5E91E0", VA = "0x1805EABE0")]
		public FireParticle()
		{
		}

		// Token: 0x04000235 RID: 565
		[Token(Token = "0x4000235")]
		[FieldOffset(Offset = "0x0")]
		public static List<FireParticle> FireParticles;

		// Token: 0x04000236 RID: 566
		[Token(Token = "0x4000236")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _state;

		// Token: 0x04000237 RID: 567
		[Token(Token = "0x4000237")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _burnTimeSec;

		// Token: 0x04000238 RID: 568
		[Token(Token = "0x4000238")]
		[FieldOffset(Offset = "0x28")]
		private Transform _transform;
	}
}
