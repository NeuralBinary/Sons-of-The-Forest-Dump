using System;
using Il2CppDummyDll;
using Sons.Animation;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x0200087F RID: 2175
	[Token(Token = "0x200087F")]
	[AddComponentMenu("Sons/Items/WalkieTalkieController")]
	public class WalkieTalkieController : HeldControllerBase
	{
		// Token: 0x06003A3C RID: 14908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A3C")]
		[Address(RVA = "0x2F0D5E0", Offset = "0x2F0C5E0", VA = "0x182F0D5E0")]
		private void Update()
		{
		}

		// Token: 0x06003A3D RID: 14909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A3D")]
		[Address(RVA = "0x2F0D520", Offset = "0x2F0C520", VA = "0x182F0D520", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06003A3E RID: 14910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A3E")]
		[Address(RVA = "0x2F0D230", Offset = "0x2F0C230", VA = "0x182F0D230", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, int itemId)
		{
		}

		// Token: 0x06003A3F RID: 14911 RVA: 0x000110E8 File Offset: 0x0000F2E8
		[Token(Token = "0x6003A3F")]
		[Address(RVA = "0x2F0D3F0", Offset = "0x2F0C3F0", VA = "0x182F0D3F0", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06003A40 RID: 14912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A40")]
		[Address(RVA = "0x2D93B10", Offset = "0x2D92B10", VA = "0x182D93B10")]
		public WalkieTalkieController()
		{
		}

		// Token: 0x04003157 RID: 12631
		[Token(Token = "0x4003157")]
		[FieldOffset(Offset = "0x70")]
		private AnimatorLayersController _layersController;

		// Token: 0x04003158 RID: 12632
		[Token(Token = "0x4003158")]
		[FieldOffset(Offset = "0x78")]
		private LayerBehaviourActivator _leftArmLayerBehaviourActivator;
	}
}
