using System;
using Il2CppDummyDll;
using Sons.Animation;
using UnityEngine;
using UnityEngine.Serialization;

namespace Construction.Anim
{
	// Token: 0x020002AD RID: 685
	[Token(Token = "0x20002AD")]
	[CreateAssetMenu(menuName = "Sons/Construction/Player Animation Data")]
	public class PlayerAnimationData : ScriptableObject
	{
		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x060014E5 RID: 5349 RVA: 0x0000C0BC File Offset: 0x0000A2BC
		[Token(Token = "0x17000459")]
		public bool IgnoreHeldItemCheck
		{
			[Token(Token = "0x60014E5")]
			[Address(RVA = "0x2DF83C0", Offset = "0x2DF69C0", VA = "0x182DF83C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x060014E6 RID: 5350 RVA: 0x0000C0D4 File Offset: 0x0000A2D4
		[Token(Token = "0x1700045A")]
		public bool SyncWithRemotePlayer
		{
			[Token(Token = "0x60014E6")]
			[Address(RVA = "0x26FA7A0", Offset = "0x26F8DA0", VA = "0x1826FA7A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014E7")]
		[Address(RVA = "0x2DF83D0", Offset = "0x2DF69D0", VA = "0x182DF83D0")]
		private void OnEnable()
		{
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014E8")]
		[Address(RVA = "0x2DF8800", Offset = "0x2DF6E00", VA = "0x182DF8800")]
		public void EnterAnimation(Vector3 worldPos, ConstructionManager manager)
		{
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014E9")]
		[Address(RVA = "0x2DF8C60", Offset = "0x2DF7260", VA = "0x182DF8C60")]
		private void ToggleFullBodyMode(bool isOn, ConstructionManager manager)
		{
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014EA")]
		[Address(RVA = "0x2DF8CB0", Offset = "0x2DF72B0", VA = "0x182DF8CB0")]
		public void ExitAnimation(ConstructionManager manager)
		{
		}

		// Token: 0x060014EB RID: 5355 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014EB")]
		[Address(RVA = "0x2DF8F20", Offset = "0x2DF7520", VA = "0x182DF8F20")]
		public void ExitPromptMode(ConstructionManager manager)
		{
		}

		// Token: 0x060014EC RID: 5356 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014EC")]
		[Address(RVA = "0x2DF90C0", Offset = "0x2DF76C0", VA = "0x182DF90C0")]
		private void SetPromptModeIk(IPlayerBuildingModeAction buildAction, TargetInfo targetInfo)
		{
		}

		// Token: 0x060014ED RID: 5357 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014ED")]
		[Address(RVA = "0x2DF9270", Offset = "0x2DF7870", VA = "0x182DF9270")]
		private void UnsetPromptModeIk(IPlayerBuildingModeAction buildAction)
		{
		}

		// Token: 0x060014EE RID: 5358 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014EE")]
		[Address(RVA = "0x2DF9330", Offset = "0x2DF7930", VA = "0x182DF9330")]
		public void TriggerPlaceAnimation(PlayerBuildingModeAction buildAction, TargetInfo targetInfo, IConstructionModule module, StructureElement elementPrefab)
		{
		}

		// Token: 0x060014EF RID: 5359 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014EF")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		public PlayerAnimationData()
		{
		}

		// Token: 0x04000A1D RID: 2589
		[Token(Token = "0x4000A1D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private PlayerAnimationData.Accessories _accessory;

		// Token: 0x04000A1E RID: 2590
		[Token(Token = "0x4000A1E")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private PlayerAnimationData.AnimatorVar _animatorVar;

		// Token: 0x04000A1F RID: 2591
		[Token(Token = "0x4000A1F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[FormerlySerializedAs("_animatorVarValue")]
		private PlaceElementTypes _placeElementTypeValue;

		// Token: 0x04000A20 RID: 2592
		[Token(Token = "0x4000A20")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private PlayerAnimationData.BuildingChopTypeValues _buildingChopTypeValue;

		// Token: 0x04000A21 RID: 2593
		[Token(Token = "0x4000A21")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _autoAimCloseDistance;

		// Token: 0x04000A22 RID: 2594
		[Token(Token = "0x4000A22")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private PlayerAnimationData.IkTypes _promptModeIk;

		// Token: 0x04000A23 RID: 2595
		[Token(Token = "0x4000A23")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _promptModeIkAllowAimAbove;

		// Token: 0x04000A24 RID: 2596
		[Token(Token = "0x4000A24")]
		[FieldOffset(Offset = "0x34")]
		[Header("Perfect Finish IK")]
		[SerializeField]
		private PerfectFinishIkModes _perfectFinishIk;

		// Token: 0x04000A25 RID: 2597
		[Token(Token = "0x4000A25")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _perfectFinishDelay;

		// Token: 0x04000A26 RID: 2598
		[Token(Token = "0x4000A26")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _perfectFinishSmoothDuration;

		// Token: 0x04000A27 RID: 2599
		[Token(Token = "0x4000A27")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Header("Animation SFX")]
		private AudioClipProfile _sfx1;

		// Token: 0x04000A28 RID: 2600
		[Token(Token = "0x4000A28")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AudioClipProfile _sfx2;

		// Token: 0x04000A29 RID: 2601
		[Token(Token = "0x4000A29")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Header("Anim properties")]
		private bool _fullbodyMode;

		// Token: 0x04000A2A RID: 2602
		[Token(Token = "0x4000A2A")]
		[FieldOffset(Offset = "0x51")]
		[SerializeField]
		private bool _fullbodyCutMode;

		// Token: 0x04000A2B RID: 2603
		[Token(Token = "0x4000A2B")]
		[FieldOffset(Offset = "0x52")]
		[SerializeField]
		private bool _ignoreHeldItemCheck;

		// Token: 0x04000A2C RID: 2604
		[Token(Token = "0x4000A2C")]
		[FieldOffset(Offset = "0x53")]
		[SerializeField]
		private bool _equipLeftHandWhenExitingPromptMode;

		// Token: 0x04000A2D RID: 2605
		[Token(Token = "0x4000A2D")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private bool _syncWithRemotePlayer;

		// Token: 0x04000A2E RID: 2606
		[Token(Token = "0x4000A2E")]
		[FieldOffset(Offset = "0x58")]
		private LayerBehaviourActivator[] _fullbodyLayerBehaviourActivators;

		// Token: 0x04000A2F RID: 2607
		[Token(Token = "0x4000A2F")]
		[FieldOffset(Offset = "0x60")]
		private LayerBehaviourActivator[] _fullbodyLayerBehaviourDisablers;

		// Token: 0x020002AE RID: 686
		[Token(Token = "0x20002AE")]
		public enum AnimatorVar
		{
			// Token: 0x04000A31 RID: 2609
			[Token(Token = "0x4000A31")]
			None,
			// Token: 0x04000A32 RID: 2610
			[Token(Token = "0x4000A32")]
			PlaceElementType,
			// Token: 0x04000A33 RID: 2611
			[Token(Token = "0x4000A33")]
			BuildingChopType
		}

		// Token: 0x020002AF RID: 687
		[Token(Token = "0x20002AF")]
		public enum Accessories
		{
			// Token: 0x04000A35 RID: 2613
			[Token(Token = "0x4000A35")]
			None,
			// Token: 0x04000A36 RID: 2614
			[Token(Token = "0x4000A36")]
			LeftHandAxe
		}

		// Token: 0x020002B0 RID: 688
		[Token(Token = "0x20002B0")]
		public enum BuildingChopTypeValues
		{
			// Token: 0x04000A38 RID: 2616
			[Token(Token = "0x4000A38")]
			None,
			// Token: 0x04000A39 RID: 2617
			[Token(Token = "0x4000A39")]
			CutWindowFirstHit,
			// Token: 0x04000A3A RID: 2618
			[Token(Token = "0x4000A3A")]
			CutWindowSecondHit,
			// Token: 0x04000A3B RID: 2619
			[Token(Token = "0x4000A3B")]
			CutQuarterOnGround,
			// Token: 0x04000A3C RID: 2620
			[Token(Token = "0x4000A3C")]
			CutPilarPrompt,
			// Token: 0x04000A3D RID: 2621
			[Token(Token = "0x4000A3D")]
			CutFloorHolePrompt,
			// Token: 0x04000A3E RID: 2622
			[Token(Token = "0x4000A3E")]
			CutDWPrompt,
			// Token: 0x04000A3F RID: 2623
			[Token(Token = "0x4000A3F")]
			CutDwShelfNotch
		}

		// Token: 0x020002B1 RID: 689
		[Token(Token = "0x20002B1")]
		public enum IkTypes
		{
			// Token: 0x04000A41 RID: 2625
			[Token(Token = "0x4000A41")]
			None,
			// Token: 0x04000A42 RID: 2626
			[Token(Token = "0x4000A42")]
			CutAimIk,
			// Token: 0x04000A43 RID: 2627
			[Token(Token = "0x4000A43")]
			VerticalCutPromptIk,
			// Token: 0x04000A44 RID: 2628
			[Token(Token = "0x4000A44")]
			HorizontalCutPromptIk
		}
	}
}
