using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x0200003D RID: 61
	[Token(Token = "0x200003D")]
	[DisallowMultipleComponent]
	[AddComponentMenu("Physics/Obi/Obi Cloth Proxy", 906)]
	public class ObiClothProxy : MonoBehaviour
	{
		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x00002186 File Offset: 0x00000386
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x17000054")]
		public ObiClothRendererBase master
		{
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0x2753380", Offset = "0x2751980", VA = "0x182753380")]
			set
			{
			}
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x2753610", Offset = "0x2751C10", VA = "0x182753610")]
		public void OnEnable()
		{
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x2753790", Offset = "0x2751D90", VA = "0x182753790")]
		public void OnDisable()
		{
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x27538B0", Offset = "0x2751EB0", VA = "0x1827538B0")]
		private void GetSlaveMeshIfNeeded()
		{
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x2753C00", Offset = "0x2752200", VA = "0x182753C00")]
		public void UpdateSkinning(ObiActor actor)
		{
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ObiClothProxy()
		{
		}

		// Token: 0x0400015D RID: 349
		[Token(Token = "0x400015D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		private ObiClothRendererBase m_Master;

		// Token: 0x0400015E RID: 350
		[Token(Token = "0x400015E")]
		[FieldOffset(Offset = "0x28")]
		public ObiTriangleSkinMap skinMap;

		// Token: 0x0400015F RID: 351
		[Token(Token = "0x400015F")]
		[FieldOffset(Offset = "0x30")]
		private Mesh slaveMesh;

		// Token: 0x04000160 RID: 352
		[Token(Token = "0x4000160")]
		[FieldOffset(Offset = "0x38")]
		private Vector3[] slavePositions;

		// Token: 0x04000161 RID: 353
		[Token(Token = "0x4000161")]
		[FieldOffset(Offset = "0x40")]
		private Vector3[] slaveNormals;

		// Token: 0x04000162 RID: 354
		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0x48")]
		private Vector4[] slaveTangents;

		// Token: 0x04000163 RID: 355
		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x50")]
		private MeshFilter meshFilter;
	}
}
