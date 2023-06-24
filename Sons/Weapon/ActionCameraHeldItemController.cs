using System;
using FMOD.Studio;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Inventory;
using Sons.PlayerActions;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Video;

namespace Sons.Weapon
{
	// Token: 0x0200089D RID: 2205
	[Token(Token = "0x200089D")]
	[AddComponentMenu("Sons/Items/ActionCameraHeldItemController")]
	public class ActionCameraHeldItemController : HeldControllerBase
	{
		// Token: 0x06003EC9 RID: 16073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EC9")]
		[Address(RVA = "0x35D5D90", Offset = "0x35D4390", VA = "0x1835D5D90", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, ItemInstance itemInstance)
		{
		}

		// Token: 0x06003ECA RID: 16074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ECA")]
		[Address(RVA = "0x35D6470", Offset = "0x35D4A70", VA = "0x1835D6470")]
		private void OnStarted(VideoPlayer source)
		{
		}

		// Token: 0x06003ECB RID: 16075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ECB")]
		[Address(RVA = "0x35D6570", Offset = "0x35D4B70", VA = "0x1835D6570")]
		private void OnEndReached(VideoPlayer source)
		{
		}

		// Token: 0x06003ECC RID: 16076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ECC")]
		[Address(RVA = "0x35D6680", Offset = "0x35D4C80", VA = "0x1835D6680")]
		private void Update()
		{
		}

		// Token: 0x06003ECD RID: 16077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ECD")]
		[Address(RVA = "0x35D6D20", Offset = "0x35D5320", VA = "0x1835D6D20")]
		private void OnDisable()
		{
		}

		// Token: 0x06003ECE RID: 16078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ECE")]
		[Address(RVA = "0x35D71B0", Offset = "0x35D57B0", VA = "0x1835D71B0")]
		private void OnChangeVideo(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06003ECF RID: 16079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ECF")]
		[Address(RVA = "0x35D72B0", Offset = "0x35D58B0", VA = "0x1835D72B0")]
		private void PlayClip(PlayerActionCameraAction.ClipData clipData)
		{
		}

		// Token: 0x06003ED0 RID: 16080 RVA: 0x000131B8 File Offset: 0x000113B8
		[Token(Token = "0x6003ED0")]
		[Address(RVA = "0x35D7590", Offset = "0x35D5B90", VA = "0x1835D7590", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06003ED1 RID: 16081 RVA: 0x000131D0 File Offset: 0x000113D0
		[Token(Token = "0x6003ED1")]
		[Address(RVA = "0x35D76B0", Offset = "0x35D5CB0", VA = "0x1835D76B0")]
		private bool ShouldShowCycleUi()
		{
			return default(bool);
		}

		// Token: 0x06003ED2 RID: 16082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ED2")]
		[Address(RVA = "0x35D7850", Offset = "0x35D5E50", VA = "0x1835D7850")]
		public ActionCameraHeldItemController()
		{
		}

		// Token: 0x0400347C RID: 13436
		[Token(Token = "0x400347C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private VideoPlayer _videoPlayer;

		// Token: 0x0400347D RID: 13437
		[Token(Token = "0x400347D")]
		[FieldOffset(Offset = "0x70")]
		private bool _triggerInitialVideo;

		// Token: 0x0400347E RID: 13438
		[Token(Token = "0x400347E")]
		[FieldOffset(Offset = "0x78")]
		private GameObject _offScreen;

		// Token: 0x0400347F RID: 13439
		[Token(Token = "0x400347F")]
		[FieldOffset(Offset = "0x80")]
		private EventInstance _activeAudioEvent;

		// Token: 0x04003480 RID: 13440
		[Token(Token = "0x4003480")]
		[FieldOffset(Offset = "0x88")]
		private PlayerActionCameraAction _playerActionCameraAction;

		// Token: 0x04003481 RID: 13441
		[Token(Token = "0x4003481")]
		[FieldOffset(Offset = "0x90")]
		private PlayerActionCameraAction.ClipData _activeClip;

		// Token: 0x04003482 RID: 13442
		[Token(Token = "0x4003482")]
		[FieldOffset(Offset = "0x98")]
		private bool _isPaused;
	}
}
