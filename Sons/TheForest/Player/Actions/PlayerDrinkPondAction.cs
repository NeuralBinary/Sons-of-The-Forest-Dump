using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.Player.Actions
{
	// Token: 0x0200046C RID: 1132
	[Token(Token = "0x200046C")]
	public class PlayerDrinkPondAction : MonoBehaviour
	{
		// Token: 0x06001D41 RID: 7489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D41")]
		[Address(RVA = "0x32D3990", Offset = "0x32D1F90", VA = "0x1832D3990")]
		private void OnEnable()
		{
		}

		// Token: 0x06001D42 RID: 7490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D42")]
		[Address(RVA = "0x32D3C50", Offset = "0x32D2250", VA = "0x1832D3C50")]
		private void LateUpdate()
		{
		}

		// Token: 0x06001D43 RID: 7491 RVA: 0x00008628 File Offset: 0x00006828
		[Token(Token = "0x6001D43")]
		[Address(RVA = "0x32D4110", Offset = "0x32D2710", VA = "0x1832D4110")]
		private bool FindWithTag(Ray ray)
		{
			return default(bool);
		}

		// Token: 0x06001D44 RID: 7492 RVA: 0x00008640 File Offset: 0x00006840
		[Token(Token = "0x6001D44")]
		[Address(RVA = "0x32D45C0", Offset = "0x32D2BC0", VA = "0x1832D45C0")]
		private bool FindBasicTrigger(Ray ray)
		{
			return default(bool);
		}

		// Token: 0x06001D45 RID: 7493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D45")]
		[Address(RVA = "0x32D4AC0", Offset = "0x32D30C0", VA = "0x1832D4AC0")]
		public void DrinkFrom(InteractableWaterNode interactableWaterNode)
		{
		}

		// Token: 0x06001D46 RID: 7494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D46")]
		[Address(RVA = "0x32D4D10", Offset = "0x32D3310", VA = "0x1832D4D10")]
		private void BeginDrink(Animator animator, PlayerAnimatorControl playerAnimatorControl)
		{
		}

		// Token: 0x06001D47 RID: 7495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D47")]
		[Address(RVA = "0x32D4E80", Offset = "0x32D3480", VA = "0x1832D4E80")]
		private void CancelDrink()
		{
		}

		// Token: 0x06001D48 RID: 7496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D48")]
		[Address(RVA = "0x32D5080", Offset = "0x32D3680", VA = "0x1832D5080")]
		private IEnumerator WaterDrinkWorker(Animator animator, PlayerAnimatorControl playerAnimatorControl)
		{
			return null;
		}

		// Token: 0x06001D49 RID: 7497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D49")]
		[Address(RVA = "0x32D51E0", Offset = "0x32D37E0", VA = "0x1832D51E0")]
		private void DoDrinkEffects()
		{
		}

		// Token: 0x06001D4A RID: 7498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D4A")]
		[Address(RVA = "0x32D5340", Offset = "0x32D3940", VA = "0x1832D5340")]
		private void FinalizeDrink(Animator animator, PlayerAnimatorControl playerAnimatorControl)
		{
		}

		// Token: 0x06001D4B RID: 7499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D4B")]
		[Address(RVA = "0x32D55A0", Offset = "0x32D3BA0", VA = "0x1832D55A0")]
		private void InitializeDrink(Animator animator, PlayerAnimatorControl playerAnimatorControl)
		{
		}

		// Token: 0x06001D4C RID: 7500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D4C")]
		[Address(RVA = "0x32D5930", Offset = "0x32D3F30", VA = "0x1832D5930")]
		public PlayerDrinkPondAction()
		{
		}

		// Token: 0x04001B9B RID: 7067
		[Token(Token = "0x4001B9B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private InteractableWaterNode _drinkNode;

		// Token: 0x04001B9C RID: 7068
		[Token(Token = "0x4001B9C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _lookDownThreshold;

		// Token: 0x04001B9D RID: 7069
		[Token(Token = "0x4001B9D")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _minimumWaterDepth;

		// Token: 0x04001B9E RID: 7070
		[Token(Token = "0x4001B9E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _maxRange;

		// Token: 0x04001B9F RID: 7071
		[Token(Token = "0x4001B9F")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private LayerMask _interactionLayerMask;

		// Token: 0x04001BA0 RID: 7072
		[Token(Token = "0x4001BA0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private LayerMask _waterExcludedInteractionLayerMask;

		// Token: 0x04001BA1 RID: 7073
		[Token(Token = "0x4001BA1")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _drinkDepthRange;

		// Token: 0x04001BA2 RID: 7074
		[Token(Token = "0x4001BA2")]
		[FieldOffset(Offset = "0x40")]
		private InteractableWaterNode _originalNodeInstance;

		// Token: 0x04001BA3 RID: 7075
		[Token(Token = "0x4001BA3")]
		[FieldOffset(Offset = "0x48")]
		private InteractableWaterNode _nodeInstance;

		// Token: 0x04001BA4 RID: 7076
		[Token(Token = "0x4001BA4")]
		[FieldOffset(Offset = "0x50")]
		private Vector3 _rayScreenPosition;

		// Token: 0x04001BA5 RID: 7077
		[Token(Token = "0x4001BA5")]
		[FieldOffset(Offset = "0x5C")]
		private bool _drinkInProgress;

		// Token: 0x04001BA6 RID: 7078
		[Token(Token = "0x4001BA6")]
		private const int TerrainLayerMask = 67108864;

		// Token: 0x04001BA7 RID: 7079
		[Token(Token = "0x4001BA7")]
		private const int BasicTriggerLayerMask = 8;

		// Token: 0x04001BA8 RID: 7080
		[Token(Token = "0x4001BA8")]
		private const int WaterLayer = 4;

		// Token: 0x04001BA9 RID: 7081
		[Token(Token = "0x4001BA9")]
		private const string WaterTag = "Water";
	}
}
