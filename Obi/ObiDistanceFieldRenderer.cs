using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x0200019E RID: 414
	[Token(Token = "0x200019E")]
	[ExecuteInEditMode]
	[AddComponentMenu("Physics/Obi/Obi Distance Field Renderer", 1003)]
	[RequireComponent(typeof(ObiCollider))]
	public class ObiDistanceFieldRenderer : MonoBehaviour
	{
		// Token: 0x060007C0 RID: 1984 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x27E0D80", Offset = "0x27DF380", VA = "0x1827E0D80")]
		public void Awake()
		{
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x27E0E10", Offset = "0x27DF410", VA = "0x1827E0E10")]
		public void OnEnable()
		{
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x27E0F40", Offset = "0x27DF540", VA = "0x1827E0F40")]
		public void OnDisable()
		{
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x27E0F40", Offset = "0x27DF540", VA = "0x1827E0F40")]
		private void Cleanup()
		{
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x27E0FB0", Offset = "0x27DF5B0", VA = "0x1827E0FB0")]
		private void ResizeTexture()
		{
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x27E1210", Offset = "0x27DF810", VA = "0x1827E1210")]
		private void CreatePlaneMesh(ObiDistanceField field)
		{
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x27E1930", Offset = "0x27DFF30", VA = "0x1827E1930")]
		private void RefreshCutawayTexture(ObiDistanceField field)
		{
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x27E1D50", Offset = "0x27E0350", VA = "0x1827E1D50")]
		private void DrawCutawayPlane(ObiDistanceField field, Matrix4x4 matrix)
		{
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x27E2310", Offset = "0x27E0910", VA = "0x1827E2310")]
		public void OnDrawGizmos()
		{
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x27E2710", Offset = "0x27E0D10", VA = "0x1827E2710")]
		public ObiDistanceFieldRenderer()
		{
		}

		// Token: 0x0400067D RID: 1661
		[Token(Token = "0x400067D")]
		[FieldOffset(Offset = "0x20")]
		public ObiDistanceFieldRenderer.Axis axis;

		// Token: 0x0400067E RID: 1662
		[Token(Token = "0x400067E")]
		[FieldOffset(Offset = "0x24")]
		[Range(0f, 1f)]
		public float slice;

		// Token: 0x0400067F RID: 1663
		[Token(Token = "0x400067F")]
		[FieldOffset(Offset = "0x28")]
		public float maxDistance;

		// Token: 0x04000680 RID: 1664
		[Token(Token = "0x4000680")]
		[FieldOffset(Offset = "0x30")]
		private ObiCollider unityCollider;

		// Token: 0x04000681 RID: 1665
		[Token(Token = "0x4000681")]
		[FieldOffset(Offset = "0x38")]
		private Material material;

		// Token: 0x04000682 RID: 1666
		[Token(Token = "0x4000682")]
		[FieldOffset(Offset = "0x40")]
		private Mesh planeMesh;

		// Token: 0x04000683 RID: 1667
		[Token(Token = "0x4000683")]
		[FieldOffset(Offset = "0x48")]
		private Texture2D cutawayTexture;

		// Token: 0x04000684 RID: 1668
		[Token(Token = "0x4000684")]
		[FieldOffset(Offset = "0x50")]
		private float sampleSize;

		// Token: 0x04000685 RID: 1669
		[Token(Token = "0x4000685")]
		[FieldOffset(Offset = "0x54")]
		private int sampleCount;

		// Token: 0x04000686 RID: 1670
		[Token(Token = "0x4000686")]
		[FieldOffset(Offset = "0x58")]
		private Color boundsColor;

		// Token: 0x0200019F RID: 415
		[Token(Token = "0x200019F")]
		public enum Axis
		{
			// Token: 0x04000688 RID: 1672
			[Token(Token = "0x4000688")]
			X,
			// Token: 0x04000689 RID: 1673
			[Token(Token = "0x4000689")]
			Y,
			// Token: 0x0400068A RID: 1674
			[Token(Token = "0x400068A")]
			Z
		}
	}
}
