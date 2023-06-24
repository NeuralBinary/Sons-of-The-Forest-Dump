using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Atmosphere
{
	// Token: 0x02000027 RID: 39
	[Token(Token = "0x2000027")]
	[CreateAssetMenu(fileName = "CloudModelDataProfile", menuName = "Sons/Atmosphere/CloudModelDataProfile")]
	public class CloudModelDataProfile : ScriptableObject
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000130 RID: 304 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x1700000F")]
		private Keyframe[] DensityCurveKeys
		{
			[Token(Token = "0x6000130")]
			[Address(RVA = "0x2D3D6C0", Offset = "0x2D3BCC0", VA = "0x182D3D6C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000131 RID: 305 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000010")]
		private Keyframe[] ErosionCurveKeys
		{
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x2D3D780", Offset = "0x2D3BD80", VA = "0x182D3D780")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000132 RID: 306 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000011")]
		private Keyframe[] AmbientOcclusionCurveKeys
		{
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x2D3D840", Offset = "0x2D3BE40", VA = "0x182D3D840")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x2D3D900", Offset = "0x2D3BF00", VA = "0x182D3D900")]
		public static void Lerp(CloudModelDataProfile aData, CloudModelDataProfile bData, float factor, ref CloudModelDataProfile dest)
		{
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000134")]
		[Address(RVA = "0x2D3DEC0", Offset = "0x2D3C4C0", VA = "0x182D3DEC0")]
		private static AnimationCurve LerpAnimationCurve(float factor, AnimationCurve curveA, AnimationCurve curveB, ref AnimationCurve dest, ref Keyframe[] lerpedKeyBuffer, Keyframe[] curveAKeys, Keyframe[] curveBKeys)
		{
			return null;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x2D3E510", Offset = "0x2D3CB10", VA = "0x182D3E510")]
		public void SetFields(float densityMultiplier, float shapeFactor, float shapeScale, float erosionFactor, float erosionScale, AnimationCurve densityCurve, AnimationCurve erosionCurve, AnimationCurve ambientOcclusionCurve, float bottomAltitude, float altitudeRange)
		{
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x2D3E660", Offset = "0x2D3CC60", VA = "0x182D3E660")]
		public CloudModelDataProfile()
		{
		}

		// Token: 0x0400010F RID: 271
		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public float DensityMultiplier;

		// Token: 0x04000110 RID: 272
		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		public float ShapeFactor;

		// Token: 0x04000111 RID: 273
		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public float ShapeScale;

		// Token: 0x04000112 RID: 274
		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		public float ErosionFactor;

		// Token: 0x04000113 RID: 275
		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		public float ErosionScale;

		// Token: 0x04000114 RID: 276
		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		public AnimationCurve DensityCurve;

		// Token: 0x04000115 RID: 277
		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		public AnimationCurve ErosionCurve;

		// Token: 0x04000116 RID: 278
		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		public AnimationCurve AmbientOcclusionCurve;

		// Token: 0x04000117 RID: 279
		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x48")]
		private Keyframe[] _densityKeyBuffer;

		// Token: 0x04000118 RID: 280
		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x50")]
		private Keyframe[] _erosionKeyBuffer;

		// Token: 0x04000119 RID: 281
		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x58")]
		private Keyframe[] _ambientOcclusionKeyBuffer;

		// Token: 0x0400011A RID: 282
		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		public float BottomAltitude;

		// Token: 0x0400011B RID: 283
		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		public float AltitudeRange;

		// Token: 0x0400011C RID: 284
		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x68")]
		private Keyframe[] _densityCurveKeysCached;

		// Token: 0x0400011D RID: 285
		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x70")]
		private Keyframe[] _erosionCurveKeysCached;

		// Token: 0x0400011E RID: 286
		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x78")]
		private Keyframe[] _ambientOcclusionCurveKeysCached;
	}
}
