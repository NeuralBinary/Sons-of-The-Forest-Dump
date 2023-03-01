using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.Utils
{
	// Token: 0x020003B4 RID: 948
	[Token(Token = "0x20003B4")]
	[Obsolete]
	public class CullingGrid : MonoBehaviour
	{
		// Token: 0x17000351 RID: 849
		// (get) Token: 0x060018D6 RID: 6358 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060018D7 RID: 6359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000351")]
		public static CullingGrid Instance
		{
			[Token(Token = "0x60018D6")]
			[Address(RVA = "0x2CC3F20", Offset = "0x2CC2F20", VA = "0x182CC3F20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60018D7")]
			[Address(RVA = "0x2CC3F60", Offset = "0x2CC2F60", VA = "0x182CC3F60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060018D8 RID: 6360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018D8")]
		[Address(RVA = "0x2CC2A80", Offset = "0x2CC1A80", VA = "0x182CC2A80")]
		private void Awake()
		{
		}

		// Token: 0x060018D9 RID: 6361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018D9")]
		[Address(RVA = "0x2CC35F0", Offset = "0x2CC25F0", VA = "0x182CC35F0")]
		private void Update()
		{
		}

		// Token: 0x060018DA RID: 6362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018DA")]
		[Address(RVA = "0x2CC2FF0", Offset = "0x2CC1FF0", VA = "0x182CC2FF0")]
		private void OnEnable()
		{
		}

		// Token: 0x060018DB RID: 6363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018DB")]
		[Address(RVA = "0x2CC2EA0", Offset = "0x2CC1EA0", VA = "0x182CC2EA0")]
		private void OnDisable()
		{
		}

		// Token: 0x060018DC RID: 6364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018DC")]
		[Address(RVA = "0x2CC2DD0", Offset = "0x2CC1DD0", VA = "0x182CC2DD0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060018DD RID: 6365 RVA: 0x00007800 File Offset: 0x00005A00
		[Token(Token = "0x60018DD")]
		[Address(RVA = "0x2CC3370", Offset = "0x2CC2370", VA = "0x182CC3370")]
		public static int Register(Renderer r)
		{
			return default(int);
		}

		// Token: 0x060018DE RID: 6366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018DE")]
		[Address(RVA = "0x2CC3480", Offset = "0x2CC2480", VA = "0x182CC3480")]
		public static void Unregister(Renderer r, int token)
		{
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x00007818 File Offset: 0x00005A18
		[Token(Token = "0x60018DF")]
		[Address(RVA = "0x2CC3140", Offset = "0x2CC2140", VA = "0x182CC3140")]
		private int RegisterInternal(Renderer r)
		{
			return default(int);
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018E0")]
		[Address(RVA = "0x2CC33D0", Offset = "0x2CC23D0", VA = "0x182CC33D0")]
		private void UnregisterInternal(Renderer r, int token)
		{
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x00007830 File Offset: 0x00005A30
		[Token(Token = "0x60018E1")]
		[Address(RVA = "0x2CC3E00", Offset = "0x2CC2E00", VA = "0x182CC3E00")]
		private int WorldToGridX(float xPosition)
		{
			return default(int);
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x00007848 File Offset: 0x00005A48
		[Token(Token = "0x60018E2")]
		[Address(RVA = "0x2CC3E90", Offset = "0x2CC2E90", VA = "0x182CC3E90")]
		private int WorldToGridY(float zPosition)
		{
			return default(int);
		}

		// Token: 0x060018E3 RID: 6371 RVA: 0x00007860 File Offset: 0x00005A60
		[Token(Token = "0x60018E3")]
		[Address(RVA = "0x2CC3DE0", Offset = "0x2CC2DE0", VA = "0x182CC3DE0")]
		private int WorldToGridXRounded(float xPosition)
		{
			return default(int);
		}

		// Token: 0x060018E4 RID: 6372 RVA: 0x00007878 File Offset: 0x00005A78
		[Token(Token = "0x60018E4")]
		[Address(RVA = "0x2CC3E70", Offset = "0x2CC2E70", VA = "0x182CC3E70")]
		private int WorldToGridYRounded(float zPosition)
		{
			return default(int);
		}

		// Token: 0x060018E5 RID: 6373 RVA: 0x00007890 File Offset: 0x00005A90
		[Token(Token = "0x60018E5")]
		[Address(RVA = "0x2CC2DB0", Offset = "0x2CC1DB0", VA = "0x182CC2DB0")]
		private float GridToWorldX(float xPosition)
		{
			return default(float);
		}

		// Token: 0x060018E6 RID: 6374 RVA: 0x000078A8 File Offset: 0x00005AA8
		[Token(Token = "0x60018E6")]
		[Address(RVA = "0x2CC2DC0", Offset = "0x2CC1DC0", VA = "0x182CC2DC0")]
		private float GridToWorldZ(float yPosition)
		{
			return default(float);
		}

		// Token: 0x060018E7 RID: 6375 RVA: 0x000078C0 File Offset: 0x00005AC0
		[Token(Token = "0x60018E7")]
		[Address(RVA = "0x2CC2D60", Offset = "0x2CC1D60", VA = "0x182CC2D60")]
		private Vector2 GridCenterToWorld(int x, int y)
		{
			return default(Vector2);
		}

		// Token: 0x060018E8 RID: 6376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018E8")]
		[Address(RVA = "0x2CC3F00", Offset = "0x2CC2F00", VA = "0x182CC3F00")]
		public CullingGrid()
		{
		}

		// Token: 0x04001885 RID: 6277
		[Token(Token = "0x4001885")]
		[FieldOffset(Offset = "0x20")]
		public int _gridSize;

		// Token: 0x04001886 RID: 6278
		[Token(Token = "0x4001886")]
		[FieldOffset(Offset = "0x24")]
		public float _gridWorldSize;

		// Token: 0x04001887 RID: 6279
		[Token(Token = "0x4001887")]
		[FieldOffset(Offset = "0x28")]
		public float _onRadius;

		// Token: 0x04001888 RID: 6280
		[Token(Token = "0x4001888")]
		[FieldOffset(Offset = "0x2C")]
		[Header("Gizmos")]
		public bool _showGrid;

		// Token: 0x04001889 RID: 6281
		[Token(Token = "0x4001889")]
		[FieldOffset(Offset = "0x2D")]
		public bool _showRendererDensity;

		// Token: 0x0400188A RID: 6282
		[Token(Token = "0x400188A")]
		[FieldOffset(Offset = "0x30")]
		public float _highestCellRendererCount;

		// Token: 0x0400188B RID: 6283
		[Token(Token = "0x400188B")]
		[FieldOffset(Offset = "0x34")]
		public float _highestCellInRangeRendererCount;

		// Token: 0x0400188C RID: 6284
		[Token(Token = "0x400188C")]
		[FieldOffset(Offset = "0x38")]
		public float _currentlyInRadiusRendererCount;

		// Token: 0x0400188E RID: 6286
		[Token(Token = "0x400188E")]
		[FieldOffset(Offset = "0x3C")]
		private Vector2 _offset;

		// Token: 0x0400188F RID: 6287
		[Token(Token = "0x400188F")]
		[FieldOffset(Offset = "0x48")]
		private CullingGrid.Cell[,] _rendererGrid;

		// Token: 0x04001890 RID: 6288
		[Token(Token = "0x4001890")]
		[FieldOffset(Offset = "0x50")]
		private Vector2 _circlePosition;

		// Token: 0x04001891 RID: 6289
		[Token(Token = "0x4001891")]
		[FieldOffset(Offset = "0x58")]
		private List<CullingGrid.Cell> _activeCells;

		// Token: 0x04001892 RID: 6290
		[Token(Token = "0x4001892")]
		[FieldOffset(Offset = "0x60")]
		private List<CullingGrid.Cell> _workCells;

		// Token: 0x04001893 RID: 6291
		[Token(Token = "0x4001893")]
		[FieldOffset(Offset = "0x68")]
		private int _frameCount;

		// Token: 0x020003B5 RID: 949
		[Token(Token = "0x20003B5")]
		public class Cell
		{
			// Token: 0x060018E9 RID: 6377 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60018E9")]
			[Address(RVA = "0x2CC27E0", Offset = "0x2CC17E0", VA = "0x182CC27E0")]
			public Cell()
			{
			}

			// Token: 0x04001894 RID: 6292
			[Token(Token = "0x4001894")]
			[FieldOffset(Offset = "0x10")]
			public bool _enabled;

			// Token: 0x04001895 RID: 6293
			[Token(Token = "0x4001895")]
			[FieldOffset(Offset = "0x14")]
			public int _activeAt;

			// Token: 0x04001896 RID: 6294
			[Token(Token = "0x4001896")]
			[FieldOffset(Offset = "0x18")]
			public float _distance;

			// Token: 0x04001897 RID: 6295
			[Token(Token = "0x4001897")]
			[FieldOffset(Offset = "0x1C")]
			public Vector2 _cellCenter;

			// Token: 0x04001898 RID: 6296
			[Token(Token = "0x4001898")]
			[FieldOffset(Offset = "0x28")]
			public List<Renderer> _renderers;
		}
	}
}
