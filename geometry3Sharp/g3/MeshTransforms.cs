using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000273 RID: 627
	[Token(Token = "0x2000273")]
	public static class MeshTransforms
	{
		// Token: 0x0600161D RID: 5661 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600161D")]
		[Address(RVA = "0x1EA4A60", Offset = "0x1EA3060", VA = "0x181EA4A60")]
		public static void Translate(IDeformableMesh mesh, Vector3d v)
		{
		}

		// Token: 0x0600161E RID: 5662 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600161E")]
		[Address(RVA = "0x1EA4C40", Offset = "0x1EA3240", VA = "0x181EA4C40")]
		public static void Translate(IDeformableMesh mesh, double tx, double ty, double tz)
		{
		}

		// Token: 0x0600161F RID: 5663 RVA: 0x00010D9C File Offset: 0x0000EF9C
		[Token(Token = "0x600161F")]
		[Address(RVA = "0x1EA4E10", Offset = "0x1EA3410", VA = "0x181EA4E10")]
		public static Vector3d Rotate(Vector3d pos, Vector3d origin, Quaternionf rotation)
		{
			return default(Vector3d);
		}

		// Token: 0x06001620 RID: 5664 RVA: 0x00010DB4 File Offset: 0x0000EFB4
		[Token(Token = "0x6001620")]
		[Address(RVA = "0x1EA4FA0", Offset = "0x1EA35A0", VA = "0x181EA4FA0")]
		public static Frame3f Rotate(Frame3f f, Vector3d origin, Quaternionf rotation)
		{
			return default(Frame3f);
		}

		// Token: 0x06001621 RID: 5665 RVA: 0x00010DCC File Offset: 0x0000EFCC
		[Token(Token = "0x6001621")]
		[Address(RVA = "0x1EA51C0", Offset = "0x1EA37C0", VA = "0x181EA51C0")]
		public static Frame3f Rotate(Frame3f f, Vector3d origin, Quaterniond rotation)
		{
			return default(Frame3f);
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001622")]
		[Address(RVA = "0x1EA5410", Offset = "0x1EA3A10", VA = "0x181EA5410")]
		public static void Rotate(IDeformableMesh mesh, Vector3d origin, Quaternionf rotation)
		{
		}

		// Token: 0x06001623 RID: 5667 RVA: 0x00010DE4 File Offset: 0x0000EFE4
		[Token(Token = "0x6001623")]
		[Address(RVA = "0x1EA56D0", Offset = "0x1EA3CD0", VA = "0x181EA56D0")]
		public static Vector3d Rotate(Vector3d pos, Vector3d origin, Quaterniond rotation)
		{
			return default(Vector3d);
		}

		// Token: 0x06001624 RID: 5668 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001624")]
		[Address(RVA = "0x1EA5820", Offset = "0x1EA3E20", VA = "0x181EA5820")]
		public static void Rotate(IDeformableMesh mesh, Vector3d origin, Quaterniond rotation)
		{
		}

		// Token: 0x06001625 RID: 5669 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001625")]
		[Address(RVA = "0x1EA5C00", Offset = "0x1EA4200", VA = "0x181EA5C00")]
		public static void Scale(IDeformableMesh mesh, Vector3d scale, Vector3d origin)
		{
		}

		// Token: 0x06001626 RID: 5670 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001626")]
		[Address(RVA = "0x1EA5E60", Offset = "0x1EA4460", VA = "0x181EA5E60")]
		public static void Scale(IDeformableMesh mesh, double sx, double sy, double sz)
		{
		}

		// Token: 0x06001627 RID: 5671 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001627")]
		[Address(RVA = "0x1EA5F40", Offset = "0x1EA4540", VA = "0x181EA5F40")]
		public static void Scale(IDeformableMesh mesh, double s)
		{
		}

		// Token: 0x06001628 RID: 5672 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001628")]
		[Address(RVA = "0x1EA6000", Offset = "0x1EA4600", VA = "0x181EA6000")]
		public static void ToFrame(IDeformableMesh mesh, Frame3f f)
		{
		}

		// Token: 0x06001629 RID: 5673 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001629")]
		[Address(RVA = "0x1EA62A0", Offset = "0x1EA48A0", VA = "0x181EA62A0")]
		public static void FromFrame(IDeformableMesh mesh, Frame3f f)
		{
		}

		// Token: 0x0600162A RID: 5674 RVA: 0x00010DFC File Offset: 0x0000EFFC
		[Token(Token = "0x600162A")]
		[Address(RVA = "0x1EA6570", Offset = "0x1EA4B70", VA = "0x181EA6570")]
		public static Vector3d ConvertZUpToYUp(Vector3d v)
		{
			return default(Vector3d);
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x00010E14 File Offset: 0x0000F014
		[Token(Token = "0x600162B")]
		[Address(RVA = "0x1EA65A0", Offset = "0x1EA4BA0", VA = "0x181EA65A0")]
		public static Vector3f ConvertZUpToYUp(Vector3f v)
		{
			return default(Vector3f);
		}

		// Token: 0x0600162C RID: 5676 RVA: 0x00010E2C File Offset: 0x0000F02C
		[Token(Token = "0x600162C")]
		[Address(RVA = "0x1EA65C0", Offset = "0x1EA4BC0", VA = "0x181EA65C0")]
		public static Frame3f ConvertZUpToYUp(Frame3f f)
		{
			return default(Frame3f);
		}

		// Token: 0x0600162D RID: 5677 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600162D")]
		[Address(RVA = "0x1EA6860", Offset = "0x1EA4E60", VA = "0x181EA6860")]
		public static void ConvertZUpToYUp(IDeformableMesh mesh)
		{
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x00010E44 File Offset: 0x0000F044
		[Token(Token = "0x600162E")]
		[Address(RVA = "0x1EA6AE0", Offset = "0x1EA50E0", VA = "0x181EA6AE0")]
		public static Vector3d ConvertYUpToZUp(Vector3d v)
		{
			return default(Vector3d);
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x00010E5C File Offset: 0x0000F05C
		[Token(Token = "0x600162F")]
		[Address(RVA = "0x1EA6B10", Offset = "0x1EA5110", VA = "0x181EA6B10")]
		public static Vector3f ConvertYUpToZUp(Vector3f v)
		{
			return default(Vector3f);
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x00010E74 File Offset: 0x0000F074
		[Token(Token = "0x6001630")]
		[Address(RVA = "0x1EA6B30", Offset = "0x1EA5130", VA = "0x181EA6B30")]
		public static Frame3f ConvertYUpToZUp(Frame3f f)
		{
			return default(Frame3f);
		}

		// Token: 0x06001631 RID: 5681 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001631")]
		[Address(RVA = "0x1EA6DD0", Offset = "0x1EA53D0", VA = "0x181EA6DD0")]
		public static void ConvertYUpToZUp(IDeformableMesh mesh)
		{
		}

		// Token: 0x06001632 RID: 5682 RVA: 0x00010E8C File Offset: 0x0000F08C
		[Token(Token = "0x6001632")]
		[Address(RVA = "0x1EA7050", Offset = "0x1EA5650", VA = "0x181EA7050")]
		public static Vector3d FlipLeftRightCoordSystems(Vector3d v)
		{
			return default(Vector3d);
		}

		// Token: 0x06001633 RID: 5683 RVA: 0x00010EA4 File Offset: 0x0000F0A4
		[Token(Token = "0x6001633")]
		[Address(RVA = "0x1EA7080", Offset = "0x1EA5680", VA = "0x181EA7080")]
		public static Vector3f FlipLeftRightCoordSystems(Vector3f v)
		{
			return default(Vector3f);
		}

		// Token: 0x06001634 RID: 5684 RVA: 0x00010EBC File Offset: 0x0000F0BC
		[Token(Token = "0x6001634")]
		[Address(RVA = "0x1EA70A0", Offset = "0x1EA56A0", VA = "0x181EA70A0")]
		public static Frame3f FlipLeftRightCoordSystems(Frame3f f)
		{
			return default(Frame3f);
		}

		// Token: 0x06001635 RID: 5685 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001635")]
		[Address(RVA = "0x1EA70F0", Offset = "0x1EA56F0", VA = "0x181EA70F0")]
		public static void FlipLeftRightCoordSystems(IDeformableMesh mesh)
		{
		}

		// Token: 0x06001636 RID: 5686 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001636")]
		[Address(RVA = "0x1EA73F0", Offset = "0x1EA59F0", VA = "0x181EA73F0")]
		public static void VertexNormalOffset(IDeformableMesh mesh, double offsetDistance)
		{
		}

		// Token: 0x06001637 RID: 5687 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001637")]
		[Address(RVA = "0x1EA7640", Offset = "0x1EA5C40", VA = "0x181EA7640")]
		public static void PerVertexTransform(IDeformableMesh mesh, Func<Vector3d, Vector3d> TransformF)
		{
		}

		// Token: 0x06001638 RID: 5688 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001638")]
		[Address(RVA = "0x1EA7820", Offset = "0x1EA5E20", VA = "0x181EA7820")]
		public static void PerVertexTransform(IDeformableMesh mesh, Func<Vector3d, Vector3f, Vector3d> TransformF)
		{
		}

		// Token: 0x06001639 RID: 5689 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001639")]
		[Address(RVA = "0x1EA7A50", Offset = "0x1EA6050", VA = "0x181EA7A50")]
		public static void PerVertexTransform(IDeformableMesh mesh, Func<Vector3d, Vector3f, Vector3dTuple2> TransformF)
		{
		}

		// Token: 0x0600163A RID: 5690 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600163A")]
		[Address(RVA = "0x1EA7CE0", Offset = "0x1EA62E0", VA = "0x181EA7CE0")]
		public static void PerVertexTransform(IDeformableMesh mesh, TransformSequence xform)
		{
		}

		// Token: 0x0600163B RID: 5691 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600163B")]
		[Address(RVA = "0x1EA80C0", Offset = "0x1EA66C0", VA = "0x181EA80C0")]
		public static void PerVertexTransform(IDeformableMesh mesh, IEnumerable<int> vertices, Func<Vector3d, int, Vector3d> TransformF)
		{
		}

		// Token: 0x0600163C RID: 5692 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600163C")]
		[Address(RVA = "0x1EA83E0", Offset = "0x1EA69E0", VA = "0x181EA83E0")]
		public static void PerVertexTransform(IDeformableMesh mesh, IEnumerable<int> vertices, Func<int, int> MapV, Func<Vector3d, int, int, Vector3d> TransformF)
		{
		}

		// Token: 0x0600163D RID: 5693 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600163D")]
		[Address(RVA = "0x1EA8720", Offset = "0x1EA6D20", VA = "0x181EA8720")]
		public static void PerVertexTransform(IDeformableMesh targetMesh, IDeformableMesh sourceMesh, int[] mapV, Func<Vector3d, int, int, Vector3d> TransformF)
		{
		}
	}
}
