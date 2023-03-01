using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Animation.BlendShapes
{
	// Token: 0x020008E5 RID: 2277
	[Token(Token = "0x20008E5")]
	[Serializable]
	public class PuffyBlendShapeAnimation
	{
		// Token: 0x06003DDD RID: 15837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DDD")]
		[Address(RVA = "0x2F22510", Offset = "0x2F21510", VA = "0x182F22510")]
		internal void OnValidate(BlendShapeManager manager, SkinnedMeshRenderer meshRender, VailStatsManager statsManager)
		{
		}

		// Token: 0x06003DDE RID: 15838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DDE")]
		[Address(RVA = "0x2F224F0", Offset = "0x2F214F0", VA = "0x182F224F0")]
		private List<string> GetAllBlendShapeIds()
		{
			return null;
		}

		// Token: 0x06003DDF RID: 15839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DDF")]
		[Address(RVA = "0x2F22750", Offset = "0x2F21750", VA = "0x182F22750")]
		internal void Update(float strength, float speedMultiplier)
		{
		}

		// Token: 0x06003DE0 RID: 15840 RVA: 0x00012330 File Offset: 0x00010530
		[Token(Token = "0x6003DE0")]
		[Address(RVA = "0x2F22570", Offset = "0x2F21570", VA = "0x182F22570")]
		private float SampleCurve(float time)
		{
			return default(float);
		}

		// Token: 0x06003DE1 RID: 15841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DE1")]
		[Address(RVA = "0x2F225B0", Offset = "0x2F215B0", VA = "0x182F225B0")]
		private void UpdateAmbientOcclusion(float eval)
		{
		}

		// Token: 0x06003DE2 RID: 15842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DE2")]
		[Address(RVA = "0x2F22670", Offset = "0x2F21670", VA = "0x182F22670")]
		private void UpdateTextureSampler(float eval)
		{
		}

		// Token: 0x06003DE3 RID: 15843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DE3")]
		[Address(RVA = "0x2F22ED0", Offset = "0x2F21ED0", VA = "0x182F22ED0")]
		private void VerifyMaterialInstance()
		{
		}

		// Token: 0x06003DE4 RID: 15844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DE4")]
		[Address(RVA = "0x2F230C0", Offset = "0x2F220C0", VA = "0x182F230C0")]
		public PuffyBlendShapeAnimation()
		{
		}

		// Token: 0x040041A0 RID: 16800
		[Token(Token = "0x40041A0")]
		[FieldOffset(Offset = "0x10")]
		[HideInInspector]
		[SerializeField]
		[FormerlySerializedAs("_manager")]
		private BlendShapeManager _blendShapeManager;

		// Token: 0x040041A1 RID: 16801
		[Token(Token = "0x40041A1")]
		[FieldOffset(Offset = "0x18")]
		[HideInInspector]
		[SerializeField]
		private VailStatsManager _statsManager;

		// Token: 0x040041A2 RID: 16802
		[Token(Token = "0x40041A2")]
		[FieldOffset(Offset = "0x20")]
		[HideInInspector]
		[SerializeField]
		private SkinnedMeshRenderer _skinnedMeshRenderer;

		// Token: 0x040041A3 RID: 16803
		[Token(Token = "0x40041A3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _applyMaterialChanges;

		// Token: 0x040041A4 RID: 16804
		[Token(Token = "0x40041A4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		public string _deflateId;

		// Token: 0x040041A5 RID: 16805
		[Token(Token = "0x40041A5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		public string _inflateId;

		// Token: 0x040041A6 RID: 16806
		[Token(Token = "0x40041A6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		public float _calmSpeed;

		// Token: 0x040041A7 RID: 16807
		[Token(Token = "0x40041A7")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		public float _agitatedSpeed;

		// Token: 0x040041A8 RID: 16808
		[Token(Token = "0x40041A8")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		public AnimationCurve _curve;

		// Token: 0x040041A9 RID: 16809
		[Token(Token = "0x40041A9")]
		[FieldOffset(Offset = "0x50")]
		[FormerlySerializedAs("_curveSampleMin")]
		[SerializeField]
		private float _deflateMultiplier;

		// Token: 0x040041AA RID: 16810
		[Token(Token = "0x40041AA")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		[FormerlySerializedAs("_curveSampleMax")]
		private float _inflateMultiplier;

		// Token: 0x040041AB RID: 16811
		[Token(Token = "0x40041AB")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		public float _timerOffset;

		// Token: 0x040041AC RID: 16812
		[Token(Token = "0x40041AC")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float _phaseSpeed;

		// Token: 0x040041AD RID: 16813
		[Token(Token = "0x40041AD")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _phaseMultiplier;

		// Token: 0x040041AE RID: 16814
		[Token(Token = "0x40041AE")]
		[FieldOffset(Offset = "0x64")]
		private float _agitatedFactor;

		// Token: 0x040041AF RID: 16815
		[Token(Token = "0x40041AF")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _deflateOcclusionValue;

		// Token: 0x040041B0 RID: 16816
		[Token(Token = "0x40041B0")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float _inflateOcclusionValue;

		// Token: 0x040041B1 RID: 16817
		[Token(Token = "0x40041B1")]
		[FieldOffset(Offset = "0x70")]
		private Material _targetMaterialInstance;

		// Token: 0x040041B2 RID: 16818
		[Token(Token = "0x40041B2")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int OcclusionShaderId;

		// Token: 0x040041B3 RID: 16819
		[Token(Token = "0x40041B3")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int TargetLayerShaderId;

		// Token: 0x040041B4 RID: 16820
		[Token(Token = "0x40041B4")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int BlendAmountShaderId;

		// Token: 0x040041B5 RID: 16821
		[Token(Token = "0x40041B5")]
		[FieldOffset(Offset = "0x78")]
		private float _timer;

		// Token: 0x040041B6 RID: 16822
		[Token(Token = "0x40041B6")]
		[FieldOffset(Offset = "0x7C")]
		private float _lastInflateFactor;

		// Token: 0x040041B7 RID: 16823
		[Token(Token = "0x40041B7")]
		[FieldOffset(Offset = "0x80")]
		private float _lastDeflateFactor;

		// Token: 0x040041B8 RID: 16824
		[Token(Token = "0x40041B8")]
		[FieldOffset(Offset = "0x84")]
		private float _animEval;

		// Token: 0x040041B9 RID: 16825
		[Token(Token = "0x40041B9")]
		[FieldOffset(Offset = "0x88")]
		private int _deflateIntId;

		// Token: 0x040041BA RID: 16826
		[Token(Token = "0x40041BA")]
		[FieldOffset(Offset = "0x8C")]
		private int _inflateIntId;

		// Token: 0x040041BB RID: 16827
		[Token(Token = "0x40041BB")]
		[FieldOffset(Offset = "0x90")]
		private float _startAnimTime;

		// Token: 0x040041BC RID: 16828
		[Token(Token = "0x40041BC")]
		[FieldOffset(Offset = "0x94")]
		private float _endAnimTime;
	}
}
