using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Crest
{
	// Token: 0x0200003F RID: 63
	[Token(Token = "0x200003F")]
	public abstract class LodDataMgrPersistent : LodDataMgr
	{
		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600016F RID: 367 RVA: 0x00002820 File Offset: 0x00000A20
		[Token(Token = "0x17000044")]
		protected override bool NeedToReadWriteTextureData
		{
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000170 RID: 368
		[Token(Token = "0x17000045")]
		protected abstract string ShaderSim { [Token(Token = "0x6000170")] get; }

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000171 RID: 369
		[Token(Token = "0x17000046")]
		protected abstract int krnl_ShaderSim { [Token(Token = "0x6000171")] get; }

		// Token: 0x06000172 RID: 370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000172")]
		[Address(RVA = "0x9E5280", Offset = "0x9E3880", VA = "0x1809E5280")]
		public LodDataMgrPersistent(OceanRenderer ocean)
		{
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000173")]
		[Address(RVA = "0x9E4C40", Offset = "0x9E3240", VA = "0x1809E4C40", Slot = "8")]
		public override void Start()
		{
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000174")]
		[Address(RVA = "0x9E54A0", Offset = "0x9E3AA0", VA = "0x1809E54A0")]
		private void CreateProperties()
		{
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000175")]
		[Address(RVA = "0x9E56B0", Offset = "0x9E3CB0", VA = "0x1809E56B0", Slot = "9")]
		protected override void InitData()
		{
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000176")]
		[Address(RVA = "0x9E5980", Offset = "0x9E3F80", VA = "0x1809E5980")]
		public void ValidateSourceData(bool usePrevTransform)
		{
		}

		// Token: 0x06000177 RID: 375
		[Token(Token = "0x6000177")]
		public abstract void GetSimSubstepData(float frameDt, out int numSubsteps, out float substepDt);

		// Token: 0x06000178 RID: 376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000178")]
		[Address(RVA = "0x9E5B80", Offset = "0x9E4180", VA = "0x1809E5B80", Slot = "11")]
		public override void BuildCommandBuffer(OceanRenderer ocean, CommandBuffer buf)
		{
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00002838 File Offset: 0x00000A38
		[Token(Token = "0x6000179")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "17")]
		protected virtual bool BuildCommandBufferInternal(int lodIdx)
		{
			return default(bool);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "18")]
		protected virtual void SetAdditionalSimParams(IPropertyWrapper simMaterial)
		{
		}

		// Token: 0x04000115 RID: 277
		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x38")]
		private RenderTexture _sources;

		// Token: 0x04000116 RID: 278
		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x40")]
		private PropertyWrapperCompute _renderSimProperties;

		// Token: 0x04000117 RID: 279
		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x48")]
		private readonly int sp_LD_TexArray_Target;

		// Token: 0x04000118 RID: 280
		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x4C")]
		private readonly int sp_cascadeDataSrc;

		// Token: 0x04000119 RID: 281
		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x50")]
		protected ComputeShader _shader;

		// Token: 0x0400011A RID: 282
		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x58")]
		private float _substepDtPrevious;

		// Token: 0x0400011B RID: 283
		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x5C")]
		private readonly int sp_SimDeltaTime;

		// Token: 0x0400011C RID: 284
		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x60")]
		private readonly int sp_SimDeltaTimePrev;
	}
}
