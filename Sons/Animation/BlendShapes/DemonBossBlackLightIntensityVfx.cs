using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using UnityEngine;

namespace Sons.Animation.BlendShapes
{
	// Token: 0x02000965 RID: 2405
	[Token(Token = "0x2000965")]
	public class DemonBossBlackLightIntensityVfx : MonoBehaviour
	{
		// Token: 0x060045A8 RID: 17832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045A8")]
		[Address(RVA = "0x3667980", Offset = "0x3665F80", VA = "0x183667980")]
		private void OnEnable()
		{
		}

		// Token: 0x060045A9 RID: 17833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045A9")]
		[Address(RVA = "0x3667A60", Offset = "0x3666060", VA = "0x183667A60")]
		private void Initialize()
		{
		}

		// Token: 0x060045AA RID: 17834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045AA")]
		[Address(RVA = "0x3667D40", Offset = "0x3666340", VA = "0x183667D40")]
		private void OnDisable()
		{
		}

		// Token: 0x060045AB RID: 17835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045AB")]
		[Address(RVA = "0x3667D50", Offset = "0x3666350", VA = "0x183667D50")]
		private void ClearMaterialPropertyBlocks()
		{
		}

		// Token: 0x060045AC RID: 17836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045AC")]
		[Address(RVA = "0x3667F80", Offset = "0x3666580", VA = "0x183667F80")]
		private void Update()
		{
		}

		// Token: 0x060045AD RID: 17837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045AD")]
		[Address(RVA = "0x3668230", Offset = "0x3666830", VA = "0x183668230")]
		private void SetValueToMaterialPropertyBlock(float currentValue)
		{
		}

		// Token: 0x060045AE RID: 17838 RVA: 0x000154F8 File Offset: 0x000136F8
		[Token(Token = "0x60045AE")]
		[Address(RVA = "0x3668490", Offset = "0x3666A90", VA = "0x183668490")]
		private float EvaluateCurve(float currentTime)
		{
			return 0f;
		}

		// Token: 0x060045AF RID: 17839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045AF")]
		[Address(RVA = "0x3668550", Offset = "0x3666B50", VA = "0x183668550")]
		public DemonBossBlackLightIntensityVfx()
		{
		}

		// Token: 0x0400481A RID: 18458
		[Token(Token = "0x400481A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private VailActor _vailActor;

		// Token: 0x0400481B RID: 18459
		[Token(Token = "0x400481B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SkinnedMeshRenderer _skinnedMeshRenderer;

		// Token: 0x0400481C RID: 18460
		[Token(Token = "0x400481C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _minValue;

		// Token: 0x0400481D RID: 18461
		[Token(Token = "0x400481D")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _maxValue;

		// Token: 0x0400481E RID: 18462
		[Token(Token = "0x400481E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AnimationCurve _animationCurve;

		// Token: 0x0400481F RID: 18463
		[Token(Token = "0x400481F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _speed;

		// Token: 0x04004820 RID: 18464
		[Token(Token = "0x4004820")]
		[FieldOffset(Offset = "0x44")]
		private bool _initialized;

		// Token: 0x04004821 RID: 18465
		[Token(Token = "0x4004821")]
		[FieldOffset(Offset = "0x48")]
		private float _currentTime;

		// Token: 0x04004822 RID: 18466
		[Token(Token = "0x4004822")]
		[FieldOffset(Offset = "0x4C")]
		private float _curveStartTime;

		// Token: 0x04004823 RID: 18467
		[Token(Token = "0x4004823")]
		[FieldOffset(Offset = "0x50")]
		private float _curveEndTime;

		// Token: 0x04004824 RID: 18468
		[Token(Token = "0x4004824")]
		[FieldOffset(Offset = "0x54")]
		private float _curveTotalTime;

		// Token: 0x04004825 RID: 18469
		[Token(Token = "0x4004825")]
		[FieldOffset(Offset = "0x58")]
		private List<MaterialPropertyBlock> _materialPropertyBlocks;

		// Token: 0x04004826 RID: 18470
		[Token(Token = "0x4004826")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int BlackLightIntensityKey;
	}
}
