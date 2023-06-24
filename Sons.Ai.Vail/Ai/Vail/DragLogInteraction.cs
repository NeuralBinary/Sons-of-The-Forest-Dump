using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Animations;

namespace Sons.Ai.Vail
{
	// Token: 0x02000072 RID: 114
	[Token(Token = "0x2000072")]
	[AddComponentMenu("Sons/Ai/Interact/DragLogInteraction")]
	public class DragLogInteraction : VailPhysicsInteraction, IVailActorInteract
	{
		// Token: 0x0600052D RID: 1325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600052D")]
		[Address(RVA = "0x2612770", Offset = "0x2610D70", VA = "0x182612770")]
		private void Start()
		{
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600052E")]
		[Address(RVA = "0x2B235A0", Offset = "0x2B21BA0", VA = "0x182B235A0")]
		private void Update()
		{
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600052F")]
		[Address(RVA = "0x2B23870", Offset = "0x2B21E70", VA = "0x182B23870")]
		private void ResetVars()
		{
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000530")]
		[Address(RVA = "0x2B23890", Offset = "0x2B21E90", VA = "0x182B23890")]
		private void CheckDragDelay()
		{
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000531")]
		[Address(RVA = "0x2B23B10", Offset = "0x2B22110", VA = "0x182B23B10")]
		private void CheckJointDelay()
		{
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000532")]
		[Address(RVA = "0x2B23C70", Offset = "0x2B22270", VA = "0x182B23C70")]
		private void CheckDropDelay()
		{
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x00004740 File Offset: 0x00002940
		[Token(Token = "0x6000533")]
		[Address(RVA = "0x2B23DF0", Offset = "0x2B223F0", VA = "0x182B23DF0")]
		private bool CheckDelay(ref float start, float delay)
		{
			return default(bool);
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000534")]
		[Address(RVA = "0x2B23E70", Offset = "0x2B22470", VA = "0x182B23E70")]
		private void CreateConstraints()
		{
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000535")]
		[Address(RVA = "0x2B246C0", Offset = "0x2B22CC0", VA = "0x182B246C0")]
		private void DisableConstraints()
		{
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000536")]
		[Address(RVA = "0x2B24A90", Offset = "0x2B23090", VA = "0x182B24A90")]
		private Rigidbody CreateRigidBodyAttachmentPoint(Transform targetTr)
		{
			return null;
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000537")]
		[Address(RVA = "0x2B24C80", Offset = "0x2B23280", VA = "0x182B24C80")]
		private CharacterJoint CreatePhysicsJoint(Rigidbody connectedBody)
		{
			return null;
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000538")]
		[Address(RVA = "0x2B25240", Offset = "0x2B23840", VA = "0x182B25240")]
		private void SavePhysicsMaterial()
		{
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000539")]
		[Address(RVA = "0x2B25380", Offset = "0x2B23980", VA = "0x182B25380")]
		private void SetPhysicsMaterial(PhysicMaterial newMaterial)
		{
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600053A")]
		[Address(RVA = "0x2B25460", Offset = "0x2B23A60", VA = "0x182B25460")]
		public void IgnoreActorCollision(VailActor vailActor)
		{
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600053B")]
		[Address(RVA = "0x2B25500", Offset = "0x2B23B00", VA = "0x182B25500", Slot = "4")]
		public void BeginInteraction(VailActor vailActor, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600053C")]
		[Address(RVA = "0x2B25750", Offset = "0x2B23D50", VA = "0x182B25750", Slot = "5")]
		public void DoInteract(VailActor vailActor, float deltaTime, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600053D")]
		[Address(RVA = "0x2B25D20", Offset = "0x2B24320", VA = "0x182B25D20", Slot = "6")]
		public void EndInteraction(VailActor vailActor, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600053E")]
		[Address(RVA = "0x2B25D90", Offset = "0x2B24390", VA = "0x182B25D90")]
		public DragLogInteraction()
		{
		}

		// Token: 0x0400044B RID: 1099
		[Token(Token = "0x400044B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _speed;

		// Token: 0x0400044C RID: 1100
		[Token(Token = "0x400044C")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _aimSpeed;

		// Token: 0x0400044D RID: 1101
		[Token(Token = "0x400044D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _delayDrag;

		// Token: 0x0400044E RID: 1102
		[Token(Token = "0x400044E")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _delayJoint;

		// Token: 0x0400044F RID: 1103
		[Token(Token = "0x400044F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _delayDrop;

		// Token: 0x04000450 RID: 1104
		[Token(Token = "0x4000450")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _offset;

		// Token: 0x04000451 RID: 1105
		[Token(Token = "0x4000451")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _offsetY;

		// Token: 0x04000452 RID: 1106
		[Token(Token = "0x4000452")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Vector3 _jointSwingAxis;

		// Token: 0x04000453 RID: 1107
		[Token(Token = "0x4000453")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _grabPoint;

		// Token: 0x04000454 RID: 1108
		[Token(Token = "0x4000454")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Vector3 _aimAxis;

		// Token: 0x04000455 RID: 1109
		[Token(Token = "0x4000455")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private PhysicMaterial _dragPhysicsMaterial;

		// Token: 0x04000456 RID: 1110
		[Token(Token = "0x4000456")]
		[FieldOffset(Offset = "0x68")]
		private PositionConstraint _posConstraint;

		// Token: 0x04000457 RID: 1111
		[Token(Token = "0x4000457")]
		[FieldOffset(Offset = "0x70")]
		private AimConstraint _aimConstraint;

		// Token: 0x04000458 RID: 1112
		[Token(Token = "0x4000458")]
		[FieldOffset(Offset = "0x78")]
		private float _startDrag;

		// Token: 0x04000459 RID: 1113
		[Token(Token = "0x4000459")]
		[FieldOffset(Offset = "0x7C")]
		private float _startDrop;

		// Token: 0x0400045A RID: 1114
		[Token(Token = "0x400045A")]
		[FieldOffset(Offset = "0x80")]
		private float _startJoint;

		// Token: 0x0400045B RID: 1115
		[Token(Token = "0x400045B")]
		[FieldOffset(Offset = "0x88")]
		private Transform _targetTransform;

		// Token: 0x0400045C RID: 1116
		[Token(Token = "0x400045C")]
		[FieldOffset(Offset = "0x90")]
		private Transform _aimTarget;

		// Token: 0x0400045D RID: 1117
		[Token(Token = "0x400045D")]
		[FieldOffset(Offset = "0x98")]
		private CharacterJoint _joint;

		// Token: 0x0400045E RID: 1118
		[Token(Token = "0x400045E")]
		[FieldOffset(Offset = "0xA0")]
		private PhysicMaterial _oldPhysicMaterial;
	}
}
