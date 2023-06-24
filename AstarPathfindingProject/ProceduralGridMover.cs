using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x0200007D RID: 125
	[Token(Token = "0x200007D")]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_procedural_grid_mover.php")]
	public class ProceduralGridMover : VersionedMonoBehaviour
	{
		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060004A9 RID: 1193 RVA: 0x0000452C File Offset: 0x0000272C
		// (set) Token: 0x060004AA RID: 1194 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000E8")]
		public bool updatingGraph
		{
			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x674880", Offset = "0x672E80", VA = "0x180674880")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004AA")]
			[Address(RVA = "0x674890", Offset = "0x672E90", VA = "0x180674890")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x6748A0", Offset = "0x672EA0", VA = "0x1806748A0")]
		private void Start()
		{
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x674D60", Offset = "0x673360", VA = "0x180674D60")]
		private void Update()
		{
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00004544 File Offset: 0x00002744
		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x674EC0", Offset = "0x6734C0", VA = "0x180674EC0")]
		private Vector3 PointToGraphSpace(Vector3 p)
		{
			return default(Vector3);
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x674F20", Offset = "0x673520", VA = "0x180674F20")]
		public void UpdateGraph()
		{
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x675170", Offset = "0x673770", VA = "0x180675170")]
		private IEnumerator UpdateGraphCoroutine()
		{
			return null;
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x675200", Offset = "0x673800", VA = "0x180675200")]
		public ProceduralGridMover()
		{
		}

		// Token: 0x04000315 RID: 789
		[Token(Token = "0x4000315")]
		[FieldOffset(Offset = "0x28")]
		public float updateDistance;

		// Token: 0x04000316 RID: 790
		[Token(Token = "0x4000316")]
		[FieldOffset(Offset = "0x30")]
		public Transform target;

		// Token: 0x04000317 RID: 791
		[Token(Token = "0x4000317")]
		[FieldOffset(Offset = "0x38")]
		private GridNodeBase[] buffer;

		// Token: 0x04000319 RID: 793
		[Token(Token = "0x4000319")]
		[FieldOffset(Offset = "0x48")]
		public GridGraph graph;

		// Token: 0x0400031A RID: 794
		[Token(Token = "0x400031A")]
		[FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public int graphIndex;
	}
}
