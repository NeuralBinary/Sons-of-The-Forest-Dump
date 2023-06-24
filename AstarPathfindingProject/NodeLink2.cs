using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Serialization;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x02000062 RID: 98
	[Token(Token = "0x2000062")]
	[AddComponentMenu("Pathfinding/Link2")]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_node_link2.php")]
	public class NodeLink2 : GraphModifier
	{
		// Token: 0x0600037D RID: 893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600037D")]
		[Address(RVA = "0x660FE0", Offset = "0x65F5E0", VA = "0x180660FE0")]
		public static NodeLink2 GetNodeLink(GraphNode node)
		{
			return null;
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600037E RID: 894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AE")]
		public Transform StartTransform
		{
			[Token(Token = "0x600037E")]
			[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600037F RID: 895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AF")]
		public Transform EndTransform
		{
			[Token(Token = "0x600037F")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000380 RID: 896 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000381 RID: 897 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000B0")]
		public PointNode startNode
		{
			[Token(Token = "0x6000380")]
			[Address(RVA = "0x661070", Offset = "0x65F670", VA = "0x180661070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000381")]
			[Address(RVA = "0x661080", Offset = "0x65F680", VA = "0x180661080")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000382 RID: 898 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000383 RID: 899 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000B1")]
		public PointNode endNode
		{
			[Token(Token = "0x6000382")]
			[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000383")]
			[Address(RVA = "0x6610F0", Offset = "0x65F6F0", VA = "0x1806610F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000384 RID: 900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B2")]
		[Obsolete("Use startNode instead (lowercase s)")]
		public GraphNode StartNode
		{
			[Token(Token = "0x6000384")]
			[Address(RVA = "0x661070", Offset = "0x65F670", VA = "0x180661070")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000385 RID: 901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B3")]
		[Obsolete("Use endNode instead (lowercase e)")]
		public GraphNode EndNode
		{
			[Token(Token = "0x6000385")]
			[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000386")]
		[Address(RVA = "0x661150", Offset = "0x65F750", VA = "0x180661150", Slot = "13")]
		public override void OnPostScan()
		{
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000387")]
		[Address(RVA = "0x661160", Offset = "0x65F760", VA = "0x180661160")]
		public void InternalOnPostScan()
		{
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000388")]
		[Address(RVA = "0x6619E0", Offset = "0x65FFE0", VA = "0x1806619E0", Slot = "18")]
		public override void OnGraphsPostUpdate()
		{
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000389")]
		[Address(RVA = "0x661AD0", Offset = "0x6600D0", VA = "0x180661AD0", Slot = "10")]
		protected override void OnEnable()
		{
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600038A")]
		[Address(RVA = "0x661D70", Offset = "0x660370", VA = "0x180661D70", Slot = "11")]
		protected override void OnDisable()
		{
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600038B")]
		[Address(RVA = "0x661F30", Offset = "0x660530", VA = "0x180661F30")]
		private void RemoveConnections(GraphNode node)
		{
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600038C")]
		[Address(RVA = "0x661F60", Offset = "0x660560", VA = "0x180661F60")]
		[ContextMenu("Recalculate neighbours")]
		private void ContextApplyForce()
		{
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600038D")]
		[Address(RVA = "0x662000", Offset = "0x660600", VA = "0x180662000")]
		public void Apply(bool forceNewCheck)
		{
		}

		// Token: 0x0600038E RID: 910 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600038E")]
		[Address(RVA = "0x662FF0", Offset = "0x6615F0", VA = "0x180662FF0", Slot = "19")]
		public virtual void OnDrawGizmosSelected()
		{
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600038F")]
		[Address(RVA = "0x663000", Offset = "0x661600", VA = "0x180663000")]
		public void OnDrawGizmos()
		{
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000390")]
		[Address(RVA = "0x663010", Offset = "0x661610", VA = "0x180663010")]
		public void OnDrawGizmos(bool selected)
		{
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000391")]
		[Address(RVA = "0x663DB0", Offset = "0x6623B0", VA = "0x180663DB0")]
		internal static void SerializeReferences(GraphSerializationContext ctx)
		{
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000392")]
		[Address(RVA = "0x6641E0", Offset = "0x6627E0", VA = "0x1806641E0")]
		internal static void DeserializeReferences(GraphSerializationContext ctx)
		{
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000393")]
		[Address(RVA = "0x664860", Offset = "0x662E60", VA = "0x180664860")]
		public NodeLink2()
		{
		}

		// Token: 0x04000273 RID: 627
		[Token(Token = "0x4000273")]
		[FieldOffset(Offset = "0x0")]
		protected static Dictionary<GraphNode, NodeLink2> reference;

		// Token: 0x04000274 RID: 628
		[Token(Token = "0x4000274")]
		[FieldOffset(Offset = "0x40")]
		public Transform end;

		// Token: 0x04000275 RID: 629
		[Token(Token = "0x4000275")]
		[FieldOffset(Offset = "0x48")]
		public float costFactor;

		// Token: 0x04000276 RID: 630
		[Token(Token = "0x4000276")]
		[FieldOffset(Offset = "0x4C")]
		public bool oneWay;

		// Token: 0x04000279 RID: 633
		[Token(Token = "0x4000279")]
		[FieldOffset(Offset = "0x60")]
		private GraphNode connectedNode1;

		// Token: 0x0400027A RID: 634
		[Token(Token = "0x400027A")]
		[FieldOffset(Offset = "0x68")]
		private GraphNode connectedNode2;

		// Token: 0x0400027B RID: 635
		[Token(Token = "0x400027B")]
		[FieldOffset(Offset = "0x70")]
		private Vector3 clamped1;

		// Token: 0x0400027C RID: 636
		[Token(Token = "0x400027C")]
		[FieldOffset(Offset = "0x7C")]
		private Vector3 clamped2;

		// Token: 0x0400027D RID: 637
		[Token(Token = "0x400027D")]
		[FieldOffset(Offset = "0x88")]
		private bool postScanCalled;

		// Token: 0x0400027E RID: 638
		[Token(Token = "0x400027E")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Color GizmosColor;

		// Token: 0x0400027F RID: 639
		[Token(Token = "0x400027F")]
		[FieldOffset(Offset = "0x18")]
		private static readonly Color GizmosColorSelected;
	}
}
