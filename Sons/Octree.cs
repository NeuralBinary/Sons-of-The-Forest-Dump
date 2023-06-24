using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000DE RID: 222
[Token(Token = "0x20000DE")]
public class Octree
{
	// Token: 0x170000E7 RID: 231
	// (get) Token: 0x060006D6 RID: 1750 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000E7")]
	public static Octree Instance
	{
		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x3526EF0", Offset = "0x35254F0", VA = "0x183526EF0")]
		get
		{
			return null;
		}
	}

	// Token: 0x060006D7 RID: 1751 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006D7")]
	[Address(RVA = "0x3527060", Offset = "0x3525660", VA = "0x183527060")]
	public Octree(Vector3 center, Vector3 size)
	{
	}

	// Token: 0x060006D8 RID: 1752 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006D8")]
	[Address(RVA = "0x35272F0", Offset = "0x35258F0", VA = "0x1835272F0")]
	public void Update(Transform t)
	{
	}

	// Token: 0x060006D9 RID: 1753 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006D9")]
	[Address(RVA = "0x3527470", Offset = "0x3525A70", VA = "0x183527470")]
	public void Purge()
	{
	}

	// Token: 0x060006DA RID: 1754 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006DA")]
	[Address(RVA = "0x35274A0", Offset = "0x3525AA0", VA = "0x1835274A0")]
	private void Clear(Octree.Node n)
	{
	}

	// Token: 0x060006DB RID: 1755 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006DB")]
	[Address(RVA = "0x3527820", Offset = "0x3525E20", VA = "0x183527820")]
	private void Purge(Octree.Node n)
	{
	}

	// Token: 0x060006DC RID: 1756 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006DC")]
	[Address(RVA = "0x3527C10", Offset = "0x3526210", VA = "0x183527C10")]
	private void Insert(Octree.Node n, Transform t, int id, Vector3 p)
	{
	}

	// Token: 0x060006DD RID: 1757 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006DD")]
	[Address(RVA = "0x35280C0", Offset = "0x35266C0", VA = "0x1835280C0")]
	private void Divide(Octree.Node n)
	{
	}

	// Token: 0x060006DE RID: 1758 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006DE")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	public void Draw()
	{
	}

	// Token: 0x060006DF RID: 1759 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006DF")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void Draw(Octree.Node n, bool empty)
	{
	}

	// Token: 0x040005A1 RID: 1441
	[Token(Token = "0x40005A1")]
	private const int MAX_DEPTH = 7;

	// Token: 0x040005A2 RID: 1442
	[Token(Token = "0x40005A2")]
	private const int MAX_OBJECTS = 8;

	// Token: 0x040005A3 RID: 1443
	[Token(Token = "0x40005A3")]
	private const int XN_YN_ZN = 0;

	// Token: 0x040005A4 RID: 1444
	[Token(Token = "0x40005A4")]
	private const int XP_YN_ZN = 1;

	// Token: 0x040005A5 RID: 1445
	[Token(Token = "0x40005A5")]
	private const int XN_YP_ZN = 2;

	// Token: 0x040005A6 RID: 1446
	[Token(Token = "0x40005A6")]
	private const int XP_YP_ZN = 3;

	// Token: 0x040005A7 RID: 1447
	[Token(Token = "0x40005A7")]
	private const int XN_YN_ZP = 4;

	// Token: 0x040005A8 RID: 1448
	[Token(Token = "0x40005A8")]
	private const int XP_YN_ZP = 5;

	// Token: 0x040005A9 RID: 1449
	[Token(Token = "0x40005A9")]
	private const int XN_YP_ZP = 6;

	// Token: 0x040005AA RID: 1450
	[Token(Token = "0x40005AA")]
	private const int XP_YP_ZP = 7;

	// Token: 0x040005AB RID: 1451
	[Token(Token = "0x40005AB")]
	[FieldOffset(Offset = "0x10")]
	private Octree.Node root;

	// Token: 0x040005AC RID: 1452
	[Token(Token = "0x40005AC")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<int, Octree.Node> nodes;

	// Token: 0x040005AD RID: 1453
	[Token(Token = "0x40005AD")]
	[FieldOffset(Offset = "0x0")]
	private static Octree _instance;

	// Token: 0x040005AE RID: 1454
	[Token(Token = "0x40005AE")]
	[FieldOffset(Offset = "0x20")]
	private List<int> clearList;

	// Token: 0x020000DF RID: 223
	[Token(Token = "0x20000DF")]
	private struct Collidable
	{
		// Token: 0x040005AF RID: 1455
		[Token(Token = "0x40005AF")]
		[FieldOffset(Offset = "0x0")]
		public int InstanceId;

		// Token: 0x040005B0 RID: 1456
		[Token(Token = "0x40005B0")]
		[FieldOffset(Offset = "0x8")]
		public Transform Transform;
	}

	// Token: 0x020000E0 RID: 224
	[Token(Token = "0x20000E0")]
	private class Node
	{
		// Token: 0x060006E0 RID: 1760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x3528810", Offset = "0x3526E10", VA = "0x183528810")]
		public Node(Octree tree, Octree.Node parent, Vector3 center, Vector3 extents, int level)
		{
		}

		// Token: 0x040005B1 RID: 1457
		[Token(Token = "0x40005B1")]
		[FieldOffset(Offset = "0x10")]
		public readonly Octree Tree;

		// Token: 0x040005B2 RID: 1458
		[Token(Token = "0x40005B2")]
		[FieldOffset(Offset = "0x18")]
		public readonly Octree.Node Parent;

		// Token: 0x040005B3 RID: 1459
		[Token(Token = "0x40005B3")]
		[FieldOffset(Offset = "0x20")]
		public readonly Vector3 Center;

		// Token: 0x040005B4 RID: 1460
		[Token(Token = "0x40005B4")]
		[FieldOffset(Offset = "0x2C")]
		public readonly Vector3 Extents;

		// Token: 0x040005B5 RID: 1461
		[Token(Token = "0x40005B5")]
		[FieldOffset(Offset = "0x38")]
		public readonly int Level;

		// Token: 0x040005B6 RID: 1462
		[Token(Token = "0x40005B6")]
		[FieldOffset(Offset = "0x40")]
		public Octree.Node[] Children;

		// Token: 0x040005B7 RID: 1463
		[Token(Token = "0x40005B7")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<int, Transform> Transforms;
	}
}
