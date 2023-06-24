using System;
using System.Collections.Generic;
using Construction;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Construction.GRABS
{
	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	public class BlueprintStructuresGrid
	{
		// Token: 0x060000F0 RID: 240 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public void Set(FoundationArchetype foundationArchetype)
		{
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
		public void Set(WallArchetype wallArchetype)
		{
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x2D8FE00", Offset = "0x2D8E400", VA = "0x182D8FE00")]
		public void Register(Vector3Int tile, Corners corner, IBeamSupport beamSupport, bool skipLinkingRegistration = false)
		{
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x2D8FF90", Offset = "0x2D8E590", VA = "0x182D8FF90")]
		public void Register(Vector3Int tile, Sides side, WallStructure wall, bool skipLinkingRegistration = false)
		{
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x2D90120", Offset = "0x2D8E720", VA = "0x182D90120")]
		public void Register(Vector3Int tile, Sides side, BeamStructure beam, bool skipLinkingRegistration = false)
		{
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x2D902B0", Offset = "0x2D8E8B0", VA = "0x182D902B0")]
		public void Register(Vector3Int tile, FloorStructure floor, Sides backSupportSide, bool skipLinkingRegistration = false)
		{
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x2D903B0", Offset = "0x2D8E9B0", VA = "0x182D903B0")]
		public void Register(Vector3Int tile, StrutStructure strut, Corners backSupportCorner, Sides side, bool skipLinkingRegistration = false)
		{
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x2D90440", Offset = "0x2D8EA40", VA = "0x182D90440")]
		private void RegisterStructureForLinking(Vector3Int tile, IStructure s, Corners corner)
		{
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x2D90480", Offset = "0x2D8EA80", VA = "0x182D90480")]
		private void RegisterStructureForLinking(Vector3Int tile, IStructure s, Sides side)
		{
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x2D904C0", Offset = "0x2D8EAC0", VA = "0x182D904C0")]
		private void RegisterStructureForLinking(Vector3Int tile, IStructure s, Corners corner, Sides side, bool needsGhostGenerated)
		{
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x2D90770", Offset = "0x2D8ED70", VA = "0x182D90770")]
		private void RegisterAll(IStructure structure)
		{
		}

		// Token: 0x060000FB RID: 251 RVA: 0x000026B4 File Offset: 0x000008B4
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x2D908C0", Offset = "0x2D8EEC0", VA = "0x182D908C0")]
		public bool TryGet(Vector3Int tile, Corners corner, out IBeamSupport beamSupport)
		{
			return default(bool);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x000026CC File Offset: 0x000008CC
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x2D90980", Offset = "0x2D8EF80", VA = "0x182D90980")]
		public bool TryGet(Vector3Int tile, Sides side, out IFloorSupport floorSupport)
		{
			return default(bool);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x000026E4 File Offset: 0x000008E4
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x2D90C80", Offset = "0x2D8F280", VA = "0x182D90C80")]
		public bool TryGet(Vector3Int tile, Sides side, out BeamStructure beam)
		{
			return default(bool);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x000026FC File Offset: 0x000008FC
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x2D90F70", Offset = "0x2D8F570", VA = "0x182D90F70")]
		public bool TryGet(Vector3Int tile, Sides side, out WallStructure wall)
		{
			return default(bool);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00002714 File Offset: 0x00000914
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x2D91260", Offset = "0x2D8F860", VA = "0x182D91260")]
		public bool TryGet(Vector3Int tile, out FloorStructure floor)
		{
			return default(bool);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000272C File Offset: 0x0000092C
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x2D912E0", Offset = "0x2D8F8E0", VA = "0x182D912E0")]
		public Vector3Int GetCornerCoords(Vector3Int tile, Corners corner)
		{
			return default(Vector3Int);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00002744 File Offset: 0x00000944
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x2D914B0", Offset = "0x2D8FAB0", VA = "0x182D914B0")]
		public Vector3Int GetSideCoords(Vector3Int tile, Sides side)
		{
			return default(Vector3Int);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x2D91710", Offset = "0x2D8FD10", VA = "0x182D91710")]
		public void LinkAllStructures()
		{
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x2D92120", Offset = "0x2D90720", VA = "0x182D92120")]
		public void InitAllStructuresGhost()
		{
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x661070", Offset = "0x65F670", VA = "0x180661070")]
		public List<Structure> GetAllStructureList()
		{
			return null;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x2D924B0", Offset = "0x2D90AB0", VA = "0x182D924B0")]
		public BlueprintStructuresGrid()
		{
		}

		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x10")]
		private FoundationArchetype _foundationArchetype;

		// Token: 0x04000065 RID: 101
		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x18")]
		private WallArchetype _wallArchetype;

		// Token: 0x04000066 RID: 102
		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x20")]
		private readonly Dictionary<Vector3Int, IBeamSupport> _tileCornersGrid;

		// Token: 0x04000067 RID: 103
		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x28")]
		private readonly Dictionary<Vector3Int, ITileEdge> _tileSidesGrid;

		// Token: 0x04000068 RID: 104
		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x30")]
		private readonly Dictionary<Vector3Int, ITileEdge> _tileTopSidesGrid;

		// Token: 0x04000069 RID: 105
		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x38")]
		private readonly Dictionary<Vector3Int, FloorStructure> _floorGrid;

		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x40")]
		private readonly Dictionary<Vector3Int, List<BlueprintStructuresGrid.StructureData>> _allStructuresPerTileGrid;

		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x48")]
		private readonly List<BlueprintStructuresGrid.StructureData> _allStructuresNeedingGhostGenerated;

		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x50")]
		private readonly List<Structure> _allStructures;

		// Token: 0x0200001C RID: 28
		[Token(Token = "0x200001C")]
		private struct StructureData
		{
			// Token: 0x0400006D RID: 109
			[Token(Token = "0x400006D")]
			[FieldOffset(Offset = "0x0")]
			public IStructure Structure;

			// Token: 0x0400006E RID: 110
			[Token(Token = "0x400006E")]
			[FieldOffset(Offset = "0x8")]
			public Corners Corner;

			// Token: 0x0400006F RID: 111
			[Token(Token = "0x400006F")]
			[FieldOffset(Offset = "0xC")]
			public Sides Side;
		}
	}
}
