using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TriangleNet.Geometry;
using TriangleNet.Logging;
using TriangleNet.Topology;

namespace TriangleNet.Meshing
{
	// Token: 0x02000046 RID: 70
	[Token(Token = "0x2000046")]
	internal class ConstraintMesher
	{
		// Token: 0x06000248 RID: 584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x24C4B90", Offset = "0x24C3190", VA = "0x1824C4B90")]
		public ConstraintMesher(Mesh mesh, Configuration config)
		{
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x24C4EC0", Offset = "0x24C34C0", VA = "0x1824C4EC0")]
		public void Apply(IPolygon input, ConstraintOptions options)
		{
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x24C5260", Offset = "0x24C3860", VA = "0x1824C5260")]
		private void CarveHoles()
		{
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024B")]
		[Address(RVA = "0x24C5C80", Offset = "0x24C4280", VA = "0x1824C5C80")]
		private void FormSkeleton(IPolygon input)
		{
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024C")]
		[Address(RVA = "0x24C61E0", Offset = "0x24C47E0", VA = "0x1824C61E0")]
		private void InfectHull()
		{
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024D")]
		[Address(RVA = "0x24C6740", Offset = "0x24C4D40", VA = "0x1824C6740")]
		private void Plague()
		{
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00002D30 File Offset: 0x00000F30
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x24C7010", Offset = "0x24C5610", VA = "0x1824C7010")]
		private FindDirectionResult FindDirection(ref Otri searchtri, Vertex searchpoint)
		{
			return FindDirectionResult.Within;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x24C7390", Offset = "0x24C5990", VA = "0x1824C7390")]
		private void SegmentIntersection(ref Otri splittri, ref Osub splitsubseg, Vertex endpoint2)
		{
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00002D48 File Offset: 0x00000F48
		[Token(Token = "0x6000250")]
		[Address(RVA = "0x24C7C30", Offset = "0x24C6230", VA = "0x1824C7C30")]
		private bool ScoutSegment(ref Otri searchtri, Vertex endpoint2, int newmark)
		{
			return default(bool);
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x24C7F20", Offset = "0x24C6520", VA = "0x1824C7F20")]
		private void DelaunayFixup(ref Otri fixuptri, bool leftside)
		{
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000252")]
		[Address(RVA = "0x24C82C0", Offset = "0x24C68C0", VA = "0x1824C82C0")]
		private void ConstrainedEdge(ref Otri starttri, Vertex endpoint2, int newmark)
		{
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x24C8730", Offset = "0x24C6D30", VA = "0x1824C8730")]
		private void InsertSegment(Vertex endpoint1, Vertex endpoint2, int newmark)
		{
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x24C8CD0", Offset = "0x24C72D0", VA = "0x1824C8CD0")]
		private void MarkHull()
		{
		}

		// Token: 0x04000294 RID: 660
		[Token(Token = "0x4000294")]
		[FieldOffset(Offset = "0x10")]
		private IPredicates predicates;

		// Token: 0x04000295 RID: 661
		[Token(Token = "0x4000295")]
		[FieldOffset(Offset = "0x18")]
		private Mesh mesh;

		// Token: 0x04000296 RID: 662
		[Token(Token = "0x4000296")]
		[FieldOffset(Offset = "0x20")]
		private Behavior behavior;

		// Token: 0x04000297 RID: 663
		[Token(Token = "0x4000297")]
		[FieldOffset(Offset = "0x28")]
		private TriangleLocator locator;

		// Token: 0x04000298 RID: 664
		[Token(Token = "0x4000298")]
		[FieldOffset(Offset = "0x30")]
		private List<Triangle> viri;

		// Token: 0x04000299 RID: 665
		[Token(Token = "0x4000299")]
		[FieldOffset(Offset = "0x38")]
		private ILog<LogItem> logger;
	}
}
