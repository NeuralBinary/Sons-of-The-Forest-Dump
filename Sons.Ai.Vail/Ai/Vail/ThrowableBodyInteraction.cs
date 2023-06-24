using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x02000075 RID: 117
	[Token(Token = "0x2000075")]
	[AddComponentMenu("Sons/Ai/Interact/Throwable Body Interaction")]
	public class ThrowableBodyInteraction : VailPhysicsInteraction, IVailActorInteract
	{
		// Token: 0x06000545 RID: 1349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000545")]
		[Address(RVA = "0x2B272C0", Offset = "0x2B258C0", VA = "0x182B272C0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00004770 File Offset: 0x00002970
		[Token(Token = "0x6000546")]
		[Address(RVA = "0x2B27600", Offset = "0x2B25C00", VA = "0x182B27600")]
		public bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000547")]
		[Address(RVA = "0x2B27860", Offset = "0x2B25E60", VA = "0x182B27860")]
		public void Pickup()
		{
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000548")]
		[Address(RVA = "0x2B27B50", Offset = "0x2B26150", VA = "0x182B27B50")]
		public void Throw(Vector3 throwDir)
		{
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000549")]
		[Address(RVA = "0x2B27D80", Offset = "0x2B26380", VA = "0x182B27D80")]
		private void Detach(Vector3 throwDir)
		{
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600054A")]
		[Address(RVA = "0x2B280D0", Offset = "0x2B266D0", VA = "0x182B280D0")]
		private void GetTargets(out Vector3 targetPosition, out Quaternion targetRotation)
		{
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600054B")]
		[Address(RVA = "0x2B28440", Offset = "0x2B26A40", VA = "0x182B28440")]
		private void InitInteraction(VailActor actor)
		{
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600054C")]
		[Address(RVA = "0x2B28A90", Offset = "0x2B27090", VA = "0x182B28A90", Slot = "4")]
		public void BeginInteraction(VailActor actor, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600054D")]
		[Address(RVA = "0x2B28AF0", Offset = "0x2B270F0", VA = "0x182B28AF0", Slot = "5")]
		public void DoInteract(VailActor actor, float deltaTime, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600054E")]
		[Address(RVA = "0x2B28B00", Offset = "0x2B27100", VA = "0x182B28B00", Slot = "6")]
		public void EndInteraction(VailActor actor, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600054F")]
		[Address(RVA = "0x2B28B60", Offset = "0x2B27160", VA = "0x182B28B60")]
		private void SendPickupBodyEvent()
		{
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000550")]
		[Address(RVA = "0x2B28C90", Offset = "0x2B27290", VA = "0x182B28C90")]
		private void SendThrowBodyEvent(Vector3 throwDir)
		{
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000551")]
		[Address(RVA = "0x2B28ED0", Offset = "0x2B274D0", VA = "0x182B28ED0")]
		public void OnReceivedThrowBodyEvent(VailThrowBodyEvent evt)
		{
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000552")]
		[Address(RVA = "0x2B290B0", Offset = "0x2B276B0", VA = "0x182B290B0")]
		private void FindRigidBody()
		{
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000553")]
		[Address(RVA = "0x2B29120", Offset = "0x2B27720", VA = "0x182B29120")]
		public ThrowableBodyInteraction()
		{
		}

		// Token: 0x0400046F RID: 1135
		[Token(Token = "0x400046F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Rigidbody _ragdollRigidbody;

		// Token: 0x04000470 RID: 1136
		[Token(Token = "0x4000470")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _throwForce;

		// Token: 0x04000471 RID: 1137
		[Token(Token = "0x4000471")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _ragdollSectionName;

		// Token: 0x04000472 RID: 1138
		[Token(Token = "0x4000472")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Vector3 _positionOffset;

		// Token: 0x04000473 RID: 1139
		[Token(Token = "0x4000473")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Vector3 _rotationOffset;

		// Token: 0x04000474 RID: 1140
		[Token(Token = "0x4000474")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _snapTime;

		// Token: 0x04000475 RID: 1141
		[Token(Token = "0x4000475")]
		[FieldOffset(Offset = "0x58")]
		private VailActor _throwingActor;

		// Token: 0x04000476 RID: 1142
		[Token(Token = "0x4000476")]
		[FieldOffset(Offset = "0x60")]
		private Transform _handTransform;

		// Token: 0x04000477 RID: 1143
		[Token(Token = "0x4000477")]
		[FieldOffset(Offset = "0x68")]
		private Action _completedCallback;

		// Token: 0x04000478 RID: 1144
		[Token(Token = "0x4000478")]
		[FieldOffset(Offset = "0x70")]
		private bool _isPickedUp;

		// Token: 0x04000479 RID: 1145
		[Token(Token = "0x4000479")]
		[FieldOffset(Offset = "0x71")]
		private bool _hasBeenReparented;

		// Token: 0x0400047A RID: 1146
		[Token(Token = "0x400047A")]
		[FieldOffset(Offset = "0x74")]
		private float _interactionTimePassed;

		// Token: 0x0400047B RID: 1147
		[Token(Token = "0x400047B")]
		[FieldOffset(Offset = "0x78")]
		private Transform _snapTransform;

		// Token: 0x0400047C RID: 1148
		[Token(Token = "0x400047C")]
		[FieldOffset(Offset = "0x80")]
		private bool _needToPickup;

		// Token: 0x0400047D RID: 1149
		[Token(Token = "0x400047D")]
		[FieldOffset(Offset = "0x81")]
		private bool _needToThrow;

		// Token: 0x0400047E RID: 1150
		[Token(Token = "0x400047E")]
		[FieldOffset(Offset = "0x84")]
		private float _startFixedTime;

		// Token: 0x02000076 RID: 118
		[Token(Token = "0x2000076")]
		private enum ThrowBodyStage
		{
			// Token: 0x04000480 RID: 1152
			[Token(Token = "0x4000480")]
			Pickup,
			// Token: 0x04000481 RID: 1153
			[Token(Token = "0x4000481")]
			Throw
		}
	}
}
