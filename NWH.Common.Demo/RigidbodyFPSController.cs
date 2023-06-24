using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NWH.Common.Demo
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(CapsuleCollider))]
	public class RigidbodyFPSController : MonoBehaviour
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00002080 File Offset: 0x00000280
		[Token(Token = "0x17000001")]
		private bool PointerOverUI
		{
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x26EBF00", Offset = "0x26EA500", VA = "0x1826EBF00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x26EBF60", Offset = "0x26EA560", VA = "0x1826EBF60")]
		private void Awake()
		{
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x26EC090", Offset = "0x26EA690", VA = "0x1826EC090")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x26EC850", Offset = "0x26EAE50", VA = "0x1826EC850")]
		private float CalculateJumpVerticalSpeed()
		{
			return 0f;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x71EE50", Offset = "0x71D450", VA = "0x18071EE50")]
		private void OnCollisionStay()
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x26EC880", Offset = "0x26EAE80", VA = "0x1826EC880")]
		public RigidbodyFPSController()
		{
		}

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x20")]
		public float gravity;

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x24")]
		public float jumpHeight;

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x28")]
		public float maximumY;

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x2C")]
		public float maxVelocityChange;

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x30")]
		public float minimumY;

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x34")]
		public float sensitivityX;

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x38")]
		public float sensitivityY;

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x3C")]
		public float speed;

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x40")]
		private bool _grounded;

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x48")]
		private Rigidbody _rb;

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x50")]
		private float _rotationY;

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x54")]
		private Vector2 _movement;

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x5C")]
		private Vector2 _cameraRotationInput;
	}
}
