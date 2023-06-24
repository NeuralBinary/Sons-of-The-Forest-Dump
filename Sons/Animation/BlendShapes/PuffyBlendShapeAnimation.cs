using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Animation.BlendShapes
{
	// Token: 0x02000966 RID: 2406
	[Token(Token = "0x2000966")]
	[Serializable]
	public class PuffyBlendShapeAnimation
	{
		// Token: 0x060045B1 RID: 17841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045B1")]
		[Address(RVA = "0x3668640", Offset = "0x3666C40", VA = "0x183668640")]
		internal void OnValidate(BlendShapeManager manager, SkinnedMeshRenderer meshRender, VailStatsManager statsManager)
		{
		}

		// Token: 0x060045B2 RID: 17842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045B2")]
		[Address(RVA = "0x3668760", Offset = "0x3666D60", VA = "0x183668760")]
		private List<string> GetAllBlendShapeIds()
		{
			return null;
		}

		// Token: 0x060045B3 RID: 17843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045B3")]
		[Address(RVA = "0x3668780", Offset = "0x3666D80", VA = "0x183668780")]
		internal void Update(float strength, float speedMultiplier)
		{
		}

		// Token: 0x060045B4 RID: 17844 RVA: 0x00015510 File Offset: 0x00013710
		[Token(Token = "0x60045B4")]
		[Address(RVA = "0x3668FF0", Offset = "0x36675F0", VA = "0x183668FF0")]
		private float SampleCurve(float time)
		{
			return 0f;
		}

		// Token: 0x060045B5 RID: 17845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045B5")]
		[Address(RVA = "0x3669090", Offset = "0x3667690", VA = "0x183669090")]
		private void UpdateAmbientOcclusion(float eval)
		{
		}

		// Token: 0x060045B6 RID: 17846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045B6")]
		[Address(RVA = "0x36691A0", Offset = "0x36677A0", VA = "0x1836691A0")]
		private void UpdateTextureSampler(float eval)
		{
		}

		// Token: 0x060045B7 RID: 17847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045B7")]
		[Address(RVA = "0x3669300", Offset = "0x3667900", VA = "0x183669300")]
		private void VerifyMaterialInstance()
		{
		}

		// Token: 0x060045B8 RID: 17848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045B8")]
		[Address(RVA = "0x36695F0", Offset = "0x3667BF0", VA = "0x1836695F0")]
		public PuffyBlendShapeAnimation()
		{
		}

		// Token: 0x04004827 RID: 18471
		[Token(Token = "0x4004827")]
		[FieldOffset(Offset = "0x10")]
		[FormerlySerializedAs("_manager")]
		[SerializeField]
		[HideInInspector]
		private BlendShapeManager _blendShapeManager;

		// Token: 0x04004828 RID: 18472
		[Token(Token = "0x4004828")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[HideInInspector]
		private VailStatsManager _statsManager;

		// Token: 0x04004829 RID: 18473
		[Token(Token = "0x4004829")]
		[FieldOffset(Offset = "0x20")]
		[HideInInspector]
		[SerializeField]
		private SkinnedMeshRenderer _skinnedMeshRenderer;

		// Token: 0x0400482A RID: 18474
		[Token(Token = "0x400482A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _applyMaterialChanges;

		// Token: 0x0400482B RID: 18475
		[Token(Token = "0x400482B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		public string _deflateId;

		// Token: 0x0400482C RID: 18476
		[Token(Token = "0x400482C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		public string _inflateId;

		// Token: 0x0400482D RID: 18477
		[Token(Token = "0x400482D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		public float _calmSpeed;

		// Token: 0x0400482E RID: 18478
		[Token(Token = "0x400482E")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		public float _agitatedSpeed;

		// Token: 0x0400482F RID: 18479
		[Token(Token = "0x400482F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		public AnimationCurve _curve;

		// Token: 0x04004830 RID: 18480
		[Token(Token = "0x4004830")]
		[FieldOffset(Offset = "0x50")]
		[FormerlySerializedAs("_curveSampleMin")]
		[SerializeField]
		private float _deflateMultiplier;

		// Token: 0x04004831 RID: 18481
		[Token(Token = "0x4004831")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		[FormerlySerializedAs("_curveSampleMax")]
		private float _inflateMultiplier;

		// Token: 0x04004832 RID: 18482
		[Token(Token = "0x4004832")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		public float _timerOffset;

		// Token: 0x04004833 RID: 18483
		[Token(Token = "0x4004833")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float _phaseSpeed;

		// Token: 0x04004834 RID: 18484
		[Token(Token = "0x4004834")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _phaseMultiplier;

		// Token: 0x04004835 RID: 18485
		[Token(Token = "0x4004835")]
		[FieldOffset(Offset = "0x64")]
		private float _agitatedFactor;

		// Token: 0x04004836 RID: 18486
		[Token(Token = "0x4004836")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _deflateOcclusionValue;

		// Token: 0x04004837 RID: 18487
		[Token(Token = "0x4004837")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float _inflateOcclusionValue;

		// Token: 0x04004838 RID: 18488
		[Token(Token = "0x4004838")]
		[FieldOffset(Offset = "0x70")]
		private Material _targetMaterialInstance;

		// Token: 0x04004839 RID: 18489
		[Token(Token = "0x4004839")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int OcclusionShaderId;

		// Token: 0x0400483A RID: 18490
		[Token(Token = "0x400483A")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int TargetLayerShaderId;

		// Token: 0x0400483B RID: 18491
		[Token(Token = "0x400483B")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int BlendAmountShaderId;

		// Token: 0x0400483C RID: 18492
		[Token(Token = "0x400483C")]
		[FieldOffset(Offset = "0x78")]
		private float _timer;

		// Token: 0x0400483D RID: 18493
		[Token(Token = "0x400483D")]
		[FieldOffset(Offset = "0x7C")]
		private float _lastInflateFactor;

		// Token: 0x0400483E RID: 18494
		[Token(Token = "0x400483E")]
		[FieldOffset(Offset = "0x80")]
		private float _lastDeflateFactor;

		// Token: 0x0400483F RID: 18495
		[Token(Token = "0x400483F")]
		[FieldOffset(Offset = "0x84")]
		private float _animEval;

		// Token: 0x04004840 RID: 18496
		[Token(Token = "0x4004840")]
		[FieldOffset(Offset = "0x88")]
		private int _deflateIntId;

		// Token: 0x04004841 RID: 18497
		[Token(Token = "0x4004841")]
		[FieldOffset(Offset = "0x8C")]
		private int _inflateIntId;

		// Token: 0x04004842 RID: 18498
		[Token(Token = "0x4004842")]
		[FieldOffset(Offset = "0x90")]
		private float _startAnimTime;

		// Token: 0x04004843 RID: 18499
		[Token(Token = "0x4004843")]
		[FieldOffset(Offset = "0x94")]
		private float _endAnimTime;
	}
}
