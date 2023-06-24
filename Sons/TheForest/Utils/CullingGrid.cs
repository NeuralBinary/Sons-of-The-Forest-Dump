using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.Utils
{
	// Token: 0x020003A6 RID: 934
	[Token(Token = "0x20003A6")]
	[Obsolete]
	public class CullingGrid : MonoBehaviour
	{
		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06001911 RID: 6417 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001912 RID: 6418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000359")]
		public static CullingGrid Instance
		{
			[Token(Token = "0x6001911")]
			[Address(RVA = "0x328DFA0", Offset = "0x328C5A0", VA = "0x18328DFA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001912")]
			[Address(RVA = "0x328DFE0", Offset = "0x328C5E0", VA = "0x18328DFE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001913 RID: 6419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001913")]
		[Address(RVA = "0x328E070", Offset = "0x328C670", VA = "0x18328E070")]
		private void Awake()
		{
		}

		// Token: 0x06001914 RID: 6420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001914")]
		[Address(RVA = "0x328E4F0", Offset = "0x328CAF0", VA = "0x18328E4F0")]
		private void Update()
		{
		}

		// Token: 0x06001915 RID: 6421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001915")]
		[Address(RVA = "0x328EED0", Offset = "0x328D4D0", VA = "0x18328EED0")]
		private void OnEnable()
		{
		}

		// Token: 0x06001916 RID: 6422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001916")]
		[Address(RVA = "0x328F020", Offset = "0x328D620", VA = "0x18328F020")]
		private void OnDisable()
		{
		}

		// Token: 0x06001917 RID: 6423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001917")]
		[Address(RVA = "0x328F170", Offset = "0x328D770", VA = "0x18328F170")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001918 RID: 6424 RVA: 0x00007A70 File Offset: 0x00005C70
		[Token(Token = "0x6001918")]
		[Address(RVA = "0x328F2B0", Offset = "0x328D8B0", VA = "0x18328F2B0")]
		public static int Register(Renderer r)
		{
			return 0;
		}

		// Token: 0x06001919 RID: 6425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001919")]
		[Address(RVA = "0x328F310", Offset = "0x328D910", VA = "0x18328F310")]
		public static void Unregister(Renderer r, int token)
		{
		}

		// Token: 0x0600191A RID: 6426 RVA: 0x00007A88 File Offset: 0x00005C88
		[Token(Token = "0x600191A")]
		[Address(RVA = "0x328F510", Offset = "0x328DB10", VA = "0x18328F510")]
		private int RegisterInternal(Renderer r)
		{
			return 0;
		}

		// Token: 0x0600191B RID: 6427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600191B")]
		[Address(RVA = "0x328F760", Offset = "0x328DD60", VA = "0x18328F760")]
		private void UnregisterInternal(Renderer r, int token)
		{
		}

		// Token: 0x0600191C RID: 6428 RVA: 0x00007AA0 File Offset: 0x00005CA0
		[Token(Token = "0x600191C")]
		[Address(RVA = "0x328F810", Offset = "0x328DE10", VA = "0x18328F810")]
		private int WorldToGridX(float xPosition)
		{
			return 0;
		}

		// Token: 0x0600191D RID: 6429 RVA: 0x00007AB8 File Offset: 0x00005CB8
		[Token(Token = "0x600191D")]
		[Address(RVA = "0x328F830", Offset = "0x328DE30", VA = "0x18328F830")]
		private int WorldToGridY(float zPosition)
		{
			return 0;
		}

		// Token: 0x0600191E RID: 6430 RVA: 0x00007AD0 File Offset: 0x00005CD0
		[Token(Token = "0x600191E")]
		[Address(RVA = "0x328F850", Offset = "0x328DE50", VA = "0x18328F850")]
		private int WorldToGridXRounded(float xPosition)
		{
			return 0;
		}

		// Token: 0x0600191F RID: 6431 RVA: 0x00007AE8 File Offset: 0x00005CE8
		[Token(Token = "0x600191F")]
		[Address(RVA = "0x328F870", Offset = "0x328DE70", VA = "0x18328F870")]
		private int WorldToGridYRounded(float zPosition)
		{
			return 0;
		}

		// Token: 0x06001920 RID: 6432 RVA: 0x00007B00 File Offset: 0x00005D00
		[Token(Token = "0x6001920")]
		[Address(RVA = "0x328F890", Offset = "0x328DE90", VA = "0x18328F890")]
		private float GridToWorldX(float xPosition)
		{
			return 0f;
		}

		// Token: 0x06001921 RID: 6433 RVA: 0x00007B18 File Offset: 0x00005D18
		[Token(Token = "0x6001921")]
		[Address(RVA = "0x328F8A0", Offset = "0x328DEA0", VA = "0x18328F8A0")]
		private float GridToWorldZ(float yPosition)
		{
			return 0f;
		}

		// Token: 0x06001922 RID: 6434 RVA: 0x00007B30 File Offset: 0x00005D30
		[Token(Token = "0x6001922")]
		[Address(RVA = "0x328F8B0", Offset = "0x328DEB0", VA = "0x18328F8B0")]
		private Vector2 GridCenterToWorld(int x, int y)
		{
			return default(Vector2);
		}

		// Token: 0x06001923 RID: 6435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001923")]
		[Address(RVA = "0x328F900", Offset = "0x328DF00", VA = "0x18328F900")]
		public CullingGrid()
		{
		}

		// Token: 0x040018A4 RID: 6308
		[Token(Token = "0x40018A4")]
		[FieldOffset(Offset = "0x20")]
		public int _gridSize;

		// Token: 0x040018A5 RID: 6309
		[Token(Token = "0x40018A5")]
		[FieldOffset(Offset = "0x24")]
		public float _gridWorldSize;

		// Token: 0x040018A6 RID: 6310
		[Token(Token = "0x40018A6")]
		[FieldOffset(Offset = "0x28")]
		public float _onRadius;

		// Token: 0x040018A7 RID: 6311
		[Token(Token = "0x40018A7")]
		[FieldOffset(Offset = "0x2C")]
		[Header("Gizmos")]
		public bool _showGrid;

		// Token: 0x040018A8 RID: 6312
		[Token(Token = "0x40018A8")]
		[FieldOffset(Offset = "0x2D")]
		public bool _showRendererDensity;

		// Token: 0x040018A9 RID: 6313
		[Token(Token = "0x40018A9")]
		[FieldOffset(Offset = "0x30")]
		public float _highestCellRendererCount;

		// Token: 0x040018AA RID: 6314
		[Token(Token = "0x40018AA")]
		[FieldOffset(Offset = "0x34")]
		public float _highestCellInRangeRendererCount;

		// Token: 0x040018AB RID: 6315
		[Token(Token = "0x40018AB")]
		[FieldOffset(Offset = "0x38")]
		public float _currentlyInRadiusRendererCount;

		// Token: 0x040018AD RID: 6317
		[Token(Token = "0x40018AD")]
		[FieldOffset(Offset = "0x3C")]
		private Vector2 _offset;

		// Token: 0x040018AE RID: 6318
		[Token(Token = "0x40018AE")]
		[FieldOffset(Offset = "0x48")]
		private CullingGrid.Cell[,] _rendererGrid;

		// Token: 0x040018AF RID: 6319
		[Token(Token = "0x40018AF")]
		[FieldOffset(Offset = "0x50")]
		private Vector2 _circlePosition;

		// Token: 0x040018B0 RID: 6320
		[Token(Token = "0x40018B0")]
		[FieldOffset(Offset = "0x58")]
		private List<CullingGrid.Cell> _activeCells;

		// Token: 0x040018B1 RID: 6321
		[Token(Token = "0x40018B1")]
		[FieldOffset(Offset = "0x60")]
		private List<CullingGrid.Cell> _workCells;

		// Token: 0x040018B2 RID: 6322
		[Token(Token = "0x40018B2")]
		[FieldOffset(Offset = "0x68")]
		private int _frameCount;

		// Token: 0x020003A7 RID: 935
		[Token(Token = "0x20003A7")]
		public class Cell
		{
			// Token: 0x06001924 RID: 6436 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001924")]
			[Address(RVA = "0x328F960", Offset = "0x328DF60", VA = "0x18328F960")]
			public Cell()
			{
			}

			// Token: 0x040018B3 RID: 6323
			[Token(Token = "0x40018B3")]
			[FieldOffset(Offset = "0x10")]
			public bool _enabled;

			// Token: 0x040018B4 RID: 6324
			[Token(Token = "0x40018B4")]
			[FieldOffset(Offset = "0x14")]
			public int _activeAt;

			// Token: 0x040018B5 RID: 6325
			[Token(Token = "0x40018B5")]
			[FieldOffset(Offset = "0x18")]
			public float _distance;

			// Token: 0x040018B6 RID: 6326
			[Token(Token = "0x40018B6")]
			[FieldOffset(Offset = "0x1C")]
			public Vector2 _cellCenter;

			// Token: 0x040018B7 RID: 6327
			[Token(Token = "0x40018B7")]
			[FieldOffset(Offset = "0x28")]
			public List<Renderer> _renderers;
		}
	}
}
