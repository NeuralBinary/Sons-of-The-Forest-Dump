using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Profiling;
using UnityEngine;

namespace Obi
{
	// Token: 0x020001B0 RID: 432
	[Token(Token = "0x20001B0")]
	[ExecuteInEditMode]
	public abstract class ObiUpdater : MonoBehaviour
	{
		// Token: 0x06000877 RID: 2167 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000877")]
		[Address(RVA = "0x27F2A30", Offset = "0x27F1030", VA = "0x1827F2A30")]
		protected void BeginStep(float stepDeltaTime)
		{
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000878")]
		[Address(RVA = "0x27F2F60", Offset = "0x27F1560", VA = "0x1827F2F60")]
		protected void Substep(float stepDeltaTime, float substepDeltaTime, int index)
		{
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000879")]
		[Address(RVA = "0x27F3460", Offset = "0x27F1A60", VA = "0x1827F3460")]
		protected void EndStep(float substepDeltaTime)
		{
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600087A")]
		[Address(RVA = "0x27F3770", Offset = "0x27F1D70", VA = "0x1827F3770")]
		protected void Interpolate(float stepDeltaTime, float accumulatedTime)
		{
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600087B")]
		[Address(RVA = "0x27F3A40", Offset = "0x27F2040", VA = "0x1827F3A40")]
		protected ObiUpdater()
		{
		}

		// Token: 0x04000725 RID: 1829
		[Token(Token = "0x4000725")]
		[FieldOffset(Offset = "0x0")]
		private static ProfilerMarker m_BeginStepPerfMarker;

		// Token: 0x04000726 RID: 1830
		[Token(Token = "0x4000726")]
		[FieldOffset(Offset = "0x8")]
		private static ProfilerMarker m_SubstepPerfMarker;

		// Token: 0x04000727 RID: 1831
		[Token(Token = "0x4000727")]
		[FieldOffset(Offset = "0x10")]
		private static ProfilerMarker m_EndStepPerfMarker;

		// Token: 0x04000728 RID: 1832
		[Token(Token = "0x4000728")]
		[FieldOffset(Offset = "0x18")]
		private static ProfilerMarker m_InterpolatePerfMarker;

		// Token: 0x04000729 RID: 1833
		[Token(Token = "0x4000729")]
		[FieldOffset(Offset = "0x20")]
		public List<ObiSolver> solvers;
	}
}
