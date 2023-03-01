using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.Player.Actions
{
	// Token: 0x0200047A RID: 1146
	[Token(Token = "0x200047A")]
	public class PlayerDrinkPondAction : MonoBehaviour
	{
		// Token: 0x06001D01 RID: 7425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D01")]
		[Address(RVA = "0x2CFCBE0", Offset = "0x2CFBBE0", VA = "0x182CFCBE0")]
		private void OnEnable()
		{
		}

		// Token: 0x06001D02 RID: 7426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D02")]
		[Address(RVA = "0x2CFC8A0", Offset = "0x2CFB8A0", VA = "0x182CFC8A0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06001D03 RID: 7427 RVA: 0x000083A0 File Offset: 0x000065A0
		[Token(Token = "0x6001D03")]
		[Address(RVA = "0x2CFC260", Offset = "0x2CFB260", VA = "0x182CFC260")]
		private bool FindWithTag(Ray ray)
		{
			return default(bool);
		}

		// Token: 0x06001D04 RID: 7428 RVA: 0x000083B8 File Offset: 0x000065B8
		[Token(Token = "0x6001D04")]
		[Address(RVA = "0x2CFBE60", Offset = "0x2CFAE60", VA = "0x182CFBE60")]
		private bool FindBasicTrigger(Ray ray)
		{
			return default(bool);
		}

		// Token: 0x06001D05 RID: 7429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D05")]
		[Address(RVA = "0x2CFBBB0", Offset = "0x2CFABB0", VA = "0x182CFBBB0")]
		public void DrinkFrom(InteractableWaterNode interactableWaterNode)
		{
		}

		// Token: 0x06001D06 RID: 7430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D06")]
		[Address(RVA = "0x2CFBA60", Offset = "0x2CFAA60", VA = "0x182CFBA60")]
		private void BeginDrink(Animator animator, PlayerAnimatorControl playerAnimatorControl)
		{
		}

		// Token: 0x06001D07 RID: 7431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D07")]
		[Address(RVA = "0x2CFCCD0", Offset = "0x2CFBCD0", VA = "0x182CFCCD0")]
		private IEnumerator WaterDrinkWorker(Animator animator, PlayerAnimatorControl playerAnimatorControl)
		{
			return null;
		}

		// Token: 0x06001D08 RID: 7432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D08")]
		[Address(RVA = "0x2CFBB10", Offset = "0x2CFAB10", VA = "0x182CFBB10")]
		private void DoDrinkEffects()
		{
		}

		// Token: 0x06001D09 RID: 7433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D09")]
		[Address(RVA = "0x2CFBCD0", Offset = "0x2CFACD0", VA = "0x182CFBCD0")]
		private void FinalizeDrink(Animator animator, PlayerAnimatorControl playerAnimatorControl)
		{
		}

		// Token: 0x06001D0A RID: 7434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D0A")]
		[Address(RVA = "0x2CFC620", Offset = "0x2CFB620", VA = "0x182CFC620")]
		private void InitializeDrink(Animator animator, PlayerAnimatorControl playerAnimatorControl)
		{
		}

		// Token: 0x06001D0B RID: 7435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D0B")]
		[Address(RVA = "0x2CFCD70", Offset = "0x2CFBD70", VA = "0x182CFCD70")]
		public PlayerDrinkPondAction()
		{
		}

		// Token: 0x04001B75 RID: 7029
		[Token(Token = "0x4001B75")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private InteractableWaterNode _drinkNode;

		// Token: 0x04001B76 RID: 7030
		[Token(Token = "0x4001B76")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _lookDownThreshold;

		// Token: 0x04001B77 RID: 7031
		[Token(Token = "0x4001B77")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _minimumWaterDepth;

		// Token: 0x04001B78 RID: 7032
		[Token(Token = "0x4001B78")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _maxRange;

		// Token: 0x04001B79 RID: 7033
		[Token(Token = "0x4001B79")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private LayerMask _interactionLayerMask;

		// Token: 0x04001B7A RID: 7034
		[Token(Token = "0x4001B7A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private LayerMask _waterExcludedInteractionLayerMask;

		// Token: 0x04001B7B RID: 7035
		[Token(Token = "0x4001B7B")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _drinkDepthRange;

		// Token: 0x04001B7C RID: 7036
		[Token(Token = "0x4001B7C")]
		[FieldOffset(Offset = "0x40")]
		private InteractableWaterNode _originalNodeInstance;

		// Token: 0x04001B7D RID: 7037
		[Token(Token = "0x4001B7D")]
		[FieldOffset(Offset = "0x48")]
		private InteractableWaterNode _nodeInstance;

		// Token: 0x04001B7E RID: 7038
		[Token(Token = "0x4001B7E")]
		[FieldOffset(Offset = "0x50")]
		private Vector3 _rayScreenPosition;

		// Token: 0x04001B7F RID: 7039
		[Token(Token = "0x4001B7F")]
		private const int TerrainLayerMask = 67108864;

		// Token: 0x04001B80 RID: 7040
		[Token(Token = "0x4001B80")]
		private const int BasicTriggerLayerMask = 8;

		// Token: 0x04001B81 RID: 7041
		[Token(Token = "0x4001B81")]
		private const int WaterLayer = 4;

		// Token: 0x04001B82 RID: 7042
		[Token(Token = "0x4001B82")]
		private const string WaterTag = "Water";
	}
}
