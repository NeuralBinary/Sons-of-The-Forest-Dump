using System;
using Il2CppDummyDll;
using Sons.Cutscenes;
using Sons.Gameplay;
using Sons.Physics;
using UnityEngine;

namespace Sons.Animation.PlayerControl
{
	// Token: 0x02000960 RID: 2400
	[Token(Token = "0x2000960")]
	public class RaftTrigger : Cutscene
	{
		// Token: 0x06004591 RID: 17809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004591")]
		[Address(RVA = "0x26E1890", Offset = "0x26DFE90", VA = "0x1826E1890")]
		public void TriggerPlay()
		{
		}

		// Token: 0x06004592 RID: 17810 RVA: 0x000154C8 File Offset: 0x000136C8
		[Token(Token = "0x6004592")]
		[Address(RVA = "0x3664F50", Offset = "0x3663550", VA = "0x183664F50", Slot = "9")]
		public override bool Play()
		{
			return default(bool);
		}

		// Token: 0x06004593 RID: 17811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004593")]
		[Address(RVA = "0x3664F80", Offset = "0x3663580", VA = "0x183664F80")]
		private void LateUpdate()
		{
		}

		// Token: 0x06004594 RID: 17812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004594")]
		[Address(RVA = "0x3665160", Offset = "0x3663760", VA = "0x183665160")]
		private void ClearWaitingForInput()
		{
		}

		// Token: 0x06004595 RID: 17813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004595")]
		[Address(RVA = "0x3665170", Offset = "0x3663770", VA = "0x183665170")]
		private void SnapPlayerPositionAndRotation()
		{
		}

		// Token: 0x06004596 RID: 17814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004596")]
		[Address(RVA = "0x3665350", Offset = "0x3663950", VA = "0x183665350")]
		private void Update()
		{
		}

		// Token: 0x06004597 RID: 17815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004597")]
		[Address(RVA = "0x36654D0", Offset = "0x3663AD0", VA = "0x1836654D0")]
		private void FinalizeCutscene()
		{
		}

		// Token: 0x06004598 RID: 17816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004598")]
		[Address(RVA = "0x3665C00", Offset = "0x3664200", VA = "0x183665C00")]
		private void OnPlayerAnimatorMove()
		{
		}

		// Token: 0x06004599 RID: 17817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004599")]
		[Address(RVA = "0x3665E30", Offset = "0x3664430", VA = "0x183665E30")]
		private void DoActivateTrigger()
		{
		}

		// Token: 0x0600459A RID: 17818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600459A")]
		[Address(RVA = "0x36668D0", Offset = "0x3664ED0", VA = "0x1836668D0")]
		private void ApplyLayerController()
		{
		}

		// Token: 0x0600459B RID: 17819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600459B")]
		[Address(RVA = "0x3666C40", Offset = "0x3665240", VA = "0x183666C40")]
		private void ClearLayerController()
		{
		}

		// Token: 0x0600459C RID: 17820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600459C")]
		[Address(RVA = "0x3666D40", Offset = "0x3665340", VA = "0x183666D40")]
		private void OnRaftMotion(Raft sourceRaft)
		{
		}

		// Token: 0x0600459D RID: 17821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600459D")]
		[Address(RVA = "0x3666D50", Offset = "0x3665350", VA = "0x183666D50")]
		public RaftTrigger()
		{
		}

		// Token: 0x040047F7 RID: 18423
		[Token(Token = "0x40047F7")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Raft _raftTarget;

		// Token: 0x040047F8 RID: 18424
		[Token(Token = "0x40047F8")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GenericInteraction _interactionObject;

		// Token: 0x040047F9 RID: 18425
		[Token(Token = "0x40047F9")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Transform _alignTransform;

		// Token: 0x040047FA RID: 18426
		[Token(Token = "0x40047FA")]
		[FieldOffset(Offset = "0xC8")]
		private bool _deactivated;

		// Token: 0x040047FB RID: 18427
		[Token(Token = "0x40047FB")]
		[FieldOffset(Offset = "0xC9")]
		private bool _constrained;

		// Token: 0x040047FC RID: 18428
		[Token(Token = "0x40047FC")]
		[FieldOffset(Offset = "0xCC")]
		[SerializeField]
		private float _fov;

		// Token: 0x040047FD RID: 18429
		[Token(Token = "0x40047FD")]
		[FieldOffset(Offset = "0xD0")]
		private float _originalFov;

		// Token: 0x040047FE RID: 18430
		[Token(Token = "0x40047FE")]
		[FieldOffset(Offset = "0xD4")]
		private bool _sequenceIsRunning;

		// Token: 0x040047FF RID: 18431
		[Token(Token = "0x40047FF")]
		[FieldOffset(Offset = "0xD8")]
		private Vector3 _originalPosition;

		// Token: 0x04004800 RID: 18432
		[Token(Token = "0x4004800")]
		[FieldOffset(Offset = "0xE4")]
		private bool _animationStateEntered;

		// Token: 0x04004801 RID: 18433
		[Token(Token = "0x4004801")]
		[FieldOffset(Offset = "0xE8")]
		private Vector3 _locationOffset;

		// Token: 0x04004802 RID: 18434
		[Token(Token = "0x4004802")]
		[FieldOffset(Offset = "0xF4")]
		private bool _isPlayingState;

		// Token: 0x04004803 RID: 18435
		[Token(Token = "0x4004803")]
		[FieldOffset(Offset = "0xF8")]
		private float _iconDisableTimer;

		// Token: 0x04004804 RID: 18436
		[Token(Token = "0x4004804")]
		[FieldOffset(Offset = "0xFC")]
		private bool _blockIcon;

		// Token: 0x04004805 RID: 18437
		[Token(Token = "0x4004805")]
		[FieldOffset(Offset = "0xFD")]
		private bool _waitingForInput;

		// Token: 0x04004806 RID: 18438
		[Token(Token = "0x4004806")]
		[FieldOffset(Offset = "0x100")]
		private PlayerAnimatorControl _animatorControl;

		// Token: 0x04004807 RID: 18439
		[Token(Token = "0x4004807")]
		[FieldOffset(Offset = "0x108")]
		private bool _appliedLayerController;

		// Token: 0x04004808 RID: 18440
		[Token(Token = "0x4004808")]
		[FieldOffset(Offset = "0x110")]
		private AnimatorLayersController _layersController;

		// Token: 0x04004809 RID: 18441
		[Token(Token = "0x4004809")]
		[FieldOffset(Offset = "0x118")]
		private LayerBehaviourActivator _fullBodyLayerBehaviourActivator;
	}
}
