using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x0200019D RID: 413
	[Token(Token = "0x200019D")]
	public class VoxelDistanceField
	{
		// Token: 0x060007BC RID: 1980 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
		public VoxelDistanceField(MeshVoxelizer voxelizer)
		{
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x0000485C File Offset: 0x00002A5C
		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x27E0030", Offset = "0x27DE630", VA = "0x1827E0030")]
		private bool VoxelExists(Vector3Int coords)
		{
			return default(bool);
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x27E0140", Offset = "0x27DE740", VA = "0x1827E0140")]
		public void JumpFlood()
		{
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x27E0900", Offset = "0x27DEF00", VA = "0x1827E0900")]
		private void JumpFloodPass(int stride, Vector3Int[,,] input, Vector3Int[,,] output)
		{
		}

		// Token: 0x0400067B RID: 1659
		[Token(Token = "0x400067B")]
		[FieldOffset(Offset = "0x10")]
		public Vector3Int[,,] distanceField;

		// Token: 0x0400067C RID: 1660
		[Token(Token = "0x400067C")]
		[FieldOffset(Offset = "0x18")]
		private MeshVoxelizer voxelizer;
	}
}
