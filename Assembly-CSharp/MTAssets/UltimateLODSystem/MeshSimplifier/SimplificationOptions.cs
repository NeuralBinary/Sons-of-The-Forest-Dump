using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace MTAssets.UltimateLODSystem.MeshSimplifier
{
	// Token: 0x0200006B RID: 107
	[Token(Token = "0x200006B")]
	[Serializable]
	[StructLayout(3)]
	public struct SimplificationOptions
	{
		// Token: 0x040002FC RID: 764
		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly SimplificationOptions Default;

		// Token: 0x040002FD RID: 765
		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[Tooltip("If the border edges should be preserved.")]
		public bool PreserveBorderEdges;

		// Token: 0x040002FE RID: 766
		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		[Tooltip("If the UV seam edges should be preserved.")]
		public bool PreserveUVSeamEdges;

		// Token: 0x040002FF RID: 767
		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		[Tooltip("If the UV foldover edges should be preserved.")]
		public bool PreserveUVFoldoverEdges;

		// Token: 0x04000300 RID: 768
		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		[Tooltip("If the discrete curvature of the mesh surface be taken into account during simplification. Taking surface curvature into account can result in very good quality mesh simplification, but it can slow the simplification process significantly.")]
		public bool PreserveSurfaceCurvature;

		// Token: 0x04000301 RID: 769
		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[Tooltip("If a feature for smarter vertex linking should be enabled, reducing artifacts at the cost of slower simplification.")]
		public bool EnableSmartLink;

		// Token: 0x04000302 RID: 770
		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[Tooltip("The maximum distance between two vertices in order to link them.")]
		public double VertexLinkDistance;

		// Token: 0x04000303 RID: 771
		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("The maximum iteration count. Higher number is more expensive but can bring you closer to your target quality.")]
		public int MaxIterationCount;

		// Token: 0x04000304 RID: 772
		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The agressiveness of the mesh simplification. Higher number equals higher quality, but more expensive to run.")]
		public double Agressiveness;

		// Token: 0x04000305 RID: 773
		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("If a manual UV component count should be used (set by UV Component Count below), instead of the automatic detection.")]
		public bool ManualUVComponentCount;

		// Token: 0x04000306 RID: 774
		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("The UV component count. The same UV component count will be used on all UV channels.")]
		[Range(0f, 4f)]
		public int UVComponentCount;
	}
}
