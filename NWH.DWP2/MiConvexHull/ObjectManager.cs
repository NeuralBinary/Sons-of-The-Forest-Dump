using System;
using Il2CppDummyDll;

namespace NWH.DWP2.MiConvexHull
{
	// Token: 0x02000041 RID: 65
	[Token(Token = "0x2000041")]
	internal class ObjectManager
	{
		// Token: 0x060001FA RID: 506 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x2720A70", Offset = "0x271F070", VA = "0x182720A70")]
		public ObjectManager(ConvexHullAlgorithm hull)
		{
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x2720CF0", Offset = "0x271F2F0", VA = "0x182720CF0")]
		public void DepositFace(int faceIndex)
		{
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x2720D90", Offset = "0x271F390", VA = "0x182720D90")]
		private void ReallocateFacePool()
		{
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00002FFC File Offset: 0x000011FC
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x2721090", Offset = "0x271F690", VA = "0x182721090")]
		private int CreateFace()
		{
			return 0;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00003014 File Offset: 0x00001214
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x2721230", Offset = "0x271F830", VA = "0x182721230")]
		public int GetFace()
		{
			return 0;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x27212B0", Offset = "0x271F8B0", VA = "0x1827212B0")]
		public void DepositConnector(FaceConnector connector)
		{
		}

		// Token: 0x06000200 RID: 512 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x6000200")]
		[Address(RVA = "0x2721430", Offset = "0x271FA30", VA = "0x182721430")]
		public FaceConnector GetConnector()
		{
			return null;
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x27215D0", Offset = "0x271FBD0", VA = "0x1827215D0")]
		public void DepositVertexBuffer(IndexBuffer buffer)
		{
		}

		// Token: 0x06000202 RID: 514 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x2721670", Offset = "0x271FC70", VA = "0x182721670")]
		public IndexBuffer GetVertexBuffer()
		{
			return null;
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000203")]
		[Address(RVA = "0x2721720", Offset = "0x271FD20", VA = "0x182721720")]
		public void DepositDeferredFace(DeferredFace face)
		{
		}

		// Token: 0x06000204 RID: 516 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x27217B0", Offset = "0x271FDB0", VA = "0x1827217B0")]
		public DeferredFace GetDeferredFace()
		{
			return null;
		}

		// Token: 0x040001DE RID: 478
		[Token(Token = "0x40001DE")]
		[FieldOffset(Offset = "0x10")]
		private readonly int Dimension;

		// Token: 0x040001DF RID: 479
		[Token(Token = "0x40001DF")]
		[FieldOffset(Offset = "0x18")]
		private readonly SimpleList<DeferredFace> DeferredFaceStack;

		// Token: 0x040001E0 RID: 480
		[Token(Token = "0x40001E0")]
		[FieldOffset(Offset = "0x20")]
		private readonly SimpleList<IndexBuffer> EmptyBufferStack;

		// Token: 0x040001E1 RID: 481
		[Token(Token = "0x40001E1")]
		[FieldOffset(Offset = "0x28")]
		private readonly IndexBuffer FreeFaceIndices;

		// Token: 0x040001E2 RID: 482
		[Token(Token = "0x40001E2")]
		[FieldOffset(Offset = "0x30")]
		private readonly ConvexHullAlgorithm Hull;

		// Token: 0x040001E3 RID: 483
		[Token(Token = "0x40001E3")]
		[FieldOffset(Offset = "0x38")]
		private FaceConnector ConnectorStack;

		// Token: 0x040001E4 RID: 484
		[Token(Token = "0x40001E4")]
		[FieldOffset(Offset = "0x40")]
		private ConvexFaceInternal[] FacePool;

		// Token: 0x040001E5 RID: 485
		[Token(Token = "0x40001E5")]
		[FieldOffset(Offset = "0x48")]
		private int FacePoolSize;

		// Token: 0x040001E6 RID: 486
		[Token(Token = "0x40001E6")]
		[FieldOffset(Offset = "0x4C")]
		private int FacePoolCapacity;
	}
}
