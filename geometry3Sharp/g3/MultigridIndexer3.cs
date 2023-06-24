using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000382 RID: 898
	[Token(Token = "0x2000382")]
	public struct MultigridIndexer3 : IMultigridIndexer3
	{
		// Token: 0x06001D69 RID: 7529 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D69")]
		[Address(RVA = "0x1F7C800", Offset = "0x1F7AE00", VA = "0x181F7C800")]
		public MultigridIndexer3(Vector3i blockSize)
		{
		}

		// Token: 0x06001D6A RID: 7530 RVA: 0x00014AA4 File Offset: 0x00012CA4
		[Token(Token = "0x6001D6A")]
		[Address(RVA = "0x1F7C890", Offset = "0x1F7AE90", VA = "0x181F7C890", Slot = "5")]
		public Vector3i ToBlockIndex(Vector3i outer_index)
		{
			return default(Vector3i);
		}

		// Token: 0x06001D6B RID: 7531 RVA: 0x00014ABC File Offset: 0x00012CBC
		[Token(Token = "0x6001D6B")]
		[Address(RVA = "0x1F7C9E0", Offset = "0x1F7AFE0", VA = "0x181F7C9E0", Slot = "6")]
		public Vector3i ToBlockLocal(Vector3i outer_index)
		{
			return default(Vector3i);
		}

		// Token: 0x06001D6C RID: 7532 RVA: 0x00014AD4 File Offset: 0x00012CD4
		[Token(Token = "0x6001D6C")]
		[Address(RVA = "0x1F7CB00", Offset = "0x1F7B100", VA = "0x181F7CB00", Slot = "4")]
		public GridLevelIndex ToBlock(Vector3i outer_index)
		{
			return default(GridLevelIndex);
		}

		// Token: 0x06001D6D RID: 7533 RVA: 0x00014AEC File Offset: 0x00012CEC
		[Token(Token = "0x6001D6D")]
		[Address(RVA = "0x1F7CCE0", Offset = "0x1F7B2E0", VA = "0x181F7CCE0", Slot = "7")]
		public Vector3i FromBlock(Vector3i block_idx)
		{
			return default(Vector3i);
		}

		// Token: 0x04000FAF RID: 4015
		[Token(Token = "0x4000FAF")]
		[FieldOffset(Offset = "0x0")]
		public Vector3i OuterShift;

		// Token: 0x04000FB0 RID: 4016
		[Token(Token = "0x4000FB0")]
		[FieldOffset(Offset = "0xC")]
		public Vector3i BlockSize;

		// Token: 0x04000FB1 RID: 4017
		[Token(Token = "0x4000FB1")]
		[FieldOffset(Offset = "0x18")]
		public Vector3i BlockShift;
	}
}
