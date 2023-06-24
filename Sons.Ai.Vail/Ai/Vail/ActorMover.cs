using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x0200001F RID: 31
	[Token(Token = "0x200001F")]
	public class ActorMover : MonoBehaviour
	{
		// Token: 0x060000AB RID: 171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x5F2110", Offset = "0x5F0710", VA = "0x1805F2110")]
		public void SetActive(bool newActive)
		{
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000024D8 File Offset: 0x000006D8
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x2AF3F20", Offset = "0x2AF2520", VA = "0x182AF3F20")]
		public bool UpdateMoveDelta(Transform tr, Vector3 position, ref Vector3 moveDelta)
		{
			return default(bool);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x2AF40E0", Offset = "0x2AF26E0", VA = "0x182AF40E0")]
		private void StayAboveGround(ref Vector3 position)
		{
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x2AF4340", Offset = "0x2AF2940", VA = "0x182AF4340")]
		private void PushBackSphere(Transform tr, ref Vector3 position)
		{
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000024F0 File Offset: 0x000006F0
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x2AF49F0", Offset = "0x2AF2FF0", VA = "0x182AF49F0")]
		private bool CheckSphereMove(Transform tr, ref Vector3 moveDelta)
		{
			return default(bool);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x2AF4CF0", Offset = "0x2AF32F0", VA = "0x182AF4CF0")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x2AF5490", Offset = "0x2AF3A90", VA = "0x182AF5490")]
		public ActorMover()
		{
		}

		// Token: 0x040000B4 RID: 180
		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _sphereRadius;

		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Vector3 _center;

		// Token: 0x040000B6 RID: 182
		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Vector3 _sphereCenter;

		// Token: 0x040000B7 RID: 183
		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _height;

		// Token: 0x040000B8 RID: 184
		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _pushBack;

		// Token: 0x040000B9 RID: 185
		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x41")]
		[SerializeField]
		private bool _checkSphereForwards;

		// Token: 0x040000BA RID: 186
		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x42")]
		[SerializeField]
		private bool _stayAboveGround;

		// Token: 0x040000BB RID: 187
		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x43")]
		[SerializeField]
		private bool _showGizmos;

		// Token: 0x040000BC RID: 188
		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x44")]
		private Vector3 _lastPushVec;

		// Token: 0x040000BD RID: 189
		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x50")]
		private bool _active;

		// Token: 0x040000BE RID: 190
		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x54")]
		private int _layerMask;

		// Token: 0x040000BF RID: 191
		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x58")]
		private Vector3 _lastTraceStart;

		// Token: 0x040000C0 RID: 192
		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x64")]
		private Vector3 _lastTraceEnd;
	}
}
