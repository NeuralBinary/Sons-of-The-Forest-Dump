using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x02000025 RID: 37
	[Token(Token = "0x2000025")]
	public abstract class ObiClothBlueprintBase : ObiMeshBasedActorBlueprint
	{
		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000126 RID: 294 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x1700002F")]
		public HalfEdgeMesh Topology
		{
			[Token(Token = "0x6000126")]
			[Address(RVA = "0x61C550", Offset = "0x61AB50", VA = "0x18061C550")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000127 RID: 295 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x2745A90", Offset = "0x2744090", VA = "0x182745A90", Slot = "14")]
		protected override void SwapWithFirstInactiveParticle(int index)
		{
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x2745C70", Offset = "0x2744270", VA = "0x182745C70", Slot = "18")]
		protected virtual IEnumerator GenerateDeformableTriangles()
		{
			return null;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x2745D00", Offset = "0x2744300", VA = "0x182745D00", Slot = "19")]
		protected virtual IEnumerator CreateSimplices()
		{
			return null;
		}

		// Token: 0x0600012A RID: 298 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x2741FD0", Offset = "0x27405D0", VA = "0x182741FD0")]
		protected ObiClothBlueprintBase()
		{
		}

		// Token: 0x040000C6 RID: 198
		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x128")]
		[HideInInspector]
		[SerializeField]
		public HalfEdgeMesh topology;

		// Token: 0x040000C7 RID: 199
		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x130")]
		[HideInInspector]
		public int[] deformableTriangles;

		// Token: 0x040000C8 RID: 200
		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x138")]
		[HideInInspector]
		public Vector3[] restNormals;

		// Token: 0x040000C9 RID: 201
		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x140")]
		[HideInInspector]
		public float[] areaContribution;

		// Token: 0x040000CA RID: 202
		[Token(Token = "0x40000CA")]
		public const float DEFAULT_PARTICLE_MASS = 0.1f;
	}
}
