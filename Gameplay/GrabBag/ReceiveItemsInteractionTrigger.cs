using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Sons.Gameplay.GrabBag
{
	// Token: 0x02000703 RID: 1795
	[Token(Token = "0x2000703")]
	[AddComponentMenu("Sons/Gameplay/GrabBag/ReceiveItemsInteractionTrigger")]
	public class ReceiveItemsInteractionTrigger : MonoBehaviour
	{
		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06002EA5 RID: 11941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005CC")]
		public BoltEntity OwnerEntity
		{
			[Token(Token = "0x6002EA5")]
			[Address(RVA = "0x2E380B0", Offset = "0x2E370B0", VA = "0x182E380B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06002EA6 RID: 11942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005CD")]
		public List<GrabBagCategory> ValidGrabBagCategories
		{
			[Token(Token = "0x6002EA6")]
			[Address(RVA = "0x541200", Offset = "0x540200", VA = "0x180541200")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06002EA7 RID: 11943 RVA: 0x0000D440 File Offset: 0x0000B640
		[Token(Token = "0x170005CE")]
		public bool IsActor
		{
			[Token(Token = "0x6002EA7")]
			[Address(RVA = "0x2E38060", Offset = "0x2E37060", VA = "0x182E38060")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002EA8 RID: 11944 RVA: 0x0000D458 File Offset: 0x0000B658
		[Token(Token = "0x6002EA8")]
		[Address(RVA = "0x2E37CC0", Offset = "0x2E36CC0", VA = "0x182E37CC0")]
		public bool TryGetVailActor(out VailActor outVailActor)
		{
			return default(bool);
		}

		// Token: 0x06002EA9 RID: 11945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EA9")]
		[Address(RVA = "0x2E37810", Offset = "0x2E36810", VA = "0x182E37810")]
		public void GrabEnter()
		{
		}

		// Token: 0x06002EAA RID: 11946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EAA")]
		[Address(RVA = "0x2E37A40", Offset = "0x2E36A40", VA = "0x182E37A40")]
		public void GrabExit()
		{
		}

		// Token: 0x06002EAB RID: 11947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EAB")]
		[Address(RVA = "0x21F6BA0", Offset = "0x21F5BA0", VA = "0x1821F6BA0")]
		private void Awake()
		{
		}

		// Token: 0x06002EAC RID: 11948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EAC")]
		[Address(RVA = "0x2E37A80", Offset = "0x2E36A80", VA = "0x182E37A80")]
		private void OnDisable()
		{
		}

		// Token: 0x06002EAD RID: 11949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EAD")]
		[Address(RVA = "0x2E37D30", Offset = "0x2E36D30", VA = "0x182E37D30")]
		private void Update()
		{
		}

		// Token: 0x06002EAE RID: 11950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EAE")]
		[Address(RVA = "0x2E37AC0", Offset = "0x2E36AC0", VA = "0x182E37AC0")]
		private void SetInteractionState(bool enable)
		{
		}

		// Token: 0x06002EAF RID: 11951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EAF")]
		[Address(RVA = "0x2E37AB0", Offset = "0x2E36AB0", VA = "0x182E37AB0")]
		private void OnPerformedAction(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06002EB0 RID: 11952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EB0")]
		[Address(RVA = "0x2E374A0", Offset = "0x2E364A0", VA = "0x182E374A0")]
		public void BeginInteraction()
		{
		}

		// Token: 0x06002EB1 RID: 11953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EB1")]
		[Address(RVA = "0x2E37710", Offset = "0x2E36710", VA = "0x182E37710")]
		private void EndInteraction()
		{
		}

		// Token: 0x06002EB2 RID: 11954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EB2")]
		[Address(RVA = "0x2E37FD0", Offset = "0x2E36FD0", VA = "0x182E37FD0")]
		public ReceiveItemsInteractionTrigger()
		{
		}

		// Token: 0x0400294E RID: 10574
		[Token(Token = "0x400294E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<GrabBagCategory> _validGrabBagCategories;

		// Token: 0x0400294F RID: 10575
		[Token(Token = "0x400294F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _interactionElement;

		// Token: 0x04002950 RID: 10576
		[Token(Token = "0x4002950")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _mustBeFacing;

		// Token: 0x04002951 RID: 10577
		[Token(Token = "0x4002951")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _interactionActivationAngleThreshold;

		// Token: 0x04002952 RID: 10578
		[Token(Token = "0x4002952")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _interactionActivationDistanceThreshold;

		// Token: 0x04002953 RID: 10579
		[Token(Token = "0x4002953")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private BoltEntity _ownerEntiy;

		// Token: 0x04002954 RID: 10580
		[Token(Token = "0x4002954")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool _isLocalPlayer;

		// Token: 0x04002955 RID: 10581
		[Token(Token = "0x4002955")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private VailActor _vailActor;

		// Token: 0x04002956 RID: 10582
		[Token(Token = "0x4002956")]
		[FieldOffset(Offset = "0x58")]
		private bool _isInteractionActive;
	}
}
