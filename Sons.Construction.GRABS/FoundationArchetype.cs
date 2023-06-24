using System;
using System.Runtime.CompilerServices;
using Construction;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Construction.GRABS
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	[CreateAssetMenu(menuName = "Sons/Construction/GRABS/Archetype: Foundation", fileName = "GRABS Archetype - Foundation")]
	public class FoundationArchetype : Archetype, IArchetype
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600002F RID: 47 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x1700000F")]
		public ElementProfile PilarElement
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000030 RID: 48 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x17000010")]
		public ElementProfile FloorElement
		{
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000031 RID: 49 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x17000011")]
		public ElementProfile FloorInteractionElement
		{
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000032 RID: 50 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x17000012")]
		public override VisualFader HightlightPrefab
		{
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80", Slot = "25")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00002144 File Offset: 0x00000344
		[Token(Token = "0x17000013")]
		public override Vector3 RotationAxis
		{
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x2D83E20", Offset = "0x2D82420", VA = "0x182D83E20", Slot = "26")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000034 RID: 52 RVA: 0x0000215C File Offset: 0x0000035C
		[Token(Token = "0x17000014")]
		public override Vector3 Size
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x2D83E70", Offset = "0x2D82470", VA = "0x182D83E70", Slot = "27")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000035 RID: 53 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x17000015")]
		public override VisualInstanceProvider FaceVisualInstanceProvider
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x675FA0", Offset = "0x6745A0", VA = "0x180675FA0", Slot = "31")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00002174 File Offset: 0x00000374
		[Token(Token = "0x17000016")]
		public override float StackingOffset
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x620A90", Offset = "0x61F090", VA = "0x180620A90", Slot = "28")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000037 RID: 55 RVA: 0x0000218C File Offset: 0x0000038C
		[Token(Token = "0x17000017")]
		public override SnapAxis StretchAxis
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x2D83F30", Offset = "0x2D82530", VA = "0x182D83F30", Slot = "30")]
			get
			{
				return SnapAxis.None;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000038 RID: 56 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x17000018")]
		public override IArchetype ExtrudeLeftSideArchetype
		{
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00", Slot = "32")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000039 RID: 57 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x17000019")]
		public override IArchetype ExtrudeRightSideArchetype
		{
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00", Slot = "33")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600003A RID: 58 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x1700001A")]
		public override IArchetype ExtrudeForwardSideArchetype
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00", Slot = "34")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600003B RID: 59 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x1700001B")]
		public override IArchetype ExtrudeBackSideArchetype
		{
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00", Slot = "35")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600003C RID: 60 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x1700001C")]
		public override IArchetype ExtrudeBellowArchetype
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x709210", Offset = "0x707810", VA = "0x180709210", Slot = "36")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600003D RID: 61 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x1700001D")]
		public override IArchetype ExtrudeAboveArchetype
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x709210", Offset = "0x707810", VA = "0x180709210", Slot = "37")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x6F1D00", Offset = "0x6F0300", VA = "0x1806F1D00", Slot = "42")]
		public override InteractionPointDefinition[] GetInteractionPointsDefinitions()
		{
			return null;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x2D83F40", Offset = "0x2D82540", VA = "0x182D83F40", Slot = "38")]
		public override IFaceVisual SetupFaceVisual(BlueprintFace face)
		{
			return null;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000021A4 File Offset: 0x000003A4
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x2D83F80", Offset = "0x2D82580", VA = "0x182D83F80", Slot = "39")]
		public override Vector3 CalcMiddlePos(BlueprintFace face)
		{
			return default(Vector3);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000021BC File Offset: 0x000003BC
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x2D84060", Offset = "0x2D82660", VA = "0x182D84060", Slot = "43")]
		public override Plane GetCastPlane(BlueprintFace face)
		{
			return default(Plane);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x2D841A0", Offset = "0x2D827A0", VA = "0x182D841A0", Slot = "40")]
		public override void CalcFaceTiles(BlueprintFace face, out Vector3Int tileFrom, out Vector3Int tileTo)
		{
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x2D84300", Offset = "0x2D82900", VA = "0x182D84300", Slot = "41")]
		public override void Generate(BlueprintStructuresGrid grid, BlueprintFace face, bool generateBuilt)
		{
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x2D84830", Offset = "0x2D82E30", VA = "0x182D84830", Slot = "44")]
		public override void PrepareGeneration(Vector3Int tileFrom, Transform blueprintTr, out float tileLength, out Vector3 tileOrigin, out Vector3 xTileAxis, out Vector3 yTileAxis)
		{
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x2D84E10", Offset = "0x2D83410", VA = "0x182D84E10")]
		private void SpawnPilarAndBeams(BlueprintStructuresGrid grid, Vector3Int tile, BlueprintFace face, Vector3 tileWorldCenterPos, Vector3 xTileAxis, Vector3 yTileAxis, Corners allowedPilars, Sides allowedSides)
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x2D85B20", Offset = "0x2D84120", VA = "0x182D85B20")]
		private void SpawnFloor(BlueprintStructuresGrid grid, Vector3Int tile, BlueprintFace face, Vector3 tileWorldCenterPos, Vector3 floorAxis, Sides backSupportSide)
		{
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000021D4 File Offset: 0x000003D4
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x2D85E20", Offset = "0x2D84420", VA = "0x182D85E20")]
		private Vector3 CalcLocalTileOrigin(BlueprintFace face, Vector3 blueprintSpaceSize, bool preservedTileAxis, float tileLength, float tileHeight)
		{
			return default(Vector3);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000021EC File Offset: 0x000003EC
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x2D86270", Offset = "0x2D84870", VA = "0x182D86270")]
		public bool IsShortestSideX(Vector3Int tileFrom, Vector3Int tileTo)
		{
			return default(bool);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002204 File Offset: 0x00000404
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x2D86290", Offset = "0x2D84890", VA = "0x182D86290")]
		public float CalcFloorTopToPilarTop()
		{
			return 0f;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x2D862D0", Offset = "0x2D848D0", VA = "0x182D862D0")]
		public void CalcAllowedPilars(Vector3Int tile, Vector3Int tileFrom, Vector3Int tileTo, out Corners allowedPilars, out Sides allowedSides)
		{
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		public FoundationArchetype()
		{
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x2D86440", Offset = "0x2D84A40", VA = "0x182D86440")]
		[CompilerGenerated]
		internal static void <CalcAllowedPilars>g__CalcSubdivisions|54_0(int tilePos, int tilePosFrom, int tilePosTo, out int nextSubdivisionFrom, out int nextSubdivisionTo)
		{
		}

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private VisualFader _hightlightPrefab;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private WallArchetype _wallArchetype;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ElementProfile _pilarElement;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ElementProfile _beamElement;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ElementProfile _strutElement;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ElementProfile _floorElement;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ElementProfile _pilarInteractionElement;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ElementProfile _beamInteractionElement;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ElementProfile _floorInteractionElement;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private ElementProfile _strutInteractionElement;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private VisualInstanceProvider _faceVisualInstanceProvider;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private InteractionPointDefinition[] _interactionPointsDefinitions;

		// Token: 0x02000008 RID: 8
		[Token(Token = "0x2000008")]
		public static class Utils
		{
			// Token: 0x02000009 RID: 9
			[Token(Token = "0x2000009")]
			public static class Beam
			{
				// Token: 0x1700001E RID: 30
				// (get) Token: 0x0600004D RID: 77 RVA: 0x0000221C File Offset: 0x0000041C
				// (set) Token: 0x0600004E RID: 78 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x1700001E")]
				public static Vector3 TileWorldCenterPos
				{
					[Token(Token = "0x600004D")]
					[Address(RVA = "0x2D864E0", Offset = "0x2D84AE0", VA = "0x182D864E0")]
					[CompilerGenerated]
					get
					{
						return default(Vector3);
					}
					[Token(Token = "0x600004E")]
					[Address(RVA = "0x2D86530", Offset = "0x2D84B30", VA = "0x182D86530")]
					[CompilerGenerated]
					private set
					{
					}
				}

				// Token: 0x0600004F RID: 79 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x600004F")]
				[Address(RVA = "0x2D86580", Offset = "0x2D84B80", VA = "0x182D86580")]
				public static void Setup(Vector3 xTileAxis, Vector3 yTileAxis, ElementProfile beamElement)
				{
				}

				// Token: 0x06000050 RID: 80 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x6000050")]
				[Address(RVA = "0x2D86670", Offset = "0x2D84C70", VA = "0x182D86670")]
				public static void Setup(Vector3 tileWorldCenterPos)
				{
				}

				// Token: 0x06000051 RID: 81 RVA: 0x00002234 File Offset: 0x00000434
				[Token(Token = "0x6000051")]
				[Address(RVA = "0x2D866C0", Offset = "0x2D84CC0", VA = "0x182D866C0")]
				internal static bool TryGenerate(BlueprintStructuresGrid grid, Vector3Int tile, Sides side, Vector3 axis, out BeamStructure beam)
				{
					return default(bool);
				}

				// Token: 0x06000052 RID: 82 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x6000052")]
				[Address(RVA = "0x2D86A00", Offset = "0x2D85000", VA = "0x182D86A00")]
				internal static void InitGhost(BeamStructure beam, float beamStructureToElementDistance, ElementProfile beamInteractionElement, ElementProfile beamElement)
				{
				}

				// Token: 0x06000053 RID: 83 RVA: 0x0000224C File Offset: 0x0000044C
				[Token(Token = "0x6000053")]
				[Address(RVA = "0x2D86CB0", Offset = "0x2D852B0", VA = "0x182D86CB0")]
				private static float CalcOffsetToTileCenter(ElementProfile beamElement)
				{
					return 0f;
				}

				// Token: 0x06000054 RID: 84 RVA: 0x00002264 File Offset: 0x00000464
				[Token(Token = "0x6000054")]
				[Address(RVA = "0x2D86CF0", Offset = "0x2D852F0", VA = "0x182D86CF0")]
				public static Vector3 CalcSidePos(Sides side)
				{
					return default(Vector3);
				}

				// Token: 0x06000055 RID: 85 RVA: 0x0000227C File Offset: 0x0000047C
				[Token(Token = "0x6000055")]
				[Address(RVA = "0x2D87080", Offset = "0x2D85680", VA = "0x182D87080")]
				public static Vector3 CalcBackPos()
				{
					return default(Vector3);
				}

				// Token: 0x06000056 RID: 86 RVA: 0x00002294 File Offset: 0x00000494
				[Token(Token = "0x6000056")]
				[Address(RVA = "0x2D871B0", Offset = "0x2D857B0", VA = "0x182D871B0")]
				public static Vector3 CalcForwardPos()
				{
					return default(Vector3);
				}

				// Token: 0x06000057 RID: 87 RVA: 0x000022AC File Offset: 0x000004AC
				[Token(Token = "0x6000057")]
				[Address(RVA = "0x2D872E0", Offset = "0x2D858E0", VA = "0x182D872E0")]
				public static Vector3 CalcLeftPos()
				{
					return default(Vector3);
				}

				// Token: 0x06000058 RID: 88 RVA: 0x000022C4 File Offset: 0x000004C4
				[Token(Token = "0x6000058")]
				[Address(RVA = "0x2D87410", Offset = "0x2D85A10", VA = "0x182D87410")]
				public static Vector3 CalcRightPos()
				{
					return default(Vector3);
				}

				// Token: 0x06000059 RID: 89 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x6000059")]
				[Address(RVA = "0x2D87540", Offset = "0x2D85B40", VA = "0x182D87540")]
				public static void LinkWithSupportingStructures(BlueprintStructuresGrid grid, BeamStructure ghostBeam, Vector3Int tile, Sides side)
				{
				}

				// Token: 0x04000021 RID: 33
				[Token(Token = "0x4000021")]
				[FieldOffset(Offset = "0xC")]
				private static Vector3 XTileAxis;

				// Token: 0x04000022 RID: 34
				[Token(Token = "0x4000022")]
				[FieldOffset(Offset = "0x18")]
				private static Vector3 YTileAxis;

				// Token: 0x04000023 RID: 35
				[Token(Token = "0x4000023")]
				[FieldOffset(Offset = "0x28")]
				private static ElementProfile BeamElement;
			}

			// Token: 0x0200000A RID: 10
			[Token(Token = "0x200000A")]
			public static class Floor
			{
				// Token: 0x0600005A RID: 90 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x600005A")]
				[Address(RVA = "0x2D87AA0", Offset = "0x2D860A0", VA = "0x182D87AA0")]
				public static void LinkWithSupportingStructures(BlueprintStructuresGrid grid, FloorStructure ghostFloor, Vector3Int tile, Sides backSupportSide)
				{
				}

				// Token: 0x0600005B RID: 91 RVA: 0x000022DC File Offset: 0x000004DC
				[Token(Token = "0x600005B")]
				[Address(RVA = "0x2D87F20", Offset = "0x2D86520", VA = "0x182D87F20")]
				public static Vector3 CalcFloorCenterPos(Vector3 tileWorldCenterPos)
				{
					return default(Vector3);
				}

				// Token: 0x0600005C RID: 92 RVA: 0x000022F4 File Offset: 0x000004F4
				[Token(Token = "0x600005C")]
				[Address(RVA = "0x2D87F50", Offset = "0x2D86550", VA = "0x182D87F50")]
				internal static bool TryGenerate(BlueprintStructuresGrid grid, Vector3Int tile, Vector3 pos, Vector3 axis, Sides backSupportSide, out FloorStructure floor)
				{
					return default(bool);
				}
			}

			// Token: 0x0200000B RID: 11
			[Token(Token = "0x200000B")]
			public static class Pilar
			{
				// Token: 0x0600005D RID: 93 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x600005D")]
				[Address(RVA = "0x2D88230", Offset = "0x2D86830", VA = "0x182D88230")]
				public static void Setup(Vector3 xTileAxis, Vector3 yTileAxis, ElementProfile pilarElement, float floorHeight)
				{
				}

				// Token: 0x0600005E RID: 94 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x600005E")]
				[Address(RVA = "0x2D88340", Offset = "0x2D86940", VA = "0x182D88340")]
				public static void Setup(Vector3 tileWorldCenterPos, bool isGroundLevel)
				{
				}

				// Token: 0x0600005F RID: 95 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x600005F")]
				[Address(RVA = "0x2D883B0", Offset = "0x2D869B0", VA = "0x182D883B0")]
				public static void InitGhost(PilarStructure pilar, float pilarTopHeight, float scale, ElementProfile InteractionElement, ElementProfile pilarElem)
				{
				}

				// Token: 0x06000060 RID: 96 RVA: 0x0000230C File Offset: 0x0000050C
				[Token(Token = "0x6000060")]
				[Address(RVA = "0x2D885F0", Offset = "0x2D86BF0", VA = "0x182D885F0")]
				public static bool TryGenerate(BlueprintStructuresGrid grid, Vector3Int tile, Corners corner, Quaternion pilarRot, out PilarStructure pilar, out float scale)
				{
					return default(bool);
				}

				// Token: 0x06000061 RID: 97 RVA: 0x00002324 File Offset: 0x00000524
				[Token(Token = "0x6000061")]
				[Address(RVA = "0x2D86CB0", Offset = "0x2D852B0", VA = "0x182D86CB0")]
				private static float CalcOffsetToTileCenter(ElementProfile pilarElement)
				{
					return 0f;
				}

				// Token: 0x06000062 RID: 98 RVA: 0x0000233C File Offset: 0x0000053C
				[Token(Token = "0x6000062")]
				[Address(RVA = "0x2D88810", Offset = "0x2D86E10", VA = "0x182D88810")]
				private static bool ValidateCastTarget(Ray cast, Collider targetCol)
				{
					return default(bool);
				}

				// Token: 0x06000063 RID: 99 RVA: 0x00002354 File Offset: 0x00000554
				[Token(Token = "0x6000063")]
				[Address(RVA = "0x2D88980", Offset = "0x2D86F80", VA = "0x182D88980")]
				private static Vector3 GetGroundPos(Vector3 worldPos, out float scale)
				{
					return default(Vector3);
				}

				// Token: 0x06000064 RID: 100 RVA: 0x0000236C File Offset: 0x0000056C
				[Token(Token = "0x6000064")]
				[Address(RVA = "0x2D88C90", Offset = "0x2D87290", VA = "0x182D88C90")]
				public static Vector3 CalcElementPos(Vector3 pilarPos, float pilarTopHeight)
				{
					return default(Vector3);
				}

				// Token: 0x06000065 RID: 101 RVA: 0x00002384 File Offset: 0x00000584
				[Token(Token = "0x6000065")]
				[Address(RVA = "0x2D88CC0", Offset = "0x2D872C0", VA = "0x182D88CC0")]
				public static Vector3 CalcCornerPos(Corners corner, out float scale)
				{
					return default(Vector3);
				}

				// Token: 0x06000066 RID: 102 RVA: 0x0000239C File Offset: 0x0000059C
				[Token(Token = "0x6000066")]
				[Address(RVA = "0x2D890C0", Offset = "0x2D876C0", VA = "0x182D890C0")]
				public static Vector3 CalcLeftBackPos(out float scale)
				{
					return default(Vector3);
				}

				// Token: 0x06000067 RID: 103 RVA: 0x000023B4 File Offset: 0x000005B4
				[Token(Token = "0x6000067")]
				[Address(RVA = "0x2D89220", Offset = "0x2D87820", VA = "0x182D89220")]
				public static Vector3 CalcLeftForwardPos(out float scale)
				{
					return default(Vector3);
				}

				// Token: 0x06000068 RID: 104 RVA: 0x000023CC File Offset: 0x000005CC
				[Token(Token = "0x6000068")]
				[Address(RVA = "0x2D89380", Offset = "0x2D87980", VA = "0x182D89380")]
				public static Vector3 CalcRightBackPos(out float scale)
				{
					return default(Vector3);
				}

				// Token: 0x06000069 RID: 105 RVA: 0x000023E4 File Offset: 0x000005E4
				[Token(Token = "0x6000069")]
				[Address(RVA = "0x2D894E0", Offset = "0x2D87AE0", VA = "0x182D894E0")]
				public static Vector3 CalcRightForwardPos(out float scale)
				{
					return default(Vector3);
				}

				// Token: 0x0600006A RID: 106 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x600006A")]
				[Address(RVA = "0x2D89640", Offset = "0x2D87C40", VA = "0x182D89640")]
				public static void LinkWithSupportingStructures(BlueprintStructuresGrid grid, PilarStructure ghostPilar, Vector3Int tile, Corners corner)
				{
				}

				// Token: 0x04000024 RID: 36
				[Token(Token = "0x4000024")]
				[FieldOffset(Offset = "0x0")]
				private static Vector3 TileWorldCenterPos;

				// Token: 0x04000025 RID: 37
				[Token(Token = "0x4000025")]
				[FieldOffset(Offset = "0xC")]
				private static Vector3 XTileAxis;

				// Token: 0x04000026 RID: 38
				[Token(Token = "0x4000026")]
				[FieldOffset(Offset = "0x18")]
				private static Vector3 YTileAxis;

				// Token: 0x04000027 RID: 39
				[Token(Token = "0x4000027")]
				[FieldOffset(Offset = "0x24")]
				private static float FloorHeight;

				// Token: 0x04000028 RID: 40
				[Token(Token = "0x4000028")]
				[FieldOffset(Offset = "0x28")]
				private static bool IsGroundLevel;

				// Token: 0x04000029 RID: 41
				[Token(Token = "0x4000029")]
				[FieldOffset(Offset = "0x30")]
				private static ElementProfile PilarElement;
			}

			// Token: 0x0200000C RID: 12
			[Token(Token = "0x200000C")]
			public static class Strut
			{
				// Token: 0x0600006B RID: 107 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x600006B")]
				[Address(RVA = "0x2D89C90", Offset = "0x2D88290", VA = "0x182D89C90")]
				public static void Setup(Vector3 xTileAxis, Vector3 yTileAxis, ElementProfile strutElement)
				{
				}

				// Token: 0x0600006C RID: 108 RVA: 0x000023FC File Offset: 0x000005FC
				[Token(Token = "0x600006C")]
				[Address(RVA = "0x2D89D80", Offset = "0x2D88380", VA = "0x182D89D80")]
				internal static bool TryGenerate(BlueprintStructuresGrid grid, Vector3Int tile, Corners corner, Sides side, Vector3 axis, out StrutStructure strut)
				{
					return default(bool);
				}

				// Token: 0x0600006D RID: 109 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x600006D")]
				[Address(RVA = "0x2D8A0C0", Offset = "0x2D886C0", VA = "0x182D8A0C0")]
				internal static void InitGhost(StrutStructure strut, float beamStructureToElementDistance, ElementProfile strutInteractionElement, ElementProfile strutElement)
				{
				}

				// Token: 0x0600006E RID: 110 RVA: 0x00002414 File Offset: 0x00000614
				[Token(Token = "0x600006E")]
				[Address(RVA = "0x2D8A440", Offset = "0x2D88A40", VA = "0x182D8A440")]
				private static float CalcOffsetToTileCenter(ElementProfile beamElement)
				{
					return 0f;
				}

				// Token: 0x0600006F RID: 111 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x600006F")]
				[Address(RVA = "0x2D8A480", Offset = "0x2D88A80", VA = "0x182D8A480")]
				public static void LinkWithSupportingStructures(BlueprintStructuresGrid grid, StrutStructure ghostStrut, Vector3Int tile, Corners corner, Sides side)
				{
				}

				// Token: 0x0400002A RID: 42
				[Token(Token = "0x400002A")]
				[FieldOffset(Offset = "0x0")]
				private static Vector3 XTileAxis;

				// Token: 0x0400002B RID: 43
				[Token(Token = "0x400002B")]
				[FieldOffset(Offset = "0xC")]
				private static Vector3 YTileAxis;

				// Token: 0x0400002C RID: 44
				[Token(Token = "0x400002C")]
				[FieldOffset(Offset = "0x18")]
				private static ElementProfile StrutElement;
			}
		}
	}
}
