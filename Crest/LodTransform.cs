using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Crest
{
	// Token: 0x02000041 RID: 65
	[Token(Token = "0x2000041")]
	public class LodTransform : IFloatingOrigin
	{
		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000186 RID: 390 RVA: 0x000028B0 File Offset: 0x00000AB0
		// (set) Token: 0x06000187 RID: 391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004A")]
		public int LodCount
		{
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x632000", Offset = "0x630600", VA = "0x180632000")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000187")]
			[Address(RVA = "0x670F30", Offset = "0x66F530", VA = "0x180670F30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000188 RID: 392 RVA: 0x000028C8 File Offset: 0x00000AC8
		[Token(Token = "0x6000188")]
		[Address(RVA = "0x9E6DE0", Offset = "0x9E53E0", VA = "0x1809E6DE0")]
		public Matrix4x4 GetWorldToCameraMatrix(int lodIdx)
		{
			return default(Matrix4x4);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x000028E0 File Offset: 0x00000AE0
		[Token(Token = "0x6000189")]
		[Address(RVA = "0x9E6E40", Offset = "0x9E5440", VA = "0x1809E6E40")]
		public Matrix4x4 GetProjectionMatrix(int lodIdx)
		{
			return default(Matrix4x4);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018A")]
		[Address(RVA = "0x9E6EA0", Offset = "0x9E54A0", VA = "0x1809E6EA0")]
		public void InitLODData(int lodCount)
		{
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x9E7140", Offset = "0x9E5740", VA = "0x1809E7140")]
		public void UpdateTransforms()
		{
		}

		// Token: 0x0600018C RID: 396 RVA: 0x000028F8 File Offset: 0x00000AF8
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x9E7960", Offset = "0x9E5F60", VA = "0x1809E7960")]
		public static Matrix4x4 CalculateWorldToCameraMatrixRHS(Vector3 position, Quaternion rotation)
		{
			return default(Matrix4x4);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x9E7BB0", Offset = "0x9E61B0", VA = "0x1809E7BB0")]
		public void SetViewProjectionMatrices(int lodIdx, CommandBuffer buf)
		{
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00002910 File Offset: 0x00000B10
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x9E7CC0", Offset = "0x9E62C0", VA = "0x1809E7CC0")]
		public float MaxWavelength(int lodIdx)
		{
			return 0f;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x9E7E60", Offset = "0x9E6460", VA = "0x1809E7E60", Slot = "4")]
		public void SetOrigin(Vector3 newOrigin)
		{
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x9E7F80", Offset = "0x9E6580", VA = "0x1809E7F80")]
		public void WriteCascadeParams(OceanRenderer.CascadeParams[] cascadeParamsTgt, OceanRenderer.CascadeParams[] cascadeParamsSrc)
		{
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public LodTransform()
		{
		}

		// Token: 0x04000123 RID: 291
		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x10")]
		protected int[] _transformUpdateFrame;

		// Token: 0x04000124 RID: 292
		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x18")]
		public LodTransform.RenderData[] _renderData;

		// Token: 0x04000125 RID: 293
		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x20")]
		public LodTransform.RenderData[] _renderDataSource;

		// Token: 0x04000127 RID: 295
		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x30")]
		private Matrix4x4[] _worldToCameraMatrix;

		// Token: 0x04000128 RID: 296
		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x38")]
		private Matrix4x4[] _projectionMatrix;

		// Token: 0x02000042 RID: 66
		[Token(Token = "0x2000042")]
		[Serializable]
		public struct RenderData
		{
			// Token: 0x06000192 RID: 402 RVA: 0x00002928 File Offset: 0x00000B28
			[Token(Token = "0x6000192")]
			[Address(RVA = "0x9E8620", Offset = "0x9E6C20", VA = "0x1809E8620")]
			public LodTransform.RenderData Validate(int frameOffset, string context)
			{
				return default(LodTransform.RenderData);
			}

			// Token: 0x1700004B RID: 75
			// (get) Token: 0x06000193 RID: 403 RVA: 0x00002940 File Offset: 0x00000B40
			[Token(Token = "0x1700004B")]
			public Rect RectXZ
			{
				[Token(Token = "0x6000193")]
				[Address(RVA = "0x9E86D0", Offset = "0x9E6CD0", VA = "0x1809E86D0")]
				get
				{
					return default(Rect);
				}
			}

			// Token: 0x04000129 RID: 297
			[Token(Token = "0x4000129")]
			[FieldOffset(Offset = "0x0")]
			public float _texelWidth;

			// Token: 0x0400012A RID: 298
			[Token(Token = "0x400012A")]
			[FieldOffset(Offset = "0x4")]
			public float _textureRes;

			// Token: 0x0400012B RID: 299
			[Token(Token = "0x400012B")]
			[FieldOffset(Offset = "0x8")]
			public Vector3 _posSnapped;

			// Token: 0x0400012C RID: 300
			[Token(Token = "0x400012C")]
			[FieldOffset(Offset = "0x14")]
			public int _frame;
		}
	}
}
