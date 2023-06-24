using System;
using System.IO;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.Serialization
{
	// Token: 0x0200011D RID: 285
	[Token(Token = "0x200011D")]
	public class GraphSerializationContext
	{
		// Token: 0x06000935 RID: 2357 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000935")]
		[Address(RVA = "0x6FE910", Offset = "0x6FCF10", VA = "0x1806FE910")]
		public GraphSerializationContext(BinaryReader reader, GraphNode[] id2NodeMapping, uint graphIndex, GraphMeta meta)
		{
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000936")]
		[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
		public GraphSerializationContext(BinaryWriter writer)
		{
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000937")]
		[Address(RVA = "0x6FEA40", Offset = "0x6FD040", VA = "0x1806FEA40")]
		public void SerializeNodeReference(GraphNode node)
		{
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000938")]
		[Address(RVA = "0x6FEA80", Offset = "0x6FD080", VA = "0x1806FEA80")]
		public GraphNode DeserializeNodeReference()
		{
			return null;
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000939")]
		[Address(RVA = "0x6FEBB0", Offset = "0x6FD1B0", VA = "0x1806FEBB0")]
		public void SerializeVector3(Vector3 v)
		{
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x00006224 File Offset: 0x00004424
		[Token(Token = "0x600093A")]
		[Address(RVA = "0x6FEC30", Offset = "0x6FD230", VA = "0x1806FEC30")]
		public Vector3 DeserializeVector3()
		{
			return default(Vector3);
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600093B")]
		[Address(RVA = "0x6FECD0", Offset = "0x6FD2D0", VA = "0x1806FECD0")]
		public void SerializeInt3(Int3 v)
		{
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x0000623C File Offset: 0x0000443C
		[Token(Token = "0x600093C")]
		[Address(RVA = "0x6FED50", Offset = "0x6FD350", VA = "0x1806FED50")]
		public Int3 DeserializeInt3()
		{
			return default(Int3);
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x00006254 File Offset: 0x00004454
		[Token(Token = "0x600093D")]
		[Address(RVA = "0x6FEDF0", Offset = "0x6FD3F0", VA = "0x1806FEDF0")]
		public int DeserializeInt(int defaultValue)
		{
			return 0;
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x0000626C File Offset: 0x0000446C
		[Token(Token = "0x600093E")]
		[Address(RVA = "0x6FEED0", Offset = "0x6FD4D0", VA = "0x1806FEED0")]
		public float DeserializeFloat(float defaultValue)
		{
			return 0f;
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600093F")]
		[Address(RVA = "0x6FEFB0", Offset = "0x6FD5B0", VA = "0x1806FEFB0")]
		public UnityEngine.Object DeserializeUnityObject()
		{
			return null;
		}

		// Token: 0x04000664 RID: 1636
		[Token(Token = "0x4000664")]
		[FieldOffset(Offset = "0x10")]
		private readonly GraphNode[] id2NodeMapping;

		// Token: 0x04000665 RID: 1637
		[Token(Token = "0x4000665")]
		[FieldOffset(Offset = "0x18")]
		public readonly BinaryReader reader;

		// Token: 0x04000666 RID: 1638
		[Token(Token = "0x4000666")]
		[FieldOffset(Offset = "0x20")]
		public readonly BinaryWriter writer;

		// Token: 0x04000667 RID: 1639
		[Token(Token = "0x4000667")]
		[FieldOffset(Offset = "0x28")]
		public readonly uint graphIndex;

		// Token: 0x04000668 RID: 1640
		[Token(Token = "0x4000668")]
		[FieldOffset(Offset = "0x30")]
		public readonly GraphMeta meta;
	}
}
