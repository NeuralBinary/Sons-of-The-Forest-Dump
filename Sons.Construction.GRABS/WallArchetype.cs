using System;
using System.Runtime.CompilerServices;
using Construction;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Construction.GRABS
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	[CreateAssetMenu(menuName = "Sons/Construction/GRABS/Archetype: Wall", fileName = "GRABS Archetype - Wall")]
	public class WallArchetype : Archetype, IArchetype
	{
		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000085 RID: 133 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x1700002C")]
		public override VisualFader HightlightPrefab
		{
			[Token(Token = "0x6000085")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80", Slot = "25")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000086 RID: 134 RVA: 0x0000242C File Offset: 0x0000062C
		[Token(Token = "0x1700002D")]
		public override Vector3 RotationAxis
		{
			[Token(Token = "0x6000086")]
			[Address(RVA = "0x2D83E20", Offset = "0x2D82420", VA = "0x182D83E20", Slot = "26")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00002444 File Offset: 0x00000644
		[Token(Token = "0x1700002E")]
		public override Vector3 Size
		{
			[Token(Token = "0x6000087")]
			[Address(RVA = "0x2D8A600", Offset = "0x2D88C00", VA = "0x182D8A600", Slot = "27")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000088 RID: 136 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x1700002F")]
		public override VisualInstanceProvider FaceVisualInstanceProvider
		{
			[Token(Token = "0x6000088")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0", Slot = "31")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000089 RID: 137 RVA: 0x0000245C File Offset: 0x0000065C
		[Token(Token = "0x17000030")]
		public override float StackingOffset
		{
			[Token(Token = "0x6000089")]
			[Address(RVA = "0x2D8A6C0", Offset = "0x2D88CC0", VA = "0x182D8A6C0", Slot = "28")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00002474 File Offset: 0x00000674
		[Token(Token = "0x17000031")]
		public override SnapAxis StretchAxis
		{
			[Token(Token = "0x600008A")]
			[Address(RVA = "0x260CE70", Offset = "0x260B470", VA = "0x18260CE70", Slot = "30")]
			get
			{
				return SnapAxis.None;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600008B RID: 139 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x17000032")]
		public override IArchetype ExtrudeLeftSideArchetype
		{
			[Token(Token = "0x600008B")]
			[Address(RVA = "0x709210", Offset = "0x707810", VA = "0x180709210", Slot = "32")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600008C RID: 140 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x17000033")]
		public override IArchetype ExtrudeRightSideArchetype
		{
			[Token(Token = "0x600008C")]
			[Address(RVA = "0x709210", Offset = "0x707810", VA = "0x180709210", Slot = "33")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600008D RID: 141 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x17000034")]
		public override IArchetype ExtrudeForwardSideArchetype
		{
			[Token(Token = "0x600008D")]
			[Address(RVA = "0x709210", Offset = "0x707810", VA = "0x180709210", Slot = "34")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600008E RID: 142 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x17000035")]
		public override IArchetype ExtrudeBackSideArchetype
		{
			[Token(Token = "0x600008E")]
			[Address(RVA = "0x709210", Offset = "0x707810", VA = "0x180709210", Slot = "35")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600008F RID: 143 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x17000036")]
		public override IArchetype ExtrudeBellowArchetype
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00", Slot = "36")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000090 RID: 144 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x17000037")]
		public override IArchetype ExtrudeAboveArchetype
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00", Slot = "37")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0", Slot = "42")]
		public override InteractionPointDefinition[] GetInteractionPointsDefinitions()
		{
			return null;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x2D8A700", Offset = "0x2D88D00", VA = "0x182D8A700", Slot = "38")]
		public override IFaceVisual SetupFaceVisual(BlueprintFace face)
		{
			return null;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000248C File Offset: 0x0000068C
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x2D83F80", Offset = "0x2D82580", VA = "0x182D83F80", Slot = "39")]
		public override Vector3 CalcMiddlePos(BlueprintFace face)
		{
			return default(Vector3);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000024A4 File Offset: 0x000006A4
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x2D8A740", Offset = "0x2D88D40", VA = "0x182D8A740", Slot = "43")]
		public override Plane GetCastPlane(BlueprintFace face)
		{
			return default(Plane);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x2D8A880", Offset = "0x2D88E80", VA = "0x182D8A880", Slot = "40")]
		public override void CalcFaceTiles(BlueprintFace face, out Vector3Int tileFrom, out Vector3Int tileTo)
		{
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x2D8AB40", Offset = "0x2D89140", VA = "0x182D8AB40", Slot = "44")]
		public override void PrepareGeneration(Vector3Int tileFrom, Transform blueprintTr, out float tileLength, out Vector3 tileOrigin, out Vector3 xTileAxis, out Vector3 yTileAxis)
		{
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x2D8AED0", Offset = "0x2D894D0", VA = "0x182D8AED0", Slot = "41")]
		public override void Generate(BlueprintStructuresGrid grid, BlueprintFace face, bool generateBuilt)
		{
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000024BC File Offset: 0x000006BC
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x2D8B480", Offset = "0x2D89A80", VA = "0x182D8B480")]
		public static bool IsBackOfTile(Transform faceTr, Transform blueprintTr)
		{
			return default(bool);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000024D4 File Offset: 0x000006D4
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x2D8B520", Offset = "0x2D89B20", VA = "0x182D8B520")]
		private Vector3 CalcLocalTileOrigin(BlueprintFace face, Vector3 blueprintSpaceSize, bool preservedTileAxis, float tileLength, float tileHeight)
		{
			return default(Vector3);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x2D8B930", Offset = "0x2D89F30", VA = "0x182D8B930")]
		private void SpawnTileBack(BlueprintStructuresGrid grid, Vector3Int tile, BlueprintFace face, Vector3 tileWorldCenterPos, Vector3 xTileAxis, Vector3 yTileAxis, float aboveBeamHeight)
		{
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x2D8BD20", Offset = "0x2D8A320", VA = "0x182D8BD20")]
		private void SpawnTileLeft(BlueprintStructuresGrid grid, Vector3Int tile, BlueprintFace face, Vector3 tileWorldCenterPos, Vector3 xTileAxis, Vector3 yTileAxis, float aboveBeamHeight)
		{
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x2D8C110", Offset = "0x2D8A710", VA = "0x182D8C110")]
		private void SpawnAboveBeam(BlueprintStructuresGrid grid, Vector3Int tile, BlueprintFace face, Vector3 axis, WallStructure wall, Sides side)
		{
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		public WallArchetype()
		{
		}

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private VisualFader _hightlightPrefab;

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private FoundationArchetype _foundationArchetype;

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ElementProfile _beamElement;

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ElementProfile _constructionElement;

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ElementProfile _interactionElement;

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private VisualInstanceProvider _faceVisualInstanceProvider;

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private InteractionPointDefinition[] _interactionPointsDefinitions;

		// Token: 0x0200000F RID: 15
		[Token(Token = "0x200000F")]
		public static class Utils
		{
			// Token: 0x02000010 RID: 16
			[Token(Token = "0x2000010")]
			public static class Wall
			{
				// Token: 0x0600009E RID: 158 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x600009E")]
				[Address(RVA = "0x2D8C4C0", Offset = "0x2D8AAC0", VA = "0x182D8C4C0")]
				public static void Setup(Vector3 xTileAxis, Vector3 yTileAxis, ElementProfile wallElement)
				{
				}

				// Token: 0x0600009F RID: 159 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x600009F")]
				[Address(RVA = "0x2D8C5B0", Offset = "0x2D8ABB0", VA = "0x182D8C5B0")]
				public static void Setup(Vector3 tileWorldCenterPos)
				{
				}

				// Token: 0x060000A0 RID: 160 RVA: 0x000024EC File Offset: 0x000006EC
				[Token(Token = "0x60000A0")]
				[Address(RVA = "0x2D86CB0", Offset = "0x2D852B0", VA = "0x182D86CB0")]
				private static float CalcOffsetToTileCenter(ElementProfile wallElement)
				{
					return 0f;
				}

				// Token: 0x060000A1 RID: 161 RVA: 0x00002504 File Offset: 0x00000704
				[Token(Token = "0x60000A1")]
				[Address(RVA = "0x2D8C600", Offset = "0x2D8AC00", VA = "0x182D8C600")]
				public static Vector3 CalcBackPos()
				{
					return default(Vector3);
				}

				// Token: 0x060000A2 RID: 162 RVA: 0x0000251C File Offset: 0x0000071C
				[Token(Token = "0x60000A2")]
				[Address(RVA = "0x2D8C6D0", Offset = "0x2D8ACD0", VA = "0x182D8C6D0")]
				public static Vector3 CalcForwardPos()
				{
					return default(Vector3);
				}

				// Token: 0x060000A3 RID: 163 RVA: 0x00002534 File Offset: 0x00000734
				[Token(Token = "0x60000A3")]
				[Address(RVA = "0x2D8C7A0", Offset = "0x2D8ADA0", VA = "0x182D8C7A0")]
				public static Vector3 CalcLeftPos()
				{
					return default(Vector3);
				}

				// Token: 0x060000A4 RID: 164 RVA: 0x0000254C File Offset: 0x0000074C
				[Token(Token = "0x60000A4")]
				[Address(RVA = "0x2D8C870", Offset = "0x2D8AE70", VA = "0x182D8C870")]
				public static Vector3 CalcRightPos()
				{
					return default(Vector3);
				}

				// Token: 0x060000A5 RID: 165 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x60000A5")]
				[Address(RVA = "0x2D8C940", Offset = "0x2D8AF40", VA = "0x182D8C940")]
				public static void LinkWithSupportingStructures(BlueprintStructuresGrid grid, WallStructure ghostWall, Vector3Int tile, Sides side)
				{
				}

				// Token: 0x060000A6 RID: 166 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x60000A6")]
				[Address(RVA = "0x2D8CB40", Offset = "0x2D8B140", VA = "0x182D8CB40")]
				[CompilerGenerated]
				internal static void <LinkWithSupportingStructures>g__LinkWithFloorBellow|11_0(ref WallArchetype.Utils.Wall.<>c__DisplayClass11_0 A_0)
				{
				}

				// Token: 0x04000034 RID: 52
				[Token(Token = "0x4000034")]
				[FieldOffset(Offset = "0x0")]
				private static Vector3 TileWorldCenterPos;

				// Token: 0x04000035 RID: 53
				[Token(Token = "0x4000035")]
				[FieldOffset(Offset = "0xC")]
				private static Vector3 XTileAxis;

				// Token: 0x04000036 RID: 54
				[Token(Token = "0x4000036")]
				[FieldOffset(Offset = "0x18")]
				private static Vector3 YTileAxis;

				// Token: 0x04000037 RID: 55
				[Token(Token = "0x4000037")]
				[FieldOffset(Offset = "0x28")]
				private static ElementProfile WallElement;
			}
		}
	}
}
