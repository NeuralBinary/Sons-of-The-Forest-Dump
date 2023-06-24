using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Crest
{
	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	public class UnderwaterEnvironmentalLighting : MonoBehaviour
	{
		// Token: 0x06000031 RID: 49 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x9F7E30", Offset = "0x9F6430", VA = "0x1809F7E30")]
		private void Start()
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x9F84D0", Offset = "0x9F6AD0", VA = "0x1809F84D0")]
		private void OnDisable()
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x9F8750", Offset = "0x9F6D50", VA = "0x1809F8750")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public UnderwaterEnvironmentalLighting()
		{
		}

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("This profile will be weighed in the deeper underwater the camera goes.")]
		private VolumeProfile _volumeProfile;

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x0")]
		private static Volume _volume;

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x28")]
		private Light _primaryLight;

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x30")]
		private float _lightIntensity;

		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x34")]
		private float _ambientIntensity;

		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x38")]
		private float _reflectionIntensity;

		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x3C")]
		private float _fogDensity;

		// Token: 0x04000079 RID: 121
		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x40")]
		private float _averageDensity;

		// Token: 0x0400007A RID: 122
		[Token(Token = "0x400007A")]
		public const float DEPTH_OUTSCATTER_CONSTANT = 0.25f;
	}
}
