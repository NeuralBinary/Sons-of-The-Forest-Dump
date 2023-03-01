using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai
{
	// Token: 0x020008E8 RID: 2280
	[Token(Token = "0x20008E8")]
	public class ButterflyController : MonoBehaviour
	{
		// Token: 0x1400004D RID: 77
		// (add) Token: 0x06003DEB RID: 15851 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003DEC RID: 15852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400004D")]
		private event Action<ButterflyController, Transform> _finishedCallback
		{
			[Token(Token = "0x6003DEB")]
			[Address(RVA = "0x2F0F8A0", Offset = "0x2F0E8A0", VA = "0x182F0F8A0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003DEC")]
			[Address(RVA = "0x2F0FC60", Offset = "0x2F0EC60", VA = "0x182F0FC60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06003DED RID: 15853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DED")]
		[Address(RVA = "0x2F0FC20", Offset = "0x2F0EC20", VA = "0x182F0FC20")]
		private void OnEnable()
		{
		}

		// Token: 0x06003DEE RID: 15854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DEE")]
		[Address(RVA = "0x2F0F970", Offset = "0x2F0E970", VA = "0x182F0F970")]
		private void OnDisable()
		{
		}

		// Token: 0x06003DEF RID: 15855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DEF")]
		[Address(RVA = "0x2F0F880", Offset = "0x2F0E880", VA = "0x182F0F880")]
		public void ActivateTarget()
		{
		}

		// Token: 0x06003DF0 RID: 15856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DF0")]
		[Address(RVA = "0x2F0F970", Offset = "0x2F0E970", VA = "0x182F0F970")]
		private void Deactivate()
		{
		}

		// Token: 0x06003DF1 RID: 15857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DF1")]
		[Address(RVA = "0x2F10A70", Offset = "0x2F0FA70", VA = "0x182F10A70")]
		private void Update()
		{
		}

		// Token: 0x06003DF2 RID: 15858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DF2")]
		[Address(RVA = "0x2F0FE50", Offset = "0x2F0EE50", VA = "0x182F0FE50")]
		private void UpdateButterfly()
		{
		}

		// Token: 0x06003DF3 RID: 15859 RVA: 0x00012360 File Offset: 0x00010560
		[Token(Token = "0x6003DF3")]
		[Address(RVA = "0x2F0FA80", Offset = "0x2F0EA80", VA = "0x182F0FA80")]
		private bool IsDisturbed()
		{
			return default(bool);
		}

		// Token: 0x06003DF4 RID: 15860 RVA: 0x00012378 File Offset: 0x00010578
		[Token(Token = "0x6003DF4")]
		[Address(RVA = "0x2F10880", Offset = "0x2F0F880", VA = "0x182F10880")]
		private bool UpdateFlyAway(float lifetime)
		{
			return default(bool);
		}

		// Token: 0x06003DF5 RID: 15861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DF5")]
		[Address(RVA = "0x2F0F990", Offset = "0x2F0E990", VA = "0x182F0F990")]
		private void DoDestroy()
		{
		}

		// Token: 0x06003DF6 RID: 15862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DF6")]
		[Address(RVA = "0x2F0FD10", Offset = "0x2F0ED10", VA = "0x182F0FD10")]
		public void SetTarget(Transform newTarget, bool link)
		{
		}

		// Token: 0x06003DF7 RID: 15863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DF7")]
		[Address(RVA = "0x2F0F8A0", Offset = "0x2F0E8A0", VA = "0x182F0F8A0")]
		public void AddFinishedCallback(Action<ButterflyController, Transform> finishedAction)
		{
		}

		// Token: 0x06003DF8 RID: 15864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DF8")]
		[Address(RVA = "0x2F0FC60", Offset = "0x2F0EC60", VA = "0x182F0FC60")]
		public void RemoveFinishedCallback(Action<ButterflyController, Transform> finishedAction)
		{
		}

		// Token: 0x06003DF9 RID: 15865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DF9")]
		[Address(RVA = "0x2F0FD80", Offset = "0x2F0ED80", VA = "0x182F0FD80")]
		public void SetVelocityRoot(Transform velocityRoot)
		{
		}

		// Token: 0x06003DFA RID: 15866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DFA")]
		[Address(RVA = "0x2F0F950", Offset = "0x2F0E950", VA = "0x182F0F950")]
		public void CleanUp()
		{
		}

		// Token: 0x06003DFB RID: 15867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DFB")]
		[Address(RVA = "0x2F10AD0", Offset = "0x2F0FAD0", VA = "0x182F10AD0")]
		public ButterflyController()
		{
		}

		// Token: 0x040041C6 RID: 16838
		[Token(Token = "0x40041C6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _targetTransform;

		// Token: 0x040041C7 RID: 16839
		[Token(Token = "0x40041C7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x040041C8 RID: 16840
		[Token(Token = "0x40041C8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _speed;

		// Token: 0x040041C9 RID: 16841
		[Token(Token = "0x40041C9")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _turnSpeed;

		// Token: 0x040041CA RID: 16842
		[Token(Token = "0x40041CA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _randomSpeed;

		// Token: 0x040041CB RID: 16843
		[Token(Token = "0x40041CB")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _maxLifetime;

		// Token: 0x040041CC RID: 16844
		[Token(Token = "0x40041CC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Vector3 _randomScale;

		// Token: 0x040041CD RID: 16845
		[Token(Token = "0x40041CD")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float _randomScaleMultiplier;

		// Token: 0x040041CE RID: 16846
		[Token(Token = "0x40041CE")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _linkTarget;

		// Token: 0x040041CF RID: 16847
		[Token(Token = "0x40041CF")]
		[FieldOffset(Offset = "0x51")]
		[SerializeField]
		private bool _autoActivate;

		// Token: 0x040041D0 RID: 16848
		[Token(Token = "0x40041D0")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float _disturbSpeed;

		// Token: 0x040041D1 RID: 16849
		[Token(Token = "0x40041D1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _movementDisturbSpeed;

		// Token: 0x040041D2 RID: 16850
		[Token(Token = "0x40041D2")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float _disturbedVerticalStartOffset;

		// Token: 0x040041D3 RID: 16851
		[Token(Token = "0x40041D3")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int Fly;

		// Token: 0x040041D4 RID: 16852
		[Token(Token = "0x40041D4")]
		[FieldOffset(Offset = "0x60")]
		private bool _flyBoolSet;

		// Token: 0x040041D5 RID: 16853
		[Token(Token = "0x40041D5")]
		[FieldOffset(Offset = "0x64")]
		private Vector3 _lastRanOffset;

		// Token: 0x040041D6 RID: 16854
		[Token(Token = "0x40041D6")]
		[FieldOffset(Offset = "0x70")]
		private float _startTime;

		// Token: 0x040041D7 RID: 16855
		[Token(Token = "0x40041D7")]
		[FieldOffset(Offset = "0x74")]
		private bool _doingFlyAway;

		// Token: 0x040041D8 RID: 16856
		[Token(Token = "0x40041D8")]
		[FieldOffset(Offset = "0x78")]
		private Vector3 _flyAwayOffset;

		// Token: 0x040041D9 RID: 16857
		[Token(Token = "0x40041D9")]
		[FieldOffset(Offset = "0x84")]
		private bool _activated;

		// Token: 0x040041DA RID: 16858
		[Token(Token = "0x40041DA")]
		[FieldOffset(Offset = "0x88")]
		private Vector3 _targetTransformPosition;

		// Token: 0x040041DB RID: 16859
		[Token(Token = "0x40041DB")]
		[FieldOffset(Offset = "0x94")]
		private Vector3 _previousTargetPosition;

		// Token: 0x040041DC RID: 16860
		[Token(Token = "0x40041DC")]
		[FieldOffset(Offset = "0xA0")]
		private Quaternion _previousTargetRotation;

		// Token: 0x040041DD RID: 16861
		[Token(Token = "0x40041DD")]
		[FieldOffset(Offset = "0xB0")]
		private Quaternion _targetTransformRotation;

		// Token: 0x040041DE RID: 16862
		[Token(Token = "0x40041DE")]
		[FieldOffset(Offset = "0xC0")]
		private bool _wasDisturbed;

		// Token: 0x040041DF RID: 16863
		[Token(Token = "0x40041DF")]
		[FieldOffset(Offset = "0xC8")]
		private Transform _velocityRoot;

		// Token: 0x040041E0 RID: 16864
		[Token(Token = "0x40041E0")]
		[FieldOffset(Offset = "0xD0")]
		private Vector3 _previousTargetPositionRelative;

		// Token: 0x040041E1 RID: 16865
		[Token(Token = "0x40041E1")]
		[FieldOffset(Offset = "0xDC")]
		private Vector3 _previousVelocityRootPos;
	}
}
