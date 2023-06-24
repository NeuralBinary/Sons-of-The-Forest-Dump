using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Crest
{
	// Token: 0x02000054 RID: 84
	[Token(Token = "0x2000054")]
	[CreateAssetMenu(fileName = "SimSettingsDynamicWaves", menuName = "Crest/Dynamic Wave Sim Settings", order = 10000)]
	public class SimSettingsWave : SimSettingsBase
	{
		// Token: 0x060001E2 RID: 482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x9FA580", Offset = "0x9F8B80", VA = "0x1809FA580")]
		public SimSettingsWave()
		{
		}

		// Token: 0x04000166 RID: 358
		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x18")]
		[Tooltip("NOT CURRENTLY WORKING. The wave sim will not run if the simulation grid is smaller in resolution than this size. Useful to limit sim range for performance.")]
		[Range(0f, 32f)]
		[HideInInspector]
		public float _minGridSize;

		// Token: 0x04000167 RID: 359
		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x1C")]
		[HideInInspector]
		[Tooltip("NOT CURRENTLY WORKING. The wave sim will not run if the simulation grid is bigger in resolution than this size. Zero means no constraint/unlimited resolutions. Useful to limit sim range for performance.")]
		[Range(0f, 32f)]
		public float _maxGridSize;

		// Token: 0x04000168 RID: 360
		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x20")]
		[Header("Stability")]
		[Range(0f, 1f)]
		[Tooltip("How much energy is dissipated each frame. Helps sim stability, but limits how far ripples will propagate. Set this as large as possible/acceptable.")]
		public float _damping;

		// Token: 0x04000169 RID: 361
		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x24")]
		[Tooltip("Stability measurement. Lower values means more stable sim, at the cost of more computation. This value should be set as large as possible until sim instabilities/flickering begin to appear.")]
		[Range(0.1f, 3f)]
		public float _courantNumber;

		// Token: 0x0400016A RID: 362
		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("How many simulation substeps are allowed per frame. Run at target framerate with the OceanDebugGUI visible to see how many substeps are being done when the camera is close to the water, and set the limit to this value. If the max substeps is set lower than this value, the detailed/high frequency waves will propagate slower than they would in reality. For many applications this may not be an issue.")]
		[Range(1f, 8f)]
		public int _maxSimStepsPerFrame;

		// Token: 0x0400016B RID: 363
		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("Induce horizontal displacements to sharpen simulated waves.")]
		[Range(0f, 20f)]
		[Header("Displacement Generation")]
		public float _horizDisplace;

		// Token: 0x0400016C RID: 364
		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		[Tooltip("Clamp displacement to help prevent self-intersection in steep waves. Zero means unclamped.")]
		public float _displaceClamp;

		// Token: 0x0400016D RID: 365
		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x34")]
		[Range(0f, 64f)]
		[Tooltip("Multiplier for gravity. More gravity means dynamic waves will travel faster.")]
		public float _gravityMultiplier;
	}
}
