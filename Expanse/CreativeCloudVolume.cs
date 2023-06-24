using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Expanse
{
	// Token: 0x02000021 RID: 33
	[Token(Token = "0x2000021")]
	[ExecuteInEditMode]
	[Serializable]
	public class CreativeCloudVolume : MonoBehaviour
	{
		// Token: 0x06000252 RID: 594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000252")]
		[Address(RVA = "0xAC0F90", Offset = "0xABF590", VA = "0x180AC0F90")]
		private void Update()
		{
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000253")]
		[Address(RVA = "0xAC1330", Offset = "0xABF930", VA = "0x180AC1330")]
		public CreativeCloudVolume()
		{
		}

		// Token: 0x040001A6 RID: 422
		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0x20")]
		public ProceduralCloudVolumeBlock m_cloudVolume;

		// Token: 0x040001A7 RID: 423
		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		public float m_coverage;

		// Token: 0x040001A8 RID: 424
		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0x2C")]
		public float m_height;

		// Token: 0x040001A9 RID: 425
		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0x30")]
		[Min(0f)]
		public float m_thickness;

		// Token: 0x040001AA RID: 426
		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0x34")]
		[Min(0f)]
		public float m_density;

		// Token: 0x040001AB RID: 427
		[Token(Token = "0x40001AB")]
		[FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public float m_shadowing;

		// Token: 0x040001AC RID: 428
		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		public float m_ambient;

		// Token: 0x040001AD RID: 429
		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		public float m_silverLining;

		// Token: 0x040001AE RID: 430
		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0x44")]
		[Range(0f, 1f)]
		public float m_silverLiningSpread;

		// Token: 0x040001AF RID: 431
		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		public float m_raininess;

		// Token: 0x040001B0 RID: 432
		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		public float m_swirl;

		// Token: 0x040001B1 RID: 433
		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0x50")]
		public Vector2 m_wind;

		// Token: 0x040001B2 RID: 434
		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0x58")]
		public Datatypes.Quality m_quality;

		// Token: 0x040001B3 RID: 435
		[Token(Token = "0x40001B3")]
		private const float kCoverageCutoff = 0.7f;
	}
}
