using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000E0 RID: 224
[Token(Token = "0x20000E0")]
public class Octree
{
	// Token: 0x170000E0 RID: 224
	// (get) Token: 0x0600068B RID: 1675 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000E0")]
	public static Octree Instance
	{
		[Token(Token = "0x600068B")]
		[Address(RVA = "0x2E89270", Offset = "0x2E88270", VA = "0x182E89270")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600068C RID: 1676 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600068C")]
	[Address(RVA = "0x2E89070", Offset = "0x2E88070", VA = "0x182E89070")]
	public Octree(Vector3 center, Vector3 size)
	{
	}

	// Token: 0x0600068D RID: 1677 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600068D")]
	[Address(RVA = "0x2E88F30", Offset = "0x2E87F30", VA = "0x182E88F30")]
	public void Update(Transform t)
	{
	}

	// Token: 0x0600068E RID: 1678 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600068E")]
	[Address(RVA = "0x2E88F00", Offset = "0x2E87F00", VA = "0x182E88F00")]
	public void Purge()
	{
	}

	// Token: 0x0600068F RID: 1679 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600068F")]
	[Address(RVA = "0x2E87AD0", Offset = "0x2E86AD0", VA = "0x182E87AD0")]
	private void Clear(Octree.Node n)
	{
	}

	// Token: 0x06000690 RID: 1680 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000690")]
	[Address(RVA = "0x2E88B10", Offset = "0x2E87B10", VA = "0x182E88B10")]
	private void Purge(Octree.Node n)
	{
	}

	// Token: 0x06000691 RID: 1681 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000691")]
	[Address(RVA = "0x2E887B0", Offset = "0x2E877B0", VA = "0x182E887B0")]
	private void Insert(Octree.Node n, Transform t, int id, Vector3 p)
	{
	}

	// Token: 0x06000692 RID: 1682 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000692")]
	[Address(RVA = "0x2E87DA0", Offset = "0x2E86DA0", VA = "0x182E87DA0")]
	private void Divide(Octree.Node n)
	{
	}

	// Token: 0x06000693 RID: 1683 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000693")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	public void Draw()
	{
	}

	// Token: 0x06000694 RID: 1684 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000694")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	private void Draw(Octree.Node n, bool empty)
	{
	}

	// Token: 0x04000584 RID: 1412
	[Token(Token = "0x4000584")]
	private const int MAX_DEPTH = 7;

	// Token: 0x04000585 RID: 1413
	[Token(Token = "0x4000585")]
	private const int MAX_OBJECTS = 8;

	// Token: 0x04000586 RID: 1414
	[Token(Token = "0x4000586")]
	private const int XN_YN_ZN = 0;

	// Token: 0x04000587 RID: 1415
	[Token(Token = "0x4000587")]
	private const int XP_YN_ZN = 1;

	// Token: 0x04000588 RID: 1416
	[Token(Token = "0x4000588")]
	private const int XN_YP_ZN = 2;

	// Token: 0x04000589 RID: 1417
	[Token(Token = "0x4000589")]
	private const int XP_YP_ZN = 3;

	// Token: 0x0400058A RID: 1418
	[Token(Token = "0x400058A")]
	private const int XN_YN_ZP = 4;

	// Token: 0x0400058B RID: 1419
	[Token(Token = "0x400058B")]
	private const int XP_YN_ZP = 5;

	// Token: 0x0400058C RID: 1420
	[Token(Token = "0x400058C")]
	private const int XN_YP_ZP = 6;

	// Token: 0x0400058D RID: 1421
	[Token(Token = "0x400058D")]
	private const int XP_YP_ZP = 7;

	// Token: 0x0400058E RID: 1422
	[Token(Token = "0x400058E")]
	[FieldOffset(Offset = "0x10")]
	private Octree.Node root;

	// Token: 0x0400058F RID: 1423
	[Token(Token = "0x400058F")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<int, Octree.Node> nodes;

	// Token: 0x04000590 RID: 1424
	[Token(Token = "0x4000590")]
	[FieldOffset(Offset = "0x0")]
	private static Octree _instance;

	// Token: 0x04000591 RID: 1425
	[Token(Token = "0x4000591")]
	[FieldOffset(Offset = "0x20")]
	private List<int> clearList;

	// Token: 0x020000E1 RID: 225
	[Token(Token = "0x20000E1")]
	private struct Collidable
	{
		// Token: 0x04000592 RID: 1426
		[Token(Token = "0x4000592")]
		[FieldOffset(Offset = "0x0")]
		public int InstanceId;

		// Token: 0x04000593 RID: 1427
		[Token(Token = "0x4000593")]
		[FieldOffset(Offset = "0x8")]
		public Transform Transform;
	}

	// Token: 0x020000E2 RID: 226
	[Token(Token = "0x20000E2")]
	private class Node
	{
		// Token: 0x06000695 RID: 1685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000695")]
		[Address(RVA = "0x2E87670", Offset = "0x2E86670", VA = "0x182E87670")]
		public Node(Octree tree, Octree.Node parent, Vector3 center, Vector3 extents, int level)
		{
		}

		// Token: 0x04000594 RID: 1428
		[Token(Token = "0x4000594")]
		[FieldOffset(Offset = "0x10")]
		public readonly Octree Tree;

		// Token: 0x04000595 RID: 1429
		[Token(Token = "0x4000595")]
		[FieldOffset(Offset = "0x18")]
		public readonly Octree.Node Parent;

		// Token: 0x04000596 RID: 1430
		[Token(Token = "0x4000596")]
		[FieldOffset(Offset = "0x20")]
		public readonly Vector3 Center;

		// Token: 0x04000597 RID: 1431
		[Token(Token = "0x4000597")]
		[FieldOffset(Offset = "0x2C")]
		public readonly Vector3 Extents;

		// Token: 0x04000598 RID: 1432
		[Token(Token = "0x4000598")]
		[FieldOffset(Offset = "0x38")]
		public readonly int Level;

		// Token: 0x04000599 RID: 1433
		[Token(Token = "0x4000599")]
		[FieldOffset(Offset = "0x40")]
		public Octree.Node[] Children;

		// Token: 0x0400059A RID: 1434
		[Token(Token = "0x400059A")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<int, Transform> Transforms;
	}
}
