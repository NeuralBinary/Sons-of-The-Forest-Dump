using System;
using Crest;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Atmosphere
{
	// Token: 0x02000044 RID: 68
	[Token(Token = "0x2000044")]
	public class SeasonalOceanWavesController : MonoBehaviour, ISeasonsReceiver, IWindReceiver
	{
		// Token: 0x060001BE RID: 446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x2D471A0", Offset = "0x2D457A0", VA = "0x182D471A0")]
		private void Awake()
		{
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x2D47220", Offset = "0x2D45820", VA = "0x182D47220")]
		private void OnDestroy()
		{
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x2D472A0", Offset = "0x2D458A0", VA = "0x182D472A0", Slot = "4")]
		public void SeasonChanged(SeasonProperties seasonProperties)
		{
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x2D474A0", Offset = "0x2D45AA0", VA = "0x182D474A0", Slot = "6")]
		public void UpdateWind(Vector3 direction, float intensity)
		{
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public SeasonalOceanWavesController()
		{
		}

		// Token: 0x04000191 RID: 401
		[Token(Token = "0x4000191")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ShapeGerstnerBatched _gerstnerBatched;

		// Token: 0x04000192 RID: 402
		[Token(Token = "0x4000192")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private OceanWaveSpectrum _cachedWaveSpectrum;
	}
}
