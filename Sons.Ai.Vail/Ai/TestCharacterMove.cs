using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai
{
	// Token: 0x0200001C RID: 28
	[Token(Token = "0x200001C")]
	[AddComponentMenu("Sons/Utilities/TestCharacterMove")]
	public class TestCharacterMove : MonoBehaviour
	{
		// Token: 0x060000A2 RID: 162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x2AF38D0", Offset = "0x2AF1ED0", VA = "0x182AF38D0")]
		private void OnValidate()
		{
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x2AF3960", Offset = "0x2AF1F60", VA = "0x182AF3960")]
		private void Start()
		{
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x2AF3A30", Offset = "0x2AF2030", VA = "0x182AF3A30")]
		private void Update()
		{
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x2AF3C90", Offset = "0x2AF2290", VA = "0x182AF3C90")]
		private void ResetPosition()
		{
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x2AF3D50", Offset = "0x2AF2350", VA = "0x182AF3D50")]
		public TestCharacterMove()
		{
		}

		// Token: 0x040000AD RID: 173
		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _downSpeed;

		// Token: 0x040000AE RID: 174
		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _forwardSpeed;

		// Token: 0x040000AF RID: 175
		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CharacterController _characterController;

		// Token: 0x040000B0 RID: 176
		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 _startPosition;
	}
}
