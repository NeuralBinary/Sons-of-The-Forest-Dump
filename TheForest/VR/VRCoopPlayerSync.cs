using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.VR
{
	// Token: 0x020003A7 RID: 935
	[Token(Token = "0x20003A7")]
	[AddComponentMenu("TheForest/VR/VRCoopPlayerSync")]
	[ExecuteInEditMode]
	public class VRCoopPlayerSync : EntityBehaviour<IPlayerState>
	{
		// Token: 0x0600186C RID: 6252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600186C")]
		[Address(RVA = "0x2CD59B0", Offset = "0x2CD49B0", VA = "0x182CD59B0")]
		private void Start()
		{
		}

		// Token: 0x0600186D RID: 6253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600186D")]
		[Address(RVA = "0x2CD4FC0", Offset = "0x2CD3FC0", VA = "0x182CD4FC0", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x0600186E RID: 6254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600186E")]
		[Address(RVA = "0x2CD5540", Offset = "0x2CD4540", VA = "0x182CD5540")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600186F RID: 6255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600186F")]
		[Address(RVA = "0x2CD5D50", Offset = "0x2CD4D50", VA = "0x182CD5D50")]
		private void UpdateIkRigPosition()
		{
		}

		// Token: 0x06001870 RID: 6256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001870")]
		[Address(RVA = "0x2CD5C90", Offset = "0x2CD4C90", VA = "0x182CD5C90")]
		private void UpdateClientRigPosition()
		{
		}

		// Token: 0x06001871 RID: 6257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001871")]
		[Address(RVA = "0x2CD60C0", Offset = "0x2CD50C0", VA = "0x182CD60C0")]
		private void UpdateOwnerPositions()
		{
		}

		// Token: 0x06001872 RID: 6258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001872")]
		[Address(RVA = "0x2CD5A60", Offset = "0x2CD4A60", VA = "0x182CD5A60")]
		private void UpdateClientPositions()
		{
		}

		// Token: 0x06001873 RID: 6259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001873")]
		[Address(RVA = "0x2CD64C0", Offset = "0x2CD54C0", VA = "0x182CD64C0")]
		private void UpdateSpineRotation()
		{
		}

		// Token: 0x06001874 RID: 6260 RVA: 0x00007740 File Offset: 0x00005940
		[Token(Token = "0x6001874")]
		[Address(RVA = "0x2CD5130", Offset = "0x2CD4130", VA = "0x182CD5130")]
		private bool DisableTrackingFromMinMovement()
		{
			return default(bool);
		}

		// Token: 0x06001875 RID: 6261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001875")]
		[Address(RVA = "0x2CD6EB0", Offset = "0x2CD5EB0", VA = "0x182CD6EB0")]
		public VRCoopPlayerSync()
		{
		}

		// Token: 0x040017A8 RID: 6056
		[Token(Token = "0x40017A8")]
		[FieldOffset(Offset = "0x28")]
		public Animator _animator;

		// Token: 0x040017A9 RID: 6057
		[Token(Token = "0x40017A9")]
		[FieldOffset(Offset = "0x30")]
		public targetStats Stats;

		// Token: 0x040017AA RID: 6058
		[Token(Token = "0x40017AA")]
		[FieldOffset(Offset = "0x38")]
		public Transform NetHeadJoint;

		// Token: 0x040017AB RID: 6059
		[Token(Token = "0x40017AB")]
		[FieldOffset(Offset = "0x40")]
		public Transform IkRigTransform;

		// Token: 0x040017AC RID: 6060
		[Token(Token = "0x40017AC")]
		[FieldOffset(Offset = "0x48")]
		public Transform IkRigOffsetTransform;

		// Token: 0x040017AD RID: 6061
		[Token(Token = "0x40017AD")]
		[FieldOffset(Offset = "0x50")]
		public Transform IkRigHeadOffsetTransform;

		// Token: 0x040017AE RID: 6062
		[Token(Token = "0x40017AE")]
		[FieldOffset(Offset = "0x58")]
		public Transform RigHead;

		// Token: 0x040017AF RID: 6063
		[Token(Token = "0x40017AF")]
		[FieldOffset(Offset = "0x60")]
		public Transform RigLeftHand;

		// Token: 0x040017B0 RID: 6064
		[Token(Token = "0x40017B0")]
		[FieldOffset(Offset = "0x68")]
		public Transform RigRightHand;

		// Token: 0x040017B1 RID: 6065
		[Token(Token = "0x40017B1")]
		[FieldOffset(Offset = "0x70")]
		public Transform TrackedHead;

		// Token: 0x040017B2 RID: 6066
		[Token(Token = "0x40017B2")]
		[FieldOffset(Offset = "0x78")]
		public Transform TrackedLeftHand;

		// Token: 0x040017B3 RID: 6067
		[Token(Token = "0x40017B3")]
		[FieldOffset(Offset = "0x80")]
		public Transform TrackedRightHand;

		// Token: 0x040017B4 RID: 6068
		[Token(Token = "0x40017B4")]
		[FieldOffset(Offset = "0x88")]
		public Transform[] spineBones;

		// Token: 0x040017B5 RID: 6069
		[Token(Token = "0x40017B5")]
		[FieldOffset(Offset = "0x90")]
		private InverseKinematics[] ikSolvers;

		// Token: 0x040017B6 RID: 6070
		[Token(Token = "0x40017B6")]
		[FieldOffset(Offset = "0x98")]
		public ElbowFollow[] elbows;

		// Token: 0x040017B7 RID: 6071
		[Token(Token = "0x40017B7")]
		[FieldOffset(Offset = "0xA0")]
		public restrictLocalIkPosition[] ikLimits;

		// Token: 0x040017B8 RID: 6072
		[Token(Token = "0x40017B8")]
		[FieldOffset(Offset = "0xA8")]
		public float xClampValue;

		// Token: 0x040017B9 RID: 6073
		[Token(Token = "0x40017B9")]
		[FieldOffset(Offset = "0xAC")]
		public float zClampValue;

		// Token: 0x040017BA RID: 6074
		[Token(Token = "0x40017BA")]
		[FieldOffset(Offset = "0xB0")]
		public float spineBendAmount;

		// Token: 0x040017BB RID: 6075
		[Token(Token = "0x40017BB")]
		[FieldOffset(Offset = "0xB4")]
		public float spineTwistAmount;

		// Token: 0x040017BC RID: 6076
		[Token(Token = "0x40017BC")]
		[FieldOffset(Offset = "0xB8")]
		private Vector3 smoothSpinePosition;

		// Token: 0x040017BD RID: 6077
		[Token(Token = "0x40017BD")]
		[FieldOffset(Offset = "0xC4")]
		private Vector3 velRef;

		// Token: 0x040017BE RID: 6078
		[Token(Token = "0x40017BE")]
		[FieldOffset(Offset = "0xD0")]
		private float smoothTargetAngle;

		// Token: 0x040017BF RID: 6079
		[Token(Token = "0x40017BF")]
		[FieldOffset(Offset = "0xD4")]
		public Vector3 mirrOffset;

		// Token: 0x040017C0 RID: 6080
		[Token(Token = "0x40017C0")]
		[FieldOffset(Offset = "0xE0")]
		public Vector3 mirrorMult;

		// Token: 0x040017C1 RID: 6081
		[Token(Token = "0x40017C1")]
		[FieldOffset(Offset = "0xEC")]
		private bool allowArmBlend;

		// Token: 0x040017C2 RID: 6082
		[Token(Token = "0x40017C2")]
		[FieldOffset(Offset = "0xED")]
		private bool allowHeadBlend;

		// Token: 0x040017C3 RID: 6083
		[Token(Token = "0x40017C3")]
		[FieldOffset(Offset = "0xF0")]
		public float blendIkValue;

		// Token: 0x040017C4 RID: 6084
		[Token(Token = "0x40017C4")]
		[FieldOffset(Offset = "0xF4")]
		public float blendHeadValue;

		// Token: 0x040017C5 RID: 6085
		[Token(Token = "0x40017C5")]
		[FieldOffset(Offset = "0xF8")]
		public bool DebugHost;

		// Token: 0x040017C6 RID: 6086
		[Token(Token = "0x40017C6")]
		[FieldOffset(Offset = "0xF9")]
		public bool DebugClient;

		// Token: 0x040017C7 RID: 6087
		[Token(Token = "0x40017C7")]
		[FieldOffset(Offset = "0xFA")]
		public bool NetPlayer;

		// Token: 0x040017C8 RID: 6088
		[Token(Token = "0x40017C8")]
		[FieldOffset(Offset = "0xFC")]
		private float disableTrackingTimer;
	}
}
