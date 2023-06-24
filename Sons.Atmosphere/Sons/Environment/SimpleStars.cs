using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Environment
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	public class SimpleStars : TimeOfDayBehaviour
	{
		// Token: 0x06000045 RID: 69 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x2D32810", Offset = "0x2D30E10", VA = "0x182D32810")]
		private void OnEnable()
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x2D328D0", Offset = "0x2D30ED0", VA = "0x182D328D0", Slot = "8")]
		public override void UpdateTime(TimeOfDay time, TimeOfDay realTime)
		{
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x2D33060", Offset = "0x2D31660", VA = "0x182D33060")]
		public SimpleStars()
		{
		}

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _starTransform;

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _latitude;

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float _longitude;

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x48")]
		private bool _isConfigured;

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int TOD_World2SkyPID;

		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int TOD_Sky2WorldPID;
	}
}
