using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x020000C2 RID: 194
	[Token(Token = "0x20000C2")]
	[AddComponentMenu("Sons/Ai/VailObjectThrower")]
	public class VailObjectThrower : MonoBehaviour, IVailWeapon
	{
		// Token: 0x0600078B RID: 1931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600078B")]
		[Address(RVA = "0x2B557C0", Offset = "0x2B53DC0", VA = "0x182B557C0")]
		public void ShowHeld()
		{
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600078C")]
		[Address(RVA = "0x2B558D0", Offset = "0x2B53ED0", VA = "0x182B558D0")]
		public void HideHeld()
		{
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600078D")]
		[Address(RVA = "0x2B559E0", Offset = "0x2B53FE0", VA = "0x182B559E0", Slot = "4")]
		private void Shoot(Vector3 targetPos, Vector3 targetVel, Vector3 forwardDir)
		{
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600078E")]
		[Address(RVA = "0x2B56050", Offset = "0x2B54650", VA = "0x182B56050")]
		public VailObjectThrower()
		{
		}

		// Token: 0x040005F6 RID: 1526
		[Token(Token = "0x40005F6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _objectPrefab;

		// Token: 0x040005F7 RID: 1527
		[Token(Token = "0x40005F7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _speed;

		// Token: 0x040005F8 RID: 1528
		[Token(Token = "0x40005F8")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Vector2 _rotateSpeed;

		// Token: 0x040005F9 RID: 1529
		[Token(Token = "0x40005F9")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Vector2 _verticalAdjust;

		// Token: 0x040005FA RID: 1530
		[Token(Token = "0x40005FA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _heldObject;

		// Token: 0x040005FB RID: 1531
		[Token(Token = "0x40005FB")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _maxAngleDiff;
	}
}
