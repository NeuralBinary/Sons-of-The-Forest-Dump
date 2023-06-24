using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Construction.GRABS
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	public interface IArchetype
	{
		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000070 RID: 112
		[Token(Token = "0x1700001F")]
		Vector3 RotationAxis { [Token(Token = "0x6000070")] get; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000071 RID: 113
		[Token(Token = "0x17000020")]
		Vector3 Size { [Token(Token = "0x6000071")] get; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000072 RID: 114
		[Token(Token = "0x17000021")]
		float StackingOffset { [Token(Token = "0x6000072")] get; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000073 RID: 115
		[Token(Token = "0x17000022")]
		float TileLength { [Token(Token = "0x6000073")] get; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000074 RID: 116
		[Token(Token = "0x17000023")]
		SnapAxis StretchAxis { [Token(Token = "0x6000074")] get; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000075 RID: 117
		[Token(Token = "0x17000024")]
		IArchetype ExtrudeLeftSideArchetype { [Token(Token = "0x6000075")] get; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000076 RID: 118
		[Token(Token = "0x17000025")]
		IArchetype ExtrudeRightSideArchetype { [Token(Token = "0x6000076")] get; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000077 RID: 119
		[Token(Token = "0x17000026")]
		IArchetype ExtrudeForwardSideArchetype { [Token(Token = "0x6000077")] get; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000078 RID: 120
		[Token(Token = "0x17000027")]
		IArchetype ExtrudeBackSideArchetype { [Token(Token = "0x6000078")] get; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000079 RID: 121
		[Token(Token = "0x17000028")]
		IArchetype ExtrudeBellowArchetype { [Token(Token = "0x6000079")] get; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600007A RID: 122
		[Token(Token = "0x17000029")]
		IArchetype ExtrudeAboveArchetype { [Token(Token = "0x600007A")] get; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600007B RID: 123
		[Token(Token = "0x1700002A")]
		VisualInstanceProvider FaceVisualInstanceProvider { [Token(Token = "0x600007B")] get; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600007C RID: 124
		[Token(Token = "0x1700002B")]
		VisualFader HightlightPrefab { [Token(Token = "0x600007C")] get; }

		// Token: 0x0600007D RID: 125
		[Token(Token = "0x600007D")]
		IFaceVisual SetupFaceVisual(BlueprintFace face);

		// Token: 0x0600007E RID: 126
		[Token(Token = "0x600007E")]
		Vector3 CalcMiddlePos(BlueprintFace face);

		// Token: 0x0600007F RID: 127
		[Token(Token = "0x600007F")]
		Plane GetCastPlane(BlueprintFace face);

		// Token: 0x06000080 RID: 128
		[Token(Token = "0x6000080")]
		InteractionPointDefinition[] GetInteractionPointsDefinitions();

		// Token: 0x06000081 RID: 129
		[Token(Token = "0x6000081")]
		void CalcFaceTiles(BlueprintFace face, out Vector3Int tileFrom, out Vector3Int tileTo);

		// Token: 0x06000082 RID: 130
		[Token(Token = "0x6000082")]
		void Generate(BlueprintStructuresGrid grid, BlueprintFace edge, bool generateBuilt);

		// Token: 0x06000083 RID: 131
		[Token(Token = "0x6000083")]
		void PrepareGeneration(Vector3Int tileFrom, Transform blueprintTr, out float tileLength, out Vector3 tileOrigin, out Vector3 xTileAxis, out Vector3 yTileAxis);

		// Token: 0x06000084 RID: 132
		[Token(Token = "0x6000084")]
		Vector3 CalcTileCenterWorldPos(float tileLength, ref Vector3 xTileAxis, ref Vector3 yTileAxis, ref Vector3 tileOrigin, ref Vector3Int tile);
	}
}
