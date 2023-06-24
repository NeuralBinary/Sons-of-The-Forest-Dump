using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200009B RID: 155
	[Token(Token = "0x200009B")]
	public class OcclusionRoomsProcessor
	{
		// Token: 0x060003F0 RID: 1008 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x612090", Offset = "0x610690", VA = "0x180612090")]
		public OcclusionRoomsProcessor(SuperStructure superStructure, Dictionary<int, List<SuperStructure.Room>> roomsPerLevel, List<SuperStructure.Room> occlusionRooms)
		{
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x2DCEC00", Offset = "0x2DCD200", VA = "0x182DCEC00")]
		public void CombineRoomsPerLevelForOcclusion()
		{
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x2DCEDC0", Offset = "0x2DCD3C0", VA = "0x182DCEDC0")]
		private void CalculateOcclusionRoomsForLevel(Vector3Int gridWorldOffset)
		{
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00003AAC File Offset: 0x00001CAC
		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x2DCF400", Offset = "0x2DCDA00", VA = "0x182DCF400")]
		private bool AddOccludedTilesForLevel(int level, Vector3Int gridWorldOffset)
		{
			return default(bool);
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x2DCF960", Offset = "0x2DCDF60", VA = "0x182DCF960")]
		private void Init()
		{
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60003F5")]
		private T Get<T>(T[] arr, int x, int y)
		{
			return null;
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003F6")]
		private void Set<T>(T[] arr, int x, int y, T val)
		{
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x2DCFC90", Offset = "0x2DCE290", VA = "0x182DCFC90")]
		private void IncrementSafe(int[] arr, int x, int y, int amount)
		{
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00003AC4 File Offset: 0x00001CC4
		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x2DCFE40", Offset = "0x2DCE440", VA = "0x182DCFE40")]
		[CompilerGenerated]
		private int <CalculateOcclusionRoomsForLevel>g__CalcGrowScoreX|11_0(int xOffset, ref OcclusionRoomsProcessor.<>c__DisplayClass11_0 A_2)
		{
			return 0;
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00003ADC File Offset: 0x00001CDC
		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x2DD0010", Offset = "0x2DCE610", VA = "0x182DD0010")]
		[CompilerGenerated]
		private int <CalculateOcclusionRoomsForLevel>g__CalcGrowScoreY|11_1(int yOffset, ref OcclusionRoomsProcessor.<>c__DisplayClass11_0 A_2)
		{
			return 0;
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x2DD01E0", Offset = "0x2DCE7E0", VA = "0x182DD01E0")]
		[CompilerGenerated]
		private void <CalculateOcclusionRoomsForLevel>g__SetProcessed|11_2(ref OcclusionRoomsProcessor.<>c__DisplayClass11_0 A_1)
		{
		}

		// Token: 0x040003C0 RID: 960
		[Token(Token = "0x40003C0")]
		[FieldOffset(Offset = "0x10")]
		private readonly SuperStructure _superStructure;

		// Token: 0x040003C1 RID: 961
		[Token(Token = "0x40003C1")]
		[FieldOffset(Offset = "0x18")]
		private readonly Dictionary<int, List<SuperStructure.Room>> _roomsPerLevel;

		// Token: 0x040003C2 RID: 962
		[Token(Token = "0x40003C2")]
		[FieldOffset(Offset = "0x20")]
		public readonly List<SuperStructure.Room> _occlusionRooms;

		// Token: 0x040003C3 RID: 963
		[Token(Token = "0x40003C3")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<Vector3Int> _newlyOccludedTiles;

		// Token: 0x040003C4 RID: 964
		[Token(Token = "0x40003C4")]
		[FieldOffset(Offset = "0x8")]
		private static int _arrayWidth;

		// Token: 0x040003C5 RID: 965
		[Token(Token = "0x40003C5")]
		[FieldOffset(Offset = "0xC")]
		private static int _arrayHeight;

		// Token: 0x040003C6 RID: 966
		[Token(Token = "0x40003C6")]
		[FieldOffset(Offset = "0x10")]
		private static bool[] _occludedTiles;

		// Token: 0x040003C7 RID: 967
		[Token(Token = "0x40003C7")]
		[FieldOffset(Offset = "0x18")]
		private static bool[] _processedTiles;

		// Token: 0x040003C8 RID: 968
		[Token(Token = "0x40003C8")]
		[FieldOffset(Offset = "0x20")]
		private static int[] _occludedTilesNeighbours;
	}
}
