using System;
using Il2CppDummyDll;
using Sons.Animation;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.InputSystem;

namespace Sons.Gameplay
{
	// Token: 0x02000816 RID: 2070
	[Token(Token = "0x2000816")]
	public abstract class PlayerGolfCartAction : MonoBehaviour, IKnockDownReceiver, ICutsceneDisconnectReceiver
	{
		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x0600395E RID: 14686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000767")]
		internal GolfCartPlayerState State
		{
			[Token(Token = "0x600395E")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x0600395F RID: 14687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000768")]
		protected ILayerBehaviourActivator[] FullBodyDriverActivators
		{
			[Token(Token = "0x600395F")]
			[Address(RVA = "0x35544D0", Offset = "0x3552AD0", VA = "0x1835544D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x06003960 RID: 14688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000769")]
		protected ILayerBehaviourActivator[] FullBodyPassengerActivators
		{
			[Token(Token = "0x6003960")]
			[Address(RVA = "0x3554720", Offset = "0x3552D20", VA = "0x183554720")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003961 RID: 14689 RVA: 0x00011730 File Offset: 0x0000F930
		[Token(Token = "0x6003961")]
		[Address(RVA = "0x35548C0", Offset = "0x3552EC0", VA = "0x1835548C0")]
		protected bool IsConnectedToGolfCart()
		{
			return default(bool);
		}

		// Token: 0x06003962 RID: 14690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003962")]
		[Address(RVA = "0x35549A0", Offset = "0x3552FA0", VA = "0x1835549A0", Slot = "6")]
		internal virtual void Update()
		{
		}

		// Token: 0x06003963 RID: 14691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003963")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "7")]
		protected virtual void UpdateInput()
		{
		}

		// Token: 0x06003964 RID: 14692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003964")]
		[Address(RVA = "0x26E1890", Offset = "0x26DFE90", VA = "0x1826E1890", Slot = "4")]
		public void OnKnockDownStarted()
		{
		}

		// Token: 0x06003965 RID: 14693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003965")]
		[Address(RVA = "0x35549E0", Offset = "0x3552FE0", VA = "0x1835549E0")]
		public void Initialize(GolfCartController golfCartController, int slotIndex)
		{
		}

		// Token: 0x06003966 RID: 14694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003966")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "8")]
		protected virtual void PostInitialize(GolfCartController golfCartController)
		{
		}

		// Token: 0x06003967 RID: 14695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003967")]
		[Address(RVA = "0x3554DB0", Offset = "0x35533B0", VA = "0x183554DB0")]
		private void InitializeConnectedTransform()
		{
		}

		// Token: 0x06003968 RID: 14696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003968")]
		[Address(RVA = "0x3554E30", Offset = "0x3553430", VA = "0x183554E30")]
		private static void SetAllConstraintsToZero(UnityEngine.Animations.IConstraint sourceConstraint)
		{
		}

		// Token: 0x06003969 RID: 14697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003969")]
		[Address(RVA = "0x3555030", Offset = "0x3553630", VA = "0x183555030")]
		private void SetupInputs()
		{
		}

		// Token: 0x0600396A RID: 14698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600396A")]
		[Address(RVA = "0x35551A0", Offset = "0x35537A0", VA = "0x1835551A0")]
		private void ClearInputs()
		{
		}

		// Token: 0x0600396B RID: 14699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600396B")]
		[Address(RVA = "0x3555310", Offset = "0x3553910", VA = "0x183555310")]
		private void OnDisconnectAction(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x0600396C RID: 14700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600396C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "9")]
		protected virtual void TriggerDisconnect()
		{
		}

		// Token: 0x0600396D RID: 14701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600396D")]
		[Address(RVA = "0x3555530", Offset = "0x3553B30", VA = "0x183555530")]
		public void DisconnectPlayer(GolfCartController golfCartController)
		{
		}

		// Token: 0x0600396E RID: 14702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600396E")]
		[Address(RVA = "0x35559E0", Offset = "0x3553FE0", VA = "0x1835559E0")]
		internal void SetNetworkProxyConnectedTransform(Vector3 position, Quaternion rotation)
		{
		}

		// Token: 0x0600396F RID: 14703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600396F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "10")]
		protected virtual void DisconnectPlayerHook(GolfCartController golfCartController)
		{
		}

		// Token: 0x06003970 RID: 14704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003970")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "11")]
		protected virtual void ConnectIk(GolfCartController golfCartController)
		{
		}

		// Token: 0x06003971 RID: 14705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003971")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "12")]
		protected virtual void DisconnectIk(GolfCartController golfCartController)
		{
		}

		// Token: 0x06003972 RID: 14706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003972")]
		[Address(RVA = "0x26E1890", Offset = "0x26DFE90", VA = "0x1826E1890", Slot = "5")]
		public void OnCutsceneDisconnect()
		{
		}

		// Token: 0x06003973 RID: 14707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003973")]
		[Address(RVA = "0x3555A60", Offset = "0x3554060", VA = "0x183555A60")]
		protected PlayerGolfCartAction()
		{
		}

		// Token: 0x04003146 RID: 12614
		[Token(Token = "0x4003146")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _networkProxyConnectedTransform;

		// Token: 0x04003147 RID: 12615
		[Token(Token = "0x4003147")]
		[FieldOffset(Offset = "0x28")]
		private GolfCartPlayerState _state;

		// Token: 0x04003148 RID: 12616
		[Token(Token = "0x4003148")]
		[FieldOffset(Offset = "0x30")]
		private ILayerBehaviourActivator[] _cachedFullBodyActivators;
	}
}
