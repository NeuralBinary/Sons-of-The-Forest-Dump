using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

namespace Crest
{
	// Token: 0x02000053 RID: 83
	[Token(Token = "0x2000053")]
	[CreateAssetMenu(fileName = "SimSettingsFoam", menuName = "Crest/Foam Sim Settings", order = 10000)]
	public class SimSettingsFoam : SimSettingsBase
	{
		// Token: 0x060001E1 RID: 481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x9FA540", Offset = "0x9F8B40", VA = "0x1809FA540")]
		public SimSettingsFoam()
		{
		}

		// Token: 0x04000160 RID: 352
		[Token(Token = "0x4000160")]
		[FieldOffset(Offset = "0x18")]
		[Tooltip("Speed at which foam fades/dissipates.")]
		[Range(0f, 20f)]
		public float _foamFadeRate;

		// Token: 0x04000161 RID: 353
		[Token(Token = "0x4000161")]
		[FieldOffset(Offset = "0x1C")]
		[Range(0f, 5f)]
		[Tooltip("Scales intensity of foam generated from waves.")]
		public float _waveFoamStrength;

		// Token: 0x04000162 RID: 354
		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("How much of the waves generate foam.")]
		[Range(0f, 1f)]
		public float _waveFoamCoverage;

		// Token: 0x04000163 RID: 355
		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x24")]
		[Tooltip("Foam will be generated in water shallower than this depth.")]
		[Range(0.01f, 3f)]
		public float _shorelineFoamMaxDepth;

		// Token: 0x04000164 RID: 356
		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Scales intensity of foam generated in shallow water.")]
		[Range(0f, 5f)]
		public float _shorelineFoamStrength;

		// Token: 0x04000165 RID: 357
		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("The rendertexture format to use for the foam simulation")]
		public GraphicsFormat _renderTextureGraphicsFormat;
	}
}
