using System;
using System.Collections;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200017D RID: 381
	[Token(Token = "0x200017D")]
	public class MarchingQuads
	{
		// Token: 0x06000A18 RID: 2584 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A18")]
		[Address(RVA = "0x1FF5510", Offset = "0x1FF3B10", VA = "0x181FF5510")]
		public MarchingQuads(int nSubdivisions, AxisAlignedBox2f bounds, float fIsoValue)
		{
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x00007964 File Offset: 0x00005B64
		// (set) Token: 0x06000A1A RID: 2586 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001C3")]
		public int Subdivisions
		{
			[Token(Token = "0x6000A19")]
			[Address(RVA = "0x716CD0", Offset = "0x7152D0", VA = "0x180716CD0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000A1A")]
			[Address(RVA = "0x1FF5AF0", Offset = "0x1FF40F0", VA = "0x181FF5AF0")]
			set
			{
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000A1B RID: 2587 RVA: 0x0000797C File Offset: 0x00005B7C
		// (set) Token: 0x06000A1C RID: 2588 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001C4")]
		public AxisAlignedBox2f Bounds
		{
			[Token(Token = "0x6000A1B")]
			[Address(RVA = "0x61A590", Offset = "0x618B90", VA = "0x18061A590")]
			get
			{
				return default(AxisAlignedBox2f);
			}
			[Token(Token = "0x6000A1C")]
			[Address(RVA = "0x1FF5D50", Offset = "0x1FF4350", VA = "0x181FF5D50")]
			set
			{
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000A1D RID: 2589 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170001C5")]
		public DPolyLine2f Stroke
		{
			[Token(Token = "0x6000A1D")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x00007994 File Offset: 0x00005B94
		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0x61A590", Offset = "0x618B90", VA = "0x18061A590")]
		public AxisAlignedBox2f GetBounds()
		{
			return default(AxisAlignedBox2f);
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0x1FF5FB0", Offset = "0x1FF45B0", VA = "0x181FF5FB0")]
		public void AddSeedPoint(float x, float y)
		{
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A20")]
		[Address(RVA = "0x1FF6050", Offset = "0x1FF4650", VA = "0x181FF6050")]
		public void ClearSeedPoints()
		{
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A21")]
		[Address(RVA = "0x1FF6080", Offset = "0x1FF4680", VA = "0x181FF6080")]
		public void ClearStroke()
		{
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A22")]
		[Address(RVA = "0x1FF60F0", Offset = "0x1FF46F0", VA = "0x181FF60F0")]
		public void Polygonize(ImplicitField2d field)
		{
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A23")]
		[Address(RVA = "0x1FF6500", Offset = "0x1FF4B00", VA = "0x181FF6500")]
		private void SubdivideStep(ref float fValue1, ref float fValue2, ref float fX1, ref float fY1, ref float fX2, ref float fY2, bool bVerticalEdge)
		{
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x000079AC File Offset: 0x00005BAC
		[Token(Token = "0x6000A24")]
		[Address(RVA = "0x1FF6630", Offset = "0x1FF4C30", VA = "0x181FF6630")]
		private int LerpAndAddStrokeVertex(float fValue1, float fValue2, int x1, int y1, int x2, int y2, bool bVerticalEdge)
		{
			return 0;
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x000079C4 File Offset: 0x00005BC4
		[Token(Token = "0x6000A25")]
		[Address(RVA = "0x1FF68A0", Offset = "0x1FF4EA0", VA = "0x181FF68A0")]
		private int GetLeftEdgeVertex(int xi, int yi)
		{
			return 0;
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x000079DC File Offset: 0x00005BDC
		[Token(Token = "0x6000A26")]
		[Address(RVA = "0x1FF69F0", Offset = "0x1FF4FF0", VA = "0x181FF69F0")]
		private int GetRightEdgeVertex(int xi, int yi)
		{
			return 0;
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x000079F4 File Offset: 0x00005BF4
		[Token(Token = "0x6000A27")]
		[Address(RVA = "0x1FF6B50", Offset = "0x1FF5150", VA = "0x181FF6B50")]
		private int GetTopEdgeVertex(int xi, int yi)
		{
			return 0;
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x00007A0C File Offset: 0x00005C0C
		[Token(Token = "0x6000A28")]
		[Address(RVA = "0x1FF6CB0", Offset = "0x1FF52B0", VA = "0x181FF6CB0")]
		private int GetBottomEdgeVertex(int xi, int yi)
		{
			return 0;
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x00007A24 File Offset: 0x00005C24
		[Token(Token = "0x6000A29")]
		[Address(RVA = "0x1FF6E10", Offset = "0x1FF5410", VA = "0x181FF6E10")]
		private bool ProcessCell(int xi, int yi)
		{
			return default(bool);
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0x1FF7DE0", Offset = "0x1FF63E0", VA = "0x181FF7DE0")]
		private void ResetCells()
		{
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0x1FF7EC0", Offset = "0x1FF64C0", VA = "0x181FF7EC0")]
		private void InitializeCells()
		{
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0x1FF80A0", Offset = "0x1FF66A0", VA = "0x181FF80A0")]
		private void SetBounds(AxisAlignedBox2f bounds)
		{
		}

		// Token: 0x040005A8 RID: 1448
		[Token(Token = "0x40005A8")]
		[FieldOffset(Offset = "0x10")]
		private DPolyLine2f m_stroke;

		// Token: 0x040005A9 RID: 1449
		[Token(Token = "0x40005A9")]
		[FieldOffset(Offset = "0x18")]
		private AxisAlignedBox2f m_bounds;

		// Token: 0x040005AA RID: 1450
		[Token(Token = "0x40005AA")]
		[FieldOffset(Offset = "0x28")]
		private float m_fXShift;

		// Token: 0x040005AB RID: 1451
		[Token(Token = "0x40005AB")]
		[FieldOffset(Offset = "0x2C")]
		private float m_fYShift;

		// Token: 0x040005AC RID: 1452
		[Token(Token = "0x40005AC")]
		[FieldOffset(Offset = "0x30")]
		private float m_fScale;

		// Token: 0x040005AD RID: 1453
		[Token(Token = "0x40005AD")]
		[FieldOffset(Offset = "0x34")]
		private int m_nCells;

		// Token: 0x040005AE RID: 1454
		[Token(Token = "0x40005AE")]
		[FieldOffset(Offset = "0x38")]
		private float m_fCellSize;

		// Token: 0x040005AF RID: 1455
		[Token(Token = "0x40005AF")]
		[FieldOffset(Offset = "0x0")]
		private static float s_fValueSentinel;

		// Token: 0x040005B0 RID: 1456
		[Token(Token = "0x40005B0")]
		[FieldOffset(Offset = "0x3C")]
		private float m_fIsoValue;

		// Token: 0x040005B1 RID: 1457
		[Token(Token = "0x40005B1")]
		[FieldOffset(Offset = "0x4")]
		private static int LEFT;

		// Token: 0x040005B2 RID: 1458
		[Token(Token = "0x40005B2")]
		[FieldOffset(Offset = "0x8")]
		private static int TOP;

		// Token: 0x040005B3 RID: 1459
		[Token(Token = "0x40005B3")]
		[FieldOffset(Offset = "0xC")]
		private static int RIGHT;

		// Token: 0x040005B4 RID: 1460
		[Token(Token = "0x40005B4")]
		[FieldOffset(Offset = "0x10")]
		private static int BOTTOM;

		// Token: 0x040005B5 RID: 1461
		[Token(Token = "0x40005B5")]
		[FieldOffset(Offset = "0x14")]
		private static int ALL;

		// Token: 0x040005B6 RID: 1462
		[Token(Token = "0x40005B6")]
		[FieldOffset(Offset = "0x40")]
		private MarchingQuads.Cell[][] m_cells;

		// Token: 0x040005B7 RID: 1463
		[Token(Token = "0x40005B7")]
		[FieldOffset(Offset = "0x48")]
		private ArrayList m_seedPoints;

		// Token: 0x040005B8 RID: 1464
		[Token(Token = "0x40005B8")]
		[FieldOffset(Offset = "0x50")]
		private ImplicitField2d m_field;

		// Token: 0x040005B9 RID: 1465
		[Token(Token = "0x40005B9")]
		[FieldOffset(Offset = "0x58")]
		private ArrayList m_cellStack;

		// Token: 0x040005BA RID: 1466
		[Token(Token = "0x40005BA")]
		[FieldOffset(Offset = "0x60")]
		private bool[] m_bEdgeSigns;

		// Token: 0x0200017E RID: 382
		[Token(Token = "0x200017E")]
		private struct Cell
		{
			// Token: 0x06000A2E RID: 2606 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000A2E")]
			[Address(RVA = "0x1FF81F0", Offset = "0x1FF67F0", VA = "0x181FF81F0")]
			public void Initialize(uint x, uint y)
			{
			}

			// Token: 0x170001C6 RID: 454
			// (get) Token: 0x06000A2F RID: 2607 RVA: 0x00007A3C File Offset: 0x00005C3C
			// (set) Token: 0x06000A30 RID: 2608 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x170001C6")]
			public uint x
			{
				[Token(Token = "0x6000A2F")]
				[Address(RVA = "0x9895D0", Offset = "0x987BD0", VA = "0x1809895D0")]
				get
				{
					return 0U;
				}
				[Token(Token = "0x6000A30")]
				[Address(RVA = "0x1FF8280", Offset = "0x1FF6880", VA = "0x181FF8280")]
				set
				{
				}
			}

			// Token: 0x170001C7 RID: 455
			// (get) Token: 0x06000A31 RID: 2609 RVA: 0x00007A54 File Offset: 0x00005C54
			// (set) Token: 0x06000A32 RID: 2610 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x170001C7")]
			public uint y
			{
				[Token(Token = "0x6000A31")]
				[Address(RVA = "0x9895B0", Offset = "0x987BB0", VA = "0x1809895B0")]
				get
				{
					return 0U;
				}
				[Token(Token = "0x6000A32")]
				[Address(RVA = "0x1FF82A0", Offset = "0x1FF68A0", VA = "0x181FF82A0")]
				set
				{
				}
			}

			// Token: 0x040005BB RID: 1467
			[Token(Token = "0x40005BB")]
			[FieldOffset(Offset = "0x0")]
			private uint nPosition;

			// Token: 0x040005BC RID: 1468
			[Token(Token = "0x40005BC")]
			[FieldOffset(Offset = "0x4")]
			public float fValue;

			// Token: 0x040005BD RID: 1469
			[Token(Token = "0x40005BD")]
			[FieldOffset(Offset = "0x8")]
			public int nLeftVertex;

			// Token: 0x040005BE RID: 1470
			[Token(Token = "0x40005BE")]
			[FieldOffset(Offset = "0xC")]
			public int nTopVertex;

			// Token: 0x040005BF RID: 1471
			[Token(Token = "0x40005BF")]
			[FieldOffset(Offset = "0x10")]
			public bool bTouched;
		}

		// Token: 0x0200017F RID: 383
		[Token(Token = "0x200017F")]
		private struct SeedPoint
		{
			// Token: 0x06000A33 RID: 2611 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000A33")]
			[Address(RVA = "0x5B25C0", Offset = "0x5B0BC0", VA = "0x1805B25C0")]
			public SeedPoint(float fX, float fY)
			{
			}

			// Token: 0x040005C0 RID: 1472
			[Token(Token = "0x40005C0")]
			[FieldOffset(Offset = "0x0")]
			public float x;

			// Token: 0x040005C1 RID: 1473
			[Token(Token = "0x40005C1")]
			[FieldOffset(Offset = "0x4")]
			public float y;
		}
	}
}
