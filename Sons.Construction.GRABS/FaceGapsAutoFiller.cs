using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Construction.GRABS
{
	// Token: 0x02000054 RID: 84
	[Token(Token = "0x2000054")]
	public class FaceGapsAutoFiller
	{
		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600021E RID: 542 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x17000089")]
		public BlueprintFace MissingTilesFoundationFace
		{
			[Token(Token = "0x600021E")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600021F RID: 543 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x1700008A")]
		public BlueprintFace MissingTilesCeilingFace
		{
			[Token(Token = "0x600021F")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000220")]
		[Address(RVA = "0x2DA7870", Offset = "0x2DA5E70", VA = "0x182DA7870")]
		public FaceGapsAutoFiller(BlueprintFace face, bool hasConnectedFoundation, bool hasConnectedCeiling, bool hasConnectedLeftWall, bool hasConnectedRightWall)
		{
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000221")]
		[Address(RVA = "0x2DA7B20", Offset = "0x2DA6120", VA = "0x182DA7B20")]
		public void Update()
		{
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000222")]
		[Address(RVA = "0x2DA8090", Offset = "0x2DA6690", VA = "0x182DA8090")]
		private void SetupFoundationOnMissingGroundTiles(Vector3Int missingTileFrom, Vector3Int missingTileTo, ref BlueprintFace missingTilesFace)
		{
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000223")]
		[Address(RVA = "0x2DA8A60", Offset = "0x2DA7060", VA = "0x182DA8A60")]
		private void SetupWallOnMissingGroundTiles(Vector3Int missingTileFrom, Vector3Int missingTileTo, ref BlueprintFace missingTilesFace)
		{
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000224")]
		[Address(RVA = "0x2DA9770", Offset = "0x2DA7D70", VA = "0x182DA9770")]
		private void HideMissingTilesFace(ref BlueprintFace missingTilesFace)
		{
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000225")]
		[Address(RVA = "0x2DA98E0", Offset = "0x2DA7EE0", VA = "0x182DA98E0")]
		internal void Validate()
		{
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000226")]
		[Address(RVA = "0x2DA9C80", Offset = "0x2DA8280", VA = "0x182DA9C80")]
		internal void Cancel()
		{
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000227")]
		[Address(RVA = "0x2DA9CE0", Offset = "0x2DA82E0", VA = "0x182DA9CE0")]
		[CompilerGenerated]
		internal static void <Validate>g__ValidateFace|20_0(BlueprintFace face)
		{
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000228")]
		[Address(RVA = "0x2DA9DD0", Offset = "0x2DA83D0", VA = "0x182DA9DD0")]
		[CompilerGenerated]
		internal static void <Cancel>g__CancelFace|21_0(BlueprintFace face)
		{
		}

		// Token: 0x040000EE RID: 238
		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x10")]
		private readonly bool _hasConnectedFoundation;

		// Token: 0x040000EF RID: 239
		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x11")]
		private readonly bool _hasConnectedCeiling;

		// Token: 0x040000F0 RID: 240
		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x12")]
		private readonly bool _hasConnectedLeftWall;

		// Token: 0x040000F1 RID: 241
		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x13")]
		private readonly bool _hasConnectedRightWall;

		// Token: 0x040000F2 RID: 242
		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x18")]
		private readonly BlueprintFace _face;

		// Token: 0x040000F3 RID: 243
		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x20")]
		private BlueprintFace _missingTilesFoundationFace;

		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x28")]
		private BlueprintFace _missingTilesCeilingFace;

		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x30")]
		private BlueprintFace _missingTilesLeftWallFace;

		// Token: 0x040000F6 RID: 246
		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x38")]
		private BlueprintFace _missingTilesRightWallFace;

		// Token: 0x040000F7 RID: 247
		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x40")]
		private readonly BlueprintTilesSearcher _blueprintTilesSearcher;

		// Token: 0x040000F8 RID: 248
		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x48")]
		private readonly bool _targetFaceOnBlueprintZAxis;
	}
}
