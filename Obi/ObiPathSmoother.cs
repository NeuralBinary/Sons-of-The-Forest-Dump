using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Profiling;
using UnityEngine;

namespace Obi
{
	// Token: 0x020001FB RID: 507
	[Token(Token = "0x20001FB")]
	[RequireComponent(typeof(ObiRopeBase))]
	[ExecuteInEditMode]
	public class ObiPathSmoother : MonoBehaviour
	{
		// Token: 0x14000015 RID: 21
		// (add) Token: 0x06000A58 RID: 2648 RVA: 0x000020F6 File Offset: 0x000002F6
		// (remove) Token: 0x06000A59 RID: 2649 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x14000015")]
		public event ObiActor.ActorCallback OnCurveGenerated
		{
			[Token(Token = "0x6000A58")]
			[Address(RVA = "0x2819700", Offset = "0x2817D00", VA = "0x182819700")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000A59")]
			[Address(RVA = "0x28197F0", Offset = "0x2817DF0", VA = "0x1828197F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000A5A RID: 2650 RVA: 0x000055C4 File Offset: 0x000037C4
		[Token(Token = "0x170001A7")]
		public float SmoothLength
		{
			[Token(Token = "0x6000A5A")]
			[Address(RVA = "0x179D730", Offset = "0x179BD30", VA = "0x18179D730")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000A5B RID: 2651 RVA: 0x000055DC File Offset: 0x000037DC
		[Token(Token = "0x170001A8")]
		public float SmoothSections
		{
			[Token(Token = "0x6000A5B")]
			[Address(RVA = "0x28198E0", Offset = "0x2817EE0", VA = "0x1828198E0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0x28198F0", Offset = "0x2817EF0", VA = "0x1828198F0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A5D")]
		[Address(RVA = "0x28199A0", Offset = "0x2817FA0", VA = "0x1828199A0")]
		private void OnDisable()
		{
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A5E")]
		[Address(RVA = "0x2819A50", Offset = "0x2818050", VA = "0x182819A50")]
		private void Actor_OnInterpolate(ObiActor actor)
		{
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0x2819AF0", Offset = "0x28180F0", VA = "0x182819AF0")]
		private void AllocateChunk(int sections)
		{
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x000055F4 File Offset: 0x000037F4
		[Token(Token = "0x6000A60")]
		[Address(RVA = "0x2819D20", Offset = "0x2818320", VA = "0x182819D20")]
		private float CalculateChunkLength(ObiList<ObiPathFrame> chunk)
		{
			return 0f;
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A61")]
		[Address(RVA = "0x2819ED0", Offset = "0x28184D0", VA = "0x182819ED0")]
		private void AllocateRawChunks(ObiRopeBase actor)
		{
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A62")]
		[Address(RVA = "0x281A200", Offset = "0x2818800", VA = "0x18281A200")]
		private void PathFrameFromParticle(ObiRopeBase actor, ref ObiPathFrame frame, int particleIndex, bool interpolateOrientation = true)
		{
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A63")]
		[Address(RVA = "0x281A590", Offset = "0x2818B90", VA = "0x18281A590")]
		public void GenerateSmoothChunks(ObiRopeBase actor, uint smoothingLevels)
		{
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x0000560C File Offset: 0x0000380C
		[Token(Token = "0x6000A64")]
		[Address(RVA = "0x281B370", Offset = "0x2819970", VA = "0x18281B370")]
		public ObiPathFrame GetSectionAt(float mu)
		{
			return default(ObiPathFrame);
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x00005624 File Offset: 0x00003824
		[Token(Token = "0x6000A65")]
		[Address(RVA = "0x281B670", Offset = "0x2819C70", VA = "0x18281B670")]
		private bool Decimate(ObiList<ObiPathFrame> input, ObiList<ObiPathFrame> output, float threshold)
		{
			return default(bool);
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A66")]
		[Address(RVA = "0x281BCC0", Offset = "0x281A2C0", VA = "0x18281BCC0")]
		private void Chaikin(ObiList<ObiPathFrame> input, ObiList<ObiPathFrame> output, uint k)
		{
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A67")]
		[Address(RVA = "0x281C490", Offset = "0x281AA90", VA = "0x18281C490")]
		public ObiPathSmoother()
		{
		}

		// Token: 0x04000834 RID: 2100
		[Token(Token = "0x4000834")]
		[FieldOffset(Offset = "0x0")]
		private static ProfilerMarker m_AllocateRawChunksPerfMarker;

		// Token: 0x04000835 RID: 2101
		[Token(Token = "0x4000835")]
		[FieldOffset(Offset = "0x8")]
		private static ProfilerMarker m_GenerateSmoothChunksPerfMarker;

		// Token: 0x04000836 RID: 2102
		[Token(Token = "0x4000836")]
		[FieldOffset(Offset = "0x20")]
		private Matrix4x4 w2l;

		// Token: 0x04000837 RID: 2103
		[Token(Token = "0x4000837")]
		[FieldOffset(Offset = "0x60")]
		private Quaternion w2lRotation;

		// Token: 0x04000838 RID: 2104
		[Token(Token = "0x4000838")]
		[FieldOffset(Offset = "0x70")]
		[Tooltip("Curvature threshold below which the path will be decimated. A value of 0 won't apply any decimation. As you increase the value, decimation will become more aggresive.")]
		[Range(0f, 1f)]
		public float decimation;

		// Token: 0x04000839 RID: 2105
		[Token(Token = "0x4000839")]
		[FieldOffset(Offset = "0x74")]
		[Range(0f, 3f)]
		[Tooltip("Smoothing iterations applied to the path. A smoothing value of 0 won't perform any smoothing at all. Note that smoothing is applied after decimation.")]
		public uint smoothing;

		// Token: 0x0400083A RID: 2106
		[Token(Token = "0x400083A")]
		[FieldOffset(Offset = "0x78")]
		[Tooltip("Twist in degrees applied to each sucessive path section.")]
		public float twist;

		// Token: 0x0400083C RID: 2108
		[Token(Token = "0x400083C")]
		[FieldOffset(Offset = "0x88")]
		protected float smoothLength;

		// Token: 0x0400083D RID: 2109
		[Token(Token = "0x400083D")]
		[FieldOffset(Offset = "0x8C")]
		protected int smoothSections;

		// Token: 0x0400083E RID: 2110
		[Token(Token = "0x400083E")]
		[FieldOffset(Offset = "0x90")]
		[HideInInspector]
		public ObiList<ObiList<ObiPathFrame>> rawChunks;

		// Token: 0x0400083F RID: 2111
		[Token(Token = "0x400083F")]
		[FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public ObiList<ObiList<ObiPathFrame>> smoothChunks;

		// Token: 0x04000840 RID: 2112
		[Token(Token = "0x4000840")]
		[FieldOffset(Offset = "0xA0")]
		private Stack<Vector2Int> stack;
	}
}
