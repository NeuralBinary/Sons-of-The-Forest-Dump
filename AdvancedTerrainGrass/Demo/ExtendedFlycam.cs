using System;
using Il2CppDummyDll;
using UnityEngine;

namespace AdvancedTerrainGrass.Demo
{
	// Token: 0x02000014 RID: 20
	[Token(Token = "0x2000014")]
	public class ExtendedFlycam : MonoBehaviour
	{
		// Token: 0x06000039 RID: 57 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x5B0F80", Offset = "0x5AF580", VA = "0x1805B0F80")]
		private void Start()
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x5B1060", Offset = "0x5AF660", VA = "0x1805B1060")]
		private void Update()
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x5B24E0", Offset = "0x5B0AE0", VA = "0x1805B24E0")]
		public ExtendedFlycam()
		{
		}

		// Token: 0x04000163 RID: 355
		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x20")]
		public float cameraSensitivity;

		// Token: 0x04000164 RID: 356
		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0x24")]
		public float climbSpeed;

		// Token: 0x04000165 RID: 357
		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x28")]
		public float normalMoveSpeed;

		// Token: 0x04000166 RID: 358
		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x2C")]
		public float slowMoveFactor;

		// Token: 0x04000167 RID: 359
		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x30")]
		public float fastMoveFactor;

		// Token: 0x04000168 RID: 360
		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x34")]
		private float rotationX;

		// Token: 0x04000169 RID: 361
		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x38")]
		private float rotationY;
	}
}
