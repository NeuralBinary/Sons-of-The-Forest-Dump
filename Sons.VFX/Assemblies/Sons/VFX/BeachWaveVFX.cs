using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

namespace Assemblies.Sons.VFX
{
	// Token: 0x02000032 RID: 50
	[Token(Token = "0x2000032")]
	public class BeachWaveVFX : MonoBehaviour
	{
		// Token: 0x060000F9 RID: 249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x3178C70", Offset = "0x3177270", VA = "0x183178C70")]
		private void Restart()
		{
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x3178C80", Offset = "0x3177280", VA = "0x183178C80")]
		private void InitFXLists()
		{
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x3178C90", Offset = "0x3177290", VA = "0x183178C90")]
		private void InitializeFXLists()
		{
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x3179020", Offset = "0x3177620", VA = "0x183179020")]
		private void OnEnable()
		{
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x31796D0", Offset = "0x3177CD0", VA = "0x1831796D0")]
		private void OnValidate()
		{
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00002208 File Offset: 0x00000408
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x31797F0", Offset = "0x3177DF0", VA = "0x1831797F0")]
		private float GetMaxTime(AnimationCurve animCurve, float defaultResult)
		{
			return 0f;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x3179920", Offset = "0x3177F20", VA = "0x183179920")]
		private void StartLoop()
		{
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x3179C30", Offset = "0x3178230", VA = "0x183179C30")]
		private void Update()
		{
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x317A8C0", Offset = "0x3178EC0", VA = "0x18317A8C0")]
		private void AnimateProjectorFade(DecalProjector projector, AnimationCurve alphaCurve, float currentTime)
		{
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x317A970", Offset = "0x3178F70", VA = "0x18317A970")]
		private void AnimateMaterialAlpha(DecalProjector projector, int alphaNameId, AnimationCurve alphaCurve, float currentTime, ref Material materialInstance, float multiplier)
		{
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x317ACE0", Offset = "0x31792E0", VA = "0x18317ACE0")]
		private void AnimateWetnessDecalAlpha(DecalProjector projector, AnimationCurve alphaCurve, float currentTime, ref Material materialInstance, float origSmoothAlpha, float origAlpha, float origNormalAlpha, float multiplier)
		{
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x317B120", Offset = "0x3179720", VA = "0x18317B120")]
		private void AnimateVATAlpha(GameObject VAT, int alphaNameId, AnimationCurve alphaCurve, float currentTime, ref Material materialInstance, float multiplier)
		{
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x317B4C0", Offset = "0x3179AC0", VA = "0x18317B4C0")]
		private void AnimateDecal(DecalProjector projector, AnimationCurve posXCurve, AnimationCurve decalWidthCurve, AnimationCurve decalHeightCurve, float currentTime)
		{
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x317B760", Offset = "0x3179D60", VA = "0x18317B760")]
		private void SetDecalSize(DecalProjector projector)
		{
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x317B7B0", Offset = "0x3179DB0", VA = "0x18317B7B0")]
		private void AnimateDecalSimple(DecalProjector projector, AnimationCurve posXCurve, float currentTime)
		{
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x317B950", Offset = "0x3179F50", VA = "0x18317B950")]
		private void AnimateVAT(GameObject VAT, AnimationCurve posXCurve, float currentTime)
		{
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x317BAF0", Offset = "0x317A0F0", VA = "0x18317BAF0")]
		private void SetMaterialFloat(int nameId, AnimationCurve animCurve, float currentTime, Material targetMaterial, float multiplier)
		{
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x317BBE0", Offset = "0x317A1E0", VA = "0x18317BBE0")]
		private void SetMaterialFloatScaled(int nameId, AnimationCurve animCurve, float currentTime, Material targetMaterial, float originalValue, float multiplier)
		{
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void SetVATAlpha(AnimationCurve animCurve, float currentTime)
		{
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00002220 File Offset: 0x00000420
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x317BCD0", Offset = "0x317A2D0", VA = "0x18317BCD0")]
		public float RemainingLoopTime()
		{
			return 0f;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x317BD00", Offset = "0x317A300", VA = "0x18317BD00")]
		private void SetDecalWidthHeight(DecalProjector projector, AnimationCurve wetnessDecalBlurredWidth, AnimationCurve wetnessDecalBlurredHeight, float currentTime)
		{
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x317BE10", Offset = "0x317A410", VA = "0x18317BE10")]
		private void SetPosX(Transform targetTransform, Vector3 currentLocalPos, AnimationCurve curveSource, float currentTime)
		{
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x317BF10", Offset = "0x317A510", VA = "0x18317BF10")]
		private void SetPosXY(Transform targetTransform, Vector3 currentLocalPos, AnimationCurve curveSourceX, AnimationCurve curveSourceY, float currentTime)
		{
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x317C080", Offset = "0x317A680", VA = "0x18317C080")]
		private void SetScaleY(Transform targetTransform, Vector3 currentLocalScale, AnimationCurve curveSource, float currentTime)
		{
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x317C190", Offset = "0x317A790", VA = "0x18317C190")]
		public BeachWaveVFX()
		{
		}

		// Token: 0x04000124 RID: 292
		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BeachWaveVFXSettings _beachWaveVFXSettings;

		// Token: 0x04000125 RID: 293
		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _fadeOnTime;

		// Token: 0x04000126 RID: 294
		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private bool _doFadeIn;

		// Token: 0x04000127 RID: 295
		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _fadeCountdown;

		// Token: 0x04000128 RID: 296
		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _fadeValue;

		// Token: 0x04000129 RID: 297
		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private DecalProjector _wetnessDecalBlurredDecalProjector;

		// Token: 0x0400012A RID: 298
		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private DecalProjector _wetnessDecalSharpDecalProjector;

		// Token: 0x0400012B RID: 299
		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<DecalProjector> _foamDecalsProjectors;

		// Token: 0x0400012C RID: 300
		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<GameObject> _foamVATs;

		// Token: 0x0400012D RID: 301
		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _Sounds;

		// Token: 0x0400012E RID: 302
		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _SoundActivationTime;

		// Token: 0x0400012F RID: 303
		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float _SoundDeactivationTime;

		// Token: 0x04000130 RID: 304
		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _WetnessDecalSize;

		// Token: 0x04000131 RID: 305
		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _particles;

		// Token: 0x04000132 RID: 306
		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _displacementGameObject;

		// Token: 0x04000133 RID: 307
		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private int _LodMode;

		// Token: 0x04000134 RID: 308
		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x84")]
		private bool _wetnessBlurredActive;

		// Token: 0x04000135 RID: 309
		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0x85")]
		private bool _wetnessSharpActive;

		// Token: 0x04000136 RID: 310
		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0x88")]
		private int _SplitFrame;

		// Token: 0x04000137 RID: 311
		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private float _wetnessSharpSmoothnessAlpha;

		// Token: 0x04000138 RID: 312
		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private float _wetnessSharpAlpha;

		// Token: 0x04000139 RID: 313
		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		private float _wetnessSharpNormalAlpha;

		// Token: 0x0400013A RID: 314
		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private float _wetnessBlurredSmoothnessAlpha;

		// Token: 0x0400013B RID: 315
		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private float _wetnessBlurredAlpha;

		// Token: 0x0400013C RID: 316
		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private float _wetnessBlurredNormalAlpha;

		// Token: 0x0400013D RID: 317
		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private float _currentTime;

		// Token: 0x0400013E RID: 318
		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0xA8")]
		private bool _ended;

		// Token: 0x0400013F RID: 319
		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0xB0")]
		private List<Material> _foamDecalsMaterialInstances;

		// Token: 0x04000140 RID: 320
		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0xB8")]
		private List<Material> _foamVATsMaterialInstances;

		// Token: 0x04000141 RID: 321
		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0xC0")]
		private Material _wetnessDecalBlurredMaterialInstance;

		// Token: 0x04000142 RID: 322
		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0xC8")]
		private Material _wetnessDecalSharpMaterialInstance;

		// Token: 0x04000143 RID: 323
		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private List<ParticleSystem> _particleSystems;

		// Token: 0x04000144 RID: 324
		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private List<BFX_ManualAnimationUpdate> _VATUpdater;

		// Token: 0x04000145 RID: 325
		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0xE0")]
		private bool _loopStart;

		// Token: 0x04000146 RID: 326
		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int AlphaMultiplierId;

		// Token: 0x04000147 RID: 327
		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int VatAlphaMultiplierId;

		// Token: 0x04000148 RID: 328
		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int _wetnessSmoothnessAlphaMultiplierId;

		// Token: 0x04000149 RID: 329
		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0xC")]
		private static readonly int _wetnessAlphaMultiplierId;

		// Token: 0x0400014A RID: 330
		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int _wetnessNormalAlphaMultiplierId;
	}
}
