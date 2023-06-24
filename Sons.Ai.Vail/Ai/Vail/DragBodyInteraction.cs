using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x02000071 RID: 113
	[Token(Token = "0x2000071")]
	[AddComponentMenu("Sons/Ai/Interact/Drag Body Interaction")]
	public class DragBodyInteraction : VailPhysicsInteraction, IVailActorInteract
	{
		// Token: 0x06000525 RID: 1317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000525")]
		[Address(RVA = "0x2B22CA0", Offset = "0x2B212A0", VA = "0x182B22CA0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000526")]
		[Address(RVA = "0x2B22FB0", Offset = "0x2B215B0", VA = "0x182B22FB0")]
		public void OnAttach(VailActor vailActor)
		{
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000527")]
		[Address(RVA = "0x2B231C0", Offset = "0x2B217C0", VA = "0x182B231C0")]
		private void Detach()
		{
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000528")]
		[Address(RVA = "0x2B23230", Offset = "0x2B21830", VA = "0x182B23230")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000529")]
		[Address(RVA = "0x2B23480", Offset = "0x2B21A80", VA = "0x182B23480", Slot = "4")]
		public void BeginInteraction(VailActor vailActor, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600052A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "5")]
		public void DoInteract(VailActor vailActor, float deltaTime, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600052B")]
		[Address(RVA = "0x2B231C0", Offset = "0x2B217C0", VA = "0x182B231C0", Slot = "6")]
		public void EndInteraction(VailActor vailActor, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600052C")]
		[Address(RVA = "0x2B23510", Offset = "0x2B21B10", VA = "0x182B23510")]
		public DragBodyInteraction()
		{
		}

		// Token: 0x04000444 RID: 1092
		[Token(Token = "0x4000444")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Rigidbody _ragdollRigidbody;

		// Token: 0x04000445 RID: 1093
		[Token(Token = "0x4000445")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _attachLerpTime;

		// Token: 0x04000446 RID: 1094
		[Token(Token = "0x4000446")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Vector3 _localOffset;

		// Token: 0x04000447 RID: 1095
		[Token(Token = "0x4000447")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 _startPosition;

		// Token: 0x04000448 RID: 1096
		[Token(Token = "0x4000448")]
		[FieldOffset(Offset = "0x48")]
		private Transform _handTransform;

		// Token: 0x04000449 RID: 1097
		[Token(Token = "0x4000449")]
		[FieldOffset(Offset = "0x50")]
		private bool _isAttached;

		// Token: 0x0400044A RID: 1098
		[Token(Token = "0x400044A")]
		[FieldOffset(Offset = "0x54")]
		private float _attachFixedTime;
	}
}
