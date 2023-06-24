using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Pathfinding.Util;
using UnityEngine;
using UnityEngine.Serialization;

namespace Pathfinding
{
	// Token: 0x020000E1 RID: 225
	[Token(Token = "0x20000E1")]
	[AddComponentMenu("Pathfinding/Navmesh/Navmesh Cut")]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_navmesh_cut.php")]
	public class NavmeshCut : NavmeshClipper
	{
		// Token: 0x060007D1 RID: 2001 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x6CCA10", Offset = "0x6CB010", VA = "0x1806CCA10", Slot = "7")]
		protected override void Awake()
		{
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x6CCAD0", Offset = "0x6CB0D0", VA = "0x1806CCAD0", Slot = "10")]
		protected override void OnEnable()
		{
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x6CCCB0", Offset = "0x6CB2B0", VA = "0x1806CCCB0", Slot = "15")]
		public override void ForceUpdate()
		{
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x00005AA4 File Offset: 0x00003CA4
		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x6CCCF0", Offset = "0x6CB2F0", VA = "0x1806CCCF0", Slot = "14")]
		public override bool RequiresUpdate()
		{
			return default(bool);
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "16")]
		public virtual void UsedForCut()
		{
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x6CCFA0", Offset = "0x6CB5A0", VA = "0x1806CCFA0")]
		public void CacheTransform()
		{
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x6CD050", Offset = "0x6CB650", VA = "0x1806CD050", Slot = "12")]
		internal override void NotifyUpdated()
		{
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x6CD160", Offset = "0x6CB760", VA = "0x1806CD160")]
		private void CalculateMeshContour()
		{
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x00005ABC File Offset: 0x00003CBC
		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x6CDAA0", Offset = "0x6CC0A0", VA = "0x1806CDAA0", Slot = "13")]
		public override Rect GetBounds(GraphTransform inverseTransform)
		{
			return default(Rect);
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x6CDDD0", Offset = "0x6CC3D0", VA = "0x1806CDDD0")]
		public void GetContour(List<List<Vector3>> buffer)
		{
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x6CE5F0", Offset = "0x6CCBF0", VA = "0x1806CE5F0")]
		private void TransformBuffer(List<Vector3> buffer, bool reverse)
		{
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x6CEAC0", Offset = "0x6CD0C0", VA = "0x1806CEAC0")]
		public void OnDrawGizmos()
		{
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x00005AD4 File Offset: 0x00003CD4
		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x6CEEA0", Offset = "0x6CD4A0", VA = "0x1806CEEA0")]
		internal float GetY(GraphTransform transform)
		{
			return 0f;
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x6CF030", Offset = "0x6CD630", VA = "0x1806CF030")]
		public void OnDrawGizmosSelected()
		{
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x6CF890", Offset = "0x6CDE90", VA = "0x1806CF890")]
		public NavmeshCut()
		{
		}

		// Token: 0x04000559 RID: 1369
		[Token(Token = "0x4000559")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("Shape of the cut")]
		public NavmeshCut.MeshType type;

		// Token: 0x0400055A RID: 1370
		[Token(Token = "0x400055A")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("The contour(s) of the mesh will be extracted. This mesh should only be a 2D surface, not a volume (see documentation).")]
		public Mesh mesh;

		// Token: 0x0400055B RID: 1371
		[Token(Token = "0x400055B")]
		[FieldOffset(Offset = "0x40")]
		public Vector2 rectangleSize;

		// Token: 0x0400055C RID: 1372
		[Token(Token = "0x400055C")]
		[FieldOffset(Offset = "0x48")]
		public float circleRadius;

		// Token: 0x0400055D RID: 1373
		[Token(Token = "0x400055D")]
		[FieldOffset(Offset = "0x4C")]
		public int circleResolution;

		// Token: 0x0400055E RID: 1374
		[Token(Token = "0x400055E")]
		[FieldOffset(Offset = "0x50")]
		public float height;

		// Token: 0x0400055F RID: 1375
		[Token(Token = "0x400055F")]
		[FieldOffset(Offset = "0x54")]
		[Tooltip("Scale of the custom mesh")]
		public float meshScale;

		// Token: 0x04000560 RID: 1376
		[Token(Token = "0x4000560")]
		[FieldOffset(Offset = "0x58")]
		public Vector3 center;

		// Token: 0x04000561 RID: 1377
		[Token(Token = "0x4000561")]
		[FieldOffset(Offset = "0x64")]
		[Tooltip("Distance between positions to require an update of the navmesh\nA smaller distance gives better accuracy, but requires more updates when moving the object over time, so it is often slower.")]
		public float updateDistance;

		// Token: 0x04000562 RID: 1378
		[Token(Token = "0x4000562")]
		[FieldOffset(Offset = "0x68")]
		[Tooltip("Only makes a split in the navmesh, but does not remove the geometry to make a hole")]
		public bool isDual;

		// Token: 0x04000563 RID: 1379
		[Token(Token = "0x4000563")]
		[FieldOffset(Offset = "0x69")]
		public bool cutsAddedGeom;

		// Token: 0x04000564 RID: 1380
		[Token(Token = "0x4000564")]
		[FieldOffset(Offset = "0x6C")]
		[Tooltip("How many degrees rotation that is required for an update to the navmesh. Should be between 0 and 180.")]
		public float updateRotationDistance;

		// Token: 0x04000565 RID: 1381
		[Token(Token = "0x4000565")]
		[FieldOffset(Offset = "0x70")]
		[FormerlySerializedAs("useRotation")]
		[Tooltip("Includes rotation in calculations. This is slower since a lot more matrix multiplications are needed but gives more flexibility.")]
		public bool useRotationAndScale;

		// Token: 0x04000566 RID: 1382
		[Token(Token = "0x4000566")]
		[FieldOffset(Offset = "0x78")]
		private Vector3[][] contours;

		// Token: 0x04000567 RID: 1383
		[Token(Token = "0x4000567")]
		[FieldOffset(Offset = "0x80")]
		protected Transform tr;

		// Token: 0x04000568 RID: 1384
		[Token(Token = "0x4000568")]
		[FieldOffset(Offset = "0x88")]
		private Mesh lastMesh;

		// Token: 0x04000569 RID: 1385
		[Token(Token = "0x4000569")]
		[FieldOffset(Offset = "0x90")]
		private Vector3 lastPosition;

		// Token: 0x0400056A RID: 1386
		[Token(Token = "0x400056A")]
		[FieldOffset(Offset = "0x9C")]
		private Quaternion lastRotation;

		// Token: 0x0400056B RID: 1387
		[Token(Token = "0x400056B")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<Int2, int> edges;

		// Token: 0x0400056C RID: 1388
		[Token(Token = "0x400056C")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<int, int> pointers;

		// Token: 0x0400056D RID: 1389
		[Token(Token = "0x400056D")]
		[FieldOffset(Offset = "0x10")]
		public static readonly Color GizmoColor;

		// Token: 0x020000E2 RID: 226
		[Token(Token = "0x20000E2")]
		public enum MeshType
		{
			// Token: 0x0400056F RID: 1391
			[Token(Token = "0x400056F")]
			Rectangle,
			// Token: 0x04000570 RID: 1392
			[Token(Token = "0x4000570")]
			Circle,
			// Token: 0x04000571 RID: 1393
			[Token(Token = "0x4000571")]
			CustomMesh
		}
	}
}
