using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x0200002B RID: 43
	[Token(Token = "0x200002B")]
	[CreateAssetMenu(fileName = "tearable cloth blueprint", menuName = "Obi/Tearable Cloth Blueprint", order = 121)]
	public class ObiTearableClothBlueprint : ObiClothBlueprint
	{
		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000147 RID: 327 RVA: 0x00002564 File Offset: 0x00000764
		[Token(Token = "0x17000039")]
		public int PooledParticles
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x2748830", Offset = "0x2746E30", VA = "0x182748830")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000148 RID: 328 RVA: 0x0000257C File Offset: 0x0000077C
		[Token(Token = "0x1700003A")]
		public override bool usesTethers
		{
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x2748840", Offset = "0x2746E40", VA = "0x182748840", Slot = "17")]
		protected override IEnumerator Initialize()
		{
			return null;
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x27488D0", Offset = "0x2746ED0", VA = "0x1827488D0", Slot = "20")]
		protected override IEnumerator CreateDistanceConstraints()
		{
			return null;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x2748960", Offset = "0x2746F60", VA = "0x182748960")]
		private IEnumerator CreateInitialDistanceConstraints(List<int> edges)
		{
			return null;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x2748A60", Offset = "0x2747060", VA = "0x182748A60")]
		private IEnumerator CreatePooledDistanceConstraints(List<int> edges)
		{
			return null;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x2748B60", Offset = "0x2747160", VA = "0x182748B60")]
		public ObiTearableClothBlueprint()
		{
		}

		// Token: 0x040000E1 RID: 225
		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x148")]
		[Tooltip("Amount of memory preallocated to create extra particles and mesh data when tearing the cloth. 0 means no extra memory will be allocated, and the cloth will not be tearable. 1 means all cloth triangles will be fully tearable.")]
		[Range(0f, 1f)]
		public float tearCapacity;

		// Token: 0x040000E2 RID: 226
		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x14C")]
		[SerializeField]
		[HideInInspector]
		private int pooledParticles;

		// Token: 0x040000E3 RID: 227
		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x150")]
		[HideInInspector]
		public float[] tearResistance;

		// Token: 0x040000E4 RID: 228
		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		[HideInInspector]
		public Vector2Int[] distanceConstraintMap;
	}
}
