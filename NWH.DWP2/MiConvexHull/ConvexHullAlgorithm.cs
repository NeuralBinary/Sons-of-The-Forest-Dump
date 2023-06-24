using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace NWH.DWP2.MiConvexHull
{
	// Token: 0x02000039 RID: 57
	[Token(Token = "0x2000039")]
	internal class ConvexHullAlgorithm
	{
		// Token: 0x060001C1 RID: 449 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x2719750", Offset = "0x2717D50", VA = "0x182719750")]
		private void SerializeVerticesToPositions()
		{
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x2719950", Offset = "0x2717F50", VA = "0x182719950")]
		private void FindBoundingBoxPoints()
		{
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x2719F00", Offset = "0x2718500", VA = "0x182719F00")]
		private void ShiftAndScalePositions()
		{
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x271A3D0", Offset = "0x27189D0", VA = "0x18271A3D0")]
		private void CreateInitialSimplex()
		{
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x271A9B0", Offset = "0x2718FB0", VA = "0x18271A9B0")]
		private List<int> FindInitialPoints()
		{
			return null;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x271B570", Offset = "0x2719B70", VA = "0x18271B570")]
		private void UpdateAdjacency(ConvexFaceInternal l, ConvexFaceInternal r)
		{
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x271B7B0", Offset = "0x2719DB0", VA = "0x18271B7B0")]
		private void FindBeyondVertices(ConvexFaceInternal face)
		{
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x60001C8")]
		internal static ConvexHull<TVertex, TFace> GetConvexHull<TVertex, TFace>(IList<TVertex> data, double PlaneDistanceTolerance) where TVertex : IVertex where TFace : ConvexFace<TVertex, TFace>, new()
		{
			return null;
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x271B860", Offset = "0x2719E60", VA = "0x18271B860")]
		private ConvexHullAlgorithm(IVertex[] vertices, bool lift, double PlaneDistanceTolerance)
		{
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00002EC4 File Offset: 0x000010C4
		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x271C470", Offset = "0x271AA70", VA = "0x18271C470")]
		private int DetermineDimension()
		{
			return 0;
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x271C710", Offset = "0x271AD10", VA = "0x18271C710")]
		private void GetConvexHull()
		{
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x271C8F0", Offset = "0x271AEF0", VA = "0x18271C8F0")]
		private void TagAffectedFaces(ConvexFaceInternal currentFace)
		{
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x271C980", Offset = "0x271AF80", VA = "0x18271C980")]
		private void TraverseAffectedFaces(int currentFace)
		{
		}

		// Token: 0x060001CE RID: 462 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x271CBB0", Offset = "0x271B1B0", VA = "0x18271CBB0")]
		private DeferredFace MakeDeferredFace(ConvexFaceInternal face, int faceIndex, ConvexFaceInternal pivot, int pivotIndex, ConvexFaceInternal oldFace)
		{
			return null;
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x271CD90", Offset = "0x271B390", VA = "0x18271CD90")]
		private void ConnectFace(FaceConnector connector)
		{
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00002EDC File Offset: 0x000010DC
		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x271D0C0", Offset = "0x271B6C0", VA = "0x18271D0C0")]
		private bool CreateCone()
		{
			return default(bool);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x271D5A0", Offset = "0x271BBA0", VA = "0x18271D5A0")]
		private void CommitCone()
		{
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x271D9A0", Offset = "0x271BFA0", VA = "0x18271D9A0")]
		private void IsBeyond(ConvexFaceInternal face, IndexBuffer beyondVertices, int v)
		{
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00002EF4 File Offset: 0x000010F4
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x271DB70", Offset = "0x271C170", VA = "0x18271DB70")]
		private int LexCompare(int u, int v)
		{
			return 0;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x271DC70", Offset = "0x271C270", VA = "0x18271DC70")]
		private void FindBeyondVertices(ConvexFaceInternal face, IndexBuffer beyond, IndexBuffer beyond1)
		{
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x271DF20", Offset = "0x271C520", VA = "0x18271DF20")]
		private void FindBeyondVertices(ConvexFaceInternal face, IndexBuffer beyond)
		{
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x271E0E0", Offset = "0x271C6E0", VA = "0x18271E0E0")]
		private void UpdateCenter()
		{
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x271E1C0", Offset = "0x271C7C0", VA = "0x18271E1C0")]
		private void RollbackCenter()
		{
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x271E2B0", Offset = "0x271C8B0", VA = "0x18271E2B0")]
		private void HandleSingular()
		{
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00002F0C File Offset: 0x0000110C
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x271E580", Offset = "0x271CB80", VA = "0x18271E580")]
		private double GetCoordinate(int vIndex, int dimension)
		{
			return 0.0;
		}

		// Token: 0x060001DA RID: 474 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x60001DA")]
		private TVertex[] GetHullVertices<TVertex>(IList<TVertex> data)
		{
			return null;
		}

		// Token: 0x060001DB RID: 475 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x60001DB")]
		private TFace[] GetConvexFaces<TVertex, TFace>() where TVertex : IVertex where TFace : ConvexFace<TVertex, TFace>, new()
		{
			return null;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x60001DC")]
		internal static TCell[] GetDelaunayTriangulation<TVertex, TCell>(IList<TVertex> data) where TVertex : IVertex where TCell : TriangulationCell<TVertex, TCell>, new()
		{
			return null;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x271E5C0", Offset = "0x271CBC0", VA = "0x18271E5C0")]
		private void RemoveUpperFaces()
		{
		}

		// Token: 0x04000196 RID: 406
		[Token(Token = "0x4000196")]
		[FieldOffset(Offset = "0x10")]
		internal readonly int NumOfDimensions;

		// Token: 0x04000197 RID: 407
		[Token(Token = "0x4000197")]
		[FieldOffset(Offset = "0x14")]
		private readonly bool IsLifted;

		// Token: 0x04000198 RID: 408
		[Token(Token = "0x4000198")]
		[FieldOffset(Offset = "0x18")]
		private readonly double PlaneDistanceTolerance;

		// Token: 0x04000199 RID: 409
		[Token(Token = "0x4000199")]
		[FieldOffset(Offset = "0x20")]
		private readonly IVertex[] Vertices;

		// Token: 0x0400019A RID: 410
		[Token(Token = "0x400019A")]
		[FieldOffset(Offset = "0x28")]
		private readonly double[] Positions;

		// Token: 0x0400019B RID: 411
		[Token(Token = "0x400019B")]
		[FieldOffset(Offset = "0x30")]
		private readonly bool[] VertexVisited;

		// Token: 0x0400019C RID: 412
		[Token(Token = "0x400019C")]
		[FieldOffset(Offset = "0x38")]
		private readonly int NumberOfVertices;

		// Token: 0x0400019D RID: 413
		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0x40")]
		internal ConvexFaceInternal[] FacePool;

		// Token: 0x0400019E RID: 414
		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0x48")]
		internal bool[] AffectedFaceFlags;

		// Token: 0x0400019F RID: 415
		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0x50")]
		private int ConvexHullSize;

		// Token: 0x040001A0 RID: 416
		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0x58")]
		private readonly FaceList UnprocessedFaces;

		// Token: 0x040001A1 RID: 417
		[Token(Token = "0x40001A1")]
		[FieldOffset(Offset = "0x60")]
		private readonly IndexBuffer ConvexFaces;

		// Token: 0x040001A2 RID: 418
		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0x68")]
		private int CurrentVertex;

		// Token: 0x040001A3 RID: 419
		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0x70")]
		private double MaxDistance;

		// Token: 0x040001A4 RID: 420
		[Token(Token = "0x40001A4")]
		[FieldOffset(Offset = "0x78")]
		private int FurthestVertex;

		// Token: 0x040001A5 RID: 421
		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0x80")]
		private readonly double[] Center;

		// Token: 0x040001A6 RID: 422
		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0x88")]
		private readonly int[] UpdateBuffer;

		// Token: 0x040001A7 RID: 423
		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0x90")]
		private readonly int[] UpdateIndices;

		// Token: 0x040001A8 RID: 424
		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0x98")]
		private readonly IndexBuffer TraverseStack;

		// Token: 0x040001A9 RID: 425
		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0xA0")]
		private readonly IndexBuffer EmptyBuffer;

		// Token: 0x040001AA RID: 426
		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0xA8")]
		private IndexBuffer BeyondBuffer;

		// Token: 0x040001AB RID: 427
		[Token(Token = "0x40001AB")]
		[FieldOffset(Offset = "0xB0")]
		private readonly IndexBuffer AffectedFaceBuffer;

		// Token: 0x040001AC RID: 428
		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0xB8")]
		private readonly SimpleList<DeferredFace> ConeFaceBuffer;

		// Token: 0x040001AD RID: 429
		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0xC0")]
		private readonly HashSet<int> SingularVertices;

		// Token: 0x040001AE RID: 430
		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0xC8")]
		private readonly ConnectorList[] ConnectorTable;

		// Token: 0x040001AF RID: 431
		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0xD0")]
		private readonly ObjectManager ObjectManager;

		// Token: 0x040001B0 RID: 432
		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0xD8")]
		private readonly MathHelper MathHelper;

		// Token: 0x040001B1 RID: 433
		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0xE0")]
		private readonly List<int>[] boundingBoxPoints;

		// Token: 0x040001B2 RID: 434
		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0xE8")]
		private int indexOfDimensionWithLeastExtremes;

		// Token: 0x040001B3 RID: 435
		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0xF0")]
		private readonly double[] minima;

		// Token: 0x040001B4 RID: 436
		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0xF8")]
		private readonly double[] maxima;
	}
}
