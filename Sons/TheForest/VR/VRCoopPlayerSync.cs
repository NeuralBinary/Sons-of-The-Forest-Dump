using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.VR
{
	// Token: 0x02000399 RID: 921
	[Token(Token = "0x2000399")]
	[ExecuteInEditMode]
	[AddComponentMenu("TheForest/VR/VRCoopPlayerSync")]
	public class VRCoopPlayerSync : EntityBehaviour<IPlayerState>
	{
		// Token: 0x060018A7 RID: 6311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018A7")]
		[Address(RVA = "0x32832C0", Offset = "0x32818C0", VA = "0x1832832C0")]
		private void Start()
		{
		}

		// Token: 0x060018A8 RID: 6312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018A8")]
		[Address(RVA = "0x3283420", Offset = "0x3281A20", VA = "0x183283420", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x060018A9 RID: 6313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018A9")]
		[Address(RVA = "0x3283660", Offset = "0x3281C60", VA = "0x183283660")]
		private void LateUpdate()
		{
		}

		// Token: 0x060018AA RID: 6314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018AA")]
		[Address(RVA = "0x3283C80", Offset = "0x3282280", VA = "0x183283C80")]
		private void UpdateIkRigPosition()
		{
		}

		// Token: 0x060018AB RID: 6315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018AB")]
		[Address(RVA = "0x32842A0", Offset = "0x32828A0", VA = "0x1832842A0")]
		private void UpdateClientRigPosition()
		{
		}

		// Token: 0x060018AC RID: 6316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018AC")]
		[Address(RVA = "0x3284480", Offset = "0x3282A80", VA = "0x183284480")]
		private void UpdateOwnerPositions()
		{
		}

		// Token: 0x060018AD RID: 6317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018AD")]
		[Address(RVA = "0x3284CF0", Offset = "0x32832F0", VA = "0x183284CF0")]
		private void UpdateClientPositions()
		{
		}

		// Token: 0x060018AE RID: 6318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018AE")]
		[Address(RVA = "0x3284FF0", Offset = "0x32835F0", VA = "0x183284FF0")]
		private void UpdateSpineRotation()
		{
		}

		// Token: 0x060018AF RID: 6319 RVA: 0x000079B0 File Offset: 0x00005BB0
		[Token(Token = "0x60018AF")]
		[Address(RVA = "0x3285E90", Offset = "0x3284490", VA = "0x183285E90")]
		private bool DisableTrackingFromMinMovement()
		{
			return default(bool);
		}

		// Token: 0x060018B0 RID: 6320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018B0")]
		[Address(RVA = "0x3286160", Offset = "0x3284760", VA = "0x183286160")]
		public VRCoopPlayerSync()
		{
		}

		// Token: 0x040017C7 RID: 6087
		[Token(Token = "0x40017C7")]
		[FieldOffset(Offset = "0x28")]
		public Animator _animator;

		// Token: 0x040017C8 RID: 6088
		[Token(Token = "0x40017C8")]
		[FieldOffset(Offset = "0x30")]
		public targetStats Stats;

		// Token: 0x040017C9 RID: 6089
		[Token(Token = "0x40017C9")]
		[FieldOffset(Offset = "0x38")]
		public Transform NetHeadJoint;

		// Token: 0x040017CA RID: 6090
		[Token(Token = "0x40017CA")]
		[FieldOffset(Offset = "0x40")]
		public Transform IkRigTransform;

		// Token: 0x040017CB RID: 6091
		[Token(Token = "0x40017CB")]
		[FieldOffset(Offset = "0x48")]
		public Transform IkRigOffsetTransform;

		// Token: 0x040017CC RID: 6092
		[Token(Token = "0x40017CC")]
		[FieldOffset(Offset = "0x50")]
		public Transform IkRigHeadOffsetTransform;

		// Token: 0x040017CD RID: 6093
		[Token(Token = "0x40017CD")]
		[FieldOffset(Offset = "0x58")]
		public Transform RigHead;

		// Token: 0x040017CE RID: 6094
		[Token(Token = "0x40017CE")]
		[FieldOffset(Offset = "0x60")]
		public Transform RigLeftHand;

		// Token: 0x040017CF RID: 6095
		[Token(Token = "0x40017CF")]
		[FieldOffset(Offset = "0x68")]
		public Transform RigRightHand;

		// Token: 0x040017D0 RID: 6096
		[Token(Token = "0x40017D0")]
		[FieldOffset(Offset = "0x70")]
		public Transform TrackedHead;

		// Token: 0x040017D1 RID: 6097
		[Token(Token = "0x40017D1")]
		[FieldOffset(Offset = "0x78")]
		public Transform TrackedLeftHand;

		// Token: 0x040017D2 RID: 6098
		[Token(Token = "0x40017D2")]
		[FieldOffset(Offset = "0x80")]
		public Transform TrackedRightHand;

		// Token: 0x040017D3 RID: 6099
		[Token(Token = "0x40017D3")]
		[FieldOffset(Offset = "0x88")]
		public Transform[] spineBones;

		// Token: 0x040017D4 RID: 6100
		[Token(Token = "0x40017D4")]
		[FieldOffset(Offset = "0x90")]
		private InverseKinematics[] ikSolvers;

		// Token: 0x040017D5 RID: 6101
		[Token(Token = "0x40017D5")]
		[FieldOffset(Offset = "0x98")]
		public ElbowFollow[] elbows;

		// Token: 0x040017D6 RID: 6102
		[Token(Token = "0x40017D6")]
		[FieldOffset(Offset = "0xA0")]
		public restrictLocalIkPosition[] ikLimits;

		// Token: 0x040017D7 RID: 6103
		[Token(Token = "0x40017D7")]
		[FieldOffset(Offset = "0xA8")]
		public float xClampValue;

		// Token: 0x040017D8 RID: 6104
		[Token(Token = "0x40017D8")]
		[FieldOffset(Offset = "0xAC")]
		public float zClampValue;

		// Token: 0x040017D9 RID: 6105
		[Token(Token = "0x40017D9")]
		[FieldOffset(Offset = "0xB0")]
		public float spineBendAmount;

		// Token: 0x040017DA RID: 6106
		[Token(Token = "0x40017DA")]
		[FieldOffset(Offset = "0xB4")]
		public float spineTwistAmount;

		// Token: 0x040017DB RID: 6107
		[Token(Token = "0x40017DB")]
		[FieldOffset(Offset = "0xB8")]
		private Vector3 smoothSpinePosition;

		// Token: 0x040017DC RID: 6108
		[Token(Token = "0x40017DC")]
		[FieldOffset(Offset = "0xC4")]
		private Vector3 velRef;

		// Token: 0x040017DD RID: 6109
		[Token(Token = "0x40017DD")]
		[FieldOffset(Offset = "0xD0")]
		private float smoothTargetAngle;

		// Token: 0x040017DE RID: 6110
		[Token(Token = "0x40017DE")]
		[FieldOffset(Offset = "0xD4")]
		public Vector3 mirrOffset;

		// Token: 0x040017DF RID: 6111
		[Token(Token = "0x40017DF")]
		[FieldOffset(Offset = "0xE0")]
		public Vector3 mirrorMult;

		// Token: 0x040017E0 RID: 6112
		[Token(Token = "0x40017E0")]
		[FieldOffset(Offset = "0xEC")]
		private bool allowArmBlend;

		// Token: 0x040017E1 RID: 6113
		[Token(Token = "0x40017E1")]
		[FieldOffset(Offset = "0xED")]
		private bool allowHeadBlend;

		// Token: 0x040017E2 RID: 6114
		[Token(Token = "0x40017E2")]
		[FieldOffset(Offset = "0xF0")]
		public float blendIkValue;

		// Token: 0x040017E3 RID: 6115
		[Token(Token = "0x40017E3")]
		[FieldOffset(Offset = "0xF4")]
		public float blendHeadValue;

		// Token: 0x040017E4 RID: 6116
		[Token(Token = "0x40017E4")]
		[FieldOffset(Offset = "0xF8")]
		public bool DebugHost;

		// Token: 0x040017E5 RID: 6117
		[Token(Token = "0x40017E5")]
		[FieldOffset(Offset = "0xF9")]
		public bool DebugClient;

		// Token: 0x040017E6 RID: 6118
		[Token(Token = "0x40017E6")]
		[FieldOffset(Offset = "0xFA")]
		public bool NetPlayer;

		// Token: 0x040017E7 RID: 6119
		[Token(Token = "0x40017E7")]
		[FieldOffset(Offset = "0xFC")]
		private float disableTrackingTimer;
	}
}
