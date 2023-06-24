using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Expanse
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	[ExecuteInEditMode]
	[Serializable]
	public abstract class BaseCloudLayerBlock : MonoBehaviour
	{
		// Token: 0x060001EE RID: 494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EE")]
		[Address(RVA = "0xAB5760", Offset = "0xAB3D60", VA = "0x180AB5760")]
		protected void OnEnable()
		{
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EF")]
		[Address(RVA = "0xAB58E0", Offset = "0xAB3EE0", VA = "0x180AB58E0")]
		protected void OnDisable()
		{
		}

		// Token: 0x060001F0 RID: 496
		[Token(Token = "0x60001F0")]
		public abstract UniversalCloudLayer ToUniversal();

		// Token: 0x060001F1 RID: 497
		[Token(Token = "0x60001F1")]
		public abstract void FromUniversal(UniversalCloudLayer from, bool bypassOffset = false);

		// Token: 0x060001F2 RID: 498
		[Token(Token = "0x60001F2")]
		public abstract bool SetTexture(CloudDatatypes.CloudNoiseLayer noiseLayer, Texture texture, int tile);

		// Token: 0x060001F3 RID: 499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0xAB5990", Offset = "0xAB3F90", VA = "0x180AB5990")]
		public void SaveUniversal(string filepath)
		{
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0xAB59D0", Offset = "0xAB3FD0", VA = "0x180AB59D0")]
		public void LoadUniversal(string filepath)
		{
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		protected BaseCloudLayerBlock()
		{
		}
	}
}
