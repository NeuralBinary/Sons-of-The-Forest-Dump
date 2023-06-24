using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Util;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x02000080 RID: 128
	[Token(Token = "0x2000080")]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_local_space_graph.php")]
	public class LocalSpaceGraph : VersionedMonoBehaviour
	{
		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060004BA RID: 1210 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000EB")]
		public GraphTransform transformation
		{
			[Token(Token = "0x60004B9")]
			[Address(RVA = "0x675FA0", Offset = "0x6745A0", VA = "0x180675FA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004BA")]
			[Address(RVA = "0x675FB0", Offset = "0x6745B0", VA = "0x180675FB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x676010", Offset = "0x674610", VA = "0x180676010")]
		private void Start()
		{
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x6761A0", Offset = "0x6747A0", VA = "0x1806761A0")]
		public void Refresh()
		{
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public LocalSpaceGraph()
		{
		}

		// Token: 0x0400032B RID: 811
		[Token(Token = "0x400032B")]
		[FieldOffset(Offset = "0x28")]
		private Matrix4x4 originalMatrix;
	}
}
