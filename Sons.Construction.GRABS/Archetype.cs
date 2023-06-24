using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Construction.GRABS
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public abstract class Archetype : ScriptableObject, IArchetype
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3
		[Token(Token = "0x17000001")]
		public abstract VisualFader HightlightPrefab { [Token(Token = "0x6000003")] get; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4
		[Token(Token = "0x17000002")]
		public abstract Vector3 RotationAxis { [Token(Token = "0x6000004")] get; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5
		[Token(Token = "0x17000003")]
		public abstract Vector3 Size { [Token(Token = "0x6000005")] get; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000006 RID: 6
		[Token(Token = "0x17000004")]
		public abstract float StackingOffset { [Token(Token = "0x6000006")] get; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000005")]
		public virtual float TileLength
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0xE7F800", Offset = "0xE7DE00", VA = "0x180E7F800", Slot = "29")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000008 RID: 8
		[Token(Token = "0x17000006")]
		public abstract SnapAxis StretchAxis { [Token(Token = "0x6000008")] get; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000009 RID: 9
		[Token(Token = "0x17000007")]
		public abstract VisualInstanceProvider FaceVisualInstanceProvider { [Token(Token = "0x6000009")] get; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600000A RID: 10
		[Token(Token = "0x17000008")]
		public abstract IArchetype ExtrudeLeftSideArchetype { [Token(Token = "0x600000A")] get; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600000B RID: 11
		[Token(Token = "0x17000009")]
		public abstract IArchetype ExtrudeRightSideArchetype { [Token(Token = "0x600000B")] get; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600000C RID: 12
		[Token(Token = "0x1700000A")]
		public abstract IArchetype ExtrudeForwardSideArchetype { [Token(Token = "0x600000C")] get; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600000D RID: 13
		[Token(Token = "0x1700000B")]
		public abstract IArchetype ExtrudeBackSideArchetype { [Token(Token = "0x600000D")] get; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600000E RID: 14
		[Token(Token = "0x1700000C")]
		public abstract IArchetype ExtrudeBellowArchetype { [Token(Token = "0x600000E")] get; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600000F RID: 15
		[Token(Token = "0x1700000D")]
		public abstract IArchetype ExtrudeAboveArchetype { [Token(Token = "0x600000F")] get; }

		// Token: 0x06000010 RID: 16
		[Token(Token = "0x6000010")]
		public abstract IFaceVisual SetupFaceVisual(BlueprintFace face);

		// Token: 0x06000011 RID: 17
		[Token(Token = "0x6000011")]
		public abstract Vector3 CalcMiddlePos(BlueprintFace face);

		// Token: 0x06000012 RID: 18
		[Token(Token = "0x6000012")]
		public abstract void CalcFaceTiles(BlueprintFace face, out Vector3Int tileFrom, out Vector3Int tileTo);

		// Token: 0x06000013 RID: 19
		[Token(Token = "0x6000013")]
		public abstract void Generate(BlueprintStructuresGrid grid, BlueprintFace edge, bool generateBuilt);

		// Token: 0x06000014 RID: 20
		[Token(Token = "0x6000014")]
		public abstract InteractionPointDefinition[] GetInteractionPointsDefinitions();

		// Token: 0x06000015 RID: 21 RVA: 0x00002080 File Offset: 0x00000280
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x2D80890", Offset = "0x2D7EE90", VA = "0x182D80890")]
		protected bool HasStructureAtPos(BlueprintFace edge, Vector3 pos)
		{
			return default(bool);
		}

		// Token: 0x06000016 RID: 22
		[Token(Token = "0x6000016")]
		public abstract Plane GetCastPlane(BlueprintFace face);

		// Token: 0x06000017 RID: 23
		[Token(Token = "0x6000017")]
		public abstract void PrepareGeneration(Vector3Int tileFrom, Transform blueprintTr, out float tileLength, out Vector3 tileOrigin, out Vector3 xTileAxis, out Vector3 yTileAxis);

		// Token: 0x06000018 RID: 24 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x2D80B90", Offset = "0x2D7F190", VA = "0x182D80B90", Slot = "24")]
		public Vector3 CalcTileCenterWorldPos(float tileLength, ref Vector3 xTileAxis, ref Vector3 yTileAxis, ref Vector3 tileOrigin, ref Vector3Int tile)
		{
			return default(Vector3);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		protected Archetype()
		{
		}
	}
}
