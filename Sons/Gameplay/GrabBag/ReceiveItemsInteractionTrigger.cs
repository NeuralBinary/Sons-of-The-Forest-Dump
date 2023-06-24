using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Sons.Gameplay.GrabBag
{
	// Token: 0x02000851 RID: 2129
	[Token(Token = "0x2000851")]
	[AddComponentMenu("Sons/Gameplay/GrabBag/ReceiveItemsInteractionTrigger")]
	public class ReceiveItemsInteractionTrigger : MonoBehaviour
	{
		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x06003C9D RID: 15517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007CF")]
		public BoltEntity OwnerEntity
		{
			[Token(Token = "0x6003C9D")]
			[Address(RVA = "0x35AA3E0", Offset = "0x35A89E0", VA = "0x1835AA3E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x06003C9E RID: 15518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007D0")]
		public List<GrabBagCategory> ValidGrabBagCategories
		{
			[Token(Token = "0x6003C9E")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x06003C9F RID: 15519 RVA: 0x000126F0 File Offset: 0x000108F0
		[Token(Token = "0x170007D1")]
		public bool IsActor
		{
			[Token(Token = "0x6003C9F")]
			[Address(RVA = "0x35AA480", Offset = "0x35A8A80", VA = "0x1835AA480")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003CA0 RID: 15520 RVA: 0x00012708 File Offset: 0x00010908
		[Token(Token = "0x6003CA0")]
		[Address(RVA = "0x35AA540", Offset = "0x35A8B40", VA = "0x1835AA540")]
		public bool TryGetVailActor(out VailActor outVailActor)
		{
			return default(bool);
		}

		// Token: 0x06003CA1 RID: 15521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CA1")]
		[Address(RVA = "0x35AA660", Offset = "0x35A8C60", VA = "0x1835AA660")]
		public void GrabEnter()
		{
		}

		// Token: 0x06003CA2 RID: 15522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CA2")]
		[Address(RVA = "0x35AA840", Offset = "0x35A8E40", VA = "0x1835AA840")]
		public void GrabExit()
		{
		}

		// Token: 0x06003CA3 RID: 15523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CA3")]
		[Address(RVA = "0x2612770", Offset = "0x2610D70", VA = "0x182612770")]
		private void Awake()
		{
		}

		// Token: 0x06003CA4 RID: 15524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CA4")]
		[Address(RVA = "0x35AA860", Offset = "0x35A8E60", VA = "0x1835AA860")]
		private void OnDisable()
		{
		}

		// Token: 0x06003CA5 RID: 15525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CA5")]
		[Address(RVA = "0x35AA870", Offset = "0x35A8E70", VA = "0x1835AA870")]
		private void Update()
		{
		}

		// Token: 0x06003CA6 RID: 15526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CA6")]
		[Address(RVA = "0x35AABE0", Offset = "0x35A91E0", VA = "0x1835AABE0")]
		private void SetInteractionState(bool enable)
		{
		}

		// Token: 0x06003CA7 RID: 15527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CA7")]
		[Address(RVA = "0x35AAF30", Offset = "0x35A9530", VA = "0x1835AAF30")]
		private void OnPerformedAction(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06003CA8 RID: 15528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CA8")]
		[Address(RVA = "0x35AAF40", Offset = "0x35A9540", VA = "0x1835AAF40")]
		public void BeginInteraction()
		{
		}

		// Token: 0x06003CA9 RID: 15529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CA9")]
		[Address(RVA = "0x35AB280", Offset = "0x35A9880", VA = "0x1835AB280")]
		private void EndInteraction()
		{
		}

		// Token: 0x06003CAA RID: 15530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CAA")]
		[Address(RVA = "0x35AB4F0", Offset = "0x35A9AF0", VA = "0x1835AB4F0")]
		public ReceiveItemsInteractionTrigger()
		{
		}

		// Token: 0x04003335 RID: 13109
		[Token(Token = "0x4003335")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<GrabBagCategory> _validGrabBagCategories;

		// Token: 0x04003336 RID: 13110
		[Token(Token = "0x4003336")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _interactionElement;

		// Token: 0x04003337 RID: 13111
		[Token(Token = "0x4003337")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _mustBeFacing;

		// Token: 0x04003338 RID: 13112
		[Token(Token = "0x4003338")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _interactionActivationAngleThreshold;

		// Token: 0x04003339 RID: 13113
		[Token(Token = "0x4003339")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _interactionActivationDistanceThreshold;

		// Token: 0x0400333A RID: 13114
		[Token(Token = "0x400333A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private BoltEntity _ownerEntiy;

		// Token: 0x0400333B RID: 13115
		[Token(Token = "0x400333B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool _isLocalPlayer;

		// Token: 0x0400333C RID: 13116
		[Token(Token = "0x400333C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private VailActor _vailActor;

		// Token: 0x0400333D RID: 13117
		[Token(Token = "0x400333D")]
		[FieldOffset(Offset = "0x58")]
		private bool _isInteractionActive;
	}
}
