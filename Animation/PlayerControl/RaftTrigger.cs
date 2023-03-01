using System;
using Il2CppDummyDll;
using Sons.Cutscenes;
using Sons.Gameplay;
using Sons.Physics;
using UnityEngine;

namespace Sons.Animation.PlayerControl
{
	// Token: 0x020008DF RID: 2271
	[Token(Token = "0x20008DF")]
	public class RaftTrigger : Cutscene
	{
		// Token: 0x06003DBF RID: 15807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DBF")]
		[Address(RVA = "0x228FFF0", Offset = "0x228EFF0", VA = "0x18228FFF0")]
		public void TriggerPlay()
		{
		}

		// Token: 0x06003DC0 RID: 15808 RVA: 0x000122E8 File Offset: 0x000104E8
		[Token(Token = "0x6003DC0")]
		[Address(RVA = "0x2F24960", Offset = "0x2F23960", VA = "0x182F24960", Slot = "9")]
		public override bool Play()
		{
			return default(bool);
		}

		// Token: 0x06003DC1 RID: 15809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DC1")]
		[Address(RVA = "0x2F246A0", Offset = "0x2F236A0", VA = "0x182F246A0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06003DC2 RID: 15810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DC2")]
		[Address(RVA = "0x2F238D0", Offset = "0x2F228D0", VA = "0x182F238D0")]
		private void ClearWaitingForInput()
		{
		}

		// Token: 0x06003DC3 RID: 15811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DC3")]
		[Address(RVA = "0x2F24990", Offset = "0x2F23990", VA = "0x182F24990")]
		private void SnapPlayerPositionAndRotation()
		{
		}

		// Token: 0x06003DC4 RID: 15812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DC4")]
		[Address(RVA = "0x2F24AB0", Offset = "0x2F23AB0", VA = "0x182F24AB0")]
		private void Update()
		{
		}

		// Token: 0x06003DC5 RID: 15813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DC5")]
		[Address(RVA = "0x2F24190", Offset = "0x2F23190", VA = "0x182F24190")]
		private void FinalizeCutscene()
		{
		}

		// Token: 0x06003DC6 RID: 15814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DC6")]
		[Address(RVA = "0x2F247E0", Offset = "0x2F237E0", VA = "0x182F247E0")]
		private void OnPlayerAnimatorMove()
		{
		}

		// Token: 0x06003DC7 RID: 15815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DC7")]
		[Address(RVA = "0x2F238E0", Offset = "0x2F228E0", VA = "0x182F238E0")]
		private void DoActivateTrigger()
		{
		}

		// Token: 0x06003DC8 RID: 15816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DC8")]
		[Address(RVA = "0x2F23650", Offset = "0x2F22650", VA = "0x182F23650")]
		private void ApplyLayerController()
		{
		}

		// Token: 0x06003DC9 RID: 15817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DC9")]
		[Address(RVA = "0x2F23830", Offset = "0x2F22830", VA = "0x182F23830")]
		private void ClearLayerController()
		{
		}

		// Token: 0x06003DCA RID: 15818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DCA")]
		[Address(RVA = "0x2F24950", Offset = "0x2F23950", VA = "0x182F24950")]
		private void OnRaftMotion(Raft sourceRaft)
		{
		}

		// Token: 0x06003DCB RID: 15819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DCB")]
		[Address(RVA = "0x2F24C00", Offset = "0x2F23C00", VA = "0x182F24C00")]
		public RaftTrigger()
		{
		}

		// Token: 0x0400417B RID: 16763
		[Token(Token = "0x400417B")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Raft _raftTarget;

		// Token: 0x0400417C RID: 16764
		[Token(Token = "0x400417C")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GenericInteraction _interactionObject;

		// Token: 0x0400417D RID: 16765
		[Token(Token = "0x400417D")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Transform _alignTransform;

		// Token: 0x0400417E RID: 16766
		[Token(Token = "0x400417E")]
		[FieldOffset(Offset = "0xC8")]
		private bool _deactivated;

		// Token: 0x0400417F RID: 16767
		[Token(Token = "0x400417F")]
		[FieldOffset(Offset = "0xC9")]
		private bool _constrained;

		// Token: 0x04004180 RID: 16768
		[Token(Token = "0x4004180")]
		[FieldOffset(Offset = "0xCC")]
		[SerializeField]
		private float _fov;

		// Token: 0x04004181 RID: 16769
		[Token(Token = "0x4004181")]
		[FieldOffset(Offset = "0xD0")]
		private float _originalFov;

		// Token: 0x04004182 RID: 16770
		[Token(Token = "0x4004182")]
		[FieldOffset(Offset = "0xD4")]
		private bool _sequenceIsRunning;

		// Token: 0x04004183 RID: 16771
		[Token(Token = "0x4004183")]
		[FieldOffset(Offset = "0xD8")]
		private Vector3 _originalPosition;

		// Token: 0x04004184 RID: 16772
		[Token(Token = "0x4004184")]
		[FieldOffset(Offset = "0xE4")]
		private bool _animationStateEntered;

		// Token: 0x04004185 RID: 16773
		[Token(Token = "0x4004185")]
		[FieldOffset(Offset = "0xE8")]
		private Vector3 _locationOffset;

		// Token: 0x04004186 RID: 16774
		[Token(Token = "0x4004186")]
		[FieldOffset(Offset = "0xF4")]
		private bool _isPlayingState;

		// Token: 0x04004187 RID: 16775
		[Token(Token = "0x4004187")]
		[FieldOffset(Offset = "0xF8")]
		private float _iconDisableTimer;

		// Token: 0x04004188 RID: 16776
		[Token(Token = "0x4004188")]
		[FieldOffset(Offset = "0xFC")]
		private bool _blockIcon;

		// Token: 0x04004189 RID: 16777
		[Token(Token = "0x4004189")]
		[FieldOffset(Offset = "0xFD")]
		private bool _waitingForInput;

		// Token: 0x0400418A RID: 16778
		[Token(Token = "0x400418A")]
		[FieldOffset(Offset = "0x100")]
		private PlayerAnimatorControl _animatorControl;

		// Token: 0x0400418B RID: 16779
		[Token(Token = "0x400418B")]
		[FieldOffset(Offset = "0x108")]
		private bool _appliedLayerController;

		// Token: 0x0400418C RID: 16780
		[Token(Token = "0x400418C")]
		[FieldOffset(Offset = "0x110")]
		private AnimatorLayersController _layersController;

		// Token: 0x0400418D RID: 16781
		[Token(Token = "0x400418D")]
		[FieldOffset(Offset = "0x118")]
		private LayerBehaviourActivator _fullBodyLayerBehaviourActivator;
	}
}
