using System;
using Endnight.Utilities.Timer;
using Il2CppDummyDll;
using Sons.Multiplayer;
using UnityEngine;

namespace Sons.Gameplay.TreeCutting
{
	// Token: 0x020006DF RID: 1759
	[Token(Token = "0x20006DF")]
	public class FallingTreeTrunkNetworkProxy : BoltEntityBehaviourWrapper<ITreeFallState>
	{
		// Token: 0x06002D01 RID: 11521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D01")]
		[Address(RVA = "0x2E06970", Offset = "0x2E05970", VA = "0x182E06970")]
		private void Update()
		{
		}

		// Token: 0x06002D02 RID: 11522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D02")]
		[Address(RVA = "0x2E06120", Offset = "0x2E05120", VA = "0x182E06120")]
		private void LateUpdate()
		{
		}

		// Token: 0x06002D03 RID: 11523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D03")]
		[Address(RVA = "0x2E06370", Offset = "0x2E05370", VA = "0x182E06370")]
		private void OnValidate()
		{
		}

		// Token: 0x06002D04 RID: 11524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D04")]
		[Address(RVA = "0x2E06240", Offset = "0x2E05240", VA = "0x182E06240")]
		private void OnEnable()
		{
		}

		// Token: 0x06002D05 RID: 11525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D05")]
		[Address(RVA = "0x2E06850", Offset = "0x2E05850", VA = "0x182E06850")]
		private void StripKinematics(Transform tr, Rigidbody targetRigidbody, Joint targetJoint)
		{
		}

		// Token: 0x06002D06 RID: 11526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D06")]
		[Address(RVA = "0x2E05B50", Offset = "0x2E04B50", VA = "0x182E05B50", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x06002D07 RID: 11527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D07")]
		[Address(RVA = "0x2E062C0", Offset = "0x2E052C0", VA = "0x182E062C0")]
		private void OnUniformScaleChanged()
		{
		}

		// Token: 0x06002D08 RID: 11528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D08")]
		[Address(RVA = "0x2E06A60", Offset = "0x2E05A60", VA = "0x182E06A60")]
		private void ValidateData(Transform sectionGameObject, ref Rigidbody sectionRigidbody, ref Joint sectionJoint)
		{
		}

		// Token: 0x06002D09 RID: 11529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D09")]
		[Address(RVA = "0x2E05F80", Offset = "0x2E04F80", VA = "0x182E05F80")]
		public void DeactivatePhysics()
		{
		}

		// Token: 0x06002D0A RID: 11530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D0A")]
		[Address(RVA = "0x2E06B90", Offset = "0x2E05B90", VA = "0x182E06B90")]
		public FallingTreeTrunkNetworkProxy()
		{
		}

		// Token: 0x04002843 RID: 10307
		[Token(Token = "0x4002843")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _selfDestructTimer;

		// Token: 0x04002844 RID: 10308
		[Token(Token = "0x4002844")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _mpCutTopProxy;

		// Token: 0x04002845 RID: 10309
		[Token(Token = "0x4002845")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _sectionA;

		// Token: 0x04002846 RID: 10310
		[Token(Token = "0x4002846")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _sectionB;

		// Token: 0x04002847 RID: 10311
		[Token(Token = "0x4002847")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _sectionC;

		// Token: 0x04002848 RID: 10312
		[Token(Token = "0x4002848")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _sectionD;

		// Token: 0x04002849 RID: 10313
		[Token(Token = "0x4002849")]
		[FieldOffset(Offset = "0x60")]
		private AutoTimer _destroyTimer;

		// Token: 0x0400284A RID: 10314
		[Token(Token = "0x400284A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Rigidbody _sectionARigidbody;

		// Token: 0x0400284B RID: 10315
		[Token(Token = "0x400284B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Rigidbody _sectionBRigidbody;

		// Token: 0x0400284C RID: 10316
		[Token(Token = "0x400284C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Rigidbody _sectionCRigidbody;

		// Token: 0x0400284D RID: 10317
		[Token(Token = "0x400284D")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Rigidbody _sectionDRigidbody;

		// Token: 0x0400284E RID: 10318
		[Token(Token = "0x400284E")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Joint _sectionAJoint;

		// Token: 0x0400284F RID: 10319
		[Token(Token = "0x400284F")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Joint _sectionBJoint;

		// Token: 0x04002850 RID: 10320
		[Token(Token = "0x4002850")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Joint _sectionCJoint;

		// Token: 0x04002851 RID: 10321
		[Token(Token = "0x4002851")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Joint _sectionDJoint;

		// Token: 0x04002852 RID: 10322
		[Token(Token = "0x4002852")]
		[FieldOffset(Offset = "0xA8")]
		private float _uniformScaleFromEntity;
	}
}
