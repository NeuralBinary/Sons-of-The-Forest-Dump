using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Il2CppDummyDll;
using Pathfinding.Ionic.Zip;
using UnityEngine;

namespace Pathfinding.Serialization
{
	// Token: 0x0200011E RID: 286
	[Token(Token = "0x200011E")]
	public class AstarSerializer
	{
		// Token: 0x06000940 RID: 2368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000940")]
		[Address(RVA = "0x6FF380", Offset = "0x6FD980", VA = "0x1806FF380")]
		private static StringBuilder GetStringBuilder()
		{
			return null;
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000941")]
		[Address(RVA = "0x6FF400", Offset = "0x6FDA00", VA = "0x1806FF400")]
		public AstarSerializer(AstarData data, GameObject contextRoot)
		{
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000942")]
		[Address(RVA = "0x6FF470", Offset = "0x6FDA70", VA = "0x1806FF470")]
		public AstarSerializer(AstarData data, SerializeSettings settings, GameObject contextRoot)
		{
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000943")]
		[Address(RVA = "0x6FF660", Offset = "0x6FDC60", VA = "0x1806FF660")]
		public void SetGraphIndexOffset(int offset)
		{
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000944")]
		[Address(RVA = "0x6FF670", Offset = "0x6FDC70", VA = "0x1806FF670")]
		private void AddChecksum(byte[] bytes)
		{
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000945")]
		[Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0")]
		private void AddEntry(string name, byte[] bytes)
		{
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x00006284 File Offset: 0x00004484
		[Token(Token = "0x6000946")]
		[Address(RVA = "0x6FF7C0", Offset = "0x6FDDC0", VA = "0x1806FF7C0")]
		public uint GetChecksum()
		{
			return 0U;
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000947")]
		[Address(RVA = "0x6FF7D0", Offset = "0x6FDDD0", VA = "0x1806FF7D0")]
		public void OpenSerialize()
		{
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000948")]
		[Address(RVA = "0x6FFA30", Offset = "0x6FE030", VA = "0x1806FFA30")]
		public byte[] CloseSerialize()
		{
			return null;
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000949")]
		[Address(RVA = "0x6FFF80", Offset = "0x6FE580", VA = "0x1806FFF80")]
		public void SerializeGraphs(NavGraph[] _graphs)
		{
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600094A")]
		[Address(RVA = "0x7001F0", Offset = "0x6FE7F0", VA = "0x1807001F0")]
		private byte[] SerializeMeta()
		{
			return null;
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600094B")]
		[Address(RVA = "0x7006D0", Offset = "0x6FECD0", VA = "0x1807006D0")]
		public byte[] Serialize(NavGraph graph)
		{
			return null;
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600094C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("Not used anymore. You can safely remove the call to this function.")]
		public void SerializeNodes()
		{
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x0000629C File Offset: 0x0000449C
		[Token(Token = "0x600094D")]
		[Address(RVA = "0x7007B0", Offset = "0x6FEDB0", VA = "0x1807007B0")]
		private static int GetMaxNodeIndexInAllGraphs(NavGraph[] graphs)
		{
			return 0;
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600094E")]
		[Address(RVA = "0x7008D0", Offset = "0x6FEED0", VA = "0x1807008D0")]
		private static byte[] SerializeNodeIndices(NavGraph[] graphs)
		{
			return null;
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600094F")]
		[Address(RVA = "0x700C40", Offset = "0x6FF240", VA = "0x180700C40")]
		private static byte[] SerializeGraphExtraInfo(NavGraph graph)
		{
			return null;
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000950")]
		[Address(RVA = "0x700D90", Offset = "0x6FF390", VA = "0x180700D90")]
		private static byte[] SerializeGraphNodeReferences(NavGraph graph)
		{
			return null;
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000951")]
		[Address(RVA = "0x700FA0", Offset = "0x6FF5A0", VA = "0x180700FA0")]
		public void SerializeExtraInfo()
		{
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000952")]
		[Address(RVA = "0x701560", Offset = "0x6FFB60", VA = "0x180701560")]
		private byte[] SerializeNodeLinks()
		{
			return null;
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000953")]
		[Address(RVA = "0x7016A0", Offset = "0x6FFCA0", VA = "0x1807016A0")]
		private ZipEntry GetEntry(string name)
		{
			return null;
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x000062B4 File Offset: 0x000044B4
		[Token(Token = "0x6000954")]
		[Address(RVA = "0x7016C0", Offset = "0x6FFCC0", VA = "0x1807016C0")]
		private bool ContainsEntry(string name)
		{
			return default(bool);
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x000062CC File Offset: 0x000044CC
		[Token(Token = "0x6000955")]
		[Address(RVA = "0x7016F0", Offset = "0x6FFCF0", VA = "0x1807016F0")]
		public bool OpenDeserialize(byte[] bytes)
		{
			return default(bool);
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000956")]
		[Address(RVA = "0x701EF0", Offset = "0x7004F0", VA = "0x180701EF0")]
		private static Version FullyDefinedVersion(Version v)
		{
			return null;
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000957")]
		[Address(RVA = "0x701FA0", Offset = "0x7005A0", VA = "0x180701FA0")]
		public void CloseDeserialize()
		{
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000958")]
		[Address(RVA = "0x7020A0", Offset = "0x7006A0", VA = "0x1807020A0")]
		private NavGraph DeserializeGraph(int zipIndex, int graphIndex, Type[] availableGraphTypes)
		{
			return null;
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000959")]
		[Address(RVA = "0x7025C0", Offset = "0x700BC0", VA = "0x1807025C0")]
		public NavGraph[] DeserializeGraphs(Type[] availableGraphTypes)
		{
			return null;
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x000062E4 File Offset: 0x000044E4
		[Token(Token = "0x600095A")]
		[Address(RVA = "0x702830", Offset = "0x700E30", VA = "0x180702830")]
		private bool DeserializeExtraInfo(NavGraph graph)
		{
			return default(bool);
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x000062FC File Offset: 0x000044FC
		[Token(Token = "0x600095B")]
		[Address(RVA = "0x702A10", Offset = "0x701010", VA = "0x180702A10")]
		private bool AnyDestroyedNodesInGraphs()
		{
			return default(bool);
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600095C")]
		[Address(RVA = "0x702B50", Offset = "0x701150", VA = "0x180702B50")]
		private GraphNode[] DeserializeNodeReferenceMap()
		{
			return null;
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600095D")]
		[Address(RVA = "0x703030", Offset = "0x701630", VA = "0x180703030")]
		private void DeserializeNodeReferences(NavGraph graph, GraphNode[] int2Node)
		{
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600095E")]
		[Address(RVA = "0x703350", Offset = "0x701950", VA = "0x180703350")]
		public void DeserializeExtraInfo()
		{
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600095F")]
		[Address(RVA = "0x703760", Offset = "0x701D60", VA = "0x180703760")]
		private void DeserializeNodeLinks(GraphNode[] int2Node)
		{
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000960")]
		[Address(RVA = "0x703870", Offset = "0x701E70", VA = "0x180703870")]
		public void PostDeserialization()
		{
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000961")]
		[Address(RVA = "0x7039E0", Offset = "0x701FE0", VA = "0x1807039E0")]
		public void DeserializeEditorSettingsCompatibility()
		{
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000962")]
		[Address(RVA = "0x703C30", Offset = "0x702230", VA = "0x180703C30")]
		private static BinaryReader GetBinaryReader(ZipEntry entry)
		{
			return null;
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000963")]
		[Address(RVA = "0x703CF0", Offset = "0x7022F0", VA = "0x180703CF0")]
		private static string GetString(ZipEntry entry)
		{
			return null;
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000964")]
		[Address(RVA = "0x703E00", Offset = "0x702400", VA = "0x180703E00")]
		private GraphMeta DeserializeMeta(ZipEntry entry)
		{
			return null;
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000965")]
		[Address(RVA = "0x703F70", Offset = "0x702570", VA = "0x180703F70")]
		private GraphMeta DeserializeBinaryMeta(ZipEntry entry)
		{
			return null;
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000966")]
		[Address(RVA = "0x7044B0", Offset = "0x702AB0", VA = "0x1807044B0")]
		public static void SaveToFile(string path, byte[] data)
		{
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000967")]
		[Address(RVA = "0x704600", Offset = "0x702C00", VA = "0x180704600")]
		public static byte[] LoadFromFile(string path)
		{
			return null;
		}

		// Token: 0x04000669 RID: 1641
		[Token(Token = "0x4000669")]
		[FieldOffset(Offset = "0x10")]
		private AstarData data;

		// Token: 0x0400066A RID: 1642
		[Token(Token = "0x400066A")]
		[FieldOffset(Offset = "0x18")]
		private ZipFile zip;

		// Token: 0x0400066B RID: 1643
		[Token(Token = "0x400066B")]
		[FieldOffset(Offset = "0x20")]
		private MemoryStream zipStream;

		// Token: 0x0400066C RID: 1644
		[Token(Token = "0x400066C")]
		[FieldOffset(Offset = "0x28")]
		private GraphMeta meta;

		// Token: 0x0400066D RID: 1645
		[Token(Token = "0x400066D")]
		[FieldOffset(Offset = "0x30")]
		private SerializeSettings settings;

		// Token: 0x0400066E RID: 1646
		[Token(Token = "0x400066E")]
		[FieldOffset(Offset = "0x38")]
		private GameObject contextRoot;

		// Token: 0x0400066F RID: 1647
		[Token(Token = "0x400066F")]
		[FieldOffset(Offset = "0x40")]
		private NavGraph[] graphs;

		// Token: 0x04000670 RID: 1648
		[Token(Token = "0x4000670")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<NavGraph, int> graphIndexInZip;

		// Token: 0x04000671 RID: 1649
		[Token(Token = "0x4000671")]
		[FieldOffset(Offset = "0x50")]
		private int graphIndexOffset;

		// Token: 0x04000672 RID: 1650
		[Token(Token = "0x4000672")]
		private const string binaryExt = ".binary";

		// Token: 0x04000673 RID: 1651
		[Token(Token = "0x4000673")]
		private const string jsonExt = ".json";

		// Token: 0x04000674 RID: 1652
		[Token(Token = "0x4000674")]
		[FieldOffset(Offset = "0x54")]
		private uint checksum;

		// Token: 0x04000675 RID: 1653
		[Token(Token = "0x4000675")]
		[FieldOffset(Offset = "0x58")]
		private UTF8Encoding encoding;

		// Token: 0x04000676 RID: 1654
		[Token(Token = "0x4000676")]
		[FieldOffset(Offset = "0x0")]
		private static StringBuilder _stringBuilder;

		// Token: 0x04000677 RID: 1655
		[Token(Token = "0x4000677")]
		[FieldOffset(Offset = "0x8")]
		public static readonly Version V3_8_3;

		// Token: 0x04000678 RID: 1656
		[Token(Token = "0x4000678")]
		[FieldOffset(Offset = "0x10")]
		public static readonly Version V3_9_0;

		// Token: 0x04000679 RID: 1657
		[Token(Token = "0x4000679")]
		[FieldOffset(Offset = "0x18")]
		public static readonly Version V4_1_0;
	}
}
