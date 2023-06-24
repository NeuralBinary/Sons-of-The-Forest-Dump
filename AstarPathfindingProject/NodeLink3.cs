using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x02000064 RID: 100
	[Token(Token = "0x2000064")]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_node_link3.php")]
	[AddComponentMenu("Pathfinding/Link3")]
	public class NodeLink3 : GraphModifier
	{
		// Token: 0x06000399 RID: 921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000399")]
		[Address(RVA = "0x664CC0", Offset = "0x6632C0", VA = "0x180664CC0")]
		public static NodeLink3 GetNodeLink(GraphNode node)
		{
			return null;
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x0600039A RID: 922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B4")]
		public Transform StartTransform
		{
			[Token(Token = "0x600039A")]
			[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x0600039B RID: 923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B5")]
		public Transform EndTransform
		{
			[Token(Token = "0x600039B")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x0600039C RID: 924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B6")]
		public GraphNode StartNode
		{
			[Token(Token = "0x600039C")]
			[Address(RVA = "0x661070", Offset = "0x65F670", VA = "0x180661070")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600039D RID: 925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B7")]
		public GraphNode EndNode
		{
			[Token(Token = "0x600039D")]
			[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600039E")]
		[Address(RVA = "0x664D50", Offset = "0x663350", VA = "0x180664D50", Slot = "13")]
		public override void OnPostScan()
		{
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600039F")]
		[Address(RVA = "0x664E90", Offset = "0x663490", VA = "0x180664E90")]
		public void InternalOnPostScan()
		{
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x6656A0", Offset = "0x663CA0", VA = "0x1806656A0", Slot = "18")]
		public override void OnGraphsPostUpdate()
		{
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x665790", Offset = "0x663D90", VA = "0x180665790", Slot = "10")]
		protected override void OnEnable()
		{
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x665990", Offset = "0x663F90", VA = "0x180665990", Slot = "11")]
		protected override void OnDisable()
		{
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x661F30", Offset = "0x660530", VA = "0x180661F30")]
		private void RemoveConnections(GraphNode node)
		{
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x665B50", Offset = "0x664150", VA = "0x180665B50")]
		[ContextMenu("Recalculate neighbours")]
		private void ContextApplyForce()
		{
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x665BF0", Offset = "0x6641F0", VA = "0x180665BF0")]
		public void Apply(bool forceNewCheck)
		{
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x6677B0", Offset = "0x665DB0", VA = "0x1806677B0", Slot = "19")]
		public virtual void OnDrawGizmosSelected()
		{
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x6677C0", Offset = "0x665DC0", VA = "0x1806677C0")]
		public void OnDrawGizmos()
		{
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x6677D0", Offset = "0x665DD0", VA = "0x1806677D0")]
		public void OnDrawGizmos(bool selected)
		{
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x668420", Offset = "0x666A20", VA = "0x180668420")]
		public NodeLink3()
		{
		}

		// Token: 0x04000283 RID: 643
		[Token(Token = "0x4000283")]
		[FieldOffset(Offset = "0x0")]
		protected static Dictionary<GraphNode, NodeLink3> reference;

		// Token: 0x04000284 RID: 644
		[Token(Token = "0x4000284")]
		[FieldOffset(Offset = "0x40")]
		public Transform end;

		// Token: 0x04000285 RID: 645
		[Token(Token = "0x4000285")]
		[FieldOffset(Offset = "0x48")]
		public float costFactor;

		// Token: 0x04000286 RID: 646
		[Token(Token = "0x4000286")]
		[FieldOffset(Offset = "0x4C")]
		public bool oneWay;

		// Token: 0x04000287 RID: 647
		[Token(Token = "0x4000287")]
		[FieldOffset(Offset = "0x50")]
		private NodeLink3Node startNode;

		// Token: 0x04000288 RID: 648
		[Token(Token = "0x4000288")]
		[FieldOffset(Offset = "0x58")]
		private NodeLink3Node endNode;

		// Token: 0x04000289 RID: 649
		[Token(Token = "0x4000289")]
		[FieldOffset(Offset = "0x60")]
		private MeshNode connectedNode1;

		// Token: 0x0400028A RID: 650
		[Token(Token = "0x400028A")]
		[FieldOffset(Offset = "0x68")]
		private MeshNode connectedNode2;

		// Token: 0x0400028B RID: 651
		[Token(Token = "0x400028B")]
		[FieldOffset(Offset = "0x70")]
		private Vector3 clamped1;

		// Token: 0x0400028C RID: 652
		[Token(Token = "0x400028C")]
		[FieldOffset(Offset = "0x7C")]
		private Vector3 clamped2;

		// Token: 0x0400028D RID: 653
		[Token(Token = "0x400028D")]
		[FieldOffset(Offset = "0x88")]
		private bool postScanCalled;

		// Token: 0x0400028E RID: 654
		[Token(Token = "0x400028E")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Color GizmosColor;

		// Token: 0x0400028F RID: 655
		[Token(Token = "0x400028F")]
		[FieldOffset(Offset = "0x18")]
		private static readonly Color GizmosColorSelected;
	}
}
