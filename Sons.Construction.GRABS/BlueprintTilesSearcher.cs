using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Construction.GRABS
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	public class BlueprintTilesSearcher
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000020 RID: 32 RVA: 0x000020C8 File Offset: 0x000002C8
		// (set) Token: 0x06000021 RID: 33 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700000E")]
		public bool CurrentIsAlignedOnXAxis
		{
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x2866320", Offset = "0x2864920", VA = "0x182866320")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x2A894E0", Offset = "0x2A87AE0", VA = "0x182A894E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x2D82010", Offset = "0x2D80610", VA = "0x182D82010")]
		public void Init(BlueprintFace wallFace)
		{
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x2D823E0", Offset = "0x2D809E0", VA = "0x182D823E0")]
		private void CalcArchetypeTilesAtLevel(HashSet<Vector3Int> tileCollection, IArchetype archetype, float groundLevelHeight)
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x2D827A0", Offset = "0x2D80DA0", VA = "0x182D827A0")]
		private void RecordFaceTiles(HashSet<Vector3Int> tileCollection, Vector3Int tileFrom, Vector3Int tileTo)
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x2D828F0", Offset = "0x2D80EF0", VA = "0x182D828F0")]
		private void CalcWallFaceTiles(out Vector3Int tileFrom, out Vector3Int tileTo)
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x2D82950", Offset = "0x2D80F50", VA = "0x182D82950")]
		private void RefreshAlignedOnXAxis()
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x2D82A70", Offset = "0x2D81070", VA = "0x182D82A70")]
		public void PrewarmCheckMissingTiles()
		{
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000020E0 File Offset: 0x000002E0
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x2D82B80", Offset = "0x2D81180", VA = "0x182D82B80")]
		public bool CheckMissingFoundationTiles(out Vector3Int missingTileFrom, out Vector3Int missingTileTo)
		{
			return default(bool);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000020F8 File Offset: 0x000002F8
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x2D82E20", Offset = "0x2D81420", VA = "0x182D82E20")]
		public bool CheckMissingCeilingTiles(out Vector3Int missingTileFrom, out Vector3Int missingTileTo)
		{
			return default(bool);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002110 File Offset: 0x00000310
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x2D830C0", Offset = "0x2D816C0", VA = "0x182D830C0")]
		public bool CheckMissingLeftWallTiles(bool missingFaceOnZAxis, out Vector3Int missingTileFrom, out Vector3Int missingTileTo)
		{
			return default(bool);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002128 File Offset: 0x00000328
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x2D83380", Offset = "0x2D81980", VA = "0x182D83380")]
		public bool CheckMissingRightWallTiles(bool missingFaceOnZAxis, out Vector3Int missingTileFrom, out Vector3Int missingTileTo)
		{
			return default(bool);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x2D83640", Offset = "0x2D81C40", VA = "0x182D83640")]
		private void LookupMissingTile(Vector3Int diffTileFrom, Vector3Int diffTileTo, Vector3Int diffTilesOffset, HashSet<Vector3Int> tileCollection, out Vector3Int missingTileFrom, out Vector3Int missingTileTo, out bool foundFirstMissingTile)
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x2D83920", Offset = "0x2D81F20", VA = "0x182D83920")]
		public void CalcAlignedFoundationCoveredTiles(out Vector3Int from, out Vector3Int to)
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x2D83CA0", Offset = "0x2D822A0", VA = "0x182D83CA0")]
		public BlueprintTilesSearcher()
		{
		}

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x10")]
		private BlueprintFace _face;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x18")]
		private Blueprint _blueprint;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x20")]
		private Vector3Int _originalTileFrom;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x2C")]
		private Vector3Int _originalTileTo;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x38")]
		private readonly HashSet<Vector3Int> _foundationTiles;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x40")]
		private readonly HashSet<Vector3Int> _ceilingTiles;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x48")]
		private readonly HashSet<Vector3Int> _wallTiles;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x50")]
		private Vector3Int _currentTileFrom;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x5C")]
		private Vector3Int _currentTileTo;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x68")]
		private bool _currentAtBackOrLeft;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x6C")]
		private Vector3Int _surfaceTilesDiffFrom;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x78")]
		private Vector3Int _surfaceTileDiffTo;
	}
}
