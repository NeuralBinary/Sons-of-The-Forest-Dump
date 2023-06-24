using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace MudBun
{
	// Token: 0x02000062 RID: 98
	[Token(Token = "0x2000062")]
	[ExecuteInEditMode]
	public class MudLockedMeshRenderer : MonoBehaviour, ISerializationCallbackReceiver
	{
		// Token: 0x060002AF RID: 687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x23C8A80", Offset = "0x23C7080", VA = "0x1823C8A80")]
		public void Config(ComputeBuffer drawArgsBuffer, ComputeBuffer getPointsBuffer, MudRendererBase renderer)
		{
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x23C8E80", Offset = "0x23C7480", VA = "0x1823C8E80", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void OnEnable()
		{
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x23C8FF0", Offset = "0x23C75F0", VA = "0x1823C8FF0")]
		private void OnDisable()
		{
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x23C91A0", Offset = "0x23C77A0", VA = "0x1823C91A0")]
		private void Validate()
		{
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x23C9B30", Offset = "0x23C8130", VA = "0x1823C9B30")]
		private void LateUpdate()
		{
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x23C9B50", Offset = "0x23C8150", VA = "0x1823C9B50")]
		private void BindRenderResources()
		{
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x23CA540", Offset = "0x23C8B40", VA = "0x1823CA540")]
		private void Render()
		{
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x23CAAB0", Offset = "0x23C90B0", VA = "0x1823CAAB0")]
		public MudLockedMeshRenderer()
		{
		}

		// Token: 0x040000C5 RID: 197
		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<int, MudLockedMeshRenderer.ComputeBufferCache> s_bufferCachePool;

		// Token: 0x040000C6 RID: 198
		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		private int m_numVerts;

		// Token: 0x040000C7 RID: 199
		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[HideInInspector]
		private int[] m_indirectDrawArgsData;

		// Token: 0x040000C8 RID: 200
		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x30")]
		[HideInInspector]
		[SerializeField]
		private GenPoint[] m_aGenPointData;

		// Token: 0x040000C9 RID: 201
		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[HideInInspector]
		private Aabb m_renderBoundsRs;

		// Token: 0x040000CA RID: 202
		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x50")]
		public Material RenderMaterial;

		// Token: 0x040000CB RID: 203
		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x58")]
		private Material m_materialCloned;

		// Token: 0x040000CC RID: 204
		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0x60")]
		private Material m_materialUsed;

		// Token: 0x040000CD RID: 205
		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x68")]
		public Color MasterColor;

		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x78")]
		public Color MasterEmission;

		// Token: 0x040000CF RID: 207
		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x88")]
		public float MasterMetallic;

		// Token: 0x040000D0 RID: 208
		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x8C")]
		public float MasterSmoothness;

		// Token: 0x040000D1 RID: 209
		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[HideInInspector]
		private MudRendererBase.RenderModeEnum m_renderMode;

		// Token: 0x040000D2 RID: 210
		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x94")]
		[HideInInspector]
		[SerializeField]
		private float m_voxelDensity;

		// Token: 0x040000D3 RID: 211
		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x98")]
		[ConditionalField("m_renderMode", MudRendererBase.RenderModeEnum.CircleSplats, MudRendererBase.RenderModeEnum.QuadSplats, null, null, null, null, Min = 0f, Max = 5f)]
		public float SplatSize;

		// Token: 0x040000D4 RID: 212
		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x9C")]
		[ConditionalField("m_renderMode", MudRendererBase.RenderModeEnum.CircleSplats, MudRendererBase.RenderModeEnum.QuadSplats, null, null, null, null, Min = 0f, Max = 360f)]
		public float SplatRotation;

		// Token: 0x040000D5 RID: 213
		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0xA0")]
		[ConditionalField("m_renderMode", MudRendererBase.RenderModeEnum.CircleSplats, MudRendererBase.RenderModeEnum.QuadSplats, null, null, null, null, Min = 0.1f, Max = 10f)]
		public float SplatRotationNoisiness;

		// Token: 0x040000D6 RID: 214
		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0xA4")]
		[ConditionalField("m_renderMode", MudRendererBase.RenderModeEnum.CircleSplats, MudRendererBase.RenderModeEnum.QuadSplats, null, null, null, null, Min = 0f, Max = 1f)]
		public float SplatCameraFacing;

		// Token: 0x040000D7 RID: 215
		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0xA8")]
		public ShadowCastingMode CastShadows;

		// Token: 0x040000D8 RID: 216
		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0xAC")]
		public bool ReceiveShadows;

		// Token: 0x040000D9 RID: 217
		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0xB0")]
		private ComputeBuffer m_indirectDrawArgsBuffer;

		// Token: 0x040000DA RID: 218
		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0xB8")]
		private ComputeBuffer m_genPointsBuffer;

		// Token: 0x040000DB RID: 219
		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0xC0")]
		private MaterialPropertyBlock m_renderMaterialProps;

		// Token: 0x040000DC RID: 220
		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0xC8")]
		[HideInInspector]
		[SerializeField]
		private int m_hash;

		// Token: 0x02000063 RID: 99
		[Token(Token = "0x2000063")]
		private class ComputeBufferCache
		{
			// Token: 0x060002BA RID: 698 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002BA")]
			[Address(RVA = "0x23F2C90", Offset = "0x23F1290", VA = "0x1823F2C90")]
			public void Release()
			{
			}

			// Token: 0x060002BB RID: 699 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002BB")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public ComputeBufferCache()
			{
			}

			// Token: 0x040000DD RID: 221
			[Token(Token = "0x40000DD")]
			[FieldOffset(Offset = "0x10")]
			public int RefCount;

			// Token: 0x040000DE RID: 222
			[Token(Token = "0x40000DE")]
			[FieldOffset(Offset = "0x18")]
			public int[] IndirectDrawArgsData;

			// Token: 0x040000DF RID: 223
			[Token(Token = "0x40000DF")]
			[FieldOffset(Offset = "0x20")]
			public GenPoint[] GenPointsData;

			// Token: 0x040000E0 RID: 224
			[Token(Token = "0x40000E0")]
			[FieldOffset(Offset = "0x28")]
			public ComputeBuffer IndirectDrawArgsBuffer;

			// Token: 0x040000E1 RID: 225
			[Token(Token = "0x40000E1")]
			[FieldOffset(Offset = "0x30")]
			public ComputeBuffer GenPointsBuffer;
		}
	}
}
