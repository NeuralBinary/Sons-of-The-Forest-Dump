using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Expanse
{
	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000019")]
	[ExecuteInEditMode]
	[Serializable]
	public class ProceduralNoiseBlock : BaseTextureGeneratorBlock
	{
		// Token: 0x06000225 RID: 549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000225")]
		[Address(RVA = "0xABD2C0", Offset = "0xABB8C0", VA = "0x180ABD2C0")]
		private void Start()
		{
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000226")]
		[Address(RVA = "0xABD370", Offset = "0xABB970", VA = "0x180ABD370")]
		private void OnEnable()
		{
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000227")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void OnDisable()
		{
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000228")]
		[Address(RVA = "0xABD380", Offset = "0xABB980", VA = "0x180ABD380")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000229")]
		[Address(RVA = "0xABD480", Offset = "0xABBA80", VA = "0x180ABD480")]
		private void Update()
		{
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022A")]
		[Address(RVA = "0xABD790", Offset = "0xABBD90", VA = "0x180ABD790")]
		private void regenerate()
		{
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022B")]
		[Address(RVA = "0xABDCD0", Offset = "0xABC2D0", VA = "0x180ABDCD0")]
		private void reallocateTargetIfNecessary()
		{
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00004DB2 File Offset: 0x00002FB2
		[Token(Token = "0x600022C")]
		[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0", Slot = "4")]
		public override RTHandle GetTexture()
		{
			return null;
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022D")]
		[Address(RVA = "0xABE1F0", Offset = "0xABC7F0", VA = "0x180ABE1F0", Slot = "5")]
		public override void ForceUpdate()
		{
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00004DE8 File Offset: 0x00002FE8
		[Token(Token = "0x600022E")]
		[Address(RVA = "0xABE200", Offset = "0xABC800", VA = "0x180ABE200", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022F")]
		[Address(RVA = "0xABE2E0", Offset = "0xABC8E0", VA = "0x180ABE2E0")]
		public ProceduralNoiseBlock()
		{
		}

		// Token: 0x0400012F RID: 303
		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Name for this texture.")]
		public string m_name;

		// Token: 0x04000130 RID: 304
		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Desired texture dimension.")]
		public Datatypes.NoiseDimension m_dimension;

		// Token: 0x04000131 RID: 305
		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("Desired texture resolution.")]
		public Vector2Int m_res2D;

		// Token: 0x04000132 RID: 306
		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0x34")]
		[Tooltip("Desired texture resolution.")]
		public Vector3Int m_res3D;

		// Token: 0x04000133 RID: 307
		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("Type of noise.")]
		public Datatypes.NoiseType m_noiseType;

		// Token: 0x04000134 RID: 308
		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x44")]
		[Tooltip("Scale of noise.")]
		public Vector2Int m_scale;

		// Token: 0x04000135 RID: 309
		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0x4C")]
		[Tooltip("How many octaves of noise to compute.")]
		[Range(1f, 8f)]
		public int m_octaves;

		// Token: 0x04000136 RID: 310
		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0x50")]
		[Min(1f)]
		[Tooltip("How much to scale each octave by.")]
		public float m_octaveScale;

		// Token: 0x04000137 RID: 311
		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0x54")]
		[Tooltip("How much influence each successive octave has.")]
		[Min(0f)]
		public float m_octaveMultiplier;

		// Token: 0x04000138 RID: 312
		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0x58")]
		private RTHandle m_target;

		// Token: 0x04000139 RID: 313
		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0x60")]
		private ComputeShader m_CS;

		// Token: 0x0400013A RID: 314
		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0x0")]
		private static Vector2Int kMaxResolution2D;

		// Token: 0x0400013B RID: 315
		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0x8")]
		private static Vector3Int kMaxResolution3D;

		// Token: 0x0400013C RID: 316
		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x68")]
		private int m_hashCode;

		// Token: 0x0400013D RID: 317
		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x6C")]
		private bool m_forceUpdate;
	}
}
