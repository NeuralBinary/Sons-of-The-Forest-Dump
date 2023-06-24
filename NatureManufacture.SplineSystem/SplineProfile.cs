using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x0200000A RID: 10
[Token(Token = "0x200000A")]
[CreateAssetMenu(fileName = "SplineProfile", menuName = "SplineProfile", order = 1)]
public class SplineProfile : ScriptableObject
{
	// Token: 0x06000045 RID: 69 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000045")]
	[Address(RVA = "0x24852A0", Offset = "0x24838A0", VA = "0x1824852A0")]
	public SplineProfile()
	{
	}

	// Token: 0x0400011D RID: 285
	[Token(Token = "0x400011D")]
	[FieldOffset(Offset = "0x18")]
	public Material splineMaterial;

	// Token: 0x0400011E RID: 286
	[Token(Token = "0x400011E")]
	[FieldOffset(Offset = "0x20")]
	public AnimationCurve meshCurve;

	// Token: 0x0400011F RID: 287
	[Token(Token = "0x400011F")]
	[FieldOffset(Offset = "0x28")]
	public float minVal;

	// Token: 0x04000120 RID: 288
	[Token(Token = "0x4000120")]
	[FieldOffset(Offset = "0x2C")]
	public float maxVal;

	// Token: 0x04000121 RID: 289
	[Token(Token = "0x4000121")]
	[FieldOffset(Offset = "0x30")]
	public int vertsInShape;

	// Token: 0x04000122 RID: 290
	[Token(Token = "0x4000122")]
	[FieldOffset(Offset = "0x34")]
	public float traingleDensity;

	// Token: 0x04000123 RID: 291
	[Token(Token = "0x4000123")]
	[FieldOffset(Offset = "0x38")]
	public float uvScale;

	// Token: 0x04000124 RID: 292
	[Token(Token = "0x4000124")]
	[FieldOffset(Offset = "0x3C")]
	public bool uvRotation;

	// Token: 0x04000125 RID: 293
	[Token(Token = "0x4000125")]
	[FieldOffset(Offset = "0x3D")]
	public bool receiveShadows;

	// Token: 0x04000126 RID: 294
	[Token(Token = "0x4000126")]
	[FieldOffset(Offset = "0x40")]
	public ShadowCastingMode shadowCastingMode;

	// Token: 0x04000127 RID: 295
	[Token(Token = "0x4000127")]
	[FieldOffset(Offset = "0x48")]
	public AnimationCurve flowFlat;

	// Token: 0x04000128 RID: 296
	[Token(Token = "0x4000128")]
	[FieldOffset(Offset = "0x50")]
	public AnimationCurve flowWaterfall;

	// Token: 0x04000129 RID: 297
	[Token(Token = "0x4000129")]
	[FieldOffset(Offset = "0x58")]
	public bool noiseflowMap;

	// Token: 0x0400012A RID: 298
	[Token(Token = "0x400012A")]
	[FieldOffset(Offset = "0x5C")]
	public float noiseMultiplierflowMap;

	// Token: 0x0400012B RID: 299
	[Token(Token = "0x400012B")]
	[FieldOffset(Offset = "0x60")]
	public float noiseSizeXflowMap;

	// Token: 0x0400012C RID: 300
	[Token(Token = "0x400012C")]
	[FieldOffset(Offset = "0x64")]
	public float noiseSizeZflowMap;

	// Token: 0x0400012D RID: 301
	[Token(Token = "0x400012D")]
	[FieldOffset(Offset = "0x68")]
	public float floatSpeed;

	// Token: 0x0400012E RID: 302
	[Token(Token = "0x400012E")]
	[FieldOffset(Offset = "0x70")]
	public AnimationCurve terrainCarve;

	// Token: 0x0400012F RID: 303
	[Token(Token = "0x400012F")]
	[FieldOffset(Offset = "0x78")]
	public float distSmooth;

	// Token: 0x04000130 RID: 304
	[Token(Token = "0x4000130")]
	[FieldOffset(Offset = "0x7C")]
	public float distSmoothStart;

	// Token: 0x04000131 RID: 305
	[Token(Token = "0x4000131")]
	[FieldOffset(Offset = "0x80")]
	public AnimationCurve terrainPaintCarve;

	// Token: 0x04000132 RID: 306
	[Token(Token = "0x4000132")]
	[FieldOffset(Offset = "0x88")]
	public bool noiseCarve;

	// Token: 0x04000133 RID: 307
	[Token(Token = "0x4000133")]
	[FieldOffset(Offset = "0x8C")]
	public float noiseMultiplierInside;

	// Token: 0x04000134 RID: 308
	[Token(Token = "0x4000134")]
	[FieldOffset(Offset = "0x90")]
	public float noiseMultiplierOutside;

	// Token: 0x04000135 RID: 309
	[Token(Token = "0x4000135")]
	[FieldOffset(Offset = "0x94")]
	public float noiseSizeX;

	// Token: 0x04000136 RID: 310
	[Token(Token = "0x4000136")]
	[FieldOffset(Offset = "0x98")]
	public float noiseSizeZ;

	// Token: 0x04000137 RID: 311
	[Token(Token = "0x4000137")]
	[FieldOffset(Offset = "0x9C")]
	public float terrainSmoothMultiplier;

	// Token: 0x04000138 RID: 312
	[Token(Token = "0x4000138")]
	[FieldOffset(Offset = "0xA0")]
	public int currentSplatMap;

	// Token: 0x04000139 RID: 313
	[Token(Token = "0x4000139")]
	[FieldOffset(Offset = "0xA4")]
	public bool mixTwoSplatMaps;

	// Token: 0x0400013A RID: 314
	[Token(Token = "0x400013A")]
	[FieldOffset(Offset = "0xA8")]
	public int secondSplatMap;

	// Token: 0x0400013B RID: 315
	[Token(Token = "0x400013B")]
	[FieldOffset(Offset = "0xAC")]
	public bool addCliffSplatMap;

	// Token: 0x0400013C RID: 316
	[Token(Token = "0x400013C")]
	[FieldOffset(Offset = "0xB0")]
	public int cliffSplatMap;

	// Token: 0x0400013D RID: 317
	[Token(Token = "0x400013D")]
	[FieldOffset(Offset = "0xB4")]
	public float cliffAngle;

	// Token: 0x0400013E RID: 318
	[Token(Token = "0x400013E")]
	[FieldOffset(Offset = "0xB8")]
	public float cliffBlend;

	// Token: 0x0400013F RID: 319
	[Token(Token = "0x400013F")]
	[FieldOffset(Offset = "0xBC")]
	public int cliffSplatMapOutside;

	// Token: 0x04000140 RID: 320
	[Token(Token = "0x4000140")]
	[FieldOffset(Offset = "0xC0")]
	public float cliffAngleOutside;

	// Token: 0x04000141 RID: 321
	[Token(Token = "0x4000141")]
	[FieldOffset(Offset = "0xC4")]
	public float cliffBlendOutside;

	// Token: 0x04000142 RID: 322
	[Token(Token = "0x4000142")]
	[FieldOffset(Offset = "0xC8")]
	public float distanceClearFoliage;

	// Token: 0x04000143 RID: 323
	[Token(Token = "0x4000143")]
	[FieldOffset(Offset = "0xCC")]
	public float distanceClearFoliageTrees;

	// Token: 0x04000144 RID: 324
	[Token(Token = "0x4000144")]
	[FieldOffset(Offset = "0xD0")]
	public bool noisePaint;

	// Token: 0x04000145 RID: 325
	[Token(Token = "0x4000145")]
	[FieldOffset(Offset = "0xD4")]
	public float noiseMultiplierInsidePaint;

	// Token: 0x04000146 RID: 326
	[Token(Token = "0x4000146")]
	[FieldOffset(Offset = "0xD8")]
	public float noiseMultiplierOutsidePaint;

	// Token: 0x04000147 RID: 327
	[Token(Token = "0x4000147")]
	[FieldOffset(Offset = "0xDC")]
	public float noiseSizeXPaint;

	// Token: 0x04000148 RID: 328
	[Token(Token = "0x4000148")]
	[FieldOffset(Offset = "0xE0")]
	public float noiseSizeZPaint;

	// Token: 0x04000149 RID: 329
	[Token(Token = "0x4000149")]
	[FieldOffset(Offset = "0xE4")]
	public float simulatedRiverLength;

	// Token: 0x0400014A RID: 330
	[Token(Token = "0x400014A")]
	[FieldOffset(Offset = "0xE8")]
	public int simulatedRiverPoints;

	// Token: 0x0400014B RID: 331
	[Token(Token = "0x400014B")]
	[FieldOffset(Offset = "0xEC")]
	public float simulatedMinStepSize;

	// Token: 0x0400014C RID: 332
	[Token(Token = "0x400014C")]
	[FieldOffset(Offset = "0xF0")]
	public bool simulatedNoUp;

	// Token: 0x0400014D RID: 333
	[Token(Token = "0x400014D")]
	[FieldOffset(Offset = "0xF1")]
	public bool simulatedBreakOnUp;

	// Token: 0x0400014E RID: 334
	[Token(Token = "0x400014E")]
	[FieldOffset(Offset = "0xF2")]
	public bool noiseWidth;

	// Token: 0x0400014F RID: 335
	[Token(Token = "0x400014F")]
	[FieldOffset(Offset = "0xF4")]
	public float noiseMultiplierWidth;

	// Token: 0x04000150 RID: 336
	[Token(Token = "0x4000150")]
	[FieldOffset(Offset = "0xF8")]
	public float noiseSizeWidth;

	// Token: 0x04000151 RID: 337
	[Token(Token = "0x4000151")]
	[FieldOffset(Offset = "0xFC")]
	public int biomeType;
}
