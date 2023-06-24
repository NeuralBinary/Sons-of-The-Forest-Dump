using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Collections;
using UnityEngine;

namespace MudBun
{
	// Token: 0x0200005B RID: 91
	[Token(Token = "0x200005B")]
	[ExecuteInEditMode]
	public abstract class MudBrushBase : MonoBehaviour
	{
		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000276 RID: 630 RVA: 0x00003480 File Offset: 0x00001680
		[Token(Token = "0x17000053")]
		public bool Hidden
		{
			[Token(Token = "0x6000276")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000277 RID: 631 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000054")]
		public MudRendererBase Renderer
		{
			[Token(Token = "0x6000277")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000278")]
		[Address(RVA = "0x23C5D60", Offset = "0x23C4360", VA = "0x1823C5D60")]
		public void MarkDirty()
		{
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000279 RID: 633 RVA: 0x00003498 File Offset: 0x00001698
		[Token(Token = "0x17000055")]
		public virtual Aabb BoundsRs
		{
			[Token(Token = "0x6000279")]
			[Address(RVA = "0x23C5D70", Offset = "0x23C4370", VA = "0x1823C5D70", Slot = "4")]
			get
			{
				return default(Aabb);
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600027A RID: 634 RVA: 0x000034B0 File Offset: 0x000016B0
		[Token(Token = "0x17000056")]
		public virtual Aabb RawBoundsRs
		{
			[Token(Token = "0x600027A")]
			[Address(RVA = "0x23C5DB0", Offset = "0x23C43B0", VA = "0x1823C5DB0", Slot = "5")]
			get
			{
				return default(Aabb);
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600027B RID: 635 RVA: 0x000034C8 File Offset: 0x000016C8
		[Token(Token = "0x17000057")]
		public virtual float BoundsRsPadding
		{
			[Token(Token = "0x600027B")]
			[Address(RVA = "0x620A90", Offset = "0x61F090", VA = "0x180620A90", Slot = "6")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600027C RID: 636 RVA: 0x000034E0 File Offset: 0x000016E0
		[Token(Token = "0x17000058")]
		public virtual bool IsSuccessorModifier
		{
			[Token(Token = "0x600027C")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600027D RID: 637 RVA: 0x000034F8 File Offset: 0x000016F8
		[Token(Token = "0x17000059")]
		public virtual bool ShouldUseAccumulatedBounds
		{
			[Token(Token = "0x600027D")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600027E RID: 638 RVA: 0x00003510 File Offset: 0x00001710
		[Token(Token = "0x1700005A")]
		public virtual bool IsBrushGroup
		{
			[Token(Token = "0x600027E")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600027F RID: 639 RVA: 0x00003528 File Offset: 0x00001728
		[Token(Token = "0x1700005B")]
		internal virtual bool UsesMaterial
		{
			[Token(Token = "0x600027F")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000280 RID: 640 RVA: 0x00003540 File Offset: 0x00001740
		[Token(Token = "0x1700005C")]
		internal virtual int MaterialHash
		{
			[Token(Token = "0x6000280")]
			[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "11")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000281")]
		[Address(RVA = "0x23C5E50", Offset = "0x23C4450", VA = "0x1823C5E50", Slot = "12")]
		public virtual void UpdateProxies(AabbTree<MudBrushBase> tree, Aabb opBounds)
		{
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000282")]
		[Address(RVA = "0x23C5F50", Offset = "0x23C4550", VA = "0x1823C5F50", Slot = "13")]
		public virtual void DestroyProxies(AabbTree<MudBrushBase> tree)
		{
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00003558 File Offset: 0x00001758
		[Token(Token = "0x6000283")]
		[Address(RVA = "0x23C5FE0", Offset = "0x23C45E0", VA = "0x1823C5FE0")]
		public Aabb BoundaryShapeBounds(SdfBrush.BoundaryShapeEnum boundaryShape, float radius)
		{
			return default(Aabb);
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "14")]
		protected virtual void ScanRenderer()
		{
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000285")]
		[Address(RVA = "0x23C66F0", Offset = "0x23C4CF0", VA = "0x1823C66F0", Slot = "15")]
		public virtual void OnEnable()
		{
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000286")]
		[Address(RVA = "0x23C67B0", Offset = "0x23C4DB0", VA = "0x1823C67B0", Slot = "16")]
		public virtual void OnDisable()
		{
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000287")]
		[Address(RVA = "0x23C6890", Offset = "0x23C4E90", VA = "0x1823C6890")]
		private void OnValidate()
		{
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000288")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "17")]
		public virtual void SanitizeParameters()
		{
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00003570 File Offset: 0x00001770
		[Token(Token = "0x6000289")]
		[Address(RVA = "0x23C68C0", Offset = "0x23C4EC0", VA = "0x1823C68C0")]
		public Vector3 PointRs(Vector3 posWs)
		{
			return default(Vector3);
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00003588 File Offset: 0x00001788
		[Token(Token = "0x600028A")]
		[Address(RVA = "0x23C6A90", Offset = "0x23C5090", VA = "0x1823C6A90")]
		public Vector3 VectorRs(Vector3 vecWs)
		{
			return default(Vector3);
		}

		// Token: 0x0600028B RID: 651 RVA: 0x000035A0 File Offset: 0x000017A0
		[Token(Token = "0x600028B")]
		[Address(RVA = "0x23C6C60", Offset = "0x23C5260", VA = "0x1823C6C60")]
		public Quaternion RotationRs(Quaternion rotWs)
		{
			return default(Quaternion);
		}

		// Token: 0x0600028C RID: 652 RVA: 0x000035B8 File Offset: 0x000017B8
		[Token(Token = "0x600028C")]
		[Address(RVA = "0x23C6E90", Offset = "0x23C5490", VA = "0x1823C6E90")]
		public Vector3 PointBs(Vector3 posWs)
		{
			return default(Vector3);
		}

		// Token: 0x0600028D RID: 653 RVA: 0x000035D0 File Offset: 0x000017D0
		[Token(Token = "0x600028D")]
		[Address(RVA = "0x23C6F90", Offset = "0x23C5590", VA = "0x1823C6F90")]
		public Vector3 VectorBs(Vector3 vecWs)
		{
			return default(Vector3);
		}

		// Token: 0x0600028E RID: 654 RVA: 0x000035E8 File Offset: 0x000017E8
		[Token(Token = "0x600028E")]
		[Address(RVA = "0x23C7090", Offset = "0x23C5690", VA = "0x1823C7090")]
		public Quaternion RotationBs(Quaternion rotWs)
		{
			return default(Quaternion);
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600028F RID: 655 RVA: 0x00003600 File Offset: 0x00001800
		[Token(Token = "0x1700005D")]
		public virtual bool CountAsBone
		{
			[Token(Token = "0x600028F")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00003618 File Offset: 0x00001818
		[Token(Token = "0x6000290")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "19")]
		public virtual int FillComputeData(NativeArray<SdfBrush> aBrush, int iStart, List<Transform> aBone)
		{
			return 0;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000291")]
		[Address(RVA = "0x23C7340", Offset = "0x23C5940", VA = "0x1823C7340", Slot = "20")]
		public virtual void FillBrushData(ref SdfBrush brush, int iBrush)
		{
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00003630 File Offset: 0x00001830
		[Token(Token = "0x6000292")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "21")]
		public virtual int FillComputeDataPostChildren(NativeArray<SdfBrush> aBrush, int iStart)
		{
			return 0;
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000293")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "22")]
		public virtual void FillBrushDataPostChildren(ref SdfBrush brush, int iBrush)
		{
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000294")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "23")]
		public virtual void FillBrushMaterialData(ref SdfBrushMaterial mat)
		{
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000295")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "24")]
		public virtual void ValidateMaterial()
		{
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x23C75E0", Offset = "0x23C5BE0", VA = "0x1823C75E0")]
		public ICollection<Transform> GetFlipXTransforms()
		{
			return null;
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x23C76A0", Offset = "0x23C5CA0", VA = "0x1823C76A0")]
		public void FlipX()
		{
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000298")]
		[Address(RVA = "0x23C7B40", Offset = "0x23C6140", VA = "0x1823C7B40")]
		private void CollectChildrenRecursive(Transform t, List<Transform> aTransform)
		{
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00003648 File Offset: 0x00001848
		[Token(Token = "0x6000299")]
		[Address(RVA = "0x23C7CA0", Offset = "0x23C62A0", VA = "0x1823C7CA0")]
		public float GetFloatHash()
		{
			return 0f;
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00003660 File Offset: 0x00001860
		[Token(Token = "0x600029A")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "25")]
		internal virtual bool IsSelected()
		{
			return default(bool);
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029B")]
		[Address(RVA = "0x23C7DA0", Offset = "0x23C63A0", VA = "0x1823C7DA0", Slot = "26")]
		protected virtual void OnDrawGizmos()
		{
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "27")]
		public virtual void DrawGizmosRs()
		{
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "28")]
		public virtual void DrawSelectionGizmosRs()
		{
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "29")]
		public virtual void DrawOutlineGizmosRs()
		{
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029F")]
		[Address(RVA = "0x23C5CD0", Offset = "0x23C42D0", VA = "0x1823C5CD0")]
		protected MudBrushBase()
		{
		}

		// Token: 0x040000B3 RID: 179
		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x20")]
		internal MudRendererBase m_renderer;

		// Token: 0x040000B4 RID: 180
		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x28")]
		internal int m_iSdfBrush;

		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x2C")]
		internal bool m_dirty;

		// Token: 0x040000B6 RID: 182
		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x2D")]
		internal bool m_preChildrenFlag;

		// Token: 0x040000B7 RID: 183
		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x30")]
		internal int m_iProxy;

		// Token: 0x0200005C RID: 92
		[Token(Token = "0x200005C")]
		private struct Locator
		{
			// Token: 0x040000B8 RID: 184
			[Token(Token = "0x40000B8")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 Position;

			// Token: 0x040000B9 RID: 185
			[Token(Token = "0x40000B9")]
			[FieldOffset(Offset = "0xC")]
			public Quaternion Rotation;
		}
	}
}
