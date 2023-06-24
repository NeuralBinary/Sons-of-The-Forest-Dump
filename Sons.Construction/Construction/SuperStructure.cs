using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Ai;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200009D RID: 157
	[Token(Token = "0x200009D")]
	[Serializable]
	public class SuperStructure : IProcessableSuperStructure
	{
		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060003FC RID: 1020 RVA: 0x00003AF4 File Offset: 0x00001CF4
		[Token(Token = "0x17000164")]
		public virtual float GridTileHeight
		{
			[Token(Token = "0x60003FC")]
			[Address(RVA = "0x2D806B0", Offset = "0x2D7ECB0", VA = "0x182D806B0", Slot = "7")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x00003B0C File Offset: 0x00001D0C
		[Token(Token = "0x17000165")]
		public virtual float GridTileLength
		{
			[Token(Token = "0x60003FD")]
			[Address(RVA = "0xE7F800", Offset = "0xE7DE00", VA = "0x180E7F800", Slot = "8")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x00003B24 File Offset: 0x00001D24
		[Token(Token = "0x17000166")]
		public virtual float GridTileHalfLength
		{
			[Token(Token = "0x60003FE")]
			[Address(RVA = "0x2D86CB0", Offset = "0x2D852B0", VA = "0x182D86CB0", Slot = "9")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060003FF RID: 1023 RVA: 0x00003B3C File Offset: 0x00001D3C
		[Token(Token = "0x17000167")]
		public int CountNodes
		{
			[Token(Token = "0x60003FF")]
			[Address(RVA = "0x2DD02B0", Offset = "0x2DCE8B0", VA = "0x182DD02B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000168")]
		public IReadOnlyList<SuperStructure.Room> Rooms
		{
			[Token(Token = "0x6000400")]
			[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000401 RID: 1025 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000169")]
		public IReadOnlyList<SuperStructure.Room> OcclusionRooms
		{
			[Token(Token = "0x6000401")]
			[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x00003B54 File Offset: 0x00001D54
		[Token(Token = "0x1700016A")]
		public Quaternion Rotation
		{
			[Token(Token = "0x6000402")]
			[Address(RVA = "0x2D40560", Offset = "0x2D3EB60", VA = "0x182D40560")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000403 RID: 1027 RVA: 0x00003B6C File Offset: 0x00001D6C
		[Token(Token = "0x1700016B")]
		public Quaternion CeilingsDebugRotation
		{
			[Token(Token = "0x6000403")]
			[Address(RVA = "0x2DD02F0", Offset = "0x2DCE8F0", VA = "0x182DD02F0")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x00003B84 File Offset: 0x00001D84
		[Token(Token = "0x1700016C")]
		public Vector3 WorldForward
		{
			[Token(Token = "0x6000404")]
			[Address(RVA = "0x179DC20", Offset = "0x179C220", VA = "0x18179DC20")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000405 RID: 1029 RVA: 0x00003B9C File Offset: 0x00001D9C
		[Token(Token = "0x1700016D")]
		public Vector3 WorldRight
		{
			[Token(Token = "0x6000405")]
			[Address(RVA = "0x70DB10", Offset = "0x70C110", VA = "0x18070DB10")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x00003BB4 File Offset: 0x00001DB4
		// (set) Token: 0x06000407 RID: 1031 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700016E")]
		public Bounds AABBBounds
		{
			[Token(Token = "0x6000406")]
			[Address(RVA = "0x167A0A0", Offset = "0x16786A0", VA = "0x18167A0A0")]
			[CompilerGenerated]
			get
			{
				return default(Bounds);
			}
			[Token(Token = "0x6000407")]
			[Address(RVA = "0x179C8B0", Offset = "0x179AEB0", VA = "0x18179C8B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000409 RID: 1033 RVA: 0x00003BCC File Offset: 0x00001DCC
		// (set) Token: 0x06000408 RID: 1032 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700016F")]
		public BoundsInt GridBounds
		{
			[Token(Token = "0x6000409")]
			[Address(RVA = "0x2DD0320", Offset = "0x2DCE920", VA = "0x182DD0320")]
			get
			{
				return default(BoundsInt);
			}
			[Token(Token = "0x6000408")]
			[Address(RVA = "0x2DD0300", Offset = "0x2DCE900", VA = "0x182DD0300")]
			set
			{
			}
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00003BE4 File Offset: 0x00001DE4
		[Token(Token = "0x600040A")]
		[Address(RVA = "0x2DD0340", Offset = "0x2DCE940", VA = "0x182DD0340")]
		public static bool TryGetNewSuperStructure(IStructure origin, out SuperStructure ss)
		{
			return default(bool);
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600040B")]
		[Address(RVA = "0x2DD0700", Offset = "0x2DCED00", VA = "0x182DD0700")]
		protected SuperStructure(IMonoBehaviour origin, bool followAngle)
		{
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00003BFC File Offset: 0x00001DFC
		[Token(Token = "0x600040C")]
		[Address(RVA = "0x2DD1700", Offset = "0x2DCFD00", VA = "0x182DD1700")]
		private bool TryCalculateOrientation(Transform tr, out bool isForwardAligned)
		{
			return default(bool);
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600040D")]
		[Address(RVA = "0x2DD17B0", Offset = "0x2DCFDB0", VA = "0x182DD17B0")]
		public void Register(WallStructure wall)
		{
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600040E")]
		[Address(RVA = "0x2DD1C80", Offset = "0x2DD0280", VA = "0x182DD1C80")]
		public void Unregister(WallStructure wall)
		{
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600040F")]
		[Address(RVA = "0x2DD1F50", Offset = "0x2DD0550", VA = "0x182DD1F50")]
		public void Register(RampStructure ramp)
		{
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000410")]
		[Address(RVA = "0x2DD28D0", Offset = "0x2DD0ED0", VA = "0x182DD28D0")]
		public void Unregister(RampStructure ramp)
		{
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00003C14 File Offset: 0x00001E14
		[Token(Token = "0x6000411")]
		[Address(RVA = "0x2DD2B40", Offset = "0x2DD1140", VA = "0x182DD2B40")]
		private static SuperStructure.TileSlots GetRampNavTileSlots(SuperStructure.TileSlots rampFlags)
		{
			return SuperStructure.TileSlots.None;
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000412")]
		[Address(RVA = "0x2DD2B80", Offset = "0x2DD1180", VA = "0x182DD2B80")]
		public void Register(ITileCenter middle)
		{
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000413")]
		[Address(RVA = "0x2DD2F10", Offset = "0x2DD1510", VA = "0x182DD2F10")]
		public void Unregister(ITileCenter middle)
		{
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000414")]
		[Address(RVA = "0x2DD30C0", Offset = "0x2DD16C0", VA = "0x182DD30C0")]
		private void Register(ISuperStructureNode node, Vector3Int tile)
		{
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00003C2C File Offset: 0x00001E2C
		[Token(Token = "0x6000415")]
		[Address(RVA = "0x2DD3190", Offset = "0x2DD1790", VA = "0x182DD3190")]
		private bool Unregister(ISuperStructureNode node)
		{
			return default(bool);
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00003C44 File Offset: 0x00001E44
		[Token(Token = "0x6000416")]
		[Address(RVA = "0x2DD31F0", Offset = "0x2DD17F0", VA = "0x182DD31F0")]
		public Vector3Int CalcTileFromWorldPos(Vector3 worldPos)
		{
			return default(Vector3Int);
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00003C5C File Offset: 0x00001E5C
		[Token(Token = "0x6000417")]
		[Address(RVA = "0x2DD33B0", Offset = "0x2DD19B0", VA = "0x182DD33B0")]
		public Vector3 CalcWorldPosFromTile(Vector3Int tile)
		{
			return default(Vector3);
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00003C74 File Offset: 0x00001E74
		[Token(Token = "0x6000418")]
		[Address(RVA = "0x2DD34F0", Offset = "0x2DD1AF0", VA = "0x182DD34F0")]
		public Vector3 CalcWorldPosFromTileF(Vector3 tile)
		{
			return default(Vector3);
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00003C8C File Offset: 0x00001E8C
		[Token(Token = "0x6000419")]
		[Address(RVA = "0x2DD3620", Offset = "0x2DD1C20", VA = "0x182DD3620")]
		private bool UpdateDirectionFlagsOnTile(Vector3Int tile, SuperStructure.TileSlots setFlags, SuperStructure.TileSlots allDirFlags)
		{
			return default(bool);
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x00003CA4 File Offset: 0x00001EA4
		[Token(Token = "0x600041A")]
		[Address(RVA = "0x2DD3790", Offset = "0x2DD1D90", VA = "0x182DD3790")]
		private bool TrySetSlotOnTile(Vector3Int tile, SuperStructure.TileSlots slots)
		{
			return default(bool);
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00003CBC File Offset: 0x00001EBC
		[Token(Token = "0x600041B")]
		[Address(RVA = "0x2DD3900", Offset = "0x2DD1F00", VA = "0x182DD3900")]
		private bool TryUnsetSlotOnTile(Vector3Int tile, SuperStructure.TileSlots slots)
		{
			return default(bool);
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600041C")]
		[Address(RVA = "0x2DD3A70", Offset = "0x2DD2070", VA = "0x182DD3A70")]
		protected void RefreshGridBounds(IEnumerable<Vector3Int> allCoords)
		{
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600041D")]
		[Address(RVA = "0x2DD4100", Offset = "0x2DD2700", VA = "0x182DD4100")]
		protected void RefreshGridBounds(BoundsInt bounds)
		{
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00003CD4 File Offset: 0x00001ED4
		[Token(Token = "0x600041E")]
		[Address(RVA = "0x2DD4B30", Offset = "0x2DD3130", VA = "0x182DD4B30")]
		public bool CanIntegrate(SuperStructure otherSuperStructure)
		{
			return default(bool);
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00003CEC File Offset: 0x00001EEC
		[Token(Token = "0x600041F")]
		[Address(RVA = "0x2DD4CE0", Offset = "0x2DD32E0", VA = "0x182DD4CE0")]
		public bool IsOnGridCorner(PilarStructure pilar)
		{
			return default(bool);
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00003D04 File Offset: 0x00001F04
		[Token(Token = "0x6000420")]
		[Address(RVA = "0x2DD4FB0", Offset = "0x2DD35B0", VA = "0x182DD4FB0")]
		private static bool IsOnGrid(float gridWorldOrigin, float testingWorldVal, float gridSize = 2.53f, float tolerance = 0.0001f)
		{
			return default(bool);
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000421")]
		[Address(RVA = "0x2DD5080", Offset = "0x2DD3680", VA = "0x182DD5080")]
		public void Integrate(SuperStructure otherSuperStructure)
		{
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000422")]
		[Address(RVA = "0x2DD5920", Offset = "0x2DD3F20", VA = "0x182DD5920")]
		public void ShowGizmos()
		{
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00003D1C File Offset: 0x00001F1C
		[Token(Token = "0x6000423")]
		[Address(RVA = "0x2DD6140", Offset = "0x2DD4740", VA = "0x182DD6140")]
		public Vector3 CalcSize(Vector3Int fromTile, Vector3Int toTile, float sizeOffset)
		{
			return default(Vector3);
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00003D34 File Offset: 0x00001F34
		[Token(Token = "0x6000424")]
		[Address(RVA = "0x2DD6230", Offset = "0x2DD4830", VA = "0x182DD6230")]
		private bool HasFlag(SuperStructure.TileSlots flags, SuperStructure.TileSlots checkFlags)
		{
			return default(bool);
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00003D4C File Offset: 0x00001F4C
		[Token(Token = "0x6000425")]
		[Address(RVA = "0x2DD6230", Offset = "0x2DD4830", VA = "0x182DD6230")]
		private bool HasFlag(SuperStructure.NavLinkFlags flags, SuperStructure.NavLinkFlags checkFlags)
		{
			return default(bool);
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000426")]
		[Address(RVA = "0x2DD6240", Offset = "0x2DD4840", VA = "0x182DD6240", Slot = "6")]
		private void GenerateNavMesh()
		{
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000427")]
		[Address(RVA = "0x2DD6510", Offset = "0x2DD4B10", VA = "0x182DD6510")]
		private void RemoveIsolatedQuads()
		{
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000428")]
		[Address(RVA = "0x2DD7620", Offset = "0x2DD5C20", VA = "0x182DD7620")]
		private void CreateQuadMeshFromGrid()
		{
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000429")]
		[Address(RVA = "0x2DD7900", Offset = "0x2DD5F00", VA = "0x182DD7900")]
		private void AddFloorQuads()
		{
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600042A")]
		[Address(RVA = "0x2DD7C80", Offset = "0x2DD6280", VA = "0x182DD7C80")]
		private void AddLinksBetweenQuads(bool checkReachable)
		{
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00003D64 File Offset: 0x00001F64
		[Token(Token = "0x600042B")]
		[Address(RVA = "0x2DD8390", Offset = "0x2DD6990", VA = "0x182DD8390")]
		public int TryConnectToTerrain()
		{
			return 0;
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600042C")]
		[Address(RVA = "0x2DD9010", Offset = "0x2DD7610", VA = "0x182DD9010")]
		private void AddCenterLink(Vector3Int tile)
		{
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600042D")]
		[Address(RVA = "0x2DD92F0", Offset = "0x2DD78F0", VA = "0x182DD92F0")]
		private void SetGridLinkFlag(Vector3Int tile, int newFlag)
		{
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600042E")]
		[Address(RVA = "0x2DD9460", Offset = "0x2DD7A60", VA = "0x182DD9460")]
		private void AddLinkQuad(Vector3Int tile1, Vector3Int tile2, Vector3Int dir)
		{
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600042F")]
		[Address(RVA = "0x2DD98E0", Offset = "0x2DD7EE0", VA = "0x182DD98E0")]
		private void CheckRampNeighborLink(Vector3Int tilePos, Vector3Int tileDir, float worldY)
		{
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000430")]
		[Address(RVA = "0x2DD9AC0", Offset = "0x2DD80C0", VA = "0x182DD9AC0")]
		private void AddRampLinkQuad(Vector3Int tilePos, SuperStructure.TileSlots tileFlags)
		{
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000431")]
		[Address(RVA = "0x2DD9EC0", Offset = "0x2DD84C0", VA = "0x182DD9EC0")]
		private void AddQuadTriangles(int q1, int q2, int q3, int q4)
		{
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000432")]
		[Address(RVA = "0x2DDA150", Offset = "0x2DD8750", VA = "0x182DDA150")]
		private void AddQuad(Vector3 center, Quaternion rotation, float slope, SuperStructure.TileSlots flags, float margin = 0f)
		{
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00003D7C File Offset: 0x00001F7C
		[Token(Token = "0x6000433")]
		[Address(RVA = "0x2DDA970", Offset = "0x2DD8F70", VA = "0x182DDA970")]
		private Vector3 GetQuadEdgeMidpoint(int quadStart, Vector3Int edgeDir)
		{
			return default(Vector3);
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00003D94 File Offset: 0x00001F94
		[Token(Token = "0x6000434")]
		[Address(RVA = "0x2DDAD80", Offset = "0x2DD9380", VA = "0x182DDAD80")]
		private Vector3 GridCellExtent()
		{
			return default(Vector3);
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00003DAC File Offset: 0x00001FAC
		[Token(Token = "0x6000435")]
		[Address(RVA = "0x2DDAE70", Offset = "0x2DD9470", VA = "0x182DDAE70")]
		private bool IsTileWalkable(Vector3Int tilePos, out SuperStructure.TileSlots flags)
		{
			return default(bool);
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00003DC4 File Offset: 0x00001FC4
		[Token(Token = "0x6000436")]
		[Address(RVA = "0x2DDAF50", Offset = "0x2DD9550", VA = "0x182DDAF50")]
		private bool IsTileWalkableFloor(Vector3Int tilePos, out SuperStructure.TileSlots flags)
		{
			return default(bool);
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00003DDC File Offset: 0x00001FDC
		[Token(Token = "0x6000437")]
		[Address(RVA = "0x2DDB040", Offset = "0x2DD9640", VA = "0x182DDB040")]
		private bool IsWalkable(SuperStructure.TileSlots flags)
		{
			return default(bool);
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000438")]
		[Address(RVA = "0x2DDB060", Offset = "0x2DD9660", VA = "0x182DDB060", Slot = "4")]
		private void ProcessRooms()
		{
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000439")]
		[Address(RVA = "0x2DDC910", Offset = "0x2DDAF10", VA = "0x182DDC910", Slot = "5")]
		private void ProcessOcclusionRooms()
		{
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600043A")]
		[Address(RVA = "0x2DDCAD0", Offset = "0x2DDB0D0", VA = "0x182DDCAD0")]
		private void EvaluateRoom(SuperStructure.Room room)
		{
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600043B")]
		[Address(RVA = "0x2DDD0F0", Offset = "0x2DDB6F0", VA = "0x182DDD0F0")]
		private void EvaluateRoomIsGrounded(SuperStructure.Room room)
		{
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600043C")]
		[Address(RVA = "0x2DDD290", Offset = "0x2DDB890", VA = "0x182DDD290")]
		private static Vector3Int[] CalcCornerCoords(SuperStructure.Room room, out SuperStructure.TileSlots[] searchedSideSlots)
		{
			return null;
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600043D")]
		[Address(RVA = "0x2DDD430", Offset = "0x2DDBA30", VA = "0x182DDD430")]
		private void EvaluateRoomConnexions(SuperStructure.Room roomA, int r)
		{
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600043E")]
		[Address(RVA = "0x2DDD610", Offset = "0x2DDBC10", VA = "0x182DDD610")]
		private void PropagateIsSealedFlagToConnexions(SuperStructure.Room roomA)
		{
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00003DF4 File Offset: 0x00001FF4
		[Token(Token = "0x600043F")]
		[Address(RVA = "0x2DDD7A0", Offset = "0x2DDBDA0", VA = "0x182DDD7A0")]
		public bool IsAboveRoofForColumn(Vector3 worldPos)
		{
			return default(bool);
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00003E0C File Offset: 0x0000200C
		[Token(Token = "0x6000440")]
		[Address(RVA = "0x2DDD910", Offset = "0x2DDBF10", VA = "0x182DDD910")]
		public bool IsWithinAnyRoom(Vector3 worldPos, out SuperStructure.Room foundRoom)
		{
			return default(bool);
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00003E24 File Offset: 0x00002024
		[Token(Token = "0x6000441")]
		[Address(RVA = "0x2DDD980", Offset = "0x2DDBF80", VA = "0x182DDD980")]
		private bool IsWithinAnyRoom(Vector3Int tileCoords, out SuperStructure.Room foundRoom)
		{
			return default(bool);
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x00003E3C File Offset: 0x0000203C
		[Token(Token = "0x6000442")]
		[Address(RVA = "0x2DDDB90", Offset = "0x2DDC190", VA = "0x182DDDB90")]
		[CompilerGenerated]
		private bool <Construction.IProcessableSuperStructure.ProcessRooms>g__TryGetGroundTile|100_0(List<Vector3Int> allCoords, ref int groundTileNum, out Vector3Int groundTile, ref SuperStructure.<>c__DisplayClass100_0 A_4)
		{
			return default(bool);
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00003E54 File Offset: 0x00002054
		[Token(Token = "0x6000443")]
		[Address(RVA = "0x2DDDCF0", Offset = "0x2DDC2F0", VA = "0x182DDDCF0")]
		[CompilerGenerated]
		private bool <Construction.IProcessableSuperStructure.ProcessRooms>g__SearchXAxisTileSlot|100_1(Vector3Int fromCoords, int toX, SuperStructure.TileSlots slotSearched, SuperStructure.TileSlots searchBreak, out bool foundHole, ref SuperStructure.<>c__DisplayClass100_0 A_6)
		{
			return default(bool);
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x00003E6C File Offset: 0x0000206C
		[Token(Token = "0x6000444")]
		[Address(RVA = "0x2DDDE40", Offset = "0x2DDC440", VA = "0x182DDDE40")]
		[CompilerGenerated]
		private bool <Construction.IProcessableSuperStructure.ProcessRooms>g__SearchZAxisTileSlot|100_2(Vector3Int fromCoords, int toZ, SuperStructure.TileSlots slotSearched, SuperStructure.TileSlots searchBreak, out bool foundHole, ref SuperStructure.<>c__DisplayClass100_0 A_6)
		{
			return default(bool);
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x00003E84 File Offset: 0x00002084
		[Token(Token = "0x6000445")]
		[Address(RVA = "0x2DDDFA0", Offset = "0x2DDC5A0", VA = "0x182DDDFA0")]
		[CompilerGenerated]
		private bool <Construction.IProcessableSuperStructure.ProcessRooms>g__SearchYAxisTileSlot|100_3(Vector3Int fromCoords, Vector3Int toCoords, SuperStructure.TileSlots slotSearched, ref SuperStructure.<>c__DisplayClass100_0 A_4)
		{
			return default(bool);
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000446")]
		[Address(RVA = "0x2DDE130", Offset = "0x2DDC730", VA = "0x182DDE130")]
		[CompilerGenerated]
		private void <Construction.IProcessableSuperStructure.ProcessRooms>g__FryUsedCoordsLine|100_4(Vector3Int fromCoords, int toZ, ref SuperStructure.<>c__DisplayClass100_0 A_3)
		{
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000447")]
		[Address(RVA = "0x2DDE270", Offset = "0x2DDC870", VA = "0x182DDE270")]
		[CompilerGenerated]
		private void <Construction.IProcessableSuperStructure.ProcessRooms>g__FryUsedCoords|100_5(Vector3Int fromCoords, Vector3Int toCoords, ref SuperStructure.<>c__DisplayClass100_0 A_3)
		{
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000448")]
		[Address(RVA = "0x2DDE350", Offset = "0x2DDC950", VA = "0x182DDE350")]
		[CompilerGenerated]
		private void <EvaluateRoom>g__ProcessTile|102_0(Vector3Int coords, SuperStructure.TileSlots searchedSideSlot, bool processCeiling, ref SuperStructure.<>c__DisplayClass102_0 A_4)
		{
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00003E9C File Offset: 0x0000209C
		[Token(Token = "0x6000449")]
		[Address(RVA = "0x2DDE440", Offset = "0x2DDCA40", VA = "0x182DDE440")]
		[CompilerGenerated]
		internal static bool <EvaluateRoomConnexions>g__RoomsAreTouching|105_0(SuperStructure.Room roomA, SuperStructure.Room roomB)
		{
			return default(bool);
		}

		// Token: 0x040003CA RID: 970
		[Token(Token = "0x40003CA")]
		[FieldOffset(Offset = "0x10")]
		private Vector3 _worldOrigin;

		// Token: 0x040003CB RID: 971
		[Token(Token = "0x40003CB")]
		[FieldOffset(Offset = "0x1C")]
		private BoundsInt _gridBounds;

		// Token: 0x040003CC RID: 972
		[Token(Token = "0x40003CC")]
		[FieldOffset(Offset = "0x38")]
		private readonly Dictionary<Vector3Int, SuperStructure.TileSlots> _grid;

		// Token: 0x040003CD RID: 973
		[Token(Token = "0x40003CD")]
		[FieldOffset(Offset = "0x40")]
		private readonly Dictionary<ISuperStructureNode, Vector3Int> _nodes;

		// Token: 0x040003CE RID: 974
		[Token(Token = "0x40003CE")]
		[FieldOffset(Offset = "0x48")]
		protected readonly List<SuperStructure.Room> _rooms;

		// Token: 0x040003CF RID: 975
		[Token(Token = "0x40003CF")]
		[FieldOffset(Offset = "0x50")]
		protected readonly Dictionary<int, List<SuperStructure.Room>> _roomsPerLevel;

		// Token: 0x040003D0 RID: 976
		[Token(Token = "0x40003D0")]
		[FieldOffset(Offset = "0x58")]
		protected readonly List<SuperStructure.Room> _occlusionRooms;

		// Token: 0x040003D1 RID: 977
		[Token(Token = "0x40003D1")]
		[FieldOffset(Offset = "0x60")]
		private readonly OcclusionRoomsProcessor _occlusionRoomsProcessor;

		// Token: 0x040003D7 RID: 983
		[Token(Token = "0x40003D7")]
		private const bool NavMeshCreationEnabled = true;

		// Token: 0x040003D8 RID: 984
		[Token(Token = "0x40003D8")]
		private const float EdgeMargin = 0.6f;

		// Token: 0x040003D9 RID: 985
		[Token(Token = "0x40003D9")]
		private const float NavLinkMaxDistance = 0.5f;

		// Token: 0x040003DA RID: 986
		[Token(Token = "0x40003DA")]
		[FieldOffset(Offset = "0xB8")]
		private NavMeshCustomMeshAdd _customNavMesh;

		// Token: 0x040003DB RID: 987
		[Token(Token = "0x40003DB")]
		[FieldOffset(Offset = "0xC0")]
		private readonly Dictionary<Vector3Int, int> _gridQuadStart;

		// Token: 0x040003DC RID: 988
		[Token(Token = "0x40003DC")]
		[FieldOffset(Offset = "0xC8")]
		private readonly Dictionary<Vector3Int, Vector3> _gridFloorCenter;

		// Token: 0x040003DD RID: 989
		[Token(Token = "0x40003DD")]
		[FieldOffset(Offset = "0xD0")]
		private readonly Dictionary<Vector3Int, float> _gridTileSlope;

		// Token: 0x040003DE RID: 990
		[Token(Token = "0x40003DE")]
		[FieldOffset(Offset = "0xD8")]
		private readonly Dictionary<Vector3Int, SuperStructure.NavLinkFlags> _gridLinks;

		// Token: 0x040003DF RID: 991
		[Token(Token = "0x40003DF")]
		[FieldOffset(Offset = "0xE0")]
		private readonly Dictionary<Vector3Int, bool> _gridReachable;

		// Token: 0x040003E0 RID: 992
		[Token(Token = "0x40003E0")]
		[FieldOffset(Offset = "0xE8")]
		private List<Vector3> _meshPoints;

		// Token: 0x040003E1 RID: 993
		[Token(Token = "0x40003E1")]
		[FieldOffset(Offset = "0xF0")]
		private List<int> _meshIndices;

		// Token: 0x040003E2 RID: 994
		[Token(Token = "0x40003E2")]
		[FieldOffset(Offset = "0xF8")]
		private readonly List<Vector3Int> _newReachable;

		// Token: 0x040003E3 RID: 995
		[Token(Token = "0x40003E3")]
		[FieldOffset(Offset = "0x100")]
		private readonly List<Vector3Int> _cachedNewReachable;

		// Token: 0x0200009E RID: 158
		[Token(Token = "0x200009E")]
		[Flags]
		public enum TileSlots
		{
			// Token: 0x040003E5 RID: 997
			[Token(Token = "0x40003E5")]
			None = 0,
			// Token: 0x040003E6 RID: 998
			[Token(Token = "0x40003E6")]
			BackSide = 2,
			// Token: 0x040003E7 RID: 999
			[Token(Token = "0x40003E7")]
			LeftSide = 4,
			// Token: 0x040003E8 RID: 1000
			[Token(Token = "0x40003E8")]
			ForwardSide = 8,
			// Token: 0x040003E9 RID: 1001
			[Token(Token = "0x40003E9")]
			RightSide = 16,
			// Token: 0x040003EA RID: 1002
			[Token(Token = "0x40003EA")]
			Floor = 32,
			// Token: 0x040003EB RID: 1003
			[Token(Token = "0x40003EB")]
			Ceiling = 64,
			// Token: 0x040003EC RID: 1004
			[Token(Token = "0x40003EC")]
			DoorBack = 128,
			// Token: 0x040003ED RID: 1005
			[Token(Token = "0x40003ED")]
			DoorLeft = 256,
			// Token: 0x040003EE RID: 1006
			[Token(Token = "0x40003EE")]
			DoorForward = 512,
			// Token: 0x040003EF RID: 1007
			[Token(Token = "0x40003EF")]
			DoorRight = 1024,
			// Token: 0x040003F0 RID: 1008
			[Token(Token = "0x40003F0")]
			BlockNavBack = 2048,
			// Token: 0x040003F1 RID: 1009
			[Token(Token = "0x40003F1")]
			BlockNavLeft = 4096,
			// Token: 0x040003F2 RID: 1010
			[Token(Token = "0x40003F2")]
			BlockNavForward = 8192,
			// Token: 0x040003F3 RID: 1011
			[Token(Token = "0x40003F3")]
			BlockNavRight = 16384,
			// Token: 0x040003F4 RID: 1012
			[Token(Token = "0x40003F4")]
			RampBack = 32768,
			// Token: 0x040003F5 RID: 1013
			[Token(Token = "0x40003F5")]
			RampForward = 65536,
			// Token: 0x040003F6 RID: 1014
			[Token(Token = "0x40003F6")]
			RampLeft = 131072,
			// Token: 0x040003F7 RID: 1015
			[Token(Token = "0x40003F7")]
			RampRight = 262144,
			// Token: 0x040003F8 RID: 1016
			[Token(Token = "0x40003F8")]
			AllSides = 30,
			// Token: 0x040003F9 RID: 1017
			[Token(Token = "0x40003F9")]
			AllRamps = 491520,
			// Token: 0x040003FA RID: 1018
			[Token(Token = "0x40003FA")]
			AllGrounds = 491552,
			// Token: 0x040003FB RID: 1019
			[Token(Token = "0x40003FB")]
			AllLeftSide = 4356,
			// Token: 0x040003FC RID: 1020
			[Token(Token = "0x40003FC")]
			AllRightSide = 17424,
			// Token: 0x040003FD RID: 1021
			[Token(Token = "0x40003FD")]
			AllForwardSide = 8712,
			// Token: 0x040003FE RID: 1022
			[Token(Token = "0x40003FE")]
			AllBackSide = 2178
		}

		// Token: 0x0200009F RID: 159
		[Token(Token = "0x200009F")]
		[Flags]
		private enum NavLinkFlags
		{
			// Token: 0x04000400 RID: 1024
			[Token(Token = "0x4000400")]
			Left = 1,
			// Token: 0x04000401 RID: 1025
			[Token(Token = "0x4000401")]
			Right = 2,
			// Token: 0x04000402 RID: 1026
			[Token(Token = "0x4000402")]
			Forward = 4,
			// Token: 0x04000403 RID: 1027
			[Token(Token = "0x4000403")]
			Back = 8,
			// Token: 0x04000404 RID: 1028
			[Token(Token = "0x4000404")]
			LeftUp = 16,
			// Token: 0x04000405 RID: 1029
			[Token(Token = "0x4000405")]
			RightUp = 32,
			// Token: 0x04000406 RID: 1030
			[Token(Token = "0x4000406")]
			ForwardUp = 64,
			// Token: 0x04000407 RID: 1031
			[Token(Token = "0x4000407")]
			BackUp = 128,
			// Token: 0x04000408 RID: 1032
			[Token(Token = "0x4000408")]
			LeftDown = 256,
			// Token: 0x04000409 RID: 1033
			[Token(Token = "0x4000409")]
			RightDown = 512,
			// Token: 0x0400040A RID: 1034
			[Token(Token = "0x400040A")]
			ForwardDown = 1024,
			// Token: 0x0400040B RID: 1035
			[Token(Token = "0x400040B")]
			BackDown = 2048,
			// Token: 0x0400040C RID: 1036
			[Token(Token = "0x400040C")]
			Terrain = 4096
		}

		// Token: 0x020000A0 RID: 160
		[Token(Token = "0x20000A0")]
		[Serializable]
		public class Room
		{
			// Token: 0x17000170 RID: 368
			// (get) Token: 0x0600044A RID: 1098 RVA: 0x00003EB4 File Offset: 0x000020B4
			// (set) Token: 0x0600044B RID: 1099 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000170")]
			public float WorldBottomHeight
			{
				[Token(Token = "0x600044A")]
				[Address(RVA = "0x71D320", Offset = "0x71B920", VA = "0x18071D320")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x600044B")]
				[Address(RVA = "0x207C3C0", Offset = "0x207A9C0", VA = "0x18207C3C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000171 RID: 369
			// (get) Token: 0x0600044C RID: 1100 RVA: 0x00003ECC File Offset: 0x000020CC
			// (set) Token: 0x0600044D RID: 1101 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000171")]
			public Vector3 WorldCenter
			{
				[Token(Token = "0x600044C")]
				[Address(RVA = "0x2D59F20", Offset = "0x2D58520", VA = "0x182D59F20")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600044D")]
				[Address(RVA = "0x2DDE4D0", Offset = "0x2DDCAD0", VA = "0x182DDE4D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000172 RID: 370
			// (get) Token: 0x0600044E RID: 1102 RVA: 0x00003EE4 File Offset: 0x000020E4
			// (set) Token: 0x0600044F RID: 1103 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000172")]
			public Vector3 WorldCorner1
			{
				[Token(Token = "0x600044E")]
				[Address(RVA = "0x2DDE4E0", Offset = "0x2DDCAE0", VA = "0x182DDE4E0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600044F")]
				[Address(RVA = "0x2DDE500", Offset = "0x2DDCB00", VA = "0x182DDE500")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000173 RID: 371
			// (get) Token: 0x06000450 RID: 1104 RVA: 0x00003EFC File Offset: 0x000020FC
			// (set) Token: 0x06000451 RID: 1105 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000173")]
			public Vector3 WorldCorner2
			{
				[Token(Token = "0x6000450")]
				[Address(RVA = "0x23C2570", Offset = "0x23C0B70", VA = "0x1823C2570")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000451")]
				[Address(RVA = "0x2DDE510", Offset = "0x2DDCB10", VA = "0x182DDE510")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000174 RID: 372
			// (get) Token: 0x06000452 RID: 1106 RVA: 0x00003F14 File Offset: 0x00002114
			// (set) Token: 0x06000453 RID: 1107 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000174")]
			public Vector3 WorldCorner3
			{
				[Token(Token = "0x6000452")]
				[Address(RVA = "0x23C25B0", Offset = "0x23C0BB0", VA = "0x1823C25B0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000453")]
				[Address(RVA = "0x2DDE520", Offset = "0x2DDCB20", VA = "0x182DDE520")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000175 RID: 373
			// (get) Token: 0x06000454 RID: 1108 RVA: 0x00003F2C File Offset: 0x0000212C
			// (set) Token: 0x06000455 RID: 1109 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000175")]
			public Vector3 WorldCorner4
			{
				[Token(Token = "0x6000454")]
				[Address(RVA = "0x1F7DB50", Offset = "0x1F7C150", VA = "0x181F7DB50")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000455")]
				[Address(RVA = "0x2B3F240", Offset = "0x2B3D840", VA = "0x182B3F240")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000176 RID: 374
			// (get) Token: 0x06000456 RID: 1110 RVA: 0x00002068 File Offset: 0x00000268
			// (set) Token: 0x06000457 RID: 1111 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000176")]
			public SuperStructure SuperStructure
			{
				[Token(Token = "0x6000456")]
				[Address(RVA = "0x6306D0", Offset = "0x62ECD0", VA = "0x1806306D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000457")]
				[Address(RVA = "0x73EE10", Offset = "0x73D410", VA = "0x18073EE10")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06000458 RID: 1112 RVA: 0x00003F44 File Offset: 0x00002144
			[Token(Token = "0x6000458")]
			[Address(RVA = "0x2DDE530", Offset = "0x2DDCB30", VA = "0x182DDE530")]
			public Vector3 CalcWorldCenterPos()
			{
				return default(Vector3);
			}

			// Token: 0x06000459 RID: 1113 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000459")]
			[Address(RVA = "0x2DDE6A0", Offset = "0x2DDCCA0", VA = "0x182DDE6A0")]
			public void CalcBottomCornerAndCenter(float tileOffsetRatio = 0.5f)
			{
			}

			// Token: 0x0600045A RID: 1114 RVA: 0x00003F5C File Offset: 0x0000215C
			[Token(Token = "0x600045A")]
			[Address(RVA = "0x2DDE900", Offset = "0x2DDCF00", VA = "0x182DDE900")]
			public Vector3 CalcWorldBottomCenterPos()
			{
				return default(Vector3);
			}

			// Token: 0x0600045B RID: 1115 RVA: 0x00003F74 File Offset: 0x00002174
			[Token(Token = "0x600045B")]
			[Address(RVA = "0x2DDE920", Offset = "0x2DDCF20", VA = "0x182DDE920")]
			public bool IsCoveredBy(SuperStructure.Room otherRoom)
			{
				return default(bool);
			}

			// Token: 0x0600045C RID: 1116 RVA: 0x00003F8C File Offset: 0x0000218C
			[Token(Token = "0x600045C")]
			[Address(RVA = "0x2DDE970", Offset = "0x2DDCF70", VA = "0x182DDE970")]
			public bool Overlaps(SuperStructure.Room otherRoom)
			{
				return default(bool);
			}

			// Token: 0x0600045D RID: 1117 RVA: 0x00003FA4 File Offset: 0x000021A4
			[Token(Token = "0x600045D")]
			[Address(RVA = "0x2DDE9B0", Offset = "0x2DDCFB0", VA = "0x182DDE9B0")]
			public bool IsAbove(Vector3Int pos)
			{
				return default(bool);
			}

			// Token: 0x0600045E RID: 1118 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600045E")]
			[Address(RVA = "0x2DDE9E0", Offset = "0x2DDCFE0", VA = "0x182DDE9E0")]
			public void DrawRoom(Color color)
			{
			}

			// Token: 0x0600045F RID: 1119 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600045F")]
			[Address(RVA = "0x2DDEA50", Offset = "0x2DDD050", VA = "0x182DDEA50")]
			public void DrawOcclusionRoom()
			{
			}

			// Token: 0x06000460 RID: 1120 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000460")]
			[Address(RVA = "0x2DDEAD0", Offset = "0x2DDD0D0", VA = "0x182DDEAD0")]
			public Room()
			{
			}

			// Token: 0x0400040D RID: 1037
			[Token(Token = "0x400040D")]
			[FieldOffset(Offset = "0x10")]
			public Vector3Int From;

			// Token: 0x0400040E RID: 1038
			[Token(Token = "0x400040E")]
			[FieldOffset(Offset = "0x1C")]
			public Vector3Int To;

			// Token: 0x0400040F RID: 1039
			[Token(Token = "0x400040F")]
			[FieldOffset(Offset = "0x28")]
			public bool ClosedCeiling;

			// Token: 0x04000410 RID: 1040
			[Token(Token = "0x4000410")]
			[FieldOffset(Offset = "0x29")]
			public bool ClosedWalls;

			// Token: 0x04000411 RID: 1041
			[Token(Token = "0x4000411")]
			[FieldOffset(Offset = "0x2A")]
			public bool IsSealed;

			// Token: 0x04000412 RID: 1042
			[Token(Token = "0x4000412")]
			[FieldOffset(Offset = "0x2B")]
			public bool IsGrounded;

			// Token: 0x04000413 RID: 1043
			[Token(Token = "0x4000413")]
			[FieldOffset(Offset = "0x30")]
			public List<SuperStructure.RoomConnexion> Connexions;
		}

		// Token: 0x020000A1 RID: 161
		[Token(Token = "0x20000A1")]
		[Serializable]
		public class RoomConnexion
		{
			// Token: 0x06000461 RID: 1121 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000461")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public RoomConnexion()
			{
			}

			// Token: 0x0400041B RID: 1051
			[Token(Token = "0x400041B")]
			[FieldOffset(Offset = "0x10")]
			public SuperStructure.Room RoomA;

			// Token: 0x0400041C RID: 1052
			[Token(Token = "0x400041C")]
			[FieldOffset(Offset = "0x18")]
			public SuperStructure.Room RoomB;
		}
	}
}
