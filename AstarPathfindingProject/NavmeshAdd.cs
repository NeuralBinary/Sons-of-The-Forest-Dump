using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Pathfinding.Util;
using UnityEngine;
using UnityEngine.Serialization;

namespace Pathfinding
{
	// Token: 0x020000DE RID: 222
	[Token(Token = "0x20000DE")]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_navmesh_add.php")]
	public class NavmeshAdd : NavmeshClipper
	{
		// Token: 0x060007BC RID: 1980 RVA: 0x00005A5C File Offset: 0x00003C5C
		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x6CA9B0", Offset = "0x6C8FB0", VA = "0x1806CA9B0", Slot = "14")]
		public override bool RequiresUpdate()
		{
			return default(bool);
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x6CABB0", Offset = "0x6C91B0", VA = "0x1806CABB0", Slot = "15")]
		public override void ForceUpdate()
		{
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x6CABF0", Offset = "0x6C91F0", VA = "0x1806CABF0", Slot = "7")]
		protected override void Awake()
		{
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x6CACA0", Offset = "0x6C92A0", VA = "0x1806CACA0", Slot = "12")]
		internal override void NotifyUpdated()
		{
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060007C0 RID: 1984 RVA: 0x00005A74 File Offset: 0x00003C74
		[Token(Token = "0x17000135")]
		public Vector3 Center
		{
			[Token(Token = "0x60007C0")]
			[Address(RVA = "0x6CADA0", Offset = "0x6C93A0", VA = "0x1806CADA0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x6CAF10", Offset = "0x6C9510", VA = "0x1806CAF10")]
		[ContextMenu("Rebuild Mesh")]
		public void RebuildMesh()
		{
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x00005A8C File Offset: 0x00003C8C
		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x6CB480", Offset = "0x6C9A80", VA = "0x1806CB480", Slot = "13")]
		public override Rect GetBounds(GraphTransform inverseTransform)
		{
			return default(Rect);
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x6CB790", Offset = "0x6C9D90", VA = "0x1806CB790")]
		public void GetMesh(ref Int3[] vbuffer, out int[] tbuffer, [Optional] GraphTransform inverseTransform)
		{
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x6CC000", Offset = "0x6CA600", VA = "0x1806CC000")]
		public NavmeshAdd()
		{
		}

		// Token: 0x04000543 RID: 1347
		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public NavmeshAdd.MeshType type;

		// Token: 0x04000544 RID: 1348
		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Mesh mesh;

		// Token: 0x04000545 RID: 1349
		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3[] verts;

		// Token: 0x04000546 RID: 1350
		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int[] tris;

		// Token: 0x04000547 RID: 1351
		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector2 rectangleSize;

		// Token: 0x04000548 RID: 1352
		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float meshScale;

		// Token: 0x04000549 RID: 1353
		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 center;

		// Token: 0x0400054A RID: 1354
		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[FormerlySerializedAs("useRotation")]
		public bool useRotationAndScale;

		// Token: 0x0400054B RID: 1355
		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Tooltip("Distance between positions to require an update of the navmesh\nA smaller distance gives better accuracy, but requires more updates when moving the object over time, so it is often slower.")]
		public float updateDistance;

		// Token: 0x0400054C RID: 1356
		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("How many degrees rotation that is required for an update to the navmesh. Should be between 0 and 180.")]
		public float updateRotationDistance;

		// Token: 0x0400054D RID: 1357
		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Transform tr;

		// Token: 0x0400054E RID: 1358
		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 lastPosition;

		// Token: 0x0400054F RID: 1359
		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Quaternion lastRotation;

		// Token: 0x04000550 RID: 1360
		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Color GizmoColor;

		// Token: 0x020000DF RID: 223
		[Token(Token = "0x20000DF")]
		public enum MeshType
		{
			// Token: 0x04000552 RID: 1362
			[Token(Token = "0x4000552")]
			Rectangle,
			// Token: 0x04000553 RID: 1363
			[Token(Token = "0x4000553")]
			CustomMesh
		}
	}
}
